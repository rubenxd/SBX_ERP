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
                    // Items
                    cls_item cls_Item = new cls_item();
                    cls_Item.v_buscar = txt_buscar.Text;
                    v_dt = cls_Item.mtd_consultar_ayuda();
                    dtg_ayudas.DataSource = v_dt;
                    break;
                case 6:
                    // empresa
                    cls_empresa cls_Empresa = new cls_empresa();
                    cls_Empresa.v_buscar = txt_buscar.Text;
                    v_dt = cls_Empresa.mtd_consultar_ayuda();
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
                        v_dato = dtg_ayudas[1, v_filas].Value.ToString();
                        Enviainfo(v_dato);
                        this.Dispose();
                        break;
                    //empresa
                    case 6:
                        v_dato = dtg_ayudas[1, v_filas].Value.ToString();
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

        }
    }
}
