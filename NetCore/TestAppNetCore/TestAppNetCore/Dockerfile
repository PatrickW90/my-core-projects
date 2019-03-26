FROM microsoft/aspnetcore:1.1 AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/aspnetcore-build:1.1 AS build
WORKDIR /src
COPY testappnetcore/testappnetcore.csproj testappnetcore/
RUN dotnet restore testappnetcore/testappnetcore.csproj
COPY . .
WORKDIR /src/testappnetcore
RUN dotnet build testappnetcore.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish testappnetcore.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "testappnetcore.dll"]
