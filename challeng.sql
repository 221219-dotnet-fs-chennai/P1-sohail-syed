
CREATE TABLE employee
(Id int not null ,
 [FistName] Varchar(max),
  [LastName] Varchar(max),
  [SSN] BigInt,
  [Department_id] Int ,
  Constraint [Pk_employee] Primary key(Id),
  Constraint [Fk_employee] Foreign key(Department_id) references Department(ID) );


create table department (
[ID] int not null,
[Name] varchar(max),
[Location] varchar(max)

Constraint [Pk_department] Primary key(Id));

Create table empDetails(
[ID] int not null,
[EmployeeId] int Unique,
[salary] float,
[Address1] varchar(max),
[Address2] varchar(max),
[City] varchar(max),
[State]varchar(max),
[Country] varchar(max)

Constraint [Pk_empDetails] Primary Key(ID),
Constraint [Fk_empDetails] Foreign Key(EmployeeID) references employee(Id)
);


Insert into department ([Id],[name],[Location]) 
values (101,'Marketing', 'bangalore'),
(102,'System Admin', 'bangalore'),
(103,'DBS', 'bangalore'), 
(104,'Employee Engagement', 'bangalore');

Insert into employee

values (10101,'Tina','Smith',012111,101),
(10102,'carey','alex',011123,101),
(10103,'david','tim',011223,101),
(10201,'ross','mac',019231,102),
(10301, 'smith','steve',012919,103),
(10401, 'maxwell' , 'glenn',012871,104);

Insert into empDetails
values(1,10101,25000,'new street','kk nagar','bangalore','karnataka','India'),
(2,10102,23000,'new street','santosh nagar','bangalore','karnataka','India'),
(3,10103,25000,'new street','santosh nagar','bangalore','karnataka','India'),
(4,10201,45000,'new street','santosh nagar','bangalore','karnataka','India'),
(5,10301,35000,'new street','santosh nagar','bangalore','karnataka','India'),
(6,10401,25000,'new street','santosh nagar','bangalore','karnataka','India');

select * from department;
select * from employee;
select * from empDetails;


alter table employee
add Constraint [UK_employeeID] Unique (ID);

alter table employee
add Constraint [UK_employeeSSN] Unique(SSN);


select FirstName,LastName from employee e
inner join department d on e.dept=d.ID
where d.Name='Marketing';


select sum(salary)as totalSalaryOfMarketing from empDetails e
where e.EmployeeId in (select e.id from employee e
inner join department d on e.dept=d.ID
where d.Name='Marketing');

select Count(*) as EmployeeCount, d.Name from employee e
inner join department d on e.dept=d.ID
group by d.Name;

update empDetails
set salary =90000
from employee e
inner join empDetails ed on e.id=ed.EmployeeId
where e.FirstName like 'Tina';

