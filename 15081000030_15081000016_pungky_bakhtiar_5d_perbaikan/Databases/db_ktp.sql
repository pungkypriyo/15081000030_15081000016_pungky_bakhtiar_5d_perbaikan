/*
Navicat MySQL Data Transfer

Source Server         : local_development
Source Server Version : 50505
Source Host           : 127.0.0.1:3306
Source Database       : testapp

Target Server Type    : MYSQL
Target Server Version : 50505
File Encoding         : 65001

Date: 2017-12-15 10:00:18
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for ktp
-- ----------------------------
DROP TABLE IF EXISTS `ktp`;
CREATE TABLE `ktp` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `ktp_no` varchar(25) NOT NULL,
  `ktp_nama_lengkap` varchar(150) NOT NULL,
  `ktp_jk` char(1) NOT NULL,
  `ktp_status_kawin` char(2) NOT NULL,
  `ktp_alamat` text NOT NULL,
  `ktp_alamat_rtrw` char(8) NOT NULL,
  `ktp_alamat_desa` varchar(55) NOT NULL,
  `ktp_alamat_kecamatan` varchar(55) NOT NULL,
  `ktp_alamat_kota` varchar(55) NOT NULL,
  `ktp_agama` varchar(20) NOT NULL,
  `ktp_goldar` char(2) NOT NULL,
  `ktp_kwn` char(4) NOT NULL,
  `ktp_berlaku` char(12) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of ktp
-- ----------------------------
INSERT INTO `ktp` VALUES ('1', '3573011110970005', 'PUNGKY PRIYO PRAKOSO', 'L', 'K', 'JL. TELUK PELABUHAN RATU 14 H', '001/003', 'ARJOSARI', 'BLIMBING', 'MALANG', 'ISLAM', 'B', 'WNI', '2030-10-11');
INSERT INTO `ktp` VALUES ('4', '12341234123', 'SYNTHIA PARAMITHA PUSPITANDARI', 'P', 'K', 'JALAN KSATRIAN 12', '003/002', 'BALEARJOSARI', 'BLIMBING', 'MALANG', 'ISLAM', 'AB', 'WNI', '2017-08-12');
