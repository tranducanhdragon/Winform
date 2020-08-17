select MaSV, HoTen, MaLop, DATEDIFF(year, NgaySinh, getdate()) sonam from SinhVien order by sonam desc
--Sắp xếp theo năm sinh, nếu bằng nhau thì sắp xếp theo tháng
select * from SinhVien order by Year(NgaySinh), Month(NgaySinh), Day(NgaySinh)

--Lấy về DSSV thuộc lớp "tin"
--1.Lấy về các mã lớp mà tên lớp có chữ "tin"
--Bảng: DMLop
select MaLop from DMLop where TenLop like N'%tin%'

--2. Lấy về DSSV có mã lớp thuộc danh sách mã lớp ở mục 1
select * from SinhVien where MaLop in( select MaLop from DMLop where TenLop like N'%tin%')

--Lấy về danh sách lớp có sinh viên Hiếu
--1. Lấy về malop trong bảng SinhVien
select MaLop from SinhVien where HoTen like N'%Hiếu%'
--2.Lấy về thông tin lớp mà mã lớp nằm trong tập ở mục 1
select * from DMLop where MaLop in (select MaLop from SinhVien where HoTen like N'%Hiếu%')

--Lấy về danh sách sv có cùng tháng sinh với 1 lớp trưởng nào đó
select * from SinhVien where MONTH(NgaySinh) in
(    select Month(NgaySinh) from SinhVien where MaSV in
           (select MaLopTruong from DMLop)
)

--Truy vấn lồng tương quan
select * from SinhVien where exists
( select * from DMLop where DMLop.Malop = SinhVien.MaLop and DMLop.TenLop like N'%tin%')

--Lấy về DSSV thuộc lớp "tin"
select * from SinhVien, (select * from DMLop where tenlop like N'%tin%') as loptin
where sinhvien.malop = loptin.malop

--Lấy về DSSV sinh vào ngày 12 hoặc sinh viên thuộc lớp "tin"
select * from sinhvien where day(NgaySinh) = 15 union 
select * from sinhvien where malop in( select malop from dmlop where tenlop like N'%tin%')

--Lấy về thông tin lớp có sinh viên tên Nguyễn trừ lớp "mềm"
select malop from sinhvien where hoten like N'Nguyễn%'
except 
select malop from dmlop where tenlop like N'%mềm%'
--Sắp xếp theo tên
select HoTen from SinhVien order by 
(select substring(reverse(HoTen), charindex(' ', reverse(HoTen))-1, 1)) asc

--Hàm thống kê, gom nhóm
--Đếm số sinh viên của lớp KTPM 16
select count(*) from SinhVien where malop = 'KTPM16'
--TÍnh tháng sinh trung bình của các sinh viên
select avg(MONTH(NgaySinh)) from SinhVien
--Thống kê số lượng sinh viên của từng lớp
--1.Liệt kê dssv theo mã lớp
select* from sinhvien order by malop
--Thống kê số lượng sv theo mã lớp
select malop, count(*) from SinhVien group by malop
--Tháng sinh trung bình của từng lớp
select malop, avg(month(NgaySinh)) from SinhVien group by malop
--Với mỗi lớp, liệt kê tháng sinh min, max của tháng sinh
select malop, min(month(NgaySinh)), max(month(ngaysinh)) from SinhVien group by malop
--Liệt kê mã lớp, tên lớp, số lượng sinh viên từng lớp
select * from dmlop, (select malop, count(*) as SL from SinhVien group by malop) thongke
where dmlop.Malop = thongke.MaLop
--Với mỗi lớp liệt kê tên của một sinh viên có tháng sinh nhỏ nhất
select hoten, tuoinhonhat.malop, mintuoi from sinhvien,
(select malop, min(month(ngaysinh)) as mintuoi from sinhvien group by malop)tuoinhonhat
where month(ngaysinh) = mintuoi and sinhvien.malop = tuoinhonhat.malop
--Liệt kê các lớp có trên 5 sv 
--c1:
select dmlop.malop, dem from dmlop,
(select malop, count(*) as dem from sinhvien group by malop )demsv
where dem >= 5 and dmlop.malop = demsv.MaLop
--c2:
select malop, count(*) as SL from sinhvien  
group by malop
having count(*) >= 5
--Liệt kê số lượng sinh viên của từng lớp theo tên lớp
select demsv.tenlop, dem from
(select sinhvien.malop, tenlop, count(*) as dem from sinhvien join dmlop on sinhvien.malop = dmlop.malop group by sinhvien.malop, tenlop)demsv
--Liệt kê các lớp có trên 5 sv có họ là Nguyễn
--c1:
select dmlop.malop, dem from dmlop, 
(select malop, count(*) as dem from sinhvien
where hoten like N'%Nguyễn%'
group by malop)demNguyen
where dmlop.malop = demNguyen.malop
--c2:
select malop, count(*) as SL from sinhvien  
where hoten like N'Nguyễn%'
group by malop
having count(*) >= 5

