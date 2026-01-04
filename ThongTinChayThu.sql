
USE QuanLyBanHang;
GO


INSERT INTO SANPHAM (TenSP, DonGia, SoLuongTon, MoTa)
VALUES 
(N'Cà Phê Đen', 20000, 200, N'Đậm vị'),
(N'Cà Phê Sữa', 25000, 200, N'Pha phin'),
(N'Bạc Xỉu', 30000, 200, N'Nhiều sữa'),
(N'Trà Đào Cam Sả', 45000, 200, N'Giải nhiệt'),
(N'Trà Olong Hạt Sen', 50000, 200, N'Thanh mát'),
(N'Trà Vải', 45000, 200, N'Có 3 trái vải'),
(N'Nước Cam Vắt', 40000, 200, N'Cam vắt nguyên chất'),
(N'Sinh Tố Bơ', 55000, 200, N'Bơ sáp Đắk Lắk'),
(N'Bánh Croissant', 35000, 200, N'Bánh sừng bò'),
(N'Bánh Mì Chảo', 60000, 200, N'Trứng, pate, xúc xích');
GO


INSERT INTO KHACHHANG (HoTen, SoDienThoai, DiaChi)
VALUES 
(N'Khách vãng lai', '', N''),
(N'Nguyễn Văn An', '0905111222', N'123 Lê Lợi, Q1, TPHCM'),
(N'Trần Thị Bình', '0913333444', N'456 Đồng Khởi, Bến Tre'),
(N'Lê Hoàng Long', '0989555666', N'789 Nguyễn Trãi, Q5, TPHCM'),
(N'Phạm Thị Mai', '0903777888', N'234 Pasteur, Q3, TPHCM'),
(N'Võ Thành Trung', '0908999000', N'567 CMT8, Q10, TPHCM'),
(N'Đặng Yến Nhi', '0938123456', N'890 Võ Văn Tần, Q3, TPHCM'),
(N'Hoàng Minh Tuấn', '0902654321', N'321 Trần Hưng Đạo, Q1, TPHCM'),
(N'Bùi Lan Anh', '0918765432', N'654 Lê Văn Sỹ, Q.Tân Bình, TPHCM'),
(N'Lý Gia Hân', '0909101010', N'101 Nguyễn Huệ, Q1, TPHCM');
GO
-------

delete khachhang 
select *from khachhang

UPDATE KHACHHANG
SET DaXoa = 0
WHERE DaXoa IS NULL OR DaXoa = 1;


CREATE TABLE NGUOIDUNG (
    TenDangNhap VARCHAR(50) PRIMARY KEY,  -- tên đ.nhap (khóa chính , ko trùng)
    MatKhau VARCHAR(50) NOT NULL,         -- mk
    HoTen NVARCHAR(100),                  -- họ tên (có dấu)
    SoDienThoai NVARCHAR(20),             -- sdt
    Quyen VARCHAR(20)                     -- phân q`: admin và nhân viên
);
GO

INSERT INTO NGUOIDUNG (TenDangNhap, MatKhau, HoTen, SoDienThoai, Quyen)
VALUES ('admin', '999', N'Phạm Minh Nhựt', '0901017304', 'Admin');

INSERT INTO NGUOIDUNG (TenDangNhap, MatKhau, HoTen, SoDienThoai, Quyen)
VALUES ('nhanvien', '123', N'Nhân Viên chạy thử', '0918777888', 'NhanVien');
GO

delete SANPHAM
GO
select *from sanpham
select *from khachhang

delete nguoidung
select *from nguoidung

select *from DONHANG
delete DONHANG
