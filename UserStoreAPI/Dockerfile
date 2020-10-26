#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["UserStoreAPI/UserStoreAPI.csproj", "UserStoreAPI/"]
COPY ["Application/Application.csproj", "Application/"]
COPY ["Domain/Domain.csproj", "Domain/"]
COPY ["Persistence/Persistence.csproj", "Persistence/"]
RUN dotnet restore "UserStoreAPI/UserStoreAPI.csproj"
COPY . .
WORKDIR "/src/UserStoreAPI"
RUN dotnet build "UserStoreAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "UserStoreAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "UserStoreAPI.dll"]