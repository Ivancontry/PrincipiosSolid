using System;
using System.Collections.Generic;
using System.Text;

namespace PrincipiosSolid.PrincipioDeSegrecionDeInterfaces.Ejercicio_Proceso.Problema
{
    public  interface IProceso
    {
        public abstract void Iniciar();       
        public abstract void Finalizar();
    }

    public interface IManual {
        public abstract void Renaudar();
        public abstract void Suspender();
    }
}
