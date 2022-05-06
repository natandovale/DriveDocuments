using DriveDocuments.Domain.Commands.RequestComprovante;
using DriveDocuments.Domain.Entities;
using DriveDocuments.Domain.Handlers.Interfaces;
using DriveDocuments.Domain.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveDocuments.Domain.Handlers.ComprovanteHandler.RequestComprovanteHandler
{
    class UpdateComprovanteHandler : IRequestHandler<UpdateComprovanteRequest>
    {
        private readonly IComprovanteRepository _repository;
        public UpdateComprovanteHandler(IComprovanteRepository repository)
        {
            _repository = repository;
        }
        public void Handler(UpdateComprovanteRequest command)
        {
            try
            {
                var dataAtualizacao = DateTime.Now;
                var comprovante = new Comprovante(command.Id, command.Nome, command.Beneficiario, dataAtualizacao);
                _repository.Update(comprovante);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
