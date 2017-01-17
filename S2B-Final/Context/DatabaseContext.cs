using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using S2B_Final.Models;

namespace S2B_Final.Context
{
    public class DatabaseContext : DbContext
    {
        public DbSet<DenunciaModel> Denuncia { get; set; }

        public DatabaseContext() : base("DefaultConnection")
        {

        }
    }
}