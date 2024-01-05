using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TasksManager.Enum;
using TasksManager.Model;
using TasksManager.Repository;

namespace TasksManager.Controller
{
    internal static class TarefaController
    {
        public static bool AdicionarTarefa(string titulo, string? descricao, string cpf)
        {
            var criador = UsuarioController.BuscarUsuarioById(cpf);

            if (criador.cargo == Cargo.Desenvolvedor)
            {
                TarefaRepository.AdicionarTarefa(new Tarefa(criador, criador, titulo, descricao));
                return true;
            }
            return false;
        }

        public static bool AdicionarTarefa(string titulo, string? descricao, string cpfCriador, string nomeResponsavel)
        {
            var criador = UsuarioController.BuscarUsuarioById(cpfCriador);

            var usuario = UsuarioController.BuscarUsuarioByNome(nomeResponsavel);

            if (criador.cargo == Cargo.TechLeader)
            {
                TarefaRepository.AdicionarTarefa(new Tarefa(criador, usuario, titulo, descricao));
                return true;
            }
            return false;
        }
        internal static void ListarTodasTarefas()
        {
            var tarefas = TarefaRepository.ListarTodasTarefas();

            foreach (var tarefa in tarefas)
            {
                Console.WriteLine(tarefa.ToString());
            }
        }
    }
}
