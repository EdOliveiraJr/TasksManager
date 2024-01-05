using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasksManager.Enum;

namespace TasksManager.Model
{
    internal class Desenvolvedor : Usuario
    {
        public Desenvolvedor(string nome, string cpf, Cargo cargo) : base(nome, cpf, cargo)
        {
        }

        internal override Tarefa CriarTarefa()
        {
            throw new NotImplementedException();
        }

        internal override bool RealizarLogin()
        {
            throw new NotImplementedException();
        }
    }
}
