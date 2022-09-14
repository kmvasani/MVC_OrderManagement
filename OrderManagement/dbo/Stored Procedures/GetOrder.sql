
CREATE PROCEDURE GetOrder   

	@OrderId uniqueidentifier
	  
 
AS  
BEGIN  

SELECT 
*
FROM [OrderManagement].[dbo].[Orders] 
WHERE Id = @OrderId  
END 