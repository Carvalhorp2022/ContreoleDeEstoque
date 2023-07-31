FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["ContreoleDeEstoque/ContreoleDeEstoque.csproj", "ContreoleDeEstoque/"]
RUN dotnet restore "ContreoleDeEstoque/ContreoleDeEstoque.csproj"
COPY . .
WORKDIR "/src/ContreoleDeEstoque"
RUN dotnet build "ContreoleDeEstoque.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ContreoleDeEstoque.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ContreoleDeEstoque.dll"]
