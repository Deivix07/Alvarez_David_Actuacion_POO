using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actuacion_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculadora calculadora = new Calculadora(4,8);
            Console.WriteLine(calculadora.sumar());
            Console.WriteLine(calculadora.restar());
            Console.WriteLine(calculadora.multiplicar());
            Console.WriteLine(calculadora.dividir());
        }
    }
}
