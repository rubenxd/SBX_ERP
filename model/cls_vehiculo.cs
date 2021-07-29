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
    public class cls_vehiculo
    {
        public string cl_codigo_pk { get; set; }
        public string cl_Tercero { get; set; }
        public string cl_Vehiculo { get; set; }
        public string cl_Placa { get; set; }
        public string cl_Modelo { get; set; }
        public string cl_km { get; set; }
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
            v_query = " select "+
                    "vh.cl_codigo_pk , " +
                    "t.cl_Codigo_pk Codigo_tercero, " +
                    "t.cl_identificacion , " +
                    "t.cl_razon_social , " +
                    "vh.cl_vehiculo , " +
                    "vh.cl_placa , " +
                    "vh.cl_modelo , " +
                    "vh.cl_km , " +
                    "vh.cl_fecha_creacion , " +
                    "vh.cl_fecha_modificacion , " +
                    "vh.cl_usuario " +
                    "from tbl_vehiculo vh " +
                    "inner join tbl_tercero t on t.cl_Codigo_pk = vh.cl_tercero " +
                    " where vh.cl_codigo_pk = "+v_buscar;
            v_dt = cls_datos.mtd_consultar(v_query);
            return v_dt;
        }
        public DataTable mtd_consultar_x_placa()
        {
            v_query = " select " +
                    "vh.cl_codigo_pk , " +
                    "t.cl_Codigo_pk Codigo_tercero, " +
                    "t.cl_identificacion , " +
                    "t.cl_razon_social , " +
                    "vh.cl_vehiculo , " +
                    "vh.cl_placa , " +
                    "vh.cl_modelo , " +
                    "vh.cl_km , " +
                    "vh.cl_fecha_creacion , " +
                    "vh.cl_fecha_modificacion , " +
                    "vh.cl_usuario " +
                    "from tbl_vehiculo vh " +
                    "inner join tbl_tercero t on t.cl_Codigo_pk = vh.cl_tercero " +
                    " where vh.cl_placa = '" + v_buscar+"'";
            v_dt = cls_datos.mtd_consultar(v_query);
            return v_dt;
        }
        private void mtd_asignaParametros()
        {
            Parametros = new SqlParameter[8];

            Parametros[0] = new SqlParameter();
            Parametros[0].ParameterName = "@cl_Tercero";
            Parametros[0].SqlDbType = SqlDbType.Int;
            Parametros[0].SqlValue = cl_Tercero;

            Parametros[1] = new SqlParameter();
            Parametros[1].ParameterName = "@cl_Vehiculo";
            Parametros[1].SqlDbType = SqlDbType.VarChar;
            Parametros[1].SqlValue = cl_Vehiculo;

            Parametros[2] = new SqlParameter();
            Parametros[2].ParameterName = "@cl_Placa";
            Parametros[2].SqlDbType = SqlDbType.VarChar;
            Parametros[2].SqlValue = cl_Placa;

            Parametros[3] = new SqlParameter();
            Parametros[3].ParameterName = "@cl_Modelo";
            Parametros[3].SqlDbType = SqlDbType.VarChar;
            Parametros[3].SqlValue = cl_Modelo;

            Parametros[4] = new SqlParameter();
            Parametros[4].ParameterName = "@cl_km";
            Parametros[4].SqlDbType = SqlDbType.VarChar;
            Parametros[4].SqlValue = cl_km;

            Parametros[5] = new SqlParameter();
            Parametros[5].ParameterName = "@cl_fecha_creacion";
            Parametros[5].SqlDbType = SqlDbType.VarChar;
            Parametros[5].SqlValue = cl_fecha_creacion;

            Parametros[6] = new SqlParameter();
            Parametros[6].ParameterName = "@cl_fecha_modificacion";
            Parametros[6].SqlDbType = SqlDbType.VarChar;
            Parametros[6].SqlValue = cl_fecha_modificacion;

            Parametros[7] = new SqlParameter();
            Parametros[7].ParameterName = "@cl_usuario";
            Parametros[7].SqlDbType = SqlDbType.VarChar;
            Parametros[7].SqlValue = cl_usuario;
        }
        public Boolean mtd_Editar()
        {
            v_query = " UPDATE tbl_vehiculo SET  cl_Tercero = @cl_Tercero,cl_Vehiculo = @cl_Vehiculo,cl_Placa = @cl_Placa,  " +
                      " cl_Modelo = @cl_Modelo,cl_km = @cl_km,cl_fecha_modificacion = @cl_fecha_modificacion,cl_usuario = @cl_usuario " +
                      " WHERE cl_Placa = '" + v_buscar +"' ";

            mtd_asignaParametros();
            v_ok = cls_datos.mtd_editar(Parametros, v_query);
            return v_ok;
        }
        public Boolean mtd_registrar()
        {
            v_query = " INSERT INTO tbl_vehiculo (cl_Tercero,cl_Vehiculo,cl_Placa,cl_Modelo,cl_km,cl_fecha_creacion,cl_fecha_modificacion,cl_usuario)" +
                      " VALUES (@cl_Tercero,@cl_Vehiculo,@cl_Placa,@cl_Modelo,@cl_km,@cl_fecha_creacion,@cl_fecha_modificacion,@cl_usuario)";

            mtd_asignaParametros();
            v_ok = cls_datos.mtd_registrar(Parametros, v_query);
            return v_ok;
        }
        public DataTable mtd_consultar_ayuda()
        {
            v_query = " sp_consultar_vehiculo_ayuda '" + v_buscar + "%' ";
            v_dt = cls_datos.mtd_consultar(v_query);
            return v_dt;
        }
    }
}
