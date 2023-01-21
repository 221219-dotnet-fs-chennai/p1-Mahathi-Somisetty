create database trainee
create table TraineeDetails(
TraineeId int IDENTITY(1,1),
FullName varchar(50),
EmailId varchar(50) not null,
Gender varchar(10),
Age int not null, 
PhoneNumber varchar(10), PRIMARY KEY([TraineeId])
);
select * from TraineeDetails;

CREATE TABLE [Skills](
    [Skill_id] int IDENTITY(1,1),
    [Skill_name] VARCHAR(20),
    [Skill_Type] VARCHAR(20),
    [Expertise] VARCHAR(20),
    CONSTRAINT [Fk_skill] FOREIGN KEY(Skill_id) REFERENCES TraineeDetails(TraineeId),
    CONSTRAINT [Pk_skill] PRIMARY KEY([Skill_id]) 
);
select * from Skills;

CREATE TABLE [CompanyDetails](
    [Id] int IDENTITY(1,1),
    [Company_name] VARCHAR(30),
    [ProjectName] VARCHAR(30),
	[Position] Varchar(30),
    [Experience] VARCHAR(20),
    constraint [pk_company] PRIMARY KEY([Id]),
    CONSTRAINT [Fk_company] FOREIGN KEY([Id]) REFERENCES TraineeDetails(TraineeId)
);
select *from CompanyDetails;
CREATE TABLE [EducationalDetails](
    [EducationId] int IDENTITY(1,1),
    [HQualification] VARCHAR(30),
    [YearOfPassing] VARCHAR(50),
    [Stream] VARCHAR(25),
    CONSTRAINT [pk_education] PRIMARY KEY([Educationid]),
    CONSTRAINT [Fk_education] FOREIGN KEY([Educationid]) REFERENCES TraineeDetails(Traineeid)
);
Select *from EducationalDetails;
