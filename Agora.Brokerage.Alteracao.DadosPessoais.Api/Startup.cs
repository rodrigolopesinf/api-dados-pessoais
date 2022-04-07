using Agora.Brokerage.Alteracao.DadosPessoais.Api.Config;
using Agora.Brokerage.Alteracao.DadosPessoais.API.Config;
using Agora.Brokerage.Bill.Api;
using Agora.Brokerage.Bill.Core.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;

namespace Agora.Brokerage.Alteracao.DadosPessoais.Api
{
    public class Startup : StartupBaseApi
    {
        public IWebHostEnvironment Env { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="configuration"></param>
        public Startup(IConfiguration configuration, IWebHostEnvironment env) : base(configuration, false)
        {
            Env = env;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="services"></param>
        public override void ConfigureIOC(IServiceCollection services)
        {
            var configurationExtensionBuilder = new ConfigurationExtensionBuilder(Env);
            services.AddSingleton<IConfigurationExtensionBuilder>(configurationExtensionBuilder);
            services.ConfigFactory();

            CommandConfig.Config(services);
            RepositoriesConfig.Config(services);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="app"></param>
        /// <param name="env"></param>
        public override void ConfigureBase(IApplicationBuilder app, IWebHostEnvironment env)
        {
        }

        /// <summary>
        /// Configuração para exbir os XML
        /// </summary>
        /// <returns></returns>
        public override List<string> GetXmlCommentsPath()
        {
            return null;
        }
    }
}