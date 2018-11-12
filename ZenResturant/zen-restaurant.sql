-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 26-10-2018 a las 00:05:49
-- Versión del servidor: 10.1.35-MariaDB
-- Versión de PHP: 7.2.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `zen-restaurant`
--

DELIMITER $$
--
-- Procedimientos
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `crudBoletaCompra` (IN `_idboleta` INT, IN `_glosa_compra` VARCHAR(255), IN `_fecha_compra` DATE, IN `_importe` DOUBLE, IN `_vendedor` INT, IN `accion` VARCHAR(45))  begin 
    IF accion = 'new' then
      INSERT INTO boleta_compra (glosa_compra,fecha_compra,importe_total,vendedor) VALUES(_glosa_compra,_fecha_compra,_importe,_vendedor);
    end IF;
    IF accion = 'update' then
      UPDATE boleta_compra SET glosa_compra=_glosa_compra,fecha_compra=_fecha_compra,importe_total=_importe,vendedor=_vendedor WHERE idboleta_compra=_idboleta;
    end IF;
    IF accion = 'delete' then
      DELETE FROM boleta_compra WHERE idboleta_compra=_idboleta;
    end IF;
    IF accion = 'selectLIKE' then
      SELECT * FROM boleta_compra WHERE idboleta_compra=_idboleta;
    end IF;
    IF accion = 'selectId' then
      SELECT * FROM boleta_compra WHERE idboleta_compra=_idboleta;
    end IF;
    IF accion = 'select' then
      SELECT * FROM boleta_compra order by idboleta_compra desc;
    end IF;
    IF accion = 'ultimo_id' then
      SELECT idboleta_compra FROM boleta_compra order by idboleta_compra DESC LIMIT 1;
    end IF;
  end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `crudBoletaVenta` (IN `_idboleta` INT, IN `_nit_ci_cliente` INT, IN `_fecha_boleta` DATE, IN `_importe_total` DOUBLE, IN `_vendedor` INT, IN `accion` VARCHAR(45))  begin 
    IF accion = 'new' then
    	SET @id_cliente=(SELECT idcliente FROM cliente where ci_cliente=_nit_ci_cliente);
    	
      INSERT INTO boleta_venta (nit_ci_cliente,fecha_boleta,importe_total,id_cliente,vendedor) VALUES(_nit_ci_cliente,_fecha_boleta,_importe_total,@id_cliente,_vendedor);
    end IF;
    IF accion = 'update' then
      UPDATE boleta_venta SET nit_ci_cliente=_nit_ci_cliente,fecha_boleta=_fecha_boleta,importe_total=_importe_total,vendedor=_vendedor WHERE idboleta_venta=_idboleta;
    end IF;
    IF accion = 'delete' then
      DELETE FROM boleta_venta WHERE idboleta_venta=_idboleta;
    end IF;
    IF accion = 'selectLIKE' then
      SELECT * FROM boleta_venta WHERE idboleta_venta=_idboleta;
    end IF;
    IF accion = 'selectId' then
      SELECT * FROM boleta_venta WHERE idboleta_venta=_idboleta;
    end IF;
    IF accion = 'select' then
      SELECT * FROM boleta_venta order by idboleta_venta desc;
    end IF;
    IF accion = 'ultimo_id' then
      SELECT idboleta_venta FROM boleta_venta order by idboleta_venta DESC LIMIT 1;
    end IF;
    IF accion = 'obtener_norden' then
      SET @norden=(SELECT count(fecha_boleta) FROM boleta_venta where fecha_boleta=_fecha_boleta)+1;
    	SELECT @norden as n_orden;
    end IF;
  end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `crudCliente` (IN `_idcliente` INT, IN `_nombre` VARCHAR(45), IN `_ci` VARCHAR(45), IN `_celular` VARCHAR(45), IN `accion` VARCHAR(45))  begin 
    IF accion = 'new' then
      INSERT INTO cliente (nombre_cliente,ci_cliente,celular_cliente) VALUES(_nombre,_ci,_celular);
    end IF;
    IF accion = 'update' then
      UPDATE cliente SET nombre_cliente=_nombre,ci_cliente=_ci,celular_cliente=_celular WHERE idcliente=_idcliente;
    end IF;
    IF accion = 'delete' then
      DELETE FROM cliente WHERE idcliente = _idcliente;
    end IF;
    IF accion = 'selectLIKE' then
      SELECT * FROM cliente WHERE nombre_cliente like _nombre ;
    end IF;
    IF accion = 'selectId' then
      SELECT * FROM cliente WHERE idcliente = _idcliente;
    end IF;
    IF accion = 'select' then
      SELECT * FROM cliente ;
    end IF;
    IF accion = 'selectCI' then
      SELECT * FROM cliente WHERE ci_cliente=_ci;
    end IF;
  end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `crudCompra` (IN `_idcompra` INT, IN `_codigo_producto_compra` VARCHAR(50), IN `_precio_compra` DOUBLE, IN `_cantidad` DOUBLE, IN `_total` DOUBLE, IN `_id_boleta_compra` INT, IN `accion` VARCHAR(45))  begin 
    IF accion = 'new' then
      INSERT INTO compra (codigo_producto_compra,precio_compra,cantidad,total,id_boleta_compra) VALUES(_codigo_producto_compra,_precio_compra,_cantidad,_total,_id_boleta_compra);
    	SET @cantidad=(select count(*) from inventario where codigo_producto=_codigo_producto_compra);
	 	IF @cantidad > 0 then
			call crudInventario(_codigo_producto_compra,_cantidad,'compra');
	 	end IF;
	 end IF;
    IF accion = 'update' then
      UPDATE compra SET codigo_producto_compra=_codigo_producto_compra,precio_compra=_precio_compra,cantidad=_cantidad,total=_total,id_boleta_compra=_id_boleta_compra WHERE idcompra=_idcompra;
    end IF;
    IF accion = 'delete' then
      DELETE FROM compra WHERE idcompra=_idcompra;
    end IF;
    IF accion = 'selectLIKE' then
      SELECT * FROM compra WHERE idcompra=_idcompra;
    end IF;
    IF accion = 'selectId' then
      SELECT * FROM compra WHERE idcompra=_idcompra;
    end IF;
    IF accion = 'select' then
      SELECT * FROM compra order by idcompra=_idcompra desc;
    end IF;
  end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `crudInventario` (IN `_codigo` VARCHAR(45), IN `_cantidad` INT, IN `accion` VARCHAR(45))  begin 
    IF accion = 'compra' then
		SET @cantidad = (select cantidad_disponible from inventario where codigo_producto=_codigo);
		UPDATE inventario SET cantidad_disponible=(@cantidad+_cantidad) WHERE  codigo_producto=_codigo;
		SET @mssg='Compra Realizada para el producto: '+_codigo;
    end IF;
    IF accion = 'venta' then
		SET @cantidad = (select cantidad_disponible from inventario where codigo_producto=_codigo);
    	SET @resultado = @cantidad-_cantidad;
    	IF @resultado>=0 then
    		UPDATE inventario SET cantidad_disponible=@resultado WHERE  codigo_producto=_codigo;
    		SET @mssg='Venta Realizada para el producto: '+_codigo;
    	end IF;
    	IF @resultado<0 then
    		SET @mssg='Cantidad insuficiente para el producto: '+_codigo;
    	end IF;
    end IF;
    IF accion = 'select' then
      SELECT inventario.codigo_producto as 'Codigo de Producto',producto.nombre_producto as 'Nombre de Producto', inventario.cantidad_disponible as 'Cantidad Disponible' FROM inventario inner join producto on inventario.codigo_producto = producto.codigo_producto;
    end IF;
  end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `crudPago` (IN `_idpago` INT, IN `_idboleta_venta` INT, IN `_cinit` INT, IN `_monto` DOUBLE, IN `_vendedor` INT, IN `accion` VARCHAR(45))  begin 
    IF accion = 'new' then
      INSERT INTO pago (idboleta_venta,cinit,monto,vendedor) VALUES(_idboleta_venta,_cinit,_monto,_vendedor);
    end IF;
    IF accion = 'update' then
      UPDATE pago SET idboleta_venta=_idboleta_venta,cinit=_cinit,monto=_monto,vendedor=_vendedor WHERE idpago=_idpago;
    end IF;
    IF accion = 'delete' then
      DELETE FROM pago WHERE idpago=_idpago;
    end IF;
    IF accion = 'selectId' then
      SELECT * FROM pago WHERE idpago=_idpago;
    end IF;
    IF accion = 'select' then
      SELECT * FROM pago;
    end IF;
    IF accion = 'obtenerpago' then
      SELECT monto FROM pago WHERE idboleta_venta=_idboleta_venta;
    end IF;
  end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `crudProducto` (IN `_idproducto` INT, IN `_nombre` VARCHAR(45), IN `_categoria` VARCHAR(50), IN `_precio` DOUBLE, IN `_codigo` VARCHAR(45), IN `_inventario` VARCHAR(45), IN `accion` VARCHAR(45))  begin   
    IF accion = 'new' then
      INSERT INTO producto (nombre_producto,categoria,codigo_producto,precio_producto,inventario_producto) VALUES(_nombre,_categoria,_codigo,_precio,_inventario);
    end IF;
    IF accion = 'update' then
      UPDATE producto SET nombre_producto=_nombre,categoria=_categoria,precio_producto=_precio,codigo_producto=_codigo,inventario_producto=_inventario WHERE idproducto=_idproducto;
    end IF;
    IF accion = 'delete' then
      DELETE FROM producto WHERE idproducto = _idproducto;
      DELETE FROM inventario WHERE codigo_producto = _codigo;
    end IF;
    IF accion = 'selectLIKE' then
      SELECT * FROM producto WHERE nombre_producto like _nombre ;
    end IF;
    IF accion = 'selectId' then
      SELECT * FROM producto WHERE idproducto = _idproducto;
    end IF;
    IF accion = 'selectCategoria' then
      SELECT * FROM producto WHERE categoria = _categoria;
    end IF;
    IF accion = 'select' then
      SELECT * FROM producto ;
    end IF;
    IF _inventario = 'Si' then
      INSERT INTO inventario (codigo_producto,cantidad_disponible) VALUES(_codigo,0);
    end IF;
  end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `CrudReporte` (IN `fecha_ini` DATE, IN `fecha_fin` DATE, IN `accion` VARCHAR(45))  begin 
    IF accion = 'Compras' then
      SELECT * FROM boleta_compra WHERE fecha_compra BETWEEN fecha_ini  AND fecha_fin;
    end IF;
    IF accion = 'Ventas' then
      SELECT * FROM boleta_venta WHERE fecha_boleta BETWEEN fecha_ini  AND fecha_fin;
    end IF;
  end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `crudVenta` (IN `_idventa` INT, IN `_codigo_producto_venta` VARCHAR(50), IN `_precio_venta` DOUBLE, IN `_cantidad` DOUBLE, IN `_total` DOUBLE, IN `_id_boleta_venta` INT, IN `accion` VARCHAR(45))  begin 
    IF accion = 'new' then
      INSERT INTO venta (codigo_producto_venta,precio_venta,cantidad,total,id_boleta_venta) VALUES(_codigo_producto_venta,_precio_venta,_cantidad,_total,_id_boleta_venta);
    	SET @cantidad=(select count(*) from inventario where codigo_producto=_codigo_producto_venta);
	 	IF @cantidad > 0 then
			call crudInventario(_codigo_producto_venta,_cantidad,'venta');
	 	end IF;
	 end IF;
    IF accion = 'update' then
      UPDATE venta SET codigo_producto_venta=_codigo_producto_venta,precio_venta=_precio_venta,cantidad=_cantidad,total=_total,id_boleta_venta=_id_boleta_venta WHERE idventa=_idventa;
    end IF;
    IF accion = 'delete' then
      DELETE FROM venta WHERE idventa=_idventa;
    end IF;
    IF accion = 'selectLIKE' then
      SELECT * FROM venta WHERE idventa=_idventa;
    end IF;
    IF accion = 'selectId' then
      SELECT * FROM venta WHERE idventa=_idventa;
    end IF;
    IF accion = 'select' then
      SELECT * FROM venta order by idventa=_idventa desc;
    end IF;
  end$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `boleta_compra`
