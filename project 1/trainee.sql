create database trainee
create table TraineeDetails(
TraineeId int IDENTITY(1,1),
FullName varchar(50),
EmailId varchar(50) not null,
Gender varchar(10),
Age int not null, 
PhoneNumber varchar(10), PRIMARY KEY([TraineeId])
);
alter table TraineeDetails add [Password] varchar(15);

CREATE TABLE Skills(
    [TraineeId] int IDENTITY(1,1),
    [Skill_name] VARCHAR(20),
    [Skill_Type] VARCHAR(20),
    [Expertise] VARCHAR(20),
    CONSTRAINT [Fk_skill] FOREIGN KEY(TraineeId) REFERENCES TraineeDetails(TraineeId),
    CONSTRAINT [Pk_skill] PRIMARY KEY([TraineeId]) 
);


CREATE TABLE [CompanyDetails](
    [TraineeId] int IDENTITY(1,1),
    [Company_name] VARCHAR(30),
    [ProjectName] VARCHAR(30),
	[Position] Varchar(30),
    [Experience] VARCHAR(20),
    constraint [pk_company] PRIMARY KEY([TraineeId]),
    CONSTRAINT [Fk_company] FOREIGN KEY([TraineeId]) REFERENCES TraineeDetails(TraineeId)
);

CREATE TABLE [EducationalDetails](
    [TraineeId] int IDENTITY(1,1),
    [HQualification] VARCHAR(30),
    [YearOfPassing] VARCHAR(50),
    [Stream] VARCHAR(25),
    CONSTRAINT [pk_education] PRIMARY KEY([TraineeId]),
    CONSTRAINT [Fk_education] FOREIGN KEY([TraineeId]) REFERENCES TraineeDetails(Traineeid)
);
alter table EducationalDetails add [Percentage] varchar(15);


select * from TraineeDetails;
Select *from EducationalDetails;
select *from CompanyDetails;


select * from Skills;