--select từ 2 bảng
select * from sinhvien join dmlop on sinhvien.MaLop = dmlop.Malop

select * from sinhvien inner join dmlop on sinhvien.MaLop = dmlop.Malop

--Lấy về dssv và tên lớp, kể cả các sv chưa đc gán lớp hoặc gán sai
select * from sinhvien left join dmlop on sinhvien.MaLop = dmlop.Malop

--Liệt kê dssv ( kể cả sv chưa đc gán lớp) và kể cả lớp chưa có sv
select * from SinhVien full join dmlop on SinhVien.malop = dmlop.Malop

--Tạo bảng mới danhsach gồm masv, teenssv, tên lớp và tên lớp trưởng
--C1:
select masv, hoten, tenlop, tenloptruong
from SinhVien, dmlop, (select hoten as tenloptruong, DMLop.Malop as lop from sinhvien, dmlop where SinhVien.masv = dmlop.MaLopTruong)loptruong 
 where SinhVien.MaLop = dmlop.Malop and SinhVien.malop = loptruong.lop

 --C2:
 create table DanhSach(
 masv float,
 hoten nvarchar(50),
 tenlop nvarchar(50),
 tenloptruong nvarchar(50)
 )

 insert into DanhSach(masv, hoten, tenlop, tenloptruong)
 select convert(float, sinhvien.masv),
 convert(nvarchar(50), sinhvien.hoten),
 convert(nvarchar(50), lop.tenlop),
 convert(nvarchar(50), lop.tenloptruong)
 from SinhVien,
 (select dmlop.Malop, dmlop.TenLop, SinhVien.hoten as tenloptruong
 from dmlop left join sinhvien on dmlop.MaLopTruong = sinhvien.masv) lop
 where SinhVien.malop = lop.Malop

 --Liệt kê các lớp ko có sinh viên
 select * from dmlop
 except
 select * from dmlop where malop in (select malop from sinhvien)
 --Hoặc
  select * from dmlop where malop not in (select malop from sinhvien)
 --Lớp có sv
 select * from dmlop where malop in (select malop from sinhvien)

 --Liệt kê các sv cần đc phân lớp lại( sinh viên ko ở lớp nào cả( hay malop = null))
  select * from sinhvien
  except
  select * from sinhvien where malop in (select malop from dmlop)
  --Tạo view
  create view svsai as
  select * from sinhvien
  except
  select * from sinhvien where malop in (select malop from dmlop)
  --Xóa view
  drop view svsai

  --tạo view giúp hiển thị mã sv, họ tên, số tuổi, tên lớp
  --C1:
  create view dstuoi as
  select masv, hoten, tuoi, ten_lop
  from SinhVien, (select tenlop as ten_lop, malop from dmlop)lop, (select (2019 - year(ngaysinh)) as tuoi from SinhVien)age
  where SinhVien.MaLop = lop.malop
  /*Khi tạo view thì ko đc dùng order by*/
  --c2:
  select masv, hoten, DATEDIFF(year, ngaysinh, GETDATE()), dmlop.TenLop
  from sinhvien left join DMLop
  on SinhVien.MaLop = dmlop.Malop

  --Liệt kê các sv có tuổi nhỏ nhất trong mỗi lớp
  --1.Với mỗi lớp, liệt kê mã lớp và tuổi nhỏ nhất
  select malop, min(datediff(year, ngaysinh, getdate())) as mintuoi from SinhVien group by malop
  --2.liệt kê thông tin các sv có tuổi nhỏ nhất
  select * from SinhVien, 
  (  select malop, min(datediff(year, ngaysinh, getdate())) as mintuoi from SinhVien group by malop)tuoilop
  where SinhVien.MaLop = tuoilop.MaLop and datediff(year, ngaysinh, getdate()) = tuoilop.mintuoi

  --Xử lí theo lô

  --Giải phương trình bậc 2
  declare @a float, @b float, @c float
  declare @delta float, @x1 float, @x2 float
  set @a = 1;
  set @b = 3;
  set @c = 4;
  select @delta = @b*@b - 4*@a*@c;
  if(@delta >= 0)
  begin
      set @x1 = (-@b - sqrt(@delta))/(2*@a);
	  set @x2 = (-@b + sqrt(@delta))/(2*@a);
	  print @x1;
	  print @x2;
  end
  else
  begin
      print N'Phương trình vô nghiệm'
  end
  print @delta

  --Thiết lập phụ cấp theo mức
  --Khóa 16 là 4000000, 15 là 4500000, 14 5000000 còn lại 5500000
  select * from SinhVien
  update sinhvien set phucap = 4000000
  where malop in (select malop from dmlop where Khoa = 16)
    update sinhvien set phucap = 4500000
  where malop in (select malop from dmlop where Khoa = 15)
    update sinhvien set phucap = 4000000
  where malop in (select malop from dmlop where Khoa = 14)
    update SinhVien set phucap = 5500000
	where malop not in (select malop from dmlop where khoa = 14 or khoa = 15 or khoa = 16)

