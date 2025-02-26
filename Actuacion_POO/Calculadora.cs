using System;

namespace Actuacion_POO
{
    // Calculadora hereda de la clase Operacion
    internal class Calculadora : Operacion
    {
        // Declaración de los atributos
        public int numero1;
        public int numero2;

        public Calculadora() { }

         // Constructor que recibe dos parámetros
        public Calculadora(int numero1, int numero2)
        {
            this.numero1 = numero1;
            this.numero2 = numero2;
        }

        public int sumar()      // Método para sumar
        {
            return numero1 + numero2;
        }

        public int restar()     // Método para restar
        {
            return numero1 - numero2;
        }

        public int multiplicar()        // Método para multiplicacion
        {
            return numero1 * numero2;
        }

        public int dividir()   // Método para división
        {
            if (numero2 == 0)   // Verifica si numero2 es 0 para evitar la división por 0
            {
                Console.WriteLine("Error, no se puede dividir entre 0");
                return 0;
            }
            return numero1 / numero2; // Si no hay error, realiza la división
        }

    }
}
