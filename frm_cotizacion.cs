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
    public partial class frm_cotizacion : Form
    {
        cls_cotizacion cls_Cotizacion = new cls_cotizacion();
        cls_item cls_Item = new cls_item();
        string v_consecutivo_os = "";
        bool v_ok;
        DataTable v_dt;
        DataTable v_dt_2;
        int v_contador = 0;
        int TipoBusquedaDoc = 0;
        public frm_cotizacion()
        {
            InitializeComponent();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (txt_identificacion.Text != "")
            {
                //registrar
                if (dtg_venta.Rows.Count > 0)
                {
                    mtd_calculos();
                    v_dt = cls_Cotizacion.mtd_consultar_consecutivo();
                    if (v_dt.Rows.Count > 0)
                    {
                        DataRow row = v_dt.Rows[0];
                        cls_Cotizacion.cl_consecutivo = row["Consecutivo"].ToString();
                    }
                    else
                    {
                        cls_Cotizacion.cl_consecutivo = "1";
                    }
                    cls_Cotizacion.cl_documento = "CT";
                    if (v_consecutivo_os != "")
                    {
                        cls_Cotizacion.cl_consecutivo = v_consecutivo_os;
                        cls_Cotizacion.mtd_eliminar();
                        v_consecutivo_os = "";

                    }
                    int contadorError = 0;
                    int contadorCorrecto = 0;
                    foreach (DataGridViewRow item in dtg_venta.Rows)
                    {
                        if (TipoBusquedaDoc != 1)
                        {
                            cls_Cotizacion.v_buscar = txt_placa.Text;
                            v_dt = cls_Cotizacion.mtd_consultar_x_placa();
                            if (v_dt.Rows.Count > 0)
                            {
                                DataRow row = v_dt.Rows[0];
                                cls_Cotizacion.cl_vehiculo = row["cl_codigo_pk"].ToString();
                            }
                        }
                        
                        cls_Item.v_buscar = item.Cells["cl_item"].Value.ToString();
                        v_dt = cls_Item.mtd_consultar();
                        if (v_dt.Rows.Count > 0)
                        {
                            DataRow row = v_dt.Rows[0];
                            cls_Cotizacion.cl_item = row["cl_codigo_pk"].ToString();
                        }
                        cls_Cotizacion.cl_cantidad = item.Cells["cl_cantidad"].Value.ToString();
                        cls_Cotizacion.cl_precioVenta = item.Cells["cl_precioVenta"].Value.ToString();
                        cls_Cotizacion.cl_costo = item.Cells["cl_costo"].Value.ToString();
                        cls_Cotizacion.cl_descuento = item.Cells["cl_descuento"].Value.ToString();
                        cls_Cotizacion.cl_fecha_creacion = DateTime.Now.ToString();
                        cls_Cotizacion.cl_fecha_modificacion = DateTime.Now.ToString();
                        cls_Cotizacion.cl_usuario = "1";
                        cls_Cotizacion.cl_nota = txt_nota.Text;
                        v_ok = cls_Cotizacion.mtd_registrar();
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

                        if (MessageBox.Show("¿Desea imprimir Cotizacion?", "Imprimir Cotizacion", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            int contadorItems = 0;
                            cls_cotizacion cls_Cotizacion = new cls_cotizacion();
                            v_dt = cls_Cotizacion.mtd_consultar_ultima_orden();
                            DataRow rows = v_dt.Rows[0];
                            cls_Cotizacion.cl_documento = rows["cl_documento"].ToString();
                            cls_Cotizacion.cl_consecutivo = rows["Consecutivo"].ToString();
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
                                    //servicios
                                    if (contadorCliente == 0) 
                                    {
                                        lrords.Add(cls_Cotizacion2);
                                        contadorCliente++;
                                    }                                        
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
            frm_info_cotizacion frm_Info_Cotizacion = new frm_info_cotizacion();
            frm_Info_Cotizacion.Enviainfo += new frm_info_cotizacion.EnviarInfo(mtd_carga_datos);
            frm_Info_Cotizacion.Show();
        }
        private void mtd_carga_datos_items(string vl_identificacion)
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
        private void mtd_carga_datos(string vl_identificacion)
        {
            this.Cursor = Cursors.WaitCursor;
            cls_Cotizacion.cl_documento = "CT";
            cls_Cotizacion.cl_consecutivo = vl_identificacion;
            v_consecutivo_os = vl_identificacion;
            dtg_venta.Rows.Clear();
            v_dt_2 = cls_Cotizacion.mtd_consultar_orden_servicio_modificar();
            foreach (DataRow item in v_dt_2.Rows)
            {
                txt_placa.Text = item["cl_placa"].ToString();
                txt_identificacion.Text = item["cl_identificacion"].ToString();
                txt_nombre.Text = item["cl_razon_social"].ToString();
                txt_vehiculo.Text = item["cl_vehiculo"].ToString();
                txt_modelo.Text = item["cl_modelo"].ToString();
                lbl_placa.Text = item["cl_placa"].ToString();
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
        private void mtd_calculos()
        {
            double Venta = 0;
            double subtotal = 0;
            double descuento = 0;
            double Total = 0;

            foreach (DataGridViewRow rows in dtg_venta.Rows)
            {
                Venta = (Convert.ToDouble(rows.Cells["cl_cantidad"].Value) * Convert.ToDouble(rows.Cells["cl_precioVenta"].Value));
                descuento = Venta * (Convert.ToDouble(rows.Cells["cl_descuento_porcentaje"].Value) / 100);
                rows.Cells["cl_descuento"].Value = descuento.ToString("N0");
                subtotal = Venta - descuento;
                rows.Cells["cl_total"].Value = subtotal.ToString("N");
                Total += subtotal;
            }
            txt_total.Text = Total.ToString("N");
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
        private void btn_buscar_items_Click(object sender, EventArgs e)
        {
            frm_busquedas frm_Busquedas = new frm_busquedas();
            frm_Busquedas.Modulo = 7;
            frm_Busquedas.Enviainfo += new frm_busquedas.EnviarInfo(mtd_carga_datos_items);
            frm_Busquedas.ShowDialog();
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

        private void txt_placa_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorProvider1.Clear();
            if (e.KeyChar == (char)13)
            {
                this.Cursor = Cursors.WaitCursor;
                cls_Cotizacion.v_buscar = txt_placa.Text;
                if (TipoBusquedaDoc == 1)
                {
                    v_dt = cls_Cotizacion.mtd_consultar_x_identificacion();
                    if (v_dt.Rows.Count > 0)
                    {
                        v_dt = cls_Cotizacion.mtd_consultar_x_identificacion();
                        DataRow row = v_dt.Rows[0];
                        txt_identificacion.Text = row["cl_identificacion"].ToString();
                        txt_nombre.Text = row["cl_razon_social"].ToString();
                        txt_modelo.Text = row["cl_modelo"].ToString();
                        txt_vehiculo.Text = row["cl_vehiculo"].ToString();
                        lbl_placa.Text = row["cl_placa"].ToString();
                    }
                    else
                    {
                        errorProvider1.SetError(txt_placa, "Identificacion NO existe");
                        txt_identificacion.Text = "";
                        txt_nombre.Text = "";
                        txt_modelo.Text = "";
                        txt_vehiculo.Text = "";
                    }
                }
                else 
                {
                    v_dt = cls_Cotizacion.mtd_consultar_x_placa();
                    if (v_dt.Rows.Count > 0)
                    {
                        v_dt = cls_Cotizacion.mtd_consultar_x_placa();
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
                cls_Cotizacion.v_buscar = txt_placa.Text;
                if (TipoBusquedaDoc == 1) 
                {
                    v_dt = cls_Cotizacion.mtd_consultar_x_identificacion();
                    if (v_dt.Rows.Count > 0)
                    {
                        v_dt = cls_Cotizacion.mtd_consultar_x_identificacion();
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
                }
                else 
                {
                    v_dt = cls_Cotizacion.mtd_consultar_x_placa();
                    if (v_dt.Rows.Count > 0)
                    {
                        v_dt = cls_Cotizacion.mtd_consultar_x_placa();
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
                }
                 
                this.Cursor = Cursors.Default;
            }
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

                if (row.Cells["cl_descuento_porcentaje"].Value == null)
                {
                    row.Cells["cl_descuento_porcentaje"].Value = "0";
                }
                else if (!cls_Global.IsNumericDouble(row.Cells["cl_descuento_porcentaje"].Value.ToString()))
                {
                    row.Cells["cl_descuento_porcentaje"].Value = "0";
                }
            }
            mtd_calculos();
        }
        cls_config cls_Config = new cls_config();
        private void frm_cotizacion_Load(object sender, EventArgs e)
        {
            v_dt = cls_Config.mtd_consultar_Tipo_busqueda_doc();
            if (v_dt.Rows.Count > 0)
            {
                DataRow row = v_dt.Rows[0];
                if (row["TipoBusquedaDoc"].ToString() == "1")
                {
                    label1.Text = "Ident";
                    TipoBusquedaDoc = 1;
                    label3.Visible = false;
                    label2.Visible = false;
                    txt_modelo.Visible = false;
                    txt_vehiculo.Visible = false;
                }
                else
                {
                    label1.Text = "Placa";
                    TipoBusquedaDoc = 0;
                    label3.Visible = true;
                    label2.Visible = true;
                    txt_modelo.Visible = true;
                    txt_vehiculo.Visible = true;
                }
            }
        }
    }
}
