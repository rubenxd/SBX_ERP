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
    public partial class frm_reportes : Form
    {
        cls_reportes cls_Reportes = new cls_reportes();
        double ingresos = 0;
        double costos = 0;
        double gastos = 0;
        double Resultado = 0;
        double Valor = 0;
        double ValorIva = 0;
        DataTable dt;
        DataTable dtR;
        public frm_reportes()
        {
            InitializeComponent();
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            txt_costos.Text = "0";
            txt_ingresos.Text = "0";
            txt_gastos.Text = "0";
            txt_resultado.Text = "0";

            dt = new DataTable();
            cls_Reportes.Finical = dtp_fecha_inicio.Value;
            cls_Reportes.ffinal = dtp_fecha_fin.Value;
            dt = cls_Reportes.mtd_consultar();
            if (dt.Rows.Count > 0)
            {
                DataRow roww = dt.Rows[0];
                costos = Convert.ToDouble(roww["CostoTotal"]);
                ingresos = Convert.ToDouble(roww["TotalVenta"]);
                txt_costos.Text = costos.ToString("N0");
                txt_ingresos.Text = ingresos.ToString("N0");
                //consultar Gastos
                cls_gastos cls_Gastos = new cls_gastos();
                cls_Gastos.Finical = dtp_fecha_inicio.Value;
                cls_Gastos.ffinal = dtp_fecha_fin.Value;
                dtR = cls_Gastos.mtd_consultar_Gastos_report();
                if (dtR.Rows.Count > 0)
                {
                    DataRow rowR = dtR.Rows[0];
                    Valor = Convert.ToDouble(rowR["Valor"]);
                    ValorIva = Convert.ToDouble(rowR["ValorIva"]);
                    gastos = Valor + ValorIva;
                    txt_gastos.Text = gastos.ToString("N0");
                }
                else
                {
                    
                }
                dt = cls_Reportes.mtd_consultar();
                Resultado = ingresos - (costos + gastos);
                txt_resultado.Text = Resultado.ToString("N0");
            }
            else
            {
               
            }
        }
        private void frm_reportes_Load(object sender, EventArgs e)
        {
            txt_costos.Text = "0";
            txt_ingresos.Text = "0";
            txt_gastos.Text = "0";
            txt_resultado.Text = "0";
        }
    }
}
