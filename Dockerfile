FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env
WORKDIR /GoldenCrown

# Copy everything
COPY . ./
# Restore as distinct layers
RUN dotnet restore
# Build and publish a release
RUN dotnet publish -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /GoldenCrown
COPY --from=build-env /GoldenCrown/out .
ENTRYPOINT ["dotnet", "GoldenCrown.Api.dll"]
EXPOSE 8080