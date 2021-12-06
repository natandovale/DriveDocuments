using Azure.Storage.Blobs;
using DriveDocuments.Domain.DTOs.Interface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveDocuments.Domain.Services
{
    public class FileDelete
    {
        public static void DeletaImagem(IInformacoes informacoes)
        {
            var blobClient = new BlobClient("DefaultEndpointsProtocol=https;AccountName=testeblobs2;AccountKey=GObmWRPMhieC95GRe+Unj1a8zT38VpRbER4EL0W9g1MACnCGMEKaEO9rdSruokLvI55L5f4bJksrtu55EDGKaw==;EndpointSuffix=core.windows.net", "demo", informacoes.Nome);

            blobClient.Delete();
        }
    }
}
