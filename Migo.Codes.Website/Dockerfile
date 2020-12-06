#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY ["Migo.Codes.Website/Migo.Codes.Website.csproj", "Migo.Codes.Website/"]
RUN dotnet restore "Migo.Codes.Website/Migo.Codes.Website.csproj"
COPY . .
WORKDIR "/src/Migo.Codes.Website"
RUN dotnet build "Migo.Codes.Website.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Migo.Codes.Website.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Migo.Codes.Website.dll"]