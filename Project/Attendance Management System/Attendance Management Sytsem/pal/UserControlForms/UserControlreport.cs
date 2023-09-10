using Attendance_management_system.pal.Forms;
using Attendance_management_system.pal.Reports;
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

namespace Attendance_management_system.pal.UserControlForms
{
   
    public partial class UserControlreport : UserControl
    {
        
        string sql = @"Data Source=DESKTOP-G9JJ980;Initial Catalog=Attendance_MGS;User ID=sa;Password=sql";
        ReportDocument cryrpy = new ReportDocument();
        SqlConnection cs = new SqlConnection(@"Data Source = . \SQLEXPRESS;
                           Initial Catalog = Attendance_management_system;
                            Integrated Security = True;");
       public  ReportDocument cryrpt;
        public UserControlreport()
        {
            InitializeComponent();
        }
        public void FirstTab()
        {
            tabControlReport.SelectedTab = tabPageClassReport;
        }
       

       
        private void tabPageMarkAttendance_Click(object sender, EventArgs e)
        {

        }

        private void tabPageStudentReport_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel16_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxPrint_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxprint, "Print");
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxprint1, "Print");
        }

        private void comboBoxClass_Click(object sender, EventArgs e)
        {
            comboBoxClass.Items.Clear();
            Attendance.FillComboBox("Select Distinct(Class_Name) From Class_Table", comboBoxClass, sql);
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            comboBoxClass.Items.Clear();
            Attendance.FillComboBox("Select Distinct(Class_Name) From Class_Table", comboBoxClass1, sql);
        }

     

        private void comboBoxClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxClass.SelectedIndex != -1)
            {
               Attendance.DisplayAndSearchAllData("SELECT Student_Name,Student_Roll,Class_Name,Attendance_Date,Attendance_Status from Student_Table INNER JOIN Attendance_Table ON Student_Table.Student_ID=Attendance_Table.Student_ID INNER JOIN Class_Table ON Class_Table.Class_ID=Student_Table.Class_ID WHERE Attendance_Date LIKE '" + dateTimePickerDate.Text+"%' AND Class_Name = '"+comboBoxClass.SelectedItem.ToString()+"'; ",dataGridViewClassReport,sql);
                Attendance.classreportsub = comboBoxClass.SelectedItem.ToString();
              
            }
        }

      

        private void comboBoxClass1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxClass1.SelectedIndex != -1)
            {
                Attendance.DisplayAndSearchAllData("SELECT Student_Name,Student_Roll,Class_Name,Attendance_Date,Attendance_Status from Student_Table INNER JOIN Attendance_Table ON Student_Table.Student_ID=Attendance_Table.Student_ID INNER JOIN Class_Table ON Class_Table.Class_ID=Student_Table.Class_ID WHERE Attendance_Date LIKE '" + dateTimePickerDate2.Text + "%'; ", dataGridViewStudentReport, sql);
                Attendance.Monthreportsub = comboBoxClass1.SelectedItem.ToString();
            }
        }

        private void pictureBoxprint_Click(object sender, EventArgs e)
        {
            if (Attendance.classreportdate != "" && Attendance.classreportsub != "")
            {
                ClassReports cre = new ClassReports();
                cre.Show();
            }
            else
            {
                MessageBox.Show("Please Select Date and Class First");
            }


            //SqlCommand cmd = new SqlCommand(query, cs);
            //ClassReport cr = new ClassReport();
            //cr.SetDataSource(ds);
        }

        private void pictureBoxprint1_Click(object sender, EventArgs e)
        {
            if (Attendance.Monthreportdate != "" && Attendance.Monthreportsub != "")
            {
                MonthlyReport str = new MonthlyReport();
                str.Show();
            }
            else
            {
                MessageBox.Show("Please Select Month and Class First");
            }
            //cs.Open();
            //string query = "Select s.Student_Name,s.Student_Roll,c.Class_Name, a.Attendance_Date,a.Attendance_Status  from Student_Table s INNER JOIN Attendance_Table a ON s.Student_ID=a.Student_ID INNER JOIN Class_Table c ON c.Class_ID=s.Class_ID WHERE a.Attendance_Date LIKE '%" + dateTimePickerDate2.Text + "%' AND s.Student_Roll LIKE '%" + comboBoxRegNo.SelectedItem.ToString() + "%';";


            //SqlDataAdapter adpt = new SqlDataAdapter(query, cs);
            //DataSet ds = new DataSet();
            //adpt.Fill(ds, "Attendance");

            //cryrpt.Load("StudentReportview.rpt");
            //cryrpt.SetDataSource(ds);


        }

        private void dateTimePickerDate_ValueChanged(object sender, EventArgs e)
        {
            Attendance.classreportdate = dateTimePickerDate.Text;
           
        }

        private void dateTimePickerDate2_ValueChanged(object sender, EventArgs e)
        {
            Attendance.Monthreportdate = dateTimePickerDate2.Text;
           
        }
    }
}
