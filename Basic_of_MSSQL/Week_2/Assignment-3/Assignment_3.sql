use NIT_JSR
select * from Contacts

select * from Employees

---Show a list of all student names (unique only)
select * from Students2024
union 
select * from Students2025

---Show a list of all student names (including duplicates)
select * from Students2024
union all
select * from Students2025



--- upper and lower
select GETDATE()
select UPPER('hello') as upper_text;


--- Display employee names in UPPERCASE 
select UPPER(name)as Name
from Employees

---Display employee names in LOWERCASE.
select lower(name)as Name
from Employees


--- Find the length of each employee’s name
select len(name) as Name_length
from Employees

--- Show only the first 3 letters of each name.
select SUBSTRING(name,1,3) as Name
from Employees

--- Reverse
select REVERSE(name) from Students2024
select REVERSE(substring(name, 3, len(name))) from Students2024

--- Replace Finance department with Accounts.
select REPLACE(department,'Finance','Accounts') from Employees

--- Create a new column showing "Name - Department" using CONCAT.
select CONCAT(name , ' - ', department) as Detail 
from Employees


--- Show today’s date using GETDATE()
select getdate() as currentdate


--- Convert today’s date into DD/MM/YYYY format using CONVERT
select CONVERT(varchar(10), getdate(), 103) as Date_DDMMYYYY


--- Convert a float 123.456 into an integer using CAST
select CAST(123.89 as int) "Value"; 

----For employees (from Employees table above), categorize them:
--- If Dept = IT → show Tech Team
--- If Dept = HR → show Human Resources
--- Else → Other
select
    Name,
    department,
    case
        when department = 'IT' then 'Tech Team'
        when department = 'HR' then 'Human Resources'
        else 'Other'
    end as Department_Category
from
    Employees;

--- Find the duration (in days) of each project using DATEDIFF.
select DATEDIFF(day, StartDate, EndDate) as project_Duration
from Projects

--- Add 10 days to each project’s EndDate using DATEADD
select DATEADD(day,10,endDate) NewDate
from Projects