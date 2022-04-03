using SBX_ERP.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SBX_ERP
{
    public partial class frm_Activos : Form
    {
        int v_validado = 0;
        bool v_ok;
        bool Registro = true;
        DataTable v_dt;
        DataTable v_dt_marca;
        DataTable v_dt_activos;
        DataTable v_dt_activos_exportar_excel;
        cl_activos cls_activos = new cl_activos();
        cls_global cls_Global = new cls_global();
        cl_marca cl_Marca = new cl_marca();
        int v_fila = 0;
        double TotalActivos = 0;
        public string codigoMarca { get; set; }
        public frm_Activos()
        {
            InitializeComponent();
        }

        private void frm_Activos_Load(object sender, EventArgs e)
        {
            v_dt = cls_activos.mtd_consultar_consecutivo();
            if (v_dt.Rows.Count > 0)
            {
                DataRow row = v_dt.Rows[0];
                txt_codigo.Text = row["Consecutivo"].ToString();
            }
            else
            {
                txt_codigo.Text = "1";
            }

            v_dt_marca = cl_Marca.mtd_consultar_marca();
            if (v_dt_marca.Rows.Count > 0 )
            {
                foreach (DataRow item in v_dt_marca.Rows)
                {
                    cbx_marca.Items.Add(item["cl_nombre"]);
                }
            }

            cbx_marca.SelectedIndex = 0;
            rd_entrada.Checked = true;
            rd_salida.Enabled = false;
            cls_activos.Finicial = dtp_fecha_inicio.Value;
            cls_activos.Ffinal = dtp_fecha_fin.Value;
            v_dt_activos = cls_activos.mtd_consultar_kardex_activos();
            dtg_venta.DataSource = v_dt_activos;
            Registro = true;
            buscar();
        }
        private void mtd_validar()
        {
            v_validado = 0;
            if (txt_nombre.Text == "")
            {
                errorProvider1.SetError(txt_nombre,"Ingrese Nombre");
                v_validado++;
            }
            if (txt_valor.Text == "")
            {
                errorProvider1.SetError(txt_valor, "Ingrese valor");
                v_validado++;
            }
            if (txt_cantidad.Text == "")
            {
                errorProvider1.SetError(txt_cantidad, "Ingrese Cantidad");
                v_validado++;
            }

            if (v_validado == 0)
            {
                if (!cls_Global.IsNumericDouble(txt_valor.Text))
                {
                    errorProvider1.SetError(txt_valor, "Ingrese valores numericos");
                    v_validado++;
                }
            }
            if (v_validado == 0)
            {
                if (!cls_Global.IsNumericDouble(txt_cantidad.Text))
                {
                    errorProvider1.SetError(txt_cantidad, "Ingrese valores numericos");
                    v_validado++;
                }
            }

        }
        private void Limpiar() 
        {
            txt_nombre.Text = "";
            cbx_marca.Text = "";
            txt_valor.Text = "";
            txt_nota.Text = "";
            txt_cantidad.Text = "";
            errorProvider1.Clear();
            v_dt = cls_activos.mtd_consultar_consecutivo();
            if (v_dt.Rows.Count > 0)
            {
                DataRow row = v_dt.Rows[0];
                txt_codigo.Text = row["Consecutivo"].ToString();
            }
            else
            {
                txt_codigo.Text = "1";
            }
            cbx_marca.SelectedIndex = 0;
            rd_entrada.Checked = true;
        }
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            mtd_validar();
            if (v_validado == 0)
            {
                cls_activos.cl_codigo = txt_codigo.Text;
                cls_activos.cl_nombre = txt_nombre.Text;
                foreach (DataRow item in v_dt_marca.Rows)
                {
                   
                        cls_activos.cl_marca = item["cl_codigo"].ToString();
                    
                }
                
                cls_activos.cl_valor = txt_valor.Text;
                cls_activos.cl_nota = txt_nota.Text;
                cls_activos.cl_fecha = DateTime.Now.ToString();
                if (rd_entrada.Checked)
                {
                    cls_activos.cl_movimiento = rd_entrada.Text;
                }
                else
                {
                    cls_activos.cl_movimiento = rd_salida.Text;
                }
                cls_activos.cl_cantidad = txt_cantidad.Text;

                if (Registro)
                {
                    v_ok = cls_activos.mtd_registrar();
                }
                else
                {
                    v_ok = cls_activos.mtd_editar();
                }
               
                if (v_ok)
                {
                    MessageBox.Show("Activo registrado correctamente","Correcto",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    Limpiar();
                    v_dt_activos = cls_activos.mtd_consultar_kardex_activos();
                    dtg_venta.DataSource = v_dt_activos;
                }
            }
            buscar();
        }

        private void btn_add_marca_Click(object sender, EventArgs e)
        {
            frm_marca frm_Marca = new frm_marca();
            frm_Marca.Enviainfo += new frm_marca.EnviarInfo(mtd_dato);
            frm_Marca.ShowDialog();
        }
        public void mtd_dato(string info)
        {
            cbx_marca.Items.Clear();
            v_dt_marca = cl_Marca.mtd_consultar_marca();
            if (v_dt_marca.Rows.Count > 0)
            {
                foreach (DataRow item in v_dt_marca.Rows)
                {
                    cbx_marca.Items.Add(item["cl_nombre"]);
                }
            }
            cbx_marca.SelectedIndex = 0;
        }

        private void btn_buscar_producto_Click(object sender, EventArgs e)
        {
            frm_busquedas frm_Busquedas = new frm_busquedas();
            frm_Busquedas.Modulo = 8;
            frm_Busquedas.Enviainfo += new frm_busquedas.EnviarInfo(mtd_carga_datos);
            frm_Busquedas.ShowDialog();
        }
        private void mtd_carga_datos(string vl_dato)
        {
            Registro = false;
            cls_activos.cl_codigo = vl_dato;
            v_dt = cls_activos.mtd_consultar_activos_unico();
            if (v_dt.Rows.Count > 0)
            {
                DataRow row = v_dt.Rows[0];
                txt_codigo.Text = row["cl_codigo_pk"].ToString();
                txt_nombre.Text = row["cl_nombre"].ToString();
                cl_Marca.codigo = row["cl_Marca"].ToString();

                v_dt_marca = cl_Marca.mtd_consultar_marca_unica();
                if (v_dt_marca.Rows.Count > 0)
                {
                    DataRow row2 = v_dt_marca.Rows[0];
                    cbx_marca.Text = row2["cl_nombre"].ToString();
                }
                double valor = Convert.ToDouble(row["cl_Valor"]);
                txt_valor.Text = valor.ToString("N0");              
                txt_cantidad.Text = "0";
                rd_entrada.Checked = true;
                rd_salida.Enabled = true;
                txt_nota.Text = row["cl_Nota"].ToString();
            }
        }

        private void btn_exportar_excel_Click(object sender, EventArgs e)
        {
            if (dtg_venta.Rows.Count > 0)
            {
                cls_activos.v_buscar = txt_buscar.Text;
                cls_activos.Finicial = dtp_fecha_inicio.Value;
                cls_activos.Ffinal = dtp_fecha_fin.Value;
                v_dt_activos_exportar_excel = cls_activos.mtd_consultar_kardex_activos();

                mtd_exporta_excel();
            }
            else
            {
                MessageBox.Show("No hay datos para exportar a excel", "Sin datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void mtd_exporta_excel()
        {
            frm_exportar_excel frm_Exportando_excel = new frm_exportar_excel();
            frm_Exportando_excel.Show();

            Microsoft.Office.Interop.Excel.Application Excel = new Microsoft.Office.Interop.Excel.Application();
            Excel.Application.Workbooks.Add(true);
            int IndiceColumna = 0;

            frm_Exportando_excel.mtd_progreso(20);

            foreach (DataColumn columna in v_dt_activos_exportar_excel.Columns)
            {
                IndiceColumna++;
                Excel.Cells[1, IndiceColumna] = columna.ColumnName;
            }
            frm_Exportando_excel.mtd_progreso(70);
            int IndiceFila = 0;

            foreach (DataRow Row in v_dt_activos_exportar_excel.Rows)
            {
                IndiceFila++;
                IndiceColumna = 0;

                foreach (DataColumn Columna in v_dt_activos_exportar_excel.Columns)
                {
                    IndiceColumna++;
                    if (Columna.ColumnName != "Foto")
                    {
                        Excel.Cells[IndiceFila + 1, IndiceColumna] = Row[Columna.ColumnName];
                    }
                }
            }
            frm_Exportando_excel.mtd_progreso(100);
            frm_Exportando_excel.Hide();

            Excel.Visible = true;
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            buscar();
        }

        private void buscar()
        {
            TotalActivos = 0;
            cls_activos.v_buscar = txt_buscar.Text;
            cls_activos.Finicial = dtp_fecha_inicio.Value;
            cls_activos.Ffinal = dtp_fecha_fin.Value;
            v_dt_activos = cls_activos.mtd_consultar_kardex_activos();
            foreach (DataRow item in v_dt_activos.Rows)
            {
                TotalActivos += Convert.ToDouble(item["Valor"]);
            }
            lblTotalActivos.Text = TotalActivos.ToString("N0");
            dtg_venta.DataSource = v_dt_activos;
        }
    }
}
