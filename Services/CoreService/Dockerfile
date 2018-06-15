FROM microsoft/aspnetcore:2.0-nanoserver-sac2016 AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/aspnetcore-build:2.0-nanoserver-sac2016 AS build
WORKDIR /src
COPY Services/CoreService/CoreService.csproj Services/CoreService/
RUN dotnet restore Services/CoreService/CoreService.csproj
COPY . .
WORKDIR /src/Services/CoreService
RUN dotnet build CoreService.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish CoreService.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "CoreService.dll"]
