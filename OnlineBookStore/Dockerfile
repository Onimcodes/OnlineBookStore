#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["OnlineBookStore/OnlineBookStore.Api.csproj", "OnlineBookStore/"]
COPY ["OnlineBookStore.Entity/OnlineBookStore.Entity.csproj", "OnlineBookStore.Entity/"]
RUN dotnet restore "OnlineBookStore/OnlineBookStore.Api.csproj"
COPY . .
WORKDIR "/src/OnlineBookStore"
RUN dotnet build "OnlineBookStore.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "OnlineBookStore.Api.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "OnlineBookStore.Api.dll"]