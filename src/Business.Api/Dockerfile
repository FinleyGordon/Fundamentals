# Stage 1: Build the application
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

WORKDIR /src
COPY ["./src/Business.Api/Business.Api.csproj", "Business.Api/"]
RUN dotnet restore "Business.Api/Business.Api.csproj"

COPY ["./src/Business.Api", "Business.Api/"]
WORKDIR "/src/Business.Api"
RUN dotnet build "Business.Api.csproj" -c Release -o /app/build

# Stage 2: Publish the application
FROM build AS publish

RUN dotnet publish "Business.Api.csproj" -c Release -o /app/publish

# Stage 3: Final image
FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS final

WORKDIR /app
COPY --from=publish /app/publish .
EXPOSE 80
EXPOSE 443

ENTRYPOINT ["dotnet", "Business.Api.dll"]

# Set dummy IAM credentials as environment variables
ENV AWS_ACCESS_KEY_ID=dummy
ENV AWS_SECRET_ACCESS_KEY=dummy
