# MyVivaDemo

A small demo of an Unreal 4.25 AR app communicating with an ASP.NET REST API.

## Instructions for running the API
1. Install the dotnet 5 sdk (https://docs.microsoft.com/en-us/dotnet/core/install/)
2. Download the ef core tools `dotnet tool install --global dotnet-ef`
2. In UnrealServer/Startup.cs line 28, change the connection string to point to your desired location for the databse.
3. Run `dotnet ef database update` 
4. Run `dotnet run` in UnrealServer/
