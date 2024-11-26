create database QL_NHAP_THUOC
go
use [QL_NHAP_THUOC]
go
CREATE TABLE Hang_SX (
    Ma_Hang_SX VARCHAR(5) PRIMARY KEY, 
    Ten_Hang NVARCHAR(100),
    Quoc_Gia NVARCHAR(100)
);

CREATE TABLE Nha_Cung_Cap (
    Ma_Nha_Cung_Cap VARCHAR(5) PRIMARY KEY, 
    Ten_Nha_Cung_Cap NVARCHAR(100),
    Thong_Tin_Dai_Dien NVARCHAR(100),
    Dia_Chi NVARCHAR(200)
);

CREATE TABLE Loai_Thuoc (
    Ma_Loai_Thuoc VARCHAR(5) PRIMARY KEY, 
    Ten_Loai_Thuoc NVARCHAR(100)
);

CREATE TABLE Nguoi_QL_Kho (
    Ma_Nguoi_QL VARCHAR(5) PRIMARY KEY, 
    Ho_Ten NVARCHAR(100),
    Ngay_Sinh DATE,
    SDT NVARCHAR(20)
);

CREATE TABLE Thuoc (
    Ma_Thuoc VARCHAR(5) PRIMARY KEY, 
    Ten_Thuoc NVARCHAR(100),
    Ma_Nha_Cung_Cap VARCHAR(5), 
    Ma_Loai_Thuoc VARCHAR(5), 
    Cong_Dung NVARCHAR(200),
    Ma_Hang_SX VARCHAR(5), 
    FOREIGN KEY (Ma_Nha_Cung_Cap) REFERENCES Nha_Cung_Cap(Ma_Nha_Cung_Cap),
    FOREIGN KEY (Ma_Loai_Thuoc) REFERENCES Loai_Thuoc(Ma_Loai_Thuoc),
    FOREIGN KEY (Ma_Hang_SX) REFERENCES Hang_SX(Ma_Hang_SX)
);

CREATE TABLE Phieu_Nhap (
    Ma_PN VARCHAR(5) PRIMARY KEY, 
    Ma_Nguoi_QL VARCHAR(5), 
    Ma_Nha_Cung_Cap VARCHAR(5),
    Ngay_Nhap DATE,
    Ma_Loai_Thuoc VARCHAR(5),  
    FOREIGN KEY (Ma_Nguoi_QL) REFERENCES Nguoi_QL_Kho(Ma_Nguoi_QL),
    FOREIGN KEY (Ma_Nha_Cung_Cap) REFERENCES Nha_Cung_Cap(Ma_Nha_Cung_Cap),
    FOREIGN KEY (Ma_Loai_Thuoc) REFERENCES Loai_Thuoc(Ma_Loai_Thuoc)
);

CREATE TABLE CT_Phieu_Nhap (
    Ma_PN VARCHAR(5), 
    Ma_Thuoc VARCHAR(5),  
    SL INT,  -- Số lượng
    Don_Gia DECIMAL(18, 2),
    PRIMARY KEY (Ma_PN, Ma_Thuoc),
    FOREIGN KEY (Ma_PN) REFERENCES Phieu_Nhap(Ma_PN),
    FOREIGN KEY (Ma_Thuoc) REFERENCES Thuoc(Ma_Thuoc)
);

CREATE TABLE  NguoiDung(
    MaTK VARCHAR(10) PRIMARY KEY, 
    TenDangnhap NVARCHAR(30),
    Matkhau NVARCHAR(30),
	LoaiTK NVARCHAR(10),
	MaNguoiQL VARCHAR(5),
	FOREIGN KEY (MaNguoiQL) REFERENCES Nguoi_QL_Kho(Ma_Nguoi_QL)
);


