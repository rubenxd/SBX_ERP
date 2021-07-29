using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SBX_ERP.model;
namespace SBX_ERP
{
    public partial class frm_config : Form
    {
        cls_config cls_Config = new cls_config();
        DataTable v_dt;
        bool ok;
        public frm_config()
        {
            InitializeComponent();
        }

        private void frm_config_Load(object sender, EventArgs e)
        {
            v_dt = cls_Config.mtd_consultar_Tipo_busqueda_doc();
            if (v_dt.Rows.Count > 0)
            {
                DataRow row = v_dt.Rows[0];
                if (row["TipoBusquedaDoc"].ToString() == "1")
                {
                    cbx_tipo_busq_doc.SelectedIndex = 1;
                }
                else
                {
                    cbx_tipo_busq_doc.SelectedIndex = 0;
                }
            }
            else 
            {
                cbx_tipo_busq_doc.SelectedIndex = 0;
            }    
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            cls_config cls_Config = new cls_config();
            cls_Config.tipo_busqueda_doc = cbx_tipo_busq_doc.SelectedIndex.ToString();
            ok = cls_Config.mtd_eliminar();
            if (true)
            {
                ok = cls_Config.mtd_registrar();
                if (ok)
                {
                    MessageBox.Show("Registrado", "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }          
        }
    }
}
