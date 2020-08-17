select * from HocSinh

select * from DiemMH where MaHS = 001

--Lấy ra sinh viên và môn mà sinh viên ấy có điểm
select HocSinh.MaHS, HocSinh.HoTen, HocSinh.MaLop, PhanCongGiangDay.MaMH 
from DiemMH, HocSinh, PhanCongGiangDay
where DiemMH.MaMH = PhanCongGiangDay.MaMH and HocSinh.MaHS = DiemMH.MaHS and HocSinh.MaLop = PhanCongGiangDay.MaLop
--Lấy ra điểm của sinh viên và giáo viên dạy môn đó ở lớp đó( lớp mà sinh viên đó học)
--1.Lấy ra điểm của sinh viên theo từng môn
select HocSinh.MaHS, HocSinh.HoTen, DiemMH.MaMH, DiemMH.DiemMieng, DiemMH.Diem15p, DiemMH.Diem45p, DiemMH.DiemThiHK
from HocSinh, DiemMH
where HocSinh.MaHS = DiemMH.MaHS
--2.Lấy ra giáo viên dạy môn đó và dạy lớp đó
select GiaoVien.MaGV, GiaoVien.HoTen, Lop.MaLop, MaMH
from GiaoVien, Lop, PhanCongGiangDay
where PhanCongGiangDay.MaGV = GiaoVien.MaGV and Lop.Malop = PhanCongGiangDay.MaLop
--3. Nối 2 bảng trên lại
select HocSinh.MaHS, HocSinh.HoTen, DiemMH.MaMH, MonGV.HoTen, DiemMH.DiemMieng, DiemMH.Diem15p, DiemMH.Diem45p, DiemMH.DiemThiHK
from HocSinh, DiemMH, 
(  select GiaoVien.MaGV, GiaoVien.HoTen, Lop.MaLop, MaMH
   from GiaoVien, Lop, PhanCongGiangDay
   where PhanCongGiangDay.MaGV = GiaoVien.MaGV and Lop.Malop = PhanCongGiangDay.MaLop)MonGV
where HocSinh.MaHS = DiemMH.MaHS
and DiemMH.MaMH = MonGV.MaMH
and HocSinh.MaLop = MonGV.MaLop

--Thống kê số sinh viên mỗi lớp
select Lop.MaLop, Lop.TenLop, count(HocSinh.MaHS) as SoHS
from Lop, HocSinh
where HocSinh.MaLop = Lop.MaLop
group by Lop.Malop, Lop.TenLop

--Xếp loại sinh viên theo từng môn
drop function XepLoai
create function XepLoai(@MaHS nvarchar(10), @MaNH nvarchar(10), @MaHK nvarchar(10) )
returns @TongKet table(
   MaHocSinh nvarchar(10),
   HoTenHocSinh nvarchar(50),
   MaNamHoc nvarchar(10),
   MaHocKy nvarchar(10),
   MaMonHoc nvarchar(10),
   TenMonHoc nvarchar(50),
   DTB float(2),
   DanhHieu nvarchar(20) 
)
as
begin
    insert into @TongKet
	select DiemMH.MaHS, HoTen, MaNH, MaHK, DiemMH.MaMH, TenMH, cast((DiemMieng + Diem15p + Diem45p*2 + DiemThiHK*3)/7 as decimal(10,2)), ''
	from DiemMH, HocSinh, MonHoc
	where DiemMH.MaHS = HocSinh.MaHS
	and @MaHS = DiemMH.MaHS
	and @MaNH = DiemMH.MaNH
	and @MaHK = DiemMH.MaHK
	and DiemMH.MaMH = MonHoc.MaMH 

	declare p cursor
	for select DTB from @TongKet
	open p
	declare @Diem float
	fetch next from p into @Diem
	while(@@FETCH_STATUS = 0)
	begin
	    declare @DanhHieu nvarchar(20)
	    if @Diem >= 0 and @Diem < 4
	    begin
	        set @DanhHieu = N'Yếu'
	    end
	    else if @Diem >= 4 and @Diem < 6
	    begin
	        set @DanhHieu = N'Trung Bình'
	    end
	    else if @Diem >= 6 and @Diem < 8
	    begin
	        set @DanhHieu = N'Khá'
	    end
	    else if @Diem >= 8 and @Diem <= 10
	    begin
	        set @DanhHieu = N'Giỏi'
	    end
	
	    update @TongKet set DanhHieu = @DanhHieu
		fetch next from p into @Diem
	end
	close p
	deallocate p
	return
