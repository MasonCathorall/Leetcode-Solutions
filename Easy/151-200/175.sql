# Write your MySQL query statement below

SELECT p.firstName, p.lastName, a.city, a.state 
From Person as p Left Join Address as a
on p.personId = a.personId
