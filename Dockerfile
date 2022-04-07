FROM quay-registry.apps.agibccoshoocp.ocp.agorasenior.corp/devops/agora-dotnet-sdk:3.1 AS restore

COPY Agora.Brokerage.Alteracao.DadosPessoais.Api.sln .
COPY Agora.Brokerage.Alteracao.DadosPessoais.Api/Agora.Brokerage.Alteracao.DadosPessoais.Api.csproj Agora.Brokerage.Alteracao.DadosPessoais.Api/
COPY Agora.Brokerage.Alteracao.DadosPessoais.Core/Agora.Brokerage.Alteracao.DadosPessoais.Core.csproj Agora.Brokerage.Alteracao.DadosPessoais.Core/

RUN dotnet restore "Agora.Brokerage.Alteracao.DadosPessoais.Api.sln"
FROM restore AS build
ARG SonarQubeProjectKey
COPY . .
ARG FOO
RUN dotnet sonarscanner begin /k:$SonarQubeProjectKey
ARG FOO
RUN dotnet build "Agora.Brokerage.Alteracao.DadosPessoais.Api.sln" -c Release -o /app

ARG FOO
RUN dotnet sonarscanner end

FROM build AS publish
RUN dotnet publish "Agora.Brokerage.Alteracao.DadosPessoais.Api.sln" -c Release -o /app

FROM quay-registry.apps.agibccoshoocp.ocp.agorasenior.corp/devops/agora-dotnet-runtime:3.1 AS final
USER 0
ENV LD_LIBRARY_PATH=/opt/rh/rh-nodejs6/root/usr/lib64:/opt/rh/rh-dotnet31/root/usr/lib64
ENV PATH=/opt/rh/rh-nodejs6/root/usr/bin:/opt/rh/rh-dotnet31/root/usr/bin:/opt/rh/rh-dotnet31/root/usr/sbin:/opt/app-root/src/.local/bin:${HOME}/src/bin:${HOME}/node_modules/.bin:${HOME}/bin:/usr/local/sbin:/usr/local/bin:/usr/sbin:/usr/bin:/sbin:/bin
RUN usermod -g dotnet default
RUN chown -R 1001:dotnet ${DOTNET_APP_PATH}
WORKDIR /app
COPY --from=publish /app .
USER 1001
CMD ["dotnet", "Agora.Brokerage.Alteracao.DadosPessoais.Api.dll"]