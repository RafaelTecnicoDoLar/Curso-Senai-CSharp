using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaMunicipalPietroGaelCabralDeOliveiraSouza
{
    internal class PaginaInicial
    {
        Menu menu;
        List<Livro> livro;
        Livro livros;

        public PaginaInicial() 
        {

            List<Livros> Livro = new List<Livros>();
            Menu menu = new Menu(Livro);
        }

    }

}
