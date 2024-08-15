using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_Santo_Andre
{
    internal class Conta : Correntista
    {
        

        public Correntista correntista;

        public int Tipo;

        private double Saldo;

        public string Agencia;

        public string Numero;

        private double Limite;
        

        public void setSaldo(double saldo)
        {
            Saldo = saldo;
        }

        public double getSaldo()
        {
            return Saldo;
        }

        public void setLimite(double limite)
        {
            Limite = limite;
        }

        public double getLimite()
        {
            return Limite;
        }
    }
}