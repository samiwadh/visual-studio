
namespace Attendance_management_system.pal.UserControlForms
{
    partial class UserControlreport
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
            this.tabControlReport = new System.Windows.Forms.TabControl();
            this.tabPageClassReport = new System.Windows.Forms.TabPage();
            this.pictureBoxprint = new System.Windows.Forms.PictureBox();
            this.dataGridViewClassReport = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel7 = new System.Windows.Forms.Panel();
            this.comboBoxClass = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.tabPageStudentReport = new System.Windows.Forms.TabPage();
            this.pictureBoxprint1 = new System.Windows.Forms.PictureBox();
            this.dataGridViewStudentReport = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel8 = new System.Windows.Forms.Panel();
            this.comboBoxClass1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePickerDate2 = new System.Windows.Forms.DateTimePicker();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControlReport.SuspendLayout();
            this.tabPageClassReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxprint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClassReport)).BeginInit();
            this.tabPageStudentReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxprint1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentReport)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlReport
            // 
            this.tabControlReport.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlReport.Controls.Add(this.tabPageClassReport);
            this.tabControlReport.Controls.Add(this.tabPageStudentReport);
            this.tabControlReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlReport.Location = new System.Drawing.Point(0, 0);
            this.tabControlReport.Name = "tabControlReport";
            this.tabControlReport.SelectedIndex = 0;
            this.tabControlReport.Size = new System.Drawing.Size(942, 501);
            this.tabControlReport.TabIndex = 0;
            // 
            // tabPageClassReport
            // 
            this.tabPageClassReport.Controls.Add(this.pictureBoxprint);
            this.tabPageClassReport.Controls.Add(this.dataGridViewClassReport);
            this.tabPageClassReport.Controls.Add(this.panel7);
            this.tabPageClassReport.Controls.Add(this.comboBoxClass);
            this.tabPageClassReport.Controls.Add(this.label3);
            this.tabPageClassReport.Controls.Add(this.panel6);
            this.tabPageClassReport.Controls.Add(this.label2);
            this.tabPageClassReport.Controls.Add(this.label1);
            this.tabPageClassReport.Controls.Add(this.dateTimePickerDate);
            this.tabPageClassReport.Location = new System.Drawing.Point(4, 4);
            this.tabPageClassReport.Name = "tabPageClassReport";
            this.tabPageClassReport.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageClassReport.Size = new System.Drawing.Size(934, 471);
            this.tabPageClassReport.TabIndex = 0;
            this.tabPageClassReport.Text = " Class Report";
            this.tabPageClassReport.UseVisualStyleBackColor = true;
            this.tabPageClassReport.Click += new System.EventHandler(this.tabPageMarkAttendance_Click);
            // 
            // pictureBoxprint
            // 
            this.pictureBoxprint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxprint.Image = global::Attendance_management_system.Properties.Resources.printericon;
            this.pictureBoxprint.Location = new System.Drawing.Point(789, 2);
            this.pictureBoxprint.Name = "pictureBoxprint";
            this.pictureBoxprint.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxprint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxprint.TabIndex = 3;
            this.pictureBoxprint.TabStop = false;
            this.pictureBoxprint.Click += new System.EventHandler(this.pictureBoxprint_Click);
            this.pictureBoxprint.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // dataGridViewClassReport
            // 
            this.dataGridViewClassReport.AllowUserToAddRows = false;
            this.dataGridViewClassReport.AllowUserToDeleteRows = false;
            this.dataGridViewClassReport.AllowUserToResizeColumns = false;
            this.dataGridViewClassReport.AllowUserToResizeRows = false;
            this.dataGridViewClassReport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewClassReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewClassReport.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewClassReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewClassReport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewClassReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClassReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridViewClassReport.Location = new System.Drawing.Point(31, 131);
            this.dataGridViewClassReport.Name = "dataGridViewClassReport";
            this.dataGridViewClassReport.ReadOnly = true;
            this.dataGridViewClassReport.RowHeadersWidth = 51;
            this.dataGridViewClassReport.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewClassReport.RowTemplate.Height = 24;
            this.dataGridViewClassReport.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewClassReport.ShowCellErrors = false;
            this.dataGridViewClassReport.ShowEditingIcon = false;
            this.dataGridViewClassReport.ShowRowErrors = false;
            this.dataGridViewClassReport.Size = new System.Drawing.Size(872, 318);
            this.dataGridViewClassReport.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Student_Name";
            this.Column1.HeaderText = "Student Name";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Student_Roll";
            this.Column2.HeaderText = "Reg Roll No";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Class_Name";
            this.Column3.HeaderText = "Class";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Attendance_Date";
            this.Column4.HeaderText = "Date";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Attendance_Status";
            this.Column5.HeaderText = "Status";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // panel7
            // 
            this.panel7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel7.BackColor = System.Drawing.Color.LightGray;
            this.panel7.Location = new System.Drawing.Point(460, 75);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(270, 2);
            this.panel7.TabIndex = 0;
            // 
            // comboBoxClass
            // 
            this.comboBoxClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxClass.FormattingEnabled = true;
            this.comboBoxClass.Location = new System.Drawing.Point(490, 78);
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
            this.label3.Location = new System.Drawing.Point(457, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Class:";
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel6.BackColor = System.Drawing.Color.LightGray;
            this.panel6.Location = new System.Drawing.Point(31, 80);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(270, 2);
            this.panel6.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(28, 15);
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
            this.label1.Size = new System.Drawing.Size(105, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Class Report:";
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.CustomFormat = "yyyy/MM/dd";
            this.dateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDate.Location = new System.Drawing.Point(60, 77);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(270, 24);
            this.dateTimePickerDate.TabIndex = 0;
            this.dateTimePickerDate.ValueChanged += new System.EventHandler(this.dateTimePickerDate_ValueChanged);
            // 
            // tabPageStudentReport
            // 
            this.tabPageStudentReport.Controls.Add(this.pictureBoxprint1);
            this.tabPageStudentReport.Controls.Add(this.dataGridViewStudentReport);
            this.tabPageStudentReport.Controls.Add(this.panel8);
            this.tabPageStudentReport.Controls.Add(this.comboBoxClass1);
            this.tabPageStudentReport.Controls.Add(this.label4);
            this.tabPageStudentReport.Controls.Add(this.panel9);
            this.tabPageStudentReport.Controls.Add(this.label5);
            this.tabPageStudentReport.Controls.Add(this.label6);
            this.tabPageStudentReport.Controls.Add(this.dateTimePickerDate2);
            this.tabPageStudentReport.Location = new System.Drawing.Point(4, 4);
            this.tabPageStudentReport.Name = "tabPageStudentReport";
            this.tabPageStudentReport.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStudentReport.Size = new System.Drawing.Size(934, 471);
            this.tabPageStudentReport.TabIndex = 1;
            this.tabPageStudentReport.Text = "Student Report";
            this.tabPageStudentReport.UseVisualStyleBackColor = true;
            this.tabPageStudentReport.Click += new System.EventHandler(this.tabPageStudentReport_Click);
            // 
            // pictureBoxprint1
            // 
            this.pictureBoxprint1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxprint1.Image = global::Attendance_management_system.Properties.Resources.printericon;
            this.pictureBoxprint1.Location = new System.Drawing.Point(789, 2);
            this.pictureBoxprint1.Name = "pictureBoxprint1";
            this.pictureBoxprint1.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxprint1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxprint1.TabIndex = 15;
            this.pictureBoxprint1.TabStop = false;
            this.pictureBoxprint1.Click += new System.EventHandler(this.pictureBoxprint1_Click);
            // 
            // dataGridViewStudentReport
            // 
            this.dataGridViewStudentReport.AllowUserToAddRows = false;
            this.dataGridViewStudentReport.AllowUserToDeleteRows = false;
            this.dataGridViewStudentReport.AllowUserToResizeColumns = false;
            this.dataGridViewStudentReport.AllowUserToResizeRows = false;
            this.dataGridViewStudentReport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewStudentReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewStudentReport.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewStudentReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewStudentReport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewStudentReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudentReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dataGridViewStudentReport.Location = new System.Drawing.Point(44, 137);
            this.dataGridViewStudentReport.Name = "dataGridViewStudentReport";
            this.dataGridViewStudentReport.ReadOnly = true;
            this.dataGridViewStudentReport.RowHeadersWidth = 51;
            this.dataGridViewStudentReport.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewStudentReport.RowTemplate.Height = 24;
            this.dataGridViewStudentReport.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewStudentReport.ShowCellErrors = false;
            this.dataGridViewStudentReport.ShowEditingIcon = false;
            this.dataGridViewStudentReport.ShowRowErrors = false;
            this.dataGridViewStudentReport.Size = new System.Drawing.Size(872, 318);
            this.dataGridViewStudentReport.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Student_Name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Student Name";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Student_Roll";
            this.dataGridViewTextBoxColumn2.HeaderText = "Roll no";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Class_Name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Class";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Attendance_Date";
            this.dataGridViewTextBoxColumn4.HeaderText = "Date";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Attendance_Status";
            this.dataGridViewTextBoxColumn5.HeaderText = "Status";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // panel8
            // 
            this.panel8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel8.BackColor = System.Drawing.Color.LightGray;
            this.panel8.Location = new System.Drawing.Point(343, 80);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(270, 2);
            this.panel8.TabIndex = 0;
            this.panel8.Paint += new System.Windows.Forms.PaintEventHandler(this.panel8_Paint);
            // 
            // comboBoxClass1
            // 
            this.comboBoxClass1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClass1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxClass1.FormattingEnabled = true;
            this.comboBoxClass1.Location = new System.Drawing.Point(368, 73);
            this.comboBoxClass1.Name = "comboBoxClass1";
            this.comboBoxClass1.Size = new System.Drawing.Size(270, 25);
            this.comboBoxClass1.TabIndex = 2;
            this.comboBoxClass1.SelectedIndexChanged += new System.EventHandler(this.comboBoxClass1_SelectedIndexChanged);
            this.comboBoxClass1.Click += new System.EventHandler(this.comboBox1_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(342, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Class:";
            // 
            // panel9
            // 
            this.panel9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel9.BackColor = System.Drawing.Color.LightGray;
            this.panel9.Location = new System.Drawing.Point(44, 80);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(270, 2);
            this.panel9.TabIndex = 6;
            this.panel9.Paint += new System.Windows.Forms.PaintEventHandler(this.panel9_Paint);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(28, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(3)))), ((int)(((byte)(125)))));
            this.label6.Location = new System.Drawing.Point(19, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Student Report:";
            // 
            // dateTimePickerDate2
            // 
            this.dateTimePickerDate2.CustomFormat = "yyyy/MM";
            this.dateTimePickerDate2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDate2.Location = new System.Drawing.Point(69, 73);
            this.dateTimePickerDate2.Name = "dateTimePickerDate2";
            this.dateTimePickerDate2.Size = new System.Drawing.Size(270, 24);
            this.dateTimePickerDate2.TabIndex = 14;
            this.dateTimePickerDate2.ValueChanged += new System.EventHandler(this.dateTimePickerDate2_ValueChanged);
            // 
            // UserControlreport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControlReport);
            this.Font = new System.Drawing.Font("Century Gothic", 9.8F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControlreport";
            this.Size = new System.Drawing.Size(942, 501);
            this.tabControlReport.ResumeLayout(false);
            this.tabPageClassReport.ResumeLayout(false);
            this.tabPageClassReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxprint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClassReport)).EndInit();
            this.tabPageStudentReport.ResumeLayout(false);
            this.tabPageStudentReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxprint1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.DateTimePicker dateTimePickerDate2;
        public System.Windows.Forms.TabPage tabPageClassReport;
        public System.Windows.Forms.TabControl tabControlReport;
        public System.Windows.Forms.DataGridView dataGridViewClassReport;
        public System.Windows.Forms.Panel panel7;
        public System.Windows.Forms.ComboBox comboBoxClass;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Panel panel6;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.DateTimePicker dateTimePickerDate;
        public System.Windows.Forms.TabPage tabPageStudentReport;
        public System.Windows.Forms.DataGridView dataGridViewStudentReport;
        public System.Windows.Forms.Panel panel8;
        public System.Windows.Forms.ComboBox comboBoxClass1;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Panel panel9;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.PictureBox pictureBoxprint;
        public System.Windows.Forms.PictureBox pictureBoxprint1;
        public System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.ToolTip toolTip2;
        public System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        public System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        public System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        public System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        public System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        public System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        public System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        public System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        public System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        public System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}
