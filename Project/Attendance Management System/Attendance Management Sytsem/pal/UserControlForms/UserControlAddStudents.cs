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
    public partial class UserControlAddStudents : UserControl
    {
        private string sql = @"Data Source=DESKTOP-G9JJ980;Initial Catalog=Attendance_MGS;User ID=sa;Password=sql";

        private string SID = "", gender = "";

        public UserControlAddStudents()
        {
            InitializeComponent();
        }


        public void CLearTextBox()
        {
            textBoxName.Clear();
            textBoxRollNum.Clear();
            comboBoxSemester.SelectedIndex = -1;
            radioButtonMale.Checked = false;
            radioButtonFemale.Checked = false;
            tabControlAddStudent.SelectedTab = tabPageAddStudent;
        }

        private void CLearTextBox1()
        {
            textBoxName1.Clear();
            textBoxRollNum1.Clear();
            comboBoxSemester1.SelectedIndex = -1;
            radioButtonMale1.Checked = false;
            radioButtonFemale1.Checked = false;
            SID = "";
        }


        private void tabPageAddStudent_Enter(object sender, EventArgs e)
        {
            CLearTextBox1();
        }

        private void tabPageUpdateAndDeleteStd_Enter(object sender, EventArgs e)
        {
            
        }

        private void tabPageAddStudent_Leave(object sender, EventArgs e)
        {
            CLearTextBox();
        }

        private void tabControlAddStudent_Leave(object sender, EventArgs e)
        {
            CLearTextBox1();
        }

        private void comboBoxSemester_Click(object sender, EventArgs e)
        {
            comboBoxSemester.Items.Clear();
            Attendance.FillComboBox("SELECT DISTINCT(Class_Semester) FROM Class_Table;", comboBoxSemester, sql);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string gender = "";
            if (radioButtonMale.Checked)
                gender = "Male";
            if (radioButtonFemale.Checked)
                gender = "Female";


            if (textBoxName.Text.Trim() == string.Empty || textBoxRollNum.Text.Trim() == string.Empty || comboBoxSemester.SelectedIndex == -1)
            {
                MessageBox.Show("First fill out all fields", "Required all fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (radioButtonMale.Checked == false && radioButtonFemale.Checked == false)
            {
                MessageBox.Show("First fill out all fields", "Required all fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                bool check = Attendance.AddStudent(textBoxName.Text.Trim(), textBoxRollNum.Text.Trim(), comboBoxSemester.SelectedItem.ToString(), gender, sql);

                if (check)
                    CLearTextBox();
            }
        }

        private void tabPageSearchStudent_Enter(object sender, EventArgs e)
        {
            textBoxSearch.Clear();
            comboBoxSearchBy.SelectedIndex = -1;
            Attendance.DisplayAndSearchAllData("SELECT Student_ID, Student_Name, Student_Roll, Student_Gender, Class_Semester FROM Student_Table INNER JOIN Class_Table ON Student_Table.Class_ID = Class_Table.Class_ID;", dataGridViewStudent, sql);
            dataGridViewStudent.Columns[0].Visible = false;
            labelCountStudent.Text = dataGridViewStudent.Rows.Count.ToString();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxSearchBy.SelectedIndex == 0)
                Attendance.DisplayAndSearchAllData("SELECT Student_ID, Student_Name, Student_Roll, Student_Gender, Class_Semester FROM Student_Table INNER JOIN Class_Table ON Student_Table.Class_ID = Class_Table.Class_ID WHERE Student_Name LIKE '%" + textBoxSearch.Text.Trim() + "%';", dataGridViewStudent, sql);
            if (comboBoxSearchBy.SelectedIndex == 1)
                Attendance.DisplayAndSearchAllData("SELECT Student_ID, Student_Name, Student_Roll, Student_Gender, Class_Semester FROM Student_Table INNER JOIN Class_Table ON Student_Table.Class_ID = Class_Table.Class_ID WHERE Student_Roll LIKE '%" + textBoxSearch.Text.Trim() + "%';", dataGridViewStudent, sql);
            if (comboBoxSearchBy.SelectedIndex == 2)
                Attendance.DisplayAndSearchAllData("SELECT Student_ID, Student_Name, Student_Roll, Student_Gender, Class_Semester FROM Student_Table INNER JOIN Class_Table ON Student_Table.Class_ID = Class_Table.Class_ID WHERE Class_Semester LIKE '%" + textBoxSearch.Text.Trim() + "%';", dataGridViewStudent, sql);
        }

        private void dataGridViewStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridViewStudent.Rows[e.RowIndex];
                SID = row.Cells["Column1"].Value.ToString();
                textBoxName1.Text = row.Cells["Column2"].Value.ToString();
                textBoxRollNum1.Text = row.Cells["Column3"].Value.ToString();
                comboBoxSemester1.Items.Clear();
                Attendance.FillComboBox("SELECT DISTINCT(Class_Semester) FROM Class_Table;", comboBoxSemester1, sql);
                comboBoxSemester1.SelectedItem = row.Cells["Column4"].Value.ToString();

                if (row.Cells["Column5"].Value.ToString() == "Male")
                    radioButtonMale1.Checked = true;

                if (row.Cells["Column5"].Value.ToString() == "Female")
                    radioButtonFemale1.Checked = true;

            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (SID != "")
            {
                if (radioButtonMale1.Checked)
                    gender = "Male";
                if (radioButtonFemale1.Checked)
                    gender = "Female";


                if (textBoxName1.Text.Trim() == string.Empty || textBoxRollNum1.Text.Trim() == string.Empty || comboBoxSemester1.SelectedIndex == -1)
                {
                    MessageBox.Show("First fill out all fields", "Required all fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (radioButtonMale1.Checked == false && radioButtonFemale1.Checked == false)
                {
                    MessageBox.Show("First fill out all fields", "Required all fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    bool check = Attendance.UpdateStudent(SID,textBoxName1.Text.Trim(), textBoxRollNum1.Text.Trim(), comboBoxSemester1.SelectedItem.ToString(), gender, sql);

                    if (check)
                        CLearTextBox1();
                }
            }
            else
                MessageBox.Show("First select row from table", "select row", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBoxSearch_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(pictureBoxSearch, "Search");
        }

        private void tabPageUpdateAndDeleteStd_Leave(object sender, EventArgs e)
        {
            CLearTextBox1();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (SID != "")
            {
                if (radioButtonMale1.Checked)
                    gender = "Male";
                if (radioButtonFemale1.Checked)
                    gender = "Female";


                if (textBoxName1.Text.Trim() == string.Empty || textBoxRollNum1.Text.Trim() == string.Empty || comboBoxSemester1.SelectedIndex == -1)
                {
                    MessageBox.Show("First fill out all fields", "Required all fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (radioButtonMale1.Checked == false && radioButtonFemale1.Checked == false)
                {
                    MessageBox.Show("First fill out all fields", "Required all fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Do you want to delete this Student?", "Delete Student", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        bool check = Attendance.DeleteStudent(SID, sql);

                        if (check)
                            CLearTextBox1();
                    }
                }
            }
            else
                MessageBox.Show("First select row from table", "select row", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
