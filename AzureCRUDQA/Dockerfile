FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 53879
EXPOSE 44306

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY ["AzureCRUDQA/AzureCRUDQA.csproj", "AzureCRUDQA/"]
RUN dotnet restore "AzureCRUDQA/AzureCRUDQA.csproj"
COPY . .
WORKDIR "/src/AzureCRUDQA"
RUN dotnet build "AzureCRUDQA.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "AzureCRUDQA.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "AzureCRUDQA.dll"]