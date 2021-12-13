#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["All-In-1 Planning/All-In-1 Planning.csproj", "All-In-1 Planning/"]
RUN dotnet restore "All-In-1 Planning/All-In-1 Planning.csproj"
COPY . .
WORKDIR "/src/All-In-1 Planning"
RUN dotnet build "All-In-1 Planning.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "All-In-1 Planning.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "All-In-1 Planning.dll"]