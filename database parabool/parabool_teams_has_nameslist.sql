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
-- Table structure for table `teams_has_nameslist`
--

DROP TABLE IF EXISTS `teams_has_nameslist`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `teams_has_nameslist` (
  `teams_idteams` int(11) NOT NULL,
  `nameslist_id` int(11) NOT NULL,
  `commisie_id` int(11) NOT NULL,
  PRIMARY KEY (`teams_idteams`,`nameslist_id`,`commisie_id`),
  KEY `fk_teams_has_nameslist_nameslist1_idx` (`nameslist_id`),
  KEY `fk_teams_has_nameslist_teams1_idx` (`teams_idteams`),
  KEY `fk_teams_has_nameslist_commissies_idx` (`commisie_id`),
  CONSTRAINT `fk_teams_has_nameslist_commissies1` FOREIGN KEY (`commisie_id`) REFERENCES `commissies` (`idcommisies`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_teams_has_nameslist_nameslist1` FOREIGN KEY (`nameslist_id`) REFERENCES `nameslist` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_teams_has_nameslist_teams1` FOREIGN KEY (`teams_idteams`) REFERENCES `teams` (`idteams`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `teams_has_nameslist`
--

LOCK TABLES `teams_has_nameslist` WRITE;
/*!40000 ALTER TABLE `teams_has_nameslist` DISABLE KEYS */;
INSERT INTO `teams_has_nameslist` VALUES (5,100,12),(5,101,12),(3,102,12),(8,103,12),(6,104,2),(1,105,12),(5,106,12),(8,107,12),(6,108,3),(8,109,12),(8,110,12),(8,111,12),(8,112,12),(8,113,12),(8,114,12),(8,115,12),(2,116,8),(3,117,4),(4,118,12),(1,119,12),(8,120,12),(1,121,12),(8,122,12),(8,123,12),(8,124,12),(8,125,1),(4,126,12),(1,127,8),(5,128,12),(2,129,1),(8,130,12),(4,131,12),(4,132,4),(3,133,12),(8,134,12),(3,135,11),(7,136,3),(8,137,12),(8,138,12),(8,139,12),(5,140,12),(2,141,3),(8,142,12),(5,143,1),(4,144,1),(8,145,12),(2,146,12),(1,147,12),(8,148,12),(8,149,12),(2,150,5),(8,151,12),(8,152,12),(2,153,12),(1,154,6),(8,155,12),(3,156,12),(2,157,12),(8,159,12),(4,160,12),(4,161,12),(8,162,12),(2,163,12),(3,164,1),(6,165,12),(8,166,12),(4,167,12),(8,168,12),(8,169,12),(8,170,12),(5,171,12),(8,172,12),(5,173,1),(1,174,12),(6,175,12),(1,176,12),(7,177,12),(3,178,12),(3,179,12),(8,180,12),(3,181,6),(8,182,12),(2,183,12),(8,184,12),(2,185,12),(8,186,12),(4,187,7),(8,188,12),(1,189,12),(8,190,12),(8,191,12),(8,192,12),(6,193,12),(8,194,12),(8,195,12),(8,196,12),(8,197,12),(8,198,12),(8,199,2),(7,200,1),(8,201,12),(8,202,12),(8,203,12),(5,204,12),(8,205,12),(8,206,10),(8,207,12),(8,208,12),(8,209,12),(8,210,12),(4,211,12),(8,212,10),(8,213,12),(3,214,12),(8,215,12),(4,216,12),(8,217,10),(8,218,12),(8,219,12),(8,220,12),(8,221,12),(8,222,10),(8,223,12),(8,224,12),(8,225,12),(8,226,12),(8,227,12),(8,228,12),(4,229,12),(8,230,12),(8,231,12),(8,232,12),(5,233,12),(2,234,12),(8,235,12),(6,236,12),(8,237,12),(8,238,12),(8,239,12),(8,240,12),(8,241,12),(2,242,12),(4,243,6),(8,244,12),(8,245,10),(8,249,12),(1,250,12),(8,251,12),(2,252,12),(2,254,1),(8,255,12),(3,256,12),(5,257,12),(6,258,12),(6,259,12),(3,260,12),(8,261,12),(8,262,10),(2,263,6),(8,264,12),(8,265,12),(8,266,12),(8,267,12),(3,268,12),(8,269,12),(8,270,12),(8,271,12),(8,272,12),(8,273,12),(8,274,12),(8,275,12),(8,276,12),(2,277,12),(7,278,11),(5,279,9),(4,280,12),(4,281,12),(8,282,12),(7,283,9),(6,284,12),(8,285,12),(7,286,1),(5,287,12),(3,288,12),(6,289,12),(2,290,12),(3,291,12),(4,294,12),(8,295,12),(7,296,12),(4,297,12),(4,298,12),(3,301,12),(3,302,12),(6,313,12),(2,315,12),(6,318,12),(6,321,12),(6,322,12),(8,323,12),(3,324,12),(8,325,12),(8,326,12),(5,327,12),(1,328,12),(3,329,12),(1,330,12),(3,331,12),(8,332,12),(4,333,12),(8,334,12),(6,335,12),(8,336,12),(8,337,12),(3,338,12);
/*!40000 ALTER TABLE `teams_has_nameslist` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-11-04 14:05:16
