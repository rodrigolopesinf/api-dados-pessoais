namespace Agora.Brokerage.Alteracao.DadosPessoais.Core.DTO
{
    public class DocumentoDto
    {
        public DocumentoDto()
        { }

        public string TipoDocumento { get; set; }
        public string NumeroDoDocumento { get; set; }
        public string DataEmissao { get; set; }
        public string OrgaoEmissor { get; set; }
        public string EstadoEmissor { get; set; }
        public long? CodigoSegurancaCNH { get; set; }
    }
}