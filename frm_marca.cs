using SBX_ERP.model;
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
    public partial class frm_marca : Form
    {
        cl_marca cl_Marca = new cl_marca();
        bool v_ok;
        DataTable dt = new DataTable();
        int v_filas;
        string v_dato;
        //Delegado
        public delegate void EnviarInfo(string dato);
        public event EnviarInfo Enviainfo;
        public frm_marca()
        {
            InitializeComponent();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (txt_nombre_marca.Text == "")
            {
                errorProvider1.SetError(txt_nombre_marca,"Ingrese nombre de marca");
            }
            else
            {
                cl_Marca.Nombre = txt_nombre_marca.Text;
                v_ok = cl_Marca.mtd_registrar();
                if (v_ok)
                {
                    MessageBox.Show("Marca registrada correctamente","Correcto",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    dt = cl_Marca.mtd_consultar_marca();
                   
                    dtg_marca.DataSource = dt;
                }
            }
        }

        private void frm_marca_Load(object sender, EventArgs e)
        {
            dt = cl_Marca.mtd_consultar_marca();
            dtg_marca.DataSource = dt;
        }

        private void dtg_marca_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void frm_marca_FormClosed(object sender, FormClosedEventArgs e)
        {
            Enviainfo("Cerrado");
        }
    }
}
