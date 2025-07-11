using System.Text.Json.Serialization;

namespace server.Models;

public class NasaResponse{
    [JsonPropertyName("date")]
    public string Date {get; set;}

    [JsonPropertyName("url")]
    public string Url {get; set;}

    [JsonPropertyName("explanation")]
    public string Explanation {get; set;}

    [JsonPropertyName("title")]
    public string Title {get; set;}
}