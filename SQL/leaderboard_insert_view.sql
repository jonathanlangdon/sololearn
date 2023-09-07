-- create a table, insert values, and view table

CREATE TABLE leaderboard(
    number INT,
    nickname VARCHAR(20),
    rating INT
);

INSERT INTO leaderboard VALUES
(1, 'Predator', 9500),
(2, 'JohnWar', 9300),
(3, 'NightWarrior', 8900);

SELECT * FROM leaderboard
ORDER BY rating DESC