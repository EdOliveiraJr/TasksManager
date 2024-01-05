using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using TasksManager.Enum;
using TasksManager.Security;

namespace TasksManager.Model
{
    internal abstract class Usuario
    {
        internal string nome { get; set; }
        internal Cargo cargo { get; set; }
        internal string cpf { get; private set; }
        
        private string Senha;

        internal Usuario(string nome, string cpf, Cargo cargo)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.cargo = cargo;
            this.Senha = cpf;
        }

        internal abstract Tarefa CriarTarefa();
        
        internal bool VerificaSenha(string senha)
        {
            if (this.Senha.Equals(senha)) return true;
            return false;
        }

        public override string ToString()
        {
            return $"CPF: {cpf}\n" +
                $"Nome: {nome}\n" +
                $"Cargp: {cargo}\n";
        }

    }
}
