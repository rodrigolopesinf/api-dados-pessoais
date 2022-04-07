using Agora.Brokerage.Alteracao.DadosPessoais.Core.Request;

namespace Agora.Brokerage.Alteracao.DadosPessoais.Core.DTO
{
    public class DadosPessoaisDto
    {
        public DadosPessoaisDto()
        {
            Documento = new DocumentoDto();
        }

        public long CpfCnpj { get; set; }
        public int? DddConvencional { get; set; }
        public long? TelefoneConvencional { get; set; }
        public int? DddCelular { get; set; }
        public long? TelefoneCelular { get; set; }
        public DocumentoDto Documento { get; set; }
        public int? Nacionalidade { get; set; }
        public string Genero { get; set; }
        public string NomeMae { get; set; }
        public string NomePai { get; set; }
        public string EstadoNascimento { get; set; }
        public string CidadeNascimento { get; set; }
        public int? EstadoCivil { get; set; }
        public string NomeConjuge { get; set; }
        public long? CPFConjuge { get; set; }
        public string Ip { get; set; }
        public string Origem { get; set; }


        public DadosPessoaisRequest ToRequest()
        {
            DadosPessoaisRequest model = new DadosPessoaisRequest()
                .SetarCpfCnpj(CpfCnpj)
                .SetarDddConvencional(DddConvencional)
                .SetarTelefoneConvencional(TelefoneConvencional)
                .SetarDddCelular(DddCelular)
                .SetarTelefoneCelular(TelefoneCelular)
                .SetarDocumento(new DocumentoRequest()
                .SetarCodigoSegurancaCNH(Documento.CodigoSegurancaCNH)
                .SetarDataEmissao(Documento.DataEmissao)
                .SetarEstadoEmissor(Documento.EstadoEmissor)
                .SetarNumeroDoDocumento(Documento.NumeroDoDocumento)
                .SetarOrgaoEmissor(Documento.OrgaoEmissor)
                .SetarTipoDocumento(Documento.TipoDocumento))
                .SetarNacionalidade(Nacionalidade)
                .SetarGenero(Genero)
                .SetarNomeMae(NomeMae)
                .SetarNomePai(NomePai)
                .SetarEstadoNascimento(EstadoNascimento)
                .SetarCidadeNascimento(CidadeNascimento)
                .SetarEstadoCivil(EstadoCivil)
                .SetarNomeConjuge(NomeConjuge)
                .SetarCpfConjuge(CPFConjuge)
                .SetarIp(Ip)
                .SetarOrigem(Origem);

            return model;
        }
    }
}