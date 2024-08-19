using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class espera
    {
        private static List<string> listMenu;
        public void Espera(List <string> ListaEspera) 
        {
            menu ExibirMenu2 = new menu();
            Console.WriteLine("Precione enter para continuar");
            Console.ReadLine();
            ExibirMenu2.Menu(listMenu);
        }

        internal void Espera(object listaEspera)
        {
            throw new NotImplementedException();
        }
    }
}
