-- using UPDATE to add data to rows for a new column

ALTER TABLE cities
ADD COLUMN place TEXT;

UPDATE cities
SET place = CASE
    WHEN name = 'Lisbon' THEN 'Belem Tower'
    WHEN name = 'Madrid' THEN 'Plaza Mayor'
    WHEN name = 'Paris' THEN 'Eiffel Tower'
    ELSE place
END;

SELECT * FROM cities;