using System.Text.Json;
using server.Models;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddOpenApi();
builder.Services.AddCors(options => {
    options.AddDefaultPolicy(policy => {
        policy.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin();
    });
});
builder.Services.AddHttpClient();

var app = builder.Build();
app.UseCors();



app.MapGet("/api/getImage", async (IHttpClientFactory HttpClientFactory, IConfiguration Configuration) => {
    var api_key = Configuration["NASA_API_KEY"];
    if(string.IsNullOrEmpty(api_key)){
        return Results.Problem("API KEY missing");
    }
    var api_url = $"https://api.nasa.gov/planetary/apod?api_key={api_key}";

    var client = HttpClientFactory.CreateClient();

    var requestMessage = new HttpRequestMessage(HttpMethod.Get, api_url);

    var response = await client.SendAsync(requestMessage);
    response.EnsureSuccessStatusCode();

    var jsonString = await response.Content.ReadAsStringAsync();
    var apiObject = JsonSerializer.Deserialize<NasaResponse>(jsonString);

    return Results.Ok(apiObject);
});



app.Run();



