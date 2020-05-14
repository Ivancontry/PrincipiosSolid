using System;
using System.Collections.Generic;
using System.Text;

namespace PrincipiosSolid.PrincipioDeSegrecionDeInterfaces.Ejercicio_Proceso.Problema
{
    public abstract class Proceso
    {
        public abstract void Iniciar();
        public abstract void Renaudar();
        public abstract void Suspender();
        public abstract void Finalizar();
    }
}
