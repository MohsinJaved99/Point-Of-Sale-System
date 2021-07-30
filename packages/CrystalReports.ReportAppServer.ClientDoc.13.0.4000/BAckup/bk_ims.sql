-- MySqlBackup.NET 2.0.9.2
-- Dump Time: 2020-12-16 16:20:13
-- --------------------------------------
-- Server version 10.1.31-MariaDB mariadb.org binary distribution


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES latin1 */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- 
-- Definition of bank_details_pos
-- 

DROP TABLE IF EXISTS `bank_details_pos`;
CREATE TABLE IF NOT EXISTS `bank_details_pos` (
  `Bank_Details_ID` int(11) NOT NULL AUTO_INCREMENT,
  `Bank_Name_ID` int(11) NOT NULL,
  `Bank_Branch` varchar(255) NOT NULL,
  `Bank_Acc_Name` varchar(255) NOT NULL,
  `Bank_Acc_Number` varchar(255) NOT NULL,
  `Bank_Acc_Balance` varchar(255) NOT NULL,
  `Bank_Acc_Status` tinyint(4) NOT NULL,
  PRIMARY KEY (`Bank_Details_ID`),
  UNIQUE KEY `Bank_Acc_Number` (`Bank_Acc_Number`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table bank_details_pos
-- 

/*!40000 ALTER TABLE `bank_details_pos` DISABLE KEYS */;
INSERT INTO `bank_details_pos`(`Bank_Details_ID`,`Bank_Name_ID`,`Bank_Branch`,`Bank_Acc_Name`,`Bank_Acc_Number`,`Bank_Acc_Balance`,`Bank_Acc_Status`) VALUES
(2,1,'Shalimar ','Muskan Khan','4201941480','320000',0);
/*!40000 ALTER TABLE `bank_details_pos` ENABLE KEYS */;

-- 
-- Definition of banks_pos
-- 

DROP TABLE IF EXISTS `banks_pos`;
CREATE TABLE IF NOT EXISTS `banks_pos` (
  `Bank_ID` int(11) NOT NULL AUTO_INCREMENT,
  `Bank_Name` varchar(255) NOT NULL,
  PRIMARY KEY (`Bank_ID`),
  UNIQUE KEY `Bank_Name` (`Bank_Name`)
) ENGINE=InnoDB AUTO_INCREMENT=29 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table banks_pos
-- 

/*!40000 ALTER TABLE `banks_pos` DISABLE KEYS */;
INSERT INTO `banks_pos`(`Bank_ID`,`Bank_Name`) VALUES
(25,'Al Baraka Bank'),
(9,'Allied Bank Limited'),
(8,'Askari Bank'),
(10,'Bank Al Falah'),
(11,'Bank Al Habib'),
(26,'Bank Islami Pakistan Limited'),
(7,'Bank of Azad Jammu & Kashmir'),
(4,'Bank of Khyber'),
(2,'Bank of Punjab'),
(24,'Dubai Islamic Bank'),
(12,'Faysal Bank'),
(27,'Finca Microfinance Bank'),
(5,'First Women Bank'),
(13,'Habib Bank Limited'),
(14,'Habib Metropolitan Bank'),
(15,'JS Bank'),
(22,'MCB Bank Limited'),
(23,'Meezan Bank Limited'),
(1,'National Bank of Pakistan'),
(16,'Samba Bank Limited'),
(17,'Silk Bank Limited'),
(3,'Sindh Bank'),
(19,'Soneri Bank'),
(18,'Standard Chartered Pakistan'),
(20,'Summit Bank'),
(28,'Telenor Microfinance Bank'),
(21,'United Bank Limited'),
(6,'Zarai Taraqiyati Bank Limited');
/*!40000 ALTER TABLE `banks_pos` ENABLE KEYS */;

-- 
-- Definition of branches_pos
-- 

DROP TABLE IF EXISTS `branches_pos`;
CREATE TABLE IF NOT EXISTS `branches_pos` (
  `Branch_ID` int(11) NOT NULL AUTO_INCREMENT,
  `Branch_Head` varchar(255) NOT NULL,
  `Branch_Area` varchar(255) NOT NULL,
  `Branch_Phone` varchar(255) NOT NULL,
  `Branch_Status` varchar(20) NOT NULL,
  PRIMARY KEY (`Branch_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table branches_pos
-- 

/*!40000 ALTER TABLE `branches_pos` DISABLE KEYS */;
INSERT INTO `branches_pos`(`Branch_ID`,`Branch_Head`,`Branch_Area`,`Branch_Phone`,`Branch_Status`) VALUES
(19,'Muhammad Asif','M.A. Jinnah Road','0317004706','Active'),
(20,'Junaid Iqbal','Gulistan-e-Jauhar','03481139913','Active');
/*!40000 ALTER TABLE `branches_pos` ENABLE KEYS */;

-- 
-- Definition of cash_details_pos
-- 

DROP TABLE IF EXISTS `cash_details_pos`;
CREATE TABLE IF NOT EXISTS `cash_details_pos` (
  `Cash_ID` int(11) NOT NULL AUTO_INCREMENT,
  `Cash_Branch` int(11) NOT NULL,
  `Cash_Current_Amount` varchar(255) NOT NULL,
  `Cash_Date` varchar(255) NOT NULL,
  PRIMARY KEY (`Cash_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table cash_details_pos
-- 

/*!40000 ALTER TABLE `cash_details_pos` DISABLE KEYS */;

/*!40000 ALTER TABLE `cash_details_pos` ENABLE KEYS */;

-- 
-- Definition of credit_sale
-- 

DROP TABLE IF EXISTS `credit_sale`;
CREATE TABLE IF NOT EXISTS `credit_sale` (
  `Credit_Sale_ID` int(11) NOT NULL AUTO_INCREMENT,
  `Credit_Order_ID` int(11) NOT NULL,
  `Credit_Customer_ID` int(11) NOT NULL,
  `Credit_Date` varchar(100) NOT NULL,
  `Paying_Date` varchar(100) NOT NULL,
  `Credit_Amount` int(11) NOT NULL,
  PRIMARY KEY (`Credit_Sale_ID`),
  KEY `Credit_Order_ID` (`Credit_Order_ID`),
  KEY `Credit_Customer_ID` (`Credit_Customer_ID`),
  CONSTRAINT `credit_sale_ibfk_1` FOREIGN KEY (`Credit_Order_ID`) REFERENCES `sale_order` (`Order_ID`),
  CONSTRAINT `credit_sale_ibfk_2` FOREIGN KEY (`Credit_Customer_ID`) REFERENCES `customers_pos` (`Customer_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table credit_sale
-- 

/*!40000 ALTER TABLE `credit_sale` DISABLE KEYS */;
INSERT INTO `credit_sale`(`Credit_Sale_ID`,`Credit_Order_ID`,`Credit_Customer_ID`,`Credit_Date`,`Paying_Date`,`Credit_Amount`) VALUES
(5,97,7,'11-December-2020','12-December-2020',45000);
/*!40000 ALTER TABLE `credit_sale` ENABLE KEYS */;

-- 
-- Definition of customers_pos
-- 

DROP TABLE IF EXISTS `customers_pos`;
CREATE TABLE IF NOT EXISTS `customers_pos` (
  `Customer_ID` int(11) NOT NULL AUTO_INCREMENT,
  `Customer_Name` varchar(255) NOT NULL,
  `Customer_NIC` varchar(20) NOT NULL,
  `Customer_Phone` varchar(255) NOT NULL,
  `Customer_Mail` varchar(255) NOT NULL,
  `Customer_Address` varchar(255) NOT NULL,
  PRIMARY KEY (`Customer_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table customers_pos
-- 

/*!40000 ALTER TABLE `customers_pos` DISABLE KEYS */;
INSERT INTO `customers_pos`(`Customer_ID`,`Customer_Name`,`Customer_NIC`,`Customer_Phone`,`Customer_Mail`,`Customer_Address`) VALUES
(3,'Muhammad Asif','42101-2354319-1','03190908378','myp0758@gmail.com','Shadman Town'),
(5,'Abid Ali','42101-2222631-9','03412412331','abid@gmail.com','ABC'),
(6,'Muhammad Hamza','42101-2226431-9','03451234567','hamzagmail.com','abidabad'),
(7,'Sheeraz','42401-4097731-5','03111282842','sheraz@gmail.com','Shadman Town');
/*!40000 ALTER TABLE `customers_pos` ENABLE KEYS */;

-- 
-- Definition of daily_expense_pos
-- 

DROP TABLE IF EXISTS `daily_expense_pos`;
CREATE TABLE IF NOT EXISTS `daily_expense_pos` (
  `Expense_ID` int(11) NOT NULL AUTO_INCREMENT,
  `Expense_Purpose` varchar(255) NOT NULL,
  `Expense_Amount` varchar(255) NOT NULL,
  `Expense_Date` varchar(50) NOT NULL,
  PRIMARY KEY (`Expense_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table daily_expense_pos
-- 

/*!40000 ALTER TABLE `daily_expense_pos` DISABLE KEYS */;
INSERT INTO `daily_expense_pos`(`Expense_ID`,`Expense_Purpose`,`Expense_Amount`,`Expense_Date`) VALUES
(2,'Lunch','300','09-November-2020'),
(3,'Anday Wala Burger','100','16-December-2020');
/*!40000 ALTER TABLE `daily_expense_pos` ENABLE KEYS */;

-- 
-- Definition of discount_card_pos
-- 

DROP TABLE IF EXISTS `discount_card_pos`;
CREATE TABLE IF NOT EXISTS `discount_card_pos` (
  `DC_Card_Number` varchar(255) NOT NULL,
  `Serial_Number` varchar(20) NOT NULL,
  `DC_Customer_ID` int(11) NOT NULL,
  `DC_Current_Points` int(11) NOT NULL,
  `DC_Start_Date` varchar(255) NOT NULL,
  PRIMARY KEY (`DC_Card_Number`),
  UNIQUE KEY `DC_Card_Number` (`DC_Card_Number`),
  KEY `DC_Customer_ID` (`DC_Customer_ID`),
  CONSTRAINT `discount_card_pos_ibfk_1` FOREIGN KEY (`DC_Customer_ID`) REFERENCES `customers_pos` (`Customer_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table discount_card_pos
-- 

/*!40000 ALTER TABLE `discount_card_pos` DISABLE KEYS */;
INSERT INTO `discount_card_pos`(`DC_Card_Number`,`Serial_Number`,`DC_Customer_ID`,`DC_Current_Points`,`DC_Start_Date`) VALUES
('4ckjCsWjl7iew5uVdJYFhtyoh','718258070',3,0,'08-December-2020'),
('BOTFlHGyTSA310Oas53QCv4UY','23029536',5,870,'04-December-2020'),
('dp1Poi08lhGpmLLL6Zk2dUN33','478482312',6,1740,'28-November-2020'),
('TxozekKSFbTADnYZsAssyIWsO','310764671',7,1625,'05-December-2020');
/*!40000 ALTER TABLE `discount_card_pos` ENABLE KEYS */;

-- 
-- Definition of discount_point_in_pos
-- 

DROP TABLE IF EXISTS `discount_point_in_pos`;
CREATE TABLE IF NOT EXISTS `discount_point_in_pos` (
  `Discount_In_ID` int(11) NOT NULL AUTO_INCREMENT,
  `Discount_In_Card_ID` varchar(255) NOT NULL,
  `Discount_In_Points` int(11) NOT NULL,
  `Discount_In_Start_Date` varchar(255) NOT NULL,
  `Discount_In_Activation_Date` varchar(50) NOT NULL,
  `Discound_In_Status` varchar(20) NOT NULL,
  PRIMARY KEY (`Discount_In_ID`),
  KEY `Discount_In_Card_ID` (`Discount_In_Card_ID`),
  CONSTRAINT `discount_point_in_pos_ibfk_1` FOREIGN KEY (`Discount_In_Card_ID`) REFERENCES `discount_card_pos` (`DC_Card_Number`)
) ENGINE=InnoDB AUTO_INCREMENT=56 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table discount_point_in_pos
-- 

/*!40000 ALTER TABLE `discount_point_in_pos` DISABLE KEYS */;
INSERT INTO `discount_point_in_pos`(`Discount_In_ID`,`Discount_In_Card_ID`,`Discount_In_Points`,`Discount_In_Start_Date`,`Discount_In_Activation_Date`,`Discound_In_Status`) VALUES
(27,'dp1Poi08lhGpmLLL6Zk2dUN33',700,'28-November-2020','01-December-2020','Activated'),
(28,'dp1Poi08lhGpmLLL6Zk2dUN33',95,'28-November-2020','01-December-2020','Activated'),
(29,'dp1Poi08lhGpmLLL6Zk2dUN33',450,'01-December-2020','04-December-2020','Activated'),
(30,'TxozekKSFbTADnYZsAssyIWsO',887,'05-December-2020','08-December-2020','Activated'),
(31,'TxozekKSFbTADnYZsAssyIWsO',340,'05-December-2020','08-December-2020','Activated'),
(32,'dp1Poi08lhGpmLLL6Zk2dUN33',450,'05-December-2020','08-December-2020','Activated'),
(34,'BOTFlHGyTSA310Oas53QCv4UY',340,'05-December-2020','08-December-2020','Activated'),
(35,'BOTFlHGyTSA310Oas53QCv4UY',340,'05-December-2020','08-December-2020','Activated'),
(36,'TxozekKSFbTADnYZsAssyIWsO',190,'05-December-2020','08-December-2020','Activated'),
(37,'dp1Poi08lhGpmLLL6Zk2dUN33',95,'05-December-2020','08-December-2020','Activated'),
(38,'TxozekKSFbTADnYZsAssyIWsO',190,'05-December-2020','08-December-2020','Activated'),
(39,'BOTFlHGyTSA310Oas53QCv4UY',95,'07-December-2020','10-December-2020','Activated'),
(40,'BOTFlHGyTSA310Oas53QCv4UY',95,'07-December-2020','10-December-2020','Activated'),
(45,'TxozekKSFbTADnYZsAssyIWsO',95,'09-December-2020','12-December-2020','Activated'),
(46,'TxozekKSFbTADnYZsAssyIWsO',95,'10-December-2020','13-December-2020','Inactive'),
(47,'TxozekKSFbTADnYZsAssyIWsO',536,'10-December-2020','13-December-2020','Inactive'),
(48,'TxozekKSFbTADnYZsAssyIWsO',95,'10-December-2020','13-December-2020','Inactive'),
(49,'dp1Poi08lhGpmLLL6Zk2dUN33',95,'11-December-2020','14-December-2020','Activated'),
(50,'TxozekKSFbTADnYZsAssyIWsO',95,'11-December-2020','14-December-2020','Activated'),
(51,'TxozekKSFbTADnYZsAssyIWsO',95,'11-December-2020','14-December-2020','Activated'),
(52,'TxozekKSFbTADnYZsAssyIWsO',340,'11-December-2020','14-December-2020','Activated'),
(53,'4ckjCsWjl7iew5uVdJYFhtyoh',95,'14-December-2020','17-December-2020','Inactive'),
(55,'dp1Poi08lhGpmLLL6Zk2dUN33',95,'14-December-2020','17-December-2020','Inactive');
/*!40000 ALTER TABLE `discount_point_in_pos` ENABLE KEYS */;

-- 
-- Definition of discount_point_out_pos
-- 

DROP TABLE IF EXISTS `discount_point_out_pos`;
CREATE TABLE IF NOT EXISTS `discount_point_out_pos` (
  `Discount_Out_ID` int(11) NOT NULL AUTO_INCREMENT,
  `Disccount_Out_Card_ID` varchar(200) NOT NULL,
  `Discount_Out_Redeem_Points` int(11) NOT NULL,
  `Discount_Out_Redeem_Date` varchar(255) NOT NULL,
  PRIMARY KEY (`Discount_Out_ID`),
  KEY `Disccount_Out_Card_ID` (`Disccount_Out_Card_ID`),
  CONSTRAINT `discount_point_out_pos_ibfk_1` FOREIGN KEY (`Disccount_Out_Card_ID`) REFERENCES `discount_card_pos` (`DC_Card_Number`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table discount_point_out_pos
-- 

/*!40000 ALTER TABLE `discount_point_out_pos` DISABLE KEYS */;
INSERT INTO `discount_point_out_pos`(`Discount_Out_ID`,`Disccount_Out_Card_ID`,`Discount_Out_Redeem_Points`,`Discount_Out_Redeem_Date`) VALUES
(1,'dp1Poi08lhGpmLLL6Zk2dUN33',95,'01-December-2020'),
(2,'dp1Poi08lhGpmLLL6Zk2dUN33',50,'05-December-2020'),
(3,'TxozekKSFbTADnYZsAssyIWsO',607,'10-December-2020');
/*!40000 ALTER TABLE `discount_point_out_pos` ENABLE KEYS */;

-- 
-- Definition of license
-- 

DROP TABLE IF EXISTS `license`;
CREATE TABLE IF NOT EXISTS `license` (
  `Lisense_Key` varchar(100) NOT NULL,
  `User_IP` varchar(100) DEFAULT NULL,
  `Start_Date` varchar(100) DEFAULT NULL,
  `Expire_Date` varchar(100) DEFAULT NULL,
  `Unlimited` varchar(100) NOT NULL DEFAULT 'False',
  `Status` varchar(100) NOT NULL DEFAULT 'Inactive',
  PRIMARY KEY (`Lisense_Key`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table license
-- 

/*!40000 ALTER TABLE `license` DISABLE KEYS */;
INSERT INTO `license`(`Lisense_Key`,`User_IP`,`Start_Date`,`Expire_Date`,`Unlimited`,`Status`) VALUES
('2VCGQ-BRVJ4-2HGJ2-K36X9-J66JG','',NULL,NULL,'True','Inactive'),
('4FMW9-MXPRT-3KQ3C-63D3T-X9JTH','9439E569C90A','16-December-2020','16-January-2021','False','Activated'),
('9D7WR-JB2Q4-9G6W9-B9327-28H4R',NULL,NULL,NULL,'False','Inactive'),
('BF9J7-HKCFK-D2TCB-TPH7R-43CD8',NULL,NULL,NULL,'False','Inactive'),
('CMBJC-VHBMB-C4H3F-QCXGM-X48JP',NULL,NULL,NULL,'False','Inactive'),
('D8BMB-BVGMF-M9PTV-HWDQW-HPCXX','','','','False','Inactive'),
('FJHWT-KDGHY-K2384-93CT7-323RC',NULL,NULL,NULL,'False','Inactive'),
('GQ6JK-GQXQV-WJJ87-R4MKB-FKQGF',NULL,NULL,NULL,'False','Inactive'),
('HXJC9-DYFJ8-4R2TV-2X4FK-Y2JBH',NULL,NULL,NULL,'False','Inactive'),
('J3MPD-MX97W-MM34H-RYR23-C2MGX',NULL,NULL,NULL,'False','Inactive'),
('J783Y-JKQWR-677Q8-KCXTF-BHWGC','',NULL,NULL,'True','Inactive'),
('J78FT-J48BQ-HH2M7-CYVTM-MXRHY',NULL,NULL,NULL,'False','Inactive'),
('J9GR3-BG6D8-BDTWB-HTW6M-9MF4C',NULL,NULL,NULL,'False','Inactive'),
('KJYJB-GDCGX-2DKYQ-XY3YF-TF3FW',NULL,NULL,NULL,'False','Inactive'),
('MGX79-TPQB9-KQ248-KXR2V-DHRTD',NULL,NULL,NULL,'True','Inactive'),
('PVMYG-HQDP7-PHHFT-X2PBD-6VDX4',NULL,NULL,NULL,'False','Inactive'),
('TFP9Y-VCY3P-VVH3T-8XXCC-MF4YK',NULL,NULL,NULL,'False','Inactive'),
('THHH2-RKK9T-FX6HM-QXT86-MGBCP',NULL,NULL,NULL,'False','Inactive'),
('V2KHD-CXKRG-VQB7C-GXCX3-K9B6K',NULL,NULL,NULL,'False','Inactive'),
('VT4PJ-KTF64-JYWB8-QV9YQ-2PTGG',NULL,NULL,NULL,'False','Inactive');
/*!40000 ALTER TABLE `license` ENABLE KEYS */;

-- 
-- Definition of product_brands_pos
-- 

DROP TABLE IF EXISTS `product_brands_pos`;
CREATE TABLE IF NOT EXISTS `product_brands_pos` (
  `Product_Brand_ID` int(11) NOT NULL AUTO_INCREMENT,
  `Product_Brand_Name` varchar(255) NOT NULL,
  `Product_Brand_Status` tinyint(11) NOT NULL,
  PRIMARY KEY (`Product_Brand_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4;

-- 
-- Dumping data for table product_brands_pos
-- 

/*!40000 ALTER TABLE `product_brands_pos` DISABLE KEYS */;
INSERT INTO `product_brands_pos`(`Product_Brand_ID`,`Product_Brand_Name`,`Product_Brand_Status`) VALUES
(6,'Pel',0),
(7,'Haier',0),
(8,'Electrolux',0),
(9,'Waves',0),
(10,'Samsung',0);
/*!40000 ALTER TABLE `product_brands_pos` ENABLE KEYS */;

-- 
-- Definition of product_category_pos
-- 

DROP TABLE IF EXISTS `product_category_pos`;
CREATE TABLE IF NOT EXISTS `product_category_pos` (
  `Product_Category_ID` int(11) NOT NULL AUTO_INCREMENT,
  `Product_Category_Name` varchar(255) NOT NULL,
  `Product_Category_Status` tinyint(4) NOT NULL,
  PRIMARY KEY (`Product_Category_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table product_category_pos
-- 

/*!40000 ALTER TABLE `product_category_pos` DISABLE KEYS */;
INSERT INTO `product_category_pos`(`Product_Category_ID`,`Product_Category_Name`,`Product_Category_Status`) VALUES
(7,'Air Conditioners',0),
(8,'Microwave Ovens',0),
(9,'Refrigerator',0),
(10,'Deep Frezer',0),
(11,'Mobile',0);
/*!40000 ALTER TABLE `product_category_pos` ENABLE KEYS */;

-- 
-- Definition of products_pos
-- 

DROP TABLE IF EXISTS `products_pos`;
CREATE TABLE IF NOT EXISTS `products_pos` (
  `Product_ID` int(11) NOT NULL AUTO_INCREMENT,
  `Product_Cat_ID` int(11) NOT NULL,
  `Product_Name` varchar(255) NOT NULL,
  `Pro_Brand_ID` int(11) NOT NULL,
  `Product_Quantity` int(11) NOT NULL,
  `Product_Model` varchar(255) NOT NULL,
  `Product_Color` varchar(255) NOT NULL,
  `Product_Material` varchar(255) NOT NULL,
  `Product_Price` varchar(255) DEFAULT NULL,
  `Product_Comission_Percentage` varchar(255) DEFAULT NULL,
  `Product_Comission_Price` varchar(255) NOT NULL,
  `Product_Remarks` varchar(255) DEFAULT NULL,
  `Product_Entry_Date` varchar(50) NOT NULL,
  PRIMARY KEY (`Product_ID`),
  KEY `Product_Cat_ID` (`Product_Cat_ID`),
  KEY `Pro_Brand_ID` (`Pro_Brand_ID`),
  CONSTRAINT `products_pos_ibfk_1` FOREIGN KEY (`Product_Cat_ID`) REFERENCES `product_category_pos` (`Product_Category_ID`),
  CONSTRAINT `products_pos_ibfk_2` FOREIGN KEY (`Pro_Brand_ID`) REFERENCES `product_brands_pos` (`Product_Brand_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table products_pos
-- 

/*!40000 ALTER TABLE `products_pos` DISABLE KEYS */;
INSERT INTO `products_pos`(`Product_ID`,`Product_Cat_ID`,`Product_Name`,`Pro_Brand_ID`,`Product_Quantity`,`Product_Model`,`Product_Color`,`Product_Material`,`Product_Price`,`Product_Comission_Percentage`,`Product_Comission_Price`,`Product_Remarks`,`Product_Entry_Date`) VALUES
(1,8,'Classic Plus Microwave',6,3,'Classic Plus','Black','Shiny','9200','400','9400','-','17/09/2020 11:19:10 pm'),
(2,9,'Life Refrigerator',6,8,'PRL - 2000','Golden','Shiny','30000',NULL,'33000','-','17/09/2020 11:20:55 pm'),
(3,7,'Split Airconditioner Titan\r\n',8,5,'Ecogreen 1923','Grey','Glossy','78500','','79000','1.5 ton','17/09/2020 11:25:55 pm'),
(5,8,'Classic Microwave',6,8,'WGM','White','Shiny','9100',NULL,'9300','-','11/25/2020 12:49:41 PM'),
(6,10,'Haier HDF-325H',7,10,'Regular Series','White','-','43000',NULL,'44000','-','11/28/2020 10:38:02 AM'),
(7,9,'Product',6,2,'123','Black','Fold','5000',NULL,'5000','None','12/9/2020 4:40:00 PM'),
(8,11,'Samsung Smartphone',10,5,'J6','Black','Shiny','27000',NULL,'28000','-','12-December-2020');
/*!40000 ALTER TABLE `products_pos` ENABLE KEYS */;

-- 
-- Definition of purchase_details_pos
-- 

DROP TABLE IF EXISTS `purchase_details_pos`;
CREATE TABLE IF NOT EXISTS `purchase_details_pos` (
  `PD_ID` int(11) NOT NULL AUTO_INCREMENT,
  `PD_Purchase_ID` int(11) NOT NULL,
  `PD_Product_ID` int(11) NOT NULL,
  `PD_Product_Price` varchar(50) NOT NULL,
  `PD_Purchase_Discount` varchar(20) NOT NULL,
  `PD_Product_Quantity` varchar(50) NOT NULL,
  `PD_Product_Total_Price` varchar(50) NOT NULL,
  PRIMARY KEY (`PD_ID`),
  KEY `PD_Purchase_ID` (`PD_Purchase_ID`),
  KEY `PD_Product_ID` (`PD_Product_ID`),
  CONSTRAINT `purchase_details_pos_ibfk_1` FOREIGN KEY (`PD_Purchase_ID`) REFERENCES `purchase_pos` (`Purchase_ID`),
  CONSTRAINT `purchase_details_pos_ibfk_2` FOREIGN KEY (`PD_Product_ID`) REFERENCES `products_pos` (`Product_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=149 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table purchase_details_pos
-- 

/*!40000 ALTER TABLE `purchase_details_pos` DISABLE KEYS */;
INSERT INTO `purchase_details_pos`(`PD_ID`,`PD_Purchase_ID`,`PD_Product_ID`,`PD_Product_Price`,`PD_Purchase_Discount`,`PD_Product_Quantity`,`PD_Product_Total_Price`) VALUES
(113,17,2,'60000','0','2','60000'),
(114,18,1,'46000','0','5','46000'),
(115,19,1,'18400','0','2','18400'),
(116,21,6,'129000','1290','3','127710'),
(117,22,1,'27600','0','3','27600'),
(118,23,1,'18400','0','2','18400'),
(120,25,1,'46000','0','5','46000'),
(122,27,2,'90000','0','3','90000'),
(123,28,2,'300000','3000','10','297000'),
(124,29,6,'430000','4300','10','425700'),
(126,31,5,'27300','0','3','27300'),
(127,32,1,'27600','0','3','27600'),
(128,33,6,'86000','0','2','86000'),
(130,35,5,'18200','0','2','18200'),
(131,36,1,'18400','0','2','18400'),
(132,37,1,'18400','0','2','18400'),
(133,38,6,'86000','0','2','86000'),
(134,39,1,'18400','0','2','18400'),
(135,40,5,'27300','0','3','27300'),
(136,41,2,'60000','0','2','60000'),
(137,42,1,'18400','0','2','18400'),
(138,43,1,'9200','0','1','9200'),
(139,44,1,'18400','0','2','18400'),
(140,45,1,'9200','0','1','9200'),
(141,46,1,'9200','0','1','9200'),
(142,47,1,'9200','0','1','9200'),
(143,48,1,'9200','0','1','9200'),
(144,49,7,'10000','1000','2','9000'),
(145,50,1,'18400','0','2','18400'),
(146,51,1,'9200','0','1','9200'),
(147,52,1,'18400','0','2','18400'),
(148,53,8,'135000','0','5','135000');
/*!40000 ALTER TABLE `purchase_details_pos` ENABLE KEYS */;

-- 
-- Definition of purchase_pos
-- 

DROP TABLE IF EXISTS `purchase_pos`;
CREATE TABLE IF NOT EXISTS `purchase_pos` (
  `Purchase_ID` int(11) NOT NULL AUTO_INCREMENT,
  `Purchase_Date` varchar(50) NOT NULL,
  `Purchase_Done_By` int(11) NOT NULL,
  `Purchase_Supplier_ID` int(11) NOT NULL,
  `Serial_Number` varchar(20) NOT NULL,
  PRIMARY KEY (`Purchase_ID`),
  KEY `Purchase_Supplier_ID` (`Purchase_Supplier_ID`),
  KEY `Purchase_Done_By` (`Purchase_Done_By`),
  CONSTRAINT `purchase_pos_ibfk_1` FOREIGN KEY (`Purchase_Supplier_ID`) REFERENCES `suppliers_pos` (`Supplier_ID`),
  CONSTRAINT `purchase_pos_ibfk_2` FOREIGN KEY (`Purchase_Done_By`) REFERENCES `users_pos` (`User_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=54 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table purchase_pos
-- 

/*!40000 ALTER TABLE `purchase_pos` DISABLE KEYS */;
INSERT INTO `purchase_pos`(`Purchase_ID`,`Purchase_Date`,`Purchase_Done_By`,`Purchase_Supplier_ID`,`Serial_Number`) VALUES
(17,'28-November-2020',14,1,'159223356'),
(18,'28-November-2020',16,1,'873941707'),
(19,'28-November-2020',14,2,'764249755'),
(20,'01-December-2020',14,2,'117400643'),
(21,'01-December-2020',14,2,'104106234'),
(22,'03-December-2020',14,1,'595746600'),
(23,'03-December-2020',14,1,'250258833'),
(24,'04-December-2020',14,1,'682858092'),
(25,'05-December-2020',14,1,'999375695'),
(26,'05-December-2020',14,2,'29633322'),
(27,'05-December-2020',14,1,'501474211'),
(28,'05-December-2020',14,2,'850916043'),
(29,'05-December-2020',14,1,'190893778'),
(30,'05-December-2020',14,1,'910733363'),
(31,'05-December-2020',14,1,'267161764'),
(32,'05-December-2020',14,1,'516306157'),
(33,'05-December-2020',14,2,'84484363'),
(34,'05-December-2020',14,2,'656871832'),
(35,'05-December-2020',14,2,'722279993'),
(36,'05-December-2020',14,1,'870756322'),
(37,'05-December-2020',14,1,'21476824'),
(38,'05-December-2020',14,1,'469144043'),
(39,'05-December-2020',14,1,'248412639'),
(40,'05-December-2020',14,1,'558574219'),
(41,'05-December-2020',14,1,'113821437'),
(42,'05-December-2020',14,2,'813293666'),
(43,'05-December-2020',14,1,'919858035'),
(44,'05-December-2020',14,1,'542509708'),
(45,'05-December-2020',14,2,'548327239'),
(46,'07-December-2020',14,2,'358291575'),
(47,'07-December-2020',14,1,'171761900'),
(48,'07-December-2020',14,1,'703138642'),
(49,'09-December-2020',14,1,'747741263'),
(50,'10-December-2020',14,1,'509911619'),
(51,'10-December-2020',14,1,'103563116'),
(52,'10-December-2020',14,1,'124700749'),
(53,'12-December-2020',14,2,'268080941');
/*!40000 ALTER TABLE `purchase_pos` ENABLE KEYS */;

-- 
-- Definition of roles_pos
-- 

DROP TABLE IF EXISTS `roles_pos`;
CREATE TABLE IF NOT EXISTS `roles_pos` (
  `Role_ID` int(11) NOT NULL AUTO_INCREMENT,
  `Role_Name` varchar(255) NOT NULL,
  PRIMARY KEY (`Role_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table roles_pos
-- 

/*!40000 ALTER TABLE `roles_pos` DISABLE KEYS */;
INSERT INTO `roles_pos`(`Role_ID`,`Role_Name`) VALUES
(1,'Admin'),
(2,'User');
/*!40000 ALTER TABLE `roles_pos` ENABLE KEYS */;

-- 
-- Definition of sale_order
-- 

DROP TABLE IF EXISTS `sale_order`;
CREATE TABLE IF NOT EXISTS `sale_order` (
  `Order_ID` int(11) NOT NULL AUTO_INCREMENT,
  `Serial_Number` varchar(15) NOT NULL,
  `Order_Date` varchar(50) NOT NULL,
  `Order_Customer_ID` int(11) NOT NULL,
  `Order_DoneBy` int(11) NOT NULL,
  `Order_Type` varchar(50) NOT NULL,
  `Order_Bank_Account_ID` int(11) DEFAULT NULL,
  `Order_Total_Price` int(11) NOT NULL,
  `Order_Paid_Amount` int(11) NOT NULL,
  `Order_Discount_Card_ID` varchar(255) DEFAULT NULL,
  `Order_Paid_Amount_By_Point` int(11) DEFAULT NULL,
  PRIMARY KEY (`Order_ID`),
  KEY `Order_Bank_Account_ID` (`Order_Bank_Account_ID`),
  KEY `Order_Customer_ID` (`Order_Customer_ID`),
  KEY `Order_DoneBy` (`Order_DoneBy`),
  KEY `Order_Discount_Card_ID` (`Order_Discount_Card_ID`),
  CONSTRAINT `sale_order_ibfk_2` FOREIGN KEY (`Order_Bank_Account_ID`) REFERENCES `bank_details_pos` (`Bank_Details_ID`),
  CONSTRAINT `sale_order_ibfk_3` FOREIGN KEY (`Order_Customer_ID`) REFERENCES `customers_pos` (`Customer_ID`),
  CONSTRAINT `sale_order_ibfk_4` FOREIGN KEY (`Order_DoneBy`) REFERENCES `users_pos` (`User_ID`),
  CONSTRAINT `sale_order_ibfk_5` FOREIGN KEY (`Order_Discount_Card_ID`) REFERENCES `discount_card_pos` (`DC_Card_Number`)
) ENGINE=InnoDB AUTO_INCREMENT=101 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table sale_order
-- 

/*!40000 ALTER TABLE `sale_order` DISABLE KEYS */;
INSERT INTO `sale_order`(`Order_ID`,`Serial_Number`,`Order_Date`,`Order_Customer_ID`,`Order_DoneBy`,`Order_Type`,`Order_Bank_Account_ID`,`Order_Total_Price`,`Order_Paid_Amount`,`Order_Discount_Card_ID`,`Order_Paid_Amount_By_Point`) VALUES
(57,'768370117','28-November-2020',6,14,'Cash',NULL,70000,70000,NULL,0),
(58,'53063199','28-November-2020',6,16,'Cash',NULL,9500,9500,NULL,0),
(59,'174136112','28-November-2020',5,14,'Cash',NULL,38000,38000,NULL,0),
(61,'443394385','01-December-2020',6,14,'Cash',NULL,90000,89905,NULL,95),
(65,'133582954','03-December-2020',3,14,'Bank',2,45000,45000,NULL,0),
(66,'489502336','03-December-2020',3,14,'Bank',2,9500,9500,NULL,0),
(67,'948642061','03-December-2020',5,14,'Cash',NULL,38000,38000,NULL,0),
(68,'159349833','04-December-2020',5,14,'Cash',NULL,160000,160000,NULL,0),
(69,'593232901','05-December-2020',7,18,'Bank',2,180000,180000,NULL,0),
(70,'593232901','05-December-2020',7,18,'Bank',2,180000,180000,NULL,0),
(71,'218738783','05-December-2020',7,14,'Cash',NULL,88700,88700,NULL,0),
(72,'26576702','05-December-2020',7,14,'Cash',NULL,34000,34000,NULL,0),
(73,'772969108','05-December-2020',6,14,'Cash',NULL,45000,44950,NULL,50),
(74,'469071934','05-December-2020',5,14,'Cash',NULL,34000,34000,NULL,0),
(75,'448605712','05-December-2020',5,14,'Cash',NULL,34000,34000,NULL,0),
(76,'364173907','05-December-2020',7,14,'',NULL,19000,19000,NULL,0),
(77,'622486523','05-December-2020 02:18:18 PM',3,14,'Cash',NULL,9500,9500,NULL,0),
(78,'338645299','05-December-2020 02:20:29 PM',6,14,'Cash',NULL,9500,9500,NULL,1100),
(79,'896039203','05-December-2020 02:49:53 PM',3,14,'Cash',NULL,9500,9500,NULL,0),
(80,'807499035','05-December-2020 05:29:52 PM',7,14,'Cash',NULL,19000,19000,NULL,0),
(81,'371811411','07-December-2020 04:36:11 PM',3,14,'Cash',NULL,9500,9500,NULL,0),
(82,'140327024','07-December-2020 04:39:40 PM',5,14,'Cash',NULL,9500,9500,NULL,0),
(83,'117042589','07-December-2020 04:40:30 PM',5,14,'Cash',NULL,9500,9500,NULL,0),
(84,'513245695','08-December-2020 10:33:45 AM',3,14,'Cash',NULL,105000,105000,NULL,0),
(88,'61716478','09-December-2020 03:00:51 PM',7,14,'Cash',NULL,9500,9500,NULL,0),
(89,'251175471','10-December-2020 09:59:28 AM',7,14,'Cash',NULL,9500,9500,NULL,0),
(90,'483427609','10-December-2020 10:00:40 AM',7,14,'Cash',NULL,53604,53604,NULL,0),
(91,'483427609','10-December-2020 10:00:54 AM',7,14,'Cash',NULL,53604,53604,NULL,0),
(92,'34393337','10-December-2020 10:11:11 AM',7,14,'Cash',NULL,9500,8893,NULL,607),
(93,'327123752','10-December-2020',6,14,'Cash',NULL,9500,9500,'dp1Poi08lhGpmLLL6Zk2dUN33',0),
(94,'358885625','11-December-2020',7,14,'Cash',NULL,9500,9500,'TxozekKSFbTADnYZsAssyIWsO',0),
(95,'269781495','11-December-2020',7,14,'Cash',NULL,9500,9500,'TxozekKSFbTADnYZsAssyIWsO',0),
(96,'496317775','11-December-2020',7,14,'Cash',NULL,34000,34000,'TxozekKSFbTADnYZsAssyIWsO',0),
(97,'897524462','11-December-2020',7,14,'Loan',NULL,0,0,'TxozekKSFbTADnYZsAssyIWsO',0),
(98,'809915271','14-December-2020',3,14,'Bank',2,9500,9500,'4ckjCsWjl7iew5uVdJYFhtyoh',0),
(100,'295464255','14-December-2020',6,14,'Cash',NULL,9500,9500,'dp1Poi08lhGpmLLL6Zk2dUN33',0);
/*!40000 ALTER TABLE `sale_order` ENABLE KEYS */;

-- 
-- Definition of sale_product
-- 

DROP TABLE IF EXISTS `sale_product`;
CREATE TABLE IF NOT EXISTS `sale_product` (
  `Sale_ID` int(11) NOT NULL AUTO_INCREMENT,
  `Sale_Product_ID` int(11) NOT NULL,
  `Sale_Product_Price` int(20) NOT NULL,
  `Sale_Product_Discounted_Amount` int(11) NOT NULL,
  `Sale_Discounted_Price` int(20) NOT NULL,
  `Sale_Product_Quantity` int(20) NOT NULL,
  `Sale_Order_ID` int(11) NOT NULL,
  PRIMARY KEY (`Sale_ID`),
  KEY `Sale_Product_ID` (`Sale_Product_ID`),
  KEY `Sale_Order_ID` (`Sale_Order_ID`),
  CONSTRAINT `sale_product_ibfk_1` FOREIGN KEY (`Sale_Product_ID`) REFERENCES `products_pos` (`Product_ID`),
  CONSTRAINT `sale_product_ibfk_2` FOREIGN KEY (`Sale_Order_ID`) REFERENCES `sale_order` (`Order_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=98 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table sale_product
-- 

/*!40000 ALTER TABLE `sale_product` DISABLE KEYS */;
INSERT INTO `sale_product`(`Sale_ID`,`Sale_Product_ID`,`Sale_Product_Price`,`Sale_Product_Discounted_Amount`,`Sale_Discounted_Price`,`Sale_Product_Quantity`,`Sale_Order_ID`) VALUES
(50,2,35000,0,35000,2,57),
(51,1,9500,0,9500,1,58),
(52,1,9500,0,9500,4,59),
(54,6,45000,0,45000,2,61),
(58,6,45000,0,45000,1,65),
(59,1,9500,0,9500,1,66),
(60,1,57000,0,9500,4,67),
(61,3,80000,0,80000,2,68),
(62,1,10000,0,10000,2,69),
(63,3,80000,0,80000,2,69),
(64,1,10000,0,10000,2,70),
(65,3,80000,0,80000,2,70),
(66,3,80000,800,79200,1,71),
(67,1,9500,0,9500,1,71),
(68,2,34000,0,34000,1,72),
(69,6,45000,0,45000,1,73),
(70,2,34000,0,34000,1,74),
(71,2,34000,0,34000,1,75),
(72,1,9500,0,9500,2,76),
(73,1,9500,0,9500,1,77),
(74,1,9500,0,9500,1,78),
(75,1,9500,0,9500,1,79),
(76,1,9500,0,9500,2,80),
(77,1,9500,0,9500,1,81),
(78,1,9500,0,9500,1,82),
(79,1,9500,0,9500,1,83),
(80,2,35000,0,35000,3,84),
(84,1,9500,0,9500,1,88),
(85,1,9500,0,9500,1,89),
(86,1,9600,96,9504,1,90),
(87,6,45000,900,44100,1,90),
(88,1,9600,96,9504,1,91),
(89,6,45000,900,44100,1,91),
(90,1,9500,0,9500,1,92),
(91,1,9500,0,9500,1,93),
(92,1,9500,0,9500,1,94),
(93,1,9500,0,9500,1,95),
(94,2,34000,0,34000,1,96),
(95,6,45000,0,45000,1,97),
(96,1,9500,0,9500,1,98),
(97,1,9500,0,9500,1,100);
/*!40000 ALTER TABLE `sale_product` ENABLE KEYS */;

-- 
-- Definition of sticknote
-- 

DROP TABLE IF EXISTS `sticknote`;
CREATE TABLE IF NOT EXISTS `sticknote` (
  `Note_ID` int(11) NOT NULL AUTO_INCREMENT,
  `Note_User_ID` int(11) NOT NULL,
  `Note_Text` varchar(5000) NOT NULL,
  `Font_Name` varchar(100) NOT NULL,
  `Font_Size` varchar(100) NOT NULL,
  PRIMARY KEY (`Note_ID`),
  KEY `Note_User_ID` (`Note_User_ID`),
  CONSTRAINT `sticknote_ibfk_1` FOREIGN KEY (`Note_User_ID`) REFERENCES `users_pos` (`User_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table sticknote
-- 

/*!40000 ALTER TABLE `sticknote` DISABLE KEYS */;
INSERT INTO `sticknote`(`Note_ID`,`Note_User_ID`,`Note_Text`,`Font_Name`,`Font_Size`) VALUES
(3,14,'256262','Segoe Print','17'),
(4,17,'agagaga','Microsoft YaHei UI','20'),
(5,19,'kl ,mjhe dhai lani h','Lucida Console','12');
/*!40000 ALTER TABLE `sticknote` ENABLE KEYS */;

-- 
-- Definition of suppliers_pos
-- 

DROP TABLE IF EXISTS `suppliers_pos`;
CREATE TABLE IF NOT EXISTS `suppliers_pos` (
  `Supplier_ID` int(11) NOT NULL AUTO_INCREMENT,
  `Supplier_Company` varchar(255) NOT NULL,
  `Supplier_Contact_Person` varchar(255) NOT NULL,
  `Supplier_Phone` varchar(255) NOT NULL,
  `Supplier_Address` varchar(255) NOT NULL,
  `Supplier_CNIC` varchar(255) NOT NULL,
  `Supplier_Entry_Date` varchar(50) NOT NULL,
  `Supplier_Status` tinyint(4) NOT NULL,
  PRIMARY KEY (`Supplier_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table suppliers_pos
-- 

/*!40000 ALTER TABLE `suppliers_pos` DISABLE KEYS */;
INSERT INTO `suppliers_pos`(`Supplier_ID`,`Supplier_Company`,`Supplier_Contact_Person`,`Supplier_Phone`,`Supplier_Address`,`Supplier_CNIC`,`Supplier_Entry_Date`,`Supplier_Status`) VALUES
(1,'Koderspot','Muhammad Khizer','021112131234','5/411','42101-0884798-9','8/23/2020 2:55:22 AM',0),
(2,'Gree','Muhammad Umar','03452527831','Baldia town','42401-4097731-5','11/28/2020 10:40:03 AM',0);
/*!40000 ALTER TABLE `suppliers_pos` ENABLE KEYS */;

-- 
-- Definition of transactions_in_pos
-- 

DROP TABLE IF EXISTS `transactions_in_pos`;
CREATE TABLE IF NOT EXISTS `transactions_in_pos` (
  `Transaction_In_ID` int(11) NOT NULL AUTO_INCREMENT,
  `Transaction_In_Payment_Method` varchar(10) NOT NULL,
  `Transaction_In_Account_ID` int(11) NOT NULL,
  `Transaction_In_Amount` varchar(255) NOT NULL,
  `Transaction_In_Date` varchar(255) NOT NULL,
  `Transaction_In_Sale_ID` varchar(50) NOT NULL,
  PRIMARY KEY (`Transaction_In_ID`),
  KEY `Transaction_In_Account_ID` (`Transaction_In_Account_ID`),
  CONSTRAINT `transactions_in_pos_ibfk_2` FOREIGN KEY (`Transaction_In_Account_ID`) REFERENCES `bank_details_pos` (`Bank_Details_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table transactions_in_pos
-- 

/*!40000 ALTER TABLE `transactions_in_pos` DISABLE KEYS */;
INSERT INTO `transactions_in_pos`(`Transaction_In_ID`,`Transaction_In_Payment_Method`,`Transaction_In_Account_ID`,`Transaction_In_Amount`,`Transaction_In_Date`,`Transaction_In_Sale_ID`) VALUES
(3,'Bank',2,'45000','03-December-2020 04:41:07 PM','65'),
(4,'Bank',2,'9500','03-December-2020 05:06:59 PM','66'),
(5,'Bank',2,'180000','05-December-2020 10:51:19 AM','69'),
(6,'Bank',2,'180000','05-December-2020 10:51:19 AM','69'),
(7,'Bank',2,'180000','05-December-2020 10:52:36 AM','70'),
(8,'Bank',2,'180000','05-December-2020 10:52:36 AM','70'),
(9,'Bank',2,'9500','11-December-2020 01:46:23 PM','94'),
(10,'Bank',2,'34000','11-December-2020 02:09:43 PM','96'),
(11,'Bank',2,'9500','14-December-2020 02:53:55 PM','98');
/*!40000 ALTER TABLE `transactions_in_pos` ENABLE KEYS */;

-- 
-- Definition of transactions_out_pos
-- 

DROP TABLE IF EXISTS `transactions_out_pos`;
CREATE TABLE IF NOT EXISTS `transactions_out_pos` (
  `Transaction_Out_ID` int(11) NOT NULL AUTO_INCREMENT,
  `Transaction_Out_Payment_Method` varchar(11) NOT NULL,
  `Transaction_Out_Account_ID` int(11) NOT NULL,
  `Transaction_Out_Amount` int(11) NOT NULL,
  `Transaction_Out_Date` varchar(100) NOT NULL,
  `Transaction_Purchase_ID` int(11) NOT NULL,
  PRIMARY KEY (`Transaction_Out_ID`),
  KEY `Transaction_Out_Account_ID` (`Transaction_Out_Account_ID`),
  KEY `Transaction_Purchase_ID` (`Transaction_Purchase_ID`),
  CONSTRAINT `transactions_out_pos_ibfk_1` FOREIGN KEY (`Transaction_Out_Account_ID`) REFERENCES `bank_details_pos` (`Bank_Details_ID`),
  CONSTRAINT `transactions_out_pos_ibfk_2` FOREIGN KEY (`Transaction_Purchase_ID`) REFERENCES `purchase_pos` (`Purchase_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table transactions_out_pos
-- 

/*!40000 ALTER TABLE `transactions_out_pos` DISABLE KEYS */;
INSERT INTO `transactions_out_pos`(`Transaction_Out_ID`,`Transaction_Out_Payment_Method`,`Transaction_Out_Account_ID`,`Transaction_Out_Amount`,`Transaction_Out_Date`,`Transaction_Purchase_ID`) VALUES
(1,'Bank',2,9200,'12/5/2020 5:35:24 PM',45),
(2,'Bank',2,18400,'12/10/2020 10:17:18 AM',52);
/*!40000 ALTER TABLE `transactions_out_pos` ENABLE KEYS */;

-- 
-- Definition of users_pos
-- 

DROP TABLE IF EXISTS `users_pos`;
CREATE TABLE IF NOT EXISTS `users_pos` (
  `User_ID` int(11) NOT NULL AUTO_INCREMENT,
  `User_First_Name` varchar(255) NOT NULL,
  `User_Last_Name` varchar(255) NOT NULL,
  `User_Username` varchar(255) NOT NULL,
  `User_Pswd` varchar(255) NOT NULL,
  `User_Phone` varchar(255) NOT NULL,
  `User_Mail` varchar(255) NOT NULL,
  `User_NIC` varchar(20) NOT NULL,
  `User_Branch_ID` int(11) NOT NULL,
  `User_Role_ID` int(11) NOT NULL,
  `User_Status` varchar(20) NOT NULL,
  PRIMARY KEY (`User_ID`),
  KEY `User_Branch_ID` (`User_Branch_ID`),
  KEY `User_Role_ID` (`User_Role_ID`),
  CONSTRAINT `users_pos_ibfk_1` FOREIGN KEY (`User_Role_ID`) REFERENCES `roles_pos` (`Role_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=20 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table users_pos
-- 

/*!40000 ALTER TABLE `users_pos` DISABLE KEYS */;
INSERT INTO `users_pos`(`User_ID`,`User_First_Name`,`User_Last_Name`,`User_Username`,`User_Pswd`,`User_Phone`,`User_Mail`,`User_NIC`,`User_Branch_ID`,`User_Role_ID`,`User_Status`) VALUES
(14,'Muhammad','Jibran','admin','admin','03249014904','jibran@gmail.com','42101-4156256-9',19,1,'Active'),
(15,'Usman','Ghani','user','user','03489209009','usman@gmail.com','42101-4176256-9',20,1,'Active'),
(16,'Ali','Ahmed','ali','123','03431441513','ali@gmail.com','42101-4156253-9',20,1,'Inactive'),
(17,'umar','Kausar','umer1','admin','03452527831','umer@gmail.com','42101-4126256-9',20,2,'Active'),
(18,'Muhammad','Mubeen','mubeen','user','03452527831.','mubeen@gmail.com','42401-4097731-5',19,2,'Active'),
(19,'zeeshan ','khan','zeeshan','zeeshan','03118211678','mdzeeshankhan147@gmail.com','42101-3014265-1',20,2,'Active');
/*!40000 ALTER TABLE `users_pos` ENABLE KEYS */;

-- 
-- Dumping procedures
-- 

DROP PROCEDURE IF EXISTS `discount_card`;
DELIMITER |
CREATE PROCEDURE `discount_card`(IN `cid` INT)
    NO SQL
    COMMENT 'no comment'
SELECT c.Customer_Name,c.Customer_Phone,d.DC_Card_Number,d.Serial_Number,d.DC_Start_Date from customers_pos c join discount_card_pos d on d.DC_Customer_ID=c.Customer_ID where c.Customer_ID=cid |
DELIMITER ;

DROP PROCEDURE IF EXISTS `for_discount_card_holder`;
DELIMITER |
CREATE PROCEDURE `for_discount_card_holder`(IN `idd` INT)
    NO SQL
    COMMENT 'no comment'
SELECT CONCAT(brandd.Product_Brand_Name ,' ', product.Product_Name,' (',product.Product_Model,')') as 'Product Name',saleproduct.Sale_Product_Price as 'Product Price',saleproduct.Sale_Product_Discounted_Amount as 'Discount',saleproduct.Sale_Discounted_Price as 'Total Amount',saleproduct.Sale_Product_Quantity as 'Product Quantity',orderr.Order_Date as 'Order Date',orderr.Order_Type as 'Type',orderr.Order_Total_Price as 'Net Amount',orderr.Order_Paid_Amount as 'Paid Amount',orderr.Order_ID,orderr.Order_Paid_Amount_By_Point,orderr.Serial_Number as 'Serial Number',customer.Customer_Name as 'Customer Name',customer.Customer_NIC as 'Customer NIC',customer.Customer_Phone,dc.DC_Current_Points as 'Available Points' from `products_pos` product join product_brands_pos brandd on brandd.Product_Brand_ID=product.Pro_Brand_ID join sale_product saleproduct on product.Product_ID=saleproduct.Sale_Product_ID join sale_order orderr on saleproduct.Sale_Order_ID=orderr.Order_ID join customers_pos customer on orderr.Order_Customer_ID=customer.Customer_ID join discount_card_pos dc on dc.DC_Customer_ID=customer.Customer_ID where orderr.Order_ID=idd |
DELIMITER ;

DROP PROCEDURE IF EXISTS `for_sale_report`;
DELIMITER |
CREATE PROCEDURE `for_sale_report`(IN `id` INT)
    NO SQL
    COMMENT 'no comment'
SELECT CONCAT(brandd.Product_Brand_Name ,' ', product.Product_Name,' (',product.Product_Model,')') as 'Product Name',saleproduct.Sale_Product_Price as 'Product Price',saleproduct.Sale_Product_Discounted_Amount as 'Discount',saleproduct.Sale_Discounted_Price as 'Total Amount',saleproduct.Sale_Product_Quantity as 'Product Quantity',orderr.Order_Date as 'Order Date',orderr.Order_Type as 'Type',orderr.Order_Total_Price as 'Paid Amount',orderr.Order_ID,orderr.Order_Paid_Amount_By_Point,orderr.Serial_Number as 'Serial Number',customer.Customer_Name as 'Customer Name',customer.Customer_NIC as 'Customer NIC',customer.Customer_Phone from `products_pos` product join product_brands_pos brandd on brandd.Product_Brand_ID=product.Pro_Brand_ID join sale_product saleproduct on product.Product_ID=saleproduct.Sale_Product_ID join sale_order orderr on saleproduct.Sale_Order_ID=orderr.Order_ID join customers_pos customer on orderr.Order_Customer_ID=customer.Customer_ID join users_pos userr on orderr.Order_DoneBy=userr.User_ID where orderr.Order_ID=id |
DELIMITER ;

DROP PROCEDURE IF EXISTS `get_single_bank_data_pos`;
DELIMITER |
CREATE PROCEDURE `get_single_bank_data_pos`(IN `banks` VARCHAR(255))
    NO SQL
BEGIN
SELECT * FROM `banks_pos` WHERE `banks_pos`.`Bank_Name` Like CONCAT( banks , '%');
END |
DELIMITER ;

DROP PROCEDURE IF EXISTS `get_single_bank_details_pos`;
DELIMITER |
CREATE PROCEDURE `get_single_bank_details_pos`(IN `bank` VARCHAR(255))
    NO SQL
BEGIN
SELECT `bd`.`Bank_Details_ID` AS `Bank_ID`, `b`.`Bank_Name` AS `Bank Name`, `bd`.`Bank_Branch` AS `Bank Branch`, `bd`.`Bank_Acc_Name` AS `Account Name`, `bd`.`Bank_Acc_Number` AS `Account Number`, `bd`.`Bank_Acc_Balance` AS `Current Balance`, if((`bd`.`Bank_Acc_Status` = 0),'Active','InActive') AS `Account Status` from `bk_ims`.`bank_details_pos` `bd` join `bk_ims`.`banks_pos` `b` on `bd`.`Bank_Name_ID` = `b`.`Bank_ID` WHERE `b`.`Bank_Name` Like CONCAT( bank , '%') OR `bd`.`Bank_Branch` Like CONCAT( bank , '%') OR `bd`.`Bank_Acc_Name` Like CONCAT( bank , '%') OR `bd`.`Bank_Acc_Number` Like CONCAT( bank , '%') OR `bd`.`Bank_Acc_Balance` Like CONCAT( bank , '%') OR if((`bk_ims`.`banks_pos`.`Bank_Acc_Status` = 0),'Active','InActive') Like CONCAT( bank , '%');
END |
DELIMITER ;

DROP PROCEDURE IF EXISTS `get_single_branch_data_pos`;
DELIMITER |
CREATE PROCEDURE `get_single_branch_data_pos`(IN `branch` VARCHAR(255))
BEGIN
SELECT Branch_ID AS `Branch ID`, Branch_Area AS `Branch Area`,  Branch_Head AS `Branch Head`, Branch_Phone AS `Branch Phone` FROM `branches_pos` WHERE Branch_Head Like CONCAT( branch , '%') OR Branch_Area Like CONCAT( branch , '%') OR Branch_Phone Like CONCAT( branch , '%');
END |
DELIMITER ;

DROP PROCEDURE IF EXISTS `get_single_customer_data_pos`;
DELIMITER |
CREATE PROCEDURE `get_single_customer_data_pos`(IN `customer` VARCHAR(255))
    NO SQL
BEGIN
SELECT Customer_ID AS `Customer ID`, Customer_Name AS `Customer Name`,  Customer_Phone AS `Customer Phone`, Customer_Mail AS `Customer Mail`, Customer_Address AS `Customer Address` FROM `customers_pos` WHERE Customer_Name Like CONCAT( customer , '%') OR Customer_Phone Like CONCAT( customer , '%') OR Customer_Mail Like CONCAT( customer , '%') OR Customer_Address Like CONCAT( customer , '%');
END |
DELIMITER ;

DROP PROCEDURE IF EXISTS `get_single_customer_for_card`;
DELIMITER |
CREATE PROCEDURE `get_single_customer_for_card`(IN `id` INT)
    NO SQL
    COMMENT 'no comment'
SELECT c.Customer_Name,c.Customer_Phone,d.DC_Card_Number,d.DC_Start_Date from customers_pos c join discount_card_pos d on d.DC_Customer_ID=c.Customer_ID where c.Customer_ID=id |
DELIMITER ;

DROP PROCEDURE IF EXISTS `get_single_expense_data_pos`;
DELIMITER |
CREATE PROCEDURE `get_single_expense_data_pos`(IN `expense` VARCHAR(255))
    NO SQL
BEGIN
SELECT Expense_ID AS `Expense ID`, Expense_Purpose AS `Expense Purpose`, Expense_Amount AS `Expense Amount`, Expense_Date AS `Expense Date` FROM `daily_expense_pos` WHERE Expense_Purpose Like CONCAT( expense , '%') OR Expense_Amount Like CONCAT( expense , '%') OR Expense_Date Like CONCAT( expense , '%');
END |
DELIMITER ;

DROP PROCEDURE IF EXISTS `get_single_product_brand_data_pos`;
DELIMITER |
CREATE PROCEDURE `get_single_product_brand_data_pos`(IN `brand` VARCHAR(255))
    NO SQL
BEGIN
SELECT `bk_ims`.`product_brands_pos`.`Product_Brand_ID` AS `Brand ID`, `bk_ims`.`product_brands_pos`.`Product_Brand_Name` AS `Brand Name`, IF(( `bk_ims`.`product_brands_pos`.`Product_Brand_Status` = 0), 'Active',   'InActive') AS `Brand Status` FROM `bk_ims`.`product_brands_pos` WHERE Product_Brand_Name Like CONCAT( brand , '%') OR IF(( `bk_ims`.`product_brands_pos`.`Product_Brand_Status` = 0), 'Active',   'InActive') Like CONCAT( brand , '%');
END |
DELIMITER ;

DROP PROCEDURE IF EXISTS `get_single_product_category_data_pos`;
DELIMITER |
CREATE PROCEDURE `get_single_product_category_data_pos`(IN `category` VARCHAR(255))
    NO SQL
BEGIN
select `pc`.`Product_Category_ID` AS `Category_ID`, `pc`.`Product_Category_Name` AS `Category Name`, `pb`.`Product_Brand_Name` AS `Brand Name`, if((`pc`.`Product_Category_Status` = 0),'Active','InActive') AS `Category Status` from `bk_ims`.`product_category_pos` `pc` join `bk_ims`.`product_brands_pos` `pb` on((`pc`.`Product_Category_Brand_ID` = `pb`.`Product_Brand_ID`)) WHERE if((`pc`.`Product_Category_Status` = 0),'Active','InActive') Like CONCAT( category , '%') OR Product_Category_Name Like CONCAT( category , '%');
END |
DELIMITER ;

DROP PROCEDURE IF EXISTS `get_single_product_data_pos`;
DELIMITER |
CREATE PROCEDURE `get_single_product_data_pos`(IN `product` VARCHAR(255))
    NO SQL
BEGIN
select `p`.`Product_ID` AS `Product_ID`,`p`.`Product_Name` AS `Product Name`,`c`.`Product_Category_Name` AS `Product Category Name`,`p`.`Product_Model` AS `Product Model`,`p`.`Product_Material` AS `Product Material`,`p`.`Product_Color` AS `Product Color`,`b`.`Product_Brand_Name` AS `Product Brand Name`,`p`.`Product_Remarks` AS `Product Remarks`,`p`.`Product_Entry_Date` AS `Product Entry Date` from ((`bk_ims`.`products_pos` `p` join `bk_ims`.`product_category_pos` `c` on((`p`.`Product_Cat_ID` = `c`.`Product_Category_ID`))) join `bk_ims`.`product_brands_pos` `b` on((`p`.`Pro_Brand_ID` = `b`.`Product_Brand_ID`))) WHERE Product_Name Like CONCAT( product, '%') OR Product_Model Like CONCAT( product, '%') OR Product_Material Like CONCAT( product, '%') OR Product_Color Like CONCAT( product, '%') OR Product_Remarks Like CONCAT( product, '%') OR Product_Redeem_Points Like CONCAT( product, '%') OR Product_Entry_Date Like CONCAT( product, '%');
END |
DELIMITER ;

DROP PROCEDURE IF EXISTS `get_single_purchase_data_pos`;
DELIMITER |
CREATE PROCEDURE `get_single_purchase_data_pos`(IN `purchase` VARCHAR(255))
    NO SQL
BEGIN
SELECT `p`.`Purchase_ID` AS `Purchase_ID`, `p`.`Purchase_Date` AS `Purchase Date`, CONCAT(`u`.`User_First_Name`, ' ', `u`.`User_Last_Name`) AS `Purchase Done By`, `s`.`Supplier_Company` AS `Supplier Company` FROM `purchase_pos` `p` JOIN `users_pos` `u` ON `p`.`Purchase_Done_By` = `u`.`User_ID` JOIN `suppliers_pos` `s` ON `p`.`Purchase_Supplier_ID` = `s`.`Supplier_ID` WHERE Supplier_Company Like CONCAT( purchase , '%') OR User_First_Name Like CONCAT( purchase , '%') OR User_Last_Name Like CONCAT( purchase , '%');
END |
DELIMITER ;

DROP PROCEDURE IF EXISTS `get_single_suppliers_data_pos`;
DELIMITER |
CREATE PROCEDURE `get_single_suppliers_data_pos`(IN `suppliers` VARCHAR(255))
    NO SQL
select `bk_ims`.`suppliers_pos`.`Supplier_ID` AS `Supplier_ID`,`bk_ims`.`suppliers_pos`.`Supplier_Company` AS `Supplier Company`,`bk_ims`.`suppliers_pos`.`Supplier_Contact_Person` AS `Supplier Contact Person`,`bk_ims`.`suppliers_pos`.`Supplier_Phone` AS `Supplier Phone`,`bk_ims`.`suppliers_pos`.`Supplier_Address` AS `Supplier Address`,`bk_ims`.`suppliers_pos`.`Supplier_CNIC` AS `Supplier CNIC`,`bk_ims`.`suppliers_pos`.`Supplier_Entry_Date` AS `Supplier Entry Date`,if((`bk_ims`.`suppliers_pos`.`Supplier_Status` = 0),'Active','InActive') AS `Supplier Status` from `bk_ims`.`suppliers_pos` |
DELIMITER ;

DROP PROCEDURE IF EXISTS `get_single_user_data_pos`;
DELIMITER |
CREATE PROCEDURE `get_single_user_data_pos`(IN `users` VARCHAR(255))
    NO SQL
select `bk_ims`.`users_pos`.`User_ID` AS `User_ID`,`bk_ims`.`users_pos`.`User_First_Name` AS `First Name`,`bk_ims`.`users_pos`.`User_Last_Name` AS `Last Name`,`bk_ims`.`users_pos`.`User_Mail` AS `Email`,`bk_ims`.`users_pos`.`User_Phone` AS `Phone Number`,`bk_ims`.`users_pos`.`User_Username` AS `Username`,`bk_ims`.`users_pos`.`User_NIC` AS `NIC`,`b`.`Branch_Area` AS `Branch`,`r`.`Role_Name` AS `Role`,`bk_ims`.`users_pos`.`User_Status` AS `Status` from ((`bk_ims`.`users_pos` join `bk_ims`.`branches_pos` `b` on((`b`.`Branch_ID` = `bk_ims`.`users_pos`.`User_Branch_ID`))) join `bk_ims`.`roles_pos` `r` on((`r`.`Role_ID` = `bk_ims`.`users_pos`.`User_Role_ID`))) WHERE User_First_Name Like CONCAT( users , '%') OR User_Last_Name Like CONCAT( users , '%') OR User_Mail Like CONCAT( users , '%') OR User_Phone Like CONCAT( users , '%') OR User_Username Like CONCAT( users , '%') OR `b`.`Branch_Area` Like CONCAT( users , '%') OR `r`.`Role_Name` LIKE CONCAT( users , '%') OR User_NIC LIKE CONCAT( users , '%') OR User_Status LIKE CONCAT( users , '%') |
DELIMITER ;

DROP PROCEDURE IF EXISTS `get_user_login_details_pos`;
DELIMITER |
CREATE PROCEDURE `get_user_login_details_pos`(IN `username` VARCHAR(255), IN `password` VARCHAR(255))
BEGIN
SELECT U.User_ID as 'ID', U.User_First_Name  as 'First Name', U.User_Last_Name  as 'Last Name', U.User_Username as 'Username', U.User_Pswd as 'Password', U.User_Role_ID as 'Role' from users_pos U join branches_pos b where U.User_Username = username and U.User_Pswd = password and U.User_Status='Active' and b.Branch_Status='Active';
END |
DELIMITER ;

DROP PROCEDURE IF EXISTS `purchase_report`;
DELIMITER |
CREATE PROCEDURE `purchase_report`(IN `sid` INT, IN `date` INT)
    NO SQL
    COMMENT 'no comment'
SELECT CONCAT(p.Product_Name,' (',p.Product_Model,')') as 'Product Name',pd.PD_Product_Price as 'Price',pd.PD_Purchase_Discount as 'Discount',pd.PD_Product_Quantity as 'Quantity',pd.PD_Product_Total_Price as 'Total',pr.Purchase_Date as 'Date',pr.Serial_Number as 'Sr no',s.Supplier_Company as 'Company',s.Supplier_Contact_Person as 'Supplier Name',s.Supplier_Phone as 'Phone' FROM products_pos p join purchase_details_pos pd on p.Product_ID=pd.PD_Product_ID join purchase_pos pr on pd.PD_Purchase_ID=pr.Purchase_ID join suppliers_pos s on pr.Purchase_Supplier_ID=s.Supplier_ID where pr.Purchase_Date=date and pr.Purchase_Supplier_ID=sid |
DELIMITER ;

DROP PROCEDURE IF EXISTS `purchase_report_net_amount`;
DELIMITER |
CREATE PROCEDURE `purchase_report_net_amount`(IN `sid` INT, IN `date` INT)
    NO SQL
    COMMENT 'no comment'
SELECT sum(pd.PD_Product_Total_Price) as 'Net Amount' from purchase_details_pos pd join purchase_pos pr on pd.PD_Purchase_ID=pr.Purchase_ID where pr.Purchase_Date=date and pr.Purchase_Supplier_ID=sid |
DELIMITER ;

-- 
-- Dumping views
-- 

DROP TABLE IF EXISTS `banks_details_view_pos`;
DROP VIEW IF EXISTS `banks_details_view_pos`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `banks_details_view_pos` AS select `bd`.`Bank_Details_ID` AS `Bank_ID`,`b`.`Bank_Name` AS `Bank Name`,`bd`.`Bank_Branch` AS `Bank Branch`,`bd`.`Bank_Acc_Name` AS `Account Name`,`bd`.`Bank_Acc_Number` AS `Account Number`,`bd`.`Bank_Acc_Balance` AS `Current Balance`,if((`bd`.`Bank_Acc_Status` = 0),'Active','InActive') AS `Account Status` from (`bank_details_pos` `bd` join `banks_pos` `b` on((`bd`.`Bank_Name_ID` = `b`.`Bank_ID`)));

DROP TABLE IF EXISTS `banks_view_pos`;
DROP VIEW IF EXISTS `banks_view_pos`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `banks_view_pos` AS select `banks_pos`.`Bank_ID` AS `Bank_ID`,`banks_pos`.`Bank_Name` AS `Bank_Name` from `banks_pos`;

DROP TABLE IF EXISTS `product_brands_view_pos`;
DROP VIEW IF EXISTS `product_brands_view_pos`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `product_brands_view_pos` AS select `product_brands_pos`.`Product_Brand_ID` AS `Brand_ID`,`product_brands_pos`.`Product_Brand_Name` AS `Brand Name`,if((`product_brands_pos`.`Product_Brand_Status` = 0),'Active','InActive') AS `Brand Status` from `product_brands_pos`;

DROP TABLE IF EXISTS `products_view_pos`;
DROP VIEW IF EXISTS `products_view_pos`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `products_view_pos` AS select `p`.`Product_ID` AS `Product_ID`,`p`.`Product_Name` AS `Product Name`,`c`.`Product_Category_Name` AS `Product Category Name`,`p`.`Product_Model` AS `Product Model`,`p`.`Product_Material` AS `Product Material`,`p`.`Product_Color` AS `Product Color`,`b`.`Product_Brand_Name` AS `Product Brand Name`,`p`.`Product_Remarks` AS `Product Remarks`,`p`.`Product_Entry_Date` AS `Product Entry Date` from ((`products_pos` `p` join `product_category_pos` `c` on((`p`.`Product_Cat_ID` = `c`.`Product_Category_ID`))) join `product_brands_pos` `b` on((`p`.`Pro_Brand_ID` = `b`.`Product_Brand_ID`)));

DROP TABLE IF EXISTS `purchases_view_pos`;
DROP VIEW IF EXISTS `purchases_view_pos`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `purchases_view_pos` AS select `p`.`Purchase_ID` AS `Purchase_ID`,`p`.`Purchase_Date` AS `Purchase Date`,concat(`u`.`User_First_Name`,' ',`u`.`User_Last_Name`) AS `Purchase Done By`,`s`.`Supplier_Company` AS `Supplier Company` from ((`purchase_pos` `p` join `users_pos` `u` on((`p`.`Purchase_Done_By` = `u`.`User_ID`))) join `suppliers_pos` `s` on((`p`.`Purchase_Supplier_ID` = `s`.`Supplier_ID`)));

DROP TABLE IF EXISTS `suppliers_view_pos`;
DROP VIEW IF EXISTS `suppliers_view_pos`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `suppliers_view_pos` AS select `suppliers_pos`.`Supplier_ID` AS `Supplier_ID`,`suppliers_pos`.`Supplier_Company` AS `Supplier Company`,`suppliers_pos`.`Supplier_Contact_Person` AS `Supplier Contact Person`,`suppliers_pos`.`Supplier_Phone` AS `Supplier Phone`,`suppliers_pos`.`Supplier_Address` AS `Supplier Address`,`suppliers_pos`.`Supplier_CNIC` AS `Supplier CNIC`,`suppliers_pos`.`Supplier_Entry_Date` AS `Supplier Entry Date`,if((`suppliers_pos`.`Supplier_Status` = 0),'Active','InActive') AS `Supplier Status` from `suppliers_pos`;

DROP TABLE IF EXISTS `users_view_pos`;
DROP VIEW IF EXISTS `users_view_pos`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `users_view_pos` AS select `users_pos`.`User_ID` AS `User_ID`,`users_pos`.`User_First_Name` AS `First Name`,`users_pos`.`User_Last_Name` AS `Last Name`,`users_pos`.`User_Mail` AS `Mail`,`users_pos`.`User_Phone` AS `Phone Number`,`users_pos`.`User_Username` AS `Username`,`users_pos`.`User_Pswd` AS `Password`,`b`.`Branch_Area` AS `Branch`,`r`.`Role_Name` AS `Role` from ((`users_pos` join `branches_pos` `b` on((`b`.`Branch_ID` = `users_pos`.`User_Branch_ID`))) join `roles_pos` `r` on((`r`.`Role_ID` = `users_pos`.`User_Role_ID`)));



/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;


-- Dump completed on 2020-12-16 16:20:14
-- Total time: 0:0:0:0:412 (d:h:m:s:ms)
