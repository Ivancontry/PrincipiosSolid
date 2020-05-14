using System;
using System.Collections.Generic;
using System.Text;

namespace PrincipiosSolid.PrincipioDeResposabilidadUnica
{
    public class Deduccion
    {
        private double _porcentajeDeDevoluvion;
        public Deduccion(double porcentajeDeDevolucion)
        {
            _porcentajeDeDevoluvion = porcentajeDeDevolucion;
        }
        public double CalcularDevoluicion(double importe) {
            return (importe * _porcentajeDeDevoluvion)/100;
        }
    }
}
