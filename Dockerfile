FROM dotnet/core-nightly/sdk:2.1

WORKDIR /app

COPY ./publish .

ENTRYPOINT ["dotnet","aspmvc.dll"]