using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveDocuments.Domain.Commands.RequestComprovante
{
    public class UpdateComprovanteRequest
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Beneficiario { get; set; }
    }
}
