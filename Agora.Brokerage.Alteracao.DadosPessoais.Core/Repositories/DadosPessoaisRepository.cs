using Agora.Brokerage.Alteracao.DadosPessoais.Core.Interface.Factories;
using Agora.Brokerage.Alteracao.DadosPessoais.Core.Interface.Repositories;
using Agora.Brokerage.Alteracao.DadosPessoais.Core.Request;
using Agora.Brokerage.Bill.Core.Repositories;
using System.Data;
using System.Threading.Tasks;

namespace Agora.Brokerage.Alteracao.DadosPessoais.Core.Repositories
{
    public class DadosPessoaisRepository : RepositoryBase, IDadosPessoaisRepository
    {
        private const string PR_AL_DP_CLI_PF_VIST = "PKG_JA_DADOS_PESSOAIS.PR_AL_DP_CLI_PF_VIST";

        public DadosPessoaisRepository(IConnectionFactory connection)
        {
            base.SetConnectionString(connection.ObterUrl(Conection.DB));
        }

        public async Task AtualizarDadosAcesso(DadosPessoaisRequest request)
        {
            OracleDynamicParameters parameters = new OracleDynamicParameters();

            parameters.Add("pCpfCnpj", request.CpfCnpj);
            parameters.Add("pDddConvencional", request.DddConvencional);
            parameters.Add("pTelefoneConvencional", request.TelefoneConvencional);
            parameters.Add("pDddCelular", request.DddCelular);
            parameters.Add("pTelefoneCelular", request.TelefoneCelular);
            parameters.Add("pTipoDocumento", request.Documento.TipoDocumento);
            parameters.Add("pNumeroDoDocumento", request.Documento.NumeroDoDocumento);
            parameters.Add("pDataEmissao", request.Documento.DataEmissao);
            parameters.Add("pOrgaoEmissor", request.Documento.OrgaoEmissor);
            parameters.Add("pEstadoEmissor", request.Documento.EstadoEmissor);
            parameters.Add("pCodigoSegurancaCNH", request.Documento.CodigoSegurancaCNH);
            parameters.Add("pNacionalidade", request.Nacionalidade);
            parameters.Add("pGenero", request.Genero);
            parameters.Add("pNomeMae", request.NomeMae);
            parameters.Add("pNomePai", request.NomePai);
            parameters.Add("pEstadoNascimento", request.EstadoNascimento);
            parameters.Add("pCidadeNascimento", request.CidadeNascimento);
            parameters.Add("pEstadoCivil", request.EstadoCivil);
            parameters.Add("pNomeConjuge", request.NomeConjuge);           
            parameters.Add("pCPFConjuge", request.CpfConjuge);
            parameters.Add("pIp", request.Ip);
            parameters.Add("pOrigem", request.Origem);
            
            await ExecuteAsync(PR_AL_DP_CLI_PF_VIST, param: parameters, commandType: CommandType.StoredProcedure);
        }
    }
}