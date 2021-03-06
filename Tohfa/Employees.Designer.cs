﻿namespace Tohfa
{
    partial class Employees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employees));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.buttonEditApprove = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonLoad_Emp = new System.Windows.Forms.Button();
            this.buttonDelete_Emp = new System.Windows.Forms.Button();
            this.buttonAdd_Emp = new System.Windows.Forms.Button();
            this.buttonNew_Emp = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxJob = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
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
            this.groupBox1.Controls.Add(this.buttonLoad_Emp);
            this.groupBox1.Controls.Add(this.buttonDelete_Emp);
            this.groupBox1.Controls.Add(this.buttonAdd_Emp);
            this.groupBox1.Controls.Add(this.buttonNew_Emp);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(135, 536);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.buttonEditApprove);
            this.groupBox5.Controls.Add(this.buttonEdit);
            this.groupBox5.Location = new System.Drawing.Point(6, 248);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(123, 114);
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
            this.buttonEditApprove.Size = new System.Drawing.Size(111, 27);
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
            this.buttonEdit.Size = new System.Drawing.Size(111, 57);
            this.buttonEdit.TabIndex = 6;
            this.buttonEdit.Text = "تعديل";
            this.buttonEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonLoad_Emp
            // 
            this.buttonLoad_Emp.Image = global::Tohfa.Properties.Resources.if_view_refreshs;
            this.buttonLoad_Emp.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonLoad_Emp.Location = new System.Drawing.Point(6, 472);
            this.buttonLoad_Emp.Name = "buttonLoad_Emp";
            this.buttonLoad_Emp.Size = new System.Drawing.Size(123, 57);
            this.buttonLoad_Emp.TabIndex = 5;
            this.buttonLoad_Emp.Text = "تحديث";
            this.buttonLoad_Emp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonLoad_Emp.UseVisualStyleBackColor = true;
            this.buttonLoad_Emp.Click += new System.EventHandler(this.buttonLoad_Emp_Click);
            // 
            // buttonDelete_Emp
            // 
            this.buttonDelete_Emp.Image = global::Tohfa.Properties.Resources.if_delete;
            this.buttonDelete_Emp.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonDelete_Emp.Location = new System.Drawing.Point(6, 185);
            this.buttonDelete_Emp.Name = "buttonDelete_Emp";
            this.buttonDelete_Emp.Size = new System.Drawing.Size(123, 57);
            this.buttonDelete_Emp.TabIndex = 3;
            this.buttonDelete_Emp.Text = "حذف";
            this.buttonDelete_Emp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonDelete_Emp.UseVisualStyleBackColor = true;
            this.buttonDelete_Emp.Click += new System.EventHandler(this.buttonDelete_Emp_Click);
            // 
            // buttonAdd_Emp
            // 
            this.buttonAdd_Emp.Image = global::Tohfa.Properties.Resources.if_save;
            this.buttonAdd_Emp.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonAdd_Emp.Location = new System.Drawing.Point(6, 126);
            this.buttonAdd_Emp.Name = "buttonAdd_Emp";
            this.buttonAdd_Emp.Size = new System.Drawing.Size(123, 57);
            this.buttonAdd_Emp.TabIndex = 1;
            this.buttonAdd_Emp.Text = "إضافة";
            this.buttonAdd_Emp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAdd_Emp.UseVisualStyleBackColor = true;
            this.buttonAdd_Emp.Click += new System.EventHandler(this.buttonAdd_Emp_Click);
            // 
            // buttonNew_Emp
            // 
            this.buttonNew_Emp.Image = global::Tohfa.Properties.Resources.if_plus_add;
            this.buttonNew_Emp.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonNew_Emp.Location = new System.Drawing.Point(6, 13);
            this.buttonNew_Emp.Name = "buttonNew_Emp";
            this.buttonNew_Emp.Size = new System.Drawing.Size(123, 70);
            this.buttonNew_Emp.TabIndex = 0;
            this.buttonNew_Emp.Text = "جديد";
            this.buttonNew_Emp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonNew_Emp.UseVisualStyleBackColor = true;
            this.buttonNew_Emp.Click += new System.EventHandler(this.buttonNew_Emp_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBoxJob);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBoxAddress);
            this.groupBox2.Controls.Add(this.textBoxPhone);
            this.groupBox2.Controls.Add(this.textBoxName);
            this.groupBox2.Controls.Add(this.textBoxCode);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(135, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(628, 184);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "التصميم",
            "التنفيذ",
            "الطباعة",
            "المبيعات",
            "المشتريات",
            "السكرتارية",
            "الإدارة",
            "التركيب",
            "الشحن",
            "المحاسبة"});
            this.comboBox1.Location = new System.Drawing.Point(296, 125);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(250, 21);
            this.comboBox1.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(552, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "القسم:";
            // 
            // textBoxJob
            // 
            this.textBoxJob.Location = new System.Drawing.Point(296, 152);
            this.textBoxJob.Name = "textBoxJob";
            this.textBoxJob.Size = new System.Drawing.Size(250, 20);
            this.textBoxJob.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(552, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "المهنة:";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(296, 99);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(250, 20);
            this.textBoxAddress.TabIndex = 15;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(296, 73);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(250, 20);
            this.textBoxPhone.TabIndex = 14;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(296, 47);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(250, 20);
            this.textBoxName.TabIndex = 13;
            // 
            // textBoxCode
            // 
            this.textBoxCode.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxCode.Location = new System.Drawing.Point(364, 21);
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(182, 20);
            this.textBoxCode.TabIndex = 12;
            this.textBoxCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(552, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "العنوان:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(552, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "رقم التليفون:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(552, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "الاسم:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(552, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "الكود:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(135, 184);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(628, 352);
            this.groupBox3.TabIndex = 27;
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
            this.dataGridView1.Size = new System.Drawing.Size(622, 333);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(3, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 24);
            this.button1.TabIndex = 37;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 536);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Employees";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "الموظفين";
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
        private System.Windows.Forms.Button buttonLoad_Emp;
        private System.Windows.Forms.Button buttonDelete_Emp;
        private System.Windows.Forms.Button buttonAdd_Emp;
        private System.Windows.Forms.Button buttonNew_Emp;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxJob;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}