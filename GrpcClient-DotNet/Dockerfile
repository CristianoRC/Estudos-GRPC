FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["../GrpcClient-DotNet/GrpcClient-DotNet.csproj", "GrpcClient-DotNet/"]
RUN dotnet restore "../GrpcClient-DotNet/GrpcClient-DotNet.csproj"
COPY . .
WORKDIR "/src/GrpcClient-DotNet"
RUN dotnet build "GrpcClient-DotNet.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "GrpcClient-DotNet.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "GrpcClient-DotNet.dll"]
