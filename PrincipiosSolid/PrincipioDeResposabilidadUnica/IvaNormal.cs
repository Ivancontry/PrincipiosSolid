using System;
using System.Collections.Generic;
using System.Text;

namespace PrincipiosSolid.PrincipioDeResposabilidadUnica
{
    public class IvaNormal
    {

        private const double PORCENTAJEIVANORMAL = 0.16;
        public IvaNormal()
        {

        }
        
        public double CalcularIva(double importe) {
            return importe * PORCENTAJEIVANORMAL;

        }
    }
}
