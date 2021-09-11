#Заполенение таблицы продуктов
INSERT INTO tab_products (name, price)
VALUES ('Phone', 5000);

INSERT INTO tab_products (name, price)
VALUES ('Car', 50000);

#Заполенение таблицы остатков
INSERT INTO tab_products_stock (product_id, count)
VALUES (1, 10);

INSERT INTO tab_products_stock (product_id, count)
VALUES (2, 5);

INSERT INTO tab_people (first_name, last_name, phone)
VALUES ('Andrey', 'Starinin', '+79042144491');

INSERT INTO tab_people (first_name, last_name, phone)
VALUES ('Anonim', 'Anonimus', '+71231234567');

INSERT INTO tab_discounts (type, discount)
VALUES ('Gold', 50);

INSERT INTO tab_discounts (type, discount)
VALUES ('Silver', 25);

INSERT INTO tab_buyers (people_id, discount_id)
VALUES (2, 1);

INSERT INTO tab_positions (position)
VALUES ('chief manager');

INSERT INTO tab_positions (position)
VALUES ('manager');

INSERT INTO tab_sellers (people_id, position_id)
VALUES (1, 1);

INSERT INTO tab_orders (buyer_id, seller_id, date, product_id, amount, total_price)
VALUE (1, 1, '2021-11-23', 1, 2, 10000)

SELECT count
FROM tab_products_stock
JOIN tab_products 
    ON tab_products_stock.product_id = tab_products.id
WHERE product_id = 2;