using Agora.Brokerage.Alteracao.DadosPessoais.Core.Command.DadosAcesso;
using Agora.Brokerage.Alteracao.DadosPessoais.Core.Interface.Command;
using Microsoft.Extensions.DependencyInjection;

namespace Agora.Brokerage.Alteracao.DadosPessoais.Api.Config
{
    public static class CommandConfig
    {
        public static void Config(IServiceCollection services)
        {
            services.AddTransient<IAtualizarDadosPessoaisCommand, AtualizarDadosPessoaisCommand>();
        }
    }
}