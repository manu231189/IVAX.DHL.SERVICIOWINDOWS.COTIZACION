using IVAX.DHL.GENERA_COTIZACION.Entidades;
using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace IVAX.DHL.GENERA_COTIZACION
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
        }

        protected override void OnStop()
        {
        }

        public void GeneraReporte(ECotizacion eCotizacion,List<ECotizacionDetalle> eCotizacionDetalles)
        {
            ReportViewer reportCotiza = new ReportViewer();
            reportCotiza.ProcessingMode = ProcessingMode.Local;
            string ruta = AppDomain.CurrentDomain.BaseDirectory + "/Reportes/rptCotizacion";
            reportCotiza.LocalReport.ReportPath = ruta;
            reportCotiza.LocalReport.DataSources.Clear();

            var rdCab = new ReportDataSource();
            rdCab.Name = "DataCabecera";
            rdCab.Value = eCotizacion;

            var rdDet = new ReportDataSource();
            rdDet.Name = "DataDetalle";
            rdDet.Value = eCotizacionDetalles;

            reportCotiza.LocalReport.DataSources.Add(rdCab);
            reportCotiza.LocalReport.DataSources.Add(rdDet);

            var reportePDF = reportCotiza.LocalReport.Render("PDF");

        }
    }
}
