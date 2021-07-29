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
    public class cls_item
    {
        public int cl_codigo_pk { get; set; }
        public string cl_item { get; set; }
        public string cl_nombre { get; set; }
        public string cl_descripcion { get; set; }
        public string cl_referencia { get; set; }
        public string cl_codigo_barras { get; set; }
        public string cl_estado { get; set; }
        public string cl_tipo_item { get; set; }
        public string cl_costo { get; set; }
        public string cl_PrecioVenta { get; set; }
        public string cl_cantidad { get; set; }
        public string cl_stock_minimo { get; set; }
        public string cl_stock_maximo { get; set; }
        public string cl_fecha_creacion { get; set; }
        public string cl_fecha_modificacion { get; set; }
        public string cl_usuario { get; set; }
        public string cl_movimiento { get; set; }

        //Kardex
        public string cl_Accion { get; set; }
        public string cl_codigo_item { get; set; }
        //instancias
        cls_conexion cls_cn = new cls_conexion();
        cls_datos cls_datos = new cls_datos();

        //Variables
        DataTable v_dt;
        string v_query = "";
        SqlParameter[] Parametros;
        bool v_ok;
        public string v_buscar { get; set; }

        private void mtd_asignaParametros()
        {
            Parametros = new SqlParameter[14];

            Parametros[0] = new SqlParameter();
            Parametros[0].ParameterName = "@cl_item";
            Parametros[0].SqlDbType = SqlDbType.VarChar;
            Parametros[0].SqlValue = cl_item;

            Parametros[1] = new SqlParameter();
            Parametros[1].ParameterName = "@cl_nombre";
            Parametros[1].SqlDbType = SqlDbType.VarChar;
            Parametros[1].SqlValue = cl_nombre;

            Parametros[2] = new SqlParameter();
            Parametros[2].ParameterName = "@cl_descripcion";
            Parametros[2].SqlDbType = SqlDbType.VarChar;
            Parametros[2].SqlValue = cl_descripcion;

            Parametros[3] = new SqlParameter();
            Parametros[3].ParameterName = "@cl_referencia";
            Parametros[3].SqlDbType = SqlDbType.VarChar;
            Parametros[3].SqlValue = cl_referencia;

            Parametros[4] = new SqlParameter();
            Parametros[4].ParameterName = "@cl_codigo_barras";
            Parametros[4].SqlDbType = SqlDbType.VarChar;
            Parametros[4].SqlValue = cl_codigo_barras;

            Parametros[5] = new SqlParameter();
            Parametros[5].ParameterName = "@cl_estado";
            Parametros[5].SqlDbType = SqlDbType.VarChar;
            Parametros[5].SqlValue = cl_estado;

            Parametros[6] = new SqlParameter();
            Parametros[6].ParameterName = "@cl_tipo_item";
            Parametros[6].SqlDbType = SqlDbType.VarChar;
            Parametros[6].SqlValue = cl_tipo_item;

            Parametros[7] = new SqlParameter();
            Parametros[7].ParameterName = "@cl_costo";
            Parametros[7].SqlDbType = SqlDbType.Money;
            Parametros[7].SqlValue = cl_costo;

            Parametros[8] = new SqlParameter();
            Parametros[8].ParameterName = "@cl_PrecioVenta";
            Parametros[8].SqlDbType = SqlDbType.Money;
            Parametros[8].SqlValue = cl_PrecioVenta;

            Parametros[9] = new SqlParameter();
            Parametros[9].ParameterName = "@cl_stock_minimo";
            Parametros[9].SqlDbType = SqlDbType.Float;
            Parametros[9].SqlValue = cl_stock_minimo;

            Parametros[10] = new SqlParameter();
            Parametros[10].ParameterName = "@cl_stock_maximo";
            Parametros[10].SqlDbType = SqlDbType.Float;
            Parametros[10].SqlValue = cl_stock_maximo;

            Parametros[11] = new SqlParameter();
            Parametros[11].ParameterName = "@cl_fecha_creacion";
            Parametros[11].SqlDbType = SqlDbType.DateTime;
            Parametros[11].SqlValue = cl_fecha_creacion;

            Parametros[12] = new SqlParameter();
            Parametros[12].ParameterName = "@cl_fecha_modificacion";
            Parametros[12].SqlDbType = SqlDbType.DateTime;
            Parametros[12].SqlValue = cl_fecha_modificacion;

            Parametros[13] = new SqlParameter();
            Parametros[13].ParameterName = "@cl_usuario";
            Parametros[13].SqlDbType = SqlDbType.Int;
            Parametros[13].SqlValue = cl_usuario;
        }
        private void mtd_asignaParametros_kardex()
        {
            Parametros = new SqlParameter[8];

            Parametros[0] = new SqlParameter();
            Parametros[0].ParameterName = "@cl_item";
            Parametros[0].SqlDbType = SqlDbType.VarChar;
            Parametros[0].SqlValue = cl_codigo_item;

            Parametros[1] = new SqlParameter();
            Parametros[1].ParameterName = "@cl_costo";
            Parametros[1].SqlDbType = SqlDbType.Money;
            Parametros[1].SqlValue = cl_costo;

            Parametros[2] = new SqlParameter();
            Parametros[2].ParameterName = "@cl_PrecioVenta";
            Parametros[2].SqlDbType = SqlDbType.Money;
            Parametros[2].SqlValue = cl_PrecioVenta;

            Parametros[3] = new SqlParameter();
            Parametros[3].ParameterName = "@cl_cantidad";
            Parametros[3].SqlDbType = SqlDbType.Float;
            Parametros[3].SqlValue = cl_cantidad;

            Parametros[4] = new SqlParameter();
            Parametros[4].ParameterName = "@cl_Accion";
            Parametros[4].SqlDbType = SqlDbType.VarChar;
            Parametros[4].SqlValue = cl_Accion;

            Parametros[5] = new SqlParameter();
            Parametros[5].ParameterName = "@cl_Movimiento";
            Parametros[5].SqlDbType = SqlDbType.VarChar;
            Parametros[5].SqlValue = cl_movimiento;

            Parametros[6] = new SqlParameter();
            Parametros[6].ParameterName = "@cl_fecha_registro";
            Parametros[6].SqlDbType = SqlDbType.DateTime;
            Parametros[6].SqlValue = cl_fecha_creacion;

            Parametros[7] = new SqlParameter();
            Parametros[7].ParameterName = "@cl_usuario";
            Parametros[7].SqlDbType = SqlDbType.Int;
            Parametros[7].SqlValue = cl_usuario;
        }
        public Boolean mtd_registrar()
        {
            v_query = " INSERT INTO tbl_items (cl_item,cl_nombre,cl_descripcion,cl_referencia,cl_codigo_barras,cl_estado,cl_tipo_item,cl_costo,cl_PrecioVenta,cl_stock_minimo,cl_stock_maximo,cl_fecha_creacion,cl_fecha_modificacion,cl_usuario)" +
                      " VALUES (@cl_item,@cl_nombre,@cl_descripcion,@cl_referencia,@cl_codigo_barras,@cl_estado,@cl_tipo_item,@cl_costo,@cl_PrecioVenta,@cl_stock_minimo,@cl_stock_maximo,@cl_fecha_creacion,@cl_fecha_modificacion,@cl_usuario)";

            mtd_asignaParametros();
            v_ok = cls_datos.mtd_registrar(Parametros, v_query);
            if (v_ok)
            {
                mtd_registrar_kardex();
            }
            return v_ok;
        }
        public Boolean mtd_registrar_kardex()
        {
            v_query = " SELECT cl_codigo_pk FROM tbl_items "+
                      " where cl_fecha_modificacion = (SELECT MAX(cl_fecha_modificacion) FROM tbl_items) ";
            v_dt = cls_datos.mtd_consultar(v_query);
            if (v_dt.Rows.Count > 0)
            {
                DataRow rows = v_dt.Rows[0];
                cl_codigo_item = rows["cl_codigo_pk"].ToString();
            }

            v_query = " INSERT INTO tbl_kardex (cl_item,cl_costo,cl_PrecioVenta,cl_cantidad,cl_Accion,cl_Movimiento,cl_fecha_registro,cl_usuario)" +
                      " VALUES (@cl_item,@cl_costo,@cl_PrecioVenta,@cl_cantidad,@cl_Accion,@cl_Movimiento,@cl_fecha_registro,@cl_usuario)";

            mtd_asignaParametros_kardex();
            v_ok = cls_datos.mtd_registrar(Parametros, v_query);
            return v_ok;
        }
        public Boolean mtd_Editar()
        {
            v_query = " UPDATE tbl_items SET  cl_item = @cl_item,cl_nombre = @cl_nombre,cl_descripcion = @cl_descripcion,  " +
                      " cl_referencia = @cl_referencia,cl_codigo_barras = @cl_codigo_barras,cl_estado = @cl_estado,cl_tipo_item = @cl_tipo_item, " +
                      " cl_costo = @cl_costo, cl_PrecioVenta = @cl_PrecioVenta, cl_stock_minimo = @cl_stock_minimo, cl_stock_maximo = @cl_stock_maximo," +
                      " cl_fecha_modificacion = @cl_fecha_modificacion, cl_usuario = @cl_usuario " +
                      " WHERE cl_item = '" + v_buscar+"'";

            mtd_asignaParametros();
            v_ok = cls_datos.mtd_editar(Parametros, v_query);
            if (v_ok)
            {
                mtd_registrar_kardex();
            }
            return v_ok;
        }
        public DataTable mtd_consultar()
        {
            v_query = " SELECT * FROM tbl_items WHERE cl_item = '" + v_buscar + "' ";
            v_dt = cls_datos.mtd_consultar(v_query);
            return v_dt;
        }
        public DataTable mtd_consultar_ayuda()
        {
            v_query = " sp_consultar_items_ayuda '" + v_buscar + "' ";
            v_dt = cls_datos.mtd_consultar(v_query);
            return v_dt;
        }
        public DataTable mtd_consultar_consecutivo()
        {
            v_query = " select isnull(max(convert(int,cl_item)),0) + 1  Consecutivo from tbl_items ";
            v_dt = cls_datos.mtd_consultar(v_query);
            return v_dt;
        }
    }
}
