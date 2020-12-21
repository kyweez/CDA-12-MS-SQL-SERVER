USE db_holding;
DROP PROCEDURE GetAllOrderProcedure;
GO

CREATE PROCEDURE GetAllOrderProcedure
AS
	SELECT id_order, order_date, order_comments, sup_name
	FROM t_orders
	JOIN t_suppliers 
	ON t_orders.fk_id_supplier = t_suppliers.id_supplier

GO