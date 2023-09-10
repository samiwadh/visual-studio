using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_management_system.pal.Forms
{
    public partial class formLogin : Form
    {
        public static string Check;
        private string sql = @"Data Source=DESKTOP-G9JJ980;Initial Catalog=Attendance_MGS;User ID=sa;Password=sql;";
        public formLogin()
        {
            InitializeComponent();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBoxMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBoxShow_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(pictureBoxShow, "Show Password");
        }

        private void pictureBoxHide_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(pictureBoxHide, "Hide Password");
        }

        private void pictureBoxShow_Click(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = false;
            pictureBoxShow.Hide();
            pictureBoxHide.Show();
        }

        private void pictureBoxHide_Click(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = true;
            pictureBoxHide.Hide();
            pictureBoxShow.Show();
        }

        private void formLogin_Load(object sender, EventArgs e)
        {
            int width= Screen.PrimaryScreen.Bounds.Width;
            int heignt= Screen.PrimaryScreen.Bounds.Height;
            this.Location= new Point(0, 0);
            this.Size = new Size(width, heignt);

            pictureBoxHide.Hide();
            pictureBoxError.Hide();
            labelError.Hide();
        }

        private void pictureBoxClose_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(pictureBoxClose, "Close");
        }

        private void pictureBoxMin_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(pictureBoxMin, "Minimize");
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            
             Check = Attendance.IsValidNamePass(textBoxName.Text, textBoxPassword.Text, sql);
            if(textBoxName.Text != string.Empty && textBoxPassword.Text != string.Empty)
            {
                if(Check != "")
                {
                    FormMain formMain = new FormMain();
                    formMain.Username = textBoxName.Text;
                    formMain.Role = Check;
                    textBoxName.Clear();
                    textBoxPassword.Clear();
                    pictureBoxHide_Click(sender, e);
                    textBoxName.Focus();
                    pictureBoxError.Hide();
                    labelError.Hide();
                    formMain.Show();
                   
                        
                }
                else
                {
                    pictureBoxError.Show();
                    labelError.Show();
                }
                
            }
           
        }

        private void textBoxName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                e.SuppressKeyPress = true;
        }

        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                SelectNextControl(ActiveControl, true, true, true, true);
                e.Handled = true;
            }
        }

        private void textBoxPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                e.SuppressKeyPress = true;
        }

        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                buttonLogin.PerformClick();
                e.Handled = true;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            FormForgotPassword formForgotPassword = new FormForgotPassword();
            formForgotPassword.ShowDialog();
        }

        private void pictureBoxShow_Click_1(object sender, EventArgs e)
        {

        }
    }
}
