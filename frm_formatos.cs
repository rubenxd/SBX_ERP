using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using SBX_ERP.model;
namespace SBX_ERP
{
    public partial class frm_formatos : Form
    {
        public string Reporte { get; set; }
        public List<cls_orden_servicio> lrords { get; set; }
        public List<cls_cotizacion> lctz { get; set; }
        public List<cls_cotizacion> lctz2 { get; set; }
        public List<cl_cuenta_cobro> lctcb { get; set; }
        public List<cl_cuenta_cobro> lctcb2 { get; set; }
        public frm_formatos()
        {
            InitializeComponent();
        }

        private void frm_formatos_Load(object sender, EventArgs e)
        {

            switch (Reporte)
            {             
                 case "OrdenServicio":
                    ReportDataSource rds_ords = new ReportDataSource("OrdenServicio", lrords);
                    this.reportViewer1.LocalReport.ReportEmbeddedResource = "SBX_ERP.Orden_Servicio.rdlc";
                    this.reportViewer1.LocalReport.DataSources.Clear();
                    this.reportViewer1.LocalReport.DataSources.Add(rds_ords);
                    this.reportViewer1.RefreshReport();
                    break;
                case "Cotizacion":
                    ReportDataSource rds_cotz = new ReportDataSource("cotizacion", lctz);
                    this.reportViewer1.LocalReport.ReportEmbeddedResource = "SBX_ERP.Cotizacion.rdlc";
                    this.reportViewer1.LocalReport.DataSources.Clear();
                    this.reportViewer1.LocalReport.DataSources.Add(rds_cotz);
                    this.reportViewer1.RefreshReport();

                    ReportDataSource rds_cotz2 = new ReportDataSource("cotizacion2", lctz2);
                    this.reportViewer1.LocalReport.ReportEmbeddedResource = "SBX_ERP.Cotizacion.rdlc";
                    //this.reportViewer1.LocalReport.DataSources.Clear();
                    this.reportViewer1.LocalReport.DataSources.Add(rds_cotz2);
                    this.reportViewer1.RefreshReport();
                    break;
                case "cuentacobro":
                    ReportDataSource rds_ctcb = new ReportDataSource("CuentaCobro", lctcb);
                    this.reportViewer1.LocalReport.ReportEmbeddedResource = "SBX_ERP.CuentaCobro.rdlc";
                    this.reportViewer1.LocalReport.DataSources.Clear();
                    this.reportViewer1.LocalReport.DataSources.Add(rds_ctcb);
                    this.reportViewer1.RefreshReport();

                    ReportDataSource rds_ctcb2 = new ReportDataSource("CuentaCobro2", lctcb2);
                    this.reportViewer1.LocalReport.ReportEmbeddedResource = "SBX_ERP.CuentaCobro.rdlc";
                    //this.reportViewer1.LocalReport.DataSources.Clear();
                    this.reportViewer1.LocalReport.DataSources.Add(rds_ctcb2);
                    this.reportViewer1.RefreshReport();
                    break;
                default:
                    break;
            }
        }
    }
}
