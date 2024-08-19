using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaMunicipalPietroGaelCabralDeOliveiraSouza
{
    internal class Livros
    {
        List<Livro> livro;
        Livro livros;
        public Livros(List<Livro> Livro)
        {
            Console.Clear();
            Console.WriteLine("|-----------------------------------------------------------|");
            Console.WriteLine("| Biblioteca Municipal Pietro Gael Cabral de Oliveira Souza |");
            Console.WriteLine("| [1] Emprestar                                             |");
            Console.WriteLine("| [2] Devolver                                              |");
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
