using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actuacion_POO
{
    // La interfaz Operacion define los métodos que deben implementars
    internal interface Operacion
    {
        // métodos para realizar las operaciones
        int sumar();
        int restar();
        int multiplicar();
        int dividir();
    }
}