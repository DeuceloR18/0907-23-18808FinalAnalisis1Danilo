FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
WORKDIR /app
EXPOSE 8080

FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src
COPY ["ApiNetguardgt/ApiNetguardgt.csproj", "ApiNetguardgt/"]
RUN dotnet restore "ApiNetguardgt/ApiNetguardgt.csproj"
COPY . .
WORKDIR "/src/ApiNetguardgt"
RUN dotnet build "ApiNetguardgt.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ApiNetguardgt.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ApiNetguardgt.dll"]FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
WORKDIR /app
EXPOSE 8080

FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src
COPY ["ApiNetguardgt/ApiNetguardgt.csproj", "ApiNetguardgt/"]
RUN dotnet restore "ApiNetguardgt/ApiNetguardgt.csproj"
COPY . .
WORKDIR "/src/ApiNetguardgt"
RUN dotnet build "ApiNetguardgt.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ApiNetguardgt.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ApiNetguardgt.dll"]