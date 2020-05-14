using System;
using System.Collections.Generic;
using System.Text;

namespace PrincipiosSolid.PrincipioDeSegrecionDeInterfaces.Ejercicio_Proceso.Problema
{
    public class ProcesoManualSolucion : IProceso, IManual
    {
        public void Finalizar()
        {
          //Proceso Finalizado;
        }

        public void Iniciar()
        {
           //Proceso Iniciado
        }

        public void Renaudar()
        {
           //Proceso Renaudado
        }

        public void Suspender()
        {
           //Proceso Suspendido
        }
    }
}
