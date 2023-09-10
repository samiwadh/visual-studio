
namespace Attendance_management_system.pal.UserControlForms
{
    partial class UserControlAddClass
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
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tabControlAddClass = new System.Windows.Forms.TabControl();
            this.tabPageAddClass = new System.Windows.Forms.TabPage();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxHmStudents = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.textBoxSemester = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageSearchClass = new System.Windows.Forms.TabPage();
            this.dataGridViewClass = new System.Windows.Forms.DataGridView();
            this.classIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classSemesterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.attendance_MGSDataSet = new Attendance_management_system.Attendance_MGSDataSet();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.pictureBoxSearch = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.labelCount = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPageUpdateAndDelete = new System.Windows.Forms.TabPage();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.textBoxHmStudents1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxYear1 = new System.Windows.Forms.TextBox();
            this.textBoxSemester1 = new System.Windows.Forms.TextBox();
            this.textBoxName1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.class_TableTableAdapter = new Attendance_management_system.Attendance_MGSDataSetTableAdapters.Class_TableTableAdapter();
            this.tabControlAddClass.SuspendLayout();
            this.tabPageAddClass.SuspendLayout();
            this.tabPageSearchClass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendance_MGSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearch)).BeginInit();
            this.tabPageUpdateAndDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlAddClass
            // 
            this.tabControlAddClass.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlAddClass.Controls.Add(this.tabPageAddClass);
            this.tabControlAddClass.Controls.Add(this.tabPageSearchClass);
            this.tabControlAddClass.Controls.Add(this.tabPageUpdateAndDelete);
            this.tabControlAddClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlAddClass.Location = new System.Drawing.Point(0, 0);
            this.tabControlAddClass.Name = "tabControlAddClass";
            this.tabControlAddClass.SelectedIndex = 0;
            this.tabControlAddClass.Size = new System.Drawing.Size(942, 501);
            this.tabControlAddClass.TabIndex = 0;
            this.tabControlAddClass.Enter += new System.EventHandler(this.tabControlAddClass_Enter);
            // 
            // tabPageAddClass
            // 
            this.tabPageAddClass.Controls.Add(this.buttonAdd);
            this.tabPageAddClass.Controls.Add(this.panel2);
            this.tabPageAddClass.Controls.Add(this.panel4);
            this.tabPageAddClass.Controls.Add(this.panel3);
            this.tabPageAddClass.Controls.Add(this.panel1);
            this.tabPageAddClass.Controls.Add(this.textBoxHmStudents);
            this.tabPageAddClass.Controls.Add(this.label3);
            this.tabPageAddClass.Controls.Add(this.textBoxYear);
            this.tabPageAddClass.Controls.Add(this.textBoxSemester);
            this.tabPageAddClass.Controls.Add(this.textBoxName);
            this.tabPageAddClass.Controls.Add(this.label5);
            this.tabPageAddClass.Controls.Add(this.label4);
            this.tabPageAddClass.Controls.Add(this.label2);
            this.tabPageAddClass.Controls.Add(this.label1);
            this.tabPageAddClass.Location = new System.Drawing.Point(4, 4);
            this.tabPageAddClass.Name = "tabPageAddClass";
            this.tabPageAddClass.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddClass.Size = new System.Drawing.Size(934, 471);
            this.tabPageAddClass.TabIndex = 0;
            this.tabPageAddClass.Text = "Add Class";
            this.tabPageAddClass.UseVisualStyleBackColor = true;
            this.tabPageAddClass.Enter += new System.EventHandler(this.tabPageAddClass_Enter);
            this.tabPageAddClass.Leave += new System.EventHandler(this.tabPageAddClass_Leave);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(3)))), ((int)(((byte)(125)))));
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(115, 291);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(114, 37);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Location = new System.Drawing.Point(557, 178);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(270, 2);
            this.panel2.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.BackColor = System.Drawing.Color.LightGray;
            this.panel4.Location = new System.Drawing.Point(557, 243);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(270, 2);
            this.panel4.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Location = new System.Drawing.Point(116, 243);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(270, 2);
            this.panel3.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Location = new System.Drawing.Point(115, 178);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 2);
            this.panel1.TabIndex = 0;
            // 
            // textBoxHmStudents
            // 
            this.textBoxHmStudents.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxHmStudents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxHmStudents.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.textBoxHmStudents.Location = new System.Drawing.Point(557, 151);
            this.textBoxHmStudents.Name = "textBoxHmStudents";
            this.textBoxHmStudents.Size = new System.Drawing.Size(270, 17);
            this.textBoxHmStudents.TabIndex = 2;
            this.textBoxHmStudents.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxHmStudents_KeyPress);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(553, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "How many Students?";
            // 
            // textBoxYear
            // 
            this.textBoxYear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxYear.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxYear.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.textBoxYear.Location = new System.Drawing.Point(556, 219);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(270, 17);
            this.textBoxYear.TabIndex = 4;
            this.textBoxYear.Enter += new System.EventHandler(this.textBoxYear_Enter);
            this.textBoxYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxYear_KeyPress);
            // 
            // textBoxSemester
            // 
            this.textBoxSemester.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxSemester.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSemester.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.textBoxSemester.Location = new System.Drawing.Point(115, 219);
            this.textBoxSemester.Name = "textBoxSemester";
            this.textBoxSemester.Size = new System.Drawing.Size(270, 17);
            this.textBoxSemester.TabIndex = 3;
            this.textBoxSemester.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSemester_KeyPress);
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxName.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.textBoxName.Location = new System.Drawing.Point(115, 151);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(270, 17);
            this.textBoxName.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(553, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Year";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(112, 190);
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
            this.label2.Location = new System.Drawing.Point(112, 122);
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
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Class:";
            // 
            // tabPageSearchClass
            // 
            this.tabPageSearchClass.Controls.Add(this.dataGridViewClass);
            this.tabPageSearchClass.Controls.Add(this.textBoxSearch);
            this.tabPageSearchClass.Controls.Add(this.pictureBoxSearch);
            this.tabPageSearchClass.Controls.Add(this.panel5);
            this.tabPageSearchClass.Controls.Add(this.labelCount);
            this.tabPageSearchClass.Controls.Add(this.label8);
            this.tabPageSearchClass.Controls.Add(this.label6);
            this.tabPageSearchClass.Controls.Add(this.label7);
            this.tabPageSearchClass.Location = new System.Drawing.Point(4, 4);
            this.tabPageSearchClass.Name = "tabPageSearchClass";
            this.tabPageSearchClass.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearchClass.Size = new System.Drawing.Size(934, 471);
            this.tabPageSearchClass.TabIndex = 1;
            this.tabPageSearchClass.Text = "Search Class";
            this.tabPageSearchClass.UseVisualStyleBackColor = true;
            this.tabPageSearchClass.Enter += new System.EventHandler(this.tabPageSearchClass_Enter);
            // 
            // dataGridViewClass
            // 
            this.dataGridViewClass.AllowUserToAddRows = false;
            this.dataGridViewClass.AllowUserToDeleteRows = false;
            this.dataGridViewClass.AllowUserToResizeColumns = false;
            this.dataGridViewClass.AllowUserToResizeRows = false;
            this.dataGridViewClass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewClass.AutoGenerateColumns = false;
            this.dataGridViewClass.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewClass.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewClass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewClass.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClass.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.classIDDataGridViewTextBoxColumn,
            this.classNameDataGridViewTextBoxColumn,
            this.classTotalDataGridViewTextBoxColumn,
            this.classSemesterDataGridViewTextBoxColumn,
            this.classYearDataGridViewTextBoxColumn});
            this.dataGridViewClass.DataSource = this.classTableBindingSource;
            this.dataGridViewClass.Location = new System.Drawing.Point(31, 131);
            this.dataGridViewClass.Name = "dataGridViewClass";
            this.dataGridViewClass.ReadOnly = true;
            this.dataGridViewClass.RowHeadersWidth = 51;
            this.dataGridViewClass.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewClass.RowTemplate.Height = 24;
            this.dataGridViewClass.ShowCellErrors = false;
            this.dataGridViewClass.ShowEditingIcon = false;
            this.dataGridViewClass.ShowRowErrors = false;
            this.dataGridViewClass.Size = new System.Drawing.Size(872, 318);
            this.dataGridViewClass.TabIndex = 0;
            this.dataGridViewClass.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClass_CellClick);
            // 
            // classIDDataGridViewTextBoxColumn
            // 
            this.classIDDataGridViewTextBoxColumn.DataPropertyName = "Class_ID";
            this.classIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.classIDDataGridViewTextBoxColumn.Name = "classIDDataGridViewTextBoxColumn";
            this.classIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // classNameDataGridViewTextBoxColumn
            // 
            this.classNameDataGridViewTextBoxColumn.DataPropertyName = "Class_Name";
            this.classNameDataGridViewTextBoxColumn.HeaderText = "Class Name";
            this.classNameDataGridViewTextBoxColumn.Name = "classNameDataGridViewTextBoxColumn";
            this.classNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // classTotalDataGridViewTextBoxColumn
            // 
            this.classTotalDataGridViewTextBoxColumn.DataPropertyName = "Class_Total";
            this.classTotalDataGridViewTextBoxColumn.HeaderText = "Total No Of Students";
            this.classTotalDataGridViewTextBoxColumn.Name = "classTotalDataGridViewTextBoxColumn";
            this.classTotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // classSemesterDataGridViewTextBoxColumn
            // 
            this.classSemesterDataGridViewTextBoxColumn.DataPropertyName = "Class_Semester";
            this.classSemesterDataGridViewTextBoxColumn.HeaderText = "Semester";
            this.classSemesterDataGridViewTextBoxColumn.Name = "classSemesterDataGridViewTextBoxColumn";
            this.classSemesterDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // classYearDataGridViewTextBoxColumn
            // 
            this.classYearDataGridViewTextBoxColumn.DataPropertyName = "Class_Year";
            this.classYearDataGridViewTextBoxColumn.HeaderText = "Year";
            this.classYearDataGridViewTextBoxColumn.Name = "classYearDataGridViewTextBoxColumn";
            this.classYearDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // classTableBindingSource
            // 
            this.classTableBindingSource.DataMember = "Class_Table";
            this.classTableBindingSource.DataSource = this.attendance_MGSDataSet;
            // 
            // attendance_MGSDataSet
            // 
            this.attendance_MGSDataSet.DataSetName = "Attendance_MGSDataSet";
            this.attendance_MGSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightGray;
            this.panel5.Location = new System.Drawing.Point(155, 109);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(270, 2);
            this.panel5.TabIndex = 0;
            // 
            // labelCount
            // 
            this.labelCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCount.AutoSize = true;
            this.labelCount.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.labelCount.Location = new System.Drawing.Point(819, 50);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(25, 17);
            this.labelCount.TabIndex = 0;
            this.labelCount.Text = "{?}";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(700, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Total Classes:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(151, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(3)))), ((int)(((byte)(125)))));
            this.label7.Location = new System.Drawing.Point(6, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Search Class:";
            // 
            // tabPageUpdateAndDelete
            // 
            this.tabPageUpdateAndDelete.Controls.Add(this.buttonDelete);
            this.tabPageUpdateAndDelete.Controls.Add(this.buttonUpdate);
            this.tabPageUpdateAndDelete.Controls.Add(this.panel6);
            this.tabPageUpdateAndDelete.Controls.Add(this.panel7);
            this.tabPageUpdateAndDelete.Controls.Add(this.panel8);
            this.tabPageUpdateAndDelete.Controls.Add(this.panel9);
            this.tabPageUpdateAndDelete.Controls.Add(this.textBoxHmStudents1);
            this.tabPageUpdateAndDelete.Controls.Add(this.label9);
            this.tabPageUpdateAndDelete.Controls.Add(this.textBoxYear1);
            this.tabPageUpdateAndDelete.Controls.Add(this.textBoxSemester1);
            this.tabPageUpdateAndDelete.Controls.Add(this.textBoxName1);
            this.tabPageUpdateAndDelete.Controls.Add(this.label10);
            this.tabPageUpdateAndDelete.Controls.Add(this.label11);
            this.tabPageUpdateAndDelete.Controls.Add(this.label12);
            this.tabPageUpdateAndDelete.Controls.Add(this.label13);
            this.tabPageUpdateAndDelete.Location = new System.Drawing.Point(4, 4);
            this.tabPageUpdateAndDelete.Name = "tabPageUpdateAndDelete";
            this.tabPageUpdateAndDelete.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUpdateAndDelete.Size = new System.Drawing.Size(934, 471);
            this.tabPageUpdateAndDelete.TabIndex = 2;
            this.tabPageUpdateAndDelete.Text = "Update and Delete Class";
            this.tabPageUpdateAndDelete.UseVisualStyleBackColor = true;
            this.tabPageUpdateAndDelete.Leave += new System.EventHandler(this.tabPageUpdateAndDelete_Leave);
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
            this.buttonDelete.TabIndex = 6;
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
            this.buttonUpdate.TabIndex = 5;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel6.BackColor = System.Drawing.Color.LightGray;
            this.panel6.Location = new System.Drawing.Point(554, 178);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(270, 2);
            this.panel6.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel7.BackColor = System.Drawing.Color.LightGray;
            this.panel7.Location = new System.Drawing.Point(554, 243);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(270, 2);
            this.panel7.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel8.BackColor = System.Drawing.Color.LightGray;
            this.panel8.Location = new System.Drawing.Point(113, 243);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(270, 2);
            this.panel8.TabIndex = 0;
            // 
            // panel9
            // 
            this.panel9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel9.BackColor = System.Drawing.Color.LightGray;
            this.panel9.Location = new System.Drawing.Point(112, 178);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(270, 2);
            this.panel9.TabIndex = 0;
            // 
            // textBoxHmStudents1
            // 
            this.textBoxHmStudents1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxHmStudents1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxHmStudents1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.textBoxHmStudents1.Location = new System.Drawing.Point(554, 151);
            this.textBoxHmStudents1.Name = "textBoxHmStudents1";
            this.textBoxHmStudents1.Size = new System.Drawing.Size(270, 17);
            this.textBoxHmStudents1.TabIndex = 2;
            this.textBoxHmStudents1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxHmStudents1_KeyPress);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(550, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "How many Students?";
            // 
            // textBoxYear1
            // 
            this.textBoxYear1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxYear1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxYear1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.textBoxYear1.Location = new System.Drawing.Point(553, 219);
            this.textBoxYear1.Name = "textBoxYear1";
            this.textBoxYear1.Size = new System.Drawing.Size(270, 17);
            this.textBoxYear1.TabIndex = 4;
            this.textBoxYear1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxYear1_KeyPress);
            // 
            // textBoxSemester1
            // 
            this.textBoxSemester1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxSemester1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSemester1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.textBoxSemester1.Location = new System.Drawing.Point(112, 219);
            this.textBoxSemester1.Name = "textBoxSemester1";
            this.textBoxSemester1.Size = new System.Drawing.Size(270, 17);
            this.textBoxSemester1.TabIndex = 3;
            this.textBoxSemester1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSemester1_KeyPress);
            // 
            // textBoxName1
            // 
            this.textBoxName1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxName1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxName1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.textBoxName1.Location = new System.Drawing.Point(112, 151);
            this.textBoxName1.Name = "textBoxName1";
            this.textBoxName1.Size = new System.Drawing.Size(270, 17);
            this.textBoxName1.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(550, 190);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Year";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(109, 190);
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
            this.label12.Location = new System.Drawing.Point(109, 122);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 16);
            this.label12.TabIndex = 0;
            this.label12.Text = "Name:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(3)))), ((int)(((byte)(125)))));
            this.label13.Location = new System.Drawing.Point(3, 3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(202, 19);
            this.label13.TabIndex = 0;
            this.label13.Text = "Update and Delete Class:";
            // 
            // class_TableTableAdapter
            // 
            this.class_TableTableAdapter.ClearBeforeFill = true;
            // 
            // UserControlAddClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControlAddClass);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UserControlAddClass";
            this.Size = new System.Drawing.Size(942, 501);
            this.tabControlAddClass.ResumeLayout(false);
            this.tabPageAddClass.ResumeLayout(false);
            this.tabPageAddClass.PerformLayout();
            this.tabPageSearchClass.ResumeLayout(false);
            this.tabPageSearchClass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendance_MGSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearch)).EndInit();
            this.tabPageUpdateAndDelete.ResumeLayout(false);
            this.tabPageUpdateAndDelete.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TabControl tabControlAddClass;
        private System.Windows.Forms.TabPage tabPageAddClass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageSearchClass;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxHmStudents;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSemester;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBoxSearch;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridViewClass;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPageUpdateAndDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox textBoxHmStudents1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxYear1;
        private System.Windows.Forms.TextBox textBoxSemester1;
        private System.Windows.Forms.TextBox textBoxName1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.BindingSource classTableBindingSource;
        private Attendance_MGSDataSet attendance_MGSDataSet;
        private Attendance_MGSDataSetTableAdapters.Class_TableTableAdapter class_TableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn classIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classSemesterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classYearDataGridViewTextBoxColumn;
    }
}
