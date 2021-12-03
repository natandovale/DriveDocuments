using DriveDocuments.Domain.Commands.RequestComprovante;
using DriveDocuments.Domain.Entities;
using DriveDocuments.Domain.Handlers.Interfaces;
using DriveDocuments.Domain.Repositories.Interfaces;
using System;
using System.IO;

namespace DriveDocuments.Domain.Handlers.ComprovanteHandler.RequestComprovanteHandler
{
    public class CreateComprovanteHandler : ICreateComprovanteHandler
    {
        private readonly IComprovanteRepository _repository;
        public CreateComprovanteHandler(IComprovanteRepository repository)
        {
            _repository = repository;
        }

        public void Handler(CreateComprovanteRequest command)
        {
            try
            {
                //byte[] imagem = GetImage(command.ImagemCaminhoDoArquivo);
                var comprovante = new Comprovante(command.Nome, command.ImagemCaminhoDoArquivo);

                _repository.Create(comprovante);
            }catch (DirectoryNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        //private byte[] GetImage(string filePath)
        //{
        //    FileStream stream = new(filePath, FileMode.Open, FileAccess.Read);
        //    BinaryReader reader = new(stream);

        //    byte[] image = reader.ReadBytes((int)stream.Length);

        //    reader.Close();
        //    stream.Close();

        //    return image;
        //}
    }
}
