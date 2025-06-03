FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copy only the project file first
COPY src/InputCounterAPI/InputCounterAPI.csproj ./

# Restore dependencies
RUN dotnet restore InputCounterAPI.csproj

# Copy the rest of the files
COPY . .

# Build the project
RUN dotnet build --configuration Release

# Run the application
CMD ["dotnet", "run"]
