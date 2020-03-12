CREATE PROCEDURE spSelCategories
AS
BEGIN 

	SELECT ID, Name, Description
	FROM Categories
END