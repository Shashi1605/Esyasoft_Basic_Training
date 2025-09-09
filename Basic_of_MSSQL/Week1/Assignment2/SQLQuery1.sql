--- Creating smart_meter database
create database smart_meter;

use smart_meter

--- Creating customers table
create table customers (
Customer_id int primary key,
Name varchar(50),
Address varchar(100),
Region varchar(10)
)


--- Creating SmartMeterReadings
create table SmartMeterReadings(
Meter_id int primary key,
Customer_id int ,
location varchar(20),
Install_Date date,
Reading_Date_time datetime,
Energy_Consumed float,
foreign key(Customer_id) references customers(Customer_id)
)

--- Inserting data into customers table
insert into customers values
(10, 'Shashi kumar', 'Ranchi Jharkhand', 'East'),
(11, 'Aman Singh', 'Jaipur Rajashthan', 'west'),
(12, 'Joy', 'Banaras UP', 'North'),
(13, 'Dharmesh', 'MP', 'Cent')



--- Inserting data into SmartMeterReadings table
insert into SmartMeterReadings values
(102,10, 'East', '2024-12-23','2024-12-23 11:30:00', 25.50),
(103,12, 'North', '2024-08-24','2024-08-24 01:23:40', 75.50),
(104,10, 'East', '2024-02-23','2024-02-23 11:40:00', 75.00),
(105,12, 'North', '2024-04-23','2024-04-23 10:00:00', 26.50),
(106,12, 'North', '2024-03-20','2024-03-20 10:40:00', 37.50),
(107,13, 'East', '2024-02-23','2024-02-23 10:00:00', 15.50),
(108,13, 'Cent', '2024-05-12','2024-05-12 05:00:40', 21.20),
(109,10, 'East', '2024-12-31','2024-12-31 03:30:00', 65.50)


--- Task 1 
select * from SmartMeterReadings
where Energy_Consumed between 10 and 50
	  and Reading_Date_time between '2024-01-01' and '2024-12-31'
	  and Reading_Date_time <= '2024-06-30'



--- Task 2
select Customer_id, round(avg(Energy_Consumed),2) as AvgEnergyConsumed, max(Energy_Consumed) as MaxEnergyConsumed
from SmartMeterReadings
group by Customer_id




