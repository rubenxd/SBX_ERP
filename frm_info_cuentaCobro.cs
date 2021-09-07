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
    public partial class frm_info_cuentaCobro : Form
    {
        cl_cuenta_cobro cl_Cuenta_cobro = new cl_cuenta_cobro();
        //Delegado
        public delegate void EnviarInfo(string dato);
        public event EnviarInfo Enviainfo;
        int v_filas = 0;
        DataTable v_dt;
        public int Modulo { get; set; }
        string v_dato = "";
        public frm_info_cuentaCobro()
        {
            InitializeComponent();
        }
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            cl_Cuenta_cobro.v_buscar = txt_buscar.Text;
            cl_Cuenta_cobro.v_Fecha_inicio = dtp_fecha_inicio.Text;
            cl_Cuenta_cobro.v_Fecha_fin = dtp_fecha_fin.Text;
            v_dt = cl_Cuenta_cobro.mtd_consultar_ordenes();
            dtg_ayudas.DataSource = v_dt;
            mtd_calcular();
        }
        private void mtd_calcular()
        {
            double totalCostos = 0;
            double TotalVentas = 0;
            if (dtg_ayudas.Rows.Count > 0)
            {
                foreach (DataGridViewRow rows in dtg_ayudas.Rows)
                {
                    if (rows.Cells["cl_estado"].Value.ToString() == "Activa")
                    {
                        totalCostos += Convert.ToDouble(rows.Cells["Costo"].Value) * Convert.ToDouble(rows.Cells["Cantidad"].Value);
                        TotalVentas += Convert.ToDouble(rows.Cells["Precio Venta"].Value) * Convert.ToDouble(rows.Cells["Cantidad"].Value);
                    }              
                }      
                    txt_costo.Text = totalCostos.ToString("N0");
                    txt_venta.Text = TotalVentas.ToString("N0");
            }
        }
        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            if (dtg_ayudas.Rows.Count > 0)
            {
                foreach (DataGridViewRow item in dtg_ayudas.SelectedRows)
                {
                    if (MessageBox.Show("¿Desea imprimir Cuenta cobro?", "Imprimir Cuenta cobro", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        int contadorItems = 0;
                        DataRow rows = v_dt.Rows[0];
                        cl_Cuenta_cobro.cl_documento = item.Cells["Documento"].Value.ToString();
                        cl_Cuenta_cobro.cl_consecutivo = item.Cells["Consecutivo"].Value.ToString();
                        v_dt = cl_Cuenta_cobro.mtd_consultar_orden_servicio();
                        List<cl_cuenta_cobro> lrctc = new List<cl_cuenta_cobro>();
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
                                cl_Cuenta_Cobro2.cl_km = rows_2["km"].ToString();
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
                                contadorItems++;
                                cl_Cuenta_Cobro2.cl_item = contadorItems.ToString();
                                //cl_Cuenta_Cobro2.cl_item = rows_2["cl_item"].ToString();
                                cl_Cuenta_Cobro2.cl_cantidad = rows_2["cl_cantidad"].ToString();
                                double Costo = Convert.ToDouble(rows_2["cl_costo"]);
                                cl_Cuenta_Cobro2.cl_costo = Costo.ToString("N");
                                double cl_precioVenta = Convert.ToDouble(rows_2["cl_precioVenta"]);
                                cl_Cuenta_Cobro2.cl_precioVenta = cl_precioVenta.ToString("N");
                                double cl_descuento = Convert.ToDouble(rows_2["cl_descuento"]);
                                cl_Cuenta_Cobro2.cl_descuento = cl_descuento.ToString("N");
                                DateTime Fechacrea = Convert.ToDateTime(rows_2["cl_fecha_creacion"]);
                                cl_Cuenta_Cobro2.cl_fecha_creacion = Fechacrea.ToString("yyyy-MM-dd");
                                DateTime Fechamod = Convert.ToDateTime(rows_2["cl_fecha_modificacion"]);
                                cl_Cuenta_Cobro2.cl_fecha_modificacion = Fechamod.ToString("yyyy-MM-dd");
                                cl_Cuenta_Cobro2.cl_usuario = rows_2["cl_usuario"].ToString();                        
                                cl_Cuenta_Cobro2.Item = rows_2["item"].ToString();                             
                                cl_Cuenta_Cobro2.cl_nombre = rows_2["cl_nombre"].ToString();
                                cl_Cuenta_Cobro2.cl_descripcion = rows_2["cl_descripcion"].ToString();
                                cl_Cuenta_Cobro2.cl_referencia = rows_2["cl_referencia"].ToString();
                                cl_Cuenta_Cobro2.cl_codigo_barras = rows_2["cl_codigo_barras"].ToString();
                                cl_Cuenta_Cobro2.cl_Vehiculo = rows_2["cl_Vehiculo1"].ToString();
                                cl_Cuenta_Cobro2.cl_Placa = rows_2["cl_Placa"].ToString();
                                cl_Cuenta_Cobro2.cl_Modelo = rows_2["cl_Modelo"].ToString();
                                cl_Cuenta_Cobro2.cl_km = rows_2["km"].ToString();
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
                                lrctc.Add(cl_Cuenta_Cobro2);
                            }
                            else
                            {
                                if (contadorCliente == 0)
                                {
                                    lrctc.Add(cl_Cuenta_Cobro2);
                                    contadorCliente++;
                                }
                                //Productos
                                cl_cuenta_cobro cl_Cuenta_Cobro3 = new cl_cuenta_cobro();
                                cl_Cuenta_Cobro3.cl_documento = rows_2["cl_documento"].ToString();
                                cl_Cuenta_Cobro3.cl_consecutivo = rows_2["cl_consecutivo"].ToString();
                                cl_Cuenta_Cobro3.cl_vehiculo = rows_2["cl_vehiculo"].ToString();
                                contadorItems++;
                                cl_Cuenta_Cobro3.cl_item = contadorItems.ToString();
                                //cl_Cuenta_Cobro3.cl_item = rows_2["cl_item"].ToString();
                                cl_Cuenta_Cobro3.cl_cantidad = rows_2["cl_cantidad"].ToString();
                                double Costo2 = Convert.ToDouble(rows_2["cl_costo"]);
                                cl_Cuenta_Cobro3.cl_costo = Costo2.ToString("N");
                                double cl_precioVenta2 = Convert.ToDouble(rows_2["cl_precioVenta"]);
                                cl_Cuenta_Cobro3.cl_precioVenta = cl_precioVenta2.ToString("N");
                                double cl_descuento2 = Convert.ToDouble(rows_2["cl_descuento"]);
                                cl_Cuenta_Cobro3.cl_descuento = cl_descuento2.ToString("N");
                                DateTime Fechacrea2 = Convert.ToDateTime(rows_2["cl_fecha_creacion"]);
                                cl_Cuenta_Cobro3.cl_fecha_creacion = Fechacrea2.ToString("yyyy-MM-dd");
                                DateTime Fechamod = Convert.ToDateTime(rows_2["cl_fecha_modificacion"]);
                                cl_Cuenta_Cobro3.cl_fecha_modificacion = Fechamod.ToString("yyyy-MM-dd");
                               
                                cl_Cuenta_Cobro3.cl_usuario = rows_2["cl_usuario"].ToString();
                                cl_Cuenta_Cobro3.Item = rows_2["item"].ToString();
                                cl_Cuenta_Cobro3.cl_nombre = rows_2["cl_nombre"].ToString();
                                cl_Cuenta_Cobro3.cl_descripcion = rows_2["cl_descripcion"].ToString();
                                cl_Cuenta_Cobro3.cl_referencia = rows_2["cl_referencia"].ToString();
                                cl_Cuenta_Cobro3.cl_codigo_barras = rows_2["cl_codigo_barras"].ToString();
                                cl_Cuenta_Cobro3.cl_Vehiculo = rows_2["cl_Vehiculo1"].ToString();
                                cl_Cuenta_Cobro3.cl_Placa = rows_2["cl_Placa"].ToString();
                                cl_Cuenta_Cobro3.cl_Modelo = rows_2["cl_Modelo"].ToString();
                                cl_Cuenta_Cobro3.cl_km = rows_2["km"].ToString();
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
                        frm_Formatos.lctcb = lrctc;
                        frm_Formatos.lctcb2 = lrctc2;
                        frm_Formatos.Show();
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione Cuenta cobro a imprimir", "Imprimir", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        Boolean v_ok;
        string DocNuevo = "";
        string ConseDocNuevo = "";
        string NotaAnulacion = "";
        private void btn_anular_Click(object sender, EventArgs e)
        {
             DocNuevo = "";
             ConseDocNuevo = "";
             NotaAnulacion = "";
            if (dtg_ayudas.Rows.Count > 0)
            {
                if (MessageBox.Show("¿Desea Anular cuenta de cobro?", "Anular Cuenta de cobro", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (dtg_ayudas.Rows.Count > 0)
                    {
                        frm_anular_doc frm_Anular_Doc = new frm_anular_doc();
                        frm_Anular_Doc.Enviainfo += new frm_anular_doc.EnviarInfo(mtd_carga_datos);
                        frm_Anular_Doc.ShowDialog();
                        if (DocNuevo != "")
                        {
                            foreach (DataGridViewRow item in dtg_ayudas.SelectedRows)
                            {
                                DataRow rows = v_dt.Rows[0];
                                cl_Cuenta_cobro.cl_documento = item.Cells["Documento"].Value.ToString();
                                cl_Cuenta_cobro.cl_consecutivo = item.Cells["Consecutivo"].Value.ToString();
                                string Estado = item.Cells["cl_estado"].Value.ToString();
                                if (Estado == "Activa")
                                {
                                    cl_Cuenta_cobro.cl_doc_nuevo = DocNuevo;
                                    cl_Cuenta_cobro.cl_conse_nuevo = ConseDocNuevo;
                                    cl_Cuenta_cobro.cl_nota_anulacion = NotaAnulacion;
                                    v_ok = cl_Cuenta_cobro.mtd_Anular();
                                    if (v_ok)
                                    {
                                        MessageBox.Show("Cuenta de cobro: " + item.Cells["Documento"].Value.ToString() + " - " + item.Cells["Consecutivo"].Value.ToString() + " Anulada", "Anulada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                        cl_Cuenta_cobro.v_buscar = txt_buscar.Text;
                                        cl_Cuenta_cobro.v_Fecha_inicio = dtp_fecha_inicio.Text;
                                        cl_Cuenta_cobro.v_Fecha_fin = dtp_fecha_fin.Text;
                                        v_dt = cl_Cuenta_cobro.mtd_consultar_ordenes();
                                        dtg_ayudas.DataSource = v_dt;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Cuenta de cobro Ya esta Anulada, por favor revise que la cuenta de cobro este Activa", "Error Anular", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                }
            }
             
        }
        private void mtd_carga_datos(string Dato1, string Dato2, string Dato3) 
        {
            if (Dato1 != "Cancelar")
            {
                DocNuevo = Dato1;
                ConseDocNuevo = Dato2;
                NotaAnulacion = Dato3;
            }      
        }
    }
}
