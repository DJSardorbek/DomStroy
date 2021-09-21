-- MySQL dump 10.13  Distrib 8.0.25, for Win64 (x86_64)
--
-- Host: localhost    Database: domstroy
-- ------------------------------------------------------
-- Server version	8.0.25

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
-- Table structure for table `branch`
--

DROP TABLE IF EXISTS `branch`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `branch` (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(50) NOT NULL,
  `address` varchar(255) NOT NULL,
  `is_b2b` tinyint(1) NOT NULL,
  `is_b2c` tinyint(1) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `branch`
--

LOCK TABLES `branch` WRITE;
/*!40000 ALTER TABLE `branch` DISABLE KEYS */;
INSERT INTO `branch` VALUES (1,'branch1','Andijan',0,1);
/*!40000 ALTER TABLE `branch` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cart`
--

DROP TABLE IF EXISTS `cart`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `cart` (
  `id` int NOT NULL AUTO_INCREMENT,
  `product` int NOT NULL,
  `amount` double NOT NULL,
  `sum` double NOT NULL,
  `shop` int NOT NULL,
  PRIMARY KEY (`id`),
  KEY `shop` (`shop`),
  CONSTRAINT `cart_ibfk_1` FOREIGN KEY (`shop`) REFERENCES `shop` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=141 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cart`
--

LOCK TABLES `cart` WRITE;
/*!40000 ALTER TABLE `cart` DISABLE KEYS */;
INSERT INTO `cart` VALUES (1,0,0,0,1);
/*!40000 ALTER TABLE `cart` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `category`
--

DROP TABLE IF EXISTS `category`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `category` (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(100) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `category`
--

LOCK TABLES `category` WRITE;
/*!40000 ALTER TABLE `category` DISABLE KEYS */;
INSERT INTO `category` VALUES (1,'el tovar'),(2,'lyustra'),(3,'shit'),(4,'bentong'),(5,'dusel'),(6,'List8'),(7,'shit+strem'),(8,'vesta'),(9,'oydin'),(10,'gg'),(11,'termo'),(12,'kabel'),(13,'chint'),(14,'praym'),(15,'kor');
/*!40000 ALTER TABLE `category` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `client`
--

DROP TABLE IF EXISTS `client`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `client` (
  `id` int NOT NULL AUTO_INCREMENT,
  `first_name` varchar(50) NOT NULL,
  `last_name` varchar(50) NOT NULL,
  `phone_1` varchar(20) NOT NULL,
  `phone_2` varchar(20) NOT NULL,
  `address` varchar(200) NOT NULL,
  `birth_date` date NOT NULL,
  `discount_card` int NOT NULL,
  `return_date` date NOT NULL,
  `loan_sum` double NOT NULL,
  `loan_dollar` double NOT NULL,
  `ball` double NOT NULL,
  PRIMARY KEY (`id`),
  KEY `discount_card` (`discount_card`),
  CONSTRAINT `client_ibfk_2` FOREIGN KEY (`discount_card`) REFERENCES `discountcard` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `client`
--

LOCK TABLES `client` WRITE;
/*!40000 ALTER TABLE `client` DISABLE KEYS */;
INSERT INTO `client` VALUES (1,'Oddiy klient','.','0','0','0','2021-01-01',1,'2021-01-01',0,0,0),(2,'Sardorbek','Sodiqjonov','994568798','','Abdijon saxar boston MFY','2000-09-05',1,'2021-09-15',0,0,0),(3,'Abdurahmon','Gulomqodirov','997861425','','Andijon shaxar','2001-01-05',1,'2021-09-21',0,0,0);
/*!40000 ALTER TABLE `client` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `currency`
--

DROP TABLE IF EXISTS `currency`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `currency` (
  `id` int NOT NULL AUTO_INCREMENT,
  `real_currency` double NOT NULL,
  `ball_price` double NOT NULL,
  `selling_currency` double NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `currency`
--

LOCK TABLES `currency` WRITE;
/*!40000 ALTER TABLE `currency` DISABLE KEYS */;
INSERT INTO `currency` VALUES (1,10700,1,13000);
/*!40000 ALTER TABLE `currency` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `discountcard`
--

DROP TABLE IF EXISTS `discountcard`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `discountcard` (
  `id` int NOT NULL AUTO_INCREMENT,
  `card` varchar(20) NOT NULL,
  `bonus_sum` double NOT NULL,
  `bonus_dollar` double NOT NULL,
  `created_at` date NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `discountcard`
--

LOCK TABLES `discountcard` WRITE;
/*!40000 ALTER TABLE `discountcard` DISABLE KEYS */;
INSERT INTO `discountcard` VALUES (1,'0',0,0,'2021-01-01');
/*!40000 ALTER TABLE `discountcard` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `product`
--

DROP TABLE IF EXISTS `product`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `product` (
  `id` int NOT NULL AUTO_INCREMENT,
  `product_id` int NOT NULL,
  `name` varchar(255) NOT NULL,
  `measurement` varchar(25) NOT NULL,
  `amount` double NOT NULL,
  `section` int NOT NULL,
  `branch` int NOT NULL,
  `barcode` varchar(50) NOT NULL,
  `producer` varchar(255) NOT NULL,
  `deliver` int NOT NULL,
  `currency` varchar(15) NOT NULL,
  `cost` double NOT NULL,
  `selling_price` double NOT NULL,
  `expire_date` date DEFAULT NULL,
  `category` int NOT NULL,
  `ball` double NOT NULL,
  PRIMARY KEY (`id`),
  KEY `section` (`section`),
  KEY `branch` (`branch`),
  KEY `category` (`category`),
  CONSTRAINT `product_ibfk_1` FOREIGN KEY (`section`) REFERENCES `section` (`id`),
  CONSTRAINT `product_ibfk_2` FOREIGN KEY (`branch`) REFERENCES `branch` (`id`),
  CONSTRAINT `product_ibfk_3` FOREIGN KEY (`category`) REFERENCES `category` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=23632 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `product`
--

LOCK TABLES `product` WRITE;
/*!40000 ALTER TABLE `product` DISABLE KEYS */;
/*!40000 ALTER TABLE `product` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `section`
--

DROP TABLE IF EXISTS `section`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `section` (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(50) NOT NULL,
  `branch` int NOT NULL,
  PRIMARY KEY (`id`),
  KEY `branch` (`branch`),
  CONSTRAINT `section_ibfk_1` FOREIGN KEY (`branch`) REFERENCES `branch` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `section`
--

LOCK TABLES `section` WRITE;
/*!40000 ALTER TABLE `section` DISABLE KEYS */;
INSERT INTO `section` VALUES (1,'section1',1),(2,'section2',1),(3,'section3',1);
/*!40000 ALTER TABLE `section` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `send`
--

DROP TABLE IF EXISTS `send`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `send` (
  `id` int NOT NULL AUTO_INCREMENT,
  `password` varchar(20) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `send`
--

LOCK TABLES `send` WRITE;
/*!40000 ALTER TABLE `send` DISABLE KEYS */;
/*!40000 ALTER TABLE `send` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `shop`
--

DROP TABLE IF EXISTS `shop`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `shop` (
  `id` int NOT NULL AUTO_INCREMENT,
  `seller` int NOT NULL,
  `client` int NOT NULL,
  `card` double NOT NULL,
  `transfer` double NOT NULL,
  `cash_sum` double NOT NULL,
  `cash_dollar` double NOT NULL,
  `loan_sum` double NOT NULL,
  `loan_dollar` double NOT NULL,
  `discount_sum` double NOT NULL,
  `discount_dollar` double NOT NULL,
  `traded_at` datetime NOT NULL,
  `status_server` int NOT NULL,
  `status_payment` int NOT NULL,
  `queue` int NOT NULL,
  `debt` int NOT NULL,
  `book` int NOT NULL,
  `comment` varchar(255) DEFAULT NULL,
  `total_sum` double NOT NULL,
  `total_dollar` double NOT NULL,
  PRIMARY KEY (`id`),
  KEY `client` (`client`),
  CONSTRAINT `shop_ibfk_4` FOREIGN KEY (`client`) REFERENCES `client` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=64 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `shop`
--

LOCK TABLES `shop` WRITE;
/*!40000 ALTER TABLE `shop` DISABLE KEYS */;
INSERT INTO `shop` VALUES (1,4,1,0,0,0,0,0,0,0,0,'2021-09-21 00:00:00',1,0,0,0,0,'none',0,0);
/*!40000 ALTER TABLE `shop` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `shopid`
--

DROP TABLE IF EXISTS `shopid`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `shopid` (
  `id` int NOT NULL AUTO_INCREMENT,
  `shop` int NOT NULL,
  `password` varchar(20) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `shopid`
--

LOCK TABLES `shopid` WRITE;
/*!40000 ALTER TABLE `shopid` DISABLE KEYS */;
/*!40000 ALTER TABLE `shopid` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `staff`
--

DROP TABLE IF EXISTS `staff`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `staff` (
  `id` int NOT NULL AUTO_INCREMENT,
  `first_name` varchar(50) NOT NULL,
  `token` varchar(100) NOT NULL,
  `password` varchar(20) NOT NULL,
  `role` varchar(50) NOT NULL,
  `section` int NOT NULL,
  PRIMARY KEY (`id`),
  KEY `section` (`section`),
  CONSTRAINT `staff_ibfk_1` FOREIGN KEY (`section`) REFERENCES `section` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `staff`
--

LOCK TABLES `staff` WRITE;
/*!40000 ALTER TABLE `staff` DISABLE KEYS */;
INSERT INTO `staff` VALUES (4,'Sardorbek','c35661b344b47120cf9435b54b3638d4f3cfab4c','123','head_of_branch',1),(14,'Omadbek','e78bc28bb72653bf04d11d378fce1fac1275a5f1','qwertyuiop','seller',2),(15,'Fayzullo','ffefef89cb154d25e3dc3692ddf417ad27084b3a','extra','cashier',3);
/*!40000 ALTER TABLE `staff` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-09-21 12:46:05
