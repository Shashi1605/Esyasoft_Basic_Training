use shashi

--- Tasks 
-- 1. Find all the books all the users and all
select *
from users u
left join orders o
on u.user_id = o.user_id
inner join books b
on b.product_id = o.product_id


-- 2. Find all orders
select * 
from orders

-- 3. find particular user who has order these books
select b.title, u.name 
from books b
left join orders o
on b.product_id = o.product_id
inner join users u
on o.user_id = u.user_id


-- 4. find books users has order
select  u.name, b.title
from users u
left join orders o
on u.user_id = o.user_id
inner join books b
on o.product_id = b.product_id

-- 5. find total price of books user has order
select u.name, sum(b.price) as total_purchase_Amount
from users u
left join orders o
on u.user_id = o.user_id
inner join books b
on o.product_id = b.product_id
group by u.name

-- 6. Find the most valuable user

select top 1 u.name as "Most valuable user", sum(b.price) as total_purchase_Amount
from users u
left join orders o
on u.user_id = o.user_id
inner join books b
on o.product_id = b.product_id
group by u.name
order by total_purchase_Amount desc

-- 7. Find the range of books from high to low
select * 
from books
order by price desc

-- 8. Find the highest price book
select title , price as Highest_Price
from books
where price = (select max(price) from books)

-- 9. Find the cheapest book
select title, price as Cheapest_book
from books
where price = (select min(price) from books)

--- 10. find newly added books
select top 1 * from books
order by product_id desc



