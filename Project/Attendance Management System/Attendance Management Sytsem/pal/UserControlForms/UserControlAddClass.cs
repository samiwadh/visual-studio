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
    public partial class UserControlAddClass : UserControl
    {
        private string sql = @"Data Source=DESKTOP-G9JJ980;Initial Catalog=Attendance_MGS;User ID=sa;Password=sql";

        private string CID = "";

        public UserControlAddClass()
        {
            InitializeComponent();
        }

        private void IntegarType(KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        public void CLearTextBox()
        {
            textBoxName.Clear();
            textBoxHmStudents.Clear();
            textBoxSemester.Clear();
            textBoxYear.Clear();
            tabControlAddClass.SelectedTab = tabPageAddClass;
        }

        private void CLearTextBox1()
        {
            textBoxName1.Clear();
            textBoxHmStudents1.Clear();
            textBoxSemester1.Clear();
            textBoxYear1.Clear();
            CID = "";
        }

        private void tabPageUpdateAndDelete_Leave(object sender, EventArgs e)
        {
            CLearTextBox1();
        }

        private void tabPageSearchClass_Enter(object sender, EventArgs e)
        {
            textBoxSearch.Clear();
            Attendance.DisplayAndSearchAllData("SELECT * FROM Class_Table;", dataGridViewClass, sql);
            dataGridViewClass.Columns[0].Visible = false;
            labelCount.Text = dataGridViewClass.Rows.Count.ToString();
        }

        private void tabPageAddClass_Enter(object sender, EventArgs e)
        {
            CLearTextBox1();
        }

        private void tabPageAddClass_Leave(object sender, EventArgs e)
        {
            CLearTextBox();
        }

        private void textBoxHmStudents_KeyPress(object sender, KeyPressEventArgs e)
        {
            IntegarType(e);
        }

        private void textBoxSemester_KeyPress(object sender, KeyPressEventArgs e)
        {
            IntegarType(e);
        }

        private void textBoxYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            IntegarType(e);
        }

        private void textBoxHmStudents1_KeyPress(object sender, KeyPressEventArgs e)
        {
            IntegarType(e);
        }

        private void textBoxSemester1_KeyPress(object sender, KeyPressEventArgs e)
        {
            IntegarType(e);
        }

        private void textBoxYear1_KeyPress(object sender, KeyPressEventArgs e)
        {
            IntegarType(e);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if(textBoxName.Text.Trim() == string.Empty || textBoxHmStudents.Text.Trim() == string.Empty || textBoxSemester.Text.Trim() == string.Empty || textBoxYear.Text.Trim() == string.Empty)
            {
                MessageBox.Show("First fill out all fields", "Required all fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                bool check = Attendance.AddClass(textBoxName.Text.Trim(), textBoxHmStudents.Text.Trim(), textBoxSemester.Text.Trim(), textBoxYear.Text.Trim(), sql);

                if (check)
                    CLearTextBox();
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            Attendance.DisplayAndSearchAllData("SELECT * FROM Class_Table WHERE Class_Name LIKE '%" + textBoxSearch.Text + "%';",dataGridViewClass, sql);
        }

        private void dataGridViewClass_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridViewClass.Rows[e.RowIndex];
                CID = row.Cells[0].Value.ToString();
                textBoxName1.Text = row.Cells[1].Value.ToString();
                textBoxHmStudents1.Text = row.Cells[2].Value.ToString();
                textBoxSemester1.Text = row.Cells[3].Value.ToString();
                textBoxYear1.Text = row.Cells[4].Value.ToString();
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (CID != "")
            {
                if (textBoxName1.Text.Trim() == string.Empty || textBoxHmStudents1.Text.Trim() == string.Empty || textBoxSemester1.Text.Trim() == string.Empty || textBoxYear1.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("First fill out all fields", "Required all fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    int sem = Convert.ToInt16( textBoxSemester1.Text.Trim());
                    int year = Convert.ToInt16(textBoxYear1.Text.Trim());
                    bool check = Attendance.UpdateClass(CID,textBoxName1.Text.Trim(), textBoxHmStudents1.Text.Trim(), sem,year , sql);

                    if (check)
                        CLearTextBox1();
                }
            }
            else
                MessageBox.Show("First select row from table", "select row", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (CID != "")
            {
                if (textBoxName1.Text.Trim() == string.Empty || textBoxHmStudents1.Text.Trim() == string.Empty || textBoxSemester1.Text.Trim() == string.Empty || textBoxYear1.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("First fill out all fields", "Required all fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Do you want to delete this class?", "delete class", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(dialogResult == DialogResult.Yes)
                    {
                        bool check = Attendance.DeleteClass(CID, sql);

                        if (check)
                            CLearTextBox1();
                    }
                }
            }
            else
                MessageBox.Show("First select row from table", "select row", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBoxYear_Enter(object sender, EventArgs e)
        {

        }

        private void tabControlAddClass_Enter(object sender, EventArgs e)
        {

        }
    }
}
