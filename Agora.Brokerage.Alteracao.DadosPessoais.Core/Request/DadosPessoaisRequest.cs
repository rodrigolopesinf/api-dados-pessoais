using Agora.Brokerage.Bill.Core.Request;

namespace Agora.Brokerage.Alteracao.DadosPessoais.Core.Request
{
    public class DadosPessoaisRequest : RequestBase
    {
        public DadosPessoaisRequest()
        {
            Documento = new DocumentoRequest();
        }

        public int? DddConvencional { get; private set; }
        public long? TelefoneConvencional { get; private set; }
        public int? DddCelular { get; private set; }
        public long? TelefoneCelular { get; private set; }
        public DocumentoRequest Documento { get; private set; }
        public int? Nacionalidade { get; private set; }
        public string Genero { get; private set; }
        public string NomeMae { get; private set; }
        public string NomePai { get; private set; }
        public string EstadoNascimento { get; private set; }
        public string CidadeNascimento { get; private set; }
        public int? EstadoCivil { get; private set; }
        public string NomeConjuge { get; private set; }
        public long? CpfConjuge { get; private set; }
        public string Ip { get; private set; }
        public string Origem { get; private set; }

        public DadosPessoaisRequest SetarCpfCnpj(long cpfCnpj)
        {
            CpfCnpj = cpfCnpj;
            return this;
        }

        public DadosPessoaisRequest SetarDddConvencional(int? dddConvencional)
        {
            DddConvencional = dddConvencional;
            return this;
        }

        public DadosPessoaisRequest SetarTelefoneConvencional(long? telefoneConvencional)
        {
            TelefoneConvencional = telefoneConvencional;
            return this;
        }

        public DadosPessoaisRequest SetarDddCelular(int? dddCelular)
        {
            DddCelular = dddCelular;
            return this;
        }

        public DadosPessoaisRequest SetarTelefoneCelular(long? telefoneCelular)
        {
            TelefoneCelular = telefoneCelular;
            return this;
        }

        public DadosPessoaisRequest SetarDocumento(DocumentoRequest documento)
        {
            Documento = documento;
            return this;
        }

        public DadosPessoaisRequest SetarNacionalidade(int? nacionalidade)
        {
            Nacionalidade = nacionalidade;
            return this;
        }

        public DadosPessoaisRequest SetarGenero(string genero)
        {
            Genero = genero;
            return this;
        }

        public DadosPessoaisRequest SetarNomeMae(string nomeMae)
        {
            NomeMae = nomeMae;
            return this;
        }

        public DadosPessoaisRequest SetarNomePai(string nomePai)
        {
            NomePai = nomePai;
            return this;
        }

        public DadosPessoaisRequest SetarEstadoNascimento(string estadoNascimento)
        {
            EstadoNascimento = estadoNascimento;
            return this;
        }

        public DadosPessoaisRequest SetarCidadeNascimento(string cidadeNascimento)
        {
            CidadeNascimento = cidadeNascimento;
            return this;
        }

        public DadosPessoaisRequest SetarEstadoCivil(int? estadoCivil)
        {
            EstadoCivil = estadoCivil;
            return this;
        }

        public DadosPessoaisRequest SetarNomeConjuge(string nomeConjuge)
        {
            NomeConjuge = nomeConjuge;
            return this;
        }

        public DadosPessoaisRequest SetarCpfConjuge(long? cpfConjuge)
        {
            CpfConjuge = cpfConjuge;
            return this;
        }

        public DadosPessoaisRequest SetarIp(string ip)
        {
            Ip = ip;
            return this;
        }

        public DadosPessoaisRequest SetarOrigem(string origem)
        {
            Origem = origem;
            return this;
        }

        public bool ValidarCpfCnpjZeroOuNUlo()
        {
            return CpfCnpj == 0;
        }

        public bool ValidarEstadoNascimentoVazioOuNUlo()
        {
            if (Nacionalidade != null)
                return false;
            else
                return string.IsNullOrEmpty(EstadoNascimento);
        }

        public bool ValidarCidadeNascimentoVazioOuNUlo()
        {
            return string.IsNullOrEmpty(CidadeNascimento);
        }
        
        public bool ValidarIpVazioOuNUlo()
        {
            return string.IsNullOrEmpty(Ip);
        }

        public bool ValidarOrigemVazioOuNUlo()
        {
            return string.IsNullOrEmpty(Origem);
        }
    }
}