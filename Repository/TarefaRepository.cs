using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasksManager.Model;

namespace TasksManager.Repository
{
    internal class TarefaRepository
    {
        private List<Tarefa> ListaDeTarefas = new List<Tarefa>();

        internal bool AdicionarTarefa(Tarefa tarefa)
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

        internal bool RemoverTarefa(Guid id)
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
    }
}
