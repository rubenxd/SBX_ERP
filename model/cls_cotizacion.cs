using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SBX_ERP.model;
using SBX_ERP.db;
using System.Data;
using System.Data.SqlClient;

namespace SBX_ERP.model
{
    public class cls_cotizacion
    {
        //instancias
        cls_conexion cls_cn = new cls_conexion();
        cls_datos cls_datos = new cls_datos();

        //Variables
        DataTable v_dt;
        string v_query = "";
        SqlParameter[] Parametros;
        bool v_ok;

        //
        public int cl_codigo_pk { get; set; }
        public string cl_documento { get; set; }
        public string cl_consecutivo { get; set; }
        public string cl_vehiculo { get; set; }
        public string cl_item { get; set; }
        public string cl_cantidad { get; set; }
        public string cl_costo { get; set; }
        public string cl_precioVenta { get; set; }
        public string cl_descuento { get; set; }
        public string cl_fecha_creacion { get; set; }
        public string cl_fecha_modificacion { get; set; }
        public string cl_usuario { get; set; }
        public string Total { get; set; }
        public string cl_nota { get; set; }

        //items
        public string Item { get; set; }
        public string cl_nombre { get; set; }
        public string cl_descripcion { get; set; }
        public string cl_referencia { get; set; }
        public string cl_codigo_barras { get; set; }
        public string cl_tipo_item { get; set; }

        //Vehiculo
        public string cl_Vehiculo { get; set; }
        public string cl_Placa { get; set; }
        public string cl_Modelo { get; set; }
        public string cl_km { get; set; }

        //Tercero
        public string cl_identificacion { get; set; }
        public string cl_razon_social { get; set; }
        public string cl_direccion { get; set; }
        public string cl_telefonos { get; set; }
        public string cl_Email { get; set; }