--Tạo bảng dữ liệu PTrinhBac2 gồm
--5 cột a, b, c, x1, x2
--và nhập dữ liệu cho 1 số bản ghi
--(trừ cột x1, x2)
--Phần 1: viết ctrinh lấy ra bản ghi có a, b, c lớn nhất ( theo thứ tự ưu tiên)
--và in ra nghiệm của ptrinh bậc 2 tương ứng
--tạo bảng insert dữ liệu , select có theo thứ tự và đưa vào biến
--Phần 2: Viết chtrinh giải toàn bộ PTB2 trong bảng và ghi nghiệm vào cột x1 x2 tương ứng.
create table PTB2(
a float,
b float,
c float,
x1 float,
x2 float,
)
insert into PTB2(a,b,c)
values (1,3,2)
insert into PTB2(a,b,c)
values (3,4,1)
insert into PTB2(a,b,c)
values (3,1,2)
insert into PTB2(a,b,c)
values (1,2,3)


--Giải phương trình bậc 2
declare 
 @a1 float = (select top(1) a from ptb2 order by a desc, b desc, c desc),
 @b1 float = (select top(1) b from ptb2 order by a desc, b desc, c desc),
 @c1 float = (select top(1) c from ptb2 order by a desc, b desc, c desc),
 @delta1 float, @x11 float, @x21 float

set @delta1 = @b1*@b1 - 4*@a1*@c1
if (@delta1 >= 0)
begin
    set @x11 = (-@b1-SQRT(@delta1))/(2*@a1)
	set @x21 = (-@b1+SQRT(@delta1))/(2*@a1)
	declare @command nvarchar(1000)
    set @command = 'select top(1)' + convert(nvarchar(10), @a1)+ 'as ''a''' +','
	+ convert(nvarchar(10), @b1) + 'as ''b'''+','
	+ convert(nvarchar(10), @c1) + 'as ''c'''+','
	+ convert(nvarchar(10), @x11) +'as ''x1'''+','
	+ convert(nvarchar(10), @x21) + 'as ''x2'''+'from ptb2'
    exec(@command)
