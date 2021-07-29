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
    public partial class frm_vehiculos : Form
    {
        bool v_ok;
        DataTable v_dt;
        int v_contador = 0;
        public frm_vehiculos()
        {
            InitializeComponent();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            frm_busquedas frm_Busquedas = new frm_busquedas();
            frm_Busquedas.Modulo = 2;
            frm_Busquedas.Enviainfo += new frm_busquedas.EnviarInfo(mtd_carga_datos);
            frm_Busquedas.ShowDialog();
        }
        private void mtd_validar()
        {
            errorProvider1.Clear();
            v_contador = 0;
            if (txt_tercero.Text == "")
            {
                errorProvider1.SetError(txt_tercero,"Ingrese Tercero");
                v_contador++;
            }
            if (txt_vehiculo.Text == "")
            {
                errorProvider1.SetError(txt_vehiculo, "Ingrese Vehiculo");
                v_contador++;
            }
            if (txt_placa.Text == "")
            {
                errorProvider1.SetError(txt_placa, "Ingrese Placa");
                v_contador++;
            }
            if (txt_modelo.Text == "")
            {
                errorProvider1.SetError(txt_modelo, "Ingrese Modelo");
                v_contador++;
            }
        }
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            mtd_validar();
            if (v_contador == 0)
            {
                //Verifica si placa ya existe
                cls_vehiculo cls_Vehiculo = new cls_vehiculo();
                cls_Vehiculo.v_buscar = txt_placa.Text;
                v_dt = cls_Vehiculo.mtd_consultar_x_placa();
                if (v_dt.Rows.Count > 0)
                {
                    DataRow dataRow = v_dt.Rows[0];
                    if (dataRow["cl_identificacion"].ToString() != txt_tercero.Text)
                    {
                        if (MessageBox.Show("Placa: " + txt_placa.Text + ", Ya existe para el tercero: " + dataRow["cl_identificacion"].ToString() + " - "
                            + dataRow["cl_razon_social"].ToString() + ", ¿Desea actualizar el tercero del vehiculo?", "Placa Tercero", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            //Editar
                            cls_Vehiculo.cl_Tercero = lbl_codigo_tercero.Text;
                            cls_Vehiculo.cl_Vehiculo = txt_vehiculo.Text;
                            cls_Vehiculo.cl_Placa = txt_placa.Text;
                            cls_Vehiculo.cl_Modelo = txt_modelo.Text;
                            cls_Vehiculo.cl_km = txt_km.Text;
                            DateTime Fecha = DateTime.Now;
                            cls_Vehiculo.cl_fecha_modificacion = Fecha.ToString();
                            //se envia la fecha de creacion pero no se realizara ningun cambio en esa fecha en base de datos
                            cls_Vehiculo.cl_fecha_creacion = Fecha.ToString();
                            cls_Vehiculo.cl_usuario = "1";

                            v_ok = cls_Vehiculo.mtd_Editar();
                            if (v_ok)
                            {
                                MessageBox.Show("Vehiculo Editado correctamente", "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                mtd_limpiar();
                            }
                        }
                    }
                    else
                    {
                        //Editar
                        cls_Vehiculo.cl_Tercero = lbl_codigo_tercero.Text;
                        cls_Vehiculo.cl_Vehiculo = txt_vehiculo.Text;
                        cls_Vehiculo.cl_Placa = txt_placa.Text;
                        cls_Vehiculo.cl_Modelo = txt_modelo.Text;
                        cls_Vehiculo.cl_km = txt_km.Text;
                        DateTime Fecha = DateTime.Now;
                        cls_Vehiculo.cl_fecha_modificacion = Fecha.ToString();
                        //se envia la fecha de creacion pero no se realizara ningun cambio en esa fecha en base de datos
                        cls_Vehiculo.cl_fecha_creacion = Fecha.ToString();
                        cls_Vehiculo.cl_usuario = "1";

                        v_ok = cls_Vehiculo.mtd_Editar();
                        if (v_ok)
                        {
                            MessageBox.Show("Vehiculo Editado correctamente", "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            mtd_limpiar();
                        }
                    }
                }
                else
                {
                    //Registrar
                    cls_Vehiculo.cl_Tercero = lbl_codigo_tercero.Text;
                    cls_Vehiculo.cl_Vehiculo = txt_vehiculo.Text;
                    cls_Vehiculo.cl_Placa = txt_placa.Text;
                    cls_Vehiculo.cl_Modelo = txt_modelo.Text;
                    cls_Vehiculo.cl_km = txt_km.Text;
                    DateTime Fecha = DateTime.Now;
                    cls_Vehiculo.cl_fecha_modificacion = Fecha.ToString();
                    cls_Vehiculo.cl_fecha_creacion = Fecha.ToString();
                    cls_Vehiculo.cl_usuario = "1";

                    v_ok = cls_Vehiculo.mtd_registrar();
                    if (v_ok)
                    {
                        MessageBox.Show("Vehiculo registrado correctamente", "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        mtd_limpiar();
                    }
                }
            }          
        }
        private void mtd_limpiar()
        {
            txt_tercero.Text = "";
            txt_nombre.Text = "";
            txt_vehiculo.Text = "";
            txt_placa.Text = "";
            txt_km.Text = "";
            txt_modelo.Text = "";
        }
        private void mtd_carga_datos(string vl_identificacion)
        {
            this.Cursor = Cursors.WaitCursor;
            cls_vehiculo cls_Vehiculo = new cls_vehiculo();
            cls_Vehiculo.v_buscar = vl_identificacion;
            v_dt = cls_Vehiculo.mtd_consultar();
            foreach (DataRow item in v_dt.Rows)
            {
                txt_tercero.Text = item["cl_identificacion"].ToString();
                txt_nombre.Text = item["cl_razon_social"].ToString();
                txt_vehiculo.Text = item["cl_vehiculo"].ToString();
                txt_placa.Text = item["cl_placa"].ToString();
                txt_modelo.Text = item["cl_modelo"].ToString();
                txt_km.Text = item["cl_km"].ToString();
            }
            this.Cursor = Cursors.Default;
        }

        private void mtd_carga_datos_2(string vl_identificacion)
        {
            this.Cursor = Cursors.WaitCursor;
            cls_terceros cls_Terceros = new cls_terceros();
            cls_Terceros.v_buscar = vl_identificacion;
            v_dt = cls_Terceros.mtd_consultar_x_codigo();
            foreach (DataRow item in v_dt.Rows)
            {
               txt_tercero.Text = item["cl_identificacion"].ToString();
               txt_nombre.Text = item["cl_razon_social"].ToString();
               lbl_codigo_tercero.Text = item["cl_Codigo_pk"].ToString();
            }
            this.Cursor = Cursors.Default;
        }

        private void btn_buscar_2_Click(object sender, EventArgs e)
        {
            frm_busquedas frm_Busquedas = new frm_busquedas();
            frm_Busquedas.Modulo = 3;
            frm_Busquedas.Enviainfo += new frm_busquedas.EnviarInfo(mtd_carga_datos_2);
            frm_Busquedas.ShowDialog();
        }
    }
}
