using System;

namespace DriveDocuments.Domain.Entities
{
    public class Comprovante
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Beneficiario { get; set; }
        public string FileName { get; set; }
        public string UriImagem { get; private set; }
        public DateTime DataCriacao { get; set; }

        public Comprovante()
        {
        }

        public Comprovante(string nome, string beneficiario, DateTime dataCriacao, string uriImage, string fileName)
        {
            Nome = nome;
            Beneficiario = beneficiario;
            DataCriacao = dataCriacao;
            UriImagem = uriImage;
            FileName = fileName;
        }

        public Comprovante(string nome, string uriImage)
        {
            Nome = nome;
            UriImagem = uriImage;
        }
    }
}
