USE [erp_sbx]
GO
/****** Object:  Table [dbo].[Gastos]    Script Date: 20/03/2022 20:08:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Gastos](
	[codigo] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Descripcion] [varchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GastosM]    Script Date: 20/03/2022 20:08:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GastosM](
	[codigo] [int] IDENTITY(1,1) NOT NULL,
	[FechaRegistro] [datetime] NULL,
	[Gasto] [int] NULL,
	[Valor] [money] NULL,
	[proveedor] [int] NULL,
	[ValorIva] [money] NULL,
	[usuario] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_activos]    Script Date: 20/03/2022 20:08:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_activos](
	[cl_codigo_pk] [int] NOT NULL,
	[cl_nombre] [varchar](300) NULL,
	[cl_Marca] [int] NULL,
	[cl_Valor] [money] NULL,
	[cl_Nota] [varchar](max) NULL,
	[cl_fecha_registro] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[cl_codigo_pk] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_compania]    Script Date: 20/03/2022 20:08:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_compania](
	[cl_Codigo_pk] [int] IDENTITY(1,1) NOT NULL,
	[cl_identificacion] [varchar](20) NOT NULL,
	[cl_tipo_identificacion] [int] NULL,
	[cl_razon_social] [varchar](100) NULL,
	[cl_tipo_persona] [int] NULL,
	[cl_direccion] [varchar](100) NULL,
	[cl_telefonos] [varchar](30) NULL,
	[cl_Email] [varchar](100) NULL,
	[cl_fecha_creacion] [datetime] NULL,
	[cl_fecha_modificacion] [datetime] NULL,
	[cl_usuario] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[cl_Codigo_pk] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_configuracion]    Script Date: 20/03/2022 20:08:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_configuracion](
	[TipoBusquedaDoc] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_cotizacion]    Script Date: 20/03/2022 20:08:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_cotizacion](
	[cl_codigo_pk] [int] IDENTITY(1,1) NOT NULL,
	[cl_documento] [varchar](20) NULL,
	[cl_consecutivo] [int] NULL,
	[cl_vehiculo] [int] NULL,
	[cl_item] [int] NULL,
	[cl_cantidad] [float] NULL,
	[cl_precioVenta] [money] NULL,
	[cl_costo] [money] NULL,
	[cl_descuento] [money] NULL,
	[cl_fecha_creacion] [datetime] NULL,
	[cl_fecha_modificacion] [datetime] NULL,
	[cl_usuario] [int] NULL,
	[cl_nota] [varchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[cl_codigo_pk] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_cuenta_cobro]    Script Date: 20/03/2022 20:08:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_cuenta_cobro](
	[cl_codigo_pk] [int] IDENTITY(1,1) NOT NULL,
	[cl_documento] [varchar](20) NULL,
	[cl_consecutivo] [int] NULL,
	[cl_vehiculo] [int] NULL,
	[cl_item] [int] NULL,
	[cl_cantidad] [float] NULL,
	[cl_precioVenta] [money] NULL,
	[cl_costo] [money] NULL,
	[cl_descuento] [money] NULL,
	[cl_fecha_creacion] [datetime] NULL,
	[cl_fecha_modificacion] [datetime] NULL,
	[cl_usuario] [int] NULL,
	[cl_nota] [varchar](200) NULL,
	[km] [varchar](15) NULL,
	[cl_estado] [int] NULL,
	[cl_documento_nuevo] [varchar](20) NULL,
	[cl_consecutivo_nuevo] [int] NULL,
	[cl_nota_anulacion] [varchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[cl_codigo_pk] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_items]    Script Date: 20/03/2022 20:08:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_items](
	[cl_codigo_pk] [int] IDENTITY(1,1) NOT NULL,
	[cl_item] [varchar](10) NULL,
	[cl_nombre] [varchar](100) NULL,
	[cl_descripcion] [varchar](300) NULL,
	[cl_referencia] [varchar](30) NULL,
	[cl_codigo_barras] [varchar](30) NULL,
	[cl_estado] [varchar](20) NULL,
	[cl_tipo_item] [varchar](20) NULL,
	[cl_costo] [money] NULL,
	[cl_PrecioVenta] [money] NULL,
	[cl_stock_minimo] [float] NULL,
	[cl_stock_maximo] [float] NULL,
	[cl_fecha_creacion] [datetime] NULL,
	[cl_fecha_modificacion] [datetime] NULL,
	[cl_usuario] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[cl_codigo_pk] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_kardex]    Script Date: 20/03/2022 20:08:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_kardex](
	[cl_codigo_pk] [int] IDENTITY(1,1) NOT NULL,
	[cl_item] [int] NULL,
	[cl_costo] [money] NULL,
	[cl_PrecioVenta] [money] NULL,
	[cl_cantidad] [float] NULL,
	[cl_Accion] [varchar](30) NULL,
	[cl_Movimiento] [varchar](30) NULL,
	[cl_fecha_registro] [datetime] NULL,
	[cl_usuario] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[cl_codigo_pk] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_kardex_activos]    Script Date: 20/03/2022 20:08:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_kardex_activos](
	[cl_codigo_pk] [int] IDENTITY(1,1) NOT NULL,
	[cl_activos] [int] NULL,
	[cl_nombre] [varchar](300) NULL,
	[cl_Marca] [int] NULL,
	[cl_Valor] [money] NULL,
	[cl_cantidad] [int] NULL,
	[cl_Nota] [varchar](max) NULL,
	[cl_fecha_registro] [datetime] NULL,
	[cl_movimiento] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[cl_codigo_pk] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_marca]    Script Date: 20/03/2022 20:08:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_marca](
	[cl_codigo] [int] IDENTITY(1,1) NOT NULL,
	[cl_nombre] [varchar](300) NULL,
PRIMARY KEY CLUSTERED 
(
	[cl_codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_orden_servicio]    Script Date: 20/03/2022 20:08:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_orden_servicio](
	[cl_codigo_pk] [int] IDENTITY(1,1) NOT NULL,
	[cl_documento] [varchar](20) NULL,
	[cl_consecutivo] [int] NULL,
	[cl_vehiculo] [int] NULL,
	[cl_item] [int] NULL,
	[cl_cantidad] [float] NULL,
	[cl_precioVenta] [money] NULL,
	[cl_costo] [money] NULL,
	[cl_descuento] [money] NULL,
	[cl_fecha_creacion] [datetime] NULL,
	[cl_fecha_modificacion] [datetime] NULL,
	[cl_usuario] [int] NULL,
	[cl_nota] [varchar](200) NULL,
	[cl_estado] [int] NULL,
	[km] [varchar](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[cl_codigo_pk] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_rol]    Script Date: 20/03/2022 20:08:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_rol](
	[cl_Codigo] [int] NOT NULL,
	[cl_Nombre] [varchar](50) NULL,
	[cl_DescripcionRol] [varchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[cl_Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_tercero]    Script Date: 20/03/2022 20:08:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_tercero](
	[cl_Codigo_pk] [int] IDENTITY(1,1) NOT NULL,
	[cl_identificacion] [varchar](20) NOT NULL,
	[cl_tipo_identificacion] [int] NULL,
	[cl_razon_social] [varchar](100) NULL,
	[cl_tipo_persona] [int] NULL,
	[cl_direccion] [varchar](100) NULL,
	[cl_telefonos] [varchar](30) NULL,
	[cl_Email] [varchar](100) NULL,
	[cl_fecha_creacion] [datetime] NULL,
	[cl_fecha_modificacion] [datetime] NULL,
	[cl_usuario] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[cl_Codigo_pk] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_usuario]    Script Date: 20/03/2022 20:08:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_usuario](
	[cl_Codigo] [int] IDENTITY(1,1) NOT NULL,
	[cl_DNI] [varchar](20) NULL,
	[cl_Nombres] [varchar](50) NULL,
	[cl_Apellidos] [varchar](50) NULL,
	[cl_Celular] [varchar](10) NULL,
	[cl_Telefono] [varchar](10) NULL,
	[cl_Email] [varchar](100) NULL,
	[cl_FechaNacimiento] [date] NULL,
	[cl_NombreUsuario] [varchar](50) NOT NULL,
	[cl_Contrasena] [varchar](max) NULL,
	[cl_Estado] [varchar](10) NOT NULL,
	[cl_Rol] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[cl_Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_vehiculo]    Script Date: 20/03/2022 20:08:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_vehiculo](
	[cl_codigo_pk] [int] IDENTITY(1,1) NOT NULL,
	[cl_Tercero] [int] NULL,
	[cl_Vehiculo] [varchar](100) NULL,
	[cl_Placa] [varchar](20) NOT NULL,
	[cl_Modelo] [varchar](20) NULL,
	[cl_km] [varchar](10) NULL,
	[cl_fecha_creacion] [datetime] NULL,
	[cl_fecha_modificacion] [datetime] NULL,
	[cl_usuario] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[cl_codigo_pk] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[GastosM]  WITH CHECK ADD FOREIGN KEY([Gasto])
REFERENCES [dbo].[Gastos] ([codigo])
GO
ALTER TABLE [dbo].[tbl_activos]  WITH CHECK ADD FOREIGN KEY([cl_Marca])
REFERENCES [dbo].[tbl_marca] ([cl_codigo])
GO
ALTER TABLE [dbo].[tbl_cotizacion]  WITH CHECK ADD FOREIGN KEY([cl_item])
REFERENCES [dbo].[tbl_items] ([cl_codigo_pk])
GO
ALTER TABLE [dbo].[tbl_cotizacion]  WITH CHECK ADD FOREIGN KEY([cl_vehiculo])
REFERENCES [dbo].[tbl_vehiculo] ([cl_codigo_pk])
GO
ALTER TABLE [dbo].[tbl_cuenta_cobro]  WITH CHECK ADD FOREIGN KEY([cl_item])
REFERENCES [dbo].[tbl_items] ([cl_codigo_pk])
GO
ALTER TABLE [dbo].[tbl_cuenta_cobro]  WITH CHECK ADD FOREIGN KEY([cl_vehiculo])
REFERENCES [dbo].[tbl_vehiculo] ([cl_codigo_pk])
GO
ALTER TABLE [dbo].[tbl_kardex]  WITH CHECK ADD FOREIGN KEY([cl_item])
REFERENCES [dbo].[tbl_items] ([cl_codigo_pk])
GO
ALTER TABLE [dbo].[tbl_kardex_activos]  WITH CHECK ADD FOREIGN KEY([cl_Marca])
REFERENCES [dbo].[tbl_marca] ([cl_codigo])
GO
ALTER TABLE [dbo].[tbl_orden_servicio]  WITH CHECK ADD FOREIGN KEY([cl_item])
REFERENCES [dbo].[tbl_items] ([cl_codigo_pk])
GO
ALTER TABLE [dbo].[tbl_orden_servicio]  WITH CHECK ADD FOREIGN KEY([cl_vehiculo])
REFERENCES [dbo].[tbl_vehiculo] ([cl_codigo_pk])
GO
ALTER TABLE [dbo].[tbl_usuario]  WITH CHECK ADD FOREIGN KEY([cl_Rol])
REFERENCES [dbo].[tbl_rol] ([cl_Codigo])
GO
ALTER TABLE [dbo].[tbl_usuario]  WITH CHECK ADD FOREIGN KEY([cl_Rol])
REFERENCES [dbo].[tbl_rol] ([cl_Codigo])
GO
ALTER TABLE [dbo].[tbl_vehiculo]  WITH CHECK ADD FOREIGN KEY([cl_Tercero])
REFERENCES [dbo].[tbl_tercero] ([cl_Codigo_pk])
GO
/****** Object:  StoredProcedure [dbo].[sp_consultar_cotizacion]    Script Date: 20/03/2022 20:08:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_consultar_cotizacion]
@Buscar VARCHAR(100),
@FechaIni DATE,
@FechaFin DATE
AS
select
os.cl_codigo_pk codigo,
os.cl_documento Documento,
os.cl_consecutivo Consecutivo,
v.cl_placa Placa,
v.cl_vehiculo Vehiculo,
v.cl_modelo Modelo,
t.cl_identificacion Identificacion,
t.cl_razon_social 'Razon social',
it.cl_item Item,
it.cl_nombre Nombre,
os.cl_cantidad Cantidad,
FORMAT(os.cl_costo,'N0') Costo,
FORMAT(os.cl_precioventa,'N0') 'Precio Venta',
FORMAT(os.cl_descuento,'N0') Descuento,
os.cl_fecha_creacion 'Fecha creacion',
os.cl_fecha_modificacion 'Fecha modificacion',
os.cl_usuario Usuario,
os.cl_nota
from tbl_cotizacion os
inner join tbl_vehiculo v on v.cl_codigo_pk = os.cl_vehiculo
inner join tbl_items it on os.cl_item = it.cl_codigo_pk
inner join tbl_tercero t on t.cl_Codigo_pk = v.cl_tercero
where (os.cl_consecutivo like @Buscar+'%' OR v.cl_placa LIKE @Buscar+'%' OR t.cl_identificacion LIKE @Buscar+'%') 
AND CONVERT(date,os.cl_fecha_creacion) BETWEEN @FechaIni AND @FechaFin

order by os.cl_codigo_pk desc


GO
/****** Object:  StoredProcedure [dbo].[sp_consultar_cuenta_cobro]    Script Date: 20/03/2022 20:08:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_consultar_cuenta_cobro]
@Buscar VARCHAR(100),
@FechaIni DATE,
@FechaFin DATE
AS
select
os.cl_codigo_pk codigo,
os.cl_documento Documento,
os.cl_consecutivo Consecutivo,
v.cl_placa Placa,
v.cl_vehiculo Vehiculo,
v.cl_modelo Modelo,
t.cl_identificacion Identificacion,
t.cl_razon_social 'Razon social',
it.cl_item Item,
it.cl_nombre Nombre,
os.cl_cantidad Cantidad,
FORMAT(os.cl_costo , 'N0') Costo,
FORMAT(os.cl_precioventa, 'N0') 'Precio Venta',
FORMAT(os.cl_descuento  ,'N0') Descuento,
os.cl_fecha_creacion 'Fecha creacion',
os.cl_fecha_modificacion 'Fecha modificacion',
os.cl_usuario Usuario,
os.cl_nota,
os.km,
case when os.cl_estado = 1 then 'Activa' else 'Anulada' end cl_estado,
os.cl_documento_nuevo, 
os.cl_consecutivo_nuevo,
os.cl_nota_anulacion
from tbl_cuenta_cobro os
inner join tbl_vehiculo v on v.cl_codigo_pk = os.cl_vehiculo
inner join tbl_tercero t on t.cl_Codigo_pk = v.cl_tercero
inner join tbl_items it on os.cl_item = it.cl_codigo_pk
where (os.cl_consecutivo like @Buscar+'%' OR v.cl_placa LIKE @Buscar+'%' OR t.cl_identificacion LIKE @Buscar+'%' 
OR t.cl_razon_social  like @Buscar+'%')
AND CONVERT(date,os.cl_fecha_creacion) BETWEEN @FechaIni AND @FechaFin

order by os.cl_codigo_pk desc
GO
/****** Object:  StoredProcedure [dbo].[sp_consultar_empresa_ayuda]    Script Date: 20/03/2022 20:08:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_consultar_empresa_ayuda]
@Buscar VARCHAR(100)
AS

select 
cl_codigo_pk Codigo, 
cl_identificacion Identificacion, 
case cl_tipo_identificacion 
when 0 then 'NIT'
when 1 then 'RUT'
when 2 then 'CEDULA' end 'Tipo identificacion',
cl_razon_social 'Razon social',
case cl_tipo_persona
when 0 then 'Juridica'
when 1 then 'Natural' end 'Tipo persona',
cl_direccion Direccion,
cl_telefonos Telefono,
cl_email Email,
cl_fecha_creacion 'Fecha creacion',
cl_fecha_modificacion 'Fecha modificacion',
cl_usuario Usuario
 from tbl_compania
 WHERE 
 cl_identificacion LIKE @Buscar+'%' OR cl_razon_social LIKE @Buscar+'%'

GO
/****** Object:  StoredProcedure [dbo].[sp_consultar_empresa_ayuda_2]    Script Date: 20/03/2022 20:08:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_consultar_empresa_ayuda_2]
@Buscar VARCHAR(100)
AS
select 
t.cl_codigo_pk Codigo, 
t.cl_identificacion Identificacion, 
t.cl_razon_social 'Razon social',
vh.cl_placa,
vh.cl_vehiculo,
vh.cl_modelo,
vh.cl_km
 from tbl_compania t
 inner join tbl_vehiculo vh on vh.cl_tercero =t.cl_Codigo_pk
 WHERE 
 cl_identificacion LIKE @Buscar+'%' OR cl_razon_social LIKE @Buscar+'%'
 OR vh.cl_placa LIKE @Buscar+'%'

GO
/****** Object:  StoredProcedure [dbo].[sp_consultar_items_ayuda]    Script Date: 20/03/2022 20:08:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROC [dbo].[sp_consultar_items_ayuda]
@Buscar VARCHAR(100),
@TipoItem VARCHAR(100)
AS
------  Consulta con Stock actual
select 
it.cl_codigo_pk Codigo,
it.cl_item Item,
it.cl_nombre Nombre,
case when (Sum(case when k.cl_Movimiento = 'Salida -' then  k.cl_cantidad * -1 else k.cl_cantidad end)) <= 0 then 1  else (Sum(case when k.cl_Movimiento = 'Salida -' then  k.cl_cantidad * -1 else k.cl_cantidad end)) end Stock,
it.cl_descripcion Descripcion,
it.cl_referencia Referencia,
it.cl_codigo_barras 'Codigo barras',
it.cl_estado Estado,
it.cl_tipo_item 'Tipo item',
FORMAT(it.cl_costo,'N0') Costo,
FORMAT(it.cl_precioVenta,'N0') cl_precioVenta,
it.cl_stock_minimo 'Stock minimo',
it.cl_stock_maximo 'Stock maximo',
it.cl_fecha_creacion 'Fecha creacion',
it.cl_fecha_modificacion 'Fecha modificacion',
it.cl_usuario Usuario
from tbl_kardex k
inner join tbl_items it on k.cl_item = it.cl_codigo_pk
where (it.cl_item LIKE @Buscar+'%' OR it.cl_nombre LIKE @Buscar+'%') AND it.cl_tipo_item like @TipoItem+'%'
group by 
it.cl_codigo_pk ,
it.cl_item ,
it.cl_nombre ,
it.cl_descripcion ,
it.cl_referencia ,
it.cl_codigo_barras ,
it.cl_estado ,
it.cl_tipo_item ,
it.cl_costo ,
it.cl_precioVenta ,
it.cl_stock_minimo ,
it.cl_stock_maximo ,
it.cl_fecha_creacion ,
it.cl_fecha_modificacion ,
it.cl_usuario


GO
/****** Object:  StoredProcedure [dbo].[sp_consultar_ordenes_servicio]    Script Date: 20/03/2022 20:08:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_consultar_ordenes_servicio]
@Buscar VARCHAR(100),
@FechaIni DATE,
@FechaFin DATE
AS
select
os.cl_codigo_pk codigo,
os.cl_documento Documento,
os.cl_consecutivo Consecutivo,
v.cl_placa Placa,
v.cl_vehiculo Vehiculo,
v.cl_modelo Modelo,
t.cl_identificacion Identificacion,
t.cl_razon_social 'Razon social',
it.cl_item Item,
it.cl_nombre Nombre,
os.cl_cantidad Cantidad,
FORMAT(os.cl_costo,'N0') Costo,
FORMAT(os.cl_precioventa,'N0') 'Precio Venta',
FORMAT(os.cl_descuento,'N0') Descuento,
os.cl_fecha_creacion 'Fecha creacion',
os.cl_fecha_modificacion 'Fecha modificacion',
os.cl_usuario Usuario,
os.cl_nota,
os.cl_estado,
os.km
from tbl_orden_servicio os
inner join tbl_vehiculo v on v.cl_codigo_pk = os.cl_vehiculo
inner join tbl_tercero t on t.cl_Codigo_pk = v.cl_tercero
inner join tbl_items it on os.cl_item = it.cl_codigo_pk
where (os.cl_consecutivo like @Buscar+'%' OR v.cl_placa LIKE @Buscar+'%' OR t.cl_identificacion LIKE @Buscar+'%')
AND CONVERT(date,os.cl_fecha_creacion) BETWEEN @FechaIni AND @FechaFin

order by os.cl_codigo_pk desc
GO
/****** Object:  StoredProcedure [dbo].[sp_consultar_tercero_ayuda]    Script Date: 20/03/2022 20:08:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_consultar_tercero_ayuda]
@Buscar VARCHAR(100)
AS

select 
cl_codigo_pk Codigo, 
cl_identificacion Identificacion, 
case cl_tipo_identificacion 
when 0 then 'NIT'
when 1 then 'RUT'
when 2 then 'CEDULA' end 'Tipo identificacion',
cl_razon_social 'Razon social',
case cl_tipo_persona
when 0 then 'Juridica'
when 1 then 'Natural' end 'Tipo persona',
cl_direccion Direccion,
cl_telefonos Telefono,
cl_email Email,
cl_fecha_creacion 'Fecha creacion',
cl_fecha_modificacion 'Fecha modificacion',
cl_usuario Usuario
 from tbl_tercero
 WHERE 
 cl_identificacion LIKE @Buscar+'%' OR cl_razon_social LIKE @Buscar+'%'

GO
/****** Object:  StoredProcedure [dbo].[sp_consultar_tercero_ayuda_2]    Script Date: 20/03/2022 20:08:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[sp_consultar_tercero_ayuda_2]
@Buscar VARCHAR(100)
AS
select 
t.cl_codigo_pk Codigo, 
t.cl_identificacion Identificacion, 
t.cl_razon_social 'Razon social',
vh.cl_placa,
vh.cl_vehiculo,
vh.cl_modelo,
vh.cl_km
 from tbl_tercero t
 inner join tbl_vehiculo vh on vh.cl_tercero =t.cl_Codigo_pk
 WHERE 
 cl_identificacion LIKE @Buscar+'%' OR cl_razon_social LIKE @Buscar+'%'
 OR vh.cl_placa LIKE @Buscar+'%'

GO
/****** Object:  StoredProcedure [dbo].[sp_consultar_vehiculo_ayuda]    Script Date: 20/03/2022 20:08:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_consultar_vehiculo_ayuda]
@Buscar VARCHAR(100)
AS
select
vh.cl_codigo_pk Codigo,
t.cl_identificacion Tercero,
t.cl_razon_social 'Razon social',
vh.cl_vehiculo Vehiculo,
vh.cl_placa Placa,
vh.cl_modelo Modelo,
vh.cl_km km,
vh.cl_fecha_creacion 'Fecha creacion',
vh.cl_fecha_modificacion 'Fecha modificacion',
vh.cl_usuario Usuario
 from tbl_vehiculo vh
 inner join tbl_tercero t on t.cl_Codigo_pk = vh.cl_tercero
 where vh.cl_placa LIKE @Buscar+'%'
GO
/****** Object:  StoredProcedure [dbo].[sp_verificar_login]    Script Date: 20/03/2022 20:08:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO







create PROCEDURE  [dbo].[sp_verificar_login]
	@Usuarios VARCHAR(50),
	@Contrasenas VARCHAR(50)
	AS
	DECLARE
	@PassEncritado VARCHAR(300),
	@PassDecifrado VARCHAR(300)

	SET @PassEncritado = (SELECT cl_Contrasena FROM tbl_Usuario WHERE cl_NombreUsuario = @Usuarios)
	SET	@PassDecifrado = DECRYPTBYPASSPHRASE('password', @PassEncritado)
	IF(@PassDecifrado = @Contrasenas)
	SELECT cl_Codigo,cl_Nombres+' '+cl_Apellidos Nombre,cl_NombreUsuario FROM tbl_Usuario WHERE cl_NombreUsuario = @Usuarios
	ELSE
	SELECT cl_Codigo,cl_Nombres+' '+cl_Apellidos Nombre,cl_NombreUsuario FROM tbl_Usuario WHERE cl_Codigo = 0
GO
