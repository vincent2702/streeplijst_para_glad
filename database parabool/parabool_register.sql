-- MySQL dump 10.13  Distrib 8.0.19, for Win64 (x86_64)
--
-- Host: localhost    Database: parabool
-- ------------------------------------------------------
-- Server version	5.7.28-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `register`
--

DROP TABLE IF EXISTS `register`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `register` (
  `id` varchar(45) DEFAULT NULL,
  `Firstname` varchar(45) DEFAULT NULL,
  `LastName` varchar(45) DEFAULT NULL,
  `Item1` varchar(45) DEFAULT NULL,
  `Item2` varchar(45) DEFAULT NULL,
  `Item3` varchar(45) DEFAULT NULL,
  `Item4` varchar(45) DEFAULT NULL,
  `Item5` varchar(45) DEFAULT NULL,
  `Item6` varchar(45) DEFAULT NULL,
  `Item7` varchar(45) DEFAULT NULL,
  `Item8` varchar(45) DEFAULT NULL,
  `Item9` varchar(45) DEFAULT NULL,
  `Item10` varchar(45) DEFAULT NULL,
  `Totaal` varchar(45) DEFAULT NULL,
  `Date` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `register`
--

LOCK TABLES `register` WRITE;
/*!40000 ALTER TABLE `register` DISABLE KEYS */;
INSERT INTO `register` VALUES ('236','Annemieke','Wargers','0','0','0','0','0','0','0','0','0','0','0','07-09-2020 12:41'),('236','Annemieke','Wargers','0','0','0','0','0','0','0','0','0','0','0','07-09-2020 14:10'),('236','Annemieke','Wargers','0','0','0','0','0','0','0','0','0','0','0','07-09-2020 14:24'),('198','Alma','Dijkstra','0','0','0','0','0','0','0','0','0','0','0','07-09-2020 14:36'),('259','Annemarij','Tuinstra','0','0','0','0','0','0','0','0','0','0','0','21-09-2020 14:35'),('143','Arjen ','Huising','51,04','0','0','0','0','0','0','0','0','0','51,04','21-09-2020 16:00'),('324','Roy','Oosting','41,36','0','0','0','0','0','0','0','0','0','41,36','21-09-2020 16:00'),('127','Sven','van Erp','36,96','0','0','0','0','0','0','0','0','0','36,96','21-09-2020 16:01'),('290','Demi','Sierdsma','33,44','0','0','0','0','0','0','0','0','0','33,44','21-09-2020 16:01'),('281','Milan','Wind','29,04','0','0','0','0','0','0','0','0','0','29,04','21-09-2020 16:01'),('105','Folkert','Bergsma','29,04','0','0','0','0','0','0','0','0','0','29,04','21-09-2020 16:01'),('216','Bjorn','de Kruijf','24,64','0','0','0','0','0','0','0','0','0','24,64','21-09-2020 16:02'),('129','Joanne','Flinkert','24,64','0','0','0','0','0','0','0','0','0','24,64','21-09-2020 16:02'),('106','Nynke','Bergsma','24,64','0','0','0','0','0','0','0','0','0','24,64','21-09-2020 16:02'),('146','Hilde','Kiers','22,88','0','0','0','0','0','0','0','0','0','22,88','21-09-2020 16:03'),('328','Daniek','van der Wal','19,36','0','0','0','0','0','0','0','0','0','19,36','21-09-2020 16:03'),('288','Matthijs','de Vries','17,6','0','0','0','0','0','0','0','0','0','17,6','21-09-2020 16:03'),('338','Leila','Moufakkir','17,6','0','0','0','0','0','0','0','0','0','17,6','21-09-2020 16:03'),('189','Jilt','Ypma','16,72','0','0','0','0','0','0','0','0','0','16,72','21-09-2020 16:04'),('280','Franka','Van luijk','15,84','0','0','0','0','0','0','0','0','0','15,84','21-09-2020 16:04'),('260','Patrick','Schraa','15,84','0','0','0','0','0','0','0','0','0','15,84','21-09-2020 16:04'),('330','Britt','Dingste','14,96','0','0','0','0','0','0','0','0','0','14,96','21-09-2020 16:04'),('183','Wybrand','de Vries','14,96','0','0','0','0','0','0','0','0','0','14,96','21-09-2020 16:05'),('278','Astrid','Schimmel','14,96','0','0','0','0','0','0','0','0','0','14,96','21-09-2020 16:05'),('157','Simon','Nitert','14,08','0','0','0','0','0','0','0','0','0','14,08','21-09-2020 16:05'),('332','Gertjan','van Drogen','13,2','0','0','0','0','0','0','0','0','0','13,2','21-09-2020 16:05'),('322','Marleen','Bruin','13,2','0','0','0','0','0','0','0','0','0','13,2','21-09-2020 16:06'),('242','Stijn','de Zeeuw','13,2','0','0','0','0','0','0','0','0','0','13,2','21-09-2020 16:06'),('214','Amarins','Koster','12,32','0','0','0','0','0','0','0','0','0','12,32','21-09-2020 16:06');
/*!40000 ALTER TABLE `register` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-11-04 14:05:15
