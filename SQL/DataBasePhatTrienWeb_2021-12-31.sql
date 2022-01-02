# ************************************************************
# Sequel Ace SQL dump
# Version 20019
#
# https://sequel-ace.com/
# https://github.com/Sequel-Ace/Sequel-Ace
#
# Host: localhost (MySQL 8.0.27)
# Database: DataBasePhatTrienWeb
# Generation Time: 2021-12-31 10:02:31 +0000
# ************************************************************


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
SET NAMES utf8mb4;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE='NO_AUTO_VALUE_ON_ZERO', SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


# Dump of table __EFMigrationsHistory
# ------------------------------------------------------------

DROP TABLE IF EXISTS `__EFMigrationsHistory`;

CREATE TABLE `__EFMigrationsHistory` (
  `MigrationId` varchar(150) NOT NULL,
  `ProductVersion` varchar(32) NOT NULL,
  PRIMARY KEY (`MigrationId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;



# Dump of table AspNetRoleClaims
# ------------------------------------------------------------

DROP TABLE IF EXISTS `AspNetRoleClaims`;

CREATE TABLE `AspNetRoleClaims` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `RoleId` varchar(767) NOT NULL,
  `ClaimType` text,
  `ClaimValue` text,
  PRIMARY KEY (`Id`),
  KEY `FK_AspNetRoleClaims_AspNetRoles_RoleId` (`RoleId`),
  CONSTRAINT `FK_AspNetRoleClaims_AspNetRoles_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `AspNetRoles` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;



# Dump of table AspNetRoles
# ------------------------------------------------------------

DROP TABLE IF EXISTS `AspNetRoles`;

CREATE TABLE `AspNetRoles` (
  `Id` varchar(767) NOT NULL,
  `Name` varchar(256) DEFAULT NULL,
  `NormalizedName` varchar(256) DEFAULT NULL,
  `ConcurrencyStamp` text,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;



# Dump of table AspNetUserClaims
# ------------------------------------------------------------

DROP TABLE IF EXISTS `AspNetUserClaims`;

CREATE TABLE `AspNetUserClaims` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `UserId` varchar(767) NOT NULL,
  `ClaimType` text,
  `ClaimValue` text,
  PRIMARY KEY (`Id`),
  KEY `FK_AspNetUserClaims_AspNetUsers_UserId` (`UserId`),
  CONSTRAINT `FK_AspNetUserClaims_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `AspNetUsers` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;



# Dump of table AspNetUserLogins
# ------------------------------------------------------------

DROP TABLE IF EXISTS `AspNetUserLogins`;

CREATE TABLE `AspNetUserLogins` (
  `LoginProvider` varchar(128) NOT NULL,
  `ProviderKey` varchar(128) NOT NULL,
  `ProviderDisplayName` text,
  `UserId` varchar(767) NOT NULL,
  PRIMARY KEY (`LoginProvider`,`ProviderKey`),
  KEY `FK_AspNetUserLogins_AspNetUsers_UserId` (`UserId`),
  CONSTRAINT `FK_AspNetUserLogins_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `AspNetUsers` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;



# Dump of table AspNetUsers
# ------------------------------------------------------------

DROP TABLE IF EXISTS `AspNetUsers`;

CREATE TABLE `AspNetUsers` (
  `Id` varchar(767) NOT NULL,
  `FirstName` text,
  `LastName` text,
  `UserName` varchar(256) DEFAULT NULL,
  `NormalizedUserName` varchar(256) DEFAULT NULL,
  `Email` varchar(256) DEFAULT NULL,
  `NormalizedEmail` varchar(256) DEFAULT NULL,
  `EmailConfirmed` tinyint(1) NOT NULL,
  `PasswordHash` text,
  `SecurityStamp` text,
  `ConcurrencyStamp` text,
  `PhoneNumber` text,
  `PhoneNumberConfirmed` tinyint(1) NOT NULL,
  `TwoFactorEnabled` tinyint(1) NOT NULL,
  `LockoutEnd` timestamp NULL DEFAULT NULL,
  `LockoutEnabled` tinyint(1) NOT NULL,
  `AccessFailedCount` int NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

LOCK TABLES `AspNetUsers` WRITE;
/*!40000 ALTER TABLE `AspNetUsers` DISABLE KEYS */;

INSERT INTO `AspNetUsers` (`Id`, `FirstName`, `LastName`, `UserName`, `NormalizedUserName`, `Email`, `NormalizedEmail`, `EmailConfirmed`, `PasswordHash`, `SecurityStamp`, `ConcurrencyStamp`, `PhoneNumber`, `PhoneNumberConfirmed`, `TwoFactorEnabled`, `LockoutEnd`, `LockoutEnabled`, `AccessFailedCount`)
VALUES
	('04fe6194-dbf9-4b2d-a156-915a3570c061','Nhan','le','Nhan@gmail.com1','NHAN@GMAIL.COM1','Nhan@gmail.com1','NHAN@GMAIL.COM1',1,'AQAAAAEAACcQAAAAEDx57A3mZe3vkU0wIumzfl8y658iuXtgClXn438/WAKjN4K4mz7kc6bv+xgq9Yjhpw==','5Z64RYCFL6V3P5BPRRJEK4BFADE7QVUR','b9da9764-ba08-4a9f-8247-68df7e551bfd',NULL,0,0,NULL,1,0),
	('11d20419-82bf-4a0d-8bb3-0072e871d549','Van','Le','van@gmail.com4','VAN@GMAIL.COM4','van@gmail.com4','VAN@GMAIL.COM4',1,'AQAAAAEAACcQAAAAEEE2VOu9o9ZpzhiTSSdnVrBBDBLdF/idYfQfJKlDZwRpBAT6/PFinpO6Bo+3D3rykA==','46GD4HXPXKHQMCCTSKGYOLFZT7XQ6ZLG','827fbe2a-9f43-4e18-a860-921fee11f789',NULL,0,0,NULL,1,0),
	('22f6cd79-7195-487b-8a34-44ed71bc9542',NULL,NULL,'vankuner0605@gmail.com1','VANKUNER0605@GMAIL.COM1','vankuner0605@gmail.com1','VANKUNER0605@GMAIL.COM1',1,'AQAAAAEAACcQAAAAEJzHJMJe/m4xuPPkB8uH/oIf1yIfsp8EBndsJCvwbkU1cUoV0B3r/CaY0lnngrjblg==','NADQLEL6JF3WRDOYROLA2XPIRMOSN3VY','89018e21-cd7a-48c8-803d-ea8041de941b',NULL,0,0,NULL,1,0),
	('28dadf91-a634-4b82-9929-2dc2e3c2e9f0','NhanOCcho','le','Nhan@gmail.com','NHAN@GMAIL.COM','Nhan@gmail.com','NHAN@GMAIL.COM',1,'AQAAAAEAACcQAAAAEESgswOGaVjTPnDbyz7ffHPKZ5ZAlPUKdRkBwZl9E+UEy1UP9ya6Z36RR9HUs+yqyQ==','G5TZMTFQCANHJPGGJIO5GJQG5M54FUR5','f5520897-9513-4f42-bf8d-4d889e44976b',NULL,0,0,NULL,1,0),
	('3b7ca625-c24a-4f08-9425-9ddafe5226c0',NULL,NULL,'van@gmail.com','VAN@GMAIL.COM','van@gmail.com','VAN@GMAIL.COM',1,'AQAAAAEAACcQAAAAENOYceKQYsmfhHCbNwC/5syrQR+AQkUGhkwU/iPq+2G0GVRK4IDOBELGEb5uJR46ew==','TKP5LI2QWQRBLRVDF45OQHCBXCD7V2XU','413a657b-7423-45d3-a5d8-f3cd268e15f8',NULL,0,0,NULL,1,0),
	('3c1c0811-0cc1-451a-bef2-8668ee2a5d58','Anh','Nguyen','Anh@gmail.com','ANH@GMAIL.COM','Anh@gmail.com','ANH@GMAIL.COM',1,'AQAAAAEAACcQAAAAEE6WyvlesZ5XJcHNhAzDVnag6Ugd9rMvJ5b9SCUEDwWFJoIIdPHeJMf0/Rl9p/rJwA==','YCLPEDXLHFDTEDQIW2HIN5GGJIWSKW36','b24f5f7c-cd9d-4434-9c90-985bfeb89668',NULL,0,0,NULL,1,0),
	('414930be-f621-4fa5-858c-7bf603e3483a','Nhan','le','Nhan@gmail.com2','NHAN@GMAIL.COM2','Nhan@gmail.com2','NHAN@GMAIL.COM2',1,'AQAAAAEAACcQAAAAELu6ynMJPPrs4QaB5ztHYwmvEgD9l513jQiQkQjq37DhTTduEJupWfbDZd1MQBb4Eg==','Y3KU2FSCVETJAS6FSQXHMGWAOGVY6LFD','6a1511ec-5061-4948-83e6-a9ac950625e0',NULL,0,0,NULL,1,0),
	('5f1f5d39-7375-4fce-8992-dd027b58ce29','Khuong','Doan','Khuong@gmail.com','KHUONG@GMAIL.COM','Khuong@gmail.com','KHUONG@GMAIL.COM',1,'AQAAAAEAACcQAAAAEOu7KduAixafT+latfGXPdbhcZGP7fwNfrsE6lSy1DyunlwpIw47+iONW6jAmv6Uiw==','DQPHQSZF27MN4MXK4XEQN43RYI3ZMH3G','b910f571-5f6d-4070-97be-f8c55dc9fcc2',NULL,0,0,NULL,1,0),
	('6bc94c15-7c6e-4027-bced-0f3838a28eed','luan','duong','luan@gmail.com1','LUAN@GMAIL.COM1','luan@gmail.com1','LUAN@GMAIL.COM1',1,'AQAAAAEAACcQAAAAEBaSVK/JzNrxTNR6SSnLXjYY8fOpzT0kCadNA6tKZTpXUfbgOw/aQr6skPO9Ko4UCA==','RTU6V67P4SNPF2LMEGXO4DHON7L7ER6I','aa3aaab0-1deb-4c68-b8ec-6958d6855454',NULL,0,0,NULL,1,0),
	('9b0e08e2-2314-4017-b508-45e014eddddd',NULL,NULL,'vankuner0605@gmail.com','VANKUNER0605@GMAIL.COM','vankuner0605@gmail.com','VANKUNER0605@GMAIL.COM',1,'AQAAAAEAACcQAAAAEGHHUAlLWPk4Ei7v+5kuwwd7vYjvoZBxTyzV9Ee2NGySVoTgv9aaMjyCoJLdqMvO/A==','YP3R7IFBM4FGOPINYHXA7MMM265JQWXV','50a20b19-2887-4278-aef6-a4a04de6e285',NULL,0,0,NULL,1,0),
	('9d261e9a-499e-424d-a3c2-87be1d634921','Truong','Le','Truong@gmail.com','TRUONG@GMAIL.COM','Truong@gmail.com','TRUONG@GMAIL.COM',1,'AQAAAAEAACcQAAAAEGzvaUD4nMwSA9Hg/gtJvh8fOFBLeN98L3FiG13hAY6zvNKJuTfdZEk+Xab5TXallQ==','S7JQEFLF5JDVDFH56TWFG6QVT5OEO7UY','84117289-5dc6-4893-a10e-046155187e98',NULL,0,0,NULL,1,0),
	('ba3d042b-bcf8-4c36-a3ce-d157d534c56c','Van','Hoang','van@gmail.com2','VAN@GMAIL.COM2','van@gmail.com2','VAN@GMAIL.COM2',1,'AQAAAAEAACcQAAAAEJT2IgrtUtSjYdDEl177YBusnT++y+jIwqq93/TznpNEfL+ACdzxjXvCDJAidolceA==','LZXWLRJF3B3M34BEG5IIMXC2SYERKRFI','bd3b5890-5c32-4396-afc6-b64ccfd008c3',NULL,0,0,NULL,1,0),
	('cfe37ffc-ba48-4f20-92d1-6f205b8f9696',NULL,NULL,'van.lbh1708@sinhvien.hoasen.edu.vn','VAN.LBH1708@SINHVIEN.HOASEN.EDU.VN','van.lbh1708@sinhvien.hoasen.edu.vn','VAN.LBH1708@SINHVIEN.HOASEN.EDU.VN',1,'AQAAAAEAACcQAAAAEBEihNg4Z2qBITzmMFWSPibxlQ3yIlh70NCd/d942+9cYYILqtdJoX8gXFVkF77ljA==','7MKB2UCLIULJK4PABQQ2KN6B7MK2SDFB','1ef42cdc-ac72-43cf-b6b9-a03e9b08ba83',NULL,0,0,NULL,1,0),
	('e8f1fe8e-82b4-4d19-a71d-9a4c8bfbbb5a',NULL,NULL,'luan@gmail.com','LUAN@GMAIL.COM','luan@gmail.com','LUAN@GMAIL.COM',1,'AQAAAAEAACcQAAAAEOcglUjfqKn0N+/PQ4vJcEFtY90dvEQqlC+OPxvg8vA8AbICNHF+9iKI0HzFe0MVnA==','O2I4U6SGEBGQQQLG5G6UXSUO2XXCKCI7','5ef5f378-9cf0-4861-8f14-6b7e7930955f',NULL,0,0,NULL,1,0),
	('ea497f0f-0c9d-44be-b9e3-16265a705716','Lanh','Nguyen','Lanh@gmail.com','LANH@GMAIL.COM','Lanh@gmail.com','LANH@GMAIL.COM',1,'AQAAAAEAACcQAAAAEIJ1NiZaawbLgdHGZHV+MGdZjVixccy69KuYC1wqABoaWRBXx4SnYRct2dj/w1GnJA==','7KCH6U73TPFKE4LNH3QZRJKTF3SGV7ND','e517ac22-b308-4c63-870c-4ad23acfeb66',NULL,0,0,NULL,1,0),
	('ef0d3a14-b554-4760-8d50-7d395c4cde37','Van','Hoang','van@gmail.com3','VAN@GMAIL.COM3','van@gmail.com3','VAN@GMAIL.COM3',1,'AQAAAAEAACcQAAAAEOkEJsCCZa0KeLDB2ig1I60wmBZpw0NktuMPLNIuCJPQ8XEKrb5rH5s/YeIeN1e6YA==','EJKN7SEAOHQX6KKEX4RWMIIYBIQCP563','afb66ac6-438d-49c3-b1bb-5ac461f5dc68',NULL,0,0,NULL,1,0),
	('ef221cfa-d9db-426a-b2ee-664c444fc802','Tuan','Le','Tuan@gmail.com','TUAN@GMAIL.COM','Tuan@gmail.com','TUAN@GMAIL.COM',1,'AQAAAAEAACcQAAAAEIyf+gC+3BvTmfm2oCY8Cf9NE2Vh32i6FiAihp0q9CPlGjyO+PV9aNtLJHwBlbqAXA==','4WAYALIZSSJ5GSA24K76ZWYZUY5B4UCF','219923fe-7c26-4e6f-907b-e8c151b1cf37',NULL,0,0,NULL,1,0),
	('f4c7a769-bc56-45e0-9ca8-f7ab356593b3','Van','Le bui Hoang','van@gmail.com1','VAN@GMAIL.COM1','van@gmail.com1','VAN@GMAIL.COM1',1,'AQAAAAEAACcQAAAAEEBMvmJeIBJM6yFbn/4mrgkRGBioHfV4Gz9sLxNCDnoq9S99eKZbjSuAnSKtAOyGeg==','XH3H45OFKYXFIVMBIOD55BOUCHFEFWS7','eebd90e6-752c-4d24-b40c-b9f62c4b1ebf',NULL,0,0,NULL,1,0),
	('ff9d6a40-a6fd-4f49-a063-2762bf205970','Thu','Huynh','thu@gmail.com','THU@GMAIL.COM','thu@gmail.com','THU@GMAIL.COM',1,'AQAAAAEAACcQAAAAEJUKt3Xy7veTHYMxv9z7WPc28YKFCcIFohe9gfNZnXSaJTb6fa2O0qiqQ3p2nhZFPw==','XXNSJBANGWCR6BIPETCQFPE4E5SZDB45','bd7f4612-1ede-4031-9fb8-bf84f30e04db',NULL,0,0,NULL,1,0);

/*!40000 ALTER TABLE `AspNetUsers` ENABLE KEYS */;
UNLOCK TABLES;


# Dump of table Catergory
# ------------------------------------------------------------

DROP TABLE IF EXISTS `Catergory`;

CREATE TABLE `Catergory` (
  `Catergory_ID` int unsigned NOT NULL AUTO_INCREMENT,
  `Catergory_Name` varchar(50) DEFAULT NULL,
  `Catergory_Description` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`Catergory_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

LOCK TABLES `Catergory` WRITE;
/*!40000 ALTER TABLE `Catergory` DISABLE KEYS */;

INSERT INTO `Catergory` (`Catergory_ID`, `Catergory_Name`, `Catergory_Description`)
VALUES
	(1,'Dien Thoai','Bao gom cac hang Dien Thoai: Apple, Samsung, Huawei, Xiaomi,...'),
	(2,'Laptop','Bao gom cac hang Laptop: Apple, Asus, Acer, ...'),
	(3,'Tablet','Bao gom cac hang Tablet: Apple, Samsung, Xiaomi,...'),
	(4,'Am Thanh','Bao gom cac hang Loa va Tai nghe: Apple, Samsung, JBL,...'),
	(5,'Dong Ho','Bao gom cac hang Dong Ho: Apple, Samsung, Xiaomi,...');

/*!40000 ALTER TABLE `Catergory` ENABLE KEYS */;
UNLOCK TABLES;


# Dump of table Customer
# ------------------------------------------------------------

DROP TABLE IF EXISTS `Customer`;

CREATE TABLE `Customer` (
  `Customer_ID` int unsigned NOT NULL AUTO_INCREMENT,
  `Customer_Name` varchar(50) DEFAULT NULL,
  `Customer_Phone` char(10) DEFAULT NULL,
  PRIMARY KEY (`Customer_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

LOCK TABLES `Customer` WRITE;
/*!40000 ALTER TABLE `Customer` DISABLE KEYS */;

INSERT INTO `Customer` (`Customer_ID`, `Customer_Name`, `Customer_Phone`)
VALUES
	(1,NULL,NULL),
	(2,NULL,NULL),
	(3,NULL,NULL),
	(4,NULL,NULL),
	(5,NULL,NULL);

/*!40000 ALTER TABLE `Customer` ENABLE KEYS */;
UNLOCK TABLES;


# Dump of table Order
# ------------------------------------------------------------

DROP TABLE IF EXISTS `Order`;

CREATE TABLE `Order` (
  `Order_ID` int unsigned NOT NULL AUTO_INCREMENT,
  `Order_Date` date DEFAULT NULL,
  `Order_Total` varchar(200) DEFAULT NULL,
  `Order_Status` varchar(200) DEFAULT NULL,
  `Customer_ID` int unsigned DEFAULT NULL,
  `Order_ShipAddress` varchar(200) DEFAULT '',
  `Order_ShipPhone` char(10) DEFAULT NULL,
  `Order_ShipName` varchar(200) DEFAULT NULL,
  `Order_ShipEmail` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`Order_ID`),
  KEY `FK_Customer_ID` (`Customer_ID`),
  CONSTRAINT `FK_Customer_ID` FOREIGN KEY (`Customer_ID`) REFERENCES `Customer` (`Customer_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;



# Dump of table OrderDetails
# ------------------------------------------------------------

DROP TABLE IF EXISTS `OrderDetails`;

CREATE TABLE `OrderDetails` (
  `OrderDetails_ID` int unsigned NOT NULL AUTO_INCREMENT,
  `Product_ID` int unsigned NOT NULL,
  `OrderDetails_Quantity` int DEFAULT NULL,
  `Order_ID` int unsigned NOT NULL,
  `OrderDetails_Price` int DEFAULT NULL,
  PRIMARY KEY (`OrderDetails_ID`),
  KEY `FK_Product_ID` (`Product_ID`),
  KEY `FK_Order_ID` (`Order_ID`),
  CONSTRAINT `FK_Order_ID` FOREIGN KEY (`Order_ID`) REFERENCES `Order` (`Order_ID`),
  CONSTRAINT `FK_Product_ID` FOREIGN KEY (`Product_ID`) REFERENCES `Product` (`Product_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;



# Dump of table Product
# ------------------------------------------------------------

DROP TABLE IF EXISTS `Product`;

CREATE TABLE `Product` (
  `Product_ID` int unsigned NOT NULL AUTO_INCREMENT,
  `Product_Name` varchar(50) DEFAULT NULL,
  `Product_Description` varchar(100) DEFAULT NULL,
  `Product_Price` int DEFAULT NULL,
  `Product_ImageURl` text,
  `Product_Quantity` int DEFAULT NULL,
  `Product_PromotionPrice` int DEFAULT NULL,
  `Catergory_ID` int unsigned NOT NULL,
  PRIMARY KEY (`Product_ID`),
  KEY `FK_Catergory_ID` (`Catergory_ID`),
  CONSTRAINT `FK_Catergory_ID` FOREIGN KEY (`Catergory_ID`) REFERENCES `Catergory` (`Catergory_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

LOCK TABLES `Product` WRITE;
/*!40000 ALTER TABLE `Product` DISABLE KEYS */;

INSERT INTO `Product` (`Product_ID`, `Product_Name`, `Product_Description`, `Product_Price`, `Product_ImageURl`, `Product_Quantity`, `Product_PromotionPrice`, `Catergory_ID`)
VALUES
	(1,'Iphone 13','Iphone 13 - Apple',24900000,'/images/DienThoai/Apple/ip13.jpg',2,2000000,1),
	(2,'Iphone 13 Mini','Iphone 13 Mini - Apple',21900000,'/images/DienThoai/Apple/ip13mini.jpg',3,1000000,1),
	(3,'Iphone 13 Pro','Iphone 13 Pro - Apple',30990000,'/images/DienThoai/Apple/ip13pro.jpg',4,3000000,1),
	(4,'Iphone 13 Pro Max','Iphone 13 Pro Max - Apple',33990000,'/images/DienThoai/Apple/ip13promax.jpg',5,3100000,1),
	(5,'Macbook Air 2020','Macbook Air 2020 - Apple',22450000,'/images/Laptop/Apple/MacbookAir2020.jpg',6,1500000,2),
	(6,'Macbook Pro 2020','Macbook Pro 2020 - Apple',28950000,'/images/Laptop/Apple/MacbookPro2020.jpg',7,2000000,2),
	(7,'Macbook Air M1 2020','Macbook Air M1 2020 - Apple',26650000,'/images/Laptop/Apple/MacbookAirM1.jpg',8,1800000,2),
	(8,'Macbook Pro M1 2020','Macbook Pro M1 2020 - Apple',32900000,'/images/Laptop/Apple/MacbookProM1.jpg',9,2500000,2),
	(9,'Ipad Pro 2020','Ipad Pro 2020 - Apple',18790000,'/images/Tablet/Apple/IpadPro2020.jpg',10,800000,3),
	(10,'Ipad Pro M1 2020','Ipad Pro M1 2020 - Apple',21990000,'/images/Tablet/Apple/IpadProM1.jpg',11,500000,3),
	(11,'Ipad Mini 6 2021','Ipad Mini 6 2021 - Apple',13950000,'/images/Tablet/Apple/IpadMini6.jpg',12,200000,3),
	(12,'Ipad Gen 9 2021','Ipad Gen 9 2021 - Apple',9290000,'/images/Tablet/Apple/IpadGen9.jpg',13,100000,3),
	(13,'AirPods 2','AirPods 2 - Apple',3290000,'/images/AmThanh/TaiNghe/Apple/AirPods2.jpg',14,100000,4),
	(14,'AirPods Pro','AirPods Pro - Apple',5090000,'/images/AmThanh/TaiNghe/Apple/AirPodsPro.jpg',15,200000,4),
	(15,'AirPods Max','AirPods Max - Apple ',11950000,'/images/AmThanh/TaiNghe/Apple/AirPodsMax.jpg',16,250000,4),
	(16,'AirPods 3','AirPods 3 - Apple',4990000,'/images/AmThanh/TaiNghe/Apple/AirPods3.jpg',17,200000,4);

/*!40000 ALTER TABLE `Product` ENABLE KEYS */;
UNLOCK TABLES;


# Dump of table Session
# ------------------------------------------------------------

DROP TABLE IF EXISTS `Session`;

CREATE TABLE `Session` (
  `Id` varchar(449) CHARACTER SET ascii COLLATE ascii_bin NOT NULL,
  `AbsoluteExpiration` datetime(6) DEFAULT NULL,
  `ExpiresAtTime` datetime(6) NOT NULL,
  `SlidingExpirationInSeconds` bigint DEFAULT NULL,
  `Value` longblob NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `Index_ExpiresAtTime` (`ExpiresAtTime`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;




/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
