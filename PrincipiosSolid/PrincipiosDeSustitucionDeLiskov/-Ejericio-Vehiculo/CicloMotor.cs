using System;
using System.Collections.Generic;
using System.Text;

namespace PrincipiosSolid.PrincipiosDeSustitucionDeLiskov._Ejericio_Vehiculo
{
    public class CicloMotor: Vehiculo
    {
        public string ObtenerNumLicencia()
        {
            return "112-sdd";
        }
    }
}
