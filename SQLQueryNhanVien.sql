select * from NhanVien
update BangNhap
set MaPB = 'TC'
where MaPB = '10'

--Lấy nhân viên ở phòng Nghiên cứu
select MaNV, TenNV from NhanVien where MaPB in
(select MaPB from PhongBan where TenPB = N'Nghiên cứu' )
--Tìm người trưởng phòng của các nhân viên
(select n.HoNV + ' '+n.TenNV as 'Nhan vien', t.HoNV+' '+t.TenNV as 'Truong Phong'
 from NhanVien n, NhanVien t, PhongBan p where t.MaNV = p.MaTP)
 --Tìm nhân viên ko có người thân
 select HoNV+' '+ TenNV from NhanVien 
 except 
 select HoNV+' '+ TenNV from NhanVien , ThanNhan  where NhanVien.MaNV = ThanNhan.MaNV
--Tìm nhân viên có lương lớn hơn ít nhất 1 nhân viên phòng NC
select MaNV from NhanVien,
( select luong from NhanVien where NhanVien.MaPB = 'NC') as LNC
where NhanVien.Luong > LNC.luong
