
namespace Attendance_management_system.pal.UserControlForms
{
    partial class UserControlAttendance
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageMarkAttendance = new System.Windows.Forms.TabPage();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dataGridViewMarkAttendance = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attendance_MGSDataSet1 = new Attendance_management_system.Attendance_MGSDataSet1();
            this.panel7 = new System.Windows.Forms.Panel();
            this.comboBoxClass = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.Attendance = new System.Windows.Forms.TabPage();
            this.attendanceTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.attendance_TableTableAdapter = new Attendance_management_system.Attendance_MGSDataSet1TableAdapters.Attendance_TableTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPageMarkAttendance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMarkAttendance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendance_MGSDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.tabPageMarkAttendance);
            this.tabControl1.Controls.Add(this.Attendance);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(942, 501);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageMarkAttendance
            // 
            this.tabPageMarkAttendance.Controls.Add(this.buttonAdd);
            this.tabPageMarkAttendance.Controls.Add(this.dataGridViewMarkAttendance);
            this.tabPageMarkAttendance.Controls.Add(this.panel7);
            this.tabPageMarkAttendance.Controls.Add(this.comboBoxClass);
            this.tabPageMarkAttendance.Controls.Add(this.label3);
            this.tabPageMarkAttendance.Controls.Add(this.panel6);
            this.tabPageMarkAttendance.Controls.Add(this.panel5);
            this.tabPageMarkAttendance.Controls.Add(this.panel4);
            this.tabPageMarkAttendance.Controls.Add(this.panel3);
            this.tabPageMarkAttendance.Controls.Add(this.panel2);
            this.tabPageMarkAttendance.Controls.Add(this.panel1);
            this.tabPageMarkAttendance.Controls.Add(this.label2);
            this.tabPageMarkAttendance.Controls.Add(this.label1);
            this.tabPageMarkAttendance.Controls.Add(this.dateTimePickerDate);
            this.tabPageMarkAttendance.Location = new System.Drawing.Point(4, 4);
            this.tabPageMarkAttendance.Name = "tabPageMarkAttendance";
            this.tabPageMarkAttendance.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMarkAttendance.Size = new System.Drawing.Size(934, 471);
            this.tabPageMarkAttendance.TabIndex = 0;
            this.tabPageMarkAttendance.Text = " ";
            this.tabPageMarkAttendance.UseVisualStyleBackColor = true;
            this.tabPageMarkAttendance.Click += new System.EventHandler(this.tabPageMarkAttendance_Click);
            this.tabPageMarkAttendance.Leave += new System.EventHandler(this.tabPageMarkAttendance_Leave);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(3)))), ((int)(((byte)(125)))));
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(755, 3);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(85, 30);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Done";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // dataGridViewMarkAttendance
            // 
            this.dataGridViewMarkAttendance.AllowUserToAddRows = false;
            this.dataGridViewMarkAttendance.AllowUserToDeleteRows = false;
            this.dataGridViewMarkAttendance.AllowUserToResizeColumns = false;
            this.dataGridViewMarkAttendance.AllowUserToResizeRows = false;
            this.dataGridViewMarkAttendance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMarkAttendance.AutoGenerateColumns = false;
            this.dataGridViewMarkAttendance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMarkAttendance.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewMarkAttendance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewMarkAttendance.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewMarkAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMarkAttendance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridViewMarkAttendance.DataSource = this.attendance_MGSDataSet1;
            this.dataGridViewMarkAttendance.Location = new System.Drawing.Point(31, 131);
            this.dataGridViewMarkAttendance.Name = "dataGridViewMarkAttendance";
            this.dataGridViewMarkAttendance.RowHeadersWidth = 51;
            this.dataGridViewMarkAttendance.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewMarkAttendance.RowTemplate.Height = 24;
            this.dataGridViewMarkAttendance.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewMarkAttendance.ShowCellErrors = false;
            this.dataGridViewMarkAttendance.ShowEditingIcon = false;
            this.dataGridViewMarkAttendance.ShowRowErrors = false;
            this.dataGridViewMarkAttendance.Size = new System.Drawing.Size(872, 318);
            this.dataGridViewMarkAttendance.TabIndex = 0;
            this.dataGridViewMarkAttendance.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewMarkAttendance_CellFormatting);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Student_ID";
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Student_Name";
            this.Column2.HeaderText = "Student Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Student_Roll";
            this.Column3.HeaderText = "Roll Number";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Status";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Attendance_Status";
            this.Column5.HeaderText = "Status";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // attendance_MGSDataSet1
            // 
            this.attendance_MGSDataSet1.DataSetName = "Attendance_MGSDataSet1";
            this.attendance_MGSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel7
            // 
            this.panel7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel7.BackColor = System.Drawing.Color.LightGray;
            this.panel7.Location = new System.Drawing.Point(454, 102);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(270, 2);
            this.panel7.TabIndex = 0;
            // 
            // comboBoxClass
            // 
            this.comboBoxClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxClass.FormattingEnabled = true;
            this.comboBoxClass.Location = new System.Drawing.Point(454, 76);
            this.comboBoxClass.Name = "comboBoxClass";
            this.comboBoxClass.Size = new System.Drawing.Size(270, 25);
            this.comboBoxClass.TabIndex = 2;
            this.comboBoxClass.SelectedIndexChanged += new System.EventHandler(this.comboBoxClass_SelectedIndexChanged);
            this.comboBoxClass.Click += new System.EventHandler(this.comboBoxClass_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(451, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Class:";
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel6.BackColor = System.Drawing.Color.LightGray;
            this.panel6.Location = new System.Drawing.Point(120, 99);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(270, 2);
            this.panel6.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Location = new System.Drawing.Point(347, 73);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 23);
            this.panel5.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Location = new System.Drawing.Point(391, 73);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 23);
            this.panel4.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Location = new System.Drawing.Point(111, 73);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 23);
            this.panel3.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(120, 95);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(270, 10);
            this.panel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(120, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 10);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(117, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(3)))), ((int)(((byte)(125)))));
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mark Attendance:";
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.CustomFormat = "yyyy/MM/dd";
            this.dateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDate.Location = new System.Drawing.Point(120, 73);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(245, 24);
            this.dateTimePickerDate.TabIndex = 0;
            // 
            // Attendance
            // 
            this.Attendance.Location = new System.Drawing.Point(4, 4);
            this.Attendance.Name = "Attendance";
            this.Attendance.Padding = new System.Windows.Forms.Padding(3);
            this.Attendance.Size = new System.Drawing.Size(934, 471);
            this.Attendance.TabIndex = 1;
            this.Attendance.Text = "Attendance";
            this.Attendance.UseVisualStyleBackColor = true;
            // 
            // attendanceTableBindingSource
            // 
            this.attendanceTableBindingSource.DataMember = "Attendance_Table";
            this.attendanceTableBindingSource.DataSource = this.attendance_MGSDataSet1;
            // 
            // attendance_TableTableAdapter
            // 
            this.attendance_TableTableAdapter.ClearBeforeFill = true;
            // 
            // UserControlAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.8F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControlAttendance";
            this.Size = new System.Drawing.Size(942, 501);
            this.tabControl1.ResumeLayout(false);
            this.tabPageMarkAttendance.ResumeLayout(false);
            this.tabPageMarkAttendance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMarkAttendance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendance_MGSDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceTableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageMarkAttendance;
        private System.Windows.Forms.TabPage Attendance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxClass;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridView dataGridViewMarkAttendance;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private Attendance_MGSDataSet1 attendance_MGSDataSet1;
        private System.Windows.Forms.BindingSource attendanceTableBindingSource;
        private Attendance_MGSDataSet1TableAdapters.Attendance_TableTableAdapter attendance_TableTableAdapter;
        private System.Windows.Forms.Button buttonAdd;
    }
}
