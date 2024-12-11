using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interrogazione
{
    internal class Bancomat
    {
        private string numCarta;
        private ContoCorrente contoCorrente;
     

        public Bancomat(string numCarta, ContoCorrente contoCorrente)
        {
            this.numCarta = numCarta;
            this.contoCorrente = contoCorrente;
        }
        public string NumCarta { get { return numCarta; } }
        public ContoCorrente Conto { get { return contoCorrente; } }

        public void Prelevare(double cifra)
        {
            contoCorrente.Prelievo(cifra);  
        }

        public void Depositare(double cifra)
        {
            contoCorrente.Deposito(cifra);
        }
    }
}
