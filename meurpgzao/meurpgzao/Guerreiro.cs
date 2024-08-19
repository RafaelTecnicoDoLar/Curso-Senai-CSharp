using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace meurpgzao
{
    internal class Guerreiro : Personagem
    {
        public Guerreiro()
        {
            Nome = "kratos";
            Especialidade = "Guerreiro";
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

            Forca = 40;
            Agilidade = 10;
            Vitalidade = 30;
            Energia = 3;

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
            CalcularDano1skill();
            CalcularDano2skill();
            CalcularDanoUltimate();
            CalcularVida();
            CalcularDano();
            Informacoes();

        }
    }
}