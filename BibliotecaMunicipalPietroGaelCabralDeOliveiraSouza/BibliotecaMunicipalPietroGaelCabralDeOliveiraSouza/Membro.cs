using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaMunicipalPietroGaelCabralDeOliveiraSouza
{
    internal class Membro
    {
        List<Livro> livro;
        Livro livros;
        public Membro(List<Livro> Livro)
        {
            Console.Clear();
            Console.WriteLine("|-----------------------------------------------------------|");
            Console.WriteLine("| Biblioteca Municipal Pietro Gael Cabral de Oliveira Souza |");
            Console.WriteLine("| [1] Nome                                                  |");
            Console.WriteLine("| [2] Número de identificação                               |");
            Console.WriteLine("| [3] Número de identificação                               |");
            Console.WriteLine("| [4] Livros emprestados                                    |");
            Console.WriteLine("| [9] Voltar                                                |");
            Console.WriteLine("|-----------------------------------------------------------|");
            Console.WriteLine("Coloque o código e precione enter");

            int resposta1 = Convert.ToInt32(Console.ReadLine());

            switch (resposta1)
            {
                case 1:

                    break;

                case 2:

                    break;

                case 9:
                    Menu menu = new Menu(Livro);
                    break;

                default:
                    Console.WriteLine("Código inválido! Precione enter!");
                    Console.ReadLine();
                    break;
            }
        }
    }
}
