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
    public partial class frm_info_orden_servicio : Form
    {
        cls_orden_servicio cls_Orden_Servicio = new cls_orden_servicio();
        DataTable v_dt;
        public int Modulo { get; set; }
        string v_dato = "";
        public frm_info_orden_servicio()
        {
            InitializeComponent();
        }
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            cls_Orden_Servicio.v_buscar = txt_buscar.Text;
            cls_Orden_Servicio.v_Fecha_inicio = dtp_fecha_inicio.Text;
            cls_Orden_Servicio.v_Fecha_fin = dtp_fecha_fin.Text;
            v_dt = cls_Orden_Servicio.mtd_consultar_ordenes();
            dtg_ayudas.DataSource = v_dt;
        }
        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            if (dtg_ayudas.Rows.Count > 0)
            {
                foreach (DataGridViewRow item in dtg_ayudas.SelectedRows)
                {
                    if (MessageBox.Show("¿Desea imprimir Orden de servicio?", "Imprimir Orden de Servicio", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        DataRow rows = v_dt.Rows[0];
                        cls_Orden_Servicio.cl_documento = item.Cells["Documento"].Value.ToString();
                        cls_Orden_Servicio.cl_consecutivo = item.Cells["Consecutivo"].Value.ToString();
                        v_dt = cls_Orden_Servicio.mtd_consultar_orden_servicio();
                        List<cls_orden_servicio> lrords = new List<cls_orden_servicio>();
                        foreach (DataRow rows_2 in v_dt.Rows)
                        {
                            cls_orden_servicio cls_Orden_Servicio2 = new cls_orden_servicio();
                            cls_Orden_Servicio2.cl_documento = rows_2["cl_documento"].ToString();
                            cls_Orden_Servicio2.cl_consecutivo = rows_2["cl_consecutivo"].ToString();
                            cls_Orden_Servicio2.cl_vehiculo = rows_2["cl_vehiculo"].ToString();
                            cls_Orden_Servicio2.cl_item = rows_2["cl_item"].ToString();
                            cls_Orden_Servicio2.cl_cantidad = rows_2["cl_cantidad"].ToString();
                            cls_Orden_Servicio2.cl_costo = rows_2["cl_costo"].ToString();
                            cls_Orden_Servicio2.cl_precioVenta = rows_2["cl_precioVenta"].ToString();
                            cls_Orden_Servicio2.cl_descuento = rows_2["cl_descuento"].ToString();
                            DateTime Fechacrea = Convert.ToDateTime(rows_2["cl_fecha_creacion"]);
                            cls_Orden_Servicio2.cl_fecha_creacion = Fechacrea.ToString("yyyy-MM-dd");
                            cls_Orden_Servicio2.cl_fecha_modificacion = rows_2["cl_fecha_modificacion"].ToString();
                            cls_Orden_Servicio2.cl_usuario = rows_2["cl_usuario"].ToString();
                            cls_Orden_Servicio2.Item = rows_2["item"].ToString();
                            cls_Orden_Servicio2.cl_nombre = rows_2["cl_nombre"].ToString();
                            cls_Orden_Servicio2.cl_descripcion = rows_2["cl_descripcion"].ToString();
                            cls_Orden_Servicio2.cl_referencia = rows_2["cl_referencia"].ToString();
                            cls_Orden_Servicio2.cl_codigo_barras = rows_2["cl_codigo_barras"].ToString();
                            cls_Orden_Servicio2.cl_Vehiculo = rows_2["cl_Vehiculo1"].ToString();
                            cls_Orden_Servicio2.cl_Placa = rows_2["cl_Placa"].ToString();
                            cls_Orden_Servicio2.cl_Modelo = rows_2["cl_Modelo"].ToString();
                            cls_Orden_Servicio2.cl_km = rows_2["km"].ToString(); ;
                            cls_Orden_Servicio2.cl_identificacion = rows_2["cl_identificacion"].ToString();
                            cls_Orden_Servicio2.cl_razon_social = rows_2["cl_razon_social"].ToString();
                            cls_Orden_Servicio2.cl_direccion = rows_2["cl_direccion"].ToString();
                            cls_Orden_Servicio2.cl_telefonos = rows_2["cl_telefonos"].ToString();
                            cls_Orden_Servicio2.cl_Email = rows_2["cl_Email"].ToString();
                            cls_Orden_Servicio2.cl_nota = rows_2["cl_nota"].ToString();
                            cls_Orden_Servicio2.cl_km = rows_2["km"].ToString();
                            lrords.Add(cls_Orden_Servicio2);
                        }
                        frm_formatos frm_Formatos = new frm_formatos();
                        frm_Formatos.Reporte = "OrdenServicio";
                        frm_Formatos.lrords = lrords;
                        frm_Formatos.Show();
                    }
                }
            }
            else 
            {
                MessageBox.Show("Seleccione Orden de servicio a imprimir","Imprimir",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }           
        }
        //Delegado
        public delegate void EnviarInfo(string dato);
        public event EnviarInfo Enviainfo;
        int v_filas = 0;
    
        private void dtg_ayudas_DoubleClick(object sender, EventArgs e)
        {
            if (dtg_ayudas.Rows.Count > 0)
            {
                v_filas = dtg_ayudas.CurrentRow.Index;
                //Verificar estado de orden de servicio
                v_dato = dtg_ayudas[18, v_filas].Value.ToString();
                if (v_dato != "1")
                {
                    v_dato = dtg_ayudas[2, v_filas].Value.ToString();
                    Enviainfo(v_dato);
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Orden de servicio ya esta Facturada, seleccione otra orden de servicio","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }          
            }
        }

        private void frm_info_orden_servicio_Load(object sender, EventArgs e)
        {

        }
    }
}
