using DriveDocuments.Domain.Commands.RequestComprovante;
using DriveDocuments.Domain.DTOs;
using DriveDocuments.Domain.Handlers.Interfaces;
using DriveDocuments.Domain.Repositories.Interfaces;
using DriveDocuments.Domain.Services;

namespace DriveDocuments.Domain.Handlers.ComprovanteHandler.RequestComprovanteHandler
{
    public class DeleteComprovanteHandler : IRequestHandler<DeleteComprovanteRequest>
    {
        private readonly IComprovanteRepository _repository;
        public DeleteComprovanteHandler(IComprovanteRepository repository)
        {
            _repository = repository;
        }
        public void Handler(DeleteComprovanteRequest command)
        {
            var comprovante = _repository.Get(command.Id);
            var dto = new InformacoesImgemBlobsDTO(comprovante.FileName);
            FileDelete.DeletaImagem(dto);
            _repository.Delete(command.Id);
        }
    }
}

