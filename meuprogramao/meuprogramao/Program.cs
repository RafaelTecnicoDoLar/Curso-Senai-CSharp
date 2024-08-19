using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace meuprogramao
{
    internal class Program
    {
        static void Main()
        {
            Carro novo_carro = new Carro();
            novo_carro.placa = "FDP-1857";
            novo_carro.modelo = "Marea";
            novo_carro.cor = "Branco";
            novo_carro.numero_portas = 4;
            novo_carro.valor = 8000;
        }
    }
}