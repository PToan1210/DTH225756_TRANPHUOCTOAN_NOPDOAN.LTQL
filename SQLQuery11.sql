Use QuanLyChiTieu

IF OBJECT_ID('GiaoDich', 'U') IS NOT NULL DROP TABLE GiaoDich;
IF OBJECT_ID('HangMuc', 'U') IS NOT NULL DROP TABLE HangMuc;
IF OBJECT_ID('NguonTien', 'U') IS NOT NULL DROP TABLE NguonTien;
IF OBJECT_ID('LoaiNguonTien', 'U') IS NOT NULL DROP TABLE LoaiNguonTien;
IF OBJECT_ID('TaiKhoan', 'U') IS NOT NULL DROP TABLE TaiKhoan;

GO


-- 1. Bảng Người dùng
CREATE TABLE TaiKhoan (
    MaNguoiDung INT PRIMARY KEY IDENTITY(1,1),
    HoTen NVARCHAR(100) NOT NULL,
    TenDangNhap VARCHAR(50) UNIQUE NOT NULL,
    MatKhau VARCHAR(255) NOT NULL,
    Email VARCHAR(100) UNIQUE,
    -- VaiTro: 1 = Admin, 0 = User (Tiết kiệm bộ nhớ)
    VaiTro BIT DEFAULT 0, 
    NgayTao DATETIME DEFAULT GETDATE()
);



-- 3. Bảng Nguồn tiền (Liên kết với bảng Loại nguồn tiền)
CREATE TABLE NguonTien (
    MaNguonTien INT PRIMARY KEY IDENTITY(1,1),
    TenNguonTien NVARCHAR(100) NOT NULL, -- Ví dụ: N'Vietcombank', N'Momo'
    SoDuHienTai DECIMAL(18, 2) DEFAULT 0,
    LoaiNguonTien NVARCHAR(10),
    MaNguoiDung INT,
    CONSTRAINT FK_NguonTien_User FOREIGN KEY (MaNguoiDung) REFERENCES TaiKhoan(MaNguoiDung) ON DELETE CASCADE
);

-- 4. Bảng Hạng mục (Thu/Chi)
CREATE TABLE HangMuc (
    MaHangMuc INT PRIMARY KEY IDENTITY(1,1),
    TenHangMuc NVARCHAR(100) NOT NULL,
    LoaiHangMuc NVARCHAR(10) CHECK (LoaiHangMuc IN (N'Thu', N'Chi')),
    HanMuc DECIMAL(18, 2) DEFAULT 0,
    MaNguoiDung INT,
    CONSTRAINT FK_HangMuc_User FOREIGN KEY (MaNguoiDung) REFERENCES TaiKhoan(MaNguoiDung)
);

-- 5. Bảng Giao dịch (Bảng trung tâm)
CREATE TABLE GiaoDich (
    MaGiaoDich INT PRIMARY KEY IDENTITY(1,1),
    NgayGiaoDich DATETIME DEFAULT GETDATE(),
    SoTien DECIMAL(18, 2) NOT NULL CHECK (SoTien > 0),
    MoTa NVARCHAR(255),
    MaNguoiDung INT,
    MaNguonTien INT,
    MaHangMuc INT,
    CONSTRAINT FK_GD_User FOREIGN KEY (MaNguoiDung) REFERENCES TaiKhoan(MaNguoiDung),
    CONSTRAINT FK_GD_NguonTien FOREIGN KEY (MaNguonTien) REFERENCES NguonTien(MaNguonTien),
    CONSTRAINT FK_GD_HangMuc FOREIGN KEY (MaHangMuc) REFERENCES HangMuc(MaHangMuc)
);

-- ==========================================
-- 1. DỮ LIỆU MẪU CHO BẢNG TAIKHOAN (1 Admin, 9 Users)
-- ==========================================
INSERT INTO TaiKhoan (HoTen, TenDangNhap, MatKhau, Email, VaiTro) VALUES 
(N'Quản trị viên', 'admin', 'admin123', 'admin@fintech.com', 1), -- Admin
(N'Nguyễn Văn Toàn', 'toan123', '123456', 'toan@gmail.com', 0),   -- User
(N'Lê Thị Mai', 'maile', '123456', 'maile@gmail.com', 0),
(N'Trần Văn Hùng', 'hungtran', '123456', 'hung@gmail.com', 0),
(N'Phạm Minh Tuấn', 'tuanpham', '123456', 'tuan@gmail.com', 0),
(N'Hoàng Bảo Ngọc', 'ngoc_hoang', '123456', 'ngoc@gmail.com', 0),
(N'Đặng Văn Lâm', 'lamdang', '123456', 'lam@gmail.com', 0),
(N'Vũ Thu Trang', 'trangvu', '123456', 'trang@gmail.com', 0),
(N'Bùi Anh Đức', 'duc_bui', '123456', 'duc@gmail.com', 0),
(N'Ngô Quốc Anh', 'anhngo', '123456', 'anh@gmail.com', 0);

