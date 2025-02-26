using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Perimetro_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            // Creamos un arreglo de objetos
            Matematica[] matematicas = new Matematica[2];

            //Creamos intancias para probar los métodos
            matematicas[0] = new PACuadrado(2,3);
            matematicas[1] = new PATriangulo(7,5);

            // Usamos un bucle foreach para recorrer cada elemento del arreglo
            foreach(Matematica matematica in matematicas)
            {
                // Imprimimos el resultado
                Console.WriteLine(matematica.resultado());
            }
        }
    }
}