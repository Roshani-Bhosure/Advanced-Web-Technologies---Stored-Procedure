Create PROCEDURE All_Operation_StoredProcedure(
@Name varchar(100)= null,
@Age varchar(100)= null,
@Country varchar(100)= null,
@Action varchar(100)= null
)
As begin
if @Action = 'Insert' Insert into UserRegistration(C_Name, C_Age,
C_Country) values(@Name, @Age, @Country)
if @Action = 'Update' Update UserRegistration set C_Name = @Name,
C_Age = @Age, C_Country = @Country where C_Name = @Name
if @Action= 'Delete' Delete from UserRegistration where C_Name =
@Name
end