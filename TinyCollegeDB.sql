USE master;

 

IF DB_ID(N'TinyCollegeDB') IS NOT NULL DROP DATABASE TinyCollegeDB;

CREATE DATABASE TinyCollegeDB;

GO

 

USE TinyCollegeDB;

GO

CREATE TABLE Instructor
(
           InstructorId		int				not null IDENTITY,
           FirstName		NVARCHAR(20)	not null,
           LastName			NVARCHAR(20)	not null,
           CONSTRAINT pk_Instructor PRIMARY KEY (InstructorId)
);

CREATE TABLE Student
(
           StudentId		int				not null IDENTITY,
           FirstName		NVARCHAR(20)	not null,
           LastName			NVARCHAR(20)	not null,
           CONSTRAINT pk_Student PRIMARY KEY (StudentId)
);

CREATE TABLE Course
(
           CourseId			nvarchar(15)	not null, --should this be identity and should this be a string
           CourseName		NVARCHAR(100)	not null,
           SeatAvailable	int				not null,
		   InstructorId		int				not	null
           CONSTRAINT pk_Course PRIMARY KEY (CourseId)
		   CONSTRAINT fk_Course_Instructor FOREIGN KEY (InstructorId) REFERENCES Instructor(InstructorId)
);

CREATE TABLE Enrollment
(
           StudentId		int				not null,
		   CourseId			nvarchar(15)	not	null,
		   Grade			decimal(3,2)	not null --should this be null?? can a student have no grade
		   CONSTRAINT fk_Enrollment_Student FOREIGN KEY (StudentId) REFERENCES Student(StudentId),
		   CONSTRAINT fk_Enrollment_Course FOREIGN KEY (CourseId) REFERENCES Course(CourseID)
);

insert into Instructor(FirstName, LastName)
	values('Josh', 'Morrison');
insert into Student(FirstName, LastName)
	values('Cole', 'Hargis');
insert into Course(CourseId, CourseName, SeatAvailable, InstructorId)
	values('CISS176', 'Intro to Comp Science', 25, 1);
insert into Enrollment(StudentId, CourseId, Grade)
	values(1, 'CISS176', 3.8);


select * from Instructor;
select * from Student;
select * from Course;
select * from Enrollment;