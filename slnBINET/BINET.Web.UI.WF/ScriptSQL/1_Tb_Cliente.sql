USE [BINET]
GO

/****** Object:  Table [dbo].[Tb_Cliente]    Script Date: 30/01/2016 01:16:49 p.m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Tb_Cliente](
	[IdCli] [int] IDENTITY(1,1) NOT NULL,
	[ApePat] [nvarchar](100) NOT NULL,
	[ApeMat] [nvarchar](100) NOT NULL,
	[NomCli01] [nvarchar](15) NOT NULL,
	[NomCli02] [nvarchar](15) NULL,
	[DirCli] [nvarchar](150) NOT NULL,
	[NumIde] [nvarchar](15) NOT NULL,
	[TipIde] [tinyint] NOT NULL,
	[MailCli01] [nvarchar](50) NOT NULL,
	[TelCli01] [int] NOT NULL,
 CONSTRAINT [PK_Tb_Cliente] PRIMARY KEY CLUSTERED 
(
	[IdCli] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


