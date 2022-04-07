using Agora.Brokerage.Alteracao.DadosPessoais.Core.Interface.Factories;
using System.Collections.Generic;

namespace Agora.Brokerage.Alteracao.DadosPessoais.Core.Factories
{
    /// <summary>
    /// 
    /// </summary>
    public class ConnectionFactory : IConnectionFactory
    {
        /// <summary>
        /// 
        /// </summary>
        private Dictionary<Conection, string> CurrentDatabaseSettings { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="currentDatabaseSettings"></param>
        public ConnectionFactory(Dictionary<Conection, string> currentDatabaseSettings)
        {
            CurrentDatabaseSettings = currentDatabaseSettings;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pConnectionName"></param>
        /// <returns></returns>
        public string ObterUrl(Conection pConnectionName)
        {

            if (CurrentDatabaseSettings.TryGetValue(pConnectionName, out string connectionString))
            {
                switch (pConnectionName)
                {
                    case Conection.DB:
                        return connectionString;
                    default:
                        break;
                }
            }
            return connectionString;
        }
    }
}