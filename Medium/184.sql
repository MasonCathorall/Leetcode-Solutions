# Write your MySQL query statement below
SELECT d.name as Department, e.name as Employee, e.salary 
FROM employee as e
    Join department as d ON d.id = e.departmentId
Where
    (d.id, salary) In (
        Select departmentId, MAX(salary)
        From Employee Group By 1
    );