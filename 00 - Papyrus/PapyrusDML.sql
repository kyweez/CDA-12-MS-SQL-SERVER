USE db_papyrus;

-- DATA SET SUPPLIERS
INSERT INTO t_suppliers
(
	sup_name, 
	supp_address, 
	supp_zipcode,
	sup_city,
	sup_contact_name,
	sup_satisfaction
)
VALUES
('PEUGEOT', '1449  Cameron Road', '76951', 'Beverly Hills', 'Bernard', 8),
('RENAULT', '3018  Fieldcrest Road', '10016', 'San Antonio', 'Sophie', 10),
('NISSAN', '1647  Lyon Avenue', '01752', 'Marlboro', null, 5),
('TOYOTA', '803  Pine Street', '16001', 'Butler', 'James ', 5),
('FORD', '49  John Daniel Drive', '63901', 'Poplar Bluff', null ,null);

-- DATA SET ORDERS
INSERT INTO t_orders
(
	order_date,
	order_comments,
	fk_id_supplier
)
VALUES
('01-01-2020', null, 1),
('02-02-2019', 'Delivery failed', 2),
('03-03-2018', 'Delivery OK', 3),
('04-04-2017', null, 4),
('05-05-2016', 'Delivery OK', 5);

-- DATA SET PRODUCTS
INSERT INTO t_products
(
	product_label,
	product_real_stock,
	product_critical_stock,
	product_annual_output,
	product_measurement_unit,
	product_price,
	fk_id_supplier
)
VALUES
('Peugeot 207', 1290, 100, 2000, 'P207', 20000, 1),
('Nissan Leaf', 120, 150, 500, 'LEAF', 21000, 3),
('Peugeot 208', 1900, 500, 2000, 'P208', 22000, 1),
('Renault Clio', 1290, 100, 2000, 'CLIO', 23000, 2),
('Nissan Juke', 12190, 1500, 22000, 'JUKE', 24000, 3),
('Toyota Rave 4', 190, 100, 600, 'RAV4', 25000, 4),
('Ford Kuga', 3290, 600, 5000, 'KUGA', 26000, 5),
('Peugeot 307', 11290, 1100, 12000, 'P307', 27000, 1);

-- DATA SET ORDER LINES
INSERT INTO t_order_lines
(
	fk_id_order,
	fk_id_product,
	line_product_quantity,
	line_product_price,
	line_product_label,
	line_delivery_date
)
VALUES
(1, 1, 2, 20000, 'Peugeot 207', '01-01-2020'),
(1, 3, 3, 22000, 'Peugeot 208', '01-01-2020'),
(1, 8, 1, 27000, 'Peugeot 307', '01-01-2020'),
(2, 2, 1, 21000, 'Nissan Leaf', '02-02-2019'),
(2, 5, 5, 22000, 'Nissan Leaf', '02-02-2019'),
(3, 4, 4, 23000, 'Renault Clio', '03-03-2018'),
(4, 7, 2, 20000, 'Toyota Rave 4', '04-04-2017'),
(5, 8, 2, 20000, 'Peugeot 307', '05-05-2016');