using System;
using System.Collections.Generic;
using System.Text;

namespace PrincipiosSolid.PrincipioAbiertoCerrado.Ejercicio_EstadoTarea
{
    public class Tarea
    {
        public EstadoTareaBase EstadoTarea { get; private set; }
        public Tarea()
        {
            EstadoTarea = new EstadoTareaPendiente();
        }
        public void CambiarEstado(EstadoTareaBase estadoTareaBase) {
            EstadoTarea = estadoTareaBase;
        }
        public void Finalizar() {
            EstadoTarea.Finalizar();            
        }
        public void Cancelar() {
            EstadoTarea.Cancelar();
            EstadoTarea = new EstadoTareaCancelada();
        }
        public void Posponer()
        {
            System.Console.WriteLine("Intentando Posponer");
            EstadoTarea.Posponer();
            EstadoTarea = new EstadoTareaPospuesta();
            System.Console.WriteLine("Tarea Pospuesta");
        }
        
    }
}
