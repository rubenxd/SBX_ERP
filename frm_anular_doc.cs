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
    public partial class frm_anular_doc : Form
    {
        //Delegado
        public delegate void EnviarInfo(string dato,string dato2,string dato3);
        public event EnviarInfo Enviainfo;

        cl_cuenta_cobro cls_Cuenta_Cobro = new cl_cuenta_cobro();
        DataTable v_dt = new DataTable();
        public frm_anular_doc()
        {
            InitializeComponent();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            int Validar = 0;
            //Validar campos
            if (txt_doc.Text == "")
            {
                errorProvider1.SetError(txt_doc,"Ingrese documento");
                Validar++;
            }
            if (txt_consecutivo.Text == "")
            {
                errorProvider1.SetError(txt_consecutivo, "Ingrese consecutivo");
                Validar++;
            }
            if (txt_nota.Text == "")
            {
                errorProvider1.SetError(txt_nota, "Ingrese Nota");
                Validar++;
            }
            if (Validar == 0)
            {
                //Validar existencia de documento y consecutivo
                cls_Cuenta_Cobro.cl_documento = txt_doc.Text;
                cls_Cuenta_Cobro.cl_consecutivo = txt_consecutivo.Text;
                v_dt = cls_Cuenta_Cobro.mtd_consultar_documento_a_anular();
                if (v_dt.Rows.Count > 0)
                {
                    Enviainfo(txt_doc.Text, txt_consecutivo.Text,txt_nota.Text);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Documento no Existe, por favor verifique documento a Anular","Error Anular",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }

            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Enviainfo("Cancelar","","");
            this.Close();
        }
    }
}
