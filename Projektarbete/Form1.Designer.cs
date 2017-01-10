namespace Projektarbete
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.salaryBox = new System.Windows.Forms.NumericUpDown();
            this.onPaLeCheckbox = new System.Windows.Forms.CheckBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.createEmployeeButton = new System.Windows.Forms.Button();
            this.dateBox = new System.Windows.Forms.DateTimePicker();
            this.departmentBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.employeesList = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.employeesDepartmentList = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.departmentsList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salaryBox)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(79, 160);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1051, 823);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage1.Controls.Add(this.salaryBox);
            this.tabPage1.Controls.Add(this.onPaLeCheckbox);
            this.tabPage1.Controls.Add(this.deleteButton);
            this.tabPage1.Controls.Add(this.saveButton);
            this.tabPage1.Controls.Add(this.createEmployeeButton);
            this.tabPage1.Controls.Add(this.dateBox);
            this.tabPage1.Controls.Add(this.departmentBox);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.emailBox);
            this.tabPage1.Controls.Add(this.nameBox);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.employeesList);
            this.tabPage1.Location = new System.Drawing.Point(8, 46);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1035, 769);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "   Employees   ";
            // 
            // salaryBox
            // 
            this.salaryBox.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.salaryBox.Location = new System.Drawing.Point(441, 370);
            this.salaryBox.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.salaryBox.Name = "salaryBox";
            this.salaryBox.Size = new System.Drawing.Size(530, 40);
            this.salaryBox.TabIndex = 17;
            // 
            // onPaLeCheckbox
            // 
            this.onPaLeCheckbox.AutoSize = true;
            this.onPaLeCheckbox.Location = new System.Drawing.Point(441, 570);
            this.onPaLeCheckbox.Name = "onPaLeCheckbox";
            this.onPaLeCheckbox.Size = new System.Drawing.Size(253, 36);
            this.onPaLeCheckbox.TabIndex = 16;
            this.onPaLeCheckbox.Text = "On Parental Leave?";
            this.onPaLeCheckbox.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.White;
            this.deleteButton.ForeColor = System.Drawing.Color.Black;
            this.deleteButton.Location = new System.Drawing.Point(771, 670);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(200, 50);
            this.deleteButton.TabIndex = 15;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.White;
            this.saveButton.ForeColor = System.Drawing.Color.Black;
            this.saveButton.Location = new System.Drawing.Point(547, 670);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(200, 50);
            this.saveButton.TabIndex = 14;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // createEmployeeButton
            // 
            this.createEmployeeButton.BackColor = System.Drawing.Color.White;
            this.createEmployeeButton.ForeColor = System.Drawing.Color.Black;
            this.createEmployeeButton.Location = new System.Drawing.Point(55, 670);
            this.createEmployeeButton.Name = "createEmployeeButton";
            this.createEmployeeButton.Size = new System.Drawing.Size(320, 50);
            this.createEmployeeButton.TabIndex = 13;
            this.createEmployeeButton.Text = "Create Employee";
            this.createEmployeeButton.UseVisualStyleBackColor = false;
            this.createEmployeeButton.Click += new System.EventHandler(this.createEmployeeButton_Click);
            // 
            // dateBox
            // 
            this.dateBox.Location = new System.Drawing.Point(441, 270);
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(530, 40);
            this.dateBox.TabIndex = 8;
            // 
            // departmentBox
            // 
            this.departmentBox.FormattingEnabled = true;
            this.departmentBox.Location = new System.Drawing.Point(441, 470);
            this.departmentBox.Name = "departmentBox";
            this.departmentBox.Size = new System.Drawing.Size(530, 40);
            this.departmentBox.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(435, 435);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 32);
            this.label7.TabIndex = 11;
            this.label7.Text = "Department";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(435, 335);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 32);
            this.label6.TabIndex = 9;
            this.label6.Text = "Salary";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(435, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 32);
            this.label5.TabIndex = 7;
            this.label5.Text = "Date of Birth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(435, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 32);
            this.label4.TabIndex = 5;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(435, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name";
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(441, 170);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(530, 40);
            this.emailBox.TabIndex = 6;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(441, 70);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(530, 40);
            this.nameBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Employee";
            // 
            // employeesList
            // 
            this.employeesList.FormattingEnabled = true;
            this.employeesList.ItemHeight = 32;
            this.employeesList.Location = new System.Drawing.Point(55, 70);
            this.employeesList.Name = "employeesList";
            this.employeesList.Size = new System.Drawing.Size(320, 548);
            this.employeesList.TabIndex = 2;
            this.employeesList.SelectedIndexChanged += new System.EventHandler(this.employeesList_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.employeesDepartmentList);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.departmentsList);
            this.tabPage2.Location = new System.Drawing.Point(8, 46);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1035, 769);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "   Departments   ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(434, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 32);
            this.label9.TabIndex = 3;
            this.label9.Text = "Employees";
            // 
            // employeesDepartmentList
            // 
            this.employeesDepartmentList.FormattingEnabled = true;
            this.employeesDepartmentList.ItemHeight = 32;
            this.employeesDepartmentList.Location = new System.Drawing.Point(440, 70);
            this.employeesDepartmentList.Name = "employeesDepartmentList";
            this.employeesDepartmentList.Size = new System.Drawing.Size(530, 612);
            this.employeesDepartmentList.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(211, 32);
            this.label8.TabIndex = 1;
            this.label8.Text = "Select Department";
            // 
            // departmentsList
            // 
            this.departmentsList.FormattingEnabled = true;
            this.departmentsList.ItemHeight = 32;
            this.departmentsList.Location = new System.Drawing.Point(55, 70);
            this.departmentsList.Name = "departmentsList";
            this.departmentsList.Size = new System.Drawing.Size(320, 612);
            this.departmentsList.TabIndex = 2;
            this.departmentsList.SelectedIndexChanged += new System.EventHandler(this.departmentsList_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(65, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1058, 129);
            this.label1.TabIndex = 1;
            this.label1.Text = "Personnel Management";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1293, 1543);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personnel Management v1.0";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salaryBox)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox employeesList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox departmentBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox departmentsList;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox employeesDepartmentList;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button createEmployeeButton;
        private System.Windows.Forms.CheckBox onPaLeCheckbox;
        private System.Windows.Forms.NumericUpDown salaryBox;
    }
}

