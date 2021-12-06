using DriveDocuments.Domain.Commands.RequestComprovante;
using DriveDocuments.Domain.Entities;
using DriveDocuments.Domain.Handlers.Interfaces;
using DriveDocuments.Domain.Repositories.Interfaces;
using DriveDocuments.Domain.Services;
using System;
using System.IO;

namespace DriveDocuments.Domain.Handlers.ComprovanteHandler.RequestComprovanteHandler
{
    public class CreateComprovanteHandler : IRequestHandler<CreateComprovanteRequest>
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
                //Salva a imagem no azure stored e retorn a url
                var blobsInformacoes = FileUpload.UploadBase64image(command.ImagemBase64, "demo");
                var dataCriacao = DateTime.Now;

                var comprovante = new Comprovante(command.Nome, command.Beneficiario, dataCriacao, blobsInformacoes.Uri, blobsInformacoes.Nome);

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
    }
}
