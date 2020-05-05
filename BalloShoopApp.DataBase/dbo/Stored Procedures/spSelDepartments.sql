create procedure spSelDepartments
as
begin

	select ID,
			Name,
			Description,
			CreatedAt,
			CreatedUser 
	from Departments
end