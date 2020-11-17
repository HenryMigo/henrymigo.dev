FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build-env
WORKDIR /MigoCodes

COPY ["Migo.Codes.Website.csproj", ""]
RUN dotnet restore "./Migo.Codes.Website.csproj"

COPY . .
RUN dotnet build "Migo.Codes.Website.csproj" -c Release -o /build

FROM build-env AS publish
RUN dotnet publish "Migo.Codes.Website.csproj" -c Release -o /publish

FROM nginx:alpine AS final
WORKDIR /usr/share/nginx/html

COPY --from=publish /publish/wwwroot /usr/local/migocodes/nginx/html
COPY nginx.conf /etc/nginx/nginx.conf