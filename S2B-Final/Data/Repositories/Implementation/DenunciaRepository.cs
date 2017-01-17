using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using S2B_Final.Data.Repositories.Interfaces;
using S2B_Final.Data.UO;
using S2B_Final.Models;

namespace S2B_Final.Data.Repositories.Implementation
{
    public class DenunciaRepository : GenericRepository<DenunciaModel>, IDenunciaRepository
    {
        public DenunciaRepository(UnitOfWork uo)
            : base(uo)
        {

        }

        public IQueryable<DenunciaModel> PesquisarPorLocal(string local)
        {
            return this._unitOfWork.Context.Denuncia.Where(c => c.LocalOcorrido.Trim().Contains(local.Trim()));
        }
    }
}