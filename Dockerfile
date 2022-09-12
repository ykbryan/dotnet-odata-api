FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 443
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["dotnet-odata-api.csproj", "./"]
RUN dotnet restore "./dotnet-odata-api.csproj"
COPY . .
RUN dotnet build "dotnet-odata-api.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "dotnet-odata-api.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "dotnet-odata-api.dll"]