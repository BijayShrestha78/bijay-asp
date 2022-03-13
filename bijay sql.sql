create database boy;
use boy;

create table employee(
eid int primary key,
empname varchar(30) not null,
esalary int,
eaddress varchar(40)
);

insert into employee values(101,'bijay',20000,'butwal');
insert into employee values(102,'aayush',10000,'butwal');
insert into employee values(103,'nayan',30000,'butwal');
insert into employee values(104,'sohan',40000,'butwal');
insert into employee values(105,'kushal',50000,'butwal');
update employee set empname='rohan' where eid=101;
delete from employee where empname='anurag';

select eid,empname,esalary,eaddress from employee;

