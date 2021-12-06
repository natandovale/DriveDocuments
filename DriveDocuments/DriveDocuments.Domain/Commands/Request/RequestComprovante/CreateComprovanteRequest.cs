using System;

namespace DriveDocuments.Domain.Commands.RequestComprovante
{
    public class CreateComprovanteRequest
    {
        public string Nome { get; set; }
        public string Beneficiario { get; set; }
        public string ImagemBase64 { get; set; }
    }
}
