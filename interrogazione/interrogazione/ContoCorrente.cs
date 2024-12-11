using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interrogazione
{
    internal class ContoCorrente
    {
        private string nomeCliente;
        private string nomeBanca;
        private double saldo;



        public ContoCorrente(string nomeCliente, string nomeBanca, double saldo)
        {
            this.nomeCliente = nomeCliente;
            this.nomeBanca = nomeBanca;
            this.saldo = saldo;

        }
    
        public void Prelievo(double cifra)
        {
        /*if (saldo < denaroPrelevato)
        {
            MessageBox.Show("Non puoi prelevare");
        }
        else
            */
            saldo = saldo - cifra;

        }

        public void Deposito(double cifra)
        {
            saldo = saldo + cifra;
        }
        public double Saldo { get { return saldo; } }
    }
   
}
