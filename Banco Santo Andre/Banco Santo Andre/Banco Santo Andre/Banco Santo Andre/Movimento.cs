using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Banco_Santo_Andre
{
    internal class Movimento
    {
        List<Conta> contas;
        Correntista correntista;
        Conta conta;
        public Movimento(List<Conta> contas)
        {
            Console.Clear();
            Console.WriteLine("                   Banco Santo André                       ");
            Console.WriteLine($"Bem-vindo de volta: {contas.Pronome} {contas.Nome}");
            Console.WriteLine("[1] Deposito");
            Console.WriteLine("[2] Saque");
            Console.WriteLine("[3] Extrato");
            Console.WriteLine("[4] Ver limite");
            Console.WriteLine("[5] Atualizar informações da conta");
            Console.WriteLine("[9] Sair e voltar para o menu principal");

            int Randola = Convert.ToInt32(Console.ReadLine());

            switch (Randola)
            {
                case 1:
                    //Depositas

                    break;

                case 2:
                    //Saque

                    break;

                case 3:
                    //Extrato

                    break;

                case 4:
                    //ver limite

                    break;

                case 5:
                    //atualizar informações da conta
                    break;

                case 9:
                    PaginaInicial paginainicial = new PaginaInicial(contas);
                    break;

                default:
                    Console.WriteLine("Dados inválidos, Tente novamente");
                    Console.ReadLine();
                    Movimento movimento = new Movimento(contas);
                    break;
            }
        }
        //1 - entrada
        //2 - saida
        public int Tipo;

        //ex. deposito, saque...
        public string Nome;
        //ex. 59.90
        public double valor;

        
    }
}