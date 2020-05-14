using System;
using System.Collections.Generic;
using System.Text;

namespace PrincipiosSolid.PrincipioAbiertoCerrado.Ejercicio_FiltradoClientes
{
    public class FiltroCliente
    {
        public List<Cliente> FiltrarPor(List<Cliente> clientes, EspecificacionFiltroCliente filtro) {
            return filtro.Filtrar(clientes);
        }
    }
}
