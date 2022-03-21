using SBX_ERP.model;
using System;
using System.Data;
using System.Windows.Forms;

namespace SBX_ERP
{
    public partial class frm_busquedas : Form
    {
        DataTable v_dt;
        int v_filas = 0;
        string v_dato = "";
        string v_dato_tipo_item = "";
        double v_total_costos = 0;
        double v_total_precioVenta = 0;
        double costo = 0;
        double PrecioVenta = 0;
        public int Modulo { get; set; }

        //Delegado
        public delegate void EnviarInfo(string dato);
        public event EnviarInfo Enviainfo;
        public frm_busquedas()
        {
            InitializeComponent();
        }
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            switch (Modulo)
            {
                case 1:
                    // Terceros
                    cls_terceros cls_Terceros = new cls_terceros();
                    cls_Terceros.v_buscar = txt_buscar.Text;
                    v_dt = cls_Terceros.mtd_consultar_ayuda();
                    dtg_ayudas.DataSource = v_dt;
                    break;
                case 2:
                    // vehiculos
                    cls_vehiculo cls_Vehiculo = new cls_vehiculo();
                    cls_Vehiculo.v_buscar = txt_buscar.Text;
                    v_dt = cls_Vehiculo.mtd_consultar_ayuda();
                    dtg_ayudas.DataSource = v_dt;
                    break;
                case 3:
                    // Terceros desde vehiculo
                    cls_terceros cls_Terceros_2 = new cls_terceros();
                    cls_Terceros_2.v_buscar = txt_buscar.Text;
                    v_dt = cls_Terceros_2.mtd_consultar_ayuda();
                    dtg_ayudas.DataSource = v_dt;
                    break;
                case 4:
                    // Terceros y sus vehiculos
                    cls_terceros cls_Terceros_3 = new cls_terceros();
                    cls_Terceros_3.v_buscar = txt_buscar.Text;
                    v_dt = cls_Terceros_3.mtd_consultar_ayuda_2();
                    dtg_ayudas.DataSource = v_dt;
                    break;
                case 5:
                    v_total_costos = 0;
                    v_total_precioVenta = 0;
                    // Items
                    cls_item cls_Item = new cls_item();
                    cls_Item.v_buscar = txt_buscar.Text;
                    if (cbxTipoItem.Text == "Todos")
                    {
                        cls_Item.v_Tipo_Item = "";
                    }
                    else
                    {
                        cls_Item.v_Tipo_Item = cbxTipoItem.Text;
                    }                  
                    v_dt = cls_Item.mtd_consultar_ayuda();

                    foreach (DataRow item in v_dt.Rows)
                    {
                        costo = Convert.ToDouble(item["Costo"]);
                        PrecioVenta = Convert.ToDouble(item["cl_precioVenta"]);
                        item["Costo"] = costo.ToString("N");
                        item["cl_precioVenta"] = PrecioVenta.ToString("N");
                    }
                    dtg_ayudas.DataSource = v_dt;
                    foreach (DataRow item in v_dt.Rows)
                    {
                        if (item["Tipo item"].ToString() == "Producto")
                        {
                            v_total_costos += Convert.ToDouble(item["Costo"]) * Convert.ToDouble(item["Stock"]);
                            v_total_precioVenta += Convert.ToDouble(item["cl_precioVenta"]) * Convert.ToDouble(item["Stock"]);
                        }
                      
                    }
                    txt_costos.Text = v_total_costos.ToString("N0");
                    txt_precioVenta.Text = v_total_precioVenta.ToString("N0");
                    break;
                case 6:
                    // empresa
                    cls_empresa cls_Empresa = new cls_empresa();
                    cls_Empresa.v_buscar = txt_buscar.Text;
                    v_dt = cls_Empresa.mtd_consultar_ayuda();
                    dtg_ayudas.DataSource = v_dt;
                    break;
                case 7:
                    v_total_costos = 0;
                    v_total_precioVenta = 0;
                    // Items
                    cls_item cls_Itemc = new cls_item();
                    cls_Itemc.v_buscar = txt_buscar.Text;
                    if (cbxTipoItem.Text == "Todos")
                    {
                        cls_Itemc.v_Tipo_Item = "";
                    }
                    else
                    {
                        cls_Itemc.v_Tipo_Item = cbxTipoItem.Text;
                    }
                    v_dt = cls_Itemc.mtd_consultar_ayuda();
                   
                    //foreach (DataRow item in v_dt.Rows)
                    //{
                    //    costo = Convert.ToDouble(item["Costo"]);
                    //    PrecioVenta = Convert.ToDouble(item["cl_precioVenta"]);
                    //    item["Costo"] = costo.ToString("N");
                    //    item["cl_precioVenta"] = PrecioVenta.ToString("N");
                    //}
                    dtg_ayudas.DataSource = v_dt;
                    foreach (DataRow item in v_dt.Rows)
                    {
                        if (item["Tipo item"].ToString() == "Producto")
                        {
                            v_total_costos += Convert.ToDouble(item["Costo"]) * Convert.ToDouble(item["Stock"]);
                            v_total_precioVenta += Convert.ToDouble(item["cl_precioVenta"]) * Convert.ToDouble(item["Stock"]);
                        }
                       
                    }
                    txt_costos.Text = v_total_costos.ToString("N0");
                    txt_precioVenta.Text = v_total_precioVenta.ToString("N0");
                    break;
                case 8:
                    cl_activos cl_Activos = new cl_activos();
                    v_dt = cl_Activos.mtd_consultar_activos();
                    dtg_ayudas.DataSource = v_dt;
                    break;
                default:
                    break;
            }     
        }
        private void dtg_ayudas_DoubleClick(object sender, EventArgs e)
        {
            if (dtg_ayudas.Rows.Count > 0)
            {
                v_filas = dtg_ayudas.CurrentRow.Index;
                switch (Modulo)
                {
                    //terceros
                    case 1:
                        v_dato = dtg_ayudas[1, v_filas].Value.ToString();
                        Enviainfo(v_dato);
                        this.Dispose();
                        break;
                    //Vehiculos
                    case 2:
                        v_dato = dtg_ayudas[0, v_filas].Value.ToString();
                        Enviainfo(v_dato);
                        this.Dispose();
                        break;
                    //Tercero desde vehiculo
                    case 3:
                        v_dato = dtg_ayudas[0, v_filas].Value.ToString();
                        Enviainfo(v_dato);
                        this.Dispose();
                        break;
                    //items
                    case 5:
                        //Validar Stock
                        v_dato = dtg_ayudas[3, v_filas].Value.ToString();
                        v_dato_tipo_item = dtg_ayudas[8, v_filas].Value.ToString();
                        if (v_dato_tipo_item == "Producto")
                        {
                            if (Convert.ToInt32(v_dato) > 0)
                            {
                                v_dato = dtg_ayudas[1, v_filas].Value.ToString();
                                Enviainfo(v_dato);
                                this.Dispose();
                            }
                            else
                            {
                                MessageBox.Show("Item sin existencias", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            v_dato = dtg_ayudas[1, v_filas].Value.ToString();
                            Enviainfo(v_dato);
                            this.Dispose();
                        }
                                      
                        break;
                    //empresa
                    case 6:
                        v_dato = dtg_ayudas[1, v_filas].Value.ToString();
                        Enviainfo(v_dato);
                        this.Dispose();
                        break;
                    case 7:
                        v_dato = dtg_ayudas[1, v_filas].Value.ToString();
                        Enviainfo(v_dato);
                        this.Dispose();
                        break;
                    case 8:
                        v_dato = dtg_ayudas[0, v_filas].Value.ToString();
                        Enviainfo(v_dato);
                        this.Dispose();
                        break;
                }
            }
        }

        private void txt_buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.Cursor = Cursors.WaitCursor;
                switch (Modulo)
                {
                    case 1:
                        // Terceros
                        cls_terceros cls_Terceros = new cls_terceros();
                        cls_Terceros.v_buscar = txt_buscar.Text;
                        v_dt = cls_Terceros.mtd_consultar_ayuda();
                        dtg_ayudas.DataSource = v_dt;
                        break;
                    default:
                        break;
                }
                this.Cursor = Cursors.Default;
            }
        }

