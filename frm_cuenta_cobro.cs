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
    public partial class frm_cuenta_cobro : Form
    {
        cl_cuenta_cobro cl_Cuenta_Cobro = new cl_cuenta_cobro();
        cls_item cls_Item = new cls_item();
        string v_consecutivo_os = "";
        bool v_ok;
        DataTable v_dt;
        DataTable v_dt_2;
        int v_contador = 0;
        public frm_cuenta_cobro()
        {
            InitializeComponent();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            v_consecutivo_os = "";
            if (txt_identificacion.Text != "")
            {
                //registrar
                if (dtg_venta.Rows.Count > 0)
                {
                    mtd_calculos();
                    v_dt = cl_Cuenta_Cobro.mtd_consultar_consecutivo();
                    if (v_dt.Rows.Count > 0)
                    {
                        DataRow row = v_dt.Rows[0];
                        cl_Cuenta_Cobro.cl_consecutivo = row["Consecutivo"].ToString();
                    }
                    else
                    {
                        cl_Cuenta_Cobro.cl_consecutivo = "1";
                    }
                    cl_Cuenta_Cobro.cl_documento = "CC";
                    if (v_consecutivo_os != "")
                    {
                        cl_Cuenta_Cobro.cl_consecutivo = v_consecutivo_os;
                        cl_Cuenta_Cobro.mtd_eliminar();
                        v_consecutivo_os = "";

                    }
                    int contadorError = 0;
                    int contadorCorrecto = 0;
                    foreach (DataGridViewRow item in dtg_venta.Rows)
                    {
                        cl_Cuenta_Cobro.v_buscar = txt_placa.Text;
                        v_dt = cl_Cuenta_Cobro.mtd_consultar_x_placa();
                        if (v_dt.Rows.Count > 0)
                        {
                            DataRow row = v_dt.Rows[0];
                            cl_Cuenta_Cobro.cl_vehiculo = row["cl_codigo_pk"].ToString();
                        }
                        cls_Item.v_buscar = item.Cells["cl_item"].Value.ToString();
                        v_dt = cls_Item.mtd_consultar();
                        if (v_dt.Rows.Count > 0)
                        {
                            DataRow row = v_dt.Rows[0];
                            cl_Cuenta_Cobro.cl_item = row["cl_codigo_pk"].ToString();
                        }
                        cl_Cuenta_Cobro.cl_cantidad = item.Cells["cl_cantidad"].Value.ToString();
                        cl_Cuenta_Cobro.cl_precioVenta = item.Cells["cl_precioVenta"].Value.ToString();
                        cl_Cuenta_Cobro.cl_costo = item.Cells["cl_costo"].Value.ToString();
                        cl_Cuenta_Cobro.cl_descuento = item.Cells["cl_descuento"].Value.ToString();
                        cl_Cuenta_Cobro.cl_fecha_creacion = DateTime.Now.ToString();
                        cl_Cuenta_Cobro.cl_fecha_modificacion = DateTime.Now.ToString();
                        cl_Cuenta_Cobro.cl_usuario = "1";
                        cl_Cuenta_Cobro.cl_nota = txt_nota.Text;
                        cl_Cuenta_Cobro.docOS = lbl_doc_fact.Text;
                        if (lbl_consedoc.Text != "-")
                        {
                            cl_Cuenta_Cobro.ConseOS = lbl_consedoc.Text;
                        }
                        else 
                        {
                            cl_Cuenta_Cobro.ConseOS = "0";
                        }
                        cl_Cuenta_Cobro.cl_km = txt_km.Text;
                 v_ok = cl_Cuenta_Cobro.mtd_registrar();
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
                        lbl_doc_fact.Text = "-";
                        lbl_consedoc.Text = "-";
                        txt_km.Text = "";

                        if (MessageBox.Show("¿Desea imprimir Cuenta cobro?", "Imprimir Cuenta cobro", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            cl_cuenta_cobro cl_Cuenta_Cobro = new cl_cuenta_cobro();
                            v_dt = cl_Cuenta_Cobro.mtd_consultar_ultima_orden();
                            DataRow rows = v_dt.Rows[0];
                            cl_Cuenta_Cobro.cl_documento = rows["cl_documento"].ToString();
                            cl_Cuenta_Cobro.cl_consecutivo = rows["Consecutivo"].ToString();
                            v_dt = cl_Cuenta_Cobro.mtd_consultar_orden_servicio();
                            List<cl_cuenta_cobro> lctcc = new List<cl_cuenta_cobro>();
                            List<cl_cuenta_cobro> lrctc2 = new List<cl_cuenta_cobro>();
                            int contadorCliente = 0;
                            foreach (DataRow rows_2 in v_dt.Rows)
                            {
                                cl_cuenta_cobro cl_Cuenta_Cobro2 = new cl_cuenta_cobro();
                                if (contadorCliente == 0)
                                {
                                    cl_Cuenta_Cobro2.cl_documento = rows_2["cl_documento"].ToString();
                                    cl_Cuenta_Cobro2.cl_consecutivo = rows_2["cl_consecutivo"].ToString();
                                    cl_Cuenta_Cobro2.cl_Vehiculo = rows_2["cl_Vehiculo1"].ToString();
                                    cl_Cuenta_Cobro2.cl_Placa = rows_2["cl_Placa"].ToString();
                                    cl_Cuenta_Cobro2.cl_Modelo = rows_2["cl_Modelo"].ToString();
                                    cl_Cuenta_Cobro2.cl_km = "0";
                                    cl_Cuenta_Cobro2.cl_identificacion = rows_2["cl_identificacion"].ToString();
                                    cl_Cuenta_Cobro2.cl_razon_social = rows_2["cl_razon_social"].ToString();
                                    cl_Cuenta_Cobro2.cl_direccion = rows_2["cl_direccion"].ToString();
                                    cl_Cuenta_Cobro2.cl_telefonos = rows_2["cl_telefonos"].ToString();
                                    cl_Cuenta_Cobro2.cl_Email = rows_2["cl_Email"].ToString();
                                    DateTime Fechamod = Convert.ToDateTime(rows_2["cl_fecha_modificacion"]);
                                    cl_Cuenta_Cobro2.cl_fecha_modificacion = Fechamod.ToString("yyyy-MM-dd");
                                }
                                if (rows_2["cl_tipo_item"].ToString() == "Servicio")
                                {
                                    //servicios

                                    cl_Cuenta_Cobro2.cl_documento = rows_2["cl_documento"].ToString();
                                    cl_Cuenta_Cobro2.cl_consecutivo = rows_2["cl_consecutivo"].ToString();
                                    cl_Cuenta_Cobro2.cl_vehiculo = rows_2["cl_vehiculo"].ToString();
                                    cl_Cuenta_Cobro2.cl_item = rows_2["cl_item"].ToString();
                                    cl_Cuenta_Cobro2.cl_cantidad = rows_2["cl_cantidad"].ToString();
                                    double Costo = Convert.ToDouble(rows_2["cl_costo"]);
                                    cl_Cuenta_Cobro2.cl_costo = Costo.ToString("N");
                                    double cl_precioVenta = Convert.ToDouble(rows_2["cl_precioVenta"]);
                                    cl_Cuenta_Cobro2.cl_precioVenta = cl_precioVenta.ToString("N");
                                    double cl_descuento = Convert.ToDouble(rows_2["cl_descuento"]);
                                    cl_Cuenta_Cobro2.cl_descuento = cl_descuento.ToString("N");
                                    DateTime Fechacrea = Convert.ToDateTime(rows_2["cl_fecha_creacion"]);
                                    cl_Cuenta_Cobro2.cl_fecha_creacion = Fechacrea.ToString("yyyy-MM-dd");
                                    DateTime FechaMod = Convert.ToDateTime(rows_2["cl_fecha_modificacion"]);
                                    cl_Cuenta_Cobro2.cl_fecha_modificacion = FechaMod.ToString("yyyy-MM-dd");
                                    cl_Cuenta_Cobro2.cl_usuario = rows_2["cl_usuario"].ToString();
                                    cl_Cuenta_Cobro2.Item = rows_2["item"].ToString();
                                    cl_Cuenta_Cobro2.cl_nombre = rows_2["cl_nombre"].ToString();
                                    cl_Cuenta_Cobro2.cl_descripcion = rows_2["cl_descripcion"].ToString();
                                    cl_Cuenta_Cobro2.cl_referencia = rows_2["cl_referencia"].ToString();
                                    cl_Cuenta_Cobro2.cl_codigo_barras = rows_2["cl_codigo_barras"].ToString();
                                    cl_Cuenta_Cobro2.cl_Vehiculo = rows_2["cl_Vehiculo1"].ToString();
                                    cl_Cuenta_Cobro2.cl_Placa = rows_2["cl_Placa"].ToString();
                                    cl_Cuenta_Cobro2.cl_Modelo = rows_2["cl_Modelo"].ToString();
                                    cl_Cuenta_Cobro2.cl_km = "0";
                                    cl_Cuenta_Cobro2.cl_identificacion = rows_2["cl_identificacion"].ToString();
                                    cl_Cuenta_Cobro2.cl_razon_social = rows_2["cl_razon_social"].ToString();
                                    cl_Cuenta_Cobro2.cl_direccion = rows_2["cl_direccion"].ToString();
                                    cl_Cuenta_Cobro2.cl_telefonos = rows_2["cl_telefonos"].ToString();
                                    cl_Cuenta_Cobro2.cl_Email = rows_2["cl_Email"].ToString();
                                    cl_Cuenta_Cobro2.cl_tipo_item = rows_2["cl_tipo_item"].ToString();
                                    double Total = Convert.ToDouble(rows_2["Total"]);
                                    cl_Cuenta_Cobro2.Total = Total.ToString("N");
                                    cl_Cuenta_Cobro2.cl_nota = rows_2["cl_nota"].ToString();
                                    cl_Cuenta_Cobro2.cl_km = rows_2["km"].ToString();
                                    lctcc.Add(cl_Cuenta_Cobro2);
                                }
                                else
                                {
                                    if (contadorCliente == 0)
                                    {
                                        lctcc.Add(cl_Cuenta_Cobro2);
                                        contadorCliente++;
                                    }
                                    //Productos
                                    cl_cuenta_cobro cl_Cuenta_Cobro3 = new cl_cuenta_cobro();
                                    cl_Cuenta_Cobro3.cl_documento = rows_2["cl_documento"].ToString();
                                    cl_Cuenta_Cobro3.cl_consecutivo = rows_2["cl_consecutivo"].ToString();
                                    cl_Cuenta_Cobro3.cl_vehiculo = rows_2["cl_vehiculo"].ToString();
                                    cl_Cuenta_Cobro3.cl_item = rows_2["cl_item"].ToString();
                                    cl_Cuenta_Cobro3.cl_cantidad = rows_2["cl_cantidad"].ToString();
                                    double Costo2 = Convert.ToDouble(rows_2["cl_costo"]);
                                    cl_Cuenta_Cobro3.cl_costo = Costo2.ToString("N");
                                    double cl_precioVenta2 = Convert.ToDouble(rows_2["cl_precioVenta"]);
                                    cl_Cuenta_Cobro3.cl_precioVenta = cl_precioVenta2.ToString("N");
                                    double cl_descuento2 = Convert.ToDouble(rows_2["cl_descuento"]);
                                    cl_Cuenta_Cobro3.cl_descuento = cl_descuento2.ToString("N");
                                    DateTime Fechacrea2 = Convert.ToDateTime(rows_2["cl_fecha_creacion"]);
                                    cl_Cuenta_Cobro3.cl_fecha_creacion = Fechacrea2.ToString("yyyy-MM-dd");
                                    DateTime FechaMod = Convert.ToDateTime(rows_2["cl_fecha_modificacion"]);
                                    cl_Cuenta_Cobro3.cl_fecha_modificacion = FechaMod.ToString("yyyy-MM-dd");
                                    cl_Cuenta_Cobro3.cl_usuario = rows_2["cl_usuario"].ToString();
                                    cl_Cuenta_Cobro3.Item = rows_2["item"].ToString();
                                    cl_Cuenta_Cobro3.cl_nombre = rows_2["cl_nombre"].ToString();
                                    cl_Cuenta_Cobro3.cl_descripcion = rows_2["cl_descripcion"].ToString();
                                    cl_Cuenta_Cobro3.cl_referencia = rows_2["cl_referencia"].ToString();
                                    cl_Cuenta_Cobro3.cl_codigo_barras = rows_2["cl_codigo_barras"].ToString();
                                    cl_Cuenta_Cobro3.cl_Vehiculo = rows_2["cl_Vehiculo1"].ToString();
                                    cl_Cuenta_Cobro3.cl_Placa = rows_2["cl_Placa"].ToString();
                                    cl_Cuenta_Cobro3.cl_Modelo = rows_2["cl_Modelo"].ToString();
                                    cl_Cuenta_Cobro3.cl_km = "0";
                                    cl_Cuenta_Cobro3.cl_identificacion = rows_2["cl_identificacion"].ToString();
                                    cl_Cuenta_Cobro3.cl_razon_social = rows_2["cl_razon_social"].ToString();
                                    cl_Cuenta_Cobro3.cl_direccion = rows_2["cl_direccion"].ToString();
                                    cl_Cuenta_Cobro3.cl_telefonos = rows_2["cl_telefonos"].ToString();
                                    cl_Cuenta_Cobro3.cl_Email = rows_2["cl_Email"].ToString();
                                    cl_Cuenta_Cobro3.cl_tipo_item = rows_2["cl_tipo_item"].ToString();
                                    double Total2 = Convert.ToDouble(rows_2["Total"]);
                                    cl_Cuenta_Cobro3.Total = Total2.ToString("N");
                                    cl_Cuenta_Cobro3.cl_nota = rows_2["cl_nota"].ToString();
                                    cl_Cuenta_Cobro3.cl_km = rows_2["km"].ToString();
                                    lrctc2.Add(cl_Cuenta_Cobro3);
                                }
                            }
                            frm_formatos frm_Formatos = new frm_formatos();
                            frm_Formatos.Reporte = "cuentacobro";
                            frm_Formatos.lctcb = lctcc;
                            frm_Formatos.lctcb2 = lrctc2;
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
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            frm_info_cuentaCobro frm_Info_cuentaCobro = new frm_info_cuentaCobro();
            frm_Info_cuentaCobro.Enviainfo += new frm_info_cuentaCobro.EnviarInfo(mtd_carga_datos);
            frm_Info_cuentaCobro.Show();
        }
        private void mtd_carga_datos(string vl_identificacion)
        {
            this.Cursor = Cursors.WaitCursor;
            cl_Cuenta_Cobro.cl_documento = "CC";
            cl_Cuenta_Cobro.cl_consecutivo = vl_identificacion;
            v_consecutivo_os = vl_identificacion;
            dtg_venta.Rows.Clear();
            v_dt_2 = cl_Cuenta_Cobro.mtd_consultar_orden_servicio_modificar();
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
        private void txt_placa_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorProvider1.Clear();
            if (e.KeyChar == (char)13)
            {
                this.Cursor = Cursors.WaitCursor;
                cl_Cuenta_Cobro.v_buscar = txt_placa.Text;
                v_dt = cl_Cuenta_Cobro.mtd_consultar_x_placa();
                if (v_dt.Rows.Count > 0)
                {
                    v_dt = cl_Cuenta_Cobro.mtd_consultar_x_placa();
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
                cl_Cuenta_Cobro.v_buscar = txt_placa.Text;
                v_dt = cl_Cuenta_Cobro.mtd_consultar_x_placa();
                if (v_dt.Rows.Count > 0)
                {
                    v_dt = cl_Cuenta_Cobro.mtd_consultar_x_placa();
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
        private void btn_buscar_items_Click(object sender, EventArgs e)
        {
            frm_busquedas frm_Busquedas = new frm_busquedas();
            frm_Busquedas.Modulo = 5;
            frm_Busquedas.Enviainfo += new frm_busquedas.EnviarInfo(mtd_carga_datos_items);
            frm_Busquedas.ShowDialog();
        }
        private void btn_os_Click(object sender, EventArgs e)
        {
            frm_info_orden_servicio frm_Info_Orden_Servicio = new frm_info_orden_servicio();
            frm_Info_Orden_Servicio.Enviainfo += new frm_info_orden_servicio.EnviarInfo(mtd_carga_datos_orden_Servicio);
            frm_Info_Orden_Servicio.Show();
        }
        private void mtd_carga_datos_orden_Servicio(string vl_identificacion)
        {
            cls_orden_servicio cls_Orden_Servicio = new cls_orden_servicio();
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

                lbl_doc_fact.Text = "OS";
                lbl_consedoc.Text = v_consecutivo_os;
            }
            mtd_calculos();
            this.Cursor = Cursors.Default;
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
    }
}
