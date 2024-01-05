using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasksManager.Controller;

namespace TasksManager.Security
{
    internal static class Sessao
    {
        private static bool _logado = false;
        
        internal static bool RealizarLogin()
        {
            Console.WriteLine("Digite seu CPF: ");
            var cpf = Console.ReadLine();

            Console.WriteLine("Digite sua Senha: ");
            var senha = Console.ReadLine();

            var usuario = UsuarioController.BuscarUsuarioById(cpf);       
            
            if (usuario == null)
            {
                Console.WriteLine("Usuário ou senha inválidos");
                return false;
            }
            else
            {
                if(usuario.VerificaSenha(senha))
                {
                    Console.WriteLine("Usuário ou senha inválidos");
                    return true;
                }
                else 
                {
                    Console.WriteLine("Senha inválida");
                    return false;
                }
            }
        }
    }
}
