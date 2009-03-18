/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE */;
/*!40101 SET SQL_MODE='STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES */;
/*!40103 SET SQL_NOTES='ON' */;


DROP DATABASE IF EXISTS `innpos_pos`;
CREATE DATABASE `innpos_pos` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `innpos_pos`;
CREATE TABLE `pos_categorias` (
  `ID` int(11) NOT NULL,
  `N_CATEGORIA` varchar(35) NOT NULL default '0',
  PRIMARY KEY  (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
CREATE TABLE `pos_convenios` (
  `ID` int(11) NOT NULL,
  `RUT` varchar(12) default NULL,
  `DESCRIPCION` varchar(50) default NULL,
  `PORC_DESCUENTO` int(11) default NULL,
  `FECHA_INICIO` varchar(8) default NULL,
  `FECHA_FINAL` varchar(8) default NULL,
  PRIMARY KEY  (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
CREATE TABLE `pos_formas_pago` (
  `ID` int(11) NOT NULL auto_increment,
  `CODIGO` varchar(20) default NULL,
  `DESCRIPCION` varchar(30) default NULL,
  `FRACCION` varchar(1) default 'S',
  `VUELTO` varchar(1) default 'S',
  `NUMERODOC` varchar(1) default 'N',
  PRIMARY KEY  (`ID`)
) ENGINE=MyISAM AUTO_INCREMENT=15 DEFAULT CHARSET=utf8 ROW_FORMAT=FIXED;
CREATE TABLE `pos_inventario` (
  `ID` int(11) NOT NULL,
  `CODIGO` varchar(20) default NULL,
  `STOCK` int(11) default NULL,
  `STOCK_MIN` int(11) default NULL,
  `RUT_CLIENTE` varchar(20) default NULL,
  `DESCUENTO` int(11) default NULL,
  `IVA` int(11) default NULL,
  `NETO` int(11) default NULL,
  `TOTAL` int(11) default NULL,
  PRIMARY KEY  (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
CREATE TABLE `pos_lista_precio` (
  `ID` int(11) NOT NULL,
  `CODIGO` varchar(20) default NULL,
  `DESCRIPCION` varchar(50) default NULL,
  `NETO` int(11) default NULL,
  `COSTO` int(11) default NULL,
  `COD_BARRAS` varchar(13) default NULL,
  `STATUS` varchar(1) default NULL,
  `ID_PROVEEDOR` int(11) default NULL,
  `CATEGORIA_1` int(11) default NULL,
  `CATEGORIA_2` int(11) default NULL,
  `CATEGORIA_3` int(11) default NULL,
  `CATEGORIA_4` int(11) default NULL,
  `FECHA_MAX_CAMBIO` varchar(8) default NULL,
  PRIMARY KEY  (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
CREATE TABLE `pos_parametros` (
  `IVA` decimal(3,2) NOT NULL,
  `N_SUCURSAL` int(11) NOT NULL,
  `NO_SUCURSAL` varchar(50) NOT NULL,
  `DIRECCION` varchar(100) NOT NULL,
  `LISTA_PRECIO` int(11) NOT NULL,
  `NO_DOCTO` int(11) default NULL,
  UNIQUE KEY `N_SUCURSAL` (`N_SUCURSAL`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
CREATE TABLE `pos_proveedores` (
  `ID` int(11) NOT NULL auto_increment,
  `N_Proveedor` varchar(50) NOT NULL,
  PRIMARY KEY  (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
CREATE TABLE `pos_usuario` (
  `ID` int(11) NOT NULL,
  `USUARIO` varchar(15) default NULL,
  `PASSWORD` varchar(15) default NULL,
  `TIPO_ACCESO` varchar(20) default NULL,
  `NOMBRE` varchar(50) default NULL,
  PRIMARY KEY  (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
CREATE TABLE `pos_venta` (
  `ID` int(11) NOT NULL auto_increment,
  `TIPO_VENTA` int(11) default NULL,
  `NUMERO` int(11) default NULL,
  `USR_CAJ` int(11) default NULL,
  `RUT_CLIENTE` varchar(20) default NULL,
  `USR_VEN` int(11) default NULL,
  `FECHA` varchar(8) default NULL,
  `HORA` varchar(4) default NULL,
  `VALOR_TOTAL` int(11) default NULL,
  `BORRADOR` varchar(1) default '*',
  PRIMARY KEY  (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
CREATE TABLE `pos_venta_detalle` (
  `ID_VENTA` int(11) NOT NULL,
  `CODIGO` varchar(20) default NULL,
  `CANTIDAD` int(11) default NULL,
  `PRECIO_UNITARIO` int(11) default NULL,
  `NETO` int(11) default NULL,
  `IVA` int(11) default NULL,
  `TOTAL` int(11) default NULL,
  `DESCUENTO` int(11) default NULL,
  `ID` int(11) NOT NULL auto_increment,
  PRIMARY KEY  (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
CREATE TABLE `pos_venta_detalle_pago` (
  `ID_VENTA` int(11) NOT NULL,
  `TIPO_PAGO` int(11) default NULL,
  `FECHA_VENCIMIENTO` varchar(8) default NULL,
  `BANCO` varchar(20) default NULL,
  `VALOR_PAGADO` int(11) default NULL,
  `ID` int(11) NOT NULL auto_increment,
  PRIMARY KEY  (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
