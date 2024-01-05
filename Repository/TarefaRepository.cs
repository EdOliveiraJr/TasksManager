using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasksManager.Model;

namespace TasksManager.Repository
{
    internal static class TarefaRepository
    {
        private static List<Tarefa> ListaDeTarefas = new()
        { 
            new Tarefa(null,null,"Tarefa 1", "Descrição 1"),
            new Tarefa(null,null,"Tarefa 2", "Descrição 2"),
        };

        internal static bool AdicionarTarefa(Tarefa tarefa)
        {
                 
            if(tarefa != null)
            {
                try
                {
                    ListaDeTarefas.Add(tarefa);
                    return true;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Ocorreu um erro ao tentar adicionar uma nova tarefa: {e.Message}");
                    return false;
                }
            }
            return false;
            
        }

        internal static bool RemoverTarefa(Guid id)
        {
            try
            {
                ListaDeTarefas.RemoveAll(tarefa => tarefa._id == id);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ocorreu um erro ao tentar remover a tarefa: {e.Message}");
                return false;
            }
        }

        internal static Tarefa BuscarTarefaById(Guid id) => ListaDeTarefas.FirstOrDefault(tarefa => tarefa._id == id);

        internal static List<Tarefa> ListarTodasTarefas()
        {
            return ListaDeTarefas;
        }
    }
}

