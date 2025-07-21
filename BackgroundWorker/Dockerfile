# BackgroundWorker Dockerfile

# Stage 1: Build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy only the .csproj files first (for faster restore)
COPY ["BackgroundWorker/BackgroundWorker.csproj", "BackgroundWorker/"]
COPY ["MarketService/MarketService.csproj", "MarketService/"]

# Restore dependencies
RUN dotnet restore "BackgroundWorker/BackgroundWorker.csproj"

# Copy the full source code for both projects
COPY . .

# Build the BackgroundWorker project
WORKDIR /src/BackgroundWorker
RUN dotnet build -c Release -o /app/build

# Stage 2: Publish
FROM build AS publish
RUN dotnet publish "BackgroundWorker.csproj" -c Release -o /app/publish /p:UseAppHost=false

# Stage 3: Runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=publish /app/publish .

ENTRYPOINT ["dotnet", "BackgroundWorker.dll"]
EXPOSE 8080
