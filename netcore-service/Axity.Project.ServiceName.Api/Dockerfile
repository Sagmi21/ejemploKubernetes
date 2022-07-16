FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build-env
WORKDIR /app

# Copy csproj and restore as distinct layers
COPY . ./
RUN dotnet restore "app/Axity.Project.ServiceName.Api/Axity.Project.ServiceName.Api.csproj"

# Copy everything else and build
COPY . ./
RUN dotnet publish "app/Axity.Project.ServiceName.Api/Axity.Project.ServiceName.Api.csproj" -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
RUN apt-get update
RUN apt-get install -y libgdiplus
ENV ASPNETCORE_ENVIRONMENT=Development
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "Axity.Project.ServiceName.Api.dll"]