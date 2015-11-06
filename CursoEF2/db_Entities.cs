using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoEF2
{
    public class db_Entities : DbContext
    {
        public db_Entities() : base(nameOrConnectionString: "DBConexao") { }

        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Departamentos> Departamentos { get; set; }
        public DbSet<Filial> Filiais { get; set; }
    }
}
