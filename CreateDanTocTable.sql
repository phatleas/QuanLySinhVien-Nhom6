-- Script tạo bảng DanToc và thêm dữ liệu mẫu
-- Chạy script này trong SQL Server Management Studio

-- Kiểm tra và tạo bảng DanToc nếu chưa tồn tại
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='DanToc' AND xtype='U')
BEGIN
    CREATE TABLE DanToc (
        MaDanToc VARCHAR(10) PRIMARY KEY,
        TenDanToc NVARCHAR(50) NOT NULL
    )
    PRINT 'Đã tạo bảng DanToc'
END
ELSE
BEGIN
    PRINT 'Bảng DanToc đã tồn tại'
END

-- Xóa dữ liệu cũ nếu có
DELETE FROM DanToc

-- Thêm dữ liệu mẫu
INSERT INTO DanToc VALUES 
('1', N'Kinh'),
('2', N'Tày'),
('3', N'Thái'),
('4', N'Mường'),
('5', N'Khmer'),
('6', N'Hoa'),
('7', N'Nùng'),
('8', N'H''Mông'),
('9', N'Dao'),
('10', N'Gia Rai')

PRINT 'Đã thêm dữ liệu mẫu vào bảng DanToc'

-- Kiểm tra dữ liệu
SELECT * FROM DanToc

-- Kiểm tra cấu trúc bảng SinhVien
SELECT COLUMN_NAME, DATA_TYPE, CHARACTER_MAXIMUM_LENGTH 
FROM INFORMATION_SCHEMA.COLUMNS 
WHERE TABLE_NAME = 'SinhVien' AND COLUMN_NAME = 'MaDanToc'

-- Kiểm tra dữ liệu trong bảng SinhVien
SELECT MaSV, MaDanToc FROM SinhVien WHERE MaDanToc IS NOT NULL

