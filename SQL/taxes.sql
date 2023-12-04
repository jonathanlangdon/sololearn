-- categorize salaries by tax rate and create new table using CASE/WHEN

SELECT firstname, lastname, salary,
CASE
    WHEN salary > 2000 THEN salary * .3
    WHEN salary > 1500 THEN salary * .2
    WHEN salary > 0 THEN salary * .1
END AS tax
FROM Employees
ORDER BY lastname ASC