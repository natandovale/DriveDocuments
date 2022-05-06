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
            var blobClient = new BlobClient("DefaultEndpointsProtocol=https;AccountName=testeblobs2;AccountKey=4Awje13gbiv1W4nVDPrcF8PNT/Gz7191XGow4GKCHO13SjiKna7ycUDkzPtn2zZzv43NBYuGKKAdZu7fe11s5A==;EndpointSuffix=core.windows.net", "demo", informacoes.Nome);

            blobClient.Delete();
        }
    }
}
