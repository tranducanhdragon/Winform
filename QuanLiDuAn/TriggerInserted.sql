select * from SUDUNGDICHVU
create proc SuDungDichVu_Insert(
    @TenDangNhap nvarchar(200),
	@MaNV nchar(100),
	@MaDV nchar(100),
	@MaHD nchar(100),
	@SoLuong int
)
as
begin
    insert into SUDUNGDICHVU
	values(@TenDangNhap, @MaNV, @MaDV, @MaHD, @SoLuong)
end
--Tạo trigger insert cho bảng DichVu
create trigger DichVu_Inserted on SuDungDichVu after insert as
begin
    update DICHVU
	set DichVu.SoLuong = DichVu.SoLuong - 
	(select top(1) SUDUNGDICHVU.SoLuong from SUDUNGDICHVU join DICHVU on SuDungDichVu.MaDV = DICHVU.MaDV order by ID desc)
	from DICHVU join SUDUNGDICHVU on DICHVU.MaDV = SUDUNGDICHVU.MaDV
end
drop trigger DichVu_Inserted
exec SuDungDichVu_Insert 'ducanh', 'NV01', '5', '0', 1
select * from DICHVU