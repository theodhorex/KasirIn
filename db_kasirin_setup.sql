-- ============================================================================
-- KasirIn - POS & Inventory Management System
-- Database Setup Script
-- ============================================================================
-- Database: db_kasirin
-- Engine: InnoDB
-- Charset: utf8mb4
-- ============================================================================

-- Drop existing database if it exists
DROP DATABASE IF EXISTS db_kasirin;

-- Create database
CREATE DATABASE db_kasirin
CHARACTER SET utf8mb4
COLLATE utf8mb4_unicode_ci;

-- Use the database
USE db_kasirin;

-- ============================================================================
-- TABLE: tbl_user
-- ============================================================================
CREATE TABLE tbl_user (
  id_user INT AUTO_INCREMENT PRIMARY KEY,
  username VARCHAR(50) NOT NULL UNIQUE,
  password VARCHAR(255) NOT NULL,
  nama_lengkap VARCHAR(100) NOT NULL,
  role ENUM('Admin','Kasir') NOT NULL DEFAULT 'Kasir',
  is_active TINYINT(1) NOT NULL DEFAULT 1,
  created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
  last_login DATETIME NULL,
  INDEX idx_username (username),
  INDEX idx_role (role)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- ============================================================================
-- TABLE: tbl_kategori
-- ============================================================================
CREATE TABLE tbl_kategori (
  id_kategori INT AUTO_INCREMENT PRIMARY KEY,
  nama_kategori VARCHAR(100) NOT NULL UNIQUE,
  deskripsi TEXT NULL,
  created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
  INDEX idx_nama_kategori (nama_kategori)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- ============================================================================
-- TABLE: tbl_produk
-- ============================================================================
CREATE TABLE tbl_produk (
  id_produk INT AUTO_INCREMENT PRIMARY KEY,
  barcode VARCHAR(50) NOT NULL UNIQUE,
  nama_produk VARCHAR(150) NOT NULL,
  id_kategori INT NOT NULL,
  harga_beli DECIMAL(12,2) NOT NULL,
  harga_jual DECIMAL(12,2) NOT NULL,
  stok INT NOT NULL DEFAULT 0,
  stok_minimum INT NOT NULL DEFAULT 5,
  satuan VARCHAR(20) NOT NULL DEFAULT 'Pcs',
  keterangan TEXT NULL,
  is_active TINYINT(1) NOT NULL DEFAULT 1,
  created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
  updated_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  FOREIGN KEY (id_kategori) REFERENCES tbl_kategori(id_kategori) ON DELETE RESTRICT ON UPDATE CASCADE,
  INDEX idx_barcode (barcode),
  INDEX idx_nama_produk (nama_produk),
  INDEX idx_kategori (id_kategori),
  INDEX idx_is_active (is_active)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- ============================================================================
-- TABLE: tbl_supplier
-- ============================================================================
CREATE TABLE tbl_supplier (
  id_supplier INT AUTO_INCREMENT PRIMARY KEY,
  kode_supplier VARCHAR(20) NOT NULL UNIQUE,
  nama_supplier VARCHAR(100) NOT NULL,
  nama_kontak VARCHAR(100) NOT NULL,
  telepon VARCHAR(20) NOT NULL,
  email VARCHAR(100) NULL,
  alamat TEXT NOT NULL,
  is_active TINYINT(1) NOT NULL DEFAULT 1,
  created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
  INDEX idx_kode_supplier (kode_supplier),
  INDEX idx_nama_supplier (nama_supplier)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- ============================================================================
-- TABLE: tbl_transaksi
-- ============================================================================
CREATE TABLE tbl_transaksi (
  id_transaksi INT AUTO_INCREMENT PRIMARY KEY,
  no_transaksi VARCHAR(50) NOT NULL UNIQUE,
  tanggal DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
  total_harga DECIMAL(12,2) NOT NULL,
  diskon_total DECIMAL(12,2) NOT NULL DEFAULT 0,
  total_bayar DECIMAL(12,2) NOT NULL,
  bayar DECIMAL(12,2) NOT NULL,
  kembalian DECIMAL(12,2) NOT NULL DEFAULT 0,
  id_user INT NOT NULL,
  status ENUM('aktif','void') NOT NULL DEFAULT 'aktif',
  catatan TEXT NULL,
  FOREIGN KEY (id_user) REFERENCES tbl_user(id_user) ON DELETE RESTRICT ON UPDATE CASCADE,
  INDEX idx_no_transaksi (no_transaksi),
  INDEX idx_tanggal (tanggal),
  INDEX idx_status (status),
  INDEX idx_id_user (id_user)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- ============================================================================
-- TABLE: tbl_detail_transaksi
-- ============================================================================
CREATE TABLE tbl_detail_transaksi (
  id_detail INT AUTO_INCREMENT PRIMARY KEY,
  id_transaksi INT NOT NULL,
  id_produk INT NOT NULL,
  nama_produk VARCHAR(150) NOT NULL,
  harga_satuan DECIMAL(12,2) NOT NULL,
  jumlah INT NOT NULL,
  diskon_item DECIMAL(12,2) NOT NULL DEFAULT 0,
  subtotal DECIMAL(12,2) NOT NULL,
  FOREIGN KEY (id_transaksi) REFERENCES tbl_transaksi(id_transaksi) ON DELETE CASCADE ON UPDATE CASCADE,
  FOREIGN KEY (id_produk) REFERENCES tbl_produk(id_produk) ON DELETE RESTRICT ON UPDATE CASCADE,
  INDEX idx_id_transaksi (id_transaksi),
  INDEX idx_id_produk (id_produk)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- ============================================================================
-- TABLE: tbl_void_transaksi
-- ============================================================================
CREATE TABLE tbl_void_transaksi (
  id_void INT AUTO_INCREMENT PRIMARY KEY,
  id_transaksi INT NOT NULL,
  alasan TEXT NOT NULL,
  waktu_void DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
  id_user INT NOT NULL,
  FOREIGN KEY (id_transaksi) REFERENCES tbl_transaksi(id_transaksi) ON DELETE CASCADE ON UPDATE CASCADE,
  FOREIGN KEY (id_user) REFERENCES tbl_user(id_user) ON DELETE RESTRICT ON UPDATE CASCADE,
  INDEX idx_id_transaksi (id_transaksi),
  INDEX idx_id_user (id_user),
  INDEX idx_waktu_void (waktu_void)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- ============================================================================
-- TABLE: tbl_pembelian
-- ============================================================================
CREATE TABLE tbl_pembelian (
  id_pembelian INT AUTO_INCREMENT PRIMARY KEY,
  no_pembelian VARCHAR(50) NOT NULL UNIQUE,
  id_supplier INT NOT NULL,
  tanggal DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
  total DECIMAL(12,2) NOT NULL,
  keterangan TEXT NULL,
  id_user INT NOT NULL,
  created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
  FOREIGN KEY (id_supplier) REFERENCES tbl_supplier(id_supplier) ON DELETE RESTRICT ON UPDATE CASCADE,
  FOREIGN KEY (id_user) REFERENCES tbl_user(id_user) ON DELETE RESTRICT ON UPDATE CASCADE,
  INDEX idx_no_pembelian (no_pembelian),
  INDEX idx_tanggal (tanggal),
  INDEX idx_id_supplier (id_supplier),
  INDEX idx_id_user (id_user)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- ============================================================================
-- TABLE: tbl_detail_pembelian
-- ============================================================================
CREATE TABLE tbl_detail_pembelian (
  id_detail_beli INT AUTO_INCREMENT PRIMARY KEY,
  id_pembelian INT NOT NULL,
  id_produk INT NOT NULL,
  jumlah INT NOT NULL,
  harga_beli DECIMAL(12,2) NOT NULL,
  subtotal DECIMAL(12,2) NOT NULL,
  FOREIGN KEY (id_pembelian) REFERENCES tbl_pembelian(id_pembelian) ON DELETE CASCADE ON UPDATE CASCADE,
  FOREIGN KEY (id_produk) REFERENCES tbl_produk(id_produk) ON DELETE RESTRICT ON UPDATE CASCADE,
  INDEX idx_id_pembelian (id_pembelian),
  INDEX idx_id_produk (id_produk)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- ============================================================================
-- TABLE: tbl_pengeluaran
-- ============================================================================
CREATE TABLE tbl_pengeluaran (
  id_pengeluaran INT AUTO_INCREMENT PRIMARY KEY,
  tanggal DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
  kategori VARCHAR(100) NOT NULL,
  keterangan TEXT NOT NULL,
  jumlah DECIMAL(12,2) NOT NULL,
  id_user INT NOT NULL,
  created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
  FOREIGN KEY (id_user) REFERENCES tbl_user(id_user) ON DELETE RESTRICT ON UPDATE CASCADE,
  INDEX idx_tanggal (tanggal),
  INDEX idx_kategori (kategori),
  INDEX idx_id_user (id_user)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- ============================================================================
-- TABLE: tbl_log_aktivitas
-- ============================================================================
CREATE TABLE tbl_log_aktivitas (
  id_log INT AUTO_INCREMENT PRIMARY KEY,
  id_user INT NOT NULL,
  aksi VARCHAR(100) NOT NULL,
  keterangan TEXT NULL,
  ip_address VARCHAR(45) NULL,
  waktu TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
  FOREIGN KEY (id_user) REFERENCES tbl_user(id_user) ON DELETE CASCADE ON UPDATE CASCADE,
  INDEX idx_id_user (id_user),
  INDEX idx_aksi (aksi),
  INDEX idx_waktu (waktu)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- ============================================================================
-- DUMMY DATA INSERTION
-- ============================================================================

-- Insert Users
INSERT INTO tbl_user (username, password, nama_lengkap, role, is_active) VALUES
('admin', SHA2('admin123', 256), 'Administrator', 'Admin', 1),
('kasir1', SHA2('kasir123', 256), 'Kasir Satu', 'Kasir', 1);

-- Insert Categories
INSERT INTO tbl_kategori (nama_kategori, deskripsi) VALUES
('Minuman', 'Produk minuman berbagai jenis'),
('Makanan', 'Produk makanan siap saji dan bahan makanan'),
('Snack', 'Produk snack dan camilan ringan');

-- Insert Products
INSERT INTO tbl_produk (barcode, nama_produk, id_kategori, harga_beli, harga_jual, stok, stok_minimum, satuan, keterangan, is_active) VALUES
('8992341000001', 'Coca Cola 1.5L', 1, 8000, 12000, 50, 10, 'Botol', 'Minuman soda', 1),
('8992341000002', 'Sprite 1.5L', 1, 8000, 12000, 45, 10, 'Botol', 'Minuman soda', 1),
('8992341000003', 'Fanta Orange 1.5L', 1, 7500, 11000, 40, 10, 'Botol', 'Minuman soda', 1),
('8992341000004', 'Air Mineral Aqua 600ml', 1, 2000, 3500, 100, 20, 'Botol', 'Air mineral', 1),
('8992341000005', 'Teh Botol Sosro 500ml', 1, 2500, 4000, 80, 15, 'Botol', 'Minuman teh', 1),
('8992341000006', 'Roti Tawar Putih', 2, 15000, 22000, 30, 5, 'Bungkus', 'Roti tawar premium', 1),
('8992341000007', 'Nasi Kuning 250g', 2, 5000, 8000, 25, 5, 'Bungkus', 'Nasi kuning siap saji', 1),
('8992341000008', 'Chitato Rasa Pedas 60g', 3, 3500, 6000, 60, 10, 'Bungkus', 'Keripik kentang', 1),
('8992341000009', 'Pocari Sweat 500ml', 1, 3000, 5500, 70, 15, 'Botol', 'Minuman isotonic', 1),
('8992341000010', 'Biscuit Oreo 137g', 3, 8000, 12000, 40, 8, 'Bungkus', 'Biscuit coklat', 1);

-- Insert Supplier
INSERT INTO tbl_supplier (kode_supplier, nama_supplier, nama_kontak, telepon, email, alamat, is_active) VALUES
('SUP001', 'PT Distributor Maju Jaya', 'Budi Santoso', '081234567890', 'contact@distributorimaju.com', 'Jl. Raya Industri No. 123, Jakarta Timur', 1);

-- ============================================================================
-- END OF SETUP SCRIPT
-- ============================================================================