end

select * from dbo.XepLoai('001', '2019', 'HK1')

--Xếp loại theo tổng trung bình các môn của sinh viên
drop function TongKet
create function TongKet(@MaHS nvarchar(10), @MaNH nvarchar(10), @MaHK nvarchar(10) )
returns @DanhHieu table(
    MaHS nvarchar(10),
	TenHS nvarchar(50),
	MaNH nvarchar(10),
	MaHK nvarchar(10),
	DTB float,
	Xep nvarchar(20)
)
as
begin
    insert into @DanhHieu
    select MaHocSinh, HoTenHocSinh, @MaNH, @MaHK, cast(avg(DTB) as decimal(10,2)), ''
    from dbo.XepLoai(@MaHS, @MaNH, @MaHK)
    group by MaHocSinh, HoTenHocSinh
	declare @Xep nvarchar(20), @Diem float
	set @Diem = (select DTB from @DanhHieu)
	if @Diem >= 0 and @Diem < 4
	    set @Xep = N'Yếu'
	else if @Diem >= 4 and @Diem < 6
	    set @Xep = N'Trung Bình'
	else if @Diem >= 6 and @Diem < 8
	    set @Xep = N'Khá'
	else if @Diem >= 8 and @Diem <= 10
	    set @Xep = N'Giỏi'

	update @DanhHieu set Xep = @Xep
	return
end

select * from dbo.TongKet('001', '2019', 'HK1')

--Lấy danh sách sinh viên và điểm từng môn của sv đó
select * from DiemMH, HocSinh
where DiemMH.MaHS = HocSinh.MaHS

--Lấy ra sinh viên và lớp trưởng của lớp đó
select HocSinh.MaHS, HoTen, GioiTinh, NgaySinh, DiaChi, HocSinh.Malop, TenLT from HocSinh,
  ( select MaHS, Lop.MaLop, HoTen as TenLT from HocSinh, Lop
    where HocSinh.MaHS = Lop.MaLT )LT
where HocSinh.MaLop = LT.MaLop

--Thống kê số lượng sv mỗi lớp
select MaLop, count(*) from HocSinh group by MaLop

--Lấy ra sv có điểm ThiHK cao nhất của môn mã 01 trong lớp
--1.Lấy ra điểm cao nhất của môn 01
select MaMH, max(DiemThiHK) from HocSinh, DiemMH
where HocSinh.MaHS = DiemMH.MaHS and DiemMH.MaMH = 01
group by MaMH
--2.Lấy ra sinh viên có điểm bằng điểm trên
select HocSinh.MaHS, HoTen, DiemThiHK
from HocSinh, DiemMH, (
    select MaMH, max(DiemThiHK) as Diem from HocSinh, DiemMH
    where HocSinh.MaHS = DiemMH.MaHS and DiemMH.MaMH = 01
    group by MaMH)DiemThi
where HocSinh.MaHS = DiemMH.MaHS
and DiemThi.Diem = DiemThiHK
and DiemMH.MaMH = DiemTHi.MaMH

--Update DTB vào bảng DiemMH
drop proc DTB
create proc DTB
as
begin
declare @diemmieng float, @diem15p float, @diem45p float, @diemthiHK float
declare p cursor
for select DiemMieng, Diem15p, Diem45p, DiemThiHK from DiemMH
open p
fetch next from p into @diemmieng, @diem15p, @diem45p, @diemthiHK
while(@@FETCH_STATUS = 0)
    begin
	    declare @DTB float = (@diemmieng + @diem15p + @diem45p*2 + @diemthiHK*3)/7
		update DiemMH set DiemTB = cast(@DTB as decimal(10,2))
		 where DiemMieng = @diemmieng and Diem15p = @diem15p and Diem45p = @diem45p and DiemThiHK = @diemthiHK
		
		fetch next from p into @diemmieng, @diem15p, @diem45p, @diemthihk
	end
close p 
deallocate p
end

