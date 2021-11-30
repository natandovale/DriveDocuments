using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveDocuments.Domain.Entities
{
    public class Comprovante
    {
        public string Nome { get; private set; }
        public string ImagemCaminhoDoArquivo { get; private set; }
        public byte[] Imagem { get; set; }

        public Comprovante() 
        { 
        }

        public Comprovante(string nome, string imagemCaminhoDoArquivo, byte[] imagem)
        {
            Nome = nome;
            ImagemCaminhoDoArquivo = imagemCaminhoDoArquivo;
            Imagem = imagem;
        }
    }
}
