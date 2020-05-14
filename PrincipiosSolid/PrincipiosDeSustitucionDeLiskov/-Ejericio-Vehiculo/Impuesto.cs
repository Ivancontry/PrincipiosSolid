using System;
using System.Collections.Generic;
using System.Text;

namespace PrincipiosSolid.PrincipiosDeSustitucionDeLiskov._Ejericio_Vehiculo
{
    public class Impuesto
    {
        public void CalcularImpuesto(Vehiculo vehiculo) {

            string matricula = ((Coche)vehiculo).ObtenerMatricula();
           
            ServicioCalcularImpuesto(matricula, vehiculo);

        }

        public void CalcularImpuesto2(Vehiculo vehiculo)
        {

            string matricula = string.Empty;
            if (vehiculo.GetType().Name == "Coche") {
               matricula = ((Coche)vehiculo).ObtenerMatricula();
            }
            else
            {
                if (vehiculo.GetType().Name == "CicloMotor") matricula = ((CicloMotor)vehiculo).ObtenerNumLicencia(); 
            }

            ServicioCalcularImpuesto(matricula, vehiculo);

        }

        public void ServicioCalcularImpuesto(string matricula, Vehiculo vehiculo) { 
        
        }
    }

   
}
