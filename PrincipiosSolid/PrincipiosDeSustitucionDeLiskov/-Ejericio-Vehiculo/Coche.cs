using System;
using System.Collections.Generic;
using System.Text;

namespace PrincipiosSolid.PrincipiosDeSustitucionDeLiskov._Ejericio_Vehiculo
{
    public class Coche:Vehiculo
    {
        public string ObtenerMatricula() {
            return "wrt-122";
        }
    }
}
