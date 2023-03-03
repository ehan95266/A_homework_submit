#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
ENV OnboardingDb="Data Source=192.168.1.33,1433;Initial Catalog=OnboardingDb;user id=sa;password=Elva002190739!;TrustServerCertificate=True"
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Hrm.Onboarding.APILayer/Hrm.Onboarding.APILayer.csproj", "Hrm.Onboarding.APILayer/"]
COPY ["Hrm.Onboarding.ApplicationCoreLayer/Hrm.Onboarding.ApplicationCoreLayer.csproj", "Hrm.Onboarding.ApplicationCoreLayer/"]
COPY ["Hrm.Onboarding.Infrastructure/Hrm.Onboarding.Infrastructure.csproj", "Hrm.Onboarding.Infrastructure/"]
RUN dotnet restore "Hrm.Onboarding.APILayer/Hrm.Onboarding.APILayer.csproj"
COPY . .
WORKDIR "/src/Hrm.Onboarding.APILayer"
RUN dotnet build "Hrm.Onboarding.APILayer.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Hrm.Onboarding.APILayer.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Hrm.Onboarding.APILayer.dll"]
