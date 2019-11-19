USE [master]
GO
/****** Object:  Database [SatinAlma]    Script Date: 20.11.2019 00:14:19 ******/
CREATE DATABASE [SatinAlma]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SatinAlma', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLSERVER2017EXP\MSSQL\DATA\SatinAlma.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SatinAlma_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLSERVER2017EXP\MSSQL\DATA\SatinAlma_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [SatinAlma] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SatinAlma].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SatinAlma] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SatinAlma] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SatinAlma] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SatinAlma] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SatinAlma] SET ARITHABORT OFF 
GO
ALTER DATABASE [SatinAlma] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SatinAlma] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SatinAlma] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SatinAlma] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SatinAlma] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SatinAlma] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SatinAlma] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SatinAlma] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SatinAlma] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SatinAlma] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SatinAlma] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SatinAlma] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SatinAlma] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SatinAlma] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SatinAlma] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SatinAlma] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SatinAlma] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SatinAlma] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SatinAlma] SET  MULTI_USER 
GO
ALTER DATABASE [SatinAlma] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SatinAlma] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SatinAlma] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SatinAlma] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SatinAlma] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'SatinAlma', N'ON'
GO
ALTER DATABASE [SatinAlma] SET QUERY_STORE = OFF
GO
USE [SatinAlma]
GO
/****** Object:  Table [dbo].[Departmanlar]    Script Date: 20.11.2019 00:14:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Departmanlar](
	[DepartmanID] [int] IDENTITY(1,1) NOT NULL,
	[Adi] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Departmanlar] PRIMARY KEY CLUSTERED 
(
	[DepartmanID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kategoriler]    Script Date: 20.11.2019 00:14:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kategoriler](
	[KategoriID] [int] IDENTITY(1,1) NOT NULL,
	[Adi] [nvarchar](50) NOT NULL,
	[Aciklama] [nvarchar](150) NULL,
	[AktifMi] [bit] NULL,
 CONSTRAINT [PK_Kategoriler] PRIMARY KEY CLUSTERED 
(
	[KategoriID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Personeller]    Script Date: 20.11.2019 00:14:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personeller](
	[PersonelID] [int] IDENTITY(1,1) NOT NULL,
	[Adi] [nvarchar](50) NOT NULL,
	[SoyAdi] [nvarchar](50) NOT NULL,
	[TCKN] [char](11) NOT NULL,
	[Gorevi] [nvarchar](50) NOT NULL,
	[DepartmanID] [int] NOT NULL,
	[IseGirisTarihi] [date] NOT NULL,
	[TelNo] [char](14) NULL,
	[KullaniciAdi] [nvarchar](50) NOT NULL,
	[Parola] [nvarchar](50) NOT NULL,
	[AlisYetkiliMi] [bit] NULL,
	[AktifMi] [bit] NULL,
 CONSTRAINT [PK_Personeller] PRIMARY KEY CLUSTERED 
(
	[PersonelID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SatinAlmaDetay]    Script Date: 20.11.2019 00:14:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SatinAlmaDetay](
	[UrunID] [int] NOT NULL,
	[SatinAlimID] [int] NOT NULL,
	[DurumID] [int] NOT NULL,
	[AlinmaTarihi] [date] NULL,
	[Fiyat] [money] NULL,
	[Adet] [float] NULL,
 CONSTRAINT [PK_SatinAlmaDetay] PRIMARY KEY CLUSTERED 
(
	[UrunID] ASC,
	[SatinAlimID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SiparisDurumu]    Script Date: 20.11.2019 00:14:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SiparisDurumu](
	[DurumID] [int] IDENTITY(1,1) NOT NULL,
	[SiparisDurum] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_SiparisDurumu] PRIMARY KEY CLUSTERED 
(
	[DurumID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tedarikciler]    Script Date: 20.11.2019 00:14:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tedarikciler](
	[TedarikciID] [int] IDENTITY(1,1) NOT NULL,
	[SirketAdi] [nvarchar](50) NOT NULL,
	[Adres] [nvarchar](500) NOT NULL,
	[Sehir] [nvarchar](50) NOT NULL,
	[TelNo] [nvarchar](14) NOT NULL,
	[AktifMi] [bit] NULL,
 CONSTRAINT [PK_Tedarikciler] PRIMARY KEY CLUSTERED 
(
	[TedarikciID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Urunler]    Script Date: 20.11.2019 00:14:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Urunler](
	[UrunID] [int] IDENTITY(1,1) NOT NULL,
	[Adi] [nvarchar](50) NOT NULL,
	[Fiyat] [money] NOT NULL,
	[Stok] [smallint] NOT NULL,
	[TedarikciID] [int] NULL,
	[KategoriID] [int] NULL,
	[AktifMi] [bit] NULL,
 CONSTRAINT [PK_Urunler] PRIMARY KEY CLUSTERED 
(
	[UrunID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UrunSatinAlim]    Script Date: 20.11.2019 00:14:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UrunSatinAlim](
	[SatinAlimID] [int] IDENTITY(1,1) NOT NULL,
	[PersonelID] [int] NULL,
	[TedarikciID] [int] NULL,
	[SatinAlimTarihi] [date] NULL,
	[NakliyeUcreti] [money] NOT NULL,
 CONSTRAINT [PK_UrunSatinAlim] PRIMARY KEY CLUSTERED 
(
	[SatinAlimID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Departmanlar] ON 

INSERT [dbo].[Departmanlar] ([DepartmanID], [Adi]) VALUES (1, N'Satın Alma')
INSERT [dbo].[Departmanlar] ([DepartmanID], [Adi]) VALUES (2, N'İnsan Kaynakları')
INSERT [dbo].[Departmanlar] ([DepartmanID], [Adi]) VALUES (3, N'Bilgi İşlem')
INSERT [dbo].[Departmanlar] ([DepartmanID], [Adi]) VALUES (4, N'Halkla İlişkiler')
INSERT [dbo].[Departmanlar] ([DepartmanID], [Adi]) VALUES (7, N'Yazılım Geliştirme')
INSERT [dbo].[Departmanlar] ([DepartmanID], [Adi]) VALUES (8, N'Ulaştırma')
INSERT [dbo].[Departmanlar] ([DepartmanID], [Adi]) VALUES (9, N'Muhaberat')
SET IDENTITY_INSERT [dbo].[Departmanlar] OFF
SET IDENTITY_INSERT [dbo].[Kategoriler] ON 

INSERT [dbo].[Kategoriler] ([KategoriID], [Adi], [Aciklama], [AktifMi]) VALUES (1, N'Çikolata', N'Sütlü  , Bitter vs...', NULL)
INSERT [dbo].[Kategoriler] ([KategoriID], [Adi], [Aciklama], [AktifMi]) VALUES (2, N'Bisküvi', N'Yulaflı,Fındıklı', NULL)
INSERT [dbo].[Kategoriler] ([KategoriID], [Adi], [Aciklama], [AktifMi]) VALUES (3, N'Süt', N'Sade,Çikolatalı,Çilekli,Yağlı,Yağsız', NULL)
SET IDENTITY_INSERT [dbo].[Kategoriler] OFF
SET IDENTITY_INSERT [dbo].[Personeller] ON 

INSERT [dbo].[Personeller] ([PersonelID], [Adi], [SoyAdi], [TCKN], [Gorevi], [DepartmanID], [IseGirisTarihi], [TelNo], [KullaniciAdi], [Parola], [AlisYetkiliMi], [AktifMi]) VALUES (12, N'Furkan', N'Yetişkin', N'12345685236', N'Satın Alma Müdürü', 1, CAST(N'2019-11-13' AS Date), N'(554) 120-2785', N'furkanyetiskin', N'13251325', 1, NULL)
INSERT [dbo].[Personeller] ([PersonelID], [Adi], [SoyAdi], [TCKN], [Gorevi], [DepartmanID], [IseGirisTarihi], [TelNo], [KullaniciAdi], [Parola], [AlisYetkiliMi], [AktifMi]) VALUES (13, N'Sercan', N'Yetişkin', N'12345678901', N'Satın Alma Personeli', 1, CAST(N'2019-11-13' AS Date), N'(532) 156-6613', N'sercanyetiskin', N'123456', 0, NULL)
INSERT [dbo].[Personeller] ([PersonelID], [Adi], [SoyAdi], [TCKN], [Gorevi], [DepartmanID], [IseGirisTarihi], [TelNo], [KullaniciAdi], [Parola], [AlisYetkiliMi], [AktifMi]) VALUES (16, N'Mert Ali', N'Yetişkin', N'74125863322', N'Junior Developer', 7, CAST(N'2019-11-11' AS Date), N'(123) 745-7558', N'mertaliyetiskin', N'654321', 0, NULL)
INSERT [dbo].[Personeller] ([PersonelID], [Adi], [SoyAdi], [TCKN], [Gorevi], [DepartmanID], [IseGirisTarihi], [TelNo], [KullaniciAdi], [Parola], [AlisYetkiliMi], [AktifMi]) VALUES (17, N'Nardan', N'Yetişkin', N'98765432102', N'İK Sorumlusu', 2, CAST(N'2019-11-13' AS Date), N'(539) 388-7081', N'nardanyetiskin', N'123456', 1, NULL)
SET IDENTITY_INSERT [dbo].[Personeller] OFF
INSERT [dbo].[SatinAlmaDetay] ([UrunID], [SatinAlimID], [DurumID], [AlinmaTarihi], [Fiyat], [Adet]) VALUES (1, 38, 3, CAST(N'2019-11-19' AS Date), 5.0000, 1)
SET IDENTITY_INSERT [dbo].[SiparisDurumu] ON 

INSERT [dbo].[SiparisDurumu] ([DurumID], [SiparisDurum]) VALUES (2, N'Reddedildi')
INSERT [dbo].[SiparisDurumu] ([DurumID], [SiparisDurum]) VALUES (3, N'Onaylandı')
SET IDENTITY_INSERT [dbo].[SiparisDurumu] OFF
SET IDENTITY_INSERT [dbo].[Tedarikciler] ON 

INSERT [dbo].[Tedarikciler] ([TedarikciID], [SirketAdi], [Adres], [Sehir], [TelNo], [AktifMi]) VALUES (1, N'Ülker', N'Ülker Mah. No:10', N'İstanbul', N'(212) 555-5555', NULL)
INSERT [dbo].[Tedarikciler] ([TedarikciID], [SirketAdi], [Adres], [Sehir], [TelNo], [AktifMi]) VALUES (2, N'Eti', N'Eti Mah. No:10', N'İstanbul', N'(212) 550-5050', NULL)
INSERT [dbo].[Tedarikciler] ([TedarikciID], [SirketAdi], [Adres], [Sehir], [TelNo], [AktifMi]) VALUES (3, N'Torku', N'Konya Mah. No:10', N'Konya', N'(212) 540-4040', NULL)
SET IDENTITY_INSERT [dbo].[Tedarikciler] OFF
SET IDENTITY_INSERT [dbo].[Urunler] ON 

INSERT [dbo].[Urunler] ([UrunID], [Adi], [Fiyat], [Stok], [TedarikciID], [KategoriID], [AktifMi]) VALUES (1, N'Çikolatalı Gofret', 1.0000, 89, 1, 1, NULL)
INSERT [dbo].[Urunler] ([UrunID], [Adi], [Fiyat], [Stok], [TedarikciID], [KategoriID], [AktifMi]) VALUES (2, N'Canga', 2.0000, 100, 2, 1, NULL)
INSERT [dbo].[Urunler] ([UrunID], [Adi], [Fiyat], [Stok], [TedarikciID], [KategoriID], [AktifMi]) VALUES (3, N'Banada', 5.0000, 50, 3, 1, NULL)
INSERT [dbo].[Urunler] ([UrunID], [Adi], [Fiyat], [Stok], [TedarikciID], [KategoriID], [AktifMi]) VALUES (4, N'Petibör', 3.0000, 187, 1, 2, NULL)
INSERT [dbo].[Urunler] ([UrunID], [Adi], [Fiyat], [Stok], [TedarikciID], [KategoriID], [AktifMi]) VALUES (5, N'Burçak', 2.5000, 3, 2, 2, NULL)
INSERT [dbo].[Urunler] ([UrunID], [Adi], [Fiyat], [Stok], [TedarikciID], [KategoriID], [AktifMi]) VALUES (6, N'Favorimo', 1.0000, 40, 3, 2, NULL)
INSERT [dbo].[Urunler] ([UrunID], [Adi], [Fiyat], [Stok], [TedarikciID], [KategoriID], [AktifMi]) VALUES (7, N'Sütaş', 2.0000, 80, 1, 3, NULL)
INSERT [dbo].[Urunler] ([UrunID], [Adi], [Fiyat], [Stok], [TedarikciID], [KategoriID], [AktifMi]) VALUES (8, N'SütEti', 3.0000, 65, 2, 3, NULL)
INSERT [dbo].[Urunler] ([UrunID], [Adi], [Fiyat], [Stok], [TedarikciID], [KategoriID], [AktifMi]) VALUES (9, N'Torku Süt', 4.0000, 4, 3, 3, NULL)
SET IDENTITY_INSERT [dbo].[Urunler] OFF
SET IDENTITY_INSERT [dbo].[UrunSatinAlim] ON 

INSERT [dbo].[UrunSatinAlim] ([SatinAlimID], [PersonelID], [TedarikciID], [SatinAlimTarihi], [NakliyeUcreti]) VALUES (38, 12, 1, CAST(N'2019-11-19' AS Date), 3.0000)
SET IDENTITY_INSERT [dbo].[UrunSatinAlim] OFF
SET ANSI_PADDING ON
GO
/****** Object:  Index [UNQ_Adi_Kategoriler]    Script Date: 20.11.2019 00:14:19 ******/
ALTER TABLE [dbo].[Kategoriler] ADD  CONSTRAINT [UNQ_Adi_Kategoriler] UNIQUE NONCLUSTERED 
(
	[Adi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UNQ_KullaniciAdi_Personeller]    Script Date: 20.11.2019 00:14:19 ******/
ALTER TABLE [dbo].[Personeller] ADD  CONSTRAINT [UNQ_KullaniciAdi_Personeller] UNIQUE NONCLUSTERED 
(
	[KullaniciAdi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UNQ_TCKN_Personeller]    Script Date: 20.11.2019 00:14:19 ******/
ALTER TABLE [dbo].[Personeller] ADD  CONSTRAINT [UNQ_TCKN_Personeller] UNIQUE NONCLUSTERED 
(
	[TCKN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UNQ_TelNo_Personeller]    Script Date: 20.11.2019 00:14:19 ******/
ALTER TABLE [dbo].[Personeller] ADD  CONSTRAINT [UNQ_TelNo_Personeller] UNIQUE NONCLUSTERED 
(
	[TelNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UNQ_SirketAdi_Tedarikciler]    Script Date: 20.11.2019 00:14:19 ******/
ALTER TABLE [dbo].[Tedarikciler] ADD  CONSTRAINT [UNQ_SirketAdi_Tedarikciler] UNIQUE NONCLUSTERED 
(
	[SirketAdi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UNQ_TelNo_Tedarikciler]    Script Date: 20.11.2019 00:14:19 ******/
ALTER TABLE [dbo].[Tedarikciler] ADD  CONSTRAINT [UNQ_TelNo_Tedarikciler] UNIQUE NONCLUSTERED 
(
	[TelNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UNQ_Adi_Urunler]    Script Date: 20.11.2019 00:14:19 ******/
ALTER TABLE [dbo].[Urunler] ADD  CONSTRAINT [UNQ_Adi_Urunler] UNIQUE NONCLUSTERED 
(
	[Adi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Kategoriler] ADD  CONSTRAINT [DF_Kategoriler_AktifMi]  DEFAULT ((1)) FOR [AktifMi]
GO
ALTER TABLE [dbo].[Personeller] ADD  CONSTRAINT [DF_Personeller_AlisYetkiliMi]  DEFAULT ((0)) FOR [AlisYetkiliMi]
GO
ALTER TABLE [dbo].[Personeller] ADD  CONSTRAINT [DF_Personeller_AktifMi]  DEFAULT ((1)) FOR [AktifMi]
GO
ALTER TABLE [dbo].[Tedarikciler] ADD  CONSTRAINT [DF_Tedarikciler_AktifMi]  DEFAULT ((1)) FOR [AktifMi]
GO
ALTER TABLE [dbo].[Urunler] ADD  CONSTRAINT [DF_Urunler_AktifMi]  DEFAULT ((1)) FOR [AktifMi]
GO
ALTER TABLE [dbo].[UrunSatinAlim] ADD  CONSTRAINT [DF_UrunSatinAlim_SatinAlimTarihi]  DEFAULT (getdate()) FOR [SatinAlimTarihi]
GO
ALTER TABLE [dbo].[Personeller]  WITH CHECK ADD  CONSTRAINT [FK_Personeller_Departmanlar] FOREIGN KEY([DepartmanID])
REFERENCES [dbo].[Departmanlar] ([DepartmanID])
GO
ALTER TABLE [dbo].[Personeller] CHECK CONSTRAINT [FK_Personeller_Departmanlar]
GO
ALTER TABLE [dbo].[SatinAlmaDetay]  WITH CHECK ADD  CONSTRAINT [FK_SatinAlmaDetay_SiparisDurumu] FOREIGN KEY([DurumID])
REFERENCES [dbo].[SiparisDurumu] ([DurumID])
GO
ALTER TABLE [dbo].[SatinAlmaDetay] CHECK CONSTRAINT [FK_SatinAlmaDetay_SiparisDurumu]
GO
ALTER TABLE [dbo].[SatinAlmaDetay]  WITH CHECK ADD  CONSTRAINT [FK_SatinAlmaDetay_Urunler] FOREIGN KEY([UrunID])
REFERENCES [dbo].[Urunler] ([UrunID])
GO
ALTER TABLE [dbo].[SatinAlmaDetay] CHECK CONSTRAINT [FK_SatinAlmaDetay_Urunler]
GO
ALTER TABLE [dbo].[SatinAlmaDetay]  WITH CHECK ADD  CONSTRAINT [FK_SatinAlmaDetay_UrunSatinAlim] FOREIGN KEY([SatinAlimID])
REFERENCES [dbo].[UrunSatinAlim] ([SatinAlimID])
GO
ALTER TABLE [dbo].[SatinAlmaDetay] CHECK CONSTRAINT [FK_SatinAlmaDetay_UrunSatinAlim]
GO
ALTER TABLE [dbo].[Urunler]  WITH CHECK ADD  CONSTRAINT [FK_Urunler_Kategoriler] FOREIGN KEY([KategoriID])
REFERENCES [dbo].[Kategoriler] ([KategoriID])
GO
ALTER TABLE [dbo].[Urunler] CHECK CONSTRAINT [FK_Urunler_Kategoriler]
GO
ALTER TABLE [dbo].[Urunler]  WITH CHECK ADD  CONSTRAINT [FK_Urunler_Tedarikciler] FOREIGN KEY([TedarikciID])
REFERENCES [dbo].[Tedarikciler] ([TedarikciID])
GO
ALTER TABLE [dbo].[Urunler] CHECK CONSTRAINT [FK_Urunler_Tedarikciler]
GO
ALTER TABLE [dbo].[UrunSatinAlim]  WITH CHECK ADD  CONSTRAINT [FK_UrunSatinAlim_Personeller] FOREIGN KEY([PersonelID])
REFERENCES [dbo].[Personeller] ([PersonelID])
GO
ALTER TABLE [dbo].[UrunSatinAlim] CHECK CONSTRAINT [FK_UrunSatinAlim_Personeller]
GO
ALTER TABLE [dbo].[UrunSatinAlim]  WITH CHECK ADD  CONSTRAINT [FK_UrunSatinAlim_Tedarikciler] FOREIGN KEY([TedarikciID])
REFERENCES [dbo].[Tedarikciler] ([TedarikciID])
GO
ALTER TABLE [dbo].[UrunSatinAlim] CHECK CONSTRAINT [FK_UrunSatinAlim_Tedarikciler]
GO
ALTER TABLE [dbo].[Personeller]  WITH CHECK ADD  CONSTRAINT [CK_Personeller_IseGirisTarihi] CHECK  (([IseGirisTarihi]<getdate()))
GO
ALTER TABLE [dbo].[Personeller] CHECK CONSTRAINT [CK_Personeller_IseGirisTarihi]
GO
ALTER TABLE [dbo].[SatinAlmaDetay]  WITH CHECK ADD  CONSTRAINT [CK_SatinAlinmisUrunler_AlinmaTarihi] CHECK  (([AlinmaTarihi]<getdate()))
GO
ALTER TABLE [dbo].[SatinAlmaDetay] CHECK CONSTRAINT [CK_SatinAlinmisUrunler_AlinmaTarihi]
GO
ALTER TABLE [dbo].[UrunSatinAlim]  WITH CHECK ADD  CONSTRAINT [CK_UrunSatinAlim_SatinAlimTarihi] CHECK  (([SatinAlimTarihi]<getdate()))
GO
ALTER TABLE [dbo].[UrunSatinAlim] CHECK CONSTRAINT [CK_UrunSatinAlim_SatinAlimTarihi]
GO
/****** Object:  StoredProcedure [dbo].[prc_PersonelGiris]    Script Date: 20.11.2019 00:14:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[prc_PersonelGiris]
@ka nvarchar(50),
@prl nvarchar(15)
as
select * from Personeller where	 KullaniciAdi=@ka and Parola=@prl
GO
USE [master]
GO
ALTER DATABASE [SatinAlma] SET  READ_WRITE 
GO
