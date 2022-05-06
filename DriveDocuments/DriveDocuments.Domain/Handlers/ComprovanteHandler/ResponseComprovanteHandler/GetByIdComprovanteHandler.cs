using DriveDocuments.Domain.Handlers.Interfaces;
using DriveDocuments.Domain.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveDocuments.Domain.Handlers.ComprovanteHandler.ResponseComprovanteHandler
{
    class GetByIdComprovanteHandler : IRequestHandler<GetAllComprovanteHandler>
    {
        private readonly IComprovanteRepository _repository;
        public GetByIdComprovanteHandler(IComprovanteRepository repository)
        {
            _repository = repository;
        }

        public void Handler(GetAllComprovanteHandler command)
        {
            throw new NotImplementedException();
        }
    }
}