-- ==========================================
-- 2. DỮ LIỆU MẪU CHO BẢNG LOAINGUONTIEN (Admin quản lý)
-- ==========================================


-- ==========================================
-- 3. DỮ LIỆU MẪU CHO BẢNG NGUONTIEN (Gán cho Toàn - MaNguoiDung = 2)
-- ==========================================
INSERT INTO NguonTien (TenNguonTien, SoDuHienTai, LoaiNguonTien, MaNguoiDung) VALUES 
(N'Ví trong túi', 500000, 1, 2),
(N'Vietcombank', 15000000, 2, 2),
(N'Ví Momo', 2000000, 3, 2),
(N'ZaloPay', 100000, 3, 2),
(N'Techcombank', 5000000, 2, 2),
(N'Thẻ tín dụng VIB', -1000000, 4, 2),
(N'Ví Moca', 0, 3, 2),
(N'Sổ tiết kiệm BIDV', 50000000, 5, 2),
(N'Ống heo ở nhà', 300000, 10, 2),
(N'Ví ShopeePay', 450000, 3, 2);

-- ==========================================
-- 4. DỮ LIỆU MẪU CHO BẢNG HANGMUC (Hệ thống + User tạo)
-- ==========================================
INSERT INTO HangMuc (TenHangMuc, LoaiHangMuc, HanMuc, MaNguoiDung) VALUES 
(N'Ăn uống', N'Chi', 3000000, NULL), -- Hệ thống
(N'Di chuyển', N'Chi', 1000000, NULL), -- Hệ thống
(N'Lương', N'Thu', 0, NULL), -- Hệ thống
(N'Tiền điện/nước', N'Chi', 2000000, NULL), -- Hệ thống
(N'Mua sắm', N'Chi', 5000000, NULL), -- Hệ thống
(N'Thưởng dự án', N'Thu', 0, 2), -- Toàn tạo riêng
(N'Nạp game', N'Chi', 500000, 2), -- Toàn tạo riêng
(N'Trả nợ', N'Chi', 0, NULL), -- Hệ thống
(N'Đầu tư', N'Chi', 10000000, NULL), -- Hệ thống
(N'Quà biếu', N'Chi', 2000000, 2); -- Toàn tạo riêng

-- ==========================================
-- 5. DỮ LIỆU MẪU CHO BẢNG GIAODICH (Toàn thực hiện - MaNguoiDung = 2)
-- ==========================================
INSERT INTO GiaoDich (NgayGiaoDich, SoTien, MoTa, MaNguoiDung, MaNguonTien, MaHangMuc) VALUES 
(GETDATE(), 50000, N'Ăn sáng phở bò', 2, 1, 1),
(GETDATE(), 12000000, N'Nhận lương tháng 3', 2, 2, 3),
(GETDATE(), 200000, N'Nạp tiền điện thoại', 2, 3, 4),
(GETDATE(), 1500000, N'Mua giày mới', 2, 5, 5),
(GETDATE(), 30000, N'Gửi xe tháng', 2, 1, 2),
(GETDATE(), 5000000, N'Thưởng đồ án tốt nghiệp', 2, 2, 6),
(GETDATE(), 100000, N'Nạp quân huy Liên Quân', 2, 4, 7),
(GETDATE(), 2000000, N'Gửi tiền về cho mẹ', 2, 2, 10),
(GETDATE(), 45000, N'Uống Cafe với bạn', 2, 1, 1),
(GETDATE(), 120000, N'Tiền điện tháng này', 2, 3, 4);

SELECT * FROM TaiKhoan;      -- Xem danh sách người dùng & Vai trò (0/1)
SELECT * FROM NguonTien;     -- Xem các ví cụ thể và số dư hiện tại
SELECT * FROM HangMuc;       -- Xem danh mục Thu/Chi và Hạn mức
SELECT * FROM GiaoDich;      -- Xem lịch sử các giao dịch đã nhập