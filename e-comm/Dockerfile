#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["e-comm/e-comm.csproj", "e-comm/"]
RUN dotnet restore "e-comm/e-comm.csproj"
COPY . .
WORKDIR "/src/e-comm"
RUN dotnet build "e-comm.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "e-comm.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "e-comm.dll"]