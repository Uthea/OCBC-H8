--- a Buat database baru dengan nama staff
DROP DATABASE IF EXISTS STAFF;
CREATE DATABASE staff;
USE staff;

--- b Buat table data_staf
CREATE TABLE data_staff (
NIK INT PRIMARY KEY,
NAMA VARCHAR(50) NULL,
ALAMAT VARCHAR(200) NULL,
HANDPHONE VARCHAR(15) NULL
)

--- c dan d Masukan data ke table
INSERT INTO data_staff(NIK,NAMA,ALAMAT,HANDPHONE)
VALUES
(1, 'TEST', 'BANDUNG', '081223445'),
(2, 'TEST2', 'MAKASSAR', '081445667')

-- e Tambah kolom joindate + tambah 1 data
ALTER TABLE data_staff
ADD JOINDATE DATE;

INSERT INTO data_staff(NIK,NAMA,ALAMAT,HANDPHONE,JOINDATE)
VALUES (3, 'TEST', 'BANDUNG', '081223445', '2019-06-10'),
(4, 'TEST', 'SUBANG', '081223445', '2019-09-10')

-- f dan g Tampilkan 2 dan 3 row
SELECT TOP(2) * FROM data_staff
SELECT TOP(3) * FROM data_staff

-- h
-- buat table staffoutsource 
-- dengan isi yang sama dengan data_staff
CREATE TABLE staffoutsource(
NIK INT PRIMARY KEY,
NAMA VARCHAR(50) NULL,
ALAMAT VARCHAR(200) NULL,
HANDPHONE VARCHAR(15) NULL,
JOINDATE DATE NULL)

INSERT INTO staffoutsource(NIK,NAMA,ALAMAT,HANDPHONE,JOINDATE)
VALUES
(1, 'TEST', 'BANDUNG', '081223445', NULL),
(2, 'TEST2', 'MAKASSAR', '081445667', NULL),
(3, 'TEST', 'BANDUNG', '081223445', '2019-06-10')

-- i
-- 10 data baru ke staff outsource
INSERT INTO staffoutsource(NIK,NAMA,ALAMAT,HANDPHONE,JOINDATE)
VALUES
(4, 'TEST4', 'MANADO', '081223445', NULL),
(5, 'TEST5', 'PARE-PARE', '081445667', NULL),
(6, 'TEST6', 'JOGJA', '081223445', '2019-06-10'),
(7, 'TEST7', 'PEKALONGAN', '081223475', '2019-08-10'),
(8, 'TEST8', 'CIBUBUR', '081253445', '2019-09-10'),
(9, 'TEST9', 'CIPANAS', '081263445', '2019-10-10'),
(10, 'TEST10', 'MENTENG', '081253445', '2019-06-17'),
(11, 'TEST11', 'BEKASI', '081223045', '2019-06-15'),
(12, 'TEST12', 'BSD', '081273445', '2019-06-04'),
(13, 'TEST13', 'ALSUT', '083223445', '2019-06-03')


-- j tampilkan data dengan join date yang sama
SELECT * FROM staffoutsource
SELECT * FROM data_staff

SELECT * FROM staffoutsource 
JOIN data_staff
ON staffoutsource.JOINDATE  = data_staff.JOINDATE 


-- k tampilkan data sebelah kanan yang sama pada table outsource
SELECT * FROM data_staff
RIGHT JOIN staffoutsource
ON data_staff.NIK = staffoutsource.NIK
WHERE data_staff.NAMA = staffoutsource.NAMA
AND data_staff.ALAMAT = staffoutsource.ALAMAT
AND data_staff.HANDPHONE = staffoutsource.HANDPHONE
AND data_staff.JOINDATE = staffoutsource.JOINDATE
-- comparasi null = null adalah unknown bukan true



-- l tampilkan data staff sebelah kiri yang tidak sama bernilai null
SELECT data_staff.* FROM data_staff
RIGHT JOIN staffoutsource
ON data_staff.NIK = staffoutsource.NIK


-- m tampilkan data dari 2 table yang tidak bernilai sama dan null
SELECT * FROM data_staff
FULL JOIN staffoutsource
ON data_staff.NIK = staffoutsource.NIK

