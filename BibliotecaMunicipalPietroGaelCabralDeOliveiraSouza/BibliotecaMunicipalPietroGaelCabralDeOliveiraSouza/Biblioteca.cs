using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaMunicipalPietroGaelCabralDeOliveiraSouza
{
    internal class Biblioteca
    {

        List<Livro> livro;
        Livro livros;
        public Biblioteca(List<Livro> Livro)
        {
            Menu menu;
            livro = livro;
            Console.Clear();
            Console.WriteLine("|-----------------------------------------------------------|");
            Console.WriteLine("| Biblioteca Municipal Pietro Gael Cabral de Oliveira Souza |");
            Console.WriteLine("|                                                           |");
            Console.WriteLine("| [1] Adicionar Livros                                      |");
            Console.WriteLine("| [2] Adicionar Membro                                      |");
            Console.WriteLine("| [3] Consultar Numero de Identificação                     |");
            Console.WriteLine("| [4] Consultar Devolução                                   |");
            Console.WriteLine("| [9] voltar                                                |");
            Console.WriteLine("|-----------------------------------------------------------|");
            Console.WriteLine("Coloque o código e precione enter");

            int resposta = Convert.ToInt32(Console.ReadLine());

            switch (resposta)
            {
                case 1:
                    Livros paginalivro = new Livros(livro);
                    break;

                case 2:

                    break;

                case 3:

                    break;
                case 4:

                    break;
                case 9:
                    menu = new Menu(Livro);
                    break;

                default:
                    Console.WriteLine("Código inválido! Precione enter!");
                    Console.ReadLine();
                    break;
            }
        }

        
    }
}
