FROM mcr.microsoft.com/dotnet/sdk:5.0 as BUILD

WORKDIR /app

COPY *.csproj ./
RUN dotnet restore

COPY . ./
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/runtime:5.0
WORKDIR /app
COPY --from=BUILD /app/out .
ENTRYPOINT ["dotnet", "programa.dll"]
