namespace DeskTimeWindowsForms
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.getAll = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.depName = new System.Windows.Forms.TextBox();
            this.depId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(409, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(329, 150);
            this.dataGridView1.TabIndex = 30;
            // 
            // getAll
            // 
            this.getAll.Location = new System.Drawing.Point(498, 343);
            this.getAll.Name = "getAll";
            this.getAll.Size = new System.Drawing.Size(75, 23);
            this.getAll.TabIndex = 29;
            this.getAll.Text = "Get All";
            this.getAll.UseVisualStyleBackColor = true;
            this.getAll.Click += new System.EventHandler(this.getAll_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(392, 343);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 28;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(279, 343);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 27;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(170, 343);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 26;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(276, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 46);
            this.label3.TabIndex = 25;
            this.label3.Text = "Department";
            // 
            // depName
            // 
            this.depName.Location = new System.Drawing.Point(170, 251);
            this.depName.Name = "depName";
            this.depName.Size = new System.Drawing.Size(100, 22);
            this.depName.TabIndex = 24;
            // 
            // depId
            // 
            this.depId.Location = new System.Drawing.Point(170, 179);
            this.depId.Name = "depId";
            this.depId.Size = new System.Drawing.Size(100, 22);
            this.depId.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Deptname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Deptid";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.getAll);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.save);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.depName);
            this.Controls.Add(this.depId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button getAll;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox depName;
        private System.Windows.Forms.TextBox depId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

