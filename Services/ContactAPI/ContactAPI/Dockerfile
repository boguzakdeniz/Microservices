#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["Services/ContactAPI/ContactAPI/Contact.API.csproj", "Services/ContactAPI/ContactAPI/"]
COPY ["Services/ContactAPI/ContactAPI.Infrastructure/Contact.API.Infrastructure.csproj", "Services/ContactAPI/ContactAPI.Infrastructure/"]
COPY ["Services/ContactAPI/Contact.API.Models/Contact.API.Models.csproj", "Services/ContactAPI/Contact.API.Models/"]
COPY ["Services/ContactAPI/Contact.API.Services/Contact.API.Services.csproj", "Services/ContactAPI/Contact.API.Services/"]
RUN dotnet restore "Services/ContactAPI/ContactAPI/Contact.API.csproj"
COPY . .
WORKDIR "/src/Services/ContactAPI/ContactAPI"
RUN dotnet build "Contact.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Contact.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Contact.API.dll"]