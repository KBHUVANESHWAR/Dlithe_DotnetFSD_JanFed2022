use webapi
create table userregistration
(
id int PRIMARY KEY identity,
Name varchar(25),
email varchar(25),
gender varchar(25),
username varchar(25),
password varchar(25)
)
select *from userregistration
insert into userregistration values('bhuvaneshwari','kbhuvi28@gmail.com','Female','bhuvaneshwari','bhuvana06')