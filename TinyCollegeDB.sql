USE master;

 

IF DB_ID(N'TinyCollegeDB') IS NOT NULL DROP DATABASE TinyCollegeDB;

CREATE DATABASE TinyCollegeDB;

GO

 

USE TinyCollegeDB;

GO



CREATE TABLE Instructor
(
           InstructorId		NVARCHAR(10)	not null,
           FirstName		NVARCHAR(20)	not null,
           LastName			NVARCHAR(20)	not null,
           CONSTRAINT pk_Instructor PRIMARY KEY (InstructorId)
);

CREATE TABLE Student
(
           StudentId		NVARCHAR(10)		not null,
           FirstName		NVARCHAR(20)	not null,
           LastName			NVARCHAR(20)	not null,
           CONSTRAINT pk_Student PRIMARY KEY (StudentId)
);

CREATE TABLE Course
(
           CourseId			nvarchar(6)		not null, 
           CourseName		NVARCHAR(100)	not null,
           SeatAvailable	int				not null,
		   Active			bit			not null,
		   InstructorId		NVARCHAR(10)	not	null,
           CONSTRAINT pk_Course PRIMARY KEY (CourseId),
		   CONSTRAINT fk_Course_Instructor FOREIGN KEY (InstructorId) REFERENCES Instructor(InstructorId)
);

CREATE TABLE Enrollment
(
           StudentId		nvarchar(10)		not null,
		   CourseId			nvarchar(6)			not	null,
		   Grade			decimal(3,2)		null,
		   CONSTRAINT fk_Enrollment_Student FOREIGN KEY (StudentId) REFERENCES Student(StudentId),
		   CONSTRAINT fk_Enrollment_Course FOREIGN KEY (CourseId) REFERENCES Course(CourseID)
);

