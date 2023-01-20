create database trainee
create table TraineeDetails(
TraineeId int Not null,
FullName varchar(50),
EmailId varchar(50) not null,
Gender varchar(10),
Age int not null, 
PhoneNumber varchar(10), PRIMARY KEY([TraineeId])
);
CREATE table Companydeatails(
CompanyId int not null,
CompanyName varchar(30),
ProjectName varchar(40),
Position Varchar(30),
Experience int not null,
CId int,
PRIMARY KEY([CompanyId]),
CONSTRAINT[FK_Company.CId]
FOREIGN KEY([CId])
REFERENCES[TraineeDetails]([TraineeId])
);
Go

CREATE TABLE EducationalDetails(
EducationId int not null,
HQualification varchar(50),
YearOfPassing date,
[Percentage] float not null,
[Stream] varchar(70),
UG varchar(50),
CONSTRAINT[FK_EducationalDetails.EducationId]
FOREIGN KEY([EducationId])
REFERENCES [TraineeDetails]([TraineeId])
);

Go

CREATE TABLE Skills(
SkillID int not null,
TechnologiesKnown varchar(70),
ExpertiseInTechnology Varchar(50),
[SID] int,
PRIMARY KEY([SkillId]),
CONSTRAINT[FK_Skills.skillId]
FOREIGN KEY([SID])
REFERENCES[TraineeDetails](TraineeId)
);
SELECT * FROM TraineeDetails
SELECT * FROM Companydeatails
SELECT * FROM EducationalDetails
SELECT * FROM Skills