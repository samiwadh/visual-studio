using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Attendance_management_system.pal.UserControlForms
{
    public partial class UserControlDashboard : UserControl
    {
        private string sql = @"Data Source=DESKTOP-G9JJ980;Initial Catalog=Attendance_MGS;User ID=sa;Password=sql";



        public UserControlDashboard()
        {
            InitializeComponent();
        }

        public void Count()
        {
            labelTotalClasses.Text = Attendance.Count("Select COUNT(*) FROM Class_Table;", sql).ToString();
            labelTotalStudents.Text = Attendance.Count("Select COUNT(*) FROM Student_Table;", sql).ToString();
            labelTotalRole.Text = Attendance.Count("Select COUNT(*) FROM User_Table;", sql).ToString();


        }

        private void UserControlDashboard_Load(object sender, EventArgs e)
        {

        }

        private void labelTotalClasses_Click(object sender, EventArgs e)
        {

        }
    }
}
