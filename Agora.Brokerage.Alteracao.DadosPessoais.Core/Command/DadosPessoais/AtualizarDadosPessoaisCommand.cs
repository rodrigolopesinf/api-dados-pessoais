using Agora.Brokerage.Alteracao.DadosPessoais.Core.Interface.Command;
using Agora.Brokerage.Alteracao.DadosPessoais.Core.Interface.Repositories;
using Agora.Brokerage.Alteracao.DadosPessoais.Core.Request;
using Agora.Brokerage.Bill.Core.Mensagens;
using Agora.Brokerage.Bill.Core.Request;
using Agora.Brokerage.Bill.Core.Validantions;
using System.Threading.Tasks;

namespace Agora.Brokerage.Alteracao.DadosPessoais.Core.Command.DadosAcesso
{
    public class AtualizarDadosPessoaisCommand : Commands, IAtualizarDadosPessoaisCommand
    {
        private readonly IDadosPessoaisRepository _repository;
        public DadosPessoaisRequest Request { get; set; }

        public AtualizarDadosPessoaisCommand(INotification notification, IDadosPessoaisRepository repository) : base(notification)
        {
            _repository = repository;
        }

        public override async Task<bool> Executar(RequestBase request = null)
        {
            Request = (DadosPessoaisRequest)request;

            if (!CommandEhValido(this))
                return false;

            await _repository.AtualizarDadosAcesso(Request);

            return true;
        }

        public override bool EhValido()
        {
            ValidationResult = new AtualizarDadosPessoaisCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}