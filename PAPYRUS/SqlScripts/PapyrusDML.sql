USE db_papyrus;

-- DATA SET SUPPLIERS
INSERT INTO t_suppliers
(
	sup_name, 
	sup_address, 
	sup_zipcode,
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
('20200101', null, 1),
('20200102', 'Delivery OK', 1),
('20200103', 'Delivery failed', 1),
('20200104', 'Delivery failed', 2),
('20200105', 'Delivery OK', 2),
('20200106', 'Delivery OK', 3),
('20200107', 'Delivery failed', 3),
('20200108', 'Delivery OK', 3),
('20200109', null, 4),
('20200110', 'Delivery failed', 5),
('20200111', 'Delivery OK', 5);

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
-- Peugeot products
('Peugeot 207', 1290, 100, 2000, 'P207', 20000, 1),
('Peugeot 307', 11290, 1100, 12000, 'P307', 27000, 1),
('Peugeot 208', 1900, 500, 2000, 'P208', 22000, 1),
-- Renault products
('Renault Clio', 1290, 100, 2000, 'CLIO', 23000, 2),
('Renault Espace', 1490, 200, 3000, 'ESPA', 25000, 2),
-- Nissan products
('Nissan Leaf', 120, 150, 500, 'LEAF', 21000, 3),
('Nissan Juke', 12190, 1500, 22000, 'JUKE', 24000, 3),
-- Toyota products
('Toyota Rave 4', 190, 100, 600, 'RAV4', 25000, 4),
-- Ford products
('Ford Kuga', 3290, 600, 5000, 'KUGA', 26000, 5);


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
-- order 1
(1, 1, 2, 20000, 'Peugeot 207', '20200101'),
(1, 2, 1, 27000, 'Peugeot 307', '20200101'),
(1, 3, 3, 22000, 'Peugeot 208', '20200101'),
-- order 2
(2, 1, 2, 20000, 'Peugeot 207', '20200102'),
(2, 2, 1, 27000, 'Peugeot 307', '20200102'),
(2, 3, 3, 22000, 'Peugeot 208', '20200102'),
-- order 3
(3, 1, 2, 20000, 'Peugeot 207', '20200103'),
(3, 2, 1, 27000, 'Peugeot 307', '20200103'),
(3, 3, 3, 22000, 'Peugeot 208', '20200103'),
-- order 4
(4, 4, 4, 23000, 'Renault Clio', '20200104'),
(4, 5, 6, 25000, 'Renault Espace', '20200104'),
-- oreder 5
(5, 4, 4, 23000, 'Renault Clio', '20200105'),
(5, 5, 6, 25000, 'Renault Espace', '20200105'),
-- order 6
(6, 6, 1, 21000, 'Nissan Leaf', '20200106'),
(6, 7, 5, 24000, 'Nissan Juke', '20200106'),
-- order 7
(7, 6, 1, 21000, 'Nissan Leaf', '20200107'),
(7, 7, 5, 24000, 'Nissan Juke', '20200107'),
-- order 8
(8, 6, 1, 21000, 'Nissan Leaf', '20200108'),
(8, 7, 5, 24000, 'Nissan Juke', '20200108'),
-- order 9
(9, 8, 2, 25000, 'Toyota Rave 4', '20200109'),
-- order 10
(10, 9, 2, 26000, 'Ford Kuga', '20200110'),
-- order 11
(11, 9, 2, 26000, 'Ford Kuga', '20200111');