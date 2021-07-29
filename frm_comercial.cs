using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SBX_ERP
{
    public partial class frm_comercial : Form
    {
        public frm_comercial()
        {
            InitializeComponent();
        }

        private void btn_terceros_Click(object sender, EventArgs e)
        {
            frm_terceros frm_Terceros = new frm_terceros();
            frm_Terceros.Show();
        }

        private void btn_items_Click(object sender, EventArgs e)
        {
            frm_items frm_Items = new frm_items();
            frm_Items.Show();
        }
        private void btn_orden_servicio_Click(object sender, EventArgs e)
        {
            frm_orden_servicio frm_Orden_Servicio = new frm_orden_servicio();
            frm_Orden_Servicio.Show();
        }
        private void btn_cotizacion_Click(object sender, EventArgs e)
        {
            frm_cotizacion frm_Cotizacion = new frm_cotizacion();
            frm_Cotizacion.Show();
        }
        private void btn_cuenta_cobro_Click(object sender, EventArgs e)
        {
            frm_cuenta_cobro frm_Cuenta_Cobro = new frm_cuenta_cobro();
            frm_Cuenta_Cobro.Show();
        }

        private void btn_empresa_Click(object sender, EventArgs e)
        {
            frm_compañia frm_Compañia = new frm_compañia();
            frm_Compañia.Show();
        }
    }
}
