using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace CursoEF2
{
    public class Funcionario
    {
        [Key]
        public int Id { get; set; }

        public string Nome { get; set; }

        public int Idade { get; set; }

        public double Salario { get; set; }

        public virtual Departamentos departamento { get; set; }
        public virtual Filial filial { get; set; }
    }
}
