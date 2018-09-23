FROM microsoft/dotnet:2.1-sdk as build  
WORKDIR /PatternAppState
COPY PatternAppState . 

RUN dotnet restore
RUN dotnet publish "PatternAppState.csproj" -c Release -o /app

FROM microsoft/dotnet:2.1-runtime as deployment
WORKDIR /app 
COPY --from=build /app .
ENTRYPOINT [ "dotnet", "PatternAppState.dll" ]