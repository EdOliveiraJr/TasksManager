using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasksManager.Model;

namespace TasksManager.Repository
{
    internal class UsuarioRepository
    {
        private List<Usuario> ListaDeUsuarios = new List<Usuario>();

        internal bool AdicionarUsuario(Usuario usuario)
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

        internal bool RemoverTarefa(string cpf)
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
    }
}
