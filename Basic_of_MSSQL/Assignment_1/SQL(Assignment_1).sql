use shashi;

--- user table in shashi database
create table users (
user_id int primary key,
email varchar(50),
name varchar(50));


--- books table in shashi database
create table books(
product_id int primary key,
title varchar(50),
price float
)

--- creating orders table
create table orders(
order_no int primary key,
user_id int,
product_id int,
foreign key(user_id) references users(user_id),
foreign key(product_id) references books(product_id)
)

exec sp_help books

--- Inserting data into uesrs table
insert into users values
(1, 'callmebhai@gmail.com', 'Gopal'),
(2, 'toxicmanji@gmail.com', 'Manjit'),
(3, 'kalajadu@gmail.com','soumyaDeep'),
(4, 'vimalpanmasala@gmail.com','JaiSai'),
(5, 'ghostlaugh@gmail.com', 'Namita');

--- Inserting data into book table
insert into books values
(101,'MsSql',100 ),
(102, 'Half Girlfriend', 699),
(103, 'Black Magic',700 ),
(104, 'Marfa',2000),
(105, 'How to laugh', 2001)

--- Inserting data into orders table
insert into orders values
(401, 1, 101),
(402, 2, 103),
(403, 2, 102),
(404, 3, 103),
(405, 3, 104),
(406, 4, 102),
(407, 5, 102),
(408, 5, 105)


--- Query to all recordes of three table by joining them
select *
from users u
left join orders o
on u.user_id = o.user_id
inner join books b
on b.product_id = o.product_id
;

--- Query to return records those who buys 'Black Magic' book
select u.name, o.order_no, b.title, b.price
from users u
left join orders o
on u.user_id = o.user_id
inner join books b
on b.product_id = o.product_id
where b.title = 'Black Magic'
;


--- Query to return record who buys book with maximum price
select u.name, o.order_no, b.title, b.price
from users u
left join orders o
on u.user_id = o.user_id
inner join books b
on b.product_id = o.product_id
where b.price = (select max(price) from books )
;


