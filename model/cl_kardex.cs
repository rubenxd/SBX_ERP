using SBX_ERP.db;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBX_ERP.model
{
    public class cl_kardex
    {
        cls_datos cls_datos = new cls_datos();
        string v_query = "";
        DataTable v_dt;
        public DataTable mtd_consultar(string Buscar)
        {
            v_query =   "   SELECT " +
                        "   krx.[cl_codigo_pk]" +
                        "  ,it.cl_item" +
                        "  ,it.cl_nombre" +
                        "  ,krx.[cl_costo]" +
                        "  ,krx.[cl_PrecioVenta]" +
                        "  ,krx.[cl_cantidad]" +
                        "  ,case when cl_Movimiento = 'Salida -' then cl_cantidad *-1 else cl_cantidad end cantidad_calculo" +
                        "  ,krx.[cl_Accion]" +
                        "  ,krx.[cl_Movimiento]" +
                        "  ,krx.[cl_fecha_registro]" +
                        "  ,krx.[cl_usuario]" +
                        "  ,us.cl_NombreUsuario," +
                        "  ( " +
                        "  select sum(case when cl_Movimiento = 'Salida -' then cl_cantidad * -1 else cl_cantidad end) from[tbl_kardex]" +
                        "  where cl_item = krx.cl_item" +
                        "  group by cl_item" +
                        "  ) Existencia" +
                        "  FROM[erp_sbx].[dbo].[tbl_kardex] krx" +
                        "  inner join tbl_items it on it.cl_codigo_pk = krx.cl_item" +
                        "  inner join tbl_usuario us on us.cl_DNI = krx.cl_usuario" +
                        "  where it.cl_item like '"+ Buscar + "%' or it.cl_nombre like '"+ Buscar + "%'" +
                        "  order by it.cl_item ";
            v_dt = cls_datos.mtd_consultar(v_query);
            return v_dt;
        }
    }
}
