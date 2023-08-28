-- create custom column while using math operator

SELECT firstname, lastname, experience * 500 
AS total FROM staff ORDER BY total DESC 