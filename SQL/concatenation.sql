-- Sql create new user emails based on first name last name concatenation

SELECT LOWER(CONCAT(firstname, '.', lastname, '@company.com')) AS email FROM Employees ORDER BY email ASC