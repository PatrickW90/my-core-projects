FROM microsoft/aspnetcore:1.1 AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/aspnetcore-build:1.1 AS build
WORKDIR /src
COPY TestAppNetCore/TestAppNetCore.csproj TestAppNetCore/
RUN dotnet restore TestAppNetCore/TestAppNetCore.csproj
COPY . .
WORKDIR /src/TestAppNetCore
RUN dotnet build TestAppNetCore.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish TestAppNetCore.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "testappnetcore.dll"]
