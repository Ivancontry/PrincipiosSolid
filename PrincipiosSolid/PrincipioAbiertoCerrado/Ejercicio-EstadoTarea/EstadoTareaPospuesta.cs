using System;
using System.Collections.Generic;
using System.Text;

namespace PrincipiosSolid.PrincipioAbiertoCerrado.Ejercicio_EstadoTarea
{
    public class EstadoTareaPospuesta : EstadoTareaBase
    {
        public override void Cancelar()
        {
            
        }

        public override void Finalizar()
        {
            throw new NotImplementedException();
        }

        public override void Posponer()
        {
            throw new NotImplementedException("Tarea ya Pospuesta");
        }
    }
}
