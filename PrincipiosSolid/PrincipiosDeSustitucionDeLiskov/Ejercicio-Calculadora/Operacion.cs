using System;
using System.Collections.Generic;
using System.Text;

namespace PrincipiosSolid.PrincipiosDeSustitucionDeLiskov.Ejercicio_Calculadora
{
    public abstract class Operacion
    {
        public double OperandoUno { get; set; }
        public double OperandoDos { get; set; }

        public abstract double Calcular();
    }
}
