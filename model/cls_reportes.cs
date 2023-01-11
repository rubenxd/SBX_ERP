using SBX_ERP.db;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBX_ERP.model
{
    public class cls_reportes
    {
        //instancias
        cls_conexion cls_cn = new cls_conexion();
        cls_datos cls_datos = new cls_datos();
        DataTable v_dt;
        string v_query = "";

        public string Busqueda { get; set; }
        public DateTime Finical { get; set; }
        public DateTime ffinal { get; set; }

        public DataTable mtd_consultar()
        {
            v_query = " select  isnull(Sum(CostoTotal),0) CostoTotal, isnull(sum(TotalVenta),0) TotalVenta " +
                " from ( " +
                " select cl_item,cl_cantidad,cl_costo,cl_precioVenta, (cl_cantidad * cl_costo) CostoTotal, (cl_cantidad * cl_precioVenta) TotalVenta " +
                " from [tbl_cuenta_cobro] " +
                " where CONVERT(date,cl_fecha_creacion) BETWEEN '"+Finical.ToString("yyyyMMdd")+"' AND '"+ffinal.ToString("yyyyMMdd")+ "' AND (cl_estado = 1)  " +
                " )g ";
            v_dt = cls_datos.mtd_consultar(v_query);
            return v_dt;
        }
    }
}
