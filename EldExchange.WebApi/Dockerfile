#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443
ARG CONNECTIONSTRING_ELDEXCHANGE

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["EldExchange.WebApi/EldExchange.WebApi.csproj", "EldExchange.WebApi/"]
COPY ["EldExchange.CrossCutting/EldExchange.CrossCutting.csproj", "EldExchange.CrossCutting/"]
COPY ["EldExchange.Domain/EldExchange.Domain.csproj", "EldExchange.Domain/"]
COPY ["EldExchange.Infra/EldExchange.Infra.csproj", "EldExchange.Infra/"]
RUN dotnet restore "EldExchange.WebApi/EldExchange.WebApi.csproj"
COPY . .
WORKDIR "/src/EldExchange.WebApi"
RUN dotnet build "EldExchange.WebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "EldExchange.WebApi.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "EldExchange.WebApi.dll"]