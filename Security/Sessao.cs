using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasksManager.Controller;
using TasksManager.Model;

namespace TasksManager.Security
{
    internal static class Sessao
    {
        private static Usuario? _usuario { get; set; }
        private static bool _logado = false;
 
        internal static bool RealizarLogin()
        {
            Console.WriteLine("Digite seu CPF: ");
            var cpf = Console.ReadLine();

            Console.WriteLine("Digite sua Senha: ");
            var senha = Console.ReadLine();

            _usuario = UsuarioController.BuscarUsuarioById(cpf);       
            
            if (_usuario == null)
            {
                Console.WriteLine("Usuário ou senha inválidos");
                return false;
            }
            else
            {
                if(_usuario.VerificaSenha(senha))
                {
                    Console.WriteLine("Sessão iniciada!");
                    _logado = true;
                    return true;
                }
                else 
                {
                    Console.WriteLine("Usuário ou senha inválidos");
                    return false;
                }
            }
        }
    }
}
