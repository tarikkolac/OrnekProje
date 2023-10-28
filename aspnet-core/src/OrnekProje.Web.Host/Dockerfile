FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

WORKDIR /src
COPY ["src/OrnekProje.Web.Host/OrnekProje.Web.Host.csproj", "src/OrnekProje.Web.Host/"]
COPY ["src/OrnekProje.Web.Core/OrnekProje.Web.Core.csproj", "src/OrnekProje.Web.Core/"]
COPY ["src/OrnekProje.Application/OrnekProje.Application.csproj", "src/OrnekProje.Application/"]
COPY ["src/OrnekProje.Core/OrnekProje.Core.csproj", "src/OrnekProje.Core/"]
COPY ["src/OrnekProje.EntityFrameworkCore/OrnekProje.EntityFrameworkCore.csproj", "src/OrnekProje.EntityFrameworkCore/"]
WORKDIR "/src/src/OrnekProje.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/OrnekProje.Web.Host", "src/OrnekProje.Web.Host"]
COPY ["src/OrnekProje.Web.Core", "src/OrnekProje.Web.Core"]
COPY ["src/OrnekProje.Application", "src/OrnekProje.Application"]
COPY ["src/OrnekProje.Core", "src/OrnekProje.Core"]
COPY ["src/OrnekProje.EntityFrameworkCore", "src/OrnekProje.EntityFrameworkCore"]
WORKDIR "/src/src/OrnekProje.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "OrnekProje.Web.Host.dll"]
