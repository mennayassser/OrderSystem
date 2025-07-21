
# market service dockerfile

#Stage 1: Build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Critical change - use absolute path and rename during copy
COPY ["MarketService.csproj", "/src/MarketService.csproj"]
RUN dotnet restore "/src/MarketService.csproj"

# Copy remaining files
COPY . .
RUN dotnet build "/src/MarketService.csproj" -c Release -o /app/build

# Stage 2: Publish
FROM build AS publish
RUN dotnet publish "/src/MarketService.csproj" -c Release -o /app/publish /p:UseAppHost=false

# Stage 3: Runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MarketService.dll"]


EXPOSE 85