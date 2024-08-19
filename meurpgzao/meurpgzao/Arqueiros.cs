using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace meurpgzao
{
    internal class Arqueiros : Personagem
    {
        public Arqueiros()
        {
            Nome = "Robin";
            Especialidade = "Arqueiro";
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

            Forca = 30;
            Agilidade = 30;
            Vitalidade = 20;
            Energia = 5;

            void CalcularDano1skill()
            {
                PontosDeStamina = (Forca + (PontosStamina * (Forca / 100)) + (Nivel + 1) * (PontosStamina / 100));
                ConsumoDeStamina = PontosDeStamina * ((PontosDeStamina + 1) / 100);
            }
            void CalcularDano2skill()
            {
                PontosDeStamina = (Forca + (PontosStamina * (Forca / 100)) + (Nivel + 5) * (PontosStamina / 100));
                ConsumoDeStamina = PontosDeStamina * ((PontosDeStamina + 1) / 100);
            }
            void CalcularDanoUltimate()
            {
                PontosDeStamina = (Forca + (PontosStamina * (Forca / 100)) + (Nivel + 10) * (PontosStamina / 100));
                ConsumoDeStamina = PontosDeStamina * ((PontosDeStamina + 1) / 100);
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
