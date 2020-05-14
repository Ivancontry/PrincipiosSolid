using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrincipiosSolid.PrincipioAbiertoCerrado.Ejercicio_FiltradoClientes
{
    public class FiltradoPorNombre : EspecificacionFiltroCliente
    {
        private string Nombre { get; set; }
        public FiltradoPorNombre(string nombre)
        {
            Nombre = nombre;
        }
        protected override List<Cliente> AplicarFiltro(List<Cliente> clientes)
        {
            return clientes.Where(c => c.Nombre == this.Nombre).ToList();
        }
    }
}
