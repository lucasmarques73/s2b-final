using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using S2B_Final.Models;
using S2B_Final.Data.Repositories.Interfaces;

namespace S2B_Final.Data.Repositories.Interfaces
{
    interface IDenunciaRepository : IGenericRepository<DenunciaModel>
    {
        IQueryable<DenunciaModel> PesquisarPorLocal(string local);
    }
}