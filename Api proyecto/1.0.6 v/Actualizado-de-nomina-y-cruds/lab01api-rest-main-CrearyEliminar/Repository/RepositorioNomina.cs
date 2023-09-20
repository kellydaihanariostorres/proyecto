using Contracts;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RepositorioNomina : RepositoryBase<Nomina>, IRepositorioNomina
    {
        public RepositorioNomina(RepositoryContext repositoryContext)
           : base(repositoryContext)
        {
        }

        public IEnumerable<Nomina> GetAllNominas(bool trackChanges) =>
            FindAll(trackChanges)
            .OrderBy(c => c.Email)
            .ToList();

        public Nomina GetNomina(Guid nominaId, bool trackChanges) =>
             FindByCondition(p => p.NominaId.Equals(nominaId), trackChanges)
            .SingleOrDefault();

       

    }
}
