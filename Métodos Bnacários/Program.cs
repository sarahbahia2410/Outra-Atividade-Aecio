using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Métodos_Bnacários
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            float saldo;

            void CadastrarUsuario()
            {
                Console.WriteLine("Informe o nome do usuário:");
                nome = Console.ReadLine();
                Console.WriteLine("Informe o saldo do usuário:");
                saldo = float.Parse(Console.ReadLine());
            }
            void ConsultarConta()
            {
                Console.WriteLine("A conta de "  + nome+ " possui R$ " + saldo);
            }

            void apagarconta()
            {
                saldo = 0;
                nome = " ";

                

            }
            

            Console.WriteLine("Pressione ENTER para sair...");
            Console.Read();
        }
    }
}
