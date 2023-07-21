namespace DeskTimeWindowsForms
{
    partial class Form2
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
            this.password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.getAll = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.TextBox();
            this.salary = new System.Windows.Forms.TextBox();
            this.emp_Name = new System.Windows.Forms.TextBox();
            this.emp_Id = new System.Windows.Forms.TextBox();
            this.gender1 = new System.Windows.Forms.Label();
            this.salary1 = new System.Windows.Forms.Label();
            this.empName = new System.Windows.Forms.Label();
            this.empId = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(179, 272);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(100, 22);
            this.password.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 37;
            this.label2.Text = "PassWord";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(410, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(344, 198);
            this.dataGridView1.TabIndex = 36;
            // 
            // getAll
            // 
            this.getAll.Location = new System.Drawing.Point(507, 389);
            this.getAll.Name = "getAll";
            this.getAll.Size = new System.Drawing.Size(75, 23);
            this.getAll.TabIndex = 35;
            this.getAll.Text = "Get All";
            this.getAll.UseVisualStyleBackColor = true;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(401, 389);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 34;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(288, 389);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 33;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(179, 389);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 32;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(261, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 51);
            this.label1.TabIndex = 31;
            this.label1.Text = "Employee";
            // 
            // gender
            // 
            this.gender.Location = new System.Drawing.Point(179, 178);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(100, 22);
            this.gender.TabIndex = 29;
            // 
            // salary
            // 
            this.salary.Location = new System.Drawing.Point(180, 330);
            this.salary.Name = "salary";
            this.salary.Size = new System.Drawing.Size(100, 22);
            this.salary.TabIndex = 28;
            // 
            // emp_Name
            // 
            this.emp_Name.Location = new System.Drawing.Point(180, 132);
            this.emp_Name.Name = "emp_Name";
            this.emp_Name.Size = new System.Drawing.Size(100, 22);
            this.emp_Name.TabIndex = 27;
            // 
            // emp_Id
            // 
            this.emp_Id.Location = new System.Drawing.Point(179, 78);
            this.emp_Id.Name = "emp_Id";
            this.emp_Id.Size = new System.Drawing.Size(100, 22);
            this.emp_Id.TabIndex = 26;
            // 
            // gender1
            // 
            this.gender1.AutoSize = true;
            this.gender1.Location = new System.Drawing.Point(74, 178);
            this.gender1.Name = "gender1";
            this.gender1.Size = new System.Drawing.Size(52, 16);
            this.gender1.TabIndex = 25;
            this.gender1.Text = "Gender";
            // 
            // salary1
            // 
            this.salary1.AutoSize = true;
            this.salary1.Location = new System.Drawing.Point(74, 333);
            this.salary1.Name = "salary1";
            this.salary1.Size = new System.Drawing.Size(46, 16);
            this.salary1.TabIndex = 24;
            this.salary1.Text = "Salary";
            // 
            // empName
            // 
            this.empName.AutoSize = true;
            this.empName.Location = new System.Drawing.Point(74, 132);
            this.empName.Name = "empName";
            this.empName.Size = new System.Drawing.Size(69, 16);
            this.empName.TabIndex = 23;
            this.empName.Text = "Empname";
            // 
            // empId
            // 
            this.empId.AutoSize = true;
            this.empId.Location = new System.Drawing.Point(74, 81);
            this.empId.Name = "empId";
            this.empId.Size = new System.Drawing.Size(46, 16);
            this.empId.TabIndex = 21;
            this.empId.Text = "Empid";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 39;
            this.label3.Text = "UserName";
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(179, 223);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(100, 22);
            this.userName.TabIndex = 40;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.getAll);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.save);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.salary);
            this.Controls.Add(this.emp_Name);
            this.Controls.Add(this.emp_Id);
            this.Controls.Add(this.gender1);
            this.Controls.Add(this.salary1);
            this.Controls.Add(this.empName);
            this.Controls.Add(this.empId);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button getAll;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox gender;
        private System.Windows.Forms.TextBox salary;
        private System.Windows.Forms.TextBox emp_Name;
        private System.Windows.Forms.TextBox emp_Id;
        private System.Windows.Forms.Label gender1;
        private System.Windows.Forms.Label salary1;
        private System.Windows.Forms.Label empName;
        private System.Windows.Forms.Label empId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox userName;
    }
}