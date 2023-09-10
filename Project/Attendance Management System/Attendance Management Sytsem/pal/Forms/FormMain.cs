using Attendance_management_system.pal.UserControlForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_management_system.pal.Forms
{
    public partial class FormMain : Form
    {
        public string Username, Role;

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you want to Logout?", "log out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                formLogin.Check = "";
                timerDateAndTime.Stop();
                Close();
            }
            else
                panelExpand.Hide();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            int width = Screen.PrimaryScreen.Bounds.Width;
            int heignt = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(width, heignt);

            panelExpand.Hide();
            labelUsername.Text = Username;
            labelRole.Text = Role;
            userControlreport1.Visible = false;

            if (Role == "User")
            {
                buttonDash.Hide();
                buttonAddStud.Hide();
                buttonAddClass.Hide();
                buttonReg.Hide();
            }
        }

        private void buttonMin_Click(object sender, EventArgs e)
        {
            panelExpand.Hide();
            WindowState = FormWindowState.Minimized;
        }

        private void timerDateAndTime_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            labelTime.Text = now.ToString("F");
        }

        public FormMain()
        {
            InitializeComponent();
            timerDateAndTime.Start();
        }

        private void buttonDash_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonDash);

            userControlDashboard1.Count();
            userControlDashboard1.Visible = true;
            userControlAddClass1.Visible = false;
            userControlAddStudents1.Visible = false;
            userControlRegister1.Visible = false;
            userControlDashboard1.Count();
            userControlDashboard1.Visible = true;
            userControlreport1.Visible = false;
            userControlAttendance1.Visible = false;
        }

        private void buttonAttendance_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonAttendance);
            userControlAddClass1.Visible = false;
            userControlRegister1.Visible = false;
            userControlAddStudents1.Visible = false;
            userControlDashboard1.Visible = false;
            userControlAttendance1.Visible = true;
            userControlreport1.Visible = false;


        }

        private void buttonAddClass_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonAddClass);
            userControlAddClass1.CLearTextBox();
            userControlAttendance1.Visible = false;
            userControlAddClass1.Visible = true;
            userControlRegister1.Visible = false;
            userControlAddStudents1.Visible = false;
            userControlDashboard1.Visible = false;
            userControlreport1.Visible = false;

        }

        private void buttonAddStud_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonAddStud);
            userControlAddClass1.Visible = false;
            userControlAttendance1.Visible = false;
            userControlRegister1.Visible = false;
            userControlAddStudents1.Visible = true;
            userControlDashboard1.Visible = false;
            userControlAddStudents1.CLearTextBox();
            userControlreport1.Visible = false;

        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonReport);
            userControlAddClass1.Visible = false;
            userControlRegister1.Visible = false;
            userControlAttendance1.Visible = false;
            userControlAddStudents1.Visible = false;
            userControlDashboard1.Visible = false;
            userControlreport1.Visible = true;

        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonReg);
            userControlAddClass1.Visible = false;
            userControlAddStudents1.Visible = false;
            userControlDashboard1.Visible = false;
            userControlAttendance1.Visible = false;
            userControlRegister1.HideErrorPic();
            userControlRegister1.ClearTextBox();
            userControlRegister1.Visible = true;
            userControlreport1.Visible = false;




        }

        private void pictureBoxExpand_Click(object sender, EventArgs e)
        {
            if (panelExpand.Visible)
                panelExpand.Visible = false;
            else
                panelExpand.Visible = true;
        }

        private void userControlRegister1_Load(object sender, EventArgs e)
        {

        }

        private void userControlreport1_Load(object sender, EventArgs e)
        {

        }

        private void MoveSidePanel(Control button)
        {
            panelSide.Location = new Point(button.Location.X - button.Location.X, button.Location.Y - 180);
        }
    }
}
