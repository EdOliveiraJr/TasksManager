using TasksManager.Controller;
using TasksManager.Security;

namespace TasksManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UsuarioController.ListarTodosUsuarios();
            
            TarefaController.ListarTodasTarefas();

            Sessao.RealizarLogin();

        }
    }
}
