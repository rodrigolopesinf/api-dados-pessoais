using FluentValidation;
using FluentValidation.Results;

namespace Agora.Brokerage.Alteracao.DadosPessoais.Core.Command.DadosAcesso
{
    public class AtualizarDadosPessoaisCommandValidation : AbstractValidator<AtualizarDadosPessoaisCommand>
    {
        public const string RequestMensagem = "Request não pode ser vazio.";
        public const string CpfCnpjMensagem = "O Cpf/Cnpj é obrigatório.";
        public const string EstadoNascimentoMensagem = "O Estado de nascimento é obrigatório.";
        public const string CidadeNascimentoMensagem = "A cidade de nascimento é obrigatória.";
        public const string TipoDocumentoMensagem = "O tipo do documento é obrigatório.";
        public const string NumeroDoDocumentoMensagem = "O número do documento é obrigatório.";
        public const string DataEmissaoMensagem = "A data de emissão do documento é obrigatória.";
        public const string OrgaoEmissorMensagem = "O orgão emissor do documento é obrigatório.";
        public const string EstadoEmissorMensagem = "O estado emissor do documento é obrigatório.";
        public const string IpMensagem = "O ip é obrigatório.";
        public const string OrigemMensagem = "A Origem é obrigatória.";
        public AtualizarDadosPessoaisCommandValidation()
        {
            RuleFor(x => x.Request)
                .Custom((request, context) =>
                {
                    if (request == null)
                    {
                        context.AddFailure(new ValidationFailure("Request", RequestMensagem) { ErrorCode = "1" });
                    }
                    else if (request.ValidarCpfCnpjZeroOuNUlo())
                    {
                        context.AddFailure(new ValidationFailure("CpfCnpj", CpfCnpjMensagem) { ErrorCode = "2" });
                    }                    
                    else if (request.ValidarEstadoNascimentoVazioOuNUlo())
                    {
                        context.AddFailure(new ValidationFailure("EstadoNascimento", EstadoNascimentoMensagem) { ErrorCode = "3" });
                    }
                    else if (request.ValidarCidadeNascimentoVazioOuNUlo())
                    {
                        context.AddFailure(new ValidationFailure("CidadeNascimento", CidadeNascimentoMensagem) { ErrorCode = "4" });
                    }
                    else if (request.Documento.ValidarTipoDocumentoVazioOuNUlo())
                    {
                        context.AddFailure(new ValidationFailure("Documento.TipoDocumento", TipoDocumentoMensagem) { ErrorCode = "5" });
                    }
                    else if (request.Documento.ValidarNumeroDocumentoVazioOuNUlo())
                    {
                        context.AddFailure(new ValidationFailure("Documento.NumeroDoDocumento", NumeroDoDocumentoMensagem) { ErrorCode = "6" });
                    }
                    else if (request.Documento.ValidarDataEmissaoVazioOuNUlo())
                    {
                        context.AddFailure(new ValidationFailure("Documento.DataEmissao", DataEmissaoMensagem) { ErrorCode = "7" });
                    }
                    else if (request.Documento.ValidarOrgaoEmissorVazioOuNUlo())
                    {
                        context.AddFailure(new ValidationFailure("Documento.OrgaoEmissor", OrgaoEmissorMensagem) { ErrorCode = "8" });
                    }
                    else if (request.Documento.ValidarEstadoEmissorVazioOuNUlo())
                    {
                        context.AddFailure(new ValidationFailure("Documento.EstadoEmissor", EstadoEmissorMensagem) { ErrorCode = "9" });
                    }
                    else if (request.ValidarIpVazioOuNUlo())
                    {
                        context.AddFailure(new ValidationFailure("Ip", IpMensagem) { ErrorCode = "10" });
                    }
                    else if (request.ValidarOrigemVazioOuNUlo())
                    {
                        context.AddFailure(new ValidationFailure("Origem", OrigemMensagem) { ErrorCode = "11" });
                    }
                });
        }
    }
}