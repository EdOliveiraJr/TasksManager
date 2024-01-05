using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TasksManager.Repository;

namespace TasksManager.Controller
{
    internal static class TarefaController
    {
        public static void AdicionarTarefa(string titulo, string descricao, string cpf)
        {
            var usuario = UsuarioController.BuscarUsuarioById(cpf);  
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
