using Attendance_management_system.pal.UserControlForms;
using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Attendance_management_system.pal.Reports
{
    public partial class MonthlyReport : Form
    {
        ReportDocument cryrpy = new ReportDocument();
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-G9JJ980;Initial Catalog=Attendance_MGS;Persist Security Info=True;User ID=sa;Password=sql");
        public MonthlyReport()
        {
            InitializeComponent();
        }

        private void StudentReport_Load(object sender, EventArgs e)
        {
            con.Open();
            string query1 = "Select s.Student_ID,s.Student_Name,s.Student_Roll,c.Class_Name,c.Class_Semester,c.Class_Total,c.Class_Year,COUNT(DISTINCT(a.Attendance_Date)) AS 'Classes Attended' from Student_Table s INNER JOIN Attendance_Table a ON s.Student_ID=a.Student_ID INNER JOIN Class_Table c ON c.Class_ID=s.Class_ID where a.Attendance_Status='Present' AND a.Attendance_Date LIKE '%"+Attendance.Monthreportdate+"%' AND c.Class_Name='"+Attendance.Monthreportsub+"' Group BY s.Student_ID,s.Student_Name,s.Student_Roll,c.Class_Name,c.Class_Semester,c.Class_Total,c.Class_Year;";


            SqlDataAdapter adpt = new SqlDataAdapter(query1, con);
            DataSet ds = new DataSet();
            adpt.Fill(ds, "MyMonthlyTable");

            cryrpy.Load("E:\\rameez\\Attendance management system\\Attendance management system\\pal\\Reports\\MonthlyReportview.rpt");
            cryrpy.SetDataSource(ds);
            crystalReportViewer2.ReportSource = cryrpy;
            crystalReportViewer2.Refresh();
            
        }
    }
}
