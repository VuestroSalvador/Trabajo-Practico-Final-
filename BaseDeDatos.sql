-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Versión del servidor:         10.4.19-MariaDB - mariadb.org binary distribution
-- SO del servidor:              Win64
-- HeidiSQL Versión:             11.2.0.6213
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Volcando estructura de base de datos para ventas_tpfinal
CREATE DATABASE IF NOT EXISTS `ventas_tpfinal` /*!40100 DEFAULT CHARACTER SET utf8mb4 */;
USE `ventas_tpfinal`;

-- Volcando estructura para tabla ventas_tpfinal.clientes
CREATE TABLE IF NOT EXISTS `clientes` (
  `ID_Clientes` int(11) NOT NULL AUTO_INCREMENT,
  `Cliente` varchar(50) NOT NULL,
  `Telefono` varchar(50) NOT NULL DEFAULT '',
  `Correo` varchar(50) NOT NULL,
  PRIMARY KEY (`ID_Clientes`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Volcando datos para la tabla ventas_tpfinal.clientes: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `clientes` DISABLE KEYS */;
/*!40000 ALTER TABLE `clientes` ENABLE KEYS */;

-- Volcando estructura para tabla ventas_tpfinal.productos
CREATE TABLE IF NOT EXISTS `productos` (
  `ID_Producto` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(50) NOT NULL,
  `Precio` int(11) NOT NULL,
  `Categoria` varchar(50) NOT NULL,
  PRIMARY KEY (`ID_Producto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Volcando datos para la tabla ventas_tpfinal.productos: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `productos` DISABLE KEYS */;
/*!40000 ALTER TABLE `productos` ENABLE KEYS */;

-- Volcando estructura para tabla ventas_tpfinal.ventas
CREATE TABLE IF NOT EXISTS `ventas` (
  `ID_Ventas` int(11) NOT NULL AUTO_INCREMENT,
  `ID_Cliente` int(11) NOT NULL,
  `Fecha` date NOT NULL,
  `Total` int(11) NOT NULL,
  PRIMARY KEY (`ID_Ventas`),
  KEY `ID_Cliente` (`ID_Cliente`),
  CONSTRAINT `ID_CLIENTE` FOREIGN KEY (`ID_Cliente`) REFERENCES `clientes` (`ID_Clientes`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Volcando datos para la tabla ventas_tpfinal.ventas: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `ventas` DISABLE KEYS */;
/*!40000 ALTER TABLE `ventas` ENABLE KEYS */;

-- Volcando estructura para tabla ventas_tpfinal.ventasitems
CREATE TABLE IF NOT EXISTS `ventasitems` (
  `ID_Vitems` int(11) NOT NULL AUTO_INCREMENT,
  `ID_Ventas` int(11) NOT NULL,
  `ID_Producto` int(11) NOT NULL,
  `PrecioUnitario` int(11) NOT NULL,
  `Cantidad` int(11) NOT NULL,
  `PrecioTotal` int(11) NOT NULL,
  PRIMARY KEY (`ID_Vitems`),
  KEY `ID_Ventas` (`ID_Ventas`),
  KEY `ID_Producto` (`ID_Producto`),
  CONSTRAINT `ID_Producto` FOREIGN KEY (`ID_Producto`) REFERENCES `productos` (`ID_Producto`),
  CONSTRAINT `ID_Ventas` FOREIGN KEY (`ID_Ventas`) REFERENCES `ventas` (`ID_Ventas`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Volcando datos para la tabla ventas_tpfinal.ventasitems: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `ventasitems` DISABLE KEYS */;
/*!40000 ALTER TABLE `ventasitems` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
