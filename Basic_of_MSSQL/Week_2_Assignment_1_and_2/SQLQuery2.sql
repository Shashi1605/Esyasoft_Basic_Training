use shashi

-- Assignment 1 Top N books per users
--Finding top 2 most expensive books purchased by each user.

select * 
from(
	select 
		u.name,
		b.title, 
		b.price,
		rank() over (partition by u.name order by b.price desc) as Top_books
	from users u
		left join orders o
	on u.user_id = o.user_id
		inner join books b
	on o.product_id = b.product_id
) as tbl
where Top_books <= 2



-- Assignment 2
-- Ranking users by total Spending

select
	ranked_data.name,
	ranked_data.Total_price,
    dense_rank() over (order by ranked_data.Total_price desc) as "Rank"
from (
    select
        u.name,
        sum(b.price) AS Total_price
    from
        users u
    left join
        orders o on u.user_id = o.user_id
    inner join
        books b on o.product_id = b.product_id
    group by
        u.name
) as ranked_data
order by
    Total_price desc;





