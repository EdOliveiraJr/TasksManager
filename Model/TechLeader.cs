using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using TasksManager.Controller;
using TasksManager.Enum;

namespace TasksManager.Model
{
    internal class TechLeader : Usuario
    {
        public TechLeader(string nome, string cpf, Cargo cargo) : base(nome, cpf, cargo)
        {
        }

        internal override bool CriarTarefa( string titulo, string? descricao, string resposavel)
        {
            
            TarefaController.AdicionarTarefa(titulo, descricao, this.cpf, resposavel);
            return true;
        }

    }
}
