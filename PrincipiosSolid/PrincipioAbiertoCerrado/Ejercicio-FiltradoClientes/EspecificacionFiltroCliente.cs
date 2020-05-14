using System;
using System.Collections.Generic;
using System.Text;

namespace PrincipiosSolid.PrincipioAbiertoCerrado.Ejercicio_FiltradoClientes
{
    public abstract class EspecificacionFiltroCliente
    {
        public List<Cliente> Filtrar(List<Cliente> clientes) {
            return AplicarFiltro(clientes);
        }
        protected abstract List<Cliente> AplicarFiltro(List<Cliente> clientes);
    }

    
}
