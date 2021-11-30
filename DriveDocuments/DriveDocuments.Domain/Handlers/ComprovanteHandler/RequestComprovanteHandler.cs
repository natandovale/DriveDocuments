using DriveDocuments.Domain.Commands.RequestComprovante;
using DriveDocuments.Domain.Entities;
using DriveDocuments.Domain.Handlers.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveDocuments.Domain.Handlers.ComprovanteHandler
{
    class RequestComprovanteHandler : IRequestComprovanteHandler
    {
        public void HandlerCreate(CreateComprovanteRequest command)
        {
            byte[] imagem = GetImage(command.ImagemCaminhoDoArquivo);
            var comprovante = new Comprovante (command.Nome, command.ImagemCaminhoDoArquivo, imagem);

           // _repository.Create(comprovante);
        }
        private static byte[] GetImage(string filePath)
        {
            FileStream stream = new FileStream(
                filePath, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(stream);

            byte[] photo = reader.ReadBytes((int)stream.Length);

            reader.Close();
            stream.Close();

            return photo;
        }

        public void HandlerDelete(int id)
        {
            throw new NotImplementedException();
        }

        public void HandlerUpdate(CreateComprovanteRequest command)
        {
            throw new NotImplementedException();
        }
    }
}
