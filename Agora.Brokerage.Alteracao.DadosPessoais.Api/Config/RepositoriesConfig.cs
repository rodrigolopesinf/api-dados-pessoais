using Agora.Brokerage.Alteracao.DadosPessoais.Core.Interface.Repositories;
using Agora.Brokerage.Alteracao.DadosPessoais.Core.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Agora.Brokerage.Alteracao.DadosPessoais.Api.Config
{
    public static class RepositoriesConfig
    {
        public static void Config(IServiceCollection services)
        {
            services.AddTransient<IDadosPessoaisRepository, DadosPessoaisRepository>();
        }
    }
}