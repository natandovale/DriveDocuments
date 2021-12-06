using Azure.Storage.Blobs;
using DriveDocuments.Domain.DTOs;
using DriveDocuments.Domain.DTOs.Interface;
using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DriveDocuments.Domain.Services
{
    class FileUpload
    {
        public static IInformacoes UploadBase64image(string base64Image, string container)
        {
            //Gera um nome randomico para a imagem
            var filename = Guid.NewGuid().ToString() + ".jpg";

            //Limpa o hash enviado
            var data = new Regex(@"^data:image\/[a-z]+;base64,").Replace(base64Image, "");

            //Gera um array de bytes
            byte[] imageBytes = Convert.FromBase64String(data);

            //Define o BLOB no qual a imagem será armazenada
            var blobClient = new BlobClient("DefaultEndpointsProtocol=https;AccountName=testeblobs2;AccountKey=GObmWRPMhieC95GRe+Unj1a8zT38VpRbER4EL0W9g1MACnCGMEKaEO9rdSruokLvI55L5f4bJksrtu55EDGKaw==;EndpointSuffix=core.windows.net", container, filename);

            //Faz o upload
            using (var stream = new MemoryStream(imageBytes))
            {
                blobClient.Upload(stream);
            }

            //Retorna a URL da imagem
            var result = new InformacoesImgemBlobsDTO(blobClient.Name, blobClient.Uri.AbsoluteUri);
            return result;
        }
    }
}
