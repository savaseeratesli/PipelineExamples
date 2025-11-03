# Stage 1: build
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src

# Copy csproj and restore
COPY HelloWORLD.csproj .
RUN dotnet restore

# Copy everything and publish
COPY . .
RUN dotnet publish -c Release -o /app/publish

# Stage 2: runtime (smaller, non-root)
FROM mcr.microsoft.com/dotnet/aspnet:7.0
# Create non-root user for security
RUN useradd -m appuser
WORKDIR /app

# Copy published output
COPY --from=build /app/publish ./

# Ensure container listens on 11130
ENV ASPNETCORE_URLS="http://0.0.0.0:11130"
EXPOSE 11130

# Drop privileges
USER appuser

ENTRYPOINT ["dotnet", "HelloWORLD.dll"]
