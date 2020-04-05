#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
#EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["Test Async .Net Core Website/Test Async .Net Core Website.csproj", "Test Async .Net Core Website/"]
RUN dotnet restore "Test Async .Net Core Website/Test Async .Net Core Website.csproj"
COPY . .
WORKDIR "/src/Test Async .Net Core Website"
RUN dotnet build "Test Async .Net Core Website.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Test Async .Net Core Website.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Test Async .Net Core Website.dll"]