using System;

namespace DriveDocuments.Domain.Entities
{
    public class Comprovante
    {
        public string Nome { get; private set; }
        public string Beneficiario { get; set; }
        public string ImagemCaminhoDoArquivo { get; private set; }
        public DateTime DataCreate { get; set; }
        public byte[] Imagem { get; private set; }

        public Comprovante()
        {
        }

        public Comprovante(string nome, string imagemCaminhoDoArquivo, byte[] imagem)
        {
            Nome = nome;
            ImagemCaminhoDoArquivo = imagemCaminhoDoArquivo;
            Imagem = imagem;
        }

        public Comprovante(string nome, byte[] imagem)
        {
            Nome = nome;
            Imagem = imagem;
        }
    }
}
