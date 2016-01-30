USE [BINET]
GO

/****** Object:  Table [dbo].[Tb_Usuario]    Script Date: 30/01/2016 01:17:03 p.m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

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

ALTER TABLE [dbo].[Tb_Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Tb_Usuario_Tb_Cliente] FOREIGN KEY([IdCli])
REFERENCES [dbo].[Tb_Cliente] ([IdCli])
GO

ALTER TABLE [dbo].[Tb_Usuario] CHECK CONSTRAINT [FK_Tb_Usuario_Tb_Cliente]
GO


