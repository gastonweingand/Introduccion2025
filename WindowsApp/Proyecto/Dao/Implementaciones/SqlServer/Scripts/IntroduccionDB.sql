USE [Introduccion]
GO
/****** Object:  User [introduccion]    Script Date: 24/5/2025 10:46:45 ******/
CREATE USER [introduccion] FOR LOGIN [introduccion] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [introduccion]
GO
/****** Object:  Table [dbo].[Categoria]    Script Date: 24/5/2025 10:46:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categoria](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Descripcion] [varchar](50) NULL,
 CONSTRAINT [PK_Categoria] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 24/5/2025 10:46:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Precio] [money] NULL,
	[CodigoBarra] [varchar](50) NULL,
	[FechaVencimiento] [date] NULL,
	[IdCategoria] [int] NULL,
 CONSTRAINT [PK_Producto] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Categoria] ON 

INSERT [dbo].[Categoria] ([Id], [Nombre], [Descripcion]) VALUES (1, N'Bebidas', N'Descripción de la categoría de bebidas')
INSERT [dbo].[Categoria] ([Id], [Nombre], [Descripcion]) VALUES (2, N'Congelados', N'Descripción de la categoría de congelados')
INSERT [dbo].[Categoria] ([Id], [Nombre], [Descripcion]) VALUES (3, N'Pastas secas', N'Descripción de la categoría de pastas secas')
SET IDENTITY_INSERT [dbo].[Categoria] OFF
GO
SET IDENTITY_INSERT [dbo].[Producto] ON 

INSERT [dbo].[Producto] ([Id], [Nombre], [Precio], [CodigoBarra], [FechaVencimiento], [IdCategoria]) VALUES (2, N'Fideos Marolio Moñito 500g', 2000.0000, N'1234', CAST(N'2025-12-31' AS Date), 3)
INSERT [dbo].[Producto] ([Id], [Nombre], [Precio], [CodigoBarra], [FechaVencimiento], [IdCategoria]) VALUES (3, N'Fideos Marolio Moñito 1kg', 4000.0000, N'1235', CAST(N'2028-12-31' AS Date), 3)
INSERT [dbo].[Producto] ([Id], [Nombre], [Precio], [CodigoBarra], [FechaVencimiento], [IdCategoria]) VALUES (5, N'Coca cola 2.25L', 4500.0000, N'5555', CAST(N'2026-10-31' AS Date), NULL)
INSERT [dbo].[Producto] ([Id], [Nombre], [Precio], [CodigoBarra], [FechaVencimiento], [IdCategoria]) VALUES (6, N'Coca cola 1.75L', 3500.0000, N'7777', CAST(N'2025-08-30' AS Date), NULL)
INSERT [dbo].[Producto] ([Id], [Nombre], [Precio], [CodigoBarra], [FechaVencimiento], [IdCategoria]) VALUES (7, N'Coca cola 500ml', 1500.0000, N'666', CAST(N'2029-10-31' AS Date), NULL)
INSERT [dbo].[Producto] ([Id], [Nombre], [Precio], [CodigoBarra], [FechaVencimiento], [IdCategoria]) VALUES (8, N'Sprite 1.5l', 2800.0000, N'6666', CAST(N'2025-12-31' AS Date), NULL)
SET IDENTITY_INSERT [dbo].[Producto] OFF
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [FK_Producto_Categoria] FOREIGN KEY([IdCategoria])
REFERENCES [dbo].[Categoria] ([Id])
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [FK_Producto_Categoria]
GO
USE [master]
GO
ALTER DATABASE [Introduccion] SET  READ_WRITE 
GO
