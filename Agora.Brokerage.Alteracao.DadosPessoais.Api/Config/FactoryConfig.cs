using Agora.Brokerage.Alteracao.DadosPessoais.Core;
using Agora.Brokerage.Alteracao.DadosPessoais.Core.Factories;
using Agora.Brokerage.Alteracao.DadosPessoais.Core.Interface.Factories;
using Agora.Brokerage.Bill.Api.Connections;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Agora.Brokerage.Alteracao.DadosPessoais.API.Config
{
    public static class FactoryConfig
    {
        public static void ConfigFactory(this IServiceCollection services)
        {
            var connectionString = Environment.GetEnvironmentVariable("CNN_STR_CADASTRO");

            if (Debugger.IsAttached)
                connectionString = ConnectionsAmbiente.GetConnection("tu", "AGR_CADASTRO", "AGR_CADASTRO");

            var configs = new Dictionary<Conection, string>()
            {
                { Conection.DB, connectionString }
            };

            services.AddSingleton<IConnectionFactory>(s => new ConnectionFactory(configs));
        }
    }
}