INSERT INTO Hang_SX(Ma_Hang_SX,Ten_Hang,Quoc_Gia)VALUES ('SX001', N'Hòa Bình', N'Việt Nam');
INSERT INTO Hang_SX(Ma_Hang_SX,Ten_Hang,Quoc_Gia)VALUES ('SX002', N'An Phú', N'Việt Nam');
INSERT INTO Hang_SX(Ma_Hang_SX,Ten_Hang,Quoc_Gia)VALUES ('SX003', N'Sài Gòn', N'Việt Nam');
INSERT INTO Hang_SX(Ma_Hang_SX,Ten_Hang,Quoc_Gia)VALUES ('SX004', N'Hương Sắc', N'Việt Nam');
INSERT INTO Hang_SX(Ma_Hang_SX,Ten_Hang,Quoc_Gia)VALUES ('SX005', N'Đông Á', N'Việt Nam');
go
INSERT INTO Loai_Thuoc (Ma_Loai_Thuoc, Ten_Loai_Thuoc)VALUES ('LT001', N'Thuốc Giảm Đau');
INSERT INTO Loai_Thuoc (Ma_Loai_Thuoc, Ten_Loai_Thuoc)VALUES ('LT002', N'Thuốc Kháng Viêm');
INSERT INTO Loai_Thuoc (Ma_Loai_Thuoc, Ten_Loai_Thuoc)VALUES ('LT003', N'Thuốc Kháng Sinh');
INSERT INTO Loai_Thuoc (Ma_Loai_Thuoc, Ten_Loai_Thuoc)VALUES ('LT004', N'Thuốc Chống Trào Ngược');
INSERT INTO Loai_Thuoc (Ma_Loai_Thuoc, Ten_Loai_Thuoc)VALUES ('LT005', N'Thuốc Hạ Đường Huyết');
INSERT INTO Loai_Thuoc (Ma_Loai_Thuoc, Ten_Loai_Thuoc)VALUES ('LT006', N'Thuốc Giảm Cholesterol');
INSERT INTO Loai_Thuoc (Ma_Loai_Thuoc, Ten_Loai_Thuoc)VALUES ('LT007', N'Thuốc Chống Dị Ứng');
INSERT INTO Loai_Thuoc (Ma_Loai_Thuoc, Ten_Loai_Thuoc)VALUES ('LT008', N'Thuốc Hạ Huyết Áp');
INSERT INTO Loai_Thuoc (Ma_Loai_Thuoc, Ten_Loai_Thuoc)VALUES ('LT009', N'Thuốc Tiêu Hóa');
INSERT INTO Loai_Thuoc (Ma_Loai_Thuoc, Ten_Loai_Thuoc)VALUES ('LT010', N'Thuốc Chống Suy Thận');
go