--

CREATE TABLE `boleta_compra` (
  `idboleta_compra` int(11) NOT NULL,
  `glosa_compra` varchar(255) DEFAULT NULL,
  `fecha_compra` date DEFAULT NULL,
  `importe_total` double DEFAULT NULL,
  `vendedor` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `boleta_venta`
--

CREATE TABLE `boleta_venta` (
  `idboleta_venta` int(11) NOT NULL,
  `nit_ci_cliente` int(11) DEFAULT NULL,
  `fecha_boleta` date DEFAULT NULL,
  `importe_total` double DEFAULT NULL,
  `vendedor` int(11) DEFAULT NULL,
  `id_cliente` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cliente`
--

CREATE TABLE `cliente` (
  `idcliente` int(11) NOT NULL,
  `nombre_cliente` varchar(45) DEFAULT NULL,
  `ci_cliente` varchar(45) DEFAULT NULL,
  `celular_cliente` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `compra`
--

CREATE TABLE `compra` (
  `idcompra` int(11) NOT NULL,
  `codigo_producto_compra` varchar(45) DEFAULT NULL,
  `precio_compra` double DEFAULT NULL,
  `cantidad` double DEFAULT NULL,
  `total` double DEFAULT NULL,
  `id_boleta_compra` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `inventario`
--

CREATE TABLE `inventario` (
  `idinventario_gaseosa` int(11) NOT NULL,
  `codigo_producto` varchar(45) DEFAULT NULL,
  `cantidad_disponible` double DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pago`
--

CREATE TABLE `pago` (
  `idpago` int(11) NOT NULL,
  `idboleta_venta` int(11) NOT NULL,
  `cinit` int(11) NOT NULL,
  `monto` double NOT NULL,
  `vendedor` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `producto`
--

CREATE TABLE `producto` (
  `idproducto` int(11) NOT NULL,
  `nombre_producto` varchar(45) DEFAULT NULL,
  `categoria` varchar(50) DEFAULT NULL,
  `codigo_producto` varchar(45) DEFAULT NULL,
  `precio_producto` double DEFAULT '0',
  `inventario_producto` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `venta`
--

CREATE TABLE `venta` (
  `idventa` int(11) NOT NULL,
  `codigo_producto_venta` varchar(50) DEFAULT NULL,
  `precio_venta` double DEFAULT NULL,
  `cantidad` double DEFAULT NULL,
  `total` double DEFAULT NULL,
  `id_boleta_venta` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `boleta_compra`
--
ALTER TABLE `boleta_compra`
  ADD PRIMARY KEY (`idboleta_compra`);

--
-- Indices de la tabla `boleta_venta`
--
ALTER TABLE `boleta_venta`
  ADD PRIMARY KEY (`idboleta_venta`);

--
-- Indices de la tabla `cliente`
--
ALTER TABLE `cliente`
  ADD PRIMARY KEY (`idcliente`);

--
-- Indices de la tabla `compra`
--
ALTER TABLE `compra`
  ADD PRIMARY KEY (`idcompra`);

--
-- Indices de la tabla `inventario`
--
ALTER TABLE `inventario`
  ADD PRIMARY KEY (`idinventario_gaseosa`);

--
-- Indices de la tabla `pago`
--
ALTER TABLE `pago`
  ADD PRIMARY KEY (`idpago`);

--
-- Indices de la tabla `producto`
--
ALTER TABLE `producto`
  ADD PRIMARY KEY (`idproducto`);

--
-- Indices de la tabla `venta`
--
ALTER TABLE `venta`
  ADD PRIMARY KEY (`idventa`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `boleta_compra`
--
ALTER TABLE `boleta_compra`
  MODIFY `idboleta_compra` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `boleta_venta`
--
ALTER TABLE `boleta_venta`
  MODIFY `idboleta_venta` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `cliente`
--
ALTER TABLE `cliente`
  MODIFY `idcliente` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `compra`
--
ALTER TABLE `compra`
  MODIFY `idcompra` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `inventario`
--
ALTER TABLE `inventario`
  MODIFY `idinventario_gaseosa` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `pago`
--
ALTER TABLE `pago`
  MODIFY `idpago` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `producto`
--
ALTER TABLE `producto`
  MODIFY `idproducto` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `venta`
--
ALTER TABLE `venta`
  MODIFY `idventa` int(11) NOT NULL AUTO_INCREMENT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
