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
    public partial class frm_compañia : Form
    {
        bool v_ok;
        DataTable v_dt;
        int v_contador = 0;
        cls_global cls_Global = new cls_global();
        public frm_compañia()
        {
            InitializeComponent();
        }
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            //Verifica si tercero ya existe
            mtd_validar();
            if (v_contador == 0)
            {
                cls_empresa cls_Empresa = new cls_empresa();
                cls_Empresa.v_buscar = txt_identificacion.Text;
                v_dt = cls_Empresa.mtd_consultar();
                if (v_dt.Rows.Count > 0)
                {
                    //Editar
                    cls_Empresa.v_buscar = txt_identificacion.Text;

                    cls_Empresa.cl_identificacion = txt_identificacion.Text;
                    cls_Empresa.cl_tipo_identificacion = cbx_tipo_identificacion.SelectedIndex.ToString();
                    cls_Empresa.cl_razon_social = txt_razon_social.Text;
                    cls_Empresa.cl_tipo_persona = cbx_tipo_persona.SelectedIndex.ToString();
                    cls_Empresa.cl_direccion = txt_direccion.Text;
                    cls_Empresa.cl_telefonos = txt_telefonos.Text;
                    cls_Empresa.cl_Email = txt_email.Text;
                    DateTime Fecha = DateTime.Now;
                    cls_Empresa.cl_fecha_modificacion = Fecha.ToString();
                    //se envia la fecha de creacion pero no se realizara ningun cambio en esa fecha en base de datos
                    cls_Empresa.cl_fecha_creacion = Fecha.ToString();
                    cls_Empresa.cl_usuario = "1";

                    v_ok = cls_Empresa.mtd_Editar();
                    if (v_ok)
                    {
                        MessageBox.Show("Compañia Editado correctamente", "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        mtd_limpiar();
                    }
                }
                else
                {
                    //Registrar
                    cls_Empresa.cl_identificacion = txt_identificacion.Text;
                    cls_Empresa.cl_tipo_identificacion = cbx_tipo_identificacion.SelectedIndex.ToString();
                    cls_Empresa.cl_razon_social = txt_razon_social.Text;
                    cls_Empresa.cl_tipo_persona = cbx_tipo_persona.SelectedIndex.ToString();
                    cls_Empresa.cl_direccion = txt_direccion.Text;
                    cls_Empresa.cl_telefonos = txt_telefonos.Text;
                    cls_Empresa.cl_Email = txt_email.Text;
                    DateTime Fecha = DateTime.Now;
                    cls_Empresa.cl_fecha_modificacion = Fecha.ToString();
                    cls_Empresa.cl_fecha_creacion = Fecha.ToString();
                    cls_Empresa.cl_usuario = "1";

                    v_ok = cls_Empresa.mtd_registrar();
                    if (v_ok)
                    {
                        MessageBox.Show("Compañia registrado correctamente", "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        mtd_limpiar();
                    }
                }
            }
        }
        private void mtd_validar()
        {
            errorProvider1.Clear();
            v_contador = 0;
            if (txt_identificacion.Text == "")
            {
                errorProvider1.SetError(txt_identificacion, "Ingrese identificacion");
                v_contador++;
            }
            if (!cls_Global.IsNumericDouble(txt_identificacion.Text))
            {
                errorProvider1.SetError(txt_identificacion, "Ingrese valores numericos");
                v_contador++;
            }
            if (txt_razon_social.Text == "")
            {
                errorProvider1.SetError(txt_razon_social, "Ingrese razon social");
                v_contador++;
            }
            if (txt_telefonos.Text == "")
            {
                errorProvider1.SetError(txt_telefonos, "Ingrese telefono ");
                v_contador++;
            }
            if (!cls_Global.IsNumericDouble(txt_telefonos.Text))
            {
                errorProvider1.SetError(txt_telefonos, "Ingrese valores numericos");
                v_contador++;
            }
        }
        private void mtd_limpiar()
        {
            txt_identificacion.Text = "";
            cbx_tipo_identificacion.SelectedIndex = 0;
            txt_razon_social.Text = "";
            cbx_tipo_persona.SelectedIndex = 0;
            txt_direccion.Text = "";
            txt_telefonos.Text = "";
            txt_email.Text = "";
        }
        private void txt_identificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.Cursor = Cursors.WaitCursor;
                cls_empresa cls_Empresa = new cls_empresa();
                cls_Empresa.v_buscar = txt_identificacion.Text;
                v_dt = cls_Empresa.mtd_consultar();
                foreach (DataRow item in v_dt.Rows)
                {
                    cbx_tipo_identificacion.SelectedIndex = Convert.ToInt32(item["cl_tipo_identificacion"]);
                    txt_razon_social.Text = item["cl_razon_social"].ToString();
                    cbx_tipo_persona.SelectedIndex = Convert.ToInt32(item["cl_tipo_persona"]);
                    txt_direccion.Text = item["cl_direccion"].ToString();
                    txt_telefonos.Text = item["cl_telefonos"].ToString();
                    txt_email.Text = item["cl_Email"].ToString();
                }
                this.Cursor = Cursors.Default;
            }
        }
        private void txt_identificacion_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Tab)
            {
                this.Cursor = Cursors.WaitCursor;
                cls_empresa cls_Empresa = new cls_empresa();
                cls_Empresa.v_buscar = txt_identificacion.Text;
                v_dt = cls_Empresa.mtd_consultar();
                foreach (DataRow item in v_dt.Rows)
                {
                    cbx_tipo_identificacion.SelectedIndex = Convert.ToInt32(item["cl_tipo_identificacion"]);
                    txt_razon_social.Text = item["cl_razon_social"].ToString();
                    cbx_tipo_persona.SelectedIndex = Convert.ToInt32(item["cl_tipo_persona"]);
                    txt_direccion.Text = item["cl_direccion"].ToString();
                    txt_telefonos.Text = item["cl_telefonos"].ToString();
                    txt_email.Text = item["cl_Email"].ToString();
                }
                this.Cursor = Cursors.Default;
            }
        }
        private void frm_compañia_Load(object sender, EventArgs e)
        {
            cbx_tipo_identificacion.SelectedIndex = 0;
            cbx_tipo_persona.SelectedIndex = 0;
        }
        private void btn_consultas_Click(object sender, EventArgs e)
        {
            frm_busquedas frm_Busquedas = new frm_busquedas();
            frm_Busquedas.Modulo = 6;
            frm_Busquedas.ShowDialog();
        }
        private void btn_buscar_2_Click(object sender, EventArgs e)
        {
            frm_busquedas frm_Busquedas = new frm_busquedas();
            frm_Busquedas.Modulo = 6;
            frm_Busquedas.Enviainfo += new frm_busquedas.EnviarInfo(mtd_carga_datos);
            frm_Busquedas.ShowDialog();
        }
        private void mtd_carga_datos(string vl_identificacion)
        {
            this.Cursor = Cursors.WaitCursor;
            cls_empresa cls_Empresa = new cls_empresa();
            cls_Empresa.v_buscar = vl_identificacion;
            v_dt = cls_Empresa.mtd_consultar();
            foreach (DataRow item in v_dt.Rows)
            {
                txt_identificacion.Text = item["cl_identificacion"].ToString();
                cbx_tipo_identificacion.SelectedIndex = Convert.ToInt32(item["cl_tipo_identificacion"]);
                txt_razon_social.Text = item["cl_razon_social"].ToString();
                cbx_tipo_persona.SelectedIndex = Convert.ToInt32(item["cl_tipo_persona"]);
                txt_direccion.Text = item["cl_direccion"].ToString();
                txt_telefonos.Text = item["cl_telefonos"].ToString();
                txt_email.Text = item["cl_Email"].ToString();
            }
            this.Cursor = Cursors.Default;
        }
    }
}
