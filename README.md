# AdventureWorksApi-Part1

Steps 

Create Adventure works database
Create Asp.net web api project
Create models using reverse engineering 
Create simple CRUD operations on products table


Required Packages - 
 Microsoft.EntityFrameworkCore.SqlServer
 Microsoft.EntityFrameworkCore.SqlServer.Design
 Microsoft.EntityFrameworkCore.Tools

Scaffold command

Scaffold-DbContext "Server=.\SQLEXPRESS;Initial Catalog=AdventureWorks;Persist Security Info=False;User ID=sauser;Password=yourpassword;MultipleActiveResultSets=False;TrustServerCertificate=False;Connection Timeout=30;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir "Models" -Force -Context "AdventureWorksDBContext" -UseDatabaseNames -NoPluralize
