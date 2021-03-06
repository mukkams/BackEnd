#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["ProcessFlowAPI/ProcessFlowAPI.csproj", "ProcessFlowAPI/"]
COPY ["Application/Application.csproj", "Application/"]
COPY ["Domain/Domain.csproj", "Domain/"]
COPY ["Persistence/Persistence.csproj", "Persistence/"]
RUN dotnet restore "ProcessFlowAPI/ProcessFlowAPI.csproj"
COPY . .
WORKDIR "/src/ProcessFlowAPI"
RUN dotnet build "ProcessFlowAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ProcessFlowAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ProcessFlowAPI.dll"]