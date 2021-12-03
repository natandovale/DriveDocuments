using System.Collections.Generic;

namespace DriveDocuments.Domain.Entities
{
    public class Categoria
    {
        public string Nome { get; private set; }
        public List<Comprovante> Comprovantes { get; private set; }

        public void Adiciona(Comprovante comprovante)
        {
            Comprovantes.Add(comprovante);
        }
    }
}
