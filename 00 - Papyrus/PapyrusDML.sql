USE db_papyrus;

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
('NISSAN', '1647  Lyon Avenue', '01752', 'Marlboro', 'Jon', 5),
('TOYOTA', '803  Pine Street', '16001', 'Butler', 'James ', 5),
('FORD', '49  John Daniel Drive', '63901', 'Poplar Bluff', 'Joe ', 8);

INSERT INTO t_orders
(
	order_date,
	order_comments
)
VALUES
('20-12-2020', null),
('20-12-2020', 'Delivery failed');