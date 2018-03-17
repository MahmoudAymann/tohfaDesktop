namespace Tohfa
{
    partial class Agents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agents));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.buttonEditApprove_Agent = new System.Windows.Forms.Button();
            this.buttonEdit_Agent = new System.Windows.Forms.Button();
            this.buttonLoad_Agent = new System.Windows.Forms.Button();
            this.buttonDelete_Agent = new System.Windows.Forms.Button();
            this.buttonAdd_Agent = new System.Windows.Forms.Button();
            this.buttonNew_Agent = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxKind = new System.Windows.Forms.ComboBox();
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
            this.groupBox1.Controls.Add(this.buttonLoad_Agent);
            this.groupBox1.Controls.Add(this.buttonDelete_Agent);
            this.groupBox1.Controls.Add(this.buttonAdd_Agent);
            this.groupBox1.Controls.Add(this.buttonNew_Agent);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(135, 535);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.buttonEditApprove_Agent);
            this.groupBox5.Controls.Add(this.buttonEdit_Agent);
            this.groupBox5.Location = new System.Drawing.Point(6, 239);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(123, 114);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "التعديل";
            // 
            // buttonEditApprove_Agent
            // 
            this.buttonEditApprove_Agent.BackColor = System.Drawing.Color.Green;
            this.buttonEditApprove_Agent.Enabled = false;
            this.buttonEditApprove_Agent.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditApprove_Agent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEditApprove_Agent.Location = new System.Drawing.Point(6, 79);
            this.buttonEditApprove_Agent.Name = "buttonEditApprove_Agent";
            this.buttonEditApprove_Agent.Size = new System.Drawing.Size(111, 27);
            this.buttonEditApprove_Agent.TabIndex = 20;
            this.buttonEditApprove_Agent.Text = "تنفيذ";
            this.buttonEditApprove_Agent.UseVisualStyleBackColor = false;
            this.buttonEditApprove_Agent.Click += new System.EventHandler(this.buttonEditApprove_Agent_Click);
            // 
            // buttonEdit_Agent
            // 
            this.buttonEdit_Agent.Image = global::Tohfa.Properties.Resources.if_edit;
            this.buttonEdit_Agent.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonEdit_Agent.Location = new System.Drawing.Point(6, 19);
            this.buttonEdit_Agent.Name = "buttonEdit_Agent";
            this.buttonEdit_Agent.Size = new System.Drawing.Size(111, 57);
            this.buttonEdit_Agent.TabIndex = 6;
            this.buttonEdit_Agent.Text = "تعديل";
            this.buttonEdit_Agent.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonEdit_Agent.UseVisualStyleBackColor = true;
            this.buttonEdit_Agent.Click += new System.EventHandler(this.buttonEdit_Agent_Click);
            // 
            // buttonLoad_Agent
            // 
            this.buttonLoad_Agent.Image = global::Tohfa.Properties.Resources.if_view_refreshs;
            this.buttonLoad_Agent.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonLoad_Agent.Location = new System.Drawing.Point(6, 472);
            this.buttonLoad_Agent.Name = "buttonLoad_Agent";
            this.buttonLoad_Agent.Size = new System.Drawing.Size(123, 57);
            this.buttonLoad_Agent.TabIndex = 5;
            this.buttonLoad_Agent.Text = "تحديث";
            this.buttonLoad_Agent.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonLoad_Agent.UseVisualStyleBackColor = true;
            this.buttonLoad_Agent.Click += new System.EventHandler(this.buttonLoad_Agent_Click);
            // 
            // buttonDelete_Agent
            // 
            this.buttonDelete_Agent.Image = global::Tohfa.Properties.Resources.if_delete;
            this.buttonDelete_Agent.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonDelete_Agent.Location = new System.Drawing.Point(6, 176);
            this.buttonDelete_Agent.Name = "buttonDelete_Agent";
            this.buttonDelete_Agent.Size = new System.Drawing.Size(123, 57);
            this.buttonDelete_Agent.TabIndex = 3;
            this.buttonDelete_Agent.Text = "حذف";
            this.buttonDelete_Agent.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonDelete_Agent.UseVisualStyleBackColor = true;
            this.buttonDelete_Agent.Click += new System.EventHandler(this.buttonDelete_Agent_Click);
            // 
            // buttonAdd_Agent
            // 
            this.buttonAdd_Agent.Image = global::Tohfa.Properties.Resources.if_save;
            this.buttonAdd_Agent.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonAdd_Agent.Location = new System.Drawing.Point(6, 117);
            this.buttonAdd_Agent.Name = "buttonAdd_Agent";
            this.buttonAdd_Agent.Size = new System.Drawing.Size(123, 57);
            this.buttonAdd_Agent.TabIndex = 1;
            this.buttonAdd_Agent.Text = "إضافة";
            this.buttonAdd_Agent.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAdd_Agent.UseVisualStyleBackColor = true;
            this.buttonAdd_Agent.Click += new System.EventHandler(this.buttonAdd_Agent_Click);
            // 
            // buttonNew_Agent
            // 
            this.buttonNew_Agent.Image = global::Tohfa.Properties.Resources.if_plus_add;
            this.buttonNew_Agent.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonNew_Agent.Location = new System.Drawing.Point(6, 13);
            this.buttonNew_Agent.Name = "buttonNew_Agent";
            this.buttonNew_Agent.Size = new System.Drawing.Size(123, 70);
            this.buttonNew_Agent.TabIndex = 0;
            this.buttonNew_Agent.Text = "جديد";
            this.buttonNew_Agent.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonNew_Agent.UseVisualStyleBackColor = true;
            this.buttonNew_Agent.Click += new System.EventHandler(this.buttonNew_Agent_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.comboBoxKind);
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
            this.groupBox2.Size = new System.Drawing.Size(592, 153);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "بيانات العميل";
            this.groupBox2.Visible = false;
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(2, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 24);
            this.button1.TabIndex = 35;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxKind
            // 
            this.comboBoxKind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKind.FormattingEnabled = true;
            this.comboBoxKind.Items.AddRange(new object[] {
            "قطاعى",
            "خاص",
            "جملة",
            "نصف جملة"});
            this.comboBoxKind.Location = new System.Drawing.Point(259, 74);
            this.comboBoxKind.Name = "comboBoxKind";
            this.comboBoxKind.Size = new System.Drawing.Size(250, 21);
            this.comboBoxKind.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(515, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "نوع العميل:";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(259, 124);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(250, 20);
            this.textBoxAddress.TabIndex = 7;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(259, 99);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(250, 20);
            this.textBoxPhone.TabIndex = 6;
            this.textBoxPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPhone_KeyPress);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(259, 48);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(250, 20);
            this.textBoxName.TabIndex = 5;
            // 
            // textBoxCode
            // 
            this.textBoxCode.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxCode.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCode.Location = new System.Drawing.Point(327, 22);
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(182, 21);
            this.textBoxCode.TabIndex = 4;
            this.textBoxCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(515, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "العنوان:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(515, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "رقم التليفون:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(515, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "الاسم:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(515, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "الكود:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(135, 153);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(592, 382);
            this.groupBox3.TabIndex = 26;
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
            this.dataGridView1.Size = new System.Drawing.Size(586, 363);
            this.dataGridView1.TabIndex = 0;
            // 
            // Agents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 535);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Agents";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "العملاء";
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
        private System.Windows.Forms.Button buttonEditApprove_Agent;
        private System.Windows.Forms.Button buttonEdit_Agent;
        private System.Windows.Forms.Button buttonLoad_Agent;
        private System.Windows.Forms.Button buttonDelete_Agent;
        private System.Windows.Forms.Button buttonAdd_Agent;
        private System.Windows.Forms.Button buttonNew_Agent;
        private System.Windows.Forms.GroupBox groupBox2;
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
        private System.Windows.Forms.ComboBox comboBoxKind;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}