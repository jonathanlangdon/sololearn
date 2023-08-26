-- practice using NULL

SELECT * FROM suppliers
WHERE city NOT IN ('London','Paris') AND status IS NOT NULL 
ORDER BY name ASC