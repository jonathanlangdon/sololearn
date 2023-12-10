-- table name: posts extract the sum of likes for each topic

SELECT topic, SUM(likes) AS sum
FROM posts
GROUP BY topic