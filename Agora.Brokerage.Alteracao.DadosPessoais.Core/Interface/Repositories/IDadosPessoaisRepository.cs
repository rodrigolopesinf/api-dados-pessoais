using Agora.Brokerage.Alteracao.DadosPessoais.Core.Request;
using System.Threading.Tasks;

namespace Agora.Brokerage.Alteracao.DadosPessoais.Core.Interface.Repositories
{
    public interface IDadosPessoaisRepository
    {
        Task AtualizarDadosAcesso(DadosPessoaisRequest request);
    }
}