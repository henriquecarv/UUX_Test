# UUX C# Junior Developer Test

## Summary
The following test intends to validate desirable and mandatory technical background.

The candidate will start with a Visual Studio Web Project using a default template with 4.5 .Net Framework and MVC Architecture.

Classes already implemented: 
 - Models/Category.cs: Product's Category Class;
 - Models/Product.cs: Product's Class;
 - DAL/MockProductDao.cs: Data Access Layer Class with fake data;
 
 
## Goals

Using the available classes, the page should display a list of products in a View using the GetAllProducts() method from the MockProductDao class.

Desirable implementations:

- Use MVC Architecture.
- Display a list with as much product information as possible using a table format.
- Display a list with using a pagination of 10 itens maximum per page.
- Implement this pagination thinking with performance in mind.

Optional implementations:

- Select pagination number (according to the users desire).
- Select sorting using the fields table header.
- Select visible columns.
