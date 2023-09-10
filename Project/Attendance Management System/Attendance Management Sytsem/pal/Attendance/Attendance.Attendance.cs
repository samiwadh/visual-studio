// Attendance
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

public class Attendance
{
	public static string Role = "";
    public static string classreportdate = "";
    public static string classreportsub = "";
    public static string Monthreportdate = "";
    public static string Monthreportsub = "";

    public static SqlConnection GetConnection(string sql)
	{
		SqlConnection sqlConnection = new SqlConnection(sql);
		try
		{
			sqlConnection.Open();
		}
		catch (SqlException ex)
		{
			MessageBox.Show("Error! \n" + ex.ToString(), "SQL connection", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
		return sqlConnection;
	}

	public static string IsValidNamePass(string Username, string Password, string connectionString)
	{
		try
		{
			//string cmdText = ";
			SqlConnection connection = GetConnection(connectionString);
			SqlCommand selectCommand = new SqlCommand("SELECT User_Name, User_Pass, User_Role FROM User_Table WHERE User_Name = @Uname AND User_Pass = @Pass;", connection);
			selectCommand.Parameters.AddWithValue("@Uname", Username);
			selectCommand.Parameters.AddWithValue("@Pass", Password);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
			DataTable dataTable = new DataTable();
			sqlDataAdapter.Fill(dataTable);
			connection.Close();
			if (dataTable.Rows.Count > 0)
			{
				Role = dataTable.Rows[0][2].ToString();
				return Role;
			}
		}
	
		
		catch (SqlException ex)
		{
			MessageBox.Show("Error! \n" + ex.ToString(), "Username and Password", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
		return "";
	}

	public static bool AddRole(string Name, string Password, string Phone, string CNIC, string DOB, string Gender, string Email, string Role, string Address, string connectionString)
	{
		string cmdText = "INSERT INTO User_Table VALUES (@User_Name, @User_Pass, @User_Pho, @User_CNIC, @User_DOB, @User_Gender, @User_Email, @User_Role, @User_Add)";
		SqlConnection connection = GetConnection(connectionString);
		SqlCommand sqlCommand = new SqlCommand(cmdText, connection);
		sqlCommand.CommandType = CommandType.Text;
		sqlCommand.Parameters.Add("@User_Name", SqlDbType.VarChar).Value = Name;
		sqlCommand.Parameters.Add("@User_Pass", SqlDbType.VarChar).Value = Password;
		sqlCommand.Parameters.Add("@User_Pho", SqlDbType.VarChar).Value = Phone;
		sqlCommand.Parameters.Add("@User_CNIC", SqlDbType.VarChar).Value = CNIC;
		sqlCommand.Parameters.Add("@User_DOB", SqlDbType.VarChar).Value = DOB;
		sqlCommand.Parameters.Add("@User_Gender", SqlDbType.VarChar).Value = Gender;
		sqlCommand.Parameters.Add("@User_Email", SqlDbType.VarChar).Value = Email;
		sqlCommand.Parameters.Add("@User_Role", SqlDbType.VarChar).Value = Role;
		sqlCommand.Parameters.Add("@User_Add", SqlDbType.VarChar).Value = Address;
		try
		{
			sqlCommand.ExecuteNonQuery();
			MessageBox.Show("Added successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}
		catch (SqlException ex)
		{
			if (ex.Number == 2627)
			{
				MessageBox.Show("Username or CNIC already exist.", "Username or CNIC", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			else
			{
				MessageBox.Show("Error! \n" + ex.ToString(), "User add", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			return false;
		}
		connection.Close();
		return true;
	}

	public static bool UpdateUser(string ID, string Name, string Password, string Phone, string CNIC, string DOB, string Gender, string Email, string Role, string Address, string connectionString)
	{
		string cmdText = "UPDATE User_Table SET User_Name = @UserName, User_Pass = @UserPass, User_Pho = @UserPho, User_CNIC = @UserCNIC, User_DOB = @UserDOB, User_Gender = @UserGender, User_Email = @UserEmail, User_Role = @UserRole, User_Add = @UserAdd WHERE User_ID = @UserID;";
		SqlConnection connection = GetConnection(connectionString);
		SqlCommand sqlCommand = new SqlCommand(cmdText, connection);
		sqlCommand.CommandType = CommandType.Text;
		sqlCommand.Parameters.Add("@UserID", SqlDbType.Int).Value = ID;
		sqlCommand.Parameters.Add("@UserName", SqlDbType.VarChar).Value = Name;
		sqlCommand.Parameters.Add("@UserPass", SqlDbType.VarChar).Value = Password;
		sqlCommand.Parameters.Add("@UserPho", SqlDbType.VarChar).Value = Phone;
		sqlCommand.Parameters.Add("@UserCNIC", SqlDbType.VarChar).Value = CNIC;
		sqlCommand.Parameters.Add("@UserDOB", SqlDbType.VarChar).Value = DOB;
		sqlCommand.Parameters.Add("@UserGender", SqlDbType.VarChar).Value = Gender;
		sqlCommand.Parameters.Add("@UserEmail", SqlDbType.VarChar).Value = Email;
		sqlCommand.Parameters.Add("@UserRole", SqlDbType.VarChar).Value = Role;
		sqlCommand.Parameters.Add("@UserAdd", SqlDbType.VarChar).Value = Address;
		try
		{
			sqlCommand.ExecuteNonQuery();
			MessageBox.Show("Updated successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}
		catch (SqlException ex)
		{
			if (ex.Number == 2627)
			{
				MessageBox.Show("Username or CNIC already exist.", "Username or CNIC", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			else
			{
				MessageBox.Show("Error! \n" + ex.ToString(), "User update", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			return false;
		}
		connection.Close();
		return true;
	}

	public static bool DeleteUser(string ID, string connectionString)
	{
		string cmdText = "DELETE FROM User_Table WHERE User_ID = @UserID";
		SqlConnection connection = GetConnection(connectionString);
		SqlCommand sqlCommand = new SqlCommand(cmdText, connection);
		sqlCommand.CommandType = CommandType.Text;
		sqlCommand.Parameters.Add("@UserID", SqlDbType.Int).Value = ID;
		try
		{
			sqlCommand.ExecuteNonQuery();
			MessageBox.Show("Deleted successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}
		catch (SqlException ex)
		{
			MessageBox.Show("Error! \n" + ex.ToString(), "User delete", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			return false;
		}
		connection.Close();
		return true;
	}

	public static bool AddClass(string Name, string Total, string sem, string Year, string connectionString)
	{
		string cmdText = "INSERT INTO Class_Table VALUES (@Class_Name, @Class_Total, @Class_sem, @Class_year)";
		SqlConnection connection = GetConnection(connectionString);
		SqlCommand sqlCommand = new SqlCommand(cmdText, connection);
		sqlCommand.CommandType = CommandType.Text;
		sqlCommand.Parameters.Add("@Class_Name", SqlDbType.VarChar).Value = Name;
		sqlCommand.Parameters.Add("@Class_Total", SqlDbType.VarChar).Value = Total;
		sqlCommand.Parameters.Add("@Class_sem", SqlDbType.VarChar).Value = sem;
		sqlCommand.Parameters.Add("@Class_Year", SqlDbType.VarChar).Value = Year;
		try
		{
			sqlCommand.ExecuteNonQuery();
			MessageBox.Show("Added successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}
		catch (SqlException ex)
		{
			MessageBox.Show("Error! \n" + ex.ToString(), "Class add", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			return false;
		}
		connection.Close();
		return true;
	}

	public static void DisplayAndSearchAllData(string query, DataGridView dgv, string connectionString)
	{
		SqlConnection connection = GetConnection(connectionString);
		SqlCommand selectCommand = new SqlCommand(query, connection);
		SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
		DataTable dataTable = new DataTable();
		sqlDataAdapter.Fill(dataTable);
		dgv.DataSource = dataTable;
	}

	public static bool UpdateClass(string ID, string Name, string Total, int semester, int year, string connectionString)
	{
		string cmdText = "UPDATE Class_Table SET Class_Name = @ClassName, Class_Total = @ClassTotal, Class_Semester = @ClassSem, Class_Year = @ClassYear WHERE Class_ID = @ClassID";
		SqlConnection connection = GetConnection(connectionString);
		SqlCommand sqlCommand = new SqlCommand(cmdText, connection);
		sqlCommand.CommandType = CommandType.Text;
		sqlCommand.Parameters.Add("@ClassID", SqlDbType.Int).Value = ID;
		sqlCommand.Parameters.Add("@ClassName", SqlDbType.VarChar).Value = Name;
		sqlCommand.Parameters.Add("@ClassTotal", SqlDbType.VarChar).Value = Total;
		sqlCommand.Parameters.Add("@ClassSem", SqlDbType.VarChar).Value = semester;
		sqlCommand.Parameters.Add("@ClassYear", SqlDbType.VarChar).Value = year;
		try
		{
			sqlCommand.ExecuteNonQuery();
			MessageBox.Show("Updated successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}
		catch (SqlException ex)
		{
			MessageBox.Show("Error! \n" + ex.ToString(), "Class update", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			return false;
		}
		connection.Close();
		return true;
	}

	public static bool DeleteClass(string CID, string connectionString)
	{
		string cmdText = "DELETE FROM Class_Table WHERE Class_ID = @ClassID";
		SqlConnection connection = GetConnection(connectionString);
		SqlCommand sqlCommand = new SqlCommand(cmdText, connection);
		sqlCommand.CommandType = CommandType.Text;
		sqlCommand.Parameters.Add("@ClassID", SqlDbType.Int).Value = CID;
		try
		{
			sqlCommand.ExecuteNonQuery();
			MessageBox.Show("Deleted Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}
		catch (SqlException ex)
		{
			MessageBox.Show("Error! \n" + ex.ToString(), "Class delete", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			return false;
		}
		connection.Close();
		return true;
	}

	public static void FillComboBox(string query, ComboBox cb, string connectionString)
	{
		SqlConnection connection = GetConnection(connectionString);
		SqlCommand sqlCommand = new SqlCommand(query, connection);
		try
		{
			SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
			while (sqlDataReader.Read())
			{
				cb.Items.Add(sqlDataReader[0]);
			}
		}
		catch (SqlException ex)
		{
			MessageBox.Show("Error! \n" + ex.ToString(), "Class not present.", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
		connection.Close();
	}

	public static int GetId(string query, string connectionString)
	{
		SqlConnection connection = GetConnection(connectionString);
		SqlCommand sqlCommand = new SqlCommand(query, connection);
		try
		{
			return Convert.ToInt32(sqlCommand.ExecuteScalar());
		}
		catch (SqlException ex)
		{
			MessageBox.Show("Error! \n" + ex.ToString(), "Class id not find.", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
		connection.Close();
		return 0;
	}

	public static bool AddStudent(string Name, string Reg, string ClassId, string Gender, string connectionString)
	{
		string cmdText = "INSERT INTO Student_Table VALUES (@Student_Name, @Student_Reg, @Student_Gender, @Class_ID)";
		SqlConnection connection = GetConnection(connectionString);
		SqlCommand sqlCommand = new SqlCommand(cmdText, connection);
		sqlCommand.CommandType = CommandType.Text;
		sqlCommand.Parameters.Add("@Student_Name", SqlDbType.VarChar).Value = Name;
		sqlCommand.Parameters.Add("@Student_Reg", SqlDbType.VarChar).Value = Reg;
		sqlCommand.Parameters.Add("@Class_ID", SqlDbType.Int).Value = GetId("SELECT Class_ID FROM Class_Table WHERE Class_Semester = '" + ClassId + "';", connectionString);
		sqlCommand.Parameters.Add("@Student_Gender", SqlDbType.VarChar).Value = Gender;
		try
		{
			sqlCommand.ExecuteNonQuery();
			MessageBox.Show("Added successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}
		catch (SqlException ex)
		{
			MessageBox.Show("Error! \n" + ex.ToString(), "Student add", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			return false;
		}
		connection.Close();
		return true;
	}

	public static bool UpdateStudent(string ID, string Name, string Reg, string ClassName, string Gender, string connectionString)
	{
		string cmdText = "UPDATE Student_Table SET Student_Name = @StudentName, Student_Roll = @StudentRoll, Student_Gender = @StudentGender, Class_ID = @ClassID WHERE Student_ID = @StudentID";
		SqlConnection connection = GetConnection(connectionString);
		SqlCommand sqlCommand = new SqlCommand(cmdText, connection);
		sqlCommand.CommandType = CommandType.Text;
		sqlCommand.Parameters.Add("@StudentID", SqlDbType.Int).Value = ID;
		sqlCommand.Parameters.Add("@StudentName", SqlDbType.VarChar).Value = Name;
		sqlCommand.Parameters.Add("@StudentRoll", SqlDbType.VarChar).Value = Reg;
		sqlCommand.Parameters.Add("@ClassID", SqlDbType.Int).Value = GetId("SELECT Class_ID FROM Class_Table WHERE Class_Name = '" + ClassName + "';", connectionString);
		sqlCommand.Parameters.Add("@StudentGender", SqlDbType.VarChar).Value = Gender;
		try
		{
			sqlCommand.ExecuteNonQuery();
			MessageBox.Show("Updated successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}
		catch (SqlException ex)
		{
			MessageBox.Show("Error! \n" + ex.ToString(), "Student update", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			return false;
		}
		connection.Close();
		return true;
	}

	public static bool DeleteStudent(string SID, string connectionString)
	{
		string cmdText = "DELETE FROM Student_Table WHERE Student_ID = @StudentID";
		SqlConnection connection = GetConnection(connectionString);
		SqlCommand sqlCommand = new SqlCommand(cmdText, connection);
		sqlCommand.CommandType = CommandType.Text;
		sqlCommand.Parameters.Add("@StudentID", SqlDbType.Int).Value = SID;
		try
		{
			sqlCommand.ExecuteNonQuery();
			MessageBox.Show("Deleted Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
		catch (SqlException ex)
		{
			MessageBox.Show("Error! \n" + ex.ToString(), "Student delete", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			return false;
		}
		connection.Close();
		return true;
	}

	public static void MarkAttendance(string SID, string date, string status, string connectionString)
	{
		string cmdText = "INSERT INTO Attendance_Table VALUES (@date, @status, @Id)";
		SqlConnection connection = GetConnection(connectionString);
		SqlCommand sqlCommand = new SqlCommand(cmdText, connection);
		sqlCommand.CommandType = CommandType.Text;
		sqlCommand.Parameters.Add("@date", SqlDbType.VarChar).Value = date;
		sqlCommand.Parameters.Add("@status", SqlDbType.VarChar).Value = status;
		sqlCommand.Parameters.Add("@Id", SqlDbType.Int).Value = SID;
		try
		{
			sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Attendance Uploaded successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
		catch (SqlException ex)
		{
			MessageBox.Show("Error! \n" + ex.ToString(), "Mark Attendance", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
		connection.Close();
	}

	public static bool IsMarkAttendance(string date, string className, string connectionString)
	{
		string cmdText = "SELECT Student_Table.Student_ID, Student_Name, Attendance_Status FROM Student_Table INNER JOIN Attendance_Table ON Student_Table.Student_ID = Attendance_Table.Student_ID INNER JOIN Class_Table ON Class_Table.Class_ID = Student_Table.Class_ID WHERE Attendance_Date = '" + date + "' AND Class_Name = '" + className + "';";
		SqlConnection connection = GetConnection(connectionString);
		SqlCommand selectCommand = new SqlCommand(cmdText, connection);
		SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
		DataTable dataTable = new DataTable();
		try
		{
			sqlDataAdapter.Fill(dataTable);
			connection.Close();
			if (dataTable.Rows.Count > 0)
			{
				return true;
			}
		}
		catch (SqlException ex)
		{
			MessageBox.Show("Error! \n" + ex.ToString(), "Date and Class", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
		return false;
	}

	public static void UpdateAttendance(string SID, string date, string status, string connectionString)
	{
		string cmdText = "UPDATE Attendance_Table SET Attendance_Date = @date, Attendance_Status = @status, Student_ID = @SID WHERE Student_ID = @SID AND Attendance_Date = @date";
		SqlConnection connection = GetConnection(connectionString);
		SqlCommand sqlCommand = new SqlCommand(cmdText, connection);
		sqlCommand.CommandType = CommandType.Text;
		sqlCommand.Parameters.Add("@SID", SqlDbType.Int).Value = SID;
		sqlCommand.Parameters.Add("@status", SqlDbType.VarChar).Value = status;
		sqlCommand.Parameters.Add("@date", SqlDbType.VarChar).Value = date;
		try
		{
			sqlCommand.ExecuteNonQuery();
		}
		catch (SqlException ex)
		{
			MessageBox.Show("Error! \n" + ex.ToString(), "Attendance update", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
		connection.Close();
	}

	public static int Count(string query, string connectionString)
	{
		int result = 0;
		SqlConnection connection = GetConnection(connectionString);
		SqlCommand sqlCommand = new SqlCommand(query, connection);
		try
		{
			result = (int)sqlCommand.ExecuteScalar();
			return result;
		}
		catch (SqlException)
		{
		}
		connection.Close();
		return result;
	}

	public static string GetUsernamePassword(string query, string connectionString)
	{
		SqlConnection connection = GetConnection(connectionString);
		SqlCommand sqlCommand = new SqlCommand(query, connection);
		try
		{
			return sqlCommand.ExecuteScalar().ToString();
		}
		catch (SqlException ex)
		{
			MessageBox.Show("Error! \n" + ex.ToString(), "Username and password", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
		connection.Close();
		return "0";
	}
}
