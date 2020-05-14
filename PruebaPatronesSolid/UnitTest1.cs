using NUnit.Framework;
using PrincipiosSolid.PrincipioAbiertoCerrado.Ejercicio_EstadoTarea;
using System;

namespace PruebaPatronesSolid
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Tarea tarea = new Tarea();          
            tarea.Cancelar();          
           // Assert.AreEqual( new EstadoTareaCancelada(), tarea._estadoTareaBase);
        }
        [Test]
        public void EjecutarTest()
        {
            Tarea tarea = new Tarea();
            tarea.Cancelar();
            TestContext.WriteLine(tarea.EstadoTarea.GetType().Name);
            Assert.Throws<NotImplementedException>(()=>tarea.Posponer());
        }
    }
}