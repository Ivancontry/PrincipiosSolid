using System;
using System.Collections.Generic;
using System.Text;

namespace PrincipiosSolid.PrincipioAbiertoCerrado.Ejercicio_EstadoTarea
{
    public class EstadoTareaFinalizada : EstadoTareaBase
    {
        public override void Cancelar()
        {
            throw new NotImplementedException("Imposible, Tarea finalizada");
        }

        public override void Finalizar()
        {
            throw new NotImplementedException("Tarea ya finalizada");
        }

        public override void Posponer()
        {
            throw new NotImplementedException("Imposible, tarea finalizada");
        }
    }
}
