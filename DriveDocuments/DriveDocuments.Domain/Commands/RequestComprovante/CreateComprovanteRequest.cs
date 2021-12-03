namespace DriveDocuments.Domain.Commands.RequestComprovante
{
    public class CreateComprovanteRequest
    {
        public string Nome { get; set; }
        public byte[] ImagemCaminhoDoArquivo { get; set; }
    }
}
