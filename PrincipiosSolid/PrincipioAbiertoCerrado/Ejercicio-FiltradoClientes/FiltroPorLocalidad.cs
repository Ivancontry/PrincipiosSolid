using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrincipiosSolid.PrincipioAbiertoCerrado.Ejercicio_FiltradoClientes
{
    public class FiltroPorLocalidad : EspecificacionFiltroCliente
    {
        private Localidades _localidades;
        public FiltroPorLocalidad(Localidades localidades)
        {
            _localidades = localidades;
        }
        protected override List<Cliente> AplicarFiltro(List<Cliente> clientes)
        {
            return clientes.Where(c=>c.Localidades == this._localidades).ToList();
        }
    }
}
