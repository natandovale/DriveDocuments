using DriveDocuments.Domain.Handlers.Interfaces;
using DriveDocuments.Domain.Repositories.Interfaces;

namespace DriveDocuments.Domain.Handlers.ComprovanteHandler.ResponseComprovanteHandler
{
    class GetAllComprovanteHandler : IRequestHandler<GetAllComprovanteHandler>
    {
        private readonly IComprovanteRepository _repository;
        public GetAllComprovanteHandler(IComprovanteRepository repository)
        {
            _repository = repository;
        }

        public void Handler(GetAllComprovanteHandler command)
        {

            throw new System.NotImplementedException();
        }
    }
}
