/* Write your T-SQL query statement below */
SELECT Name as Customers from Customers Where Customers.id Not In (Select customerId from Orders)