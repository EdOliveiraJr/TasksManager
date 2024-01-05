using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TasksManager.Controller;
using TasksManager.Enum;

namespace TasksManager.Model
{
    internal class Desenvolvedor : Usuario
    {
        public Desenvolvedor(string nome, string cpf, Cargo cargo) : base(nome, cpf, cargo)
        {
        }

        internal override bool CriarTarefa(string titulo, string? descricao, string responsavel)
        {
            responsavel = this.nome;

            TarefaController.AdicionarTarefa(titulo, descricao, this.cpf, responsavel);
            return true;
        }

    }
}
