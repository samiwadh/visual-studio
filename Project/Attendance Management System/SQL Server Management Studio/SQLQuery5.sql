USE Attendance_management_system;
CREATE TABLE Attendance_Table
(
	Attendance_ID int IDENTITY(1,1),
	Attendance_Date VARCHAR(10),
	Attendance_Status VARCHAR(10) DEFAULT 'Absent',
	Student_ID INT ,
	CONSTRAINT Attendance_Table_PK PRIMARY KEY (Attendance_ID),
	CONSTRAINT Attendance_Table_FK FOREIGN KEY (Student_ID) REFERENCES Student_Table (Student_ID) ON DELETE CASCADE 
);