        public string v_buscar { get; set; }
        public string v_Fecha_inicio { get; set; }
        public string v_Fecha_fin { get; set; }
        public DataTable mtd_consultar_x_placa()
        {
            v_query = " select " +
                "vh.cl_Codigo_pk, " +
            "vh.cl_placa, " +
            "vh.cl_vehiculo, " +
            "vh.cl_modelo, " +
            "vh.cl_km, " +
            "t.cl_identificacion, " +
            "t.cl_razon_social " +
            "from tbl_vehiculo vh " +
            "inner join tbl_tercero t on t.cl_Codigo_pk = vh.cl_tercero " +
            "where vh.cl_placa = '" + v_buscar + "' ";
            v_dt = cls_datos.mtd_consultar(v_query);
            return v_dt;
        }
        public DataTable mtd_consultar_x_identificacion()
        {
            v_query = " select " +
                "vh.cl_Codigo_pk, " +
            "vh.cl_placa, " +
            "vh.cl_vehiculo, " +
            "vh.cl_modelo, " +
            "vh.cl_km, " +
            "t.cl_identificacion, " +
            "t.cl_razon_social " +
            "from tbl_vehiculo vh " +
            "left join tbl_tercero t on t.cl_Codigo_pk = vh.cl_tercero " +
            "where t.cl_identificacion = '" + v_buscar + "' ";
            v_dt = cls_datos.mtd_consultar(v_query);
            return v_dt;
        }
        private void mtd_asignaParametros()
        {
            if (cl_vehiculo != null)
            {
                Parametros = new SqlParameter[12];
                Parametros[11] = new SqlParameter();
                Parametros[11].ParameterName = "@cl_vehiculo";
                Parametros[11].SqlDbType = SqlDbType.VarChar;
                Parametros[11].SqlValue = cl_vehiculo;
            }
            else 
            {
                Parametros = new SqlParameter[11];
            }
           

            Parametros[0] = new SqlParameter();
            Parametros[0].ParameterName = "@cl_documento";
            Parametros[0].SqlDbType = SqlDbType.VarChar;
            Parametros[0].SqlValue = cl_documento;

            Parametros[1] = new SqlParameter();
            Parametros[1].ParameterName = "@cl_consecutivo";
            Parametros[1].SqlDbType = SqlDbType.VarChar;
            Parametros[1].SqlValue = cl_consecutivo;
          
            Parametros[2] = new SqlParameter();
            Parametros[2].ParameterName = "@cl_item";
            Parametros[2].SqlDbType = SqlDbType.VarChar;
            Parametros[2].SqlValue = cl_item;

            Parametros[3] = new SqlParameter();
            Parametros[3].ParameterName = "@cl_cantidad";
            Parametros[3].SqlDbType = SqlDbType.Float;
            Parametros[3].SqlValue = cl_cantidad;

            Parametros[4] = new SqlParameter();
            Parametros[4].ParameterName = "@cl_precioVenta";
            Parametros[4].SqlDbType = SqlDbType.Money;
            Parametros[4].SqlValue = cl_precioVenta;

            Parametros[5] = new SqlParameter();
            Parametros[5].ParameterName = "@cl_descuento";
            Parametros[5].SqlDbType = SqlDbType.Money;
            Parametros[5].SqlValue = cl_descuento;

            Parametros[6] = new SqlParameter();
            Parametros[6].ParameterName = "@cl_fecha_creacion";
            Parametros[6].SqlDbType = SqlDbType.DateTime;
            Parametros[6].SqlValue = cl_fecha_creacion;

            Parametros[7] = new SqlParameter();
            Parametros[7].ParameterName = "@cl_fecha_modificacion";
            Parametros[7].SqlDbType = SqlDbType.Date;
            Parametros[7].SqlValue = cl_fecha_modificacion;

            Parametros[8] = new SqlParameter();
            Parametros[8].ParameterName = "@cl_usuario";
            Parametros[8].SqlDbType = SqlDbType.Int;
            Parametros[8].SqlValue = cl_usuario;

            Parametros[9] = new SqlParameter();
            Parametros[9].ParameterName = "@cl_costo";
            Parametros[9].SqlDbType = SqlDbType.Money;
            Parametros[9].SqlValue = cl_costo;

            Parametros[10] = new SqlParameter();
            Parametros[10].ParameterName = "@cl_nota";
            Parametros[10].SqlDbType = SqlDbType.VarChar;
            Parametros[10].SqlValue = cl_nota;        
        }
        public Boolean mtd_registrar()
        {
            if (cl_vehiculo != null) 
            {
                v_query = " INSERT INTO tbl_cotizacion (cl_documento,cl_consecutivo,cl_vehiculo,cl_item,cl_cantidad,cl_precioVenta,cl_descuento,cl_fecha_creacion,cl_fecha_modificacion,cl_usuario,cl_costo,cl_nota)" +
      " VALUES (@cl_documento,@cl_consecutivo,@cl_vehiculo,@cl_item,@cl_cantidad,@cl_precioVenta,@cl_descuento,@cl_fecha_creacion,@cl_fecha_modificacion,@cl_usuario,@cl_costo,@cl_nota)";

            }
            else
            {
                v_query = " INSERT INTO tbl_cotizacion (cl_documento,cl_consecutivo,cl_item,cl_cantidad,cl_precioVenta,cl_descuento,cl_fecha_creacion,cl_fecha_modificacion,cl_usuario,cl_costo,cl_nota)" +
      " VALUES (@cl_documento,@cl_consecutivo,@cl_item,@cl_cantidad,@cl_precioVenta,@cl_descuento,@cl_fecha_creacion,@cl_fecha_modificacion,@cl_usuario,@cl_costo,@cl_nota)";

            }

            mtd_asignaParametros();
            v_ok = cls_datos.mtd_registrar(Parametros, v_query);
            return v_ok;
        }
        public DataTable mtd_consultar_consecutivo()
        {
            v_query = " select isnull(max(cl_consecutivo),0) + 1 Consecutivo from tbl_cotizacion ";
            v_dt = cls_datos.mtd_consultar(v_query);
            return v_dt;
        }
        public DataTable mtd_consultar_ordenes()
        {
            DateTime FechaIni = Convert.ToDateTime(v_Fecha_inicio);
            DateTime FechaFin = Convert.ToDateTime(v_Fecha_fin);
            v_query = " sp_consultar_cotizacion '" + v_buscar + "','" + FechaIni + "','" + FechaFin + "' ";
            v_dt = cls_datos.mtd_consultar(v_query);
            return v_dt;
        }

