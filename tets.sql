use Quanlychungcu
select * from  nhanvien
insert into nhanvien(manhanvien,hoten,gioitinh,diachi,sdt,ngaysinh,email,cmnd,maphongban,hinhanh)
select 'NV02','An Na Di','Nữ','Hà Nam','23914123','2002/10/11','asdasd@gmail.com','032423423','PB03',
	BulkColumn 
	from Openrowset(Bulk 'E:\TestC#\nhanvien(1).jpg',Single_Blob) as Image
