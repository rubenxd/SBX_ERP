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
    public partial class Form1 : Form
    {
        public string CodigoUsuario { get; set; }
        public string Usuario { get; set; }
        public string Nombre { get; set; }
        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }
        private void btn_comercial_Click(object sender, EventArgs e)
        {
            frm_comercial frm_Comercial = new frm_comercial();
            frm_Comercial.Show();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_usuario.Text = Usuario + " - " + Nombre;
            DateTime FechaHoy = DateTime.Now;
            lbl_fecha_hora.Text = FechaHoy.ToString();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_fecha_hora.Text = DateTime.Now.ToString();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_config_Click(object sender, EventArgs e)
        {
            frm_config frm_Config = new frm_config();
            frm_Config.ShowDialog();
        }
    }
}
