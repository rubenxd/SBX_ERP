using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SBX_ERP.db;

namespace SBX_ERP.model
{
    public class cls_config
    {
        //instancias
        cls_conexion cls_cn = new cls_conexion();
        cls_datos cls_datos = new cls_datos();

        //Variables
        DataTable v_dt;
        string v_query = "";
        SqlParameter[] Parametros;
        bool v_ok;
        public string tipo_busqueda_doc { get; set; }

        public DataTable mtd_consultar_Tipo_busqueda_doc()
        {
            v_query = " select * FROM tbl_configuracion ";
               
            v_dt = cls_datos.mtd_consultar(v_query);
            return v_dt;
        }
        private void mtd_asignaParametros()
        {
            Parametros = new SqlParameter[1];

            Parametros[0] = new SqlParameter();
            Parametros[0].ParameterName = "@TipoBusquedaDoc";
            Parametros[0].SqlDbType = SqlDbType.Int;
            Parametros[0].SqlValue = tipo_busqueda_doc;       
        }
        public Boolean mtd_registrar()
        {
            v_query = " INSERT INTO tbl_configuracion (TipoBusquedaDoc)" +
                      " VALUES (@TipoBusquedaDoc)";

            mtd_asignaParametros();
            v_ok = cls_datos.mtd_registrar(Parametros, v_query);         
            return v_ok;
        }
        public Boolean mtd_Editar()
        {
            v_query = " UPDATE tbl_configuracion SET TipoBusquedaDoc = @TipoBusquedaDoc ";

            mtd_asignaParametros();
            v_ok = cls_datos.mtd_editar(Parametros, v_query);
            return v_ok;
        }
        public Boolean mtd_eliminar()
        {
            v_query = "DELETE FROM tbl_configuracion ";
            v_ok = cls_datos.mtd_eliminar(v_query);
            return v_ok;
        }
    }
}
