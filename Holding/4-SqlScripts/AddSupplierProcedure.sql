USE db_holding
DROP PROCEDURE AddSupplierProcedure
GO
CREATE PROCEDURE AddSupplierProcedure
(
	@sup_name VARCHAR(50),
	@sup_address VARCHAR(100),
	@sup_zipcode CHAR(5),
	@sup_city VARCHAR(50),
	@sup_contact_name VARCHAR(50),
	@sup_satisfaction TINYINT,
	@id_supplier INT OUTPUT
)
AS
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
(
	@sup_name,
	@sup_address,
	@sup_zipcode,
	@sup_city,
	@sup_contact_name,
	@sup_satisfaction
)
SET @id_supplier = SCOPE_IDENTITY();
RETURN @id_supplier;
GO