        private void txt_buscar_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Tab)
            {
                this.Cursor = Cursors.WaitCursor;
                switch (Modulo)
                {
                    case 1:
                        // Terceros
                        cls_terceros cls_Terceros = new cls_terceros();
                        cls_Terceros.v_buscar = txt_buscar.Text;
                        v_dt = cls_Terceros.mtd_consultar_ayuda();
                        dtg_ayudas.DataSource = v_dt;
                        break;
                    default:
                        break;
                }
                this.Cursor = Cursors.Default;
            }
        }

        private void frm_busquedas_Load(object sender, EventArgs e)
        {
            cbxTipoItem.SelectedIndex = 0;
        }

        private void btn_exportar_excel_Click(object sender, EventArgs e)
        {
            if (dtg_ayudas.Rows.Count > 0)
            {
                cls_item cls_Item = new cls_item();
                cls_Item.v_buscar = txt_buscar.Text;
                if (cbxTipoItem.Text == "Todos")
                {
                    cls_Item.v_Tipo_Item = "";
                }
                else
                {
                    cls_Item.v_Tipo_Item = cbxTipoItem.Text;
                }
                v_dt = cls_Item.mtd_consultar_ayuda();

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

            foreach (DataColumn columna in v_dt.Columns)
            {
                IndiceColumna++;
                Excel.Cells[1, IndiceColumna] = columna.ColumnName;
            }
            frm_Exportando_excel.mtd_progreso(70);
            int IndiceFila = 0;

            foreach (DataRow Row in v_dt.Rows)
            {
                IndiceFila++;
                IndiceColumna = 0;

                foreach (DataColumn Columna in v_dt.Columns)
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
    }
}
