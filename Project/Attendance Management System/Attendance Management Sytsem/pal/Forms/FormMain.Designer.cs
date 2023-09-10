
namespace Attendance_management_system.pal.Forms
{
    partial class FormMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonReg = new System.Windows.Forms.Button();
            this.buttonReport = new System.Windows.Forms.Button();
            this.buttonAddStud = new System.Windows.Forms.Button();
            this.buttonAddClass = new System.Windows.Forms.Button();
            this.buttonAttendance = new System.Windows.Forms.Button();
            this.buttonDash = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelSide = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelBack = new System.Windows.Forms.Panel();
            this.pictureBoxExpand = new System.Windows.Forms.PictureBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelExpand = new System.Windows.Forms.Panel();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonMin = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelRole = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timerDateAndTime = new System.Windows.Forms.Timer(this.components);
            this.userControlDashboard1 = new Attendance_management_system.pal.UserControlForms.UserControlDashboard();
            this.userControlAddClass1 = new Attendance_management_system.pal.UserControlForms.UserControlAddClass();
            this.userControlAddStudents1 = new Attendance_management_system.pal.UserControlForms.UserControlAddStudents();
            this.userControlRegister1 = new Attendance_management_system.pal.UserControlForms.UserControlRegister();
            this.userControlAttendance1 = new Attendance_management_system.pal.UserControlForms.UserControlAttendance();
            this.userControlreport1 = new Attendance_management_system.pal.UserControlForms.UserControlreport();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExpand)).BeginInit();
            this.panelTop.SuspendLayout();
            this.panelExpand.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(3)))), ((int)(((byte)(125)))));
            this.panel1.Controls.Add(this.buttonReg);
            this.panel1.Controls.Add(this.buttonReport);
            this.panel1.Controls.Add(this.buttonAddStud);
            this.panel1.Controls.Add(this.buttonAddClass);
            this.panel1.Controls.Add(this.buttonAttendance);
            this.panel1.Controls.Add(this.buttonDash);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 720);
            this.panel1.TabIndex = 0;
            // 
            // buttonReg
            // 
            this.buttonReg.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonReg.FlatAppearance.BorderSize = 0;
            this.buttonReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReg.ForeColor = System.Drawing.Color.White;
            this.buttonReg.Location = new System.Drawing.Point(8, 415);
            this.buttonReg.Name = "buttonReg";
            this.buttonReg.Size = new System.Drawing.Size(250, 47);
            this.buttonReg.TabIndex = 6;
            this.buttonReg.Text = "Register";
            this.buttonReg.UseVisualStyleBackColor = true;
            this.buttonReg.Click += new System.EventHandler(this.buttonReg_Click);
            // 
            // buttonReport
            // 
            this.buttonReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonReport.FlatAppearance.BorderSize = 0;
            this.buttonReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReport.ForeColor = System.Drawing.Color.White;
            this.buttonReport.Location = new System.Drawing.Point(8, 368);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Size = new System.Drawing.Size(250, 47);
            this.buttonReport.TabIndex = 5;
            this.buttonReport.Text = "Report";
            this.buttonReport.UseVisualStyleBackColor = true;
            this.buttonReport.Click += new System.EventHandler(this.buttonReport_Click);
            // 
            // buttonAddStud
            // 
            this.buttonAddStud.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAddStud.FlatAppearance.BorderSize = 0;
            this.buttonAddStud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddStud.ForeColor = System.Drawing.Color.White;
            this.buttonAddStud.Location = new System.Drawing.Point(8, 321);
            this.buttonAddStud.Name = "buttonAddStud";
            this.buttonAddStud.Size = new System.Drawing.Size(250, 47);
            this.buttonAddStud.TabIndex = 4;
            this.buttonAddStud.Text = "Add Students";
            this.buttonAddStud.UseVisualStyleBackColor = true;
            this.buttonAddStud.Click += new System.EventHandler(this.buttonAddStud_Click);
            // 
            // buttonAddClass
            // 
            this.buttonAddClass.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAddClass.FlatAppearance.BorderSize = 0;
            this.buttonAddClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddClass.ForeColor = System.Drawing.Color.White;
            this.buttonAddClass.Location = new System.Drawing.Point(8, 274);
            this.buttonAddClass.Name = "buttonAddClass";
            this.buttonAddClass.Size = new System.Drawing.Size(250, 47);
            this.buttonAddClass.TabIndex = 3;
            this.buttonAddClass.Text = "Add Class";
            this.buttonAddClass.UseVisualStyleBackColor = true;
            this.buttonAddClass.Click += new System.EventHandler(this.buttonAddClass_Click);
            // 
            // buttonAttendance
            // 
            this.buttonAttendance.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAttendance.FlatAppearance.BorderSize = 0;
            this.buttonAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAttendance.ForeColor = System.Drawing.Color.White;
            this.buttonAttendance.Location = new System.Drawing.Point(8, 227);
            this.buttonAttendance.Name = "buttonAttendance";
            this.buttonAttendance.Size = new System.Drawing.Size(250, 47);
            this.buttonAttendance.TabIndex = 2;
            this.buttonAttendance.Text = "Attendance";
            this.buttonAttendance.UseVisualStyleBackColor = true;
            this.buttonAttendance.Click += new System.EventHandler(this.buttonAttendance_Click);
            // 
            // buttonDash
            // 
            this.buttonDash.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDash.FlatAppearance.BorderSize = 0;
            this.buttonDash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDash.ForeColor = System.Drawing.Color.White;
            this.buttonDash.Location = new System.Drawing.Point(8, 180);
            this.buttonDash.Name = "buttonDash";
            this.buttonDash.Size = new System.Drawing.Size(250, 47);
            this.buttonDash.TabIndex = 1;
            this.buttonDash.Text = "DashBoard";
            this.buttonDash.UseVisualStyleBackColor = true;
            this.buttonDash.Click += new System.EventHandler(this.buttonDash_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panelSide);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 180);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(8, 540);
            this.panel4.TabIndex = 0;
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.Color.White;
            this.panelSide.Location = new System.Drawing.Point(0, 0);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(8, 47);
            this.panelSide.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(258, 180);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Attendance_management_system.Properties.Resources.graduate_user_icon;
            this.pictureBox1.Location = new System.Drawing.Point(48, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panelBack
            // 
            this.panelBack.Controls.Add(this.pictureBoxExpand);
            this.panelBack.Controls.Add(this.labelTime);
            this.panelBack.Controls.Add(this.panelTop);
            this.panelBack.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBack.Location = new System.Drawing.Point(258, 0);
            this.panelBack.Name = "panelBack";
            this.panelBack.Size = new System.Drawing.Size(942, 165);
            this.panelBack.TabIndex = 0;
            // 
            // pictureBoxExpand
            // 
            this.pictureBoxExpand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxExpand.Image = global::Attendance_management_system.Properties.Resources.menus;
            this.pictureBoxExpand.Location = new System.Drawing.Point(960, 40);
            this.pictureBoxExpand.Name = "pictureBoxExpand";
            this.pictureBoxExpand.Size = new System.Drawing.Size(27, 24);
            this.pictureBoxExpand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxExpand.TabIndex = 2;
            this.pictureBoxExpand.TabStop = false;
            this.pictureBoxExpand.Click += new System.EventHandler(this.pictureBoxExpand_Click);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.BackColor = System.Drawing.Color.White;
            this.labelTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(3)))), ((int)(((byte)(125)))));
            this.labelTime.Location = new System.Drawing.Point(24, 23);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(28, 19);
            this.labelTime.TabIndex = 0;
            this.labelTime.Text = "{?}";
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(3)))), ((int)(((byte)(125)))));
            this.panelTop.Controls.Add(this.panelExpand);
            this.panelTop.Controls.Add(this.labelRole);
            this.panelTop.Controls.Add(this.labelUsername);
            this.panelTop.Controls.Add(this.label4);
            this.panelTop.Controls.Add(this.label2);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelTop.Location = new System.Drawing.Point(0, 65);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(942, 100);
            this.panelTop.TabIndex = 0;
            // 
            // panelExpand
            // 
            this.panelExpand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelExpand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelExpand.Controls.Add(this.buttonLogout);
            this.panelExpand.Controls.Add(this.buttonMin);
            this.panelExpand.Controls.Add(this.panel3);
            this.panelExpand.Location = new System.Drawing.Point(709, -10);
            this.panelExpand.Name = "panelExpand";
            this.panelExpand.Size = new System.Drawing.Size(200, 107);
            this.panelExpand.TabIndex = 0;
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.White;
            this.buttonLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonLogout.FlatAppearance.BorderSize = 0;
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogout.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.buttonLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(3)))), ((int)(((byte)(125)))));
            this.buttonLogout.Location = new System.Drawing.Point(0, 53);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(198, 48);
            this.buttonLogout.TabIndex = 0;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonMin
            // 
            this.buttonMin.BackColor = System.Drawing.Color.White;
            this.buttonMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMin.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonMin.FlatAppearance.BorderSize = 0;
            this.buttonMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMin.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.buttonMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(3)))), ((int)(((byte)(125)))));
            this.buttonMin.Location = new System.Drawing.Point(0, 5);
            this.buttonMin.Name = "buttonMin";
            this.buttonMin.Size = new System.Drawing.Size(198, 48);
            this.buttonMin.TabIndex = 0;
            this.buttonMin.Text = "Minimize";
            this.buttonMin.UseVisualStyleBackColor = false;
            this.buttonMin.Click += new System.EventHandler(this.buttonMin_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(198, 5);
            this.panel3.TabIndex = 0;
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.ForeColor = System.Drawing.Color.White;
            this.labelRole.Location = new System.Drawing.Point(154, 57);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(28, 19);
            this.labelRole.TabIndex = 0;
            this.labelRole.Text = "{?}";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.ForeColor = System.Drawing.Color.White;
            this.labelUsername.Location = new System.Drawing.Point(154, 22);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(28, 19);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "{?}";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(50, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Role:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(50, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Welcome:";
            // 
            // timerDateAndTime
            // 
            this.timerDateAndTime.Tick += new System.EventHandler(this.timerDateAndTime_Tick);
            // 
            // userControlDashboard1
            // 
            this.userControlDashboard1.BackColor = System.Drawing.Color.White;
            this.userControlDashboard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlDashboard1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.userControlDashboard1.Location = new System.Drawing.Point(258, 165);
            this.userControlDashboard1.Margin = new System.Windows.Forms.Padding(4);
            this.userControlDashboard1.Name = "userControlDashboard1";
            this.userControlDashboard1.Size = new System.Drawing.Size(942, 555);
            this.userControlDashboard1.TabIndex = 1;
            // 
            // userControlAddClass1
            // 
            this.userControlAddClass1.BackColor = System.Drawing.Color.White;
            this.userControlAddClass1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlAddClass1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.userControlAddClass1.Location = new System.Drawing.Point(258, 165);
            this.userControlAddClass1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userControlAddClass1.Name = "userControlAddClass1";
            this.userControlAddClass1.Size = new System.Drawing.Size(942, 555);
            this.userControlAddClass1.TabIndex = 0;
            this.userControlAddClass1.Visible = false;
            // 
            // userControlAddStudents1
            // 
            this.userControlAddStudents1.BackColor = System.Drawing.Color.White;
            this.userControlAddStudents1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlAddStudents1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.userControlAddStudents1.Location = new System.Drawing.Point(258, 165);
            this.userControlAddStudents1.Margin = new System.Windows.Forms.Padding(4);
            this.userControlAddStudents1.Name = "userControlAddStudents1";
            this.userControlAddStudents1.Size = new System.Drawing.Size(942, 555);
            this.userControlAddStudents1.TabIndex = 0;
            this.userControlAddStudents1.Visible = false;
            // 
            // userControlRegister1
            // 
            this.userControlRegister1.AutoSize = true;
            this.userControlRegister1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlRegister1.Location = new System.Drawing.Point(258, 165);
            this.userControlRegister1.Margin = new System.Windows.Forms.Padding(6);
            this.userControlRegister1.Name = "userControlRegister1";
            this.userControlRegister1.Size = new System.Drawing.Size(942, 555);
            this.userControlRegister1.TabIndex = 0;
            this.userControlRegister1.Visible = false;
            this.userControlRegister1.Load += new System.EventHandler(this.userControlRegister1_Load);
            // 
            // userControlAttendance1
            // 
            this.userControlAttendance1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlAttendance1.Font = new System.Drawing.Font("Century Gothic", 9.8F);
            this.userControlAttendance1.Location = new System.Drawing.Point(258, 165);
            this.userControlAttendance1.Margin = new System.Windows.Forms.Padding(4);
            this.userControlAttendance1.Name = "userControlAttendance1";
            this.userControlAttendance1.Size = new System.Drawing.Size(942, 555);
            this.userControlAttendance1.TabIndex = 0;
            this.userControlAttendance1.Visible = false;
            // 
            // userControlreport1
            // 
            this.userControlreport1.BackColor = System.Drawing.Color.White;
            this.userControlreport1.Font = new System.Drawing.Font("Century Gothic", 9.8F);
            this.userControlreport1.Location = new System.Drawing.Point(258, 165);
            this.userControlreport1.Margin = new System.Windows.Forms.Padding(4);
            this.userControlreport1.Name = "userControlreport1";
            this.userControlreport1.Size = new System.Drawing.Size(999, 555);
            this.userControlreport1.TabIndex = 0;
            this.userControlreport1.Load += new System.EventHandler(this.userControlreport1_Load);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.userControlreport1);
            this.Controls.Add(this.userControlAttendance1);
            this.Controls.Add(this.userControlRegister1);
            this.Controls.Add(this.userControlAddStudents1);
            this.Controls.Add(this.userControlAddClass1);
            this.Controls.Add(this.userControlDashboard1);
            this.Controls.Add(this.panelBack);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Attendance Management System";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelBack.ResumeLayout(false);
            this.panelBack.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExpand)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelExpand.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelBack;
        private System.Windows.Forms.PictureBox pictureBoxExpand;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelExpand;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonMin;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonReg;
        private System.Windows.Forms.Button buttonReport;
        private System.Windows.Forms.Button buttonAddStud;
        private System.Windows.Forms.Button buttonAddClass;
        private System.Windows.Forms.Button buttonAttendance;
        private System.Windows.Forms.Button buttonDash;
        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Timer timerDateAndTime;
        private UserControlForms.UserControlDashboard userControlDashboard1;
        private UserControlForms.UserControlAddClass userControlAddClass1;
        private UserControlForms.UserControlAddStudents userControlAddStudents1;
        private UserControlForms.UserControlRegister userControlRegister1;
        private UserControlForms.UserControlAttendance userControlAttendance1;
        private UserControlForms.UserControlreport userControlreport1;
    }
}