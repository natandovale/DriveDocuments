using DriveDocuments.Domain.DTOs.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveDocuments.Domain.DTOs
{
    public class InformacoesImgemBlobsDTO : IInformacoes
    {
        public InformacoesImgemBlobsDTO(string nome, string uri)
        {
            Nome = nome;
            Uri = uri;
        }

        public InformacoesImgemBlobsDTO(string nome)
        {
            Nome = nome;
        }

        public string Nome { get ; set; }
        public string Uri { get ; set ; }
    }
}
