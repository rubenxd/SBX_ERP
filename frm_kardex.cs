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
    public partial class frm_kardex : Form
    {
        public frm_kardex()
        {
            InitializeComponent();
        }
        DataTable v_dt;
        cl_kardex cl_Kardex = new cl_kardex();
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            mtd_consultar();
            this.Cursor = Cursors.Default;
        }
        private void mtd_consultar()
        {
            v_dt = cl_Kardex.mtd_consultar(txt_buscar.Text);
            dtg_kardex.DataSource = v_dt;
        }

        private void btn_exportar_excel_Click(object sender, EventArgs e)
        {
            if (dtg_kardex.Rows.Count > 0)
            {
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