INSERT INTO Nguoi_QL_Kho (Ma_Nguoi_QL, Ho_Ten, Ngay_Sinh, SDT)VALUES ('QL001', N'Nguyễn Văn Quí', '1980-01-01', '0901234567');
INSERT INTO Nguoi_QL_Kho (Ma_Nguoi_QL, Ho_Ten, Ngay_Sinh, SDT)VALUES ('QL002', N'Trần Thị Phúc', '1985-02-02', '0902345678');
INSERT INTO Nguoi_QL_Kho (Ma_Nguoi_QL, Ho_Ten, Ngay_Sinh, SDT)VALUES ('QL003', N'Lê Văn Mận', '1990-03-03', '0903456789');
INSERT INTO Nguoi_QL_Kho (Ma_Nguoi_QL, Ho_Ten, Ngay_Sinh, SDT)VALUES ('QL004', N'Phan Văn Linh', '1975-04-04', '0904567890');
INSERT INTO Nguoi_QL_Kho (Ma_Nguoi_QL, Ho_Ten, Ngay_Sinh, SDT)VALUES ('QL005', N'Nguyễn Thị Ngọc', '1983-05-05', '0905678901');
INSERT INTO Nguoi_QL_Kho (Ma_Nguoi_QL, Ho_Ten, Ngay_Sinh, SDT)VALUES ('QL006', N'Nguyễn Văn Khương','1992-06-06', '0906789012');
INSERT INTO Nguoi_QL_Kho (Ma_Nguoi_QL, Ho_Ten, Ngay_Sinh, SDT)VALUES ('QL007', N'Trần Văn Danh', '1995-07-07', '0907890123');
INSERT INTO Nguoi_QL_Kho (Ma_Nguoi_QL, Ho_Ten, Ngay_Sinh, SDT)VALUES ('QL008', N'Lê Thị Oanh', '1988-08-08', '0908901234');
INSERT INTO Nguoi_QL_Kho (Ma_Nguoi_QL, Ho_Ten, Ngay_Sinh, SDT)VALUES ('QL009', N'Phan Thị Bưởi', '1991-09-09', '0909012345');
INSERT INTO Nguoi_QL_Kho (Ma_Nguoi_QL, Ho_Ten, Ngay_Sinh, SDT)VALUES ('QL010', N'Nguyễn Văn Trình', '1982-10-10', '0910123456');
go
INSERT INTO Nha_Cung_Cap (Ma_Nha_Cung_Cap, Ten_Nha_Cung_Cap, Thong_Tin_Dai_Dien, Dia_Chi)VALUES ('NC001', N'Công ty Dược phẩm Hòa Bình', N'Nguyễn Văn An', N'Hà Nội');
INSERT INTO Nha_Cung_Cap (Ma_Nha_Cung_Cap, Ten_Nha_Cung_Cap, Thong_Tin_Dai_Dien, Dia_Chi)VALUES ('NC002', N'Công ty Dược phẩm An Phú', N'Trần Thị Lệ', N'Hồ Chí Minh');
INSERT INTO Nha_Cung_Cap (Ma_Nha_Cung_Cap, Ten_Nha_Cung_Cap, Thong_Tin_Dai_Dien, Dia_Chi)VALUES ('NC003', N'Công ty Dược phẩm Sài Gòn', N'Lê Văn Hạnh', N'Đà Nẵng');
INSERT INTO Nha_Cung_Cap (Ma_Nha_Cung_Cap, Ten_Nha_Cung_Cap, Thong_Tin_Dai_Dien, Dia_Chi)VALUES ('NC004', N'Công ty Dược phẩm Việt Nam', N'Phan Văn Cường', N'Cần Thơ');
INSERT INTO Nha_Cung_Cap (Ma_Nha_Cung_Cap, Ten_Nha_Cung_Cap, Thong_Tin_Dai_Dien, Dia_Chi)VALUES ('NC005', N'Công ty Dược phẩm Đông Á', N'Hoàng Thị Xuân', N'Hải Phòng');
INSERT INTO Nha_Cung_Cap (Ma_Nha_Cung_Cap, Ten_Nha_Cung_Cap, Thong_Tin_Dai_Dien, Dia_Chi)VALUES ('NC006', N'Công ty Dược phẩm Hương Sắc', N'Nguyễn Văn Bửu', N'Bắc Ninh');
INSERT INTO Nha_Cung_Cap (Ma_Nha_Cung_Cap, Ten_Nha_Cung_Cap, Thong_Tin_Dai_Dien, Dia_Chi)VALUES ('NC007', N'Công ty Dược phẩm Hạnh Phúc', N'Nguyễn Văn Giang', N'Huế');
INSERT INTO Nha_Cung_Cap (Ma_Nha_Cung_Cap, Ten_Nha_Cung_Cap, Thong_Tin_Dai_Dien, Dia_Chi)VALUES ('NC008', N'Công ty Dược phẩm Tâm Đức', N'Nguyễn Văn Hùng', N'Nha Trang');
INSERT INTO Nha_Cung_Cap (Ma_Nha_Cung_Cap, Ten_Nha_Cung_Cap, Thong_Tin_Dai_Dien, Dia_Chi)VALUES ('NC009', N'Công ty Dược phẩm Gia Đình', N'Nguyễn Văn Trúc', N'Hà Nội');
INSERT INTO Nha_Cung_Cap (Ma_Nha_Cung_Cap, Ten_Nha_Cung_Cap, Thong_Tin_Dai_Dien, Dia_Chi)VALUES ('NC010', N'Công ty Dược phẩm Thành Công', N'Trần Thị Hoa', N'Hồ Chí Minh');

