using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Promobusque.Dominio
{
    public class Contexto : DbContext
    {

        public Contexto() : base("PromobusqueMDF")
        {
        }

        public DbSet<Empresa> Empresa { get; set; }
    }
}
