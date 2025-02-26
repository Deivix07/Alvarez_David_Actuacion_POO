using System;

namespace Actuacion_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creamos intancias para probar los métodos
            Calculadora calc1 = new Calculadora(4, 8);
            Console.WriteLine($"Valores {calc1.numero1} y {calc1.numero2}");
            Console.WriteLine($"Suma = {calc1.sumar()}");
            Console.WriteLine($"Resta = {calc1.restar()}");
            Console.WriteLine($"Multiplicación = {calc1.multiplicar()}");
            Console.WriteLine($"División = {calc1.dividir()}");

            Calculadora calc2 = new Calculadora(10, 2);
            Console.WriteLine($"\nValores {calc2.numero1} y {calc2.numero2}");
            Console.WriteLine($"Suma = {calc2.sumar()}");
            Console.WriteLine($"Resta = {calc2.restar()}");
            Console.WriteLine($"Multiplicación = {calc2.multiplicar()}");
            Console.WriteLine($"División = {calc2.dividir()}");


            // Probamos la divison entre 0
            Calculadora calc3 = new Calculadora(7, 0);
            Console.WriteLine($"\nValores {calc3.numero1} y {calc3.numero2}");
            Console.WriteLine($"División = {calc3.dividir()}");
        }
    }
}
