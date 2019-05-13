FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-stretch AS build
WORKDIR /src
COPY ["IKMController/IKMController.csproj", "IKMController/"]
RUN dotnet restore "IKMController/IKMController.csproj"
COPY . .
WORKDIR "/src/IKMController"
RUN dotnet build "IKMController.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "IKMController.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "IKMController.dll"]