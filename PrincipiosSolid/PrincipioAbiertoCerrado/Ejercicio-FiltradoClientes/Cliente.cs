using System;
using System.Collections.Generic;
using System.Text;

namespace PrincipiosSolid.PrincipioAbiertoCerrado.Ejercicio_FiltradoClientes
{
    public class Cliente
    {
        public string Nombre { get; set; }
        public double Salario { get; set; }
        public Localidades Localidades { get; set; }
    }

    public enum Localidades { 
        None,
        Zaragoza,
        Huezca,
        Terezel
    }
}
