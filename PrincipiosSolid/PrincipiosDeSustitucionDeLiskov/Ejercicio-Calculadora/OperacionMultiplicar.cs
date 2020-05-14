using System;
using System.Collections.Generic;
using System.Text;

namespace PrincipiosSolid.PrincipiosDeSustitucionDeLiskov.Ejercicio_Calculadora
{
    public class OperacionMultiplicar : Operacion
    {
        public override double Calcular()
        {
             return this.OperandoUno*this.OperandoDos;   
        }
    }
}