end
else
begin
    print('PT vo nghiem')
end

--Tăng phụ cấp cho sinh viên ít tuổi nhất khóa 16 n lần
--Mỗi lần tăng 10%
--tăng cho đến khi phụ cấp của sv này >= phụ cấp trung binh của sv khóa 13 trở về trc
select * from SinhVien
declare @l16 float = (select top(1) phucap from sinhvien where datediff(day, NgaySinh, getdate()) in
                           (select min(datediff(day, ngaysinh, getdate())) from SinhVien group by malop having malop = 'KTPM16')
					 ),
        @ltb13 float = (select avg(phucap) from sinhvien group by malop having malop = '13')
while(@ltb13 > @l16)
begin
    set @l16 = @l16*1.1
end

--Viết đoạn script nhập vào điểm và in ra phân loại tương ứng
--điểm < 4 : không đạt
--4 <= điểm < 5.5: trung bình
-- 5.5 <= điểm < 7: trung bình khá
--7 <= điểm < 8: khá
-- 8 <= diểm < 9: giỏi
--9 <= điểm <= 10: xuất sắc

--1.Thêm cột DiemTB vào bảng sinhvien
select * from SinhVien
alter table sinhvien 
add DiemTB float
--2. Thực hiện xếp loại
select *,
case 
    when DiemTB >= 9 and DiemTB <= 10 then N'Xuất Sắc'
	when DiemTB >= 8 and DiemTB < 9 then N'Giỏi'
	when DiemTB >= 7 and DiemTB < 8 then N'Khá'
	when DiemTB >= 5.5 and DiemTB < 7 then N'Trung Bình Khá'
	when DiemTB >= 4 and DiemTB < 5.5 then N'Trung Bình'
	when DiemTB >= 0 and DiemTB < 4 then N'Không Đạt'
    else N'Điểm không hợp lệ'
end as XepLoai
from sinhvien

--Viết thủ tục đọc điểm số ra điểm chữ
--Viết thủ tục chuyển số hóa đơn sang dạng chữ tính đến hàng tỷ

alter table sinhvien 
add DiemChu nvarchar(20)

declare p cursor
for select DiemTB from sinhvien

declare @Diem float
open p
fetch next from p into @Diem
while (@@FETCH_STATUS = 0)
begin

    declare @ThapPhan int
	declare @LamTron int
	set @LamTron = floor(@Diem)--Làm tròn xuống
	set @ThapPhan = (@Diem - @LamTron)*10
	declare @DiemChu nvarchar(20)
	declare @ThapPhanChu nvarchar(20)

    if @LamTron = 0
	begin
	    set @DiemChu = N'Không'
	end
	else if @LamTron = 1
	begin
	    set @DiemChu = N'Một' 
	end
	else if @LamTron = 2
	begin
	    set @DiemChu = N'Hai'
	end
	if @LamTron = 3
	begin
	    set @DiemChu = N'Ba'
	end
	if @LamTron = 4
	begin
	    set @DiemChu = N'Bốn'
	end
	if @LamTron = 5
	begin
	    set @DiemChu = N'Năm'
	end
	if @LamTron = 6
	begin
	    set @DiemChu = N'Sáu'
	end
	if @LamTron = 7
	begin
	    set @DiemChu = N'Bảy'
	end
	if @LamTron = 8
	begin
	    set @DiemChu = N'Tám'
	end
	if @LamTron = 9
	begin
	    set @DiemChu = N'Chín'
	end
	if @LamTron = 10
	begin
	    set @DiemChu = N'Mười'
	end
	
	if @ThapPhan = 0
	begin
	    set @ThapPhanChu = N'Không'
	end
	else if @ThapPhan = 5
	begin
	    set @ThapPhanChu = N'Năm'
	end
	update sinhvien set DiemChu = @DiemChu+N' phẩy '+@ThapPhanChu where @Diem = DiemTB

	fetch next from p into @Diem
