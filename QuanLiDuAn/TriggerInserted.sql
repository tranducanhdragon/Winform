--select * from SUDUNGDICHVU
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
--Tạo trigger insert Dịch vụ nếu trùng tên dịch vụ thì ko đc insert
alter trigger DichVu_Insert on DichVu for insert
as
begin
	if(select count(DichVu.TenDV) from DICHVU right join inserted on DICHVU.TenDV = inserted.TenDV) > 1
	begin
	    print(N'Tên dịch vụ đã tồn tại')
		rollback tran
	end
end
insert into DichVu values('8','Nem chua rán','Đồ ăn',8000, 10)
select * from DichVu
--tạo trigger ko cho phép xóa dịch vụ có tên là Giờ chơi
alter trigger DichVu_Delete on DichVu for delete
as
begin
    if exists(select * from deleted where TenDV = N'Giờ chơi')
	begin
	    print(N'Không được xóa dịch vụ này!')
		rollback tran
	end
end
delete from DICHVU where MaDV = '1'