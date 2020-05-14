using System;
using System.Collections.Generic;
using System.Text;

namespace PrincipiosSolid.PrincipioAbiertoCerrado.Ejercicio_EstadoTarea
{
    public abstract class EstadoTareaBase
    {
        protected Tarea _tarea;
        public abstract void Finalizar();
        public abstract void Cancelar();
        public abstract void Posponer();
    }

}
