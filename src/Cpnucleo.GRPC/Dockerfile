FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base

LABEL maintainer "Jonathan Peris"

USER app
WORKDIR /app

EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR /src

COPY ["src/Cpnucleo.GRPC/Cpnucleo.GRPC.csproj", "src/Cpnucleo.GRPC/"]
COPY ["src/Cpnucleo.Application/Cpnucleo.Application.csproj", "src/Cpnucleo.Application/"]
COPY ["src/Cpnucleo.Domain/Cpnucleo.Domain.csproj", "src/Cpnucleo.Domain/"]
COPY ["src/Cpnucleo.Infrastructure/Cpnucleo.Infrastructure.csproj", "src/Cpnucleo.Infrastructure/"]

RUN dotnet restore "src/Cpnucleo.GRPC/Cpnucleo.GRPC.csproj"

COPY . .

WORKDIR "/src/src/Cpnucleo.GRPC"

RUN dotnet build "Cpnucleo.GRPC.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Cpnucleo.GRPC.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final

WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Cpnucleo.GRPC.dll"]