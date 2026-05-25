-- Insert dummy transaksi untuk testing dashboard
-- Jalankan script ini di phpMyAdmin atau MySQL Command Line

USE db_kasirin;

-- Insert transaksi hari ini (5 transaksi)
INSERT INTO tbl_transaksi (no_transaksi, tanggal, total_harga, diskon_total, total_bayar, bayar, kembalian, id_user, status, catatan) VALUES
('TRX20260523001', NOW(), 50000, 0, 50000, 50000, 0, 1, 'aktif', 'Transaksi normal'),
('TRX20260523002', NOW(), 75000, 5000, 70000, 70000, 0, 1, 'aktif', 'Transaksi dengan diskon'),
('TRX20260523003', NOW(), 120000, 0, 120000, 150000, 30000, 2, 'aktif', 'Transaksi kasir'),
('TRX20260523004', NOW(), 85000, 10000, 75000, 75000, 0, 1, 'aktif', 'Transaksi diskon besar'),
('TRX20260523005', NOW(), 45000, 0, 45000, 50000, 5000, 2, 'aktif', 'Transaksi kembalian');

-- Get id_transaksi yang baru dibuat untuk detail transaksi
SET @trx1 = (SELECT id_transaksi FROM tbl_transaksi WHERE no_transaksi = 'TRX20260523001');
SET @trx2 = (SELECT id_transaksi FROM tbl_transaksi WHERE no_transaksi = 'TRX20260523002');
SET @trx3 = (SELECT id_transaksi FROM tbl_transaksi WHERE no_transaksi = 'TRX20260523003');
SET @trx4 = (SELECT id_transaksi FROM tbl_transaksi WHERE no_transaksi = 'TRX20260523004');
SET @trx5 = (SELECT id_transaksi FROM tbl_transaksi WHERE no_transaksi = 'TRX20260523005');

-- Insert detail transaksi
INSERT INTO tbl_detail_transaksi (id_transaksi, id_produk, nama_produk, harga_satuan, jumlah, diskon_item, subtotal) VALUES
(@trx1, 1, 'Coca Cola 1.5L', 12000, 2, 0, 24000),
(@trx1, 4, 'Air Mineral Aqua 600ml', 3500, 1, 0, 3500),
(@trx1, 8, 'Chitato Rasa Pedas 60g', 6000, 4, 0, 24000),

(@trx2, 2, 'Sprite 1.5L', 12000, 3, 0, 36000),
(@trx2, 5, 'Teh Botol Sosro 500ml', 4000, 2, 0, 8000),
(@trx2, 10, 'Biscuit Oreo 137g', 12000, 3, 5000, 31000),

(@trx3, 3, 'Fanta Orange 1.5L', 11000, 5, 0, 55000),
(@trx3, 6, 'Roti Tawar Putih', 22000, 2, 0, 44000),
(@trx3, 9, 'Pocari Sweat 500ml', 5500, 1, 0, 5500),

(@trx4, 1, 'Coca Cola 1.5L', 12000, 4, 0, 48000),
(@trx4, 7, 'Nasi Kuning 250g', 8000, 2, 10000, 6000),
(@trx4, 4, 'Air Mineral Aqua 600ml', 3500, 3, 0, 10500),

(@trx5, 8, 'Chitato Rasa Pedas 60g', 6000, 5, 0, 30000),
(@trx5, 10, 'Biscuit Oreo 137g', 12000, 1, 0, 12000),
(@trx5, 5, 'Teh Botol Sosro 500ml', 4000, 1, 0, 4000);

-- Verify data
SELECT COUNT(*) as total_transaksi FROM tbl_transaksi WHERE DATE(tanggal) = CURDATE();
SELECT COUNT(*) as total_detail FROM tbl_detail_transaksi;
