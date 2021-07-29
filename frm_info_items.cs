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
    public partial class frm_info_items : Form
    {
        cls_item cls_Item = new cls_item();
        DataTable v_dt;
        public frm_info_items()
        {
            InitializeComponent();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            cls_Item.v_buscar = txt_buscar.Text;
            v_dt = cls_Item.mtd_consultar_ayuda();
            dtg_ayudas.DataSource = v_dt;
        }
    }
}
