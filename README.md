# NASA Image of the Day Viewer

A full-stack web application that fetches and displays the daily "Astronomy Picture of the Day" (APOD) from NASA's public API. The frontend is built with React and Vite, and the backend is a lightweight ASP.NET Core API that securely handles communication with the NASA service.

---

## Features

- **Dynamic Content**: Automatically fetches and displays the latest image or video of the day from NASA.
- **Immersive UI**: Features a "glassmorphism" card design with a blurred, dynamic background generated from the daily image for a stunning visual experience.
- **Secure Backend Proxy**: The ASP.NET Core backend securely manages the NASA API key, which is never exposed to the client.
- **Responsive Design**: The frontend is fully responsive and looks great on both desktop and mobile devices.
- **Strongly-Typed API Communication**: Uses C# models on the backend and async/await on the frontend for robust and predictable data handling.

---

## Technology Stack

| Area      | Technology                                    |
|-----------|-----------------------------------------------|
| **Frontend**  | React, Vite, JavaScript (ES6+), CSS3          |
| **Backend**   | .NET 8, ASP.NET Core Minimal API, C#          |
| **Tooling**   | Node.js, npm, .NET CLI, User Secrets Manager  |

---

## Project Structure

The project is organized into two main parts:

- **/server**: The ASP.NET Core backend API. It handles fetching data from the NASA API.
- **/client/nasa_daily_image**: The React frontend application that displays the data.

---

## Setup and Installation

To run this project, you will need [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) and [Node.js](https://nodejs.org/) (which includes npm) installed.

### 1. Backend Setup (API Key)

The backend requires a NASA API key. You can generate a free key at [api.nasa.gov](https://api.nasa.gov/).

Once you have your key, configure it using the .NET Secret Manager. This keeps your key secure and out of the source code.

```bash
# Navigate to the server directory from the project root
cd server

# Initialize user secrets for the project
dotnet user-secrets init

# Set your NASA API key (replace YOUR_KEY_HERE)
dotnet user-secrets set "NasaApiKey" "YOUR_KEY_HERE"
```

### 2. Frontend Setup (Dependencies)

Install the necessary Node.js packages for the React application.

```bash
# Navigate to the client directory from the project root
cd client/nasa_daily_image

# Install dependencies
npm install
```

---

## Running the Application

You will need to run two processes in separate terminals: one for the backend server and one for the frontend client.

### Terminal 1: Run the Backend

```bash
# Navigate to the server directory
cd server

# Run the .NET server
dotnet run
```
The API will start, typically on a port like `5036`.

### Terminal 2: Run the Frontend

```bash
# Navigate to the client directory
cd client/nasa_daily_image

# Run the Vite development server
npm run dev
```
The React app will start, typically on port `5173`, and will open automatically in your browser. It is configured to make requests to the backend API.
