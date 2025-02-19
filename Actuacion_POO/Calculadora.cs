using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actuacion_POO
{
    internal class Calculadora : Operacion
    {
        public int numero1;
        public int numero2;

        public Calculadora()
        {
        }

        public Calculadora(int numero1, int numero2)
        {
            this.numero1 = numero1;
            this.numero2 = numero2;
        }

        public int dividir()
        {
            return numero1 / numero2;
        }

        public int multiplicar()
        {
            return numero1 * numero2;
        }

        public int restar()
        {
            return numero1 - numero2;
        }

        public int sumar()
        {
            return numero1 + numero2;
        }
    }
}
