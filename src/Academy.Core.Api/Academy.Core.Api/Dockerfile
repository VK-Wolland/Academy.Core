#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM microsoft/dotnet:2.1-aspnetcore-runtime-nanoserver-1803 AS base
WORKDIR /app
EXPOSE 58040
EXPOSE 44324

FROM microsoft/dotnet:2.1-sdk-nanoserver-1803 AS build
WORKDIR /src
COPY ["Academy.Core.Api/Academy.Core.Api.csproj", "Academy.Core.Api/"]
RUN dotnet restore "Academy.Core.Api/Academy.Core.Api.csproj"
COPY . .
WORKDIR "/src/Academy.Core.Api"
RUN dotnet build "Academy.Core.Api.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Academy.Core.Api.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Academy.Core.Api.dll"]