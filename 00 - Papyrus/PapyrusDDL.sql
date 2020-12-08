DROP DATABASE IF EXISTS db_papyrus;
CREATE DATABASE db_papyrus;
-- USE db_papyrus;

DROP TABLE IF EXISTS t_suppliers;
CREATE TABLE t_suppliers
(
	id_supplier INT IDENTITY(1,1) NOT NULL,
	sup_name VARCHAR(50) NOT NULL,
	supp_address VARCHAR(50) NOT NULL,
	supp_zipcode CHAR(5) NOT NULL,
	sup_city VARCHAR(50) NOT NULL,
	sup_contact_name VARCHAR(50),
	sup_satisfaction TINYINT,
	--Primary key--
	CONSTRAINT PK_supplier PRIMARY KEY (id_supplier)
);

DROP TABLE IF EXISTS t_orders;
CREATE TABLE t_orders
(
	id_order INT IDENTITY(1,1) NOT NULL,
	order_date DATE NOT NULL,
	order_comments VARCHAR(50),
	--Primary key--
	CONSTRAINT PK_order PRIMARY KEY (id_order)
);

DROP TABLE IF EXISTS t_products;
CREATE TABLE t_products
(
	id_product INT IDENTITY(1,1) NOT NULL,
	product_label VARCHAR(50) NOT NULL,
	product_real_stock INT NOT NULL,
	product_critical_stock INT NOT NULL,
	product_annual_output INT NOT NULL,
	product_measurement_unit INT NOT NULL,
	--Primary key--
	CONSTRAINT PK_product PRIMARY KEY (id_product)
);

DROP TABLE IF EXISTS t_order_lines;
CREATE TABLE t_order_lines
(
	id_order INT NOT NULL,
	id_product INT NOT NULL,
	line_product_quantity INT NOT NULL,
	line_delivery_date DATE NOT NULL,
	--Foreign keys--
	CONSTRAINT FK_order_in_line FOREIGN KEY (id_order) REFERENCES t_orders(id_order),
	CONSTRAINT FK_product_in_line FOREIGN KEY (id_product) REFERENCES t_products(id_product),
	--Primary key--
	CONSTRAINT PK_order_line PRIMARY KEY (id_order, id_product)
);

DROP TABLE IF EXISTS t_sell;
CREATE TABLE t_sell
(
	id_supplier INT NOT NULL,
	id_product INT NOT NULL,
	--Foreign keys--
	CONSTRAINT FK_supplier_in_sell FOREIGN KEY (id_supplier) REFERENCES t_suppliers(id_supplier),
	CONSTRAINT FK_product_in_sell FOREIGN KEY (id_product) REFERENCES t_products(id_product),
	--Primary key--
	CONSTRAINT PK_sell PRIMARY KEY (id_supplier, id_product)
);

DROP TABLE IF EXISTS t_send;
CREATE TABLE t_send
(
	id_supplier INT NOT NULL,
	id_order INT NOT NULL,
	--Foreign keys--
	CONSTRAINT FK_supplier_in_send FOREIGN KEY (id_supplier) REFERENCES t_suppliers(id_supplier),
	CONSTRAINT FK_order_in_send FOREIGN KEY (id_order) REFERENCES t_orders(id_order),
	--Primary key--
	CONSTRAINT PK_send PRIMARY KEY (id_supplier, id_order)
);