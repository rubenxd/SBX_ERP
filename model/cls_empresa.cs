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
    public class cls_empresa
    {
        public string cl_Codigo_pk { get; set; }
        public string cl_identificacion { get; set; }
        public string cl_tipo_identificacion { get; set; }
        public string cl_razon_social { get; set; }
        public string cl_tipo_persona { get; set; }
        public string cl_direccion { get; set; }
        public string cl_telefonos { get; set; }
        public string cl_Email { get; set; }
        public string cl_fecha_creacion { get; set; }
        public string cl_fecha_modificacion { get; set; }
        public string cl_usuario { get; set; }

        //instancias
        cls_conexion cls_cn = new cls_conexion();
        cls_datos cls_datos = new cls_datos();

        //Variables
        DataTable v_dt;
        string v_query = "";
        SqlParameter[] Parametros;
        bool v_ok;
        public string v_buscar { get; set; }

        //Metodos
        public DataTable mtd_consultar()
        {
            v_query = " SELECT * FROM tbl_compania WHERE cl_identificacion = '" + v_buscar + "' ";
            v_dt = cls_datos.mtd_consultar(v_query);
            return v_dt;
        }
        public DataTable mtd_consultar_x_codigo()
        {
            v_query = " SELECT * FROM tbl_compania WHERE cl_Codigo_pk = " + v_buscar + " ";
            v_dt = cls_datos.mtd_consultar(v_query);
            return v_dt;
        }
        public DataTable mtd_consultar_ayuda()
        {
            v_query = " sp_consultar_empresa_ayuda '" + v_buscar + "' ";
            v_dt = cls_datos.mtd_consultar(v_query);
            return v_dt;
        }
        public DataTable mtd_consultar_ayuda_2()
        {
            v_query = " sp_consultar_empresa_ayuda_2 '" + v_buscar + "' ";
            v_dt = cls_datos.mtd_consultar(v_query);
            return v_dt;
        }
        private void mtd_asignaParametros()
        {
            Parametros = new SqlParameter[10];

            Parametros[0] = new SqlParameter();
            Parametros[0].ParameterName = "@cl_identificacion";
            Parametros[0].SqlDbType = SqlDbType.VarChar;
            Parametros[0].SqlValue = cl_identificacion;

            Parametros[1] = new SqlParameter();
            Parametros[1].ParameterName = "@cl_tipo_identificacion";
            Parametros[1].SqlDbType = SqlDbType.Int;
            Parametros[1].SqlValue = cl_tipo_identificacion;

            Parametros[2] = new SqlParameter();
            Parametros[2].ParameterName = "@cl_razon_social";
            Parametros[2].SqlDbType = SqlDbType.VarChar;
            Parametros[2].SqlValue = cl_razon_social;

            Parametros[3] = new SqlParameter();
            Parametros[3].ParameterName = "@cl_tipo_persona";
            Parametros[3].SqlDbType = SqlDbType.Int;
            Parametros[3].SqlValue = cl_tipo_persona;

            Parametros[4] = new SqlParameter();
            Parametros[4].ParameterName = "@cl_direccion";
            Parametros[4].SqlDbType = SqlDbType.VarChar;
            Parametros[4].SqlValue = cl_direccion;

            Parametros[5] = new SqlParameter();
            Parametros[5].ParameterName = "@cl_telefonos";
            Parametros[5].SqlDbType = SqlDbType.VarChar;
            Parametros[5].SqlValue = cl_telefonos;

            Parametros[6] = new SqlParameter();
            Parametros[6].ParameterName = "@cl_Email";
            Parametros[6].SqlDbType = SqlDbType.VarChar;
            Parametros[6].SqlValue = cl_Email;

            Parametros[7] = new SqlParameter();
            Parametros[7].ParameterName = "@cl_fecha_creacion";
            Parametros[7].SqlDbType = SqlDbType.VarChar;
            Parametros[7].SqlValue = cl_fecha_creacion;

            Parametros[8] = new SqlParameter();
            Parametros[8].ParameterName = "@cl_fecha_modificacion";
            Parametros[8].SqlDbType = SqlDbType.VarChar;
            Parametros[8].SqlValue = cl_fecha_modificacion;

            Parametros[9] = new SqlParameter();
            Parametros[9].ParameterName = "@cl_usuario";
            Parametros[9].SqlDbType = SqlDbType.VarChar;
            Parametros[9].SqlValue = cl_usuario;
        }
        public Boolean mtd_registrar()
        {
            v_query = " INSERT INTO tbl_compania (cl_identificacion,cl_tipo_identificacion,cl_razon_social,cl_tipo_persona,cl_direccion,cl_telefonos,cl_Email,cl_fecha_creacion,cl_fecha_modificacion,cl_usuario)" +
                      " VALUES (@cl_identificacion,@cl_tipo_identificacion,@cl_razon_social,@cl_tipo_persona,@cl_direccion,@cl_telefonos,@cl_Email,@cl_fecha_creacion,@cl_fecha_modificacion,@cl_usuario)";

            mtd_asignaParametros();
            v_ok = cls_datos.mtd_registrar(Parametros, v_query);
            return v_ok;
        }
        public Boolean mtd_Editar()
        {
            v_query = " UPDATE tbl_compania SET  cl_identificacion = @cl_identificacion,cl_tipo_identificacion = @cl_tipo_identificacion,cl_razon_social = @cl_razon_social,  " +
                      " cl_telefonos = @cl_telefonos,cl_Email = @cl_Email,cl_fecha_modificacion = @cl_fecha_modificacion,cl_usuario = @cl_usuario " +
                      " WHERE cl_identificacion = " + v_buscar;

            mtd_asignaParametros();
            v_ok = cls_datos.mtd_editar(Parametros, v_query);
            return v_ok;
        }
        public Boolean mtd_eliminar()
        {
            v_query = "DELETE FROM tbl_compania WHERE cl_identificacion = " + v_buscar;
            v_ok = cls_datos.mtd_eliminar(v_query);
            return v_ok;
        }
    }
}
