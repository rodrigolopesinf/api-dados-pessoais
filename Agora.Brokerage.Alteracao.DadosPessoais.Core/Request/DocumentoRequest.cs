namespace Agora.Brokerage.Alteracao.DadosPessoais.Core.Request
{
    public class DocumentoRequest
    {
        public string TipoDocumento { get; private set; }
        public string NumeroDoDocumento { get; private set; }
        public string DataEmissao { get; private set; }
        public string OrgaoEmissor { get; private set; }
        public string EstadoEmissor { get; private set; }
        public long? CodigoSegurancaCNH { get; private set; }

        public DocumentoRequest SetarTipoDocumento(string tipoDocumento)
        {
            TipoDocumento = tipoDocumento;
            return this;
        }

        public DocumentoRequest SetarNumeroDoDocumento(string numeroDoDocumento)
        {
            NumeroDoDocumento = numeroDoDocumento;
            return this;
        }

        public DocumentoRequest SetarDataEmissao(string dataEmissao)
        {
            DataEmissao = dataEmissao;
            return this;
        }
        public DocumentoRequest SetarOrgaoEmissor(string orgaoEmissor)
        {
            OrgaoEmissor = orgaoEmissor;
            return this;
        }

        public DocumentoRequest SetarEstadoEmissor(string estadoEmissor)
        {
            EstadoEmissor = estadoEmissor;
            return this;
        }

        public DocumentoRequest SetarCodigoSegurancaCNH(long? codigoSegurancaCNH)
        {
            CodigoSegurancaCNH = codigoSegurancaCNH;
            return this;
        }

        public bool ValidarTipoDocumentoVazioOuNUlo()
        {
            return string.IsNullOrEmpty(TipoDocumento);
        }

        public bool ValidarNumeroDocumentoVazioOuNUlo()
        {
            return string.IsNullOrEmpty(NumeroDoDocumento);
        }

        public bool ValidarDataEmissaoVazioOuNUlo()
        {
            return string.IsNullOrEmpty(DataEmissao);
        }

        public bool ValidarOrgaoEmissorVazioOuNUlo()
        {
            return string.IsNullOrEmpty(OrgaoEmissor);
        }

        public bool ValidarEstadoEmissorVazioOuNUlo()
        {
            return string.IsNullOrEmpty(EstadoEmissor);
        }

    }
}