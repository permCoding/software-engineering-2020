SELECT * 
    FROM cities 
    JOIN summary_table USING (id_city);


SELECT * 
    FROM (SELECT * FROM cities JOIN summary_table USING (id_city))
       JOIN prices USING (id_shop);


SELECT name_city, name_shop, way, price
    FROM (SELECT * FROM cities JOIN summary_table USING (id_city))
        JOIN prices USING (id_shop);


SELECT name_city, name_shop, way, price
    FROM CitiesWithShop
        JOIN prices USING (id_shop);
/* view CitiesWithShop
SELECT * 
    FROM cities 
    JOIN summary_table USING (id_city)*/


SELECT name_city, name_shop, way, price
    FROM (SELECT * FROM cities JOIN summary_table USING (id_city))
        JOIN prices USING (id_shop)
            WHERE way <= 300;
   
         
SELECT cities.name_city, summary_table.id_shop
    FROM cities
        LEFT JOIN summary_table ON cities.id_city = summary_table.id_city;

       
SELECT cities.name_city, summary_table.id_shop
    FROM cities LEFT JOIN summary_table USING (id_city)
        WHERE id_shop IS NULL;

  
SELECT cities.name_city, summary_table.id_shop
    FROM cities LEFT JOIN summary_table USING (id_city)
        WHERE id_shop IS NOT NULL;
