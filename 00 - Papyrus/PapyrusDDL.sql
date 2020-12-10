--DROP DATABASE IF EXISTS db_papyrus;
--GO
--CREATE DATABASE db_papyrus;
--USE db_papyrus;


DROP TABLE IF EXISTS t_order_lines;
DROP TABLE IF EXISTS t_products;
DROP TABLE IF EXISTS t_orders;
DROP TABLE IF EXISTS t_suppliers;


CREATE TABLE t_suppliers
(
	id_supplier INT IDENTITY(1,1) NOT NULL,
	sup_name VARCHAR(50) NOT NULL,
	supp_address VARCHAR(100) NOT NULL,
	supp_zipcode CHAR(5) NOT NULL,
	sup_city VARCHAR(50) NOT NULL,
	sup_contact_name VARCHAR(50),
	sup_satisfaction TINYINT,
	--Primary key--
	CONSTRAINT PK_supplier PRIMARY KEY (id_supplier)
);

CREATE TABLE t_orders
(
	id_order INT IDENTITY(1,1) NOT NULL,
	order_date DATE NOT NULL,
	order_comments VARCHAR(100),
	fk_id_supplier INT NOT NULL,
	--Primary key--
	CONSTRAINT PK_order PRIMARY KEY (id_order),
	--Foreign keys--
	CONSTRAINT FK_supplier_in_order FOREIGN KEY (fk_id_supplier) REFERENCES t_suppliers(id_supplier)
);


CREATE TABLE t_products
(
	id_product INT IDENTITY(1,1) NOT NULL,
	product_label VARCHAR(50) NOT NULL,
	product_real_stock INT NOT NULL,
	product_critical_stock INT NOT NULL,
	product_annual_output INT NOT NULL,
	product_measurement_unit INT NOT NULL,
	fk_id_supplier INT NOT NULL,
	--Primary key--
	CONSTRAINT PK_product PRIMARY KEY (id_product),
	--Foreign keys--
	CONSTRAINT FK_supplier_in_product FOREIGN KEY (fk_id_supplier) REFERENCES t_suppliers(id_supplier)
);


CREATE TABLE t_order_lines
(
	fk_id_order INT NOT NULL,
	fk_id_product INT NOT NULL,
	line_product_quantity INT NOT NULL,
	line_delivery_date DATE NOT NULL,
	--Foreign keys--
	CONSTRAINT FK_order_in_line FOREIGN KEY (fk_id_order) REFERENCES t_orders(id_order),
	CONSTRAINT FK_product_in_line FOREIGN KEY (fk_id_product) REFERENCES t_products(id_product),
	--Primary key--
	CONSTRAINT PK_order_line PRIMARY KEY (fk_id_order, fk_id_product)
);