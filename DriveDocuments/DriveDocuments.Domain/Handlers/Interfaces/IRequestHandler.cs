using DriveDocuments.Domain.Commands.RequestComprovante;

namespace DriveDocuments.Domain.Handlers.Interfaces
{
    public interface IRequestHandler<T>
    {
        void Handler(T command);
    }
}
