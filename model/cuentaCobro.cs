using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBX_ERP.model
{
    public class cuentaCobro
    {
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
    }
}
