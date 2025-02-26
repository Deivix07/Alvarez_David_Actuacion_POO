using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Perimetro_Area
{
    class Matematica : Operacion
    {
        // Declaración de los atributos
        public int lado;
        public int area;

         // Constructor que recibe dos parámetros
        public Matematica(int lado, int area)
        {
            this.lado = lado;
            this.area = area;
        }

        public virtual string resultado()
        {
            return $"Perimetro y Area";
        }
    }

    // Clase PATriangulo que hereda de Matematica
    class PATriangulo : Matematica
    {
        // Constructor que pasa los parámetros a la clase base
        public PATriangulo(int lado, int area) : base(lado, area)
        {
        }

        // Sobrescribe el método resultado de la clase base para calcular el perímetro y el área del triángulo
        public override string resultado()
        {
            int perimetro = lado * 3;
            int areaTriangulo = (lado * area) / 2;
            // Devuelve una cadena con los resultados
            return $"Perimetro Triángulo: {perimetro}\nÁrea Triángulo: {areaTriangulo}";
        }
    }

    internal class PACuadrado : Matematica
    {
        public PACuadrado(int lado, int area) : base(lado, area)
        {
        }

        public override string resultado()
        {
            int perimetro = lado * 4;
            int areaCuadrado = lado * lado;
            return $"Perimetro Cuadrado: {perimetro}\nÁrea Cuadrado: {areaCuadrado}";
        }
    }
}