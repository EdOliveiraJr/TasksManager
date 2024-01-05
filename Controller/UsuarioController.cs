using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasksManager.Model;
using TasksManager.Repository;

namespace TasksManager.Controller
{
    internal static class UsuarioController
    {
      
        internal static Usuario BuscarUsuarioById(string cpf)
        {
            Usuario usuario = UsuarioRepository.BuscarUsuarioById(cpf);
            return usuario;
        }

        internal static Usuario BuscarUsuarioByNome(string nome)
        {
            Usuario usuario = UsuarioRepository.BuscarUsuarioByNome(nome);
            return usuario;
        }

        internal static void ListarTodosUsuarios()
        {
            var usuarios = UsuarioRepository.ListarTodosUsuarios();

            foreach (var usuario in usuarios)
            {
                Console.WriteLine(usuario.ToString());
            }
        }

    }
}
