using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class remover
    {
        produto ExibirLista = new produto();
        public List<string> Listar { get; private set; }
        public void Remover_Produto()
        {
            ExibirLista.ListName(Listar);
        }
    }
}