        public DataTable mtd_consultar_ultima_orden()
        {
            v_query = " select max(cl_consecutivo) Consecutivo, cl_documento from tbl_cotizacion " +
                      " group by cl_documento ";
            v_dt = cls_datos.mtd_consultar(v_query);
            return v_dt;
        }
        public DataTable mtd_consultar_cotizacion()
        {
            v_query = "  SELECT os.[cl_codigo_pk]  , " +
  "  os.[cl_documento]  , " +
  "  os.[cl_consecutivo]  , " +
  "  os.[cl_vehiculo]  , " +
  "  os.[cl_item]  , " +
  "  os.[cl_cantidad]  , " +
  "  os.[cl_precioVenta]  , " +
  "  os.[cl_costo]  , " +
  "  os.[cl_descuento]  , " +
  "  os.[cl_fecha_creacion]  , " +
  "  os.[cl_fecha_modificacion]  , " +
  "  os.[cl_usuario]  , " +
  "  it.cl_item Item, " +
  "  it.cl_nombre  , " +
  "  it.cl_descripcion  , " +
  "  it.cl_referencia  , " +
  "  it.cl_codigo_barras , " +
  "  vh.cl_Vehiculo cl_Vehiculo1, " +
  "  vh.cl_Placa, " +
  "  vh.cl_Modelo, " +
  "  tc.cl_identificacion, " +
  "  tc.cl_razon_social, " +
  "  tc.cl_direccion, " +
  "  tc.cl_telefonos, " +
  "  tc.cl_Email, " +
  " it.cl_tipo_item, " +
  " ((os.[cl_cantidad] * os.[cl_precioVenta]) - os.[cl_descuento]) Total, " +
    " os.cl_nota " +
  "  FROM[erp_sbx].[dbo].[tbl_cotizacion] os " +
  "  inner join tbl_items it on it.cl_codigo_pk = os.[cl_item] " +
  "  left join tbl_vehiculo vh on vh.cl_codigo_pk = os.cl_vehiculo " +
  "  inner join tbl_tercero tc on tc.cl_Codigo_pk = vh.cl_Tercero" +
                       " where cl_documento = '" + cl_documento + "' and cl_consecutivo = " + cl_consecutivo + " " +
                       "   order by it.cl_tipo_item asc ";
            v_dt = cls_datos.mtd_consultar(v_query);
            return v_dt;
        }
        public DataTable mtd_consultar_orden_servicio_modificar()
        {
            v_query = " select " +
" os.cl_documento " +
" ,os.cl_consecutivo " +
" ,vh.cl_placa " +
" ,tc.cl_identificacion " +
" ,tc.cl_razon_social " +
" ,vh.cl_vehiculo " +
" ,vh.cl_modelo " +
" ,it.cl_item " +
" ,it.cl_nombre " +
" ,it.cl_descripcion " +
" ,it.cl_referencia " +
" ,os.cl_cantidad " +
" ,os.cl_costo " +
" ,os.cl_precioVenta " +
" ,os.cl_descuento " +
" ,os.cl_nota " +
 " from tbl_cotizacion os " +
" inner join tbl_vehiculo vh on os.cl_vehiculo = vh.cl_codigo_pk " +
" inner join tbl_tercero tc on tc.cl_Codigo_pk = vh.cl_tercero " +
" inner join tbl_items it on it.cl_codigo_pk = os.cl_item " +
                      " where os.cl_documento = '" + cl_documento + "' and os.cl_consecutivo = " + cl_consecutivo + " ";
            v_dt = cls_datos.mtd_consultar(v_query);
            return v_dt;
        }
        public Boolean mtd_eliminar()
        {
            v_query = "DELETE FROM tbl_cotizacion WHERE cl_documento = '" + cl_documento + "' AND cl_consecutivo = " + cl_consecutivo + " ";
            v_ok = cls_datos.mtd_eliminar(v_query);
            return v_ok;
        }
    }
}
