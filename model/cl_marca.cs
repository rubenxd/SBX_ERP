using SBX_ERP.db;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBX_ERP.model
{
    class cl_marca
    {
        //instancias
        cls_conexion cls_cn = new cls_conexion();
        cls_datos cls_datos = new cls_datos();
        SqlParameter[] Parametros;
        //Variables
        DataTable v_dt;
        string v_query = "";
        bool v_ok;
        public string Nombre { get; set; }
        public string codigo { get; set; }
        public DataTable mtd_consultar_marca()
        {
            v_query = " SELECT * FROM tbl_marca ";
            v_dt = cls_datos.mtd_consultar(v_query);
            return v_dt;
        }
        public DataTable mtd_consultar_marca_unica()
        {
            v_query = " SELECT * FROM tbl_marca where cl_codigo = "+ codigo;
            v_dt = cls_datos.mtd_consultar(v_query);
            return v_dt;
        }
        private void mtd_asignaParametros()
        {
            Parametros = new SqlParameter[1];

            Parametros[0] = new SqlParameter();
            Parametros[0].ParameterName = "@cl_nombre";
            Parametros[0].SqlDbType = SqlDbType.VarChar;
            Parametros[0].SqlValue = Nombre;
        }
        public bool mtd_registrar()
        {
            v_query = " INSERT INTO tbl_marca VALUES(@cl_nombre) ";
            mtd_asignaParametros();
            v_ok = cls_datos.mtd_registrar(Parametros, v_query);
            return v_ok;
        }
    }
}
