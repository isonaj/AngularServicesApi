FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["AngularServicesApi/AngularServicesApi.csproj", "AngularServicesApi/"]
RUN dotnet restore "AngularServicesApi/AngularServicesApi.csproj"
COPY . .
WORKDIR "/src/AngularServicesApi"
RUN dotnet build "AngularServicesApi.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "AngularServicesApi.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "AngularServicesApi.dll"]