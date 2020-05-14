using System;
using System.Collections.Generic;
using System.Text;

namespace PrincipiosSolid.PrincipiosDeSustitucionDeLiskov.Ejercicio_Calculadora
{
    public class OperacionSumar : Operacion
    {
        public override double Calcular()
        {
            return this.OperandoUno + this.OperandoDos;
        }
    }
}
