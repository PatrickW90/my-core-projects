FROM microsoft/aspnetcore:2.0 AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/aspnetcore-build:2.0 AS build
WORKDIR /src
COPY testapp/testapp.csproj testapp/
RUN dotnet restore testapp/testapp.csproj
COPY . .
WORKDIR /src/testapp
RUN dotnet build testapp.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish testapp.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "testapp.dll"]