end
close p
deallocate p

select * from SinhVien

--Con trỏ
declare @a float, @b float, @c float

declare heso cursor
for select a, b, c from ptb2
open heso
fetch next from heso
into @a, @b, @c
while @@FETCH_STATUS = 0
begin
    fetch next from heso
	into @a, @b, @c
	declare @delta3 float, @x13 float, @x23 float
    set @delta3 = @b*@b - 4*@a*@c
    if (@delta3 >= 0)
    begin
        set @x13 = (-@b-SQRT(@delta3))/(2*@a)
	    set @x23 = (-@b+SQRT(@delta3))/(2*@a)
		update ptb2 set x1 = @x13, x2 = @x23 where a = @a and b = @b and c = @c
    end
    else
    begin
        set @x13 = null
		set @x23 = null
		update ptb2 set x1 = @x13, x2 = @x23 where a = @a and b = @b and c = @c
    end
end

close heso
deallocate heso

select * from ptb2

--thêm thủ tục thêm sinh viên, chỉ cho phép thêm nếu:
--Mã sinh viên khác null
--sinh viên thuộc lớp đã có sinh viên
create proc ThemSinhVien(@ma varchar(20), @hoten varchar(50), @malop varchar(10))
as 
begin
    if(@ma is not null)
	begin
		if exists(select * from sinhvien where malop = @malop)
	    begin
		    --Thêm vào
			insert into sinhvien(masv, hoten, malop)
			values(@ma, @hoten)
		end
	end
end 

--Viết thủ tục liệt kê dssv có tháng sinh theo yêu cầu
create proc LietkeSV(@thang int)
as
begin
    select * from SinhVien where month(ngaysinh) = @thang
end

exec LietkeSV 11
--Trả về tham số trong một thủ tục
create proc Cong(@a int, @b int, @result int out)
as
begin
    set @result = @a + @b
end
--Run
declare @tong int
exec Cong 1, 2, @tong out
print @tong

--Viết hàm thống kê SL sv theo mã lớp
create function SLSinhVien(@malop nvarchar(10))
returns int
as
begin
    declare @sl int
	    select @sl = count(*) from sinhvien where malop = @malop
	return (@sl)
end
--Sử dụng hàm trên
select malop, dbo.SLSinhVien(malop) from dmlop

--Viết hàm trả về dssv thuộc lớp có trong danh mục của học viện
create function Xemlop(@malop nvarchar(10))
returns table
as 
return (select masv, hoten from SinhVien, dmlop
           where SinhVien.malop = dmlop.malop
		   and sinhvien.malop = @malop)
--Run
select * from dbo.Xemlop('KTPM16')

--Thường stored proc sử dụng trong cập nhật dữ liệu
--Hàm (function) sử dụng trong thống kê, báo cáo & tính toán

--Tạo hàm thống kê số lượng sv của lớp( nhập vào tên lớp). Nếu lớp rỗng thống kê SL của tất cả các lớp
drop function ThongKeSL
create function ThongKeSL(@tenlop nvarchar(50))
returns @BangThongKe table(
    tenlop nvarchar(50),
	malop nvarchar(10),
	soluongSV int
)
as 
begin
 if @tenlop = ''
     insert into @BangThongKe
	 select Tenlop, Sinhvien.malop, count(masv) as [slsv] from dmlop, sinhvien
	     where dmlop.malop = sinhvien.malop
		 group by sinhvien.malop, tenlop
 else
     insert into @BangThongKe
	 select DMlop.tenlop, sinhvien.malop , count(masv) from dmlop, sinhvien
	     where dmlop.malop = sinhvien.malop
		 and TenLop = @tenlop
		 group by SinhVien.malop, tenlop
 return
end
select * from dbo.ThongKeSL(N'công nghệ thông tin 16')