--Danh sach sinh vien thuoc ca 2 bang SinhVien va DMLop
select * from SinhVien s, DMLop l where s.MaLop = l.MaLop and s.MaSV = l.MaLopTruong
select distinct Malop from SinhVien

--Gan bi danh
select HoTen+' - '+MaSV as 'Tên - MaSV' from SinhVien