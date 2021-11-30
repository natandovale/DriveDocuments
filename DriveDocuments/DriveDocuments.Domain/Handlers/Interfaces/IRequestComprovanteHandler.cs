using DriveDocuments.Domain.Commands.RequestComprovante;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveDocuments.Domain.Handlers.Interfaces
{
    interface IRequestComprovanteHandler
    {
        void HandlerCreate(CreateComprovanteRequest command);
        void HandlerDelete(int id);
        void HandlerUpdate(CreateComprovanteRequest command);
    }
}
