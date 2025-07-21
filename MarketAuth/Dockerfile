# market auth dockerfile

# Stage 1: Build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Critical change - use absolute path and rename during copy
COPY ["MarketAuth.csproj", "/src/MarketAuth.csproj"]
RUN dotnet restore "/src/MarketAuth.csproj"

# Copy remaining files
COPY . .
RUN dotnet build "/src/MarketAuth.csproj" -c Release -o /app/build

# Stage 2: Publish
FROM build AS publish
RUN dotnet publish "/src/MarketAuth.csproj" -c Release -o /app/publish /p:UseAppHost=false

# Stage 3: Runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MarketAuth.dll"]

EXPOSE 80
