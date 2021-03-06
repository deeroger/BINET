USE [master]
GO

/******   Database [BINET]   ******/
CREATE DATABASE [BINET]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BINET', FILENAME = N'C:\BD\BINET.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'BINET_log', FILENAME = N'C:\BD\BINET_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO	

USE [BINET]
GO

/****************************************   Table [dbo].[cliente]   ******************************************/
CREATE TABLE [dbo].[Cliente](
/*	[IdCliente] [int] IDENTITY(1,1) NOT NULL,*/

	[IdCliente] [int]	NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[ApellidoPaterno] [varchar](100) NOT NULL,
	[ApellidoMaterno] [varchar](100) NOT NULL,
	[NumIdent] [varchar](20) NOT NULL,
	[Email] [nvarchar](70) NOT NULL,
	[Telefono] [varchar](9) NOT NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[IdCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

/****************************************   Table [dbo].[Cliente]   ******************************************/

CREATE TABLE [dbo].[Tb_Usuario](
	[IdCli] [int] NOT NULL,
	[UID] [nvarchar](20) NOT NULL,
	[Password] [nvarchar](20) NOT NULL,
	[FlaAct] [bit] NOT NULL,
 CONSTRAINT [PK_Tb_Usuario] PRIMARY KEY CLUSTERED 
(
	[IdCli] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Tb_Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Tb_Usuario_Cliente] FOREIGN KEY([IdCli])
REFERENCES [dbo].[Cliente] ([IdCliente])
GO

ALTER TABLE [dbo].[Tb_Usuario] CHECK CONSTRAINT [FK_Tb_Usuario_Cliente]
GO


/****************************************   Table [dbo].[moneda]   ******************************************/
CREATE TABLE [dbo].[moneda](
	[codigo]		[int]		NOT NULL,
	[nombre]		[char](10)	NOT NULL,
 CONSTRAINT [PK_moneda] PRIMARY KEY CLUSTERED 
(	[codigo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

/****************************************   Table [dbo].[tipocuenta]   ******************************************/
CREATE TABLE [dbo].[tipocuenta](
	[codigo]		[char](01)	NOT NULL,
	[nombre]		[char](10)	NOT NULL,
 CONSTRAINT [PK_tipocuenta] PRIMARY KEY CLUSTERED 
(	[codigo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

/****************************************   Table [dbo].[estado]   ******************************************/
CREATE TABLE [dbo].[estado](
	[codigo]		[char](01)	NOT NULL,
	[nombre]		[char](10)	NOT NULL,
 CONSTRAINT [PK_estado] PRIMARY KEY CLUSTERED 
(	[codigo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

/****************************************   Table [dbo].[cuenta]   ******************************************/
CREATE TABLE [dbo].[cuenta](
	[codigo]		[numeric] (19)	NOT NULL,
	[cliente]		[int]			NOT NULL,
	[moneda]		[int]			NOT NULL,
	[tipo]			[char](01)		NOT NULL,
	[disponible]	[decimal](10,2) NOT NULL,
	[estado]		[char](01)		NOT NULL,	
 CONSTRAINT [PK_cuenta] PRIMARY KEY CLUSTERED 
(	[codigo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/******   ForeignKey [FK_cuenta_cliente]   ******/
ALTER TABLE [dbo].[cuenta]  WITH CHECK ADD  CONSTRAINT [FK_cuenta_cliente] FOREIGN KEY([cliente])
REFERENCES [dbo].[cliente] ([IdCliente])
GO
ALTER TABLE [dbo].[cuenta] CHECK CONSTRAINT [FK_cuenta_cliente]
GO
/******   ForeignKey [FK_cuenta_moneda]   ******/
ALTER TABLE [dbo].[cuenta]  WITH CHECK ADD  CONSTRAINT [FK_cuenta_moneda] FOREIGN KEY([moneda])
REFERENCES [dbo].[moneda] ([codigo])
GO
ALTER TABLE [dbo].[cuenta] CHECK CONSTRAINT [FK_cuenta_moneda]
GO
/******   ForeignKey [FK_cuenta_tipo]   ******/
ALTER TABLE [dbo].[cuenta]  WITH CHECK ADD  CONSTRAINT [FK_cuenta_tipo] FOREIGN KEY([tipo])
REFERENCES [dbo].[tipocuenta] ([codigo])
GO
ALTER TABLE [dbo].[cuenta] CHECK CONSTRAINT [FK_cuenta_tipo]
GO
/******   ForeignKey [FK_cuenta_estado]   ******/
ALTER TABLE [dbo].[cuenta]  WITH CHECK ADD  CONSTRAINT [FK_cuenta_estado] FOREIGN KEY([estado])
REFERENCES [dbo].[estado] ([codigo])
GO
ALTER TABLE [dbo].[cuenta] CHECK CONSTRAINT [FK_cuenta_estado]
GO

/****************************************   Table [dbo].[campana]   ******************************************/
CREATE TABLE [dbo].[campana](
	[codigo]		[int] 			NOT NULL,
	[cliente]		[int]			NOT NULL,
	[cuenta]		[numeric] (19)	NOT NULL,
	[moneda]		[int]			NOT NULL,
	[monto]			[decimal](10,2) NOT NULL,
	[tea]			[decimal](5,2)	NOT NULL,
	[tcea]			[decimal](5,2)	NOT NULL,
	[cuotas1]		[int]			NOT NULL,
	[montoc1]		[decimal](10,2) NOT NULL,
	[cuotas2]		[int]			NOT NULL,
	[montoc2]		[decimal](10,2) NOT NULL,
	[cuotas3]		[int]			NOT NULL,
	[montoc3]		[decimal](10,2) NOT NULL,
	[estado]		[char](01)		NOT NULL,
	[montotot1]		[decimal](10,2) NOT NULL,
	[montotot2]		[decimal](10,2) NOT NULL,
	[montotot3]		[decimal](10,2) NOT NULL,	
 CONSTRAINT [PK_campana] PRIMARY KEY CLUSTERED 
(	[codigo] ASC, [cliente] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/******   ForeignKey [FK_campana_cliente]   ******/
ALTER TABLE [dbo].[campana]  WITH CHECK ADD  CONSTRAINT [FK_campana_cliente] FOREIGN KEY([cliente])
REFERENCES [dbo].[cliente] ([IdCliente])
GO
ALTER TABLE [dbo].[campana] CHECK CONSTRAINT [FK_campana_cliente]
GO
/******   ForeignKey [FK_campana_cuenta]   ******/
ALTER TABLE [dbo].[campana]  WITH CHECK ADD  CONSTRAINT [FK_campana_cuenta] FOREIGN KEY([cuenta])
REFERENCES [dbo].[cuenta] ([codigo])
GO
ALTER TABLE [dbo].[campana] CHECK CONSTRAINT [FK_campana_cuenta]
GO
/******   ForeignKey [FK_campana_moneda]   ******/
ALTER TABLE [dbo].[campana]  WITH CHECK ADD  CONSTRAINT [FK_campana_moneda] FOREIGN KEY([moneda])
REFERENCES [dbo].[moneda] ([codigo])
GO
ALTER TABLE [dbo].[campana] CHECK CONSTRAINT [FK_campana_moneda]
GO
/******   ForeignKey [FK_campana_estado]   ******/
ALTER TABLE [dbo].[campana]  WITH CHECK ADD  CONSTRAINT [FK_campana_estado] FOREIGN KEY([estado])
REFERENCES [dbo].[estado] ([codigo])
GO
ALTER TABLE [dbo].[campana] CHECK CONSTRAINT [FK_campana_estado]
GO

/****************************************   Table [dbo].[tipotarjeta]   ******************************************/
CREATE TABLE [dbo].[tipotarjeta](
	[codigo]		[char](01)	NOT NULL,
	[nombre]		[char](10)	NOT NULL,
 CONSTRAINT [PK_tipotarjeta] PRIMARY KEY CLUSTERED 
(	[codigo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

/****************************************   Table [dbo].[tarjeta]   ******************************************/
CREATE TABLE [dbo].[tarjeta](
	[codigo]	[numeric] (19) NOT NULL,
	[cuenta]	[numeric] (19) NOT NULL,	
	[tipo]		[char](01) NOT NULL,
	[estado]	[char](01) NOT NULL,		
 CONSTRAINT [PK_tarjeta] PRIMARY KEY CLUSTERED 
(	[codigo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/******   ForeignKey [FK_tarjeta_cuenta]   ******/
ALTER TABLE [dbo].[tarjeta]  WITH CHECK ADD  CONSTRAINT [FK_tarjeta_cuenta] FOREIGN KEY([cuenta])
REFERENCES [dbo].[cuenta] ([codigo])
GO
ALTER TABLE [dbo].[tarjeta] CHECK CONSTRAINT [FK_tarjeta_cuenta]
GO
/******   ForeignKey [FK_tarjeta_tipo]   ******/
ALTER TABLE [dbo].[tarjeta]  WITH CHECK ADD  CONSTRAINT [FK_tarjeta_tipo] FOREIGN KEY([tipo])
REFERENCES [dbo].[tipotarjeta] ([codigo])
GO
ALTER TABLE [dbo].[tarjeta] CHECK CONSTRAINT [FK_tarjeta_tipo]
GO
/******   ForeignKey [FK_tarjeta_estado]   ******/
ALTER TABLE [dbo].[tarjeta]  WITH CHECK ADD  CONSTRAINT [FK_tarjeta_estado] FOREIGN KEY([estado])
REFERENCES [dbo].[estado] ([codigo])
GO
ALTER TABLE [dbo].[tarjeta] CHECK CONSTRAINT [FK_tarjeta_estado]
GO

/****************************************   Table [dbo].[prestamo]   ******************************************/
CREATE TABLE [dbo].[prestamo](
	[codigo]		[int] NOT NULL,
	[tarjeta]		[numeric] (19) NOT NULL,
	[cuentaorigen]	[numeric] (19) NOT NULL,
	[moneda]		[int]			NOT NULL,
	[monto]			[decimal](10,2) NOT NULL,
	[cuotas]		[int] NOT NULL,
	[tea]			[decimal](5,2) NOT NULL,
	[tcea]			[decimal](5,2) NOT NULL,
	[montoc]		[decimal](10,2) NOT NULL,
	[fechor]		[datetime] NOT NULL,
	[cuentadestino]	[numeric] (19) NOT NULL,
	[cliente]		[int]	NOT NULL,
 CONSTRAINT [PK_prestamo] PRIMARY KEY CLUSTERED 
(	[codigo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/******   ForeignKey [FK_prestamo_tarjeta]   ******/
ALTER TABLE [dbo].[prestamo]  WITH CHECK ADD  CONSTRAINT [FK_prestamo_tarjeta] FOREIGN KEY([tarjeta])
REFERENCES [dbo].[tarjeta] ([codigo])
GO
ALTER TABLE [dbo].[prestamo] CHECK CONSTRAINT [FK_prestamo_tarjeta]
GO
/******   ForeignKey [FK_prestamo_cuentaorigen]   ******/
ALTER TABLE [dbo].[prestamo]  WITH CHECK ADD  CONSTRAINT [FK_prestamo_cuentaorigen] FOREIGN KEY([cuentaorigen])
REFERENCES [dbo].[cuenta] ([codigo])
GO
ALTER TABLE [dbo].[prestamo] CHECK CONSTRAINT [FK_prestamo_cuentaorigen]
GO

/******   ForeignKey [FK_prestamo_cuentadestino]   ******/
ALTER TABLE [dbo].[prestamo]  WITH CHECK ADD  CONSTRAINT [FK_prestamo_cuentadestino] FOREIGN KEY([cuentadestino])
REFERENCES [dbo].[cuenta] ([codigo])
GO
ALTER TABLE [dbo].[prestamo] CHECK CONSTRAINT [FK_prestamo_cuentadestino]
GO

/******   ForeignKey [FK_prestamo_cliente]   ******/
ALTER TABLE [dbo].[prestamo]  WITH CHECK ADD  CONSTRAINT [FK_prestamo_cliente] FOREIGN KEY([cliente])
REFERENCES [dbo].[cliente] ([IdCliente])
GO
ALTER TABLE [dbo].[prestamo] CHECK CONSTRAINT [FK_prestamo_cliente]
GO
/******   ForeignKey [FK_prestamo_moneda]   ******/
ALTER TABLE [dbo].[prestamo]  WITH CHECK ADD  CONSTRAINT [FK_prestamo_moneda] FOREIGN KEY([moneda])
REFERENCES [dbo].[moneda] ([codigo])
GO
ALTER TABLE [dbo].[prestamo] CHECK CONSTRAINT [FK_prestamo_moneda]
GO

CREATE TABLE [dbo].[Cronograma](
	[prestamo] [int] NOT NULL,
	[cliente] [int] NOT NULL,
	[cuota] [int] NOT NULL,
	[fecha] [date] NOT NULL,
	[monto] [decimal](10, 2) NOT NULL,
	[estado] [char](1) NOT NULL,
 CONSTRAINT [PK_Cronograma] PRIMARY KEY CLUSTERED 
(
	[prestamo] ASC,
	[cliente] ASC,
	[cuota] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[Cronograma]  WITH CHECK ADD  CONSTRAINT [FK_Cronograma_Cliente] FOREIGN KEY([cliente])
REFERENCES [dbo].[Cliente] ([IdCliente])
GO

ALTER TABLE [dbo].[Cronograma] CHECK CONSTRAINT [FK_Cronograma_Cliente]
GO

ALTER TABLE [dbo].[Cronograma]  WITH CHECK ADD  CONSTRAINT [FK_Cronograma_prestamo] FOREIGN KEY([prestamo])
REFERENCES [dbo].[prestamo] ([codigo])
GO

ALTER TABLE [dbo].[Cronograma] CHECK CONSTRAINT [FK_Cronograma_prestamo]
GO

/**********Clientes******************************************/
Insert into Cliente values (1,'Pedro','Romero','Salazar','43919590','pedro@pedro.com','1234567')
Insert into Cliente values (2,'Luisa','Reyes','Torres','43919591','luisa@luisa.com','7654321')
Insert into Cliente values (3,'Paola','Flores','Mero','43919592','paola@paola.com','1231231')
GO

/**********Usuarios******************************************/
Insert into Tb_Usuario values (1,'promero','123',1);
Insert into Tb_Usuario values (2,'luis','luisa',0);
GO

/**********Monedas*****1=Soles, 2=Dolares*************************************/
Insert into moneda values (1, 'Soles')
Insert into moneda values (2, 'Dolares')

/**********Tipo Cuenta********************************************************/
Insert into tipocuenta values ('A', 'Ahorro')
Insert into tipocuenta values ('C', 'Credito')
Insert into tipocuenta values ('P', 'Paralela')
Insert into tipocuenta values ('T', 'Cts')

/**********Estado********************************************************/
Insert into estado values ('A', 'Activo')
Insert into estado values ('C', 'cancelado')


/**********Cuentas***********************************************************/
Insert into cuenta values (1, 1, 1, 'A', 5000, 'A')
Insert into cuenta values (2, 1, 1, 'P', 10000, 'A')
Insert into cuenta values (3, 1, 1, 'C', 15000, 'A')
Insert into cuenta values (10, 1, 1, 'T', 55000, 'A')
GO
Insert into cuenta values (4, 2, 1, 'A', 5000, 'A')
Insert into cuenta values (5, 2, 1, 'P', 10000, 'A')
Insert into cuenta values (6, 2, 1, 'C', 15000, 'A')
GO
Insert into cuenta values (7, 3, 1, 'A', 5000, 'A')
Insert into cuenta values (8, 3, 1, 'P', 10000, 'A')
Insert into cuenta values (9, 3, 1, 'C', 15000, 'A')
GO

/**********Tipo tarjeta********************************************************/
Insert into tipotarjeta values ('C', 'Credito')
Insert into tipotarjeta values ('D', 'Debito')

/**********Tarjetas**********************************************************/
Insert into tarjeta values (1, 2, 'C', 'C')
Insert into tarjeta values (2, 2, 'C', 'C')
Insert into tarjeta values (3, 2, 'C', 'A')
GO
Insert into tarjeta values (4, 5, 'C', 'C')
Insert into tarjeta values (5, 5, 'C', 'C')
Insert into tarjeta values (6, 5, 'C', 'A')
GO
Insert into tarjeta values (7, 8, 'C', 'C')
Insert into tarjeta values (8, 8, 'C', 'C')
Insert into tarjeta values (9, 8, 'C', 'A')
GO

/**********Campaña******************************************/
Insert into campana values (1, 1, 2, 1, 15000, 12.50, 12.99, 12, 445.41, 24, 473.07, 36, 501.80, 'A', 5000,10000,15000)
Insert into campana values (1, 2, 5, 1, 15000, 12.50, 12.99, 12, 445.41, 24, 473.07, 36, 501.80, 'A', 5000,10000,15000)
Insert into campana values (1, 3, 8, 1, 15000, 12.50, 12.99, 12, 445.41, 24, 473.07, 36, 501.80, 'A', 5000,10000,15000)
GO

USE BINET

IF OBJECT_ID ('CerrarCampana','TR') IS NOT NULL
   DROP TRIGGER CerrarCampana;

Go

CREATE TRIGGER CerrarCampana ON Cronograma
AFTER INSERT
AS
Begin
	Update Ca
	Set Ca.estado='C'
	From campana Ca
	Inner Join Cronograma Pe On Pe.cliente=Ca.cliente
End
GO

/**********Prestamo******************************************/
/*Insert into prestamo values (1, 3, 2, 1, 15000, 12, 12.50, 12.99, 445.41, '01-31-2016 12:12:12:000', 1, 1)
Insert into prestamo values (2, 6, 5, 1, 15000, 12, 12.50, 12.99, 445.41, '01-31-2016 12:12:12:000', 4, 2)
Insert into prestamo values (3, 9, 8, 1, 15000, 12, 12.50, 12.99, 445.41, '01-31-2016 12:12:12:000', 7, 3)*/

--select * from campana
--use BINET
--select * from prestamo
--delete from prestamo
--select * from moneda
--select * from tipocuenta
--select * from tipotarjeta
--select * from Cliente
--select * from cuenta
--select * from tarjeta
--select * from estado
--select * from campana

---- Cliente => 1
---- MOSTRAR AVISO DE PRESTAMO (A=ACTIVO SIN USO DE CAMPAÑA, C=CANCELADO O RECHAZADO) => 
--select ca.* 
--from campana ca 
--inner join cuenta cu on cu.codigo=ca.cuenta and cu.estado='A' and cu.tipo='P' and cu.moneda=ca.moneda and cu.cliente=ca.cliente 
--inner join tarjeta ta on ta.cuenta=cu.codigo and ta.estado='A' and ta.tipo='C'
--WHERE ca.CODIGO=1 AND ca.CLIENTE =1 AND ca.ESTADO = 'A' and ca.moneda=1 and ca.monto>=5000 And exists (Select * From Cuenta where cliente=1 and estado='A' and tipo='A');
---- MOSTRAR CUENTA DEST (COMBO)
--Select * From Cuenta where cliente=1 and estado='A' and tipo='A';
---- ELEGIR OPCION DE CUOTAS Y CUENTA DESTINO QUE QUIERE E INVOCAR SERVICIO DE JANET (REGISTRAR PRESTAMO)
----- OPERACION EXITOSTSA => CODIOG DE PRESTAMO
--select * from prestamo


