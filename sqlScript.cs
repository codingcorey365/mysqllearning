

//  Comment shortcut for workbench is ctl + '/'
//  Quickly select the documentation by placing the caret just before the first set of double dashes
//  Then press Shift + Alt + 'click on the last line that is directly below the caret placement'
//  This will allow you to select of the text without the C# Comment initializer




//   --Question 1--
//   -- joins: select all the computers from the products table:
//   -- using the products table and the categories table, return the product name and the category name
     
//   -- Result 1/2 ---
//   -- SELECT P.Name AS Product, C.Name AS Category FROM products AS P
//   -- INNER JOIN categories AS C
//   -- ON C.CategoryID = P.CategoryID
//   -- WHERE C.Name = "Computers";
     
//   --Result 2 / 2--
//   SELECT products.Name AS Product, categories.Name AS Category
//   FROM products
//   INNER JOIN categories on categories.CategoryID = products.CategoryID
//   WHERE categories.Name = "Computers";
     
//   --Question 2--
//   -- joins: find all product names, product prices, and products ratings that have a rating of 5 */
//   -- products table && Review Table and we'll join on productID column
     
//   -- Result
//   SELECT products.Name, products.Price, reviews.Rating
//   FROM products
//   INNER JOIN reviews ON reviews.ProductID = products.ProductID
//   WHERE reviews.Rating = 5;
     
//   --Question 3--
//   /* joins: find the employee with the most total quantity sold.  use the sum() function and group by */
     
//   -- Result
//   SELECT employees.FirstName, employees.LastName, Sum(Sales.quantity) AS Total
//   FROM sales
//   INNER JOIN employees ON employees.EmployeeID = sales.EmployeeID
//   GROUP BY employees.EmployeeID
//   ORDER BY Total DESC
//   LIMIT 2;
     
//   --Question 4--
//   /* joins: find the name of the department, and the name of the category for Appliances and Games */
     
//   -- Result
//   SELECT d.Name AS "Department Name", c.Name as "Category Name" 
//   FROM departments as d
//   INNER JOIN categories as c on c.DepartmentID = d.DepartmentID
//   WHERE c.Name = "Appliances" or c.Name = "Games";
     
//   --Question 5--
//   /* joins: find the product name, total # sold, and total price sold,
//    for Eagles: Hotel California --You may need to use SUM() */
     
//   -- Result
//   SELECT p.Name, Sum(s.Quantity) as "Total Sold", Sum(s.Quantity * s.PricePerUnit) as "Total Price"
//   FROM products as p
//   INNER JOIN sales as s on s.ProductID = p.ProductID
//   WHERE p.ProductID = 97;
//   --To Verify
//   -- SELECT* from sales where ProductID = 97;
     
//   --Question 6--
//   -- joins: find Product name, reviewer name, rating, and comment on the Visio TV.
//   -- (only return for the lowest rating!) */
     
//   -- Result
//   SELECT p.Name, r.Reviewer, r.Rating, r.Comment
//   FROM products as p
//   INNER JOIN reviews as r ON r.ProductID = p.ProductID
//   where p.ProductID = 857 and r.Rating = 1;
     
     
//   ---------------------Extra - May be difficult --------------------------------
     
//   -- Your goal is to write a query that serves as an employee sales report.
//   -- This query should return:
//   --the employeeID
//   -- the employee's first and last name
//   -- the name of each product
//   -- and how many of that product they sold */
     
//   -- Result
//   SELECT e.EmployeeID, e.FirstName, e.LastName, p.Name, SUM(s.Quantity) as TotalSold
//   FROM Sales as s
//   INNER JOIN employees as e on e.employeeID = s.EmployeeID
//   INNER JOIN products as p on p.ProductID = s.ProductID
//   GROUP BY e.EmployeeID, p.ProductID