go
INSERT INTO Thuoc (Ma_Thuoc, Ten_Thuoc, Ma_Nha_Cung_Cap, Ma_Loai_Thuoc, Cong_Dung, Ma_Hang_SX)VALUES ('TH001', N'Paracetamol', 'NC001', 'LT001', N'Giảm đau', 'SX001');
INSERT INTO Thuoc (Ma_Thuoc, Ten_Thuoc, Ma_Nha_Cung_Cap, Ma_Loai_Thuoc, Cong_Dung, Ma_Hang_SX)VALUES ('TH002', N'Ibuprofen', 'NC002', 'LT002', N'Kháng viêm', 'SX002');
INSERT INTO Thuoc (Ma_Thuoc, Ten_Thuoc, Ma_Nha_Cung_Cap, Ma_Loai_Thuoc, Cong_Dung, Ma_Hang_SX)VALUES ('TH003', N'Aspirin', 'NC003', 'LT001', N'Giảm đau', 'SX001');
INSERT INTO Thuoc (Ma_Thuoc, Ten_Thuoc, Ma_Nha_Cung_Cap, Ma_Loai_Thuoc, Cong_Dung, Ma_Hang_SX)VALUES ('TH004', N'Amoxicillin', 'NC004', 'LT003', N'Kháng sinh', 'SX002');
INSERT INTO Thuoc (Ma_Thuoc, Ten_Thuoc, Ma_Nha_Cung_Cap, Ma_Loai_Thuoc, Cong_Dung, Ma_Hang_SX)VALUES ('TH005', N'Ciprofloxacin', 'NC005', 'LT003', N'Kháng khuẩn', 'SX003');
INSERT INTO Thuoc (Ma_Thuoc, Ten_Thuoc, Ma_Nha_Cung_Cap, Ma_Loai_Thuoc, Cong_Dung, Ma_Hang_SX)VALUES ('TH006', N'Loratadine', 'NC006', 'LT002', N'Chống dị ứng', 'SX001');
INSERT INTO Thuoc (Ma_Thuoc, Ten_Thuoc, Ma_Nha_Cung_Cap, Ma_Loai_Thuoc, Cong_Dung, Ma_Hang_SX)VALUES ('TH007', N'Omeprazole', 'NC001', 'LT004', N'Chống trào ngược', 'SX004');
INSERT INTO Thuoc (Ma_Thuoc, Ten_Thuoc, Ma_Nha_Cung_Cap, Ma_Loai_Thuoc, Cong_Dung, Ma_Hang_SX)VALUES ('TH008', N'Metformin', 'NC002', 'LT005', N'Hạ đường huyết', 'SX005');
INSERT INTO Thuoc (Ma_Thuoc, Ten_Thuoc, Ma_Nha_Cung_Cap, Ma_Loai_Thuoc, Cong_Dung, Ma_Hang_SX)VALUES ('TH009', N'Simvastatin', 'NC003', 'LT006', N'Giảm cholesterol', 'SX004');
INSERT INTO Thuoc (Ma_Thuoc, Ten_Thuoc, Ma_Nha_Cung_Cap, Ma_Loai_Thuoc, Cong_Dung, Ma_Hang_SX)VALUES ('TH010', N'Prednisolone', 'NC004', 'LT002', N'Chống viêm', 'SX005');


