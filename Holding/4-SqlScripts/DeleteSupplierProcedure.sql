USE db_holding;
GO

CREATE PROCEDURE DeleteSupplierProcedure
	@id_supplier INT

AS

DELETE FROM t_suppliers
WHERE id_supplier = @id_supplier;

GO