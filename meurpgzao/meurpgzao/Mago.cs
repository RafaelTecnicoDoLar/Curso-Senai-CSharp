using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace meurpgzao
{
    internal class Mago : Personagem
    {
        public Mago()
        {
            Nome = "Theobaldo";
            Especialidade = "Mago";
            Nivel = 10;

            PontosVida = 100;
            PontosStamina = 50;
            PontosMana = 50;

            PontosDeVida = 0;
            PontosDeStamina = 0;
            PontosDeMana = 0;
            ConsumoDeStamina = 0;
            ConsumoDeMana = 0;
            Defesa = 0;

            Forca = 10;
            Agilidade = 10;
            Vitalidade = 25;
            Energia = 40;

            void CalcularDano1skill()
            {
                PontosDeMana = (Energia + (PontosDeMana * (Energia / 100)) + (Nivel + 1) * (PontosDeMana / 100));
                ConsumoDeMana = PontosDeMana * ((PontosDeMana + 1) / 100);
            }
            void CalcularDano2skill()
            {
                PontosDeMana = (Energia + (PontosDeMana * (Energia / 100)) + (Nivel + 5) * (PontosDeMana / 100));
                ConsumoDeMana = PontosDeMana * ((PontosDeMana + 5) / 100);
            }
            void CalcularDanoUltimate()
            {
                PontosDeMana = (Energia + (PontosDeMana * (Energia / 100)) + (Nivel + 10) * (PontosDeMana / 100));
                ConsumoDeMana = PontosDeMana * ((PontosDeMana + 10) / 100);
            }

            CalcularVida();
            CalcularDano();
            Informacoes();
            CalcularDano1skill();
            CalcularDano2skill();
            CalcularDanoUltimate();
        }
    }
}