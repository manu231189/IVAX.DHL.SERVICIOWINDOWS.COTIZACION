using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVAX.DHL.GENERA_COTIZACION.Entidades
{
    public class ECotizacion
    {
        public string tipopago { get; set; }
        public string ruc { get; set; }
        public string numcotizacion { get; set; }
        public string razonsocial { get; set; }
        public string direccion { get; set; }
        public string obigeo { get; set; }
        public string centraltelefonico { get; set; }
        public string telefatncliente { get; set; }
        public string link { get; set; }
        public string razoncliente { get; set; }
        public string ruccliente { get; set; }
        public string direccliente { get; set; }
        public string cuentacliente { get; set; }
        public string fechaemicion { get; set; }
        public string fechavencimiento { get; set; }
        public double soles { get; set; }
        public double tipocambio { get; set; }
        public string formapago { get; set; }
        public double dolares { get; set; }
        public string numentransferencia { get; set; }
        public string banco { get; set; }
        public string fecha_awb { get; set; }
        public double peso { get; set; }
        public string n_awb { get; set; }
        public string origen { get; set; }
        public int piezas_awb { get; set; }
        public string destino { get; set; }
        public double op_gravada { get; set; }
        public double op_inafecta { get; set; }
        public double op_exoneradas { get; set; }
        public double op_gratuitas { get; set; }
        public double detracciones { get; set; }
        public double percepciones { get; set; }
        public double descuento { get; set; }
        public double igv { get; set; }
        public double total_venta { get; set; }
        public List<ECotizacionDetalle> detalleCotizacion { get; set; }

    }





}
