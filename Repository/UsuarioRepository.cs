using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasksManager.Enum;
using TasksManager.Model;

namespace TasksManager.Repository
{
    internal static class UsuarioRepository
    {
        private static List<Usuario> ListaDeUsuarios = new List<Usuario>() 
        { 
            new TechLeader("Edvaldo", "01816219320", Cargo.TechLeader),
            new Desenvolvedor("Tainá", "00011122233", Cargo.Desenvolvedor),
        };

        internal static bool AdicionarUsuario(Usuario usuario)
        {

            if (usuario != null)
            {
                try
                {
                    ListaDeUsuarios.Add(usuario);
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

        internal static bool RemoverTarefa(string cpf)
        {
            try
            {
                ListaDeUsuarios.RemoveAll(usuario => usuario._cpf == cpf);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ocorreu um erro ao tentar remover a tarefa: {e.Message}");
                return false;
            }
        }

        internal static Usuario BuscarUsuarioById(string cpf) => ListaDeUsuarios.FirstOrDefault(usuario => usuario._cpf == cpf);

        internal static List<Usuario> ListarTodosUsuarios() 
        {
            return ListaDeUsuarios;
        }
    }
}
