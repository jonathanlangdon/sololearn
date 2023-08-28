-- get avg salary of each department

SELECT department, AVG(salary) AS average FROM staff 
GROUP BY department ORDER BY average DESC 