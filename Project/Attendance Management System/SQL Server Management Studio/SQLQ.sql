CREATE DATABASE Attendance_Management_System

CREATE TABLE User_Table

(
	User_Id int identity(1,1),
	User_Name varchar(50)Unique,
	User_Pass varchar(50),
	User_Pho varchar(50),
	User_CNIC varchar(15) Unique,
	User_DOB varchar(10),
	User_Gender varchar(6),
	User_Email varchar(50),
	User_Role varchar(5),
	User_Add varchar(150),
	Constraint User_Table_pk Primary key (User_id)
);

insert into values("samiwadho","Abdul Sami","12345","23233-2323233-2","09/14/2022","Male","samiwadho")