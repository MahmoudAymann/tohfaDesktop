namespace Tohfa
{
    partial class Department
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.buttonEditApprove = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonLoad_Dept = new System.Windows.Forms.Button();
            this.buttonDelete_Dept = new System.Windows.Forms.Button();
            this.buttonAdd_Dept = new System.Windows.Forms.Button();
            this.buttonNew_Dept = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.buttonLoad_Dept);
            this.groupBox1.Controls.Add(this.buttonDelete_Dept);
            this.groupBox1.Controls.Add(this.buttonAdd_Dept);
            this.groupBox1.Controls.Add(this.buttonNew_Dept);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(140, 430);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.buttonEditApprove);
            this.groupBox5.Controls.Add(this.buttonEdit);
            this.groupBox5.Location = new System.Drawing.Point(6, 239);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(128, 114);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "التعديل";
            // 
            // buttonEditApprove
            // 
            this.buttonEditApprove.BackColor = System.Drawing.Color.Green;
            this.buttonEditApprove.Enabled = false;
            this.buttonEditApprove.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditApprove.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEditApprove.Location = new System.Drawing.Point(6, 79);
            this.buttonEditApprove.Name = "buttonEditApprove";
            this.buttonEditApprove.Size = new System.Drawing.Size(116, 27);
            this.buttonEditApprove.TabIndex = 20;
            this.buttonEditApprove.Text = "تنفيذ";
            this.buttonEditApprove.UseVisualStyleBackColor = false;
            this.buttonEditApprove.Click += new System.EventHandler(this.buttonEditApprove_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Image = global::Tohfa.Properties.Resources.if_edit;
            this.buttonEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonEdit.Location = new System.Drawing.Point(6, 19);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(116, 57);
            this.buttonEdit.TabIndex = 6;
            this.buttonEdit.Text = "تعديل";
            this.buttonEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonLoad_Dept
            // 
            this.buttonLoad_Dept.Image = global::Tohfa.Properties.Resources.if_view_refreshs;
            this.buttonLoad_Dept.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonLoad_Dept.Location = new System.Drawing.Point(6, 359);
            this.buttonLoad_Dept.Name = "buttonLoad_Dept";
            this.buttonLoad_Dept.Size = new System.Drawing.Size(128, 57);
            this.buttonLoad_Dept.TabIndex = 5;
            this.buttonLoad_Dept.Text = "تحديث";
            this.buttonLoad_Dept.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonLoad_Dept.UseVisualStyleBackColor = true;
            this.buttonLoad_Dept.Click += new System.EventHandler(this.buttonLoad_Dept_Click);
            // 
            // buttonDelete_Dept
            // 
            this.buttonDelete_Dept.Image = global::Tohfa.Properties.Resources.if_delete;
            this.buttonDelete_Dept.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonDelete_Dept.Location = new System.Drawing.Point(6, 176);
            this.buttonDelete_Dept.Name = "buttonDelete_Dept";
            this.buttonDelete_Dept.Size = new System.Drawing.Size(128, 57);
            this.buttonDelete_Dept.TabIndex = 3;
            this.buttonDelete_Dept.Text = "حذف";
            this.buttonDelete_Dept.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonDelete_Dept.UseVisualStyleBackColor = true;
            this.buttonDelete_Dept.Click += new System.EventHandler(this.buttonDelete_Dept_Click);
            // 
            // buttonAdd_Dept
            // 
            this.buttonAdd_Dept.Image = global::Tohfa.Properties.Resources.if_save;
            this.buttonAdd_Dept.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonAdd_Dept.Location = new System.Drawing.Point(6, 117);
            this.buttonAdd_Dept.Name = "buttonAdd_Dept";
            this.buttonAdd_Dept.Size = new System.Drawing.Size(128, 57);
            this.buttonAdd_Dept.TabIndex = 1;
            this.buttonAdd_Dept.Text = "إضافة";
            this.buttonAdd_Dept.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAdd_Dept.UseVisualStyleBackColor = true;
            this.buttonAdd_Dept.Click += new System.EventHandler(this.buttonAdd_Dept_Click);
            // 
            // buttonNew_Dept
            // 
            this.buttonNew_Dept.Image = global::Tohfa.Properties.Resources.if_plus_add;
            this.buttonNew_Dept.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonNew_Dept.Location = new System.Drawing.Point(6, 13);
            this.buttonNew_Dept.Name = "buttonNew_Dept";
            this.buttonNew_Dept.Size = new System.Drawing.Size(128, 70);
            this.buttonNew_Dept.TabIndex = 0;
            this.buttonNew_Dept.Text = "جديد";
            this.buttonNew_Dept.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonNew_Dept.UseVisualStyleBackColor = true;
            this.buttonNew_Dept.Click += new System.EventHandler(this.buttonNew_Dept_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxName);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(140, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(449, 63);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Visible = false;
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(85, 19);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(263, 26);
            this.textBoxName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(354, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم القسم:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(140, 63);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(449, 367);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(443, 348);
            this.dataGridView1.TabIndex = 0;
            // 
            // Department
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 430);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Department";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "الأقسام";
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button buttonEditApprove;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonLoad_Dept;
        private System.Windows.Forms.Button buttonDelete_Dept;
        private System.Windows.Forms.Button buttonAdd_Dept;
        private System.Windows.Forms.Button buttonNew_Dept;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}