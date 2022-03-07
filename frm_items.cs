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
    public partial class frm_items : Form
    {
        int v_validado = 0;
        bool v_ok;
        DataTable v_dt;
        cls_item cls_Item = new cls_item();
        cls_global cls_Global = new cls_global();
        public frm_items()
        {
            InitializeComponent();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {           
            mtd_validar();
            if (v_validado == 0)
            {
                cls_Item.cl_item = txt_item.Text;
                cls_Item.cl_nombre = txt_nombre.Text;
                cls_Item.cl_descripcion = txt_descripcion.Text;
                cls_Item.cl_referencia = txt_referencia.Text;
                cls_Item.cl_codigo_barras = txt_codigo_barras.Text;
                cls_Item.cl_estado = cbx_estado.Text;
                cls_Item.cl_tipo_item = cbx_tipo_item.Text;
                cls_Item.cl_costo = txt_costo.Text;
                cls_Item.cl_PrecioVenta = txt_precio_venta.Text;
                cls_Item.cl_stock_minimo = txt_stock_minimo.Text;
                cls_Item.cl_stock_maximo = txt_stock_maximo.Text;
                cls_Item.cl_cantidad = txt_cantidad.Text;

                if (rd_entrada.Checked == true)
                {
                    cls_Item.cl_movimiento = rd_entrada.Text;
                }
                else
                {
                    cls_Item.cl_movimiento = rd_salida.Text;
                }
                DateTime Fecha = DateTime.Now;
                cls_Item.cl_fecha_creacion = Fecha.ToString();
                cls_Item.cl_fecha_modificacion = Fecha.ToString();
                cls_Item.cl_usuario = "1";

                //verificar item
                cls_Item.v_buscar = txt_item.Text;
                v_dt = cls_Item.mtd_consultar();
                if (v_dt.Rows.Count > 0)
                {
                    //Editar
                    cls_Item.cl_Accion = "UPDATE-ITEM";
                    v_ok = cls_Item.mtd_Editar();
                    if (v_ok)
                    {
                        MessageBox.Show("Item Editado correctamente", "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        mtd_limpiar();
                    }
                }
                else 
                {
                    //Registrar 
                    cls_Item.cl_Accion = "INSERT-ITEM";
                    v_ok = cls_Item.mtd_registrar();
                    if (v_ok)
                    {
                        MessageBox.Show("Item registrado correctamente", "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        mtd_limpiar();
                    }
                }             
            }
            double Margen = 0;
            if (txt_precio_venta.Text != "" && txt_costo.Text != "") { 
                if (!cls_Global.IsNumericDouble(txt_costo.Text) && !cls_Global.IsNumericDouble(txt_precio_venta.Text))
            {
                Margen = (Convert.ToDouble(txt_precio_venta.Text) - Convert.ToDouble(txt_costo.Text));
                Margen = Margen / Convert.ToDouble(txt_precio_venta.Text);
                Margen = Margen * 100;
                txt_margen.Text = Margen.ToString();
            }
            }
        }     
        private void mtd_limpiar()
        {
            txt_item.Text = "";
            txt_nombre.Text = "";
            txt_descripcion.Text = "";
            txt_referencia.Text = "";
            txt_codigo_barras.Text = "";
            cbx_estado.SelectedIndex = 0;
            cbx_tipo_item.SelectedIndex = 0;
            txt_costo.Text = "";
            txt_margen.Text = "";
            txt_precio_venta.Text = "";
            txt_stock_minimo.Text = "0";
            txt_stock_maximo.Text = "0";
            txt_cantidad.Text = "";
            rd_entrada.Checked = true;
            rd_salida.Checked = false;

            v_dt = cls_Item.mtd_consultar_consecutivo();
            DataRow row = v_dt.Rows[0];
            txt_item.Text = row["Consecutivo"].ToString();
            errorProvider1.Clear();
        }
        private void mtd_validar() 
        {
            errorProvider1.Clear();
            v_validado = 0;
            if (txt_item.Text == "")
            {
                errorProvider1.SetError(txt_item, "Ingrese Item");
                v_validado++;
            }
            if (txt_nombre.Text == "")
            {
                errorProvider1.SetError(txt_nombre, "Ingrese Nombre");
                v_validado++;
            }
            if (txt_costo.Text == "")
            {
                errorProvider1.SetError(txt_costo, "Ingrese Costo");
                v_validado++;
            }
            if (!cls_Global.IsNumericDouble(txt_costo.Text))
            {
                errorProvider1.SetError(txt_costo, "Ingrese valores numericos");
                v_validado++;
            }
            if (txt_margen.Text == "")
            {
                errorProvider1.SetError(txt_margen, "Ingrese Margen");
                v_validado++;
            }
            if (!cls_Global.IsNumericDouble(txt_margen.Text))
            {
                errorProvider1.SetError(txt_margen, "Ingrese valores numericos");
                v_validado++;
            }
            if (txt_precio_venta.Text == "")
            {
                errorProvider1.SetError(txt_precio_venta, "Ingrese Precio venta");
                v_validado++;
            }
            if (!cls_Global.IsNumericDouble(txt_precio_venta.Text))
            {
                errorProvider1.SetError(txt_precio_venta, "Ingrese valores numericos");
                v_validado++;
            }
            if (txt_cantidad.Text == "")
            {
                errorProvider1.SetError(txt_cantidad, "Ingrese cantidad");
                v_validado++;
            }
            if (!cls_Global.IsNumericDouble(txt_cantidad.Text))
            {
                errorProvider1.SetError(txt_cantidad, "Ingrese valores numericos");
                v_validado++;
            }
            if (txt_stock_minimo.Text == "")
            {
                txt_stock_minimo.Text = "0";
            }
            if (!cls_Global.IsNumericDouble(txt_stock_minimo.Text))
            {
                errorProvider1.SetError(txt_stock_minimo, "Ingrese valores numericos");
                v_validado++;
            }
            if (txt_stock_maximo.Text == "")
            {
                txt_stock_maximo.Text = "0";
            }
            if (!cls_Global.IsNumericDouble(txt_stock_maximo.Text))
            {
                errorProvider1.SetError(txt_stock_maximo, "Ingrese valores numericos");
                v_validado++;
            }
            double Margen = 0;
            if (txt_precio_venta.Text != "" && txt_costo.Text != "")
            {
                if (!cls_Global.IsNumericDouble(txt_costo.Text) && !cls_Global.IsNumericDouble(txt_precio_venta.Text))
                {
                    Margen = (Convert.ToDouble(txt_precio_venta.Text) - Convert.ToDouble(txt_costo.Text));
                    Margen = Margen / Convert.ToDouble(txt_precio_venta.Text);
                    Margen = Margen * 100;
                    txt_margen.Text = Margen.ToString();
                }
            }        
        }
        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            mtd_limpiar();
        }
        private void frm_items_Load(object sender, EventArgs e)
        {
            v_dt = cls_Item.mtd_consultar_consecutivo();
            if (v_dt.Rows.Count > 0)
            {
                DataRow row = v_dt.Rows[0];
                txt_item.Text = row["Consecutivo"].ToString();
            }
            else 
            {
                txt_item.Text = "1";
            }    
            
            cbx_estado.SelectedIndex = 0;
            cbx_tipo_item.SelectedIndex = 0;
            rd_entrada.Checked = true;
        }
        private void btn_consultas_Click(object sender, EventArgs e)
        {
            frm_info_items frm_Info_Items = new frm_info_items();
            frm_Info_Items.Show();
        }
        private void btn_buscar_producto_Click(object sender, EventArgs e)
        {
            frm_busquedas frm_Busquedas = new frm_busquedas();
            frm_Busquedas.Modulo = 7;
            frm_Busquedas.Enviainfo += new frm_busquedas.EnviarInfo(mtd_carga_datos);
            frm_Busquedas.ShowDialog();
        }
        private void mtd_carga_datos(string vl_identificacion)
        {
            this.Cursor = Cursors.WaitCursor;            
            cls_Item.v_buscar = vl_identificacion;
            v_dt = cls_Item.mtd_consultar();
            double Costo = 0;
            double PrecioVenta = 0;
            foreach (DataRow item in v_dt.Rows)
            {
                txt_item.Text = item["cl_item"].ToString();
                txt_nombre.Text = item["cl_nombre"].ToString();
                txt_descripcion.Text = item["cl_descripcion"].ToString();
                txt_referencia.Text = item["cl_referencia"].ToString();
                txt_codigo_barras.Text = item["cl_codigo_barras"].ToString();
                cbx_estado.Text = item["cl_estado"].ToString();
                cbx_tipo_item.Text = item["cl_tipo_item"].ToString();
                Costo = Convert.ToDouble(item["cl_costo"]);
                txt_costo.Text = Costo.ToString("N0");
                PrecioVenta = Convert.ToDouble(item["cl_PrecioVenta"]);
                txt_precio_venta.Text = PrecioVenta.ToString();
                txt_stock_minimo.Text = item["cl_stock_minimo"].ToString();
                txt_stock_maximo.Text = item["cl_stock_maximo"].ToString();
                txt_cantidad.Text = "";
                double Margen = 0;
                if (cls_Global.IsNumericDouble(txt_costo.Text) && cls_Global.IsNumericDouble(txt_precio_venta.Text))
                {
                    Margen = (Convert.ToDouble(txt_precio_venta.Text) - Convert.ToDouble(txt_costo.Text));
                    Margen = Margen / Convert.ToDouble(txt_precio_venta.Text);
                    Margen = Margen * 100;
                    txt_margen.Text = Margen.ToString();
                }
            }
            this.Cursor = Cursors.Default;
        }

        private void txt_costo_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Tab) 
            {
                double Margen = 0;
                if (cls_Global.IsNumericDouble(txt_costo.Text) && cls_Global.IsNumericDouble(txt_precio_venta.Text))
                {
                    Margen = (Convert.ToDouble(txt_precio_venta.Text) - Convert.ToDouble(txt_costo.Text));
                    Margen = Margen / Convert.ToDouble(txt_precio_venta.Text);
                    Margen = Margen * 100;
                    txt_margen.Text = Margen.ToString();
                }
            }          
        }

        private void txt_costo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) 
            {
                double Margen = 0;
                if (cls_Global.IsNumericDouble(txt_costo.Text) && cls_Global.IsNumericDouble(txt_precio_venta.Text))
                {
                    Margen = (Convert.ToDouble(txt_precio_venta.Text) - Convert.ToDouble(txt_costo.Text));
                    Margen = Margen / Convert.ToDouble(txt_precio_venta.Text);
                    Margen = Margen * 100;
                    txt_margen.Text = Margen.ToString();
                }
            }
        }
        private void txt_precio_venta_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Tab)
            {
                double Margen = 0;
                if (!cls_Global.IsNumericDouble(txt_costo.Text) && !cls_Global.IsNumericDouble(txt_precio_venta.Text))
                {
                    Margen = (Convert.ToDouble(txt_precio_venta.Text) - Convert.ToDouble(txt_costo.Text));
                    Margen = Margen / Convert.ToDouble(txt_precio_venta.Text);
                    Margen = Margen * 100;
                    txt_margen.Text = Margen.ToString();
                }
            }
        }
        private void txt_precio_venta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                double Margen = 0;
                if (cls_Global.IsNumericDouble(txt_costo.Text) && cls_Global.IsNumericDouble(txt_precio_venta.Text))
                {
                    Margen = (Convert.ToDouble(txt_precio_venta.Text) - Convert.ToDouble(txt_costo.Text));
                    Margen = Margen / Convert.ToDouble(txt_precio_venta.Text);
                    Margen = Margen * 100;
                    txt_margen.Text = Margen.ToString();
                }
            }
        }

        private void txt_margen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Tab)
            {
                double Margen = 0;
                if (cls_Global.IsNumericDouble(txt_costo.Text) && cls_Global.IsNumericDouble(txt_precio_venta.Text))
                {
                    Margen = (Convert.ToDouble(txt_precio_venta.Text) - Convert.ToDouble(txt_costo.Text));
                    Margen = Margen / Convert.ToDouble(txt_precio_venta.Text);
                    Margen = Margen * 100;
                    txt_margen.Text = Margen.ToString();
                }
            }
        }

        private void txt_margen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                double Margen = 0;
                if (cls_Global.IsNumericDouble(txt_costo.Text) && cls_Global.IsNumericDouble(txt_precio_venta.Text))
                {
                    Margen = (Convert.ToDouble(txt_precio_venta.Text) - Convert.ToDouble(txt_costo.Text));
                    Margen = Margen / Convert.ToDouble(txt_precio_venta.Text);
                    Margen = Margen * 100;
                    txt_margen.Text = Margen.ToString();
                }
            }
        }

        private void txt_precio_venta_KeyUp(object sender, KeyEventArgs e)
        {
            mtd_calcular_margen();
        }
        double vl;
        private void mtd_calcular_margen()
        {

            double Margen = 0;
            vl = 0;
            if (txt_costo.Text == "")
            {
                vl++;
                errorProvider1.SetError(txt_costo, "Falta valor costo");
            }
            if (txt_precio_venta.Text == "")
            {
                vl++;
                errorProvider1.SetError(txt_precio_venta, "Ingrese Precio venta");
            }

            if (vl == 0)
            {
                if (cls_Global.IsNumericDouble(txt_precio_venta.Text))
                {
                    Margen = (Convert.ToDouble(txt_precio_venta.Text) - Convert.ToDouble(txt_costo.Text));
                    Margen = Margen / Convert.ToDouble(txt_precio_venta.Text);
                    Margen = Margen * 100;
                    txt_margen.Text = Margen.ToString();
                }
                else
                {
                    errorProvider1.SetError(txt_precio_venta, "Ingrese valores numericos");
                }
            }
            else
            {
                txt_margen.Text = "";
            }

        }

        private void txt_costo_KeyUp(object sender, KeyEventArgs e)
        {
           
        }

        private void mtd_calcular_precio_venta()
        {
            double preVenta = 0;
            vl = 0;
            if (txt_costo.Text == "")
            {
                vl++;
                errorProvider1.SetError(txt_costo, "Falta valor costo");
            }
            if (txt_margen.Text == "")
            {
                vl++;
                errorProvider1.SetError(txt_margen, "Ingrese margen");
            }

            if (vl == 0)
            {
                if (cls_Global.IsNumericDouble(txt_margen.Text))
                {
                    if (Convert.ToDouble(txt_margen.Text) == 100)
                    {
                        double margen = Convert.ToDouble(txt_margen.Text) - 1;
                        txt_margen.Text = margen.ToString();
                    }
                    preVenta = Convert.ToDouble(txt_costo.Text) / (1 - (Convert.ToDouble(txt_margen.Text) / 100));
                    txt_precio_venta.Text = preVenta.ToString("N0");
                }
                else
                {
                    errorProvider1.SetError(txt_margen, "Ingrese valores numericos");
                }
            }
            else
            {
                txt_precio_venta.Text = "";
            }

        }

        private void txt_margen_KeyUp(object sender, KeyEventArgs e)
        {
            mtd_calcular_precio_venta();
        }

        private void cbx_tipo_item_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_tipo_item.Text == "Servicio")
            {
                txt_costo.Text = "0";
                txt_costo.Enabled = false;
                txt_margen.Enabled = false;
                txt_stock_minimo.Text = "0";
                txt_stock_minimo.Enabled = false;
                txt_stock_maximo.Text = "0";
                txt_stock_maximo.Enabled = false;
                txt_cantidad.Text = "1";
                txt_cantidad.Enabled = false;
                rd_entrada.Checked = true;
                rd_entrada.Enabled = false;
                rd_salida.Checked = false;
                rd_salida.Enabled = false;
            }
            else 
            {
                txt_costo.Text = "0";
                txt_costo.Enabled = true;
                txt_margen.Enabled = true;
                txt_stock_minimo.Text = "0";
                txt_stock_minimo.Enabled = true;
                txt_stock_maximo.Text = "0";
                txt_stock_maximo.Enabled = true;
                txt_cantidad.Text = "";
                txt_cantidad.Enabled = true;
                rd_entrada.Checked = true;
                rd_entrada.Enabled = true;
                rd_salida.Checked = false;
                rd_salida.Enabled = true;
            }
        }
    }
}
