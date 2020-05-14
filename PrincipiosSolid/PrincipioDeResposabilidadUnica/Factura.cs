using System;
using System.Collections.Generic;
using System.Text;

namespace PrincipiosSolid.PrincipioDeResposabilidadUnica
{
    public class Factura
    {
        public string Codigo { get; set; }
        public DateTime FechaEmision { get; set; }
        public double ImporteFactura { get; set; } 
        public double ImporteIva { get; set; }
        public double ImporteDeduccion { get; set; }
        public double ImporteTotal { get; set; }
        public double PorcentajeDeDeduccion { get; set; }

        #region ViolacionDelPrincipioSolid
        public void CalcularTotal()
        {
            //Calculamos la Deduccion
            ImporteDeduccion = (ImporteFactura * PorcentajeDeDeduccion) / 100;
            // Calculamos el IVA            
            ImporteIva = ImporteFactura * 0.16;
            // Calculamos el total
            ImporteTotal = (ImporteFactura - ImporteDeduccion) + ImporteIva;
        }
        #endregion
        #region AplicacionDelPrincipioSolid
        public void CalcularTotalSolid()
        {
            //Calculamos la Deduccion
            Deduccion deduccion = new Deduccion(PorcentajeDeDeduccion);
            ImporteDeduccion = deduccion.CalcularDevoluicion(ImporteFactura);
            // Calculamos el IVA
            IvaNormal ivaNormal = new IvaNormal();
            ImporteIva = ivaNormal.CalcularIva(ImporteFactura);
            // Calculamos el total
            ImporteTotal = (ImporteFactura - ImporteDeduccion) + ImporteIva;
        }
        #endregion

    }
}
