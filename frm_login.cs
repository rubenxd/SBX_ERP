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
    public partial class frm_login : Form
    {
        int v_validado = 0;
        cls_login cls_Login = new cls_login();
        DataTable v_dt;
        Form1 Form1 = new Form1();
        public frm_login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            mtd_validar();
            if (v_validado == 0)
            {
                mtd_ingresar();
            }
        }
        private void mtd_validar()
        {
            v_validado = 0;

            if (txtUsuario.Text == "" || txtUsuario.Text == "USUARIO")
            {
                errorProvider1.SetError(txtUsuario, "Ingrese usuario");
                v_validado++;
            }
            if (txtContrasena.Text == "" || txtContrasena.Text == "CONTRASEÑA")
            {
                errorProvider1.SetError(txtContrasena, "Ingrese Contraseña");
                v_validado++;
            }
        }
        private void mtd_ingresar()
        {
            mtd_validar();
            if (v_validado == 0)
            {
                cls_Login.NombreUsuario = txtUsuario.Text;
                cls_Login.Contrasena = txtContrasena.Text;
                v_dt = cls_Login.mtd_consultar_estado();
                if (v_dt.Rows.Count > 0)
                {
                    DataRow rows = v_dt.Rows[0];
                    if (rows["cl_Codigo"].ToString() == "")
                    {
                        errorProvider1.SetError(txtUsuario, "Usuario incorrecto");
                        errorProvider1.SetError(txtContrasena, "Contraseña incorrecta");
                    }
                    else
                    {
                        Form1.Usuario = rows["cl_NombreUsuario"].ToString();
                        Form1.Nombre = rows["Nombre"].ToString();
                        Form1.CodigoUsuario = rows["cl_Codigo"].ToString();
                        Form1.Show();
                        this.Hide();
                    }
                }
                else
                {
                    errorProvider1.SetError(txtUsuario, "Usuario incorrecto");
                    errorProvider1.SetError(txtContrasena, "Contraseña incorrecta");
                }
            }
        }
        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) 
            {
                mtd_validar();
                if (v_validado == 0)
                {
                    mtd_ingresar();
                }
            }
        }
        private void txtUsuario_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Tab) 
            {
                mtd_validar();
                if (v_validado == 0)
                {
                    mtd_ingresar();
                }
            }
        }
        private void txtContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                mtd_validar();
                if (v_validado == 0)
                {
                    mtd_ingresar();
                }
            }
        }
        private void txtContrasena_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Tab)
            {
                mtd_validar();
                if (v_validado == 0)
                {
                    mtd_ingresar();
                }
            }
        }
    }
}
