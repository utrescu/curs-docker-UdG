FROM mcr.microsoft.com/dotnet/sdk:5.0 as BUILD

WORKDIR /app

COPY *.csproj ./
RUN dotnet restore

COPY . ./
RUN dotnet publish -c Release -o out

WORKDIR /app/out

ENTRYPOINT ["dotnet", "programa.dll"]
