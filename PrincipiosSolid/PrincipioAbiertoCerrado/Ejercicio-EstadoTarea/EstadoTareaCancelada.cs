using System;
using System.Collections.Generic;
using System.Text;

namespace PrincipiosSolid.PrincipioAbiertoCerrado.Ejercicio_EstadoTarea
{
    public class EstadoTareaCancelada : EstadoTareaBase
    {
        public override void Cancelar()
        {
            throw new NotImplementedException("Tarea ya cancelada");
        }

        public override void Finalizar()
        {
            throw new NotImplementedException("Imposible finalizar, tarea cancelada");
        }

        public override void Posponer()
        {
            throw new NotImplementedException("Imposible Posponer, tarea cancelada");
        }
    }
}
