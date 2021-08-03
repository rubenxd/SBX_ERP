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
    public partial class frm_info_cotizacion : Form
    {
        //Delegado
        public delegate void EnviarInfo(string dato);
        public event EnviarInfo Enviainfo;
        int v_filas = 0;

        cls_cotizacion cls_Cotizacion = new cls_cotizacion();
        DataTable v_dt;
        public int Modulo { get; set; }
        string v_dato = "";
        public frm_info_cotizacion()
        {
            InitializeComponent();
        }

        private void frm_info_cotizacion_Load(object sender, EventArgs e)
        {

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            cls_Cotizacion.v_buscar = txt_buscar.Text;
            cls_Cotizacion.v_Fecha_inicio = dtp_fecha_inicio.Text;
            cls_Cotizacion.v_Fecha_fin = dtp_fecha_fin.Text;
            v_dt = cls_Cotizacion.mtd_consultar_ordenes();
            dtg_ayudas.DataSource = v_dt;
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            if (dtg_ayudas.Rows.Count > 0)
            {
                foreach (DataGridViewRow item in dtg_ayudas.SelectedRows)
                {
                    if (MessageBox.Show("¿Desea imprimir Cotizacion?", "Imprimir Cotizacion", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        int contadorItems = 0;
                        DataRow rows = v_dt.Rows[0];
                        cls_Cotizacion.cl_documento = item.Cells["Documento"].Value.ToString();
                        cls_Cotizacion.cl_consecutivo = item.Cells["Consecutivo"].Value.ToString();
                        v_dt = cls_Cotizacion.mtd_consultar_cotizacion();
                        List<cls_cotizacion> lrords = new List<cls_cotizacion>();
                        List<cls_cotizacion> lrords2 = new List<cls_cotizacion>();
                        int contadorCliente = 0;
                        foreach (DataRow rows_2 in v_dt.Rows)
                        {
                            cls_cotizacion cls_Cotizacion2 = new cls_cotizacion();
                            if (contadorCliente == 0)
                            {
                                cls_Cotizacion2.cl_documento = rows_2["cl_documento"].ToString();
                                cls_Cotizacion2.cl_consecutivo = rows_2["cl_consecutivo"].ToString();
                                cls_Cotizacion2.cl_Vehiculo = rows_2["cl_Vehiculo1"].ToString();
                                cls_Cotizacion2.cl_Placa = rows_2["cl_Placa"].ToString();
                                cls_Cotizacion2.cl_Modelo = rows_2["cl_Modelo"].ToString();
                                cls_Cotizacion2.cl_km = "0";
                                cls_Cotizacion2.cl_identificacion = rows_2["cl_identificacion"].ToString();
                                cls_Cotizacion2.cl_razon_social = rows_2["cl_razon_social"].ToString();
                                cls_Cotizacion2.cl_direccion = rows_2["cl_direccion"].ToString();
                                cls_Cotizacion2.cl_telefonos = rows_2["cl_telefonos"].ToString();
                                cls_Cotizacion2.cl_Email = rows_2["cl_Email"].ToString();
                                DateTime FechaModif = Convert.ToDateTime(rows_2["cl_fecha_modificacion"]);
                                cls_Cotizacion2.cl_fecha_modificacion = FechaModif.ToString("yyyy-MM-dd");
                            }                         
                           
                            if (rows_2["cl_tipo_item"].ToString() == "Producto") 
                            {
                                //productos
                               
                                cls_Cotizacion2.cl_documento = rows_2["cl_documento"].ToString();
                                cls_Cotizacion2.cl_consecutivo = rows_2["cl_consecutivo"].ToString();
                                cls_Cotizacion2.cl_vehiculo = rows_2["cl_vehiculo"].ToString();
                                contadorItems++;
                                //cls_Cotizacion2.cl_item = rows_2["cl_item"].ToString();
                                cls_Cotizacion2.cl_item = contadorItems.ToString();
                                cls_Cotizacion2.cl_cantidad = rows_2["cl_cantidad"].ToString();
                                double Costo = Convert.ToDouble(rows_2["cl_costo"]);
                                cls_Cotizacion2.cl_costo = Costo.ToString("N");
                                double cl_precioVenta = Convert.ToDouble(rows_2["cl_precioVenta"]);
                                cls_Cotizacion2.cl_precioVenta = cl_precioVenta.ToString("N");
                                double cl_descuento = Convert.ToDouble(rows_2["cl_descuento"]);
                                cls_Cotizacion2.cl_descuento = cl_descuento.ToString("N");
                                DateTime Fechacrea = Convert.ToDateTime(rows_2["cl_fecha_creacion"]);
                                cls_Cotizacion2.cl_fecha_creacion = Fechacrea.ToString("yyyy-MM-dd");
                                DateTime FechaModif = Convert.ToDateTime(rows_2["cl_fecha_modificacion"]);
                                cls_Cotizacion2.cl_fecha_modificacion = FechaModif.ToString("yyyy-MM-dd");
                                cls_Cotizacion2.cl_usuario = rows_2["cl_usuario"].ToString();
                                cls_Cotizacion2.Item = rows_2["item"].ToString();
                                cls_Cotizacion2.cl_nombre = rows_2["cl_nombre"].ToString();
                                cls_Cotizacion2.cl_descripcion = rows_2["cl_descripcion"].ToString();
                                cls_Cotizacion2.cl_referencia = rows_2["cl_referencia"].ToString();
                                cls_Cotizacion2.cl_codigo_barras = rows_2["cl_codigo_barras"].ToString();
                                cls_Cotizacion2.cl_Vehiculo = rows_2["cl_Vehiculo1"].ToString();
                                cls_Cotizacion2.cl_Placa = rows_2["cl_Placa"].ToString();
                                cls_Cotizacion2.cl_Modelo = rows_2["cl_Modelo"].ToString();
                                cls_Cotizacion2.cl_km = "0";
                                cls_Cotizacion2.cl_identificacion = rows_2["cl_identificacion"].ToString();
                                cls_Cotizacion2.cl_razon_social = rows_2["cl_razon_social"].ToString();
                                cls_Cotizacion2.cl_direccion = rows_2["cl_direccion"].ToString();
                                cls_Cotizacion2.cl_telefonos = rows_2["cl_telefonos"].ToString();
                                cls_Cotizacion2.cl_Email = rows_2["cl_Email"].ToString();
                                cls_Cotizacion2.cl_tipo_item = rows_2["cl_tipo_item"].ToString();
                                double Total = Convert.ToDouble(rows_2["Total"]);
                                cls_Cotizacion2.Total = Total.ToString("N");
                                cls_Cotizacion2.cl_nota = rows_2["cl_nota"].ToString();
                                lrords.Add(cls_Cotizacion2);
                            }
                            else 
                            {
                                if (contadorCliente == 0)
                                {
                                    lrords.Add(cls_Cotizacion2);
                                    contadorCliente++;
                                }

                                //servicios
                                cls_cotizacion cls_Cotizacion3 = new cls_cotizacion();
                                cls_Cotizacion3.cl_documento = rows_2["cl_documento"].ToString();
                                cls_Cotizacion3.cl_consecutivo = rows_2["cl_consecutivo"].ToString();
                                cls_Cotizacion3.cl_vehiculo = rows_2["cl_vehiculo"].ToString();
                                contadorItems++;
                                //cls_Cotizacion3.cl_item = rows_2["cl_item"].ToString();
                                cls_Cotizacion3.cl_item = contadorItems.ToString();
                                cls_Cotizacion3.cl_cantidad = rows_2["cl_cantidad"].ToString();
                                double Costo = Convert.ToDouble(rows_2["cl_costo"]);
                                cls_Cotizacion3.cl_costo = Costo.ToString("N");
                                double cl_precioVenta = Convert.ToDouble(rows_2["cl_precioVenta"]);
                                cls_Cotizacion3.cl_precioVenta = cl_precioVenta.ToString("N");
                                double cl_descuento = Convert.ToDouble(rows_2["cl_descuento"]);
                                cls_Cotizacion3.cl_descuento = cl_descuento.ToString("N");
                                DateTime Fechacrea = Convert.ToDateTime(rows_2["cl_fecha_creacion"]);
                                cls_Cotizacion3.cl_fecha_creacion = Fechacrea.ToString("yyyy-MM-dd");
                                DateTime FechaModif = Convert.ToDateTime(rows_2["cl_fecha_modificacion"]);
                                cls_Cotizacion3.cl_fecha_modificacion = FechaModif.ToString("yyyy-MM-dd");
                                cls_Cotizacion3.cl_usuario = rows_2["cl_usuario"].ToString();
                                cls_Cotizacion3.Item = rows_2["item"].ToString();
                                cls_Cotizacion3.cl_nombre = rows_2["cl_nombre"].ToString();
                                cls_Cotizacion3.cl_descripcion = rows_2["cl_descripcion"].ToString();
                                cls_Cotizacion3.cl_referencia = rows_2["cl_referencia"].ToString();
                                cls_Cotizacion3.cl_codigo_barras = rows_2["cl_codigo_barras"].ToString();
                                cls_Cotizacion3.cl_Vehiculo = rows_2["cl_Vehiculo1"].ToString();
                                cls_Cotizacion3.cl_Placa = rows_2["cl_Placa"].ToString();
                                cls_Cotizacion3.cl_Modelo = rows_2["cl_Modelo"].ToString();
                                cls_Cotizacion3.cl_km = "0";
                                cls_Cotizacion3.cl_identificacion = rows_2["cl_identificacion"].ToString();
                                cls_Cotizacion3.cl_razon_social = rows_2["cl_razon_social"].ToString();
                                cls_Cotizacion3.cl_direccion = rows_2["cl_direccion"].ToString();
                                cls_Cotizacion3.cl_telefonos = rows_2["cl_telefonos"].ToString();
                                cls_Cotizacion3.cl_Email = rows_2["cl_Email"].ToString();
                                cls_Cotizacion3.cl_tipo_item = rows_2["cl_tipo_item"].ToString();
                                double Total = Convert.ToDouble(rows_2["Total"]);
                                cls_Cotizacion3.Total = Total.ToString("N");
                                cls_Cotizacion3.cl_nota = rows_2["cl_nota"].ToString();
                                lrords2.Add(cls_Cotizacion3);

                            }
                        }
                        frm_formatos frm_Formatos = new frm_formatos();
                        frm_Formatos.Reporte = "Cotizacion";
                        frm_Formatos.lctz = lrords;
                        frm_Formatos.lctz2 = lrords2;
                        frm_Formatos.Show();
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione Cotizacion a imprimir", "Imprimir", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void dtg_ayudas_DoubleClick(object sender, EventArgs e)
        {
            if (dtg_ayudas.Rows.Count > 0)
            {
                v_filas = dtg_ayudas.CurrentRow.Index;
                v_dato = dtg_ayudas[2, v_filas].Value.ToString();
                Enviainfo(v_dato);
                this.Dispose();
            }
        }
    }
}
