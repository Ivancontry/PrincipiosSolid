using System;
using System.Collections.Generic;
using System.Text;

namespace PrincipiosSolid.PrincipioDeSegrecionDeInterfaces.Ejercicio_Proceso.Problema
{
    public class ProcesoAutomatico : Proceso
    {
        public override void Finalizar()
        {
           
            //Proceso Finalizado
        }

        public override void Iniciar()
        {
           //Proceso Iniciado
        }

        public override void Renaudar()
        {
            throw new NotImplementedException();
        }

        public override void Suspender()
        {
            throw new NotImplementedException();
        }
    }
}
