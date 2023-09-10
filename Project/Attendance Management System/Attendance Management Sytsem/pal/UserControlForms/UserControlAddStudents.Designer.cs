﻿
namespace Attendance_management_system.pal.UserControlForms
{
    partial class UserControlAddStudents
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
            this.tabControlAddStudent = new System.Windows.Forms.TabControl();
            this.tabPageAddStudent = new System.Windows.Forms.TabPage();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.comboBoxSemester = new System.Windows.Forms.ComboBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxRollNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageSearchStudent = new System.Windows.Forms.TabPage();
            this.comboBoxSearchBy = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.dataGridViewStudent = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.labelCountStudent = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBoxSearch = new System.Windows.Forms.PictureBox();
            this.tabPageUpdateAndDeleteStd = new System.Windows.Forms.TabPage();
            this.radioButtonFemale1 = new System.Windows.Forms.RadioButton();
            this.radioButtonMale1 = new System.Windows.Forms.RadioButton();
            this.comboBoxSemester1 = new System.Windows.Forms.ComboBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.textBoxRollNum1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxName1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tabControlAddStudent.SuspendLayout();
            this.tabPageAddStudent.SuspendLayout();
            this.tabPageSearchStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearch)).BeginInit();
            this.tabPageUpdateAndDeleteStd.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlAddStudent
            // 
            this.tabControlAddStudent.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlAddStudent.Controls.Add(this.tabPageAddStudent);
            this.tabControlAddStudent.Controls.Add(this.tabPageSearchStudent);
            this.tabControlAddStudent.Controls.Add(this.tabPageUpdateAndDeleteStd);
            this.tabControlAddStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlAddStudent.Location = new System.Drawing.Point(0, 0);
            this.tabControlAddStudent.Name = "tabControlAddStudent";
            this.tabControlAddStudent.SelectedIndex = 0;
            this.tabControlAddStudent.Size = new System.Drawing.Size(942, 501);
            this.tabControlAddStudent.TabIndex = 0;
            this.tabControlAddStudent.Leave += new System.EventHandler(this.tabControlAddStudent_Leave);
            // 
            // tabPageAddStudent
            // 
            this.tabPageAddStudent.Controls.Add(this.radioButtonFemale);
            this.tabPageAddStudent.Controls.Add(this.radioButtonMale);
            this.tabPageAddStudent.Controls.Add(this.comboBoxSemester);
            this.tabPageAddStudent.Controls.Add(this.buttonAdd);
            this.tabPageAddStudent.Controls.Add(this.panel2);
            this.tabPageAddStudent.Controls.Add(this.panel3);
            this.tabPageAddStudent.Controls.Add(this.panel1);
            this.tabPageAddStudent.Controls.Add(this.textBoxRollNum);
            this.tabPageAddStudent.Controls.Add(this.label3);
            this.tabPageAddStudent.Controls.Add(this.textBoxName);
            this.tabPageAddStudent.Controls.Add(this.label5);
            this.tabPageAddStudent.Controls.Add(this.label4);
            this.tabPageAddStudent.Controls.Add(this.label2);
            this.tabPageAddStudent.Controls.Add(this.label1);
            this.tabPageAddStudent.Location = new System.Drawing.Point(4, 4);
            this.tabPageAddStudent.Name = "tabPageAddStudent";
            this.tabPageAddStudent.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddStudent.Size = new System.Drawing.Size(934, 471);
            this.tabPageAddStudent.TabIndex = 0;
            this.tabPageAddStudent.Text = "Add Student";
            this.tabPageAddStudent.UseVisualStyleBackColor = true;
            this.tabPageAddStudent.Enter += new System.EventHandler(this.tabPageAddStudent_Enter);
            this.tabPageAddStudent.Leave += new System.EventHandler(this.tabPageAddStudent_Leave);
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Location = new System.Drawing.Point(700, 320);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(71, 21);
            this.radioButtonFemale.TabIndex = 5;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "female";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Location = new System.Drawing.Point(700, 289);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(59, 21);
            this.radioButtonMale.TabIndex = 4;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "male";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // comboBoxSemester
            // 
            this.comboBoxSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSemester.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxSemester.FormattingEnabled = true;
            this.comboBoxSemester.Items.AddRange(new object[] {
            "--Select--"});
            this.comboBoxSemester.Location = new System.Drawing.Point(195, 260);
            this.comboBoxSemester.Name = "comboBoxSemester";
            this.comboBoxSemester.Size = new System.Drawing.Size(271, 25);
            this.comboBoxSemester.TabIndex = 3;
            this.comboBoxSemester.Click += new System.EventHandler(this.comboBoxSemester_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(3)))), ((int)(((byte)(125)))));
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(115, 320);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(114, 37);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Location = new System.Drawing.Point(557, 175);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(270, 2);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Location = new System.Drawing.Point(116, 240);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(270, 2);
            this.panel3.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Location = new System.Drawing.Point(115, 175);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 2);
            this.panel1.TabIndex = 0;
            // 
            // textBoxRollNum
            // 
            this.textBoxRollNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxRollNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRollNum.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.textBoxRollNum.Location = new System.Drawing.Point(557, 148);
            this.textBoxRollNum.Name = "textBoxRollNum";
            this.textBoxRollNum.Size = new System.Drawing.Size(270, 17);
            this.textBoxRollNum.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(553, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Roll Number:";
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxName.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.textBoxName.Location = new System.Drawing.Point(115, 148);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(270, 17);
            this.textBoxName.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(553, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Gender";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(112, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Semester";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(112, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(3)))), ((int)(((byte)(125)))));
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Student:";
            // 
            // tabPageSearchStudent
            // 
            this.tabPageSearchStudent.Controls.Add(this.comboBoxSearchBy);
            this.tabPageSearchStudent.Controls.Add(this.panel4);
            this.tabPageSearchStudent.Controls.Add(this.label14);
            this.tabPageSearchStudent.Controls.Add(this.dataGridViewStudent);
            this.tabPageSearchStudent.Controls.Add(this.textBoxSearch);
            this.tabPageSearchStudent.Controls.Add(this.panel5);
            this.tabPageSearchStudent.Controls.Add(this.labelCountStudent);
            this.tabPageSearchStudent.Controls.Add(this.label8);
            this.tabPageSearchStudent.Controls.Add(this.label6);
            this.tabPageSearchStudent.Controls.Add(this.label7);
            this.tabPageSearchStudent.Controls.Add(this.pictureBoxSearch);
            this.tabPageSearchStudent.Location = new System.Drawing.Point(4, 4);
            this.tabPageSearchStudent.Name = "tabPageSearchStudent";
            this.tabPageSearchStudent.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearchStudent.Size = new System.Drawing.Size(934, 471);
            this.tabPageSearchStudent.TabIndex = 1;
            this.tabPageSearchStudent.Text = "Search Student";
            this.tabPageSearchStudent.UseVisualStyleBackColor = true;
            this.tabPageSearchStudent.Enter += new System.EventHandler(this.tabPageSearchStudent_Enter);
            // 
            // comboBoxSearchBy
            // 
            this.comboBoxSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSearchBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxSearchBy.FormattingEnabled = true;
            this.comboBoxSearchBy.Items.AddRange(new object[] {
            "Name",
            "Roll Number",
            "Semester"});
            this.comboBoxSearchBy.Location = new System.Drawing.Point(466, 82);
            this.comboBoxSearchBy.Name = "comboBoxSearchBy";
            this.comboBoxSearchBy.Size = new System.Drawing.Size(216, 25);
            this.comboBoxSearchBy.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.BackColor = System.Drawing.Color.LightGray;
            this.panel4.Location = new System.Drawing.Point(467, 104);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(212, 10);
            this.panel4.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(463, 59);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 16);
            this.label14.TabIndex = 0;
            this.label14.Text = "Search By:";
            // 
            // dataGridViewStudent
            // 
            this.dataGridViewStudent.AllowUserToAddRows = false;
            this.dataGridViewStudent.AllowUserToDeleteRows = false;
            this.dataGridViewStudent.AllowUserToResizeColumns = false;
            this.dataGridViewStudent.AllowUserToResizeRows = false;
            this.dataGridViewStudent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewStudent.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewStudent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewStudent.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridViewStudent.Location = new System.Drawing.Point(31, 131);
            this.dataGridViewStudent.Name = "dataGridViewStudent";
            this.dataGridViewStudent.ReadOnly = true;
            this.dataGridViewStudent.RowHeadersWidth = 51;
            this.dataGridViewStudent.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewStudent.RowTemplate.Height = 24;
            this.dataGridViewStudent.ShowCellErrors = false;
            this.dataGridViewStudent.ShowEditingIcon = false;
            this.dataGridViewStudent.ShowRowErrors = false;
            this.dataGridViewStudent.Size = new System.Drawing.Size(872, 318);
            this.dataGridViewStudent.TabIndex = 0;
            this.dataGridViewStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStudent_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Student_ID";
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Student_Name";
            this.Column2.HeaderText = "Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Student_Roll";
            this.Column3.HeaderText = "Roll Number";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Class_Semester";
            this.Column4.HeaderText = "Semester";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Student_Gender";
            this.Column5.HeaderText = "Gender";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSearch.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.textBoxSearch.Location = new System.Drawing.Point(154, 79);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(252, 17);
            this.textBoxSearch.TabIndex = 1;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightGray;
            this.panel5.Location = new System.Drawing.Point(155, 109);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(270, 2);
            this.panel5.TabIndex = 0;
            // 
            // labelCountStudent
            // 
            this.labelCountStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCountStudent.AutoSize = true;
            this.labelCountStudent.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.labelCountStudent.Location = new System.Drawing.Point(899, 7);
            this.labelCountStudent.Name = "labelCountStudent";
            this.labelCountStudent.Size = new System.Drawing.Size(25, 17);
            this.labelCountStudent.TabIndex = 0;
            this.labelCountStudent.Text = "{?}";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(780, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Total Students:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(151, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Search:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(3)))), ((int)(((byte)(125)))));
            this.label7.Location = new System.Drawing.Point(6, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Search Student:";
            // 
            // pictureBoxSearch
            // 
            this.pictureBoxSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxSearch.Image = global::Attendance_management_system.Properties.Resources.icons8_search_50;
            this.pictureBoxSearch.Location = new System.Drawing.Point(405, 74);
            this.pictureBoxSearch.Name = "pictureBoxSearch";
            this.pictureBoxSearch.Size = new System.Drawing.Size(19, 26);
            this.pictureBoxSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSearch.TabIndex = 6;
            this.pictureBoxSearch.TabStop = false;
            this.pictureBoxSearch.MouseHover += new System.EventHandler(this.pictureBoxSearch_MouseHover);
            // 
            // tabPageUpdateAndDeleteStd
            // 
            this.tabPageUpdateAndDeleteStd.Controls.Add(this.radioButtonFemale1);
            this.tabPageUpdateAndDeleteStd.Controls.Add(this.radioButtonMale1);
            this.tabPageUpdateAndDeleteStd.Controls.Add(this.comboBoxSemester1);
            this.tabPageUpdateAndDeleteStd.Controls.Add(this.panel6);
            this.tabPageUpdateAndDeleteStd.Controls.Add(this.panel7);
            this.tabPageUpdateAndDeleteStd.Controls.Add(this.panel8);
            this.tabPageUpdateAndDeleteStd.Controls.Add(this.textBoxRollNum1);
            this.tabPageUpdateAndDeleteStd.Controls.Add(this.label9);
            this.tabPageUpdateAndDeleteStd.Controls.Add(this.textBoxName1);
            this.tabPageUpdateAndDeleteStd.Controls.Add(this.label10);
            this.tabPageUpdateAndDeleteStd.Controls.Add(this.label11);
            this.tabPageUpdateAndDeleteStd.Controls.Add(this.label12);
            this.tabPageUpdateAndDeleteStd.Controls.Add(this.buttonDelete);
            this.tabPageUpdateAndDeleteStd.Controls.Add(this.buttonUpdate);
            this.tabPageUpdateAndDeleteStd.Controls.Add(this.label13);
            this.tabPageUpdateAndDeleteStd.Location = new System.Drawing.Point(4, 4);
            this.tabPageUpdateAndDeleteStd.Name = "tabPageUpdateAndDeleteStd";
            this.tabPageUpdateAndDeleteStd.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUpdateAndDeleteStd.Size = new System.Drawing.Size(934, 471);
            this.tabPageUpdateAndDeleteStd.TabIndex = 2;
            this.tabPageUpdateAndDeleteStd.Text = "Update and Delete Student";
            this.tabPageUpdateAndDeleteStd.UseVisualStyleBackColor = true;
            this.tabPageUpdateAndDeleteStd.Enter += new System.EventHandler(this.tabPageUpdateAndDeleteStd_Enter);
            this.tabPageUpdateAndDeleteStd.Leave += new System.EventHandler(this.tabPageUpdateAndDeleteStd_Leave);
            // 
            // radioButtonFemale1
            // 
            this.radioButtonFemale1.AutoSize = true;
            this.radioButtonFemale1.Location = new System.Drawing.Point(627, 248);
            this.radioButtonFemale1.Name = "radioButtonFemale1";
            this.radioButtonFemale1.Size = new System.Drawing.Size(71, 21);
            this.radioButtonFemale1.TabIndex = 5;
            this.radioButtonFemale1.TabStop = true;
            this.radioButtonFemale1.Text = "female";
            this.radioButtonFemale1.UseVisualStyleBackColor = true;
            // 
            // radioButtonMale1
            // 
            this.radioButtonMale1.AutoSize = true;
            this.radioButtonMale1.Location = new System.Drawing.Point(627, 217);
            this.radioButtonMale1.Name = "radioButtonMale1";
            this.radioButtonMale1.Size = new System.Drawing.Size(59, 21);
            this.radioButtonMale1.TabIndex = 4;
            this.radioButtonMale1.TabStop = true;
            this.radioButtonMale1.Text = "male";
            this.radioButtonMale1.UseVisualStyleBackColor = true;
            // 
            // comboBoxSemester1
            // 
            this.comboBoxSemester1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSemester1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxSemester1.FormattingEnabled = true;
            this.comboBoxSemester1.Items.AddRange(new object[] {
            "--Select--"});
            this.comboBoxSemester1.Location = new System.Drawing.Point(112, 201);
            this.comboBoxSemester1.Name = "comboBoxSemester1";
            this.comboBoxSemester1.Size = new System.Drawing.Size(271, 25);
            this.comboBoxSemester1.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel6.BackColor = System.Drawing.Color.LightGray;
            this.panel6.Location = new System.Drawing.Point(554, 166);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(270, 2);
            this.panel6.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel7.BackColor = System.Drawing.Color.LightGray;
            this.panel7.Location = new System.Drawing.Point(113, 231);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(270, 2);
            this.panel7.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel8.BackColor = System.Drawing.Color.LightGray;
            this.panel8.Location = new System.Drawing.Point(112, 166);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(270, 2);
            this.panel8.TabIndex = 0;
            // 
            // textBoxRollNum1
            // 
            this.textBoxRollNum1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxRollNum1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRollNum1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.textBoxRollNum1.Location = new System.Drawing.Point(554, 139);
            this.textBoxRollNum1.Name = "textBoxRollNum1";
            this.textBoxRollNum1.Size = new System.Drawing.Size(270, 17);
            this.textBoxRollNum1.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(550, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Roll Number:";
            // 
            // textBoxName1
            // 
            this.textBoxName1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxName1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxName1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.textBoxName1.Location = new System.Drawing.Point(112, 139);
            this.textBoxName1.Name = "textBoxName1";
            this.textBoxName1.Size = new System.Drawing.Size(270, 17);
            this.textBoxName1.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(550, 217);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Gender";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(109, 178);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "Semester";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(109, 110);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 16);
            this.label12.TabIndex = 0;
            this.label12.Text = "Name:";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(3)))), ((int)(((byte)(125)))));
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(242, 291);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(114, 37);
            this.buttonDelete.TabIndex = 7;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(3)))), ((int)(((byte)(125)))));
            this.buttonUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUpdate.FlatAppearance.BorderSize = 0;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.ForeColor = System.Drawing.Color.White;
            this.buttonUpdate.Location = new System.Drawing.Point(112, 291);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(114, 37);
            this.buttonUpdate.TabIndex = 6;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(3)))), ((int)(((byte)(125)))));
            this.label13.Location = new System.Drawing.Point(3, 3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(220, 19);
            this.label13.TabIndex = 0;
            this.label13.Text = "Update and Delete Student:";
            // 
            // UserControlAddStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControlAddStudent);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControlAddStudents";
            this.Size = new System.Drawing.Size(942, 501);
            this.tabControlAddStudent.ResumeLayout(false);
            this.tabPageAddStudent.ResumeLayout(false);
            this.tabPageAddStudent.PerformLayout();
            this.tabPageSearchStudent.ResumeLayout(false);
            this.tabPageSearchStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearch)).EndInit();
            this.tabPageUpdateAndDeleteStd.ResumeLayout(false);
            this.tabPageUpdateAndDeleteStd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlAddStudent;
        private System.Windows.Forms.TabPage tabPageAddStudent;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxRollNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageSearchStudent;
        private System.Windows.Forms.DataGridView dataGridViewStudent;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.PictureBox pictureBoxSearch;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label labelCountStudent;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPageUpdateAndDeleteStd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.ComboBox comboBoxSemester;
        private System.Windows.Forms.ComboBox comboBoxSearchBy;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.RadioButton radioButtonFemale1;
        private System.Windows.Forms.RadioButton radioButtonMale1;
        private System.Windows.Forms.ComboBox comboBoxSemester1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox textBoxRollNum1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxName1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}
