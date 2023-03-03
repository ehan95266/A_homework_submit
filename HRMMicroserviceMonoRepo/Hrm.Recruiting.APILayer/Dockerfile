#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
ENV RecruitmentDb="Data Source=192.168.1.33,1433;Initial Catalog=RecruitmentDb;user id=sa;password=Elva002190739!;TrustServerCertificate=True"

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Hrm.Recruiting.APILayer/Hrm.Recruiting.APILayer.csproj", "Hrm.Recruiting.APILayer/"]
COPY ["Hrm.Recruiting.ApplicationCoreLayer/Hrm.Recruiting.ApplicationCoreLayer.csproj", "Hrm.Recruiting.ApplicationCoreLayer/"]
COPY ["Hrm.Recruiting.Infrastructure/Hrm.Recruiting.Infrastructure.csproj", "Hrm.Recruiting.Infrastructure/"]
RUN dotnet restore "Hrm.Recruiting.APILayer/Hrm.Recruiting.APILayer.csproj"
COPY . .
WORKDIR "/src/Hrm.Recruiting.APILayer"
RUN dotnet build "Hrm.Recruiting.APILayer.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Hrm.Recruiting.APILayer.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Hrm.Recruiting.APILayer.dll"]
