USE db_papyrus
GO
CREATE PROCEDURE UpdateSupplierProcedure
(
	@sup_name VARCHAR(50),
	@sup_address VARCHAR(100),
	@sup_zipcode CHAR(5),
	@sup_city VARCHAR(50),
	@sup_contact_name VARCHAR(50),
	@sup_satisfaction TINYINT,
	@id_supplier INT
)
AS
UPDATE t_suppliers
SET
	sup_name = @sup_name,
	sup_address = @sup_address,
	sup_zipcode = @sup_zipcode,
	sup_city = @sup_city,
	sup_contact_name = @sup_contact_name,
	sup_satisfaction = @sup_satisfaction
WHERE
	id_supplier = @id_supplier;