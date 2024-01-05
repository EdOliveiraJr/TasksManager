using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TasksManager.Enum;

namespace TasksManager.Model
{
    internal abstract class Usuario
    {
        internal string _nome { get; set; }
        internal Cargo _cargo { get; set; }
        internal string _cpf { get; private set; }

        internal Usuario(string nome, string cpf, Cargo cargo)
        {
            _nome = nome;
            _cpf = cpf;
            _cargo = cargo;
        }

        internal abstract Tarefa CriarTarefa();

        internal abstract bool RealizarLogin();

        public override string ToString()
        {
            return $"CPF: {_cpf}\n" +
                $"Nome: {_nome}\n" +
                $"Cargp: {_cargo}\n";
        }

    }
}
