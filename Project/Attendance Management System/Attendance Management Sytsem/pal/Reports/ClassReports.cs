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
using System.Xml.Xsl;

namespace Attendance_management_system.pal.Reports
{
    public partial class ClassReports : Form
    {
        ReportDocument cryrpt = new ReportDocument();
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-G9JJ980;Initial Catalog=Attendance_MGS;User ID=sa;Password=sql");
        public ClassReports()
        {
            InitializeComponent();
        }

        private void ClassReports_Load(object sender, EventArgs e)
        {
            conn.Open();
            string query = "Select s.Student_ID,s.Student_Name,s.Student_Roll,c.Class_Name,c.Class_Semester,c.Class_Total,c.Class_Year, a.Attendance_Date,a.Attendance_Status  from Student_Table s INNER JOIN Attendance_Table a ON s.Student_ID=a.Student_ID INNER JOIN Class_Table c ON c.Class_ID=s.Class_ID where a.Attendance_Date='"+Attendance.classreportdate+"' AND c.Class_Name='" + Attendance.classreportsub +"';";


            SqlDataAdapter adpt = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            adpt.Fill(ds, "MyDataTable");

            cryrpt.Load("E:\\rameez\\Attendance management system\\Attendance management system\\pal\\Reports\\ClassReportview.rpt");
            cryrpt.SetDataSource(ds);
            crystalReportViewer1.ReportSource = cryrpt;
            crystalReportViewer1.Refresh();


        }
    }
}
