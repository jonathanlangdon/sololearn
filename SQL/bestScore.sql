-- Get best score from each player and sort by scores SQL

SELECT nickname, MAX(score) AS best
FROM Scores
GROUP BY nickname
ORDER BY best DESC;