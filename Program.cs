using TasksManager.Controller;

namespace TasksManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UsuarioController.ListarTodosUsuarios();
            TarefaController.ListarTodasTarefas();
        }
    }
}
