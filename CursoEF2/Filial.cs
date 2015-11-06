using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoEF2
{
    public class Filial
    {
        [Key]
        public int Id { get; set; }

        public string RazaoSocial { get; set; }

        public virtual ICollection<Funcionario> Funcionarios { get; set; }

        public override string ToString()
        {
            return string.Format("{0}.{1}", Id, RazaoSocial);
        }
    }
}
