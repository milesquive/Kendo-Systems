FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-stretch AS build
WORKDIR /src
COPY ["IKMDatabase/IKMDatabase.csproj", "IKMDatabase/"]
RUN dotnet restore "IKMDatabase/IKMDatabase.csproj"
COPY . .
WORKDIR "/src/IKMDatabase"
RUN dotnet build "IKMDatabase.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "IKMDatabase.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "IKMDatabase.dll"]