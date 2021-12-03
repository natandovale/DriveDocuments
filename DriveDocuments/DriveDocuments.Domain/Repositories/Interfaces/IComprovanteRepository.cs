using DriveDocuments.Domain.Entities;
using System.Collections.Generic;

namespace DriveDocuments.Domain.Repositories.Interfaces
{
    public interface IComprovanteRepository
    {
        public void Create(Comprovante product);
        IEnumerable<Comprovante> Get();
        //IEnumerable<Product> Get(int id);
        Comprovante Get(int id);
        public void Update(Comprovante product);
        public void Delete(int id);
    }
}
