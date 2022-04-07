namespace Agora.Brokerage.Alteracao.DadosPessoais.Core.Interface.Factories
{
    /// <summary>
    /// 
    /// </summary>
    public interface IConnectionFactory
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pConnectionName"></param>
        /// <returns></returns>
        string ObterUrl(Conection pConnectionName);
    }
}