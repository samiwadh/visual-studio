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
    public partial class UserControlAttendance : UserControl
    {
        private string sql = @"Data Source=DESKTOP-G9JJ980;Initial Catalog=Attendance_MGS;User ID=sa;Password=sql";
        private bool okey;

        public UserControlAttendance()
        {
            InitializeComponent();
            dataGridViewMarkAttendance.Columns["Column1"].Visible = false;
            dataGridViewMarkAttendance.Columns["Column5"].Visible = false;

        }

        private void tabPageMarkAttendance_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (global::Attendance.IsMarkAttendance(dateTimePickerDate.Text, comboBoxClass.SelectedItem.ToString(), sql))
                {
                    global::Attendance.DisplayAndSearchAllData("Select Student_Table.Student_ID,Student_Table.Student_Name ,Student_Table.Student_Roll,Attendance_Table.Attendance_Status From Student_Table INNER JOIN Attendance_Table ON Student_Table.Student_ID =Attendance_Table.Student_ID INNER JOIN Class_Table ON Class_Table.Class_ID = Student_Table.Class_ID WHERE Attendance_Table.Attendance_Date = '" + dateTimePickerDate.Text + "'AND Class_Table.Class_Name = '" + comboBoxClass.SelectedItem.ToString() + "';", dataGridViewMarkAttendance, sql);
                    okey = true;
                }
                else
                {
                    global::Attendance.DisplayAndSearchAllData("Select Student_ID,Student_Name ,Student_Roll  From Student_Table INNER JOIN Class_Table ON Class_Table.Class_ID =Student_Table.Class_ID WHERE Class_Name = '" + comboBoxClass.SelectedItem.ToString() + "';", dataGridViewMarkAttendance, sql);
                    okey = false;
                }
            }
            catch (Exception ex )
            {

               
            }
                
        }

        private void tabPageMarkAttendance_Leave(object sender, EventArgs e)
        {
            if (comboBoxClass.SelectedIndex != -1)
            {
                string status = "Absent";
                if (global::Attendance.IsMarkAttendance(dateTimePickerDate.Text, comboBoxClass.SelectedItem.ToString(), sql))
                {
                    foreach (DataGridViewRow row in dataGridViewMarkAttendance.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells["Column4"].EditedFormattedValue) == true)
                        {
                            status = "Present";
                        }
                        else
                        {
                            status = "Absent";
                        }
                        global::Attendance.UpdateAttendance(row.Cells["Column1"].Value.ToString(), dateTimePickerDate.Text, status, sql);

                    }
                }
                else
                {
                    foreach (DataGridViewRow row in dataGridViewMarkAttendance.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells["Column4"].EditedFormattedValue) == true)
                            status = "Present";
                        else
                            status = "Absent";

                        global::Attendance.UpdateAttendance(row.Cells["Column1"].Value.ToString(), dateTimePickerDate.Text, status, sql);

                    }
                }
            }
        }

        private void dataGridViewMarkAttendance_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (comboBoxClass.SelectedIndex != -1)
            {
                
                if (global::Attendance.IsMarkAttendance(dateTimePickerDate.Text, comboBoxClass.SelectedItem.ToString(), sql) && okey)
                {
                    foreach (DataGridViewRow row in dataGridViewMarkAttendance.Rows)
                    {
                        if (row.Cells["Column5"].Value.ToString() == "Present")
                            row.Cells["Column4"].Value = true;
                        else
                            row.Cells["Column4"].Value = false;

                    }
                }
               
            }
        }

        private void comboBoxClass_Click(object sender, EventArgs e)
        {
            comboBoxClass.Items.Clear();
            global::Attendance.FillComboBox("Select Distinct(Class_Name) From Class_Table", comboBoxClass, sql);

        }

        private void buttonDone_Click(object sender, EventArgs e)
        {

            {
                if (comboBoxClass.SelectedIndex != -1)
                {
                    string status = "Absent";
                    if (!global::Attendance.IsMarkAttendance(dateTimePickerDate.Text, comboBoxClass.SelectedItem.ToString(), sql))
                    {
                        foreach (DataGridViewRow row in dataGridViewMarkAttendance.Rows)
                        {
                            if (Convert.ToBoolean(row.Cells["Column4"].EditedFormattedValue) == true)
                            {
                                status = "Present";
                            }
                            else
                            {
                                status = "Absent";
                            }
                            global::Attendance.MarkAttendance(row.Cells["Column1"].Value.ToString(), dateTimePickerDate.Text, status, sql);

                        }
                    }
                    else
                    {
                        foreach (DataGridViewRow row in dataGridViewMarkAttendance.Rows)
                        {
                            if (Convert.ToBoolean(row.Cells["Column4"].EditedFormattedValue) == true)
                                status = "Present";
                            else
                                status = "Absent";

                            global::Attendance.UpdateAttendance(row.Cells["Column1"].Value.ToString(), dateTimePickerDate.Text, status, sql);

                        }
                    }
                }
            }
        }
    }
}
