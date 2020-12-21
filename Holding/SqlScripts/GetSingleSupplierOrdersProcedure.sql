USE db_hollding;
DROP PROCEDURE GetOrderProcedure;
GO

CREATE PROCEDURE GetOrderProcedure
	@id_supplier INT
AS
	SELECT id_order, order_date, order_comments, sup_name
	FROM t_orders
	JOIN t_suppliers 
	ON t_orders.fk_id_supplier = t_suppliers.id_supplier
	WHERE id_supplier = @id_supplier;

GO