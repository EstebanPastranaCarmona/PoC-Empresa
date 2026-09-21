FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build

WORKDIR /src

COPY ["PoCEmPRESA.csproj", "./"]

RUN dotnet restore "PoCEmPRESA.csproj"

COPY . .

RUN dotnet publish "PoCEmPRESA.csproj" -c Release -o /app/publish


FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS final

WORKDIR /app

COPY --from=build /app/publish .

ENV ASPNETCORE_URLS=http://+:8080

EXPOSE 8080

ENTRYPOINT ["dotnet", "PoCEmPRESA.dll"]