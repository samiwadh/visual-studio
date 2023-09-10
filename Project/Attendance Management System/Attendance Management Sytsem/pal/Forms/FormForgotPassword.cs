using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_management_system.pal.Forms
{
    public partial class FormForgotPassword : Form
    {
        private string sql = @"Data Source=DESKTOP-G9JJ980;Initial Catalog=Attendance_MGS;User ID=sa;Password=sql;";
        public FormForgotPassword()
        {
            InitializeComponent();
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBoxClose_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxClose, "Close");
        }

        private void textBoxEmail_Enter(object sender, EventArgs e)
        {
            if(textBoxEmail.Text.Trim() == "johndoe@email.com")
            {
                textBoxEmail.Clear();
                textBoxEmail.ForeColor = Color.Black;
            }

            if (!IsValidEmail(textBoxEmail.Text.Trim()) || textBoxEmail.Text.Trim() == "johndoe@email.com")
                pictureBoxError.Show();
            else
                pictureBoxError.Hide();
        }

        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
            if(textBoxEmail.Text.Trim() == string.Empty)
            {
                textBoxEmail.Text = "johndoe@email.com";
                textBoxEmail.ForeColor = Color.DarkGray;
            }

            if (!IsValidEmail(textBoxEmail.Text.Trim()) || textBoxEmail.Text.Trim() == "johndoe@email.com")
                pictureBoxError.Show();
            else
                pictureBoxError.Hide();
        }

        private void pictureBoxError_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxError, "invalid Email");
        }

        private void buttonVerify_Click(object sender, EventArgs e)
        {
            if (IsValidEmail(textBoxEmail.Text.Trim()))
            {
                string userName = Attendance.GetUsernamePassword("SELECT User_Name From user_table WHERE User_Email = '" + textBoxEmail.Text.Trim() + "';", sql);
                string Password = Attendance.GetUsernamePassword("SELECT User_Pass From user_table WHERE User_Email = '" + textBoxEmail.Text.Trim() + "';", sql);
                MessageBox.Show("your username is " + userName + " and your password is " + Password + ".", "infomatiom", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //pictureBoxClose.Hide();
        }
    }
}
