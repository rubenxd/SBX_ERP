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
    public partial class frm_orden_servicio : Form
    {
        cls_orden_servicio cls_Orden_Servicio = new cls_orden_servicio();
        cls_item cls_Item = new cls_item();
        string v_consecutivo_os = "";
        bool v_ok;
        DataTable v_dt;
        DataTable v_dt_2;
        int v_contador = 0;
        public frm_orden_servicio()
        {
            InitializeComponent();
        }
        private void txt_placa_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorProvider1.Clear();
            if (e.KeyChar == (char)13)
            {
                this.Cursor = Cursors.WaitCursor;
                cls_Orden_Servicio.v_buscar = txt_placa.Text;
                v_dt = cls_Orden_Servicio.mtd_consultar_x_placa();
                if (v_dt.Rows.Count > 0)
                {
                    v_dt = cls_Orden_Servicio.mtd_consultar_x_placa();
                    DataRow row = v_dt.Rows[0];
                    txt_identificacion.Text = row["cl_identificacion"].ToString();
                    txt_nombre.Text = row["cl_razon_social"].ToString();
                    txt_modelo.Text = row["cl_modelo"].ToString();
                    txt_vehiculo.Text = row["cl_vehiculo"].ToString();     
                    lbl_placa.Text = row["cl_placa"].ToString();
                }
                else
                {
                    errorProvider1.SetError(txt_placa, "Placa NO existe");
                    txt_identificacion.Text = "";
                    txt_nombre.Text = "";
                    txt_modelo.Text = "";
                    txt_vehiculo.Text = "";                  
                }
                this.Cursor = Cursors.Default;
            }
        }
        private void txt_placa_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            errorProvider1.Clear();
            if (e.KeyData == Keys.Tab)
            {
                this.Cursor = Cursors.WaitCursor;
                cls_Orden_Servicio.v_buscar = txt_placa.Text;
                v_dt = cls_Orden_Servicio.mtd_consultar_x_placa();
                if (v_dt.Rows.Count > 0)
                {
                    v_dt = cls_Orden_Servicio.mtd_consultar_x_placa();
                    DataRow row = v_dt.Rows[0];
                    txt_identificacion.Text = row["cl_identificacion"].ToString();
                    txt_nombre.Text = row["cl_razon_social"].ToString();
                    txt_modelo.Text = row["cl_modelo"].ToString();
                    txt_vehiculo.Text = row["cl_vehiculo"].ToString();
                    lbl_placa.Text = row["cl_placa"].ToString();
                }
                else
                {
                    errorProvider1.SetError(txt_placa, "Placa NO existe");
                    txt_identificacion.Text = "";
                    txt_nombre.Text = "";
                    txt_modelo.Text = "";
                    txt_vehiculo.Text = "";
                }
                this.Cursor = Cursors.Default;
            }
        }
        private void btn_buscar_items_Click(object sender, EventArgs e)
        {
            frm_busquedas frm_Busquedas = new frm_busquedas();
            frm_Busquedas.Modulo = 5;
            frm_Busquedas.Enviainfo += new frm_busquedas.EnviarInfo(mtd_carga_datos_item);
            frm_Busquedas.ShowDialog();
        }
        private void mtd_carga_datos_item(string vl_identificacion)
        {
            this.Cursor = Cursors.WaitCursor;
            cls_Item.v_buscar = vl_identificacion;
            v_dt = cls_Item.mtd_consultar();
            if (v_dt.Rows.Count > 0)
            {
                v_dt = cls_Item.mtd_consultar();
                DataRow v_row = v_dt.Rows[0];
                dtg_venta.Rows.Add(1);
                v_contador = dtg_venta.Rows.Count;
                dtg_venta.Rows[v_contador - 1].Cells["cl_item"].Value = v_row["cl_item"];
                dtg_venta.Rows[v_contador - 1].Cells["cl_Nombre"].Value = v_row["cl_Nombre"];
                dtg_venta.Rows[v_contador - 1].Cells["cl_descripcion"].Value = v_row["cl_descripcion"];
                dtg_venta.Rows[v_contador - 1].Cells["cl_referencia"].Value = v_row["cl_referencia"];
                dtg_venta.Rows[v_contador - 1].Cells["cl_cantidad"].Value = "1";
                double precioVenta = Convert.ToDouble(v_row["cl_precioVenta"]);
                dtg_venta.Rows[v_contador - 1].Cells["cl_costo"].Value = v_row["cl_costo"];
                dtg_venta.Rows[v_contador - 1].Cells["cl_precioVenta"].Value = precioVenta.ToString("N");
                dtg_venta.Rows[v_contador - 1].Cells["cl_descuento"].Value = "0";
                dtg_venta.Rows[v_contador - 1].Cells["cl_total"].Value = precioVenta.ToString("N");
            }
            else
            {
                errorProvider1.SetError(txt_items, "Item NO existe");
            }
            mtd_calculos();
            this.Cursor = Cursors.Default;
        }
        private void txt_items_KeyPress(object sender, KeyPressEventArgs e)
        {
            v_contador = 0;
            errorProvider1.Clear();
            if (e.KeyChar == (char)13)
            {
                this.Cursor = Cursors.WaitCursor;
                cls_Item.v_buscar = txt_items.Text;
                v_dt = cls_Item.mtd_consultar();
                if (v_dt.Rows.Count > 0)
                {
                    v_dt = cls_Item.mtd_consultar();
                    DataRow v_row = v_dt.Rows[0];
                    dtg_venta.Rows.Add(1);
                    v_contador = dtg_venta.Rows.Count;
                    dtg_venta.Rows[v_contador - 1].Cells["cl_item"].Value = v_row["cl_item"];
                    dtg_venta.Rows[v_contador - 1].Cells["cl_Nombre"].Value = v_row["cl_Nombre"];
                    dtg_venta.Rows[v_contador - 1].Cells["cl_descripcion"].Value = v_row["cl_descripcion"];
                    dtg_venta.Rows[v_contador - 1].Cells["cl_referencia"].Value = v_row["cl_referencia"];
                    dtg_venta.Rows[v_contador - 1].Cells["cl_cantidad"].Value = "1";
                    double precioVenta = Convert.ToDouble(v_row["cl_precioVenta"]);
                    dtg_venta.Rows[v_contador - 1].Cells["cl_costo"].Value = v_row["cl_costo"];
                    dtg_venta.Rows[v_contador - 1].Cells["cl_precioVenta"].Value = precioVenta.ToString("N");
                    dtg_venta.Rows[v_contador - 1].Cells["cl_descuento"].Value = "0";                  
                    dtg_venta.Rows[v_contador - 1].Cells["cl_total"].Value = precioVenta.ToString("N");
                }
                else
                {
                    errorProvider1.SetError(txt_items, "Item NO existe");
                }
                this.Cursor = Cursors.Default;
            }
            mtd_calculos();
        }
        private void txt_items_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            v_contador = 0;
            errorProvider1.Clear();
            if (e.KeyData == Keys.Tab)
            {
                this.Cursor = Cursors.WaitCursor;
                cls_Item.v_buscar = txt_items.Text;
                v_dt = cls_Item.mtd_consultar();
                if (v_dt.Rows.Count > 0)
                {
                    v_dt = cls_Item.mtd_consultar();
                    DataRow v_row = v_dt.Rows[0];
                    dtg_venta.Rows.Add(1);
                    v_contador = dtg_venta.Rows.Count;
                    dtg_venta.Rows[v_contador - 1].Cells["cl_item"].Value = v_row["cl_item"];
                    dtg_venta.Rows[v_contador - 1].Cells["cl_Nombre"].Value = v_row["cl_Nombre"];
                    dtg_venta.Rows[v_contador - 1].Cells["cl_descripcion"].Value = v_row["cl_descripcion"];
                    dtg_venta.Rows[v_contador - 1].Cells["cl_referencia"].Value = v_row["cl_referencia"];
                    dtg_venta.Rows[v_contador - 1].Cells["cl_cantidad"].Value = "1";
                    double pv = Convert.ToDouble(v_row["cl_precioVenta"]);
                    dtg_venta.Rows[v_contador - 1].Cells["cl_precioVenta"].Value = pv.ToString("N");
                    dtg_venta.Rows[v_contador - 1].Cells["cl_descuento"].Value = "0";
                    dtg_venta.Rows[v_contador - 1].Cells["cl_total"].Value = pv.ToString("N");
                }
                else
                {
                    errorProvider1.SetError(txt_items, "Item NO existe");
                }
                this.Cursor = Cursors.Default;
            }
            mtd_calculos();
        }
        private void mtd_calculos() 
        {
            double Venta = 0;
            double subtotal = 0;
            double descuento = 0;
            double Total = 0;

            foreach (DataGridViewRow rows in dtg_venta.Rows)
            {
                Venta = (Convert.ToDouble(rows.Cells["cl_cantidad"].Value) * Convert.ToDouble(rows.Cells["cl_precioVenta"].Value));
                descuento = Convert.ToDouble(rows.Cells["cl_descuento"].Value);
                subtotal = Venta - descuento;
                rows.Cells["cl_total"].Value = subtotal.ToString("N");
                Total += subtotal;
            }
            txt_total.Text = Total.ToString("N");
        }
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (txt_identificacion.Text != "")
            {
                    //registrar
                    if (dtg_venta.Rows.Count > 0)
                    {
                    mtd_calculos();
                    v_dt = cls_Orden_Servicio.mtd_consultar_consecutivo();
                        if (v_dt.Rows.Count > 0)
                        {
                            DataRow row = v_dt.Rows[0];
                            cls_Orden_Servicio.cl_consecutivo = row["Consecutivo"].ToString();
                        }
                        else
                        {
                            cls_Orden_Servicio.cl_consecutivo = "1";
                        }
                    cls_Orden_Servicio.cl_documento = "OS";
                    if (v_consecutivo_os != "")
                    {
                        cls_Orden_Servicio.cl_consecutivo = v_consecutivo_os;
                        cls_Orden_Servicio.mtd_eliminar();
                        v_consecutivo_os = "";
                       
                    }
                        int contadorError = 0;
                        int contadorCorrecto = 0;
                        foreach (DataGridViewRow item in dtg_venta.Rows)
                        {                           
                            cls_Orden_Servicio.v_buscar = txt_placa.Text;
                            v_dt = cls_Orden_Servicio.mtd_consultar_x_placa();
                            if (v_dt.Rows.Count > 0)
                            {
                                DataRow row = v_dt.Rows[0];
                                cls_Orden_Servicio.cl_vehiculo = row["cl_codigo_pk"].ToString();
                            }
                            cls_Item.v_buscar = item.Cells["cl_item"].Value.ToString();
                            v_dt = cls_Item.mtd_consultar();
                            if (v_dt.Rows.Count > 0)
                            {
                                DataRow row = v_dt.Rows[0];
                                cls_Orden_Servicio.cl_item = row["cl_codigo_pk"].ToString();
                            }
                            cls_Orden_Servicio.cl_cantidad = item.Cells["cl_cantidad"].Value.ToString();
                            cls_Orden_Servicio.cl_precioVenta = item.Cells["cl_precioVenta"].Value.ToString();
                            cls_Orden_Servicio.cl_costo = item.Cells["cl_costo"].Value.ToString();
                            cls_Orden_Servicio.cl_descuento = item.Cells["cl_descuento"].Value.ToString();
                            cls_Orden_Servicio.cl_fecha_creacion = DateTime.Now.ToString();
                            cls_Orden_Servicio.cl_fecha_modificacion = DateTime.Now.ToString();
                            cls_Orden_Servicio.cl_usuario = "1";
                        cls_Orden_Servicio.cl_nota = txt_nota.Text;
                        cls_Orden_Servicio.cl_km = txt_km.Text;
                            v_ok = cls_Orden_Servicio.mtd_registrar();
                            if (v_ok)
                            {
                                contadorCorrecto++;
                            }
                            else
                            {
                                contadorError++;
                            }
                        }
                        MessageBox.Show("Proceso Terminado, Correcto:" + contadorCorrecto + ", Errores:" + contadorError, "Proceso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (contadorError == 0)
                        {
                            dtg_venta.Rows.Clear();
                            errorProvider1.Clear();
                            txt_placa.Text = "";
                            txt_identificacion.Text = "";
                            txt_nombre.Text = "";
                            txt_vehiculo.Text = "";
                            txt_modelo.Text = "";
                            lbl_placa.Text = "";
                            txt_items.Text = "";
                            txt_total.Text = "";
                        txt_nota.Text = "";
                        txt_km.Text = "";

                            if (MessageBox.Show("¿Desea imprimir Orden de servicio?", "Imprimir Orden de Servicio", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                cls_orden_servicio cls_Orden_Servicio = new cls_orden_servicio();
                                v_dt = cls_Orden_Servicio.mtd_consultar_ultima_orden();
                                DataRow rows = v_dt.Rows[0];
                                cls_Orden_Servicio.cl_documento = rows["cl_documento"].ToString();
                                cls_Orden_Servicio.cl_consecutivo = rows["Consecutivo"].ToString();
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
                                //cls_Orden_Servicio2.cl_km = "0";
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
                        MessageBox.Show("Ingrese items ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }                
            }
            else
            {
                MessageBox.Show("Ingrese placa vehiculo ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            frm_info_orden_servicio frm_Info_Orden_Servicio = new frm_info_orden_servicio();
            frm_Info_Orden_Servicio.Enviainfo += new frm_info_orden_servicio.EnviarInfo(mtd_carga_datos);
            frm_Info_Orden_Servicio.Show();
        }
        private void dtg_venta_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            cls_global cls_Global = new cls_global();
            foreach (DataGridViewRow row in dtg_venta.Rows)
            {
                if (row.Cells["cl_cantidad"].Value == null)
                {
                    row.Cells["cl_cantidad"].Value = "1";
                }
                else if (!cls_Global.IsNumericDouble(row.Cells["cl_cantidad"].Value.ToString()))
                {
                    row.Cells["cl_cantidad"].Value = "1";
                }

                if (row.Cells["cl_precioVenta"].Value == null)
                {
                    row.Cells["cl_precioVenta"].Value = "1";
                }
                else if (!cls_Global.IsNumericDouble(row.Cells["cl_precioVenta"].Value.ToString()))
                {
                    row.Cells["cl_precioVenta"].Value = "1";
                }

                if (row.Cells["cl_descuento"].Value == null)
                {
                    row.Cells["cl_descuento"].Value = "0";
                }
                else if (!cls_Global.IsNumericDouble(row.Cells["cl_descuento"].Value.ToString()))
                {
                    row.Cells["cl_descuento"].Value = "0";
                }
            }
            mtd_calculos();
        }
        private void btn_quitar_uno_Click(object sender, EventArgs e)
        {
            if (dtg_venta.Rows.Count > 0)
            {
                if (dtg_venta.CurrentRow != null)
                {
                    foreach (DataGridViewRow rows in dtg_venta.SelectedRows)
                    {
                        dtg_venta.Rows.Remove(dtg_venta.Rows[rows.Index]);
                    }
                }
                mtd_calculos();
            }
        }
        private void btn_cotizacion_Click(object sender, EventArgs e)
        {
            frm_info_cotizacion frm_Info_Cotizacion = new frm_info_cotizacion();
            frm_Info_Cotizacion.Enviainfo += new frm_info_cotizacion.EnviarInfo(mtd_carga_datos_cotizacion);
            frm_Info_Cotizacion.Show();
        }
        private void mtd_carga_datos(string vl_identificacion)
        {
            this.Cursor = Cursors.WaitCursor;
            cls_Orden_Servicio.cl_documento = "OS";
            cls_Orden_Servicio.cl_consecutivo = vl_identificacion;
            v_consecutivo_os = vl_identificacion;
            dtg_venta.Rows.Clear();
            v_dt_2 = cls_Orden_Servicio.mtd_consultar_orden_servicio_modificar();
            foreach (DataRow item in v_dt_2.Rows)
            {
                txt_placa.Text = item["cl_placa"].ToString();
                txt_identificacion.Text = item["cl_identificacion"].ToString();
                txt_nombre.Text = item["cl_razon_social"].ToString();
                txt_vehiculo.Text = item["cl_vehiculo"].ToString();
                txt_modelo.Text = item["cl_modelo"].ToString();
                lbl_placa.Text = item["cl_placa"].ToString();
                txt_km.Text = item["km"].ToString();
                txt_nota.Text = item["cl_nota"].ToString();

                dtg_venta.Rows.Add(1);
                v_contador = dtg_venta.Rows.Count;
                dtg_venta.Rows[v_contador - 1].Cells["cl_item"].Value = item["cl_item"];
                dtg_venta.Rows[v_contador - 1].Cells["cl_Nombre"].Value = item["cl_nombre"];
                dtg_venta.Rows[v_contador - 1].Cells["cl_descripcion"].Value = item["cl_descripcion"];
                dtg_venta.Rows[v_contador - 1].Cells["cl_referencia"].Value = item["cl_referencia"];
                dtg_venta.Rows[v_contador - 1].Cells["cl_cantidad"].Value = item["cl_cantidad"];
                double precioVenta = Convert.ToDouble(item["cl_precioVenta"]);
                dtg_venta.Rows[v_contador - 1].Cells["cl_precioVenta"].Value = precioVenta.ToString("N");
                dtg_venta.Rows[v_contador - 1].Cells["cl_costo"].Value = item["cl_costo"];
                double cl_descuento = Convert.ToDouble(item["cl_descuento"]);
                dtg_venta.Rows[v_contador - 1].Cells["cl_descuento"].Value = cl_descuento.ToString("N");
                dtg_venta.Rows[v_contador - 1].Cells["cl_total"].Value = precioVenta.ToString("N");
            }
            mtd_calculos();
            this.Cursor = Cursors.Default;
        }
        private void mtd_carga_datos_cotizacion(string vl_identificacion)
        {
            cls_cotizacion cls_Cotizacion = new cls_cotizacion();
            this.Cursor = Cursors.WaitCursor;
            cls_Cotizacion.cl_documento = "CT";
            cls_Cotizacion.cl_consecutivo = vl_identificacion;
            //v_consecutivo_os = vl_identificacion;
            //dtg_venta.Rows.Clear();
            v_dt_2 = cls_Cotizacion.mtd_consultar_orden_servicio_modificar();
            foreach (DataRow item in v_dt_2.Rows)
            {
                //txt_placa.Text = item["cl_placa"].ToString();
                //txt_identificacion.Text = item["cl_identificacion"].ToString();
                //txt_nombre.Text = item["cl_razon_social"].ToString();
                //txt_vehiculo.Text = item["cl_vehiculo"].ToString();
                //txt_modelo.Text = item["cl_modelo"].ToString();
                //lbl_placa.Text = item["cl_placa"].ToString();

                dtg_venta.Rows.Add(1);
                v_contador = dtg_venta.Rows.Count;
                dtg_venta.Rows[v_contador - 1].Cells["cl_item"].Value = item["cl_item"];
                dtg_venta.Rows[v_contador - 1].Cells["cl_Nombre"].Value = item["cl_nombre"];
                dtg_venta.Rows[v_contador - 1].Cells["cl_descripcion"].Value = item["cl_descripcion"];
                dtg_venta.Rows[v_contador - 1].Cells["cl_referencia"].Value = item["cl_referencia"];
                dtg_venta.Rows[v_contador - 1].Cells["cl_cantidad"].Value = item["cl_cantidad"];
                double precioVenta = Convert.ToDouble(item["cl_precioVenta"]);
                dtg_venta.Rows[v_contador - 1].Cells["cl_precioVenta"].Value = precioVenta.ToString("N");
                dtg_venta.Rows[v_contador - 1].Cells["cl_costo"].Value = item["cl_costo"];
                double cl_descuento = Convert.ToDouble(item["cl_descuento"]);
                dtg_venta.Rows[v_contador - 1].Cells["cl_descuento"].Value = cl_descuento.ToString("N");
                dtg_venta.Rows[v_contador - 1].Cells["cl_total"].Value = precioVenta.ToString("N");
            }
            mtd_calculos();
            this.Cursor = Cursors.Default;
        }
    }
}