exec DTB
select * from DiemMH

--Xếp loại học sinh theo học kỳ 1
drop function XepLoai2
create function XepLoai2(@MaHS nvarchar(10), @MaHK nvarchar(10), @MaNH nvarchar(10))
returns @DanhHieu2 table(
    MaHocSinh nvarchar(10),
	TenHocSinh nvarchar(50),
	MaHocKy nvarchar(10),
	MaNamHoc nvarchar(10),
	DTB float,
	Xep nvarchar(20)
)
as
begin
    insert into @DanhHieu2
	select DiemMH.MaHS, HoTen, MaHK, MaNH, avg(DiemTB), ''
	from DiemMH, HocSinh
	where DiemMH.MaHS = HocSinh.MaHS and DiemMH.MaHS = @MaHS and DiemMH.MaHK = @MaHK and DiemMH.MaNH = @MaNH
	group by DiemMH.MaHS, HoTen, MaHK, MaNH
	declare @DH nvarchar(20), @Diem float
	set @Diem = (select DTB from @DanhHieu2)
	if @Diem >= 0 and @Diem < 4
	    set @DH = N'Yếu'
	else if @Diem >= 4 and @Diem < 6
	    set @DH = N'Trung Bình'
	else if @Diem >= 6 and @Diem < 8
	    set @DH = N'Khá'
	else if @Diem >= 8 and @Diem <= 10
	    set @DH = N'Giỏi'

	update @DanhHieu2 set Xep = @DH
	return
end

select * from dbo.XepLoai2('001', 'HK1', '2019')

--Liệt kê xếp loại của các sinh viên
drop function TongKet2
create function TongKet2(@MaHK nvarchar(10), @MaNH nvarchar(10))
returns @DanhSach table(
	MaHS nvarchar(10),
	TenHS nvarchar(50),
	MaNH nvarchar(10),
	MaHK nvarchar(10),
	DTB float,
	Xep nvarchar(20)
)
as
begin
    declare @MaHocSinh nvarchar(10), @MaHocKy nvarchar(10), @MaNamHoc nvarchar(10)
    declare p cursor
	for select MaHS, MaHK, MaNH from DiemMH where MaMH = 01 --Chỉ lấy 1 dòng trong DiemMH( vì chỉ cần MaHS, MaHK, MaNH)
	open p
	fetch next from p into @MaHocSinh, @MaHocKy, @MaNamHoc
	while @@FETCH_STATUS = 0
	begin
	    insert into @DanhSach
		select MaHocSinh, TenHocSinh, MaNamHoc, MaHocKy, DTB, Xep
		from dbo.XepLoai2(@MaHocSinh, @MaHocKy, @MaNamHoc)
		where MaNamHoc = @MaNH and MaHocKy = @MaHK
		
		fetch next from p into @MaHocSinh, @MaHocKy, @MaNamHoc
	end
    return
end

select * from TongKet2('HK1', '2019')

--1.Liệt kê dsgv dạy môn toán
select * from GiaoVien, PhanCongGiangDay, (select TenMH, MonHoc.MaMH from MonHoc, PhanCongGiangDay where PhanCongGiangDay.MaMH = MonHoc.MaMH and MaHK = 'HK1' and MaLop = '10A1')Mon
 where GiaoVien.MaGV = PhanCongGiangDay.MaGV and PhanCongGiangDay.MaMH = Mon.MaMH and Mon.TenMH = N'Toán'

--2. Thống kê số lượt phân công giảng dạy theo từng gv
select PhanCongGiangDay.MaGV, HoTen, count(*) from PhanCongGiangDay, GiaoVien where PhanCongGiangDay.MaGV = GiaoVien.MaGV group by PhanCongGiangDay.MaGV, HoTen

--3. THống kế SL GV giảng dạy theo từng môn học của lớp đó
select MaMH, count(*) from PhanCongGiangDay group by MaMH

--4.Thực hiện loại bỏ 1 gv nếu gv dạy ít hơn 5 môn của lớp đó
create proc Loai
as
begin
	delete GiaoVien where GiaoVien.MaGV in (select MaGV, count(*) from PhanCongGiangDay where MaLop = '10A1' group by MaGV having count(*) <= 5)
end