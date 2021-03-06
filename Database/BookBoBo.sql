USE [sachbobo]
GO
/****** Object:  Table [dbo].[Bangchucvu]    Script Date: 1/17/2022 2:44:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bangchucvu](
	[Sottcv] [int] IDENTITY(1,1) NOT NULL,
	
	[Chucvu] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[Sottcv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bangkhachhang]    Script Date: 1/17/2022 2:44:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bangkhachhang](
	[Sottkh] [int] IDENTITY(1,1) NOT NULL,
	[Tenkhachhang] [nvarchar](200) NULL,
	[Trangthai] [bit] NULL,
	[Sodienthoai] [varchar](10) NULL,
	[Matkhau] [varchar](10) NULL,
	[Gioitinh] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Sottkh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bangkhosach]    Script Date: 1/17/2022 2:44:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bangkhosach](
	[Sottks] [int] IDENTITY(1,1) NOT NULL,
	[Sotttg] [int] NULL,
	[Sottbs] [int] NULL,
	[Sottnv] [int] NULL,
	[Soluongsach] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Sottks] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bangnhanvien]    Script Date: 1/17/2022 2:44:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bangnhanvien](
	[Sottnv] [int] IDENTITY(1,1) NOT NULL,
	[Hovatennhanvien] [nvarchar](200) NULL,
	[tkemail] [varchar](200) NULL,
	[gioitinh] [bit] NULL,
	[matkhau] [varchar](10) NULL,
	[tuoi] [int] NULL,
	[Sottcv] [int] NULL,
	[anh3x4] [image] NULL,
 PRIMARY KEY CLUSTERED 
(
	[Sottnv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BangSach]    Script Date: 1/17/2022 2:44:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BangSach](
	[Sottbs] [int] IDENTITY(1,1) NOT NULL,
	[Tensach] [nvarchar](200) NULL,
	[soluocnoidung] [nvarchar](800) NULL,
	[biasach] [image] NULL,
	[Sottnv] [int] NULL,
	[gia] [bigint] NULL,
PRIMARY KEY CLUSTERED 
(
	[Sottbs] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bangtacgia]    Script Date: 1/17/2022 2:44:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bangtacgia](
	[Sotttg] [int] IDENTITY(1,1) NOT NULL,
	[Tentacgia] [nvarchar](200) NULL,
	[Diachi] [nvarchar](200) NULL,
	[Sodienthoai] [varchar](20) NULL,
	[Sottnv] [int] NULL,
	[Anhcanhan] [image] NULL,
PRIMARY KEY CLUSTERED 
(
	[Sotttg] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Hoadon]    Script Date: 1/17/2022 2:44:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hoadon](
	[Sotthd] [int] IDENTITY(1,1) NOT NULL,
	[Sottnv] [int] NULL,
	[Soluongsach] [int] NULL,
	[Giasach] [int] NULL,
	[Tongtien]  AS ([Giasach]*[Soluongsach]),
	[Ngaylaphoadon] [datetime] NULL,
	[Sottkh] [int] NULL,
	[Sottbs] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Sotthd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Phieuphat]    Script Date: 1/17/2022 2:44:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Phieuphat](
	[Sottpp] [int] IDENTITY(1,1) NOT NULL,
	[Sottnv] [int] Null,
	[Sottkh] [int]  NULL,
	[Noidung] [varchar](300) NULL,
	[Phiphat] [int] NULL,
	[Thoigianlapphieu] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Sottpp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Themuonsach]    Script Date: 1/17/2022 2:44:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Themuonsach](
	[Sotttms] [int] IDENTITY(1,1) NOT NULL,
	
	[Tensachmuon] [nvarchar](200) NULL,
	[Soluongsachmuon] [int] NULL,
	[Sottnv] [int] NULL,
	[Sottkh] [int] NULL,
	[Thoigianlapthe] [datetime] NULL,
	[Thoigianmuonsach] [datetime] NULL,
	[Thoigiantrasach] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Sottms] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Bangkhosach]  WITH CHECK ADD FOREIGN KEY([Sottbs])
REFERENCES [dbo].[BangSach] ([Sottbs])
GO
ALTER TABLE [dbo].[Bangkhosach]  WITH CHECK ADD FOREIGN KEY([Sotttg])
REFERENCES [dbo].[Bangtacgia] ([Sotttg])
GO
ALTER TABLE [dbo].[Bangnhanvien]  WITH CHECK ADD FOREIGN KEY([Sottcv])
REFERENCES [dbo].[Bangchucvu] ([Sottcv])
GO
ALTER TABLE [dbo].[Hoadon]  WITH CHECK ADD FOREIGN KEY([Sottkh])
REFERENCES [dbo].[Bangkhachhang] ([Sottkh])
GO
ALTER TABLE [dbo].[Hoadon]  WITH CHECK ADD FOREIGN KEY([Sottbs])
REFERENCES [dbo].[BangSach] ([Sottbs])
GO
ALTER TABLE [dbo].[Phieuphat]  WITH CHECK ADD FOREIGN KEY([Sottkh])
REFERENCES [dbo].[Bangkhachhang] ([Sottkh])
GO
ALTER TABLE [dbo].[Themuonsach]  WITH CHECK ADD FOREIGN KEY([Sottkh])
REFERENCES [dbo].[Bangkhachhang] ([Sottkh])
GO
