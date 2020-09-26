using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVAX.DHL.GENERA_COTIZACION.Entidades
{
    public class ECotizacionDetalle
    {
        public string producto { get; set; }
        public string descripcion { get; set; }
        public string um { get; set; }
        public double cantidad  { get; set; }
        public double importe { get; set; }


    }
}
