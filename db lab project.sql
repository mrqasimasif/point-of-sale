use pos


insert into dbo.sales values( 9999);

select sales_id from sales;

---Alter Table sales alter Column sales_id Int not null AUTO_INCREMENT Primary Key;---



create table sales(
sales_id int IDENTITY(1,1) not null PRIMARY KEY,
total_amount int,
customer_name varchar(50),
);

create table products(
product_id int IDENTITY(1,1) not null Primary Key,
product_name varchar(50),
product_cost int
);


create table sales_detail(
sales_id int foreign key references sales(sales_id),
product_name varchar(50),
product_cost int
);

drop table sales_detail
drop table sales
drop table products

select * from sales
select * from sales_detail

update sales set sales_id = 1 where sales_id = 4
update sales_detail set sales_id = 1 where sales_id = 4


---delete from sales and sales_detail where sales_id = 1
delete from sales_detail where sales_id = 1
delete from sales where sales_id = 1

select * from sales
select * from sales_detail where sales_id = 2



select sales_id, product_name, product_cost, total_amount,customer_name  from sales inner join sales_detail
on sales.sales_id = sales_detail.sales_id 

select * from sales inner join sales_detail
on sales.sales_id = sales_detail.sales_id 

