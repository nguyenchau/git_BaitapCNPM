USE [QLD]
GO
/****** Object:  StoredProcedure [dbo].[BangdiemHP]    Script Date: 29/05/2017 3:13:27 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[BangdiemHP]
(
	@MaLop nvarchar(50),
	@MaHP nvarchar(50)
)
as
begin
	select SinhVien.MaSV, SinhVien.HoTen, SinhVien.NgaySinh, DiemHP.DiemCC, DiemHP.DiemGK, DiemHP.DiemCK
	from SinhVien inner join DiemHP on SinhVien.MaSV=DiemHP.MaSV
	where SinhVien.MaLop=@MaLop and DiemHP.MaHP=@MaHP
end
GO
/****** Object:  StoredProcedure [dbo].[DiemHP_Insert]    Script Date: 29/05/2017 3:13:27 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DiemHP_Insert] (@MaHP nvarchar (50), @MaSV
nvarchar (50))
as
begin
	Insert into DiemHP(MaHP,MaSV) values (@MaHP,@MaSV)
end

GO
/****** Object:  StoredProcedure [dbo].[DiemHP_Search]    Script Date: 29/05/2017 3:13:27 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DiemHP_Search](
@MaHP nvarchar(50),
@MaSV nvarchar(50)
)
as
begin
	select * from DiemHP where MaHP=@MaHP and MaSV=@MaSV
end
GO
/****** Object:  StoredProcedure [dbo].[DiemHP_UpdateLan1]    Script Date: 29/05/2017 3:13:27 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DiemHP_UpdateLan1]
(
	@DiemCC float,
	@MaHP nvarchar(50),
	@MaSV nvarchar(50)
)
as
begin
	update DiemHP set DiemCC=@DiemCC Where MaHP=@MaHP and MaSV=@MaSV
end
GO
/****** Object:  StoredProcedure [dbo].[DiemHP_UpdateLan2]    Script Date: 29/05/2017 3:13:27 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DiemHP_UpdateLan2]
(
	@DiemGK float,
	@MaHP nvarchar(50),
	@MaSV nvarchar(50)
)
as
begin
	update DiemHP set DiemGK=@DiemGK Where MaHP=@MaHP and MaSV=@MaSV
end
GO
/****** Object:  StoredProcedure [dbo].[DiemHP_UpdateLan3]    Script Date: 29/05/2017 3:13:27 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DiemHP_UpdateLan3]
(
	@DiemCK float,
	@MaHP nvarchar(50),
	@MaSV nvarchar(50)
)
as
begin
	update DiemHP set DiemCK=@DiemCK Where MaHP=@MaHP and MaSV=@MaSV
end
GO
/****** Object:  StoredProcedure [dbo].[HocKy_Delete]    Script Date: 29/05/2017 3:13:27 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[HocKy_Delete]
(
	@MaHocKy nvarchar(50)
	
)
as
begin
	Delete from HocKy  Where MaHocKy=@MaHocKy 
end
GO
/****** Object:  StoredProcedure [dbo].[HocKy_Insert]    Script Date: 29/05/2017 3:13:27 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[HocKy_Insert]
(
	@MaHocKy nvarchar(50),
	@TenHocKy nvarchar(100)
)
as
begin
	insert into HocKy values (@MaHocKy, @TenHocKy)
end
GO
/****** Object:  StoredProcedure [dbo].[HocKy_SelectAll]    Script Date: 29/05/2017 3:13:27 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[HocKy_SelectAll]
as
begin
	select * from HocKy
end
GO
/****** Object:  StoredProcedure [dbo].[HocKy_Update]    Script Date: 29/05/2017 3:13:27 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[HocKy_Update]
(
	@MaHocKy nvarchar(50),
	@TenHocKy nvarchar(100)
)
as
begin
	update HocKy set TenHocKy=@TenHocKy Where MaHocKy=@MaHocKy 
end
GO
/****** Object:  StoredProcedure [dbo].[ketqua_selectAll]    Script Date: 29/05/2017 3:13:27 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ketqua_selectAll]
 as
 begin
 select * from Ketqua
 end
GO
/****** Object:  StoredProcedure [dbo].[Lop_Update]    Script Date: 29/05/2017 3:13:27 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Lop_Update]
( @MaLop nvarchar(50),
@TenLop nvarchar(100),
@GiaoVienChuNhiem nvarchar(50),
@Khoa nvarchar (50)
)
as
begin 
	update  Lops set TenLop= @TenLop,GiaoVienChuNhiem= @GiaoVienChuNhiem,Khoa= @Khoa where MaLop = @MaLop 
end
GO
/****** Object:  StoredProcedure [dbo].[Lops_Delete]    Script Date: 29/05/2017 3:13:27 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Lops_Delete](
@MaLop nvarchar(50)
)
as
Begin
	delete from Lops  where MaLop=@MaLop
end
GO
/****** Object:  StoredProcedure [dbo].[Lops_Insert]    Script Date: 29/05/2017 3:13:27 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Lops_Insert]
( @MaLop nvarchar(50),
@TenLop nvarchar(100),
@GiaoVienChuNhiem nvarchar(50),
@Khoa nvarchar (50)
)
as
begin 
	insert into Lops values (@MaLop , @TenLop, @GiaoVienChuNhiem, @Khoa)
end
GO
/****** Object:  StoredProcedure [dbo].[Lops_SelectAll]    Script Date: 29/05/2017 3:13:27 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Lops_SelectAll]
as
Begin
	select * from Lops
end
GO
/****** Object:  StoredProcedure [dbo].[MonHP_Delete]    Script Date: 29/05/2017 3:13:27 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[MonHP_Delete] (@MaHP nvarchar (50)
)
as
begin
	delete from MonHP  where MaHP=@MaHP
end

GO
/****** Object:  StoredProcedure [dbo].[MonHP_Insert]    Script Date: 29/05/2017 3:13:27 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[MonHP_Insert] (@MaHP nvarchar (50),
@TenHP nvarchar(100),
@SoTinChi int,
@MaHocKy nvarchar(50))
as
begin
	insert into MonHP values (@MaHP,@TenHP,@SoTinChi,@MaHocKy)
end

GO
/****** Object:  StoredProcedure [dbo].[MonHP_SelectAll]    Script Date: 29/05/2017 3:13:27 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[MonHP_SelectAll]
as
begin
	select * from MonHP
end
GO
/****** Object:  StoredProcedure [dbo].[MonHP_SelectMaHocKy]    Script Date: 29/05/2017 3:13:27 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[MonHP_SelectMaHocKy](@MaHocKy nvarchar (50))
as
begin
	select * from MonHP where MaHocKy= @MaHocKy
end

GO
/****** Object:  StoredProcedure [dbo].[MonHP_Update]    Script Date: 29/05/2017 3:13:27 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[MonHP_Update] (@MaHP nvarchar (50),
@TenHP nvarchar(100),
@SoTinChi int
)
as
begin
	update MonHP set TenHP=@TenHP,SoTinChi=@SoTinChi where MaHP=@MaHP
end

GO
/****** Object:  StoredProcedure [dbo].[SinhVien_Delete]    Script Date: 29/05/2017 3:13:27 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SinhVien_Delete](
@MaSV nvarchar(50)
)

as
begin
	Delete from SinhVien
	where MaSV=@MaSV
end
GO
/****** Object:  StoredProcedure [dbo].[Sinhvien_Deletes]    Script Date: 29/05/2017 3:13:27 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Sinhvien_Deletes]
(
@MaSV nvarchar(50)

)
as
begin
	delete from SinhVien 
where MaSV=@MaSV
end
GO
/****** Object:  StoredProcedure [dbo].[SinhVien_Insert]    Script Date: 29/05/2017 3:13:27 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SinhVien_Insert](
@MaSV nvarchar(50),
@HoTen nchar(50),

@NgaySinh datetime,
@GioiTinh int,
@DanToc nvarchar(50),
@NoiSinh nvarchar(100),
@MaLop nvarchar(50)
)
as
begin
	Insert into SinhVien values (@MaSV,@HoTen,@NgaySinh,@GioiTinh,@DanToc,@NoiSinh,@MaLop)
end
GO
/****** Object:  StoredProcedure [dbo].[Sinhvien_Inserts]    Script Date: 29/05/2017 3:13:27 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Sinhvien_Inserts]
(
@MaSV nvarchar(50),
@HoTen nchar(50),
@NgaySinh datetime,
@GioiTinh int,
@DanToc nvarchar(50),
@NoiSinh nvarchar(100),
@MaLop nvarchar(50),
@Email nvarchar(50),
@Sdt nvarchar(50),
@DiaChi nvarchar(50)
)
as
begin
	Insert into SinhVien values (@MaSV,@HoTen,@NgaySinh,@GioiTinh,@DanToc,@NoiSinh,@MaLop,@Email,@Sdt,@DiaChi)
end
GO
/****** Object:  StoredProcedure [dbo].[Sinhvien_Insertsss]    Script Date: 29/05/2017 3:13:27 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Sinhvien_Insertsss]
(
@MaSV nvarchar(50),
@HoTen nchar(50),
@NgaySinh datetime,
@GioiTinh int,
@DanToc nvarchar(50),
@NoiSinh nvarchar(100),
@MaLop nvarchar(50),
@Email nvarchar(50),
@Sdt nvarchar(50),
@DiaChi nvarchar(50)
)
as
begin
	Insert into SinhVien
	 values (@MaSV,@HoTen,@NgaySinh,@GioiTinh,@DanToc,@NoiSinh,@MaLop,@Email,@Sdt,@DiaChi)
end
GO
/****** Object:  StoredProcedure [dbo].[SinhVien_Search]    Script Date: 29/05/2017 3:13:27 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SinhVien_Search](
@HoTen nchar(50),
@MaLop nvarchar(50)
)

as
begin
	Select * from SinhVien
	where HoTen LIKE '%@HoTen%'and MaLop=@MaLop
end
GO
/****** Object:  StoredProcedure [dbo].[SinhVien_SelectAll]    Script Date: 29/05/2017 3:13:27 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SinhVien_SelectAll]
as
begin
	select * from SinhVien
end
GO
/****** Object:  StoredProcedure [dbo].[SinhVien_selectMalop]    Script Date: 29/05/2017 3:13:27 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SinhVien_selectMalop](
@malop nvarchar(50)
)
as
begin
	select * from SinhVien where MaLop=@malop
end
GO
/****** Object:  StoredProcedure [dbo].[Sinhvien_selectMalops]    Script Date: 29/05/2017 3:13:27 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Sinhvien_selectMalops]

as
begin 
	select * from SinhVien
end
GO
/****** Object:  StoredProcedure [dbo].[Sinhvien_selectMasv]    Script Date: 29/05/2017 3:13:27 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Sinhvien_selectMasv]
(
@MaSV nvarchar(50)
)
as
begin
	select * from SinhVien where MaSV=@MaSV
	end
GO
/****** Object:  StoredProcedure [dbo].[SinhVien_Update]    Script Date: 29/05/2017 3:13:27 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SinhVien_Update](
@MaSV nvarchar(50),
@HoTen nchar(50),

@NgaySinh datetime,
@GioiTinh int,
@DanToc nvarchar(50),
@NoiSinh nvarchar(100)
)
as
begin
	update SinhVien set MaSV=@MaSV,HoTen=@HoTen,NgaySinh=@NgaySinh,GioiTinh=@GioiTinh,DanToc=@DanToc,NoiSinh=@NoiSinh
	where MaSV=@MaSV
end
GO
/****** Object:  StoredProcedure [dbo].[Sinhvien_Updatenew]    Script Date: 29/05/2017 3:13:27 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Sinhvien_Updatenew]
(@MaSV nvarchar(50),
@HoTen nchar(50),

@NgaySinh datetime,
@GioiTinh int,
@DanToc nvarchar(50),
@NoiSinh nvarchar(100),
@Email nvarchar(50),
@Sdt nvarchar(50),
@DiaChi nvarchar(50)
)
as
begin
	update SinhVien set HoTen=@HoTen,NgaySinh=@NgaySinh,
	GioiTinh=@GioiTinh,DanToc=@DanToc,NoiSinh=@NoiSinh,Email=@Email,Sdt=@Sdt,DiaChi=@DiaChi
	where MaSV=@MaSV
end
GO
/****** Object:  StoredProcedure [dbo].[Sinhvien_Updates]    Script Date: 29/05/2017 3:13:27 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Sinhvien_Updates]
(
@MaSV nvarchar(50),
@HoTen nchar(50),
@NgaySinh datetime,
@GioiTinh int,
@DanToc nvarchar(50),
@NoiSinh nvarchar(100),
@Email nvarchar(50),
@Sdt nvarchar(50),
@DiaChi nvarchar(50)
)
as
begin
	update SinhVien set HoTen= @HoTen,NgaySinh= @NgaySinh,GioiTinh= @GioiTinh,DanToc= @DanToc,NoiSinh= @NoiSinh,Email= @Email,Sdt= @Sdt,DiaChi= @DiaChi
where MaSV=@MaSV
end
GO
/****** Object:  StoredProcedure [dbo].[Sinhvien_Updatess]    Script Date: 29/05/2017 3:13:27 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[Sinhvien_Updatess]
(@MaSV nvarchar(50),
@HoTen nchar(50),
@MaLop nvarchar(50),
@NgaySinh datetime,
@GioiTinh int,
@DanToc nvarchar(50),
@NoiSinh nvarchar(100)
)
as
begin
	update SinhVien set MaSV=@MaSV,HoTen=@HoTen,MaLop=@MaLop,NgaySinh=@NgaySinh,GioiTinh=@GioiTinh,DanToc=@DanToc,NoiSinh=@NoiSinh
	where MaSV=@MaSV
end
GO
/****** Object:  StoredProcedure [dbo].[Sinhvien_Updatesss]    Script Date: 29/05/2017 3:13:27 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Sinhvien_Updatesss]
(@MaSV nvarchar(50),
@HoTen nchar(50),
@MaLop nvarchar(50),
@NgaySinh datetime,
@GioiTinh int,
@DanToc nvarchar(50),
@NoiSinh nvarchar(100),
@Email nvarchar(50),
@Sdt nvarchar(50),
@DiaChi nvarchar(50)
)
as
begin
	update SinhVien set HoTen=@HoTen,MaLop=@MaLop,NgaySinh=@NgaySinh,
	GioiTinh=@GioiTinh,DanToc=@DanToc,NoiSinh=@NoiSinh,Email=@Email,Sdt=@Sdt,DiaChi=@DiaChi
	where MaSV=@MaSV
end
GO
/****** Object:  StoredProcedure [dbo].[Sinhvien_Updatessss]    Script Date: 29/05/2017 3:13:27 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Sinhvien_Updatessss]
(@MaSV nvarchar(50),
@HoTen nchar(50),
@MaLop nvarchar(50),
@NgaySinh datetime,
@GioiTinh int,
@DanToc nvarchar(50),
@NoiSinh nvarchar(100),
@Email nvarchar(50),
@Sdt nvarchar(50),
@DiaChi nvarchar(50)
)
as
begin
	update SinhVien set HoTen=@HoTen,NgaySinh=@NgaySinh,
	GioiTinh=@GioiTinh,DanToc=@DanToc,NoiSinh=@NoiSinh,Email=@Email,Sdt=@Sdt,DiaChi=@DiaChi
	where MaSV=@MaSV
end
GO
/****** Object:  Table [dbo].[DangNhap]    Script Date: 29/05/2017 3:13:27 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DangNhap](
	[username] [nvarchar](50) NULL,
	[password] [nvarchar](50) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DiemHP]    Script Date: 29/05/2017 3:13:27 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DiemHP](
	[MaSV] [nvarchar](50) NOT NULL,
	[MaHP] [nvarchar](50) NOT NULL,
	[DiemCC] [float] NULL,
	[DiemGK] [float] NULL,
	[DiemCK] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HocKy]    Script Date: 29/05/2017 3:13:27 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HocKy](
	[MaHocKy] [nvarchar](50) NOT NULL,
	[TenHocKy] [nvarchar](100) NULL,
 CONSTRAINT [PK_HocKy] PRIMARY KEY CLUSTERED 
(
	[MaHocKy] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Ketqua]    Script Date: 29/05/2017 3:13:27 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ketqua](
	[MaSV] [nvarchar](50) NULL,
	[HoTen] [nchar](50) NULL,
	[MaLop] [nvarchar](50) NULL,
	[MaHP] [nvarchar](50) NULL,
	[DiemCC] [float] NULL,
	[DiemGK] [float] NULL,
	[DiemCK] [float] NULL,
	[DiemHP] [float] NULL,
	[DiemChu] [nchar](10) NULL,
	[DiemSo] [int] NULL,
	[TenHP] [nvarchar](100) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Lops]    Script Date: 29/05/2017 3:13:27 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lops](
	[MaLop] [nvarchar](50) NOT NULL,
	[TenLop] [nvarchar](100) NULL,
	[GiaoVienChuNhiem] [nvarchar](50) NULL,
	[Khoa] [nvarchar](50) NULL,
 CONSTRAINT [PK_Lops] PRIMARY KEY CLUSTERED 
(
	[MaLop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MonHP]    Script Date: 29/05/2017 3:13:27 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MonHP](
	[MaHP] [nvarchar](50) NOT NULL,
	[TenHP] [nvarchar](100) NULL,
	[SoTinChi] [int] NULL,
	[MaHocKy] [nvarchar](50) NOT NULL,
	[DiemHP] [real] NULL,
 CONSTRAINT [PK_MonHP] PRIMARY KEY CLUSTERED 
(
	[MaHP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SinhVien]    Script Date: 29/05/2017 3:13:27 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SinhVien](
	[MaSV] [nvarchar](50) NOT NULL,
	[HoTen] [nchar](50) NULL,
	[NgaySinh] [datetime] NULL,
	[GioiTinh] [int] NULL,
	[DanToc] [nvarchar](50) NULL,
	[NoiSinh] [nvarchar](100) NULL,
	[MaLop] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NULL,
	[Sdt] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](100) NULL,
 CONSTRAINT [PK_SinhVien] PRIMARY KEY CLUSTERED 
(
	[MaSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[DiemHP]  WITH CHECK ADD  CONSTRAINT [FK_DiemHP_MonHP] FOREIGN KEY([MaHP])
REFERENCES [dbo].[MonHP] ([MaHP])
GO
ALTER TABLE [dbo].[DiemHP] CHECK CONSTRAINT [FK_DiemHP_MonHP]
GO
ALTER TABLE [dbo].[DiemHP]  WITH CHECK ADD  CONSTRAINT [FK_DiemHP_SinhVien] FOREIGN KEY([MaSV])
REFERENCES [dbo].[SinhVien] ([MaSV])
GO
ALTER TABLE [dbo].[DiemHP] CHECK CONSTRAINT [FK_DiemHP_SinhVien]
GO
ALTER TABLE [dbo].[Ketqua]  WITH CHECK ADD  CONSTRAINT [FK_Ketqua_Lops] FOREIGN KEY([MaLop])
REFERENCES [dbo].[Lops] ([MaLop])
GO
ALTER TABLE [dbo].[Ketqua] CHECK CONSTRAINT [FK_Ketqua_Lops]
GO
ALTER TABLE [dbo].[Ketqua]  WITH CHECK ADD  CONSTRAINT [FK_Ketqua_MonHP] FOREIGN KEY([MaHP])
REFERENCES [dbo].[MonHP] ([MaHP])
GO
ALTER TABLE [dbo].[Ketqua] CHECK CONSTRAINT [FK_Ketqua_MonHP]
GO
ALTER TABLE [dbo].[Ketqua]  WITH CHECK ADD  CONSTRAINT [FK_Ketqua_SinhVien] FOREIGN KEY([MaSV])
REFERENCES [dbo].[SinhVien] ([MaSV])
GO
ALTER TABLE [dbo].[Ketqua] CHECK CONSTRAINT [FK_Ketqua_SinhVien]
GO
ALTER TABLE [dbo].[MonHP]  WITH CHECK ADD  CONSTRAINT [FK_MonHP_HocKy] FOREIGN KEY([MaHocKy])
REFERENCES [dbo].[HocKy] ([MaHocKy])
GO
ALTER TABLE [dbo].[MonHP] CHECK CONSTRAINT [FK_MonHP_HocKy]
GO
ALTER TABLE [dbo].[SinhVien]  WITH CHECK ADD  CONSTRAINT [FK_SinhVien_Lops] FOREIGN KEY([MaLop])
REFERENCES [dbo].[Lops] ([MaLop])
GO
ALTER TABLE [dbo].[SinhVien] CHECK CONSTRAINT [FK_SinhVien_Lops]
GO
