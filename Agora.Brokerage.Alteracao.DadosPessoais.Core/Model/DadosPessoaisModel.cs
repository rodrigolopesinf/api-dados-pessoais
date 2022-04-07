namespace Agora.Brokerage.Alteracao.DadosPessoais.Core.Model
{
    public class DadosPessoaisModel
    {
        public DadosPessoaisModel(long cpfCnpj, string origem)
        {
            CpfCnpj = cpfCnpj;
            Origem = origem;
        }

        public long CpfCnpj { get; private set; }
        public string NomeCompleto { get; private set; }
        public string Email { get; private set; }
        public int? DDDCelular { get; private set; }
        public long? TelefoneCelular { get; private set; }
        public string Origem { get; private set; }

        public DadosPessoaisModel SetarNomeCompleto(string nomeCompleto)
        {
            NomeCompleto = nomeCompleto;
            return this;
        }

        public DadosPessoaisModel SetarEmail(string email)
        {
            Email = email;
            return this;
        }

        public DadosPessoaisModel SetarDDDCelular(int? dddCelular)
        {
            DDDCelular = dddCelular;
            return this;
        }

        public DadosPessoaisModel SetarTelefoneCelular(long? telefoneCelular)
        {
            TelefoneCelular = telefoneCelular;
            return this;
        }

        public DadosPessoaisModel SetarOrigem(string origem)
        {
            Origem = origem;
            return this;
        }
    }
}