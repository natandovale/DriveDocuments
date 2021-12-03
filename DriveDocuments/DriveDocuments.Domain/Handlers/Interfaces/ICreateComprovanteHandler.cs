using DriveDocuments.Domain.Commands.RequestComprovante;

namespace DriveDocuments.Domain.Handlers.Interfaces
{
    public interface ICreateComprovanteHandler
    {
        void Handler(CreateComprovanteRequest command);
    }
}
