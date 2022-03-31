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
    public partial class frm_gastos : Form
    {
        DataTable v_dt;
        double TotalGastos = 0;
        double TotalIva = 0;
        cls_gastos_m cl_gm = new cls_gastos_m();
        public string Codigo { get; set; }
        int Fila = 0;
        int Contador = 0;
        bool v_confirmacion;
        public frm_gastos()
        {
            InitializeComponent();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            mtd_consultar();
            this.Cursor = Cursors.Default;
        }
        private void mtd_consultar()
        {
            cl_gm.Buscar = txt_buscar.Text;
            cl_gm.FechaIni = dtp_fecha_inicio.Value;
            cl_gm.Fechafin = dtp_fecha_fin.Value;
            cl_gm.usuario = this.Codigo;
            v_dt = cl_gm.mtd_consultar_gastos();
            TotalGastos = 0;
            TotalIva = 0;
            dtg_gastos.Rows.Clear();
            if (v_dt.Rows.Count > 0)
            {
                Fila = v_dt.Rows.Count;
                dtg_gastos.Rows.Add(Fila);
                Contador = 0;

                foreach (DataRow rows in v_dt.Rows)
                {
                    dtg_gastos.Rows[Contador].Cells["cl_id_gasto"].Value = rows["Codigo"];
                    dtg_gastos.Rows[Contador].Cells["cl_fecha"].Value = rows["FechaRegistro"];
                    dtg_gastos.Rows[Contador].Cells["cl_desc_gasto"].Value = rows["Gasto"];
                    double Valores = Convert.ToDouble(rows["Valor"]);
                    TotalGastos += Valores;
                    dtg_gastos.Rows[Contador].Cells["cl_valor"].Value = Valores.ToString("N0");
                    dtg_gastos.Rows[Contador].Cells["cl_proveedor"].Value = rows["Descripcion"];
                    double ValoresIVA = Convert.ToDouble(rows["ValorIva"]);
                    TotalIva += ValoresIVA;
                    dtg_gastos.Rows[Contador].Cells["cl_valor_iva"].Value = ValoresIVA.ToString("N0");
                    Contador++;
                }
            }

            txt_total.Text = TotalGastos.ToString("N0");
            txt_total_iva.Text = TotalIva.ToString("N0");
            double total = TotalGastos + TotalIva;
            txt_valorMasIVA.Text = total.ToString("N0");
        }

        private void btn_exportar_excel_Click(object sender, EventArgs e)
        {
            cl_gm.Buscar = txt_buscar.Text;
            cl_gm.FechaIni = dtp_fecha_inicio.Value;
            cl_gm.Fechafin = dtp_fecha_fin.Value;
            v_dt = cl_gm.mtd_consultar_gastos();
            mtd_exporta_excel();
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
                    Excel.Cells[IndiceFila + 1, IndiceColumna] = Row[Columna.ColumnName];

                }
            }
            frm_Exportando_excel.mtd_progreso(100);
            frm_Exportando_excel.Hide();

            Excel.Visible = true;
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            cls_gastos_m gm = new cls_gastos_m();
            int v_contador;
            int Eliminados;
            int Error;
            bool v_ok;
            frm_confirmacion frm_Confirmacion = new frm_confirmacion();
            if (dtg_gastos.Rows.Count > 0)
            {
                if (dtg_gastos.SelectedRows.Count > 0)
                {
                    frm_Confirmacion.Confirma += new frm_confirmacion.Confirmacion(mtd_confirmacion);
                    v_contador = dtg_gastos.SelectedRows.Count;
                    frm_Confirmacion.txt_mensaje.Text = "¿Está seguro de que desea Eliminar " + v_contador + "  Gastos?";
                    frm_Confirmacion.ShowDialog();
                    if (v_confirmacion == true)
                    {
                        Eliminados = 0;
                        Error = 0;
                        foreach (DataGridViewRow rows in dtg_gastos.SelectedRows)
                        {
                            int Gastosm = Convert.ToInt32(rows.Cells["cl_id_gasto"].Value);
                            gm.Codigo = Gastosm;
                            v_ok = gm.mtd_eliminar();
                            if (v_ok)
                            {
                                Eliminados++;
                            }
                            else
                            {
                                Error++;
                            }
                        }
                        mtd_consultar();
                    }
                }
            }
            gm.Codigo = 0;
        }
        private void mtd_confirmacion(bool confirma)
        {
            v_confirmacion = confirma;
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            frm_agregar_consecto_gasto frm_a_gasto = new frm_agregar_consecto_gasto();
            frm_a_gasto.ShowDialog();
        }

        private void btn_agregar_gastos_Click(object sender, EventArgs e)
        {
           
            
                frm_agregar_gasto Frm_Agregar_gasto = new frm_agregar_gasto();
                Frm_Agregar_gasto.usuario = this.Codigo;
                Frm_Agregar_gasto.ShowDialog();
                mtd_consultar();
            
        }
    }
}
