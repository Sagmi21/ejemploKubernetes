FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build-env
WORKDIR /app
COPY . ./
RUN dotnet restore "/app/Axity.Project.ServiceName.Api/Axity.Project.ServiceName.Api.csproj"
COPY . ./
RUN dotnet publish "/app/Axity.Project.ServiceName.Api/Axity.Project.ServiceName.Api.csproj" -c Release -o out

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
RUN apt-get update
RUN apt-get install -y libgdiplus
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "Axity.Project.ServiceName.Api.dll"]