using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoEF2
{
    public class MainViewModel : ModelBase
    {
        private ObservableCollection<Funcionario> funcionarios;

        public ObservableCollection<Funcionario> Funcionarios
        {
            get { return funcionarios; }
            set { funcionarios = value; }
        }


        public MainViewModel()
        {
            Funcionarios = new ObservableCollection<Funcionario>();
            using (db_Entities db = new db_Entities())
            {
                foreach (var item in db.Funcionarios.Include("Departamento").Include("Filial"))
                {
                    Funcionario func = new Funcionario();

                    func.Id = item.Id;
                    func.Nome = item.Nome;
                    func.Idade = item.Idade;
                    func.departamento = item.departamento;

                    Funcionarios.Add(func);
                }
            }
        }

    }
}
