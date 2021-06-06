use master
go

create database QuanLyBatDongSan
go

use QuanLyBatDongSan
go

CREATE TABLE [dbo].[clients](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[firstname] [nvarchar](50) NOT NULL,
	[lastname] [nvarchar](50) NULL,
	[phonenumber] [varchar](12) NOT NULL,
	[email] [varchar](50) NULL,
	[address] [nvarchar](100) NULL,
 CONSTRAINT [PK_clients] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[property_type](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NOT NULL,
	[description] [nvarchar](500) NOT NULL,
 CONSTRAINT [PK_property_type] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[owner](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[firstname] [nvarchar](50) NOT NULL,
	[lastname] [nvarchar](50) NOT NULL,
	[phone] [varchar](12) NOT NULL,
	[email] [varchar](50) NULL,
	[address] [nvarchar](100) NULL,
 CONSTRAINT [PK_owner] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[property](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[type] [int] NULL,
	[squarefeet] [int] NULL,
	[ownerId] [int] NULL,
	[price] [nvarchar] (50) NULL,
	[address] [nvarchar](100) NULL,
	[bedroom] [int] NULL,
	[bathroom] [int] NULL,
	[age] [int] NULL,
	[balcony] [tinyint] NULL,
	[pool] [tinyint] NULL,
	[backyard] [tinyint] NULL,
	[garage] [tinyint] NULL,
	[description] [nvarchar](500) NULL,
 CONSTRAINT [PK_property] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[property]  WITH CHECK ADD  CONSTRAINT [FK_property_owner] FOREIGN KEY([ownerId])
REFERENCES [dbo].[owner] ([id])
GO

ALTER TABLE [dbo].[property] CHECK CONSTRAINT [FK_property_owner]
GO

ALTER TABLE [dbo].[property]  WITH CHECK ADD  CONSTRAINT [FK_property_property_type] FOREIGN KEY([type])
REFERENCES [dbo].[property_type] ([id])
GO

ALTER TABLE [dbo].[property] CHECK CONSTRAINT [FK_property_property_type]
GO

CREATE TABLE [dbo].[property_image](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[propertyId] [int] NOT NULL,
	[image] [text] NOT NULL,
 CONSTRAINT [PK_property_image] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[property_image]  WITH CHECK ADD  CONSTRAINT [FK_property_image_property] FOREIGN KEY([propertyId])
REFERENCES [dbo].[property] ([id])
GO

ALTER TABLE [dbo].[property_image] CHECK CONSTRAINT [FK_property_image_property]
GO

CREATE TABLE [dbo].[sale](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[propertyId] [int] NOT NULL,
	[clientId] [int] NOT NULL,
	[finalprice] [varchar](50) NOT NULL,
	[saledate] [date] NULL,
 CONSTRAINT [PK_sale] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[sale]  WITH CHECK ADD  CONSTRAINT [FK_sale_clients] FOREIGN KEY([clientId])
REFERENCES [dbo].[clients] ([id])
GO

ALTER TABLE [dbo].[sale] CHECK CONSTRAINT [FK_sale_clients]
GO

ALTER TABLE [dbo].[sale]  WITH CHECK ADD  CONSTRAINT [FK_sale_property] FOREIGN KEY([propertyId])
REFERENCES [dbo].[property] ([id])
GO

ALTER TABLE [dbo].[sale] CHECK CONSTRAINT [FK_sale_property]
GO

CREATE TABLE [dbo].[users](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[username] [varchar](50) NOT NULL,
	[password] [varchar](50) NOT NULL,
 CONSTRAINT [PK_users] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
