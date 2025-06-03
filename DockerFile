FROM mcr.microsoft.com/dotnet/aspnet:8.0

WORKDIR /app

COPY . .

# Build the app
RUN dotnet build --configuration Release

# Start the application
CMD ["dotnet", "run"]
