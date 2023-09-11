--MVC
USE KrunalDhote351

create table Student(
	id int primary key identity(1,1),
	FirstName varchar(100),
	LastName Varchar(100),
	Email Varchar(100) Not Null Unique,
	Password Varchar(50),
	Address Varchar(250),
	Gender Char
)
Insert into Student Values('Krunal','Dhote','kruna2l.d@shaligraminfotech.com','Sit@321#','Amravati','M')

select * from Student

delete from Student where id>1

USertypes

insert into users values('dfd','sdsd','sdsd','shd@fffgf',103,'sds','9638527410',101,101,101)

