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
    class cl_activos
    {
        //instancias
        cls_conexion cls_cn = new cls_conexion();
        cls_datos cls_datos = new cls_datos();
        string v_query = "";
        DataTable v_dt = new DataTable();
        SqlParameter[] Parametros;
        bool v_ok;
        public string cl_codigo { get; set; }
        public string cl_nombre { get; set; }
        public string cl_marca { get; set; }
        public string cl_valor { get; set; }
        public string cl_nota { get; set; }
        public string cl_fecha { get; set; }
        public string cl_movimiento { get; set; }
        public string cl_cantidad { get; set; }

        public DateTime Finicial { get; set; }
        public DateTime Ffinal { get; set; }
        public string v_buscar { get; set; }
        public DataTable mtd_consultar_consecutivo()
        {
            v_query = " select isnull(max(convert(int,cl_codigo_pk)),0) + 1  Consecutivo from tbl_activos ";
            v_dt = cls_datos.mtd_consultar(v_query);
            return v_dt;
        }

        private void mtd_asignaParametros()
        {
            Parametros = new SqlParameter[6];

            Parametros[0] = new SqlParameter();
            Parametros[0].ParameterName = "@cl_codigo";
            Parametros[0].SqlDbType = SqlDbType.Int;
            Parametros[0].SqlValue = cl_codigo;

            Parametros[1] = new SqlParameter();
            Parametros[1].ParameterName = "@cl_nombre";
            Parametros[1].SqlDbType = SqlDbType.VarChar;
            Parametros[1].SqlValue = cl_nombre;

            Parametros[2] = new SqlParameter();
            Parametros[2].ParameterName = "@cl_marca";
            Parametros[2].SqlDbType = SqlDbType.Int;
            Parametros[2].SqlValue = cl_marca;

            Parametros[3] = new SqlParameter();
            Parametros[3].ParameterName = "@cl_valor";
            Parametros[3].SqlDbType = SqlDbType.Money;
            Parametros[3].SqlValue = cl_valor;

            Parametros[4] = new SqlParameter();
            Parametros[4].ParameterName = "@cl_nota";
            Parametros[4].SqlDbType = SqlDbType.VarChar;
            Parametros[4].SqlValue = cl_nota;

            Parametros[5] = new SqlParameter();
            Parametros[5].ParameterName = "@cl_fecha";
            Parametros[5].SqlDbType = SqlDbType.DateTime;
            Parametros[5].SqlValue = cl_fecha;

        }
        public Boolean mtd_registrar()
        {
            v_query = " INSERT INTO tbl_activos (cl_codigo_pk,cl_nombre,cl_Marca,cl_valor,cl_nota,cl_fecha_registro)" +
                      " VALUES (@cl_codigo,@cl_nombre,@cl_marca,@cl_valor,@cl_nota,@cl_fecha)";

            mtd_asignaParametros();
            v_ok = cls_datos.mtd_registrar(Parametros, v_query);
            if (v_ok)
            {
                mtd_registrar_kardex();
            }
            return v_ok;
        }
        public Boolean mtd_editar()
        {
            v_query = " UPDATE  tbl_activos SET cl_nombre = @cl_nombre,cl_Marca = @cl_marca,cl_valor = @cl_valor,cl_nota = @cl_nota,cl_fecha_registro = @cl_fecha where cl_codigo_pk = @cl_codigo";

            mtd_asignaParametros(); 
            v_ok = cls_datos.mtd_registrar(Parametros, v_query);
            if (v_ok)
            {
                mtd_registrar_kardex();
            }
            return v_ok;
        }
        private void mtd_asignaParametros_kardex()
        {
            Parametros = new SqlParameter[9];

            Parametros[0] = new SqlParameter();
            Parametros[0].ParameterName = "@cl_codigo_pk";
            Parametros[0].SqlDbType = SqlDbType.Int;
            Parametros[0].SqlValue = cl_codigo;

            Parametros[1] = new SqlParameter();
            Parametros[1].ParameterName = "@cl_activos";
            Parametros[1].SqlDbType = SqlDbType.Int;
            Parametros[1].SqlValue = cl_codigo;

            Parametros[2] = new SqlParameter();
            Parametros[2].ParameterName = "@cl_nombre";
            Parametros[2].SqlDbType = SqlDbType.VarChar;
            Parametros[2].SqlValue = cl_nombre;

            Parametros[3] = new SqlParameter();
            Parametros[3].ParameterName = "@cl_Marca";
            Parametros[3].SqlDbType = SqlDbType.Int;
            Parametros[3].SqlValue = cl_marca;

            Parametros[4] = new SqlParameter();
            Parametros[4].ParameterName = "@cl_Valor";
            Parametros[4].SqlDbType = SqlDbType.Money;
            Parametros[4].SqlValue = cl_valor;

            Parametros[5] = new SqlParameter();
            Parametros[5].ParameterName = "@cl_cantidad";
            Parametros[5].SqlDbType = SqlDbType.Int;
            Parametros[5].SqlValue = cl_cantidad;

            Parametros[6] = new SqlParameter();
            Parametros[6].ParameterName = "@cl_Nota";
            Parametros[6].SqlDbType = SqlDbType.VarChar;
            Parametros[6].SqlValue = cl_nota;

            Parametros[7] = new SqlParameter();
            Parametros[7].ParameterName = "@cl_fecha_registro";
            Parametros[7].SqlDbType = SqlDbType.DateTime;
            Parametros[7].SqlValue = cl_fecha;

            Parametros[8] = new SqlParameter();
            Parametros[8].ParameterName = "@cl_movimiento";
            Parametros[8].SqlDbType = SqlDbType.VarChar;
            Parametros[8].SqlValue = cl_movimiento;
        }
        public Boolean mtd_registrar_kardex()
        {           
            v_query = " INSERT INTO tbl_kardex_activos (cl_activos,cl_nombre,cl_Marca,cl_Valor,cl_cantidad,cl_Nota,cl_fecha_registro,cl_movimiento)" +
                      " VALUES (@cl_activos,@cl_nombre,@cl_Marca,@cl_Valor,@cl_cantidad,@cl_Nota,@cl_fecha_registro,@cl_movimiento)";

            mtd_asignaParametros_kardex();
            v_ok = cls_datos.mtd_registrar(Parametros, v_query);
            return v_ok;
        }

        public DataTable mtd_consultar_kardex_activos()
        {
            v_query = "  select ka.cl_activos Activo, ka.cl_nombre Nombre, m.cl_nombre Marca, ka.cl_cantidad Cantidad, FORMAT(ka.cl_Valor,'N0') Valor, ka.cl_Nota Nota, ka.cl_fecha_registro FechaRegistro, ka.cl_movimiento Movimiento from tbl_kardex_activos ka inner join tbl_marca m on m.cl_codigo = ka.cl_Marca  " +
                " where ka.cl_nombre like '" + v_buscar + "%' " +
                "and (CONVERT(date,ka.cl_fecha_registro) BETWEEN '" + Finicial.ToString("yyyyMMdd") + "' " +
                "AND '" + Ffinal.ToString("yyyyMMdd") + "')  ORDER BY (CONVERT(date,ka.cl_fecha_registro)) DESC ";
            v_dt = cls_datos.mtd_consultar(v_query);
            return v_dt;
        }

        public DataTable mtd_consultar_activos()
        {
            v_query = " select * from tbl_activos ";
            v_dt = cls_datos.mtd_consultar(v_query);
            return v_dt;
        }
        public DataTable mtd_consultar_activos_unico()
        {
            v_query = " select * from tbl_activos where cl_codigo_pk = "+cl_codigo;
            v_dt = cls_datos.mtd_consultar(v_query);
            return v_dt;
        }

    }
}
