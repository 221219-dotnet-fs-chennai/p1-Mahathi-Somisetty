create database coding

use coding

drop table Department

CREATE TABLE Department(
id int IDENTITY(1,1) PRIMARY KEY,
[Name] varchar(20),
[Location] VARCHAR(20)
);




CREATE TABLE Employe(
    id int IDENTITY(1,1) PRIMARY KEY,
    firstName varchar(20) not null,
    lastName VARCHAR(20),
    SSN int,
    deptId int,
    FOREIGN key (deptId) REFERENCES Department(id)
);




CREATE TABLE empDetails(
  id int IDENTITY(1,1) PRIMARY KEY,
  employeeId int,
  salary int not null,
  address1 VARCHAR(50) not null,
  address2 VARCHAR(50),
  city VARCHAR(30),
  state VARCHAR(30),
  country VARCHAR(30),
  FOREIGN key (employeeId) REFERENCES Employe(id)
);



SELECT * from Department

select * from Employe

select*from empDetails

INSERT INTO empDetails(employeeId,salary,address1,address2,city,state,country)
values
(1,2000,'101,chittoor',null,'chittoor','Andhra Pradesh','India'),
(2,3000,'10-11,putur',null,'putur','Andhra Pradesh','India'),
(3,2500,'11-10,tirupati','11-10,checkpost,tirupati','tirpupati','Andhra pradesh','inida')

insert into  Department(name,location)
values ('IT','chittoor'),('HR','puthur'),('Managemet','tirupathi')

insert into Employe(firstName,lastName,SSN,deptId)
VALUES ('Ram','setty',65432,6)
select * from Department
-- updatig the values to check
UPDATE Department
SET name = 'marketing'
where id = 4

-- Inserting teena into employe 
insert into Employe(firstName,lastName,SSN,deptId)
values('teena','smith',654323,2)

-- marketing

insert into Department(name, location)
VALUES('Marketing','Chennai')

--employe inot marketing

insert into empDetails(employeeId,salary ,address1 , address2,city,state,country)
values(4,3750,'202Cittoor',null,'chittoor','andhrapradesh','India')

-- total salary of maketing

select sum(salary) as totalSalary from Employe
JOIN empDetails on Employe.id = empDetails.employeeId where name like 'marketing'

----list of employe in marketing


SELECT firstName,lastName, name from Employe
join Department on department.id = Employe.deptid where name like 'marketing'

-- employes by group
SELECT NAME,COUNT(*) from Department
join Employe on department.id = Employe.deptId 
group by name

-- teena salary to 90000$
update empDetails
set salary = 90000
where  employeeId = 4  