INSERT INTO Phieu_Nhap (Ma_PN, Ma_Nguoi_QL, Ma_Nha_Cung_Cap, Ngay_Nhap, Ma_Loai_Thuoc)VALUES ('PN001', 'QL001', 'NC001', '2024-01-01', 'LT001');
INSERT INTO Phieu_Nhap (Ma_PN, Ma_Nguoi_QL, Ma_Nha_Cung_Cap, Ngay_Nhap, Ma_Loai_Thuoc)VALUES ('PN002', 'QL002', 'NC002', '2024-01-02', 'LT002');
INSERT INTO Phieu_Nhap (Ma_PN, Ma_Nguoi_QL, Ma_Nha_Cung_Cap, Ngay_Nhap, Ma_Loai_Thuoc)VALUES ('PN003', 'QL003', 'NC003', '2024-01-03', 'LT003');
INSERT INTO Phieu_Nhap (Ma_PN, Ma_Nguoi_QL, Ma_Nha_Cung_Cap, Ngay_Nhap, Ma_Loai_Thuoc)VALUES ('PN004', 'QL004', 'NC004', '2024-01-04', 'LT004');
INSERT INTO Phieu_Nhap (Ma_PN, Ma_Nguoi_QL, Ma_Nha_Cung_Cap, Ngay_Nhap, Ma_Loai_Thuoc)VALUES ('PN005', 'QL005', 'NC005', '2024-01-05', 'LT005');
INSERT INTO Phieu_Nhap (Ma_PN, Ma_Nguoi_QL, Ma_Nha_Cung_Cap, Ngay_Nhap, Ma_Loai_Thuoc)VALUES ('PN006', 'QL006', 'NC006', '2024-01-06', 'LT006');
INSERT INTO Phieu_Nhap (Ma_PN, Ma_Nguoi_QL, Ma_Nha_Cung_Cap, Ngay_Nhap, Ma_Loai_Thuoc)VALUES ('PN007', 'QL007', 'NC007', '2024-01-07', 'LT007');
INSERT INTO Phieu_Nhap (Ma_PN, Ma_Nguoi_QL, Ma_Nha_Cung_Cap, Ngay_Nhap, Ma_Loai_Thuoc)VALUES ('PN008', 'QL008', 'NC008', '2024-01-08', 'LT008');
INSERT INTO Phieu_Nhap (Ma_PN, Ma_Nguoi_QL, Ma_Nha_Cung_Cap, Ngay_Nhap, Ma_Loai_Thuoc)VALUES ('PN009', 'QL009', 'NC009', '2024-01-09', 'LT009');
INSERT INTO Phieu_Nhap (Ma_PN, Ma_Nguoi_QL, Ma_Nha_Cung_Cap, Ngay_Nhap, Ma_Loai_Thuoc)VALUES ('PN010', 'QL010', 'NC010', '2024-01-10', 'LT010');
go
INSERT INTO CT_Phieu_Nhap (Ma_PN, Ma_Thuoc, SL, Don_Gia)VALUES ('PN001', 'TH001', 100, 10000);
INSERT INTO CT_Phieu_Nhap (Ma_PN, Ma_Thuoc, SL, Don_Gia)VALUES ('PN002', 'TH002', 200, 20000);
INSERT INTO CT_Phieu_Nhap (Ma_PN, Ma_Thuoc, SL, Don_Gia)VALUES ('PN003', 'TH003', 150, 15000);
INSERT INTO CT_Phieu_Nhap (Ma_PN, Ma_Thuoc, SL, Don_Gia)VALUES ('PN004', 'TH004', 120, 12000);
INSERT INTO CT_Phieu_Nhap (Ma_PN, Ma_Thuoc, SL, Don_Gia)VALUES ('PN005', 'TH005', 180, 18000);
INSERT INTO CT_Phieu_Nhap (Ma_PN, Ma_Thuoc, SL, Don_Gia)VALUES ('PN006', 'TH006', 140, 14000);
INSERT INTO CT_Phieu_Nhap (Ma_PN, Ma_Thuoc, SL, Don_Gia)VALUES ('PN007', 'TH007', 130, 13000);
INSERT INTO CT_Phieu_Nhap (Ma_PN, Ma_Thuoc, SL, Don_Gia)VALUES ('PN008', 'TH008', 110, 11000);
INSERT INTO CT_Phieu_Nhap (Ma_PN, Ma_Thuoc, SL, Don_Gia)VALUES ('PN009', 'TH009', 160, 16000);
INSERT INTO CT_Phieu_Nhap (Ma_PN, Ma_Thuoc, SL, Don_Gia)VALUES ('PN010', 'TH010', 170, 17000);

INSERT INTO NguoiDung(MaTK,TenDangnhap,Matkhau,LoaiTK,MaNguoiQL)VALUES ('TK001', 'nguoiquanly','123456', 'nguoiql',null);
INSERT INTO NguoiDung(MaTK,TenDangnhap,Matkhau,LoaiTK,MaNguoiQL)VALUES ('TK002', 'nhanvienquanly','123456', 'nhanvien','QL003');
 
 select*from NguoiDung where TenDangnhap='nguoiquanly ' and Matkhau='123456'
 select*from Thuoc
 select a.Ma_Thuoc,Ten_Thuoc,Ten_Nha_Cung_Cap,Ten_Thuoc,Cong_Dung,Ten_Hang from Thuoc a,Nha_Cung_Cap b,Loai_Thuoc c,Hang_SX d 
 where a.Ma_Nha_Cung_Cap=b.Ma_Nha_Cung_Cap and a.Ma_Loai_Thuoc=c.Ma_Loai_Thuoc and a.Ma_Hang_SX=d.Ma_Hang_SX
 update Thuoc set Ten_Thuoc='ghghjfj',Ma_Nha_Cung_Cap='NC003',Ma_Loai_Thuoc='LT003',Cong_Dung='efjhdj',Ma_Hang_SX='SX003'where Ma_Thuoc='TH011'
 delete from Thuoc where Ma_Thuoc='TH012'
select*from Nguoi_QL_Kho
select*from NguoiDung
select Ma_Nguoi_QL,Ho_Ten,Ngay_Sinh,SDT,TenDangnhap,Matkhau from Nguoi_QL_Kho a,NguoiDung b where a.Ma_Nguoi_QL=b.MaNguoiQL
select top 1 MaTK from NguoiDung order by MaTK desc
update NguoiDung set TenDangnhap='nhanvienquanly' where MaTK = 'TK002'