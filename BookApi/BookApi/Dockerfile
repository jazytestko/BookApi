FROM mcr.microsoft.com/dotnet/core/aspnet:2.1-stretch-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:2.1-stretch AS build
WORKDIR /src
COPY ["BookApi/BookApi.csproj", "BookApi/"]
RUN dotnet restore "BookApi/BookApi.csproj"
COPY . .
WORKDIR "/src/BookApi"
RUN dotnet build "BookApi.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "BookApi.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "BookApi.dll"]