using System;
using System.Collections.Generic;
using System.Text;

namespace PrincipiosSolid.PrincipioDeSegrecionDeInterfaces.Ejercicio_Proceso.Problema
{
    public class ProcesoManual : Proceso
    {
        public override void Finalizar()
        {
          //Proceso Finalizado;
        }

        public override void Iniciar()
        {
           //Proceso Iniciado
        }

        public override void Renaudar()
        {
           //Proceso Renaudado
        }

        public override void Suspender()
        {
           //Proceso Suspendido
        }
    }
}
