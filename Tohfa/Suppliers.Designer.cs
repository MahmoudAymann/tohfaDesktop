namespace Tohfa
{
    partial class Suppliers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Suppliers));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.buttonEditApprove_Suppliers = new System.Windows.Forms.Button();
            this.buttonEdit_Suppliers = new System.Windows.Forms.Button();
            this.buttonLoad_Suppliers = new System.Windows.Forms.Button();
            this.buttonDelete_Suppliers = new System.Windows.Forms.Button();
            this.buttonAdd_Suppliers = new System.Windows.Forms.Button();
            this.buttonNew_Suppliers = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
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
            this.groupBox1.Controls.Add(this.buttonLoad_Suppliers);
            this.groupBox1.Controls.Add(this.buttonDelete_Suppliers);
            this.groupBox1.Controls.Add(this.buttonAdd_Suppliers);
            this.groupBox1.Controls.Add(this.buttonNew_Suppliers);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(135, 535);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.buttonEditApprove_Suppliers);
            this.groupBox5.Controls.Add(this.buttonEdit_Suppliers);
            this.groupBox5.Location = new System.Drawing.Point(6, 239);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(123, 114);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "التعديل";
            // 
            // buttonEditApprove_Suppliers
            // 
            this.buttonEditApprove_Suppliers.BackColor = System.Drawing.Color.Green;
            this.buttonEditApprove_Suppliers.Enabled = false;
            this.buttonEditApprove_Suppliers.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditApprove_Suppliers.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEditApprove_Suppliers.Location = new System.Drawing.Point(6, 79);
            this.buttonEditApprove_Suppliers.Name = "buttonEditApprove_Suppliers";
            this.buttonEditApprove_Suppliers.Size = new System.Drawing.Size(111, 27);
            this.buttonEditApprove_Suppliers.TabIndex = 20;
            this.buttonEditApprove_Suppliers.Text = "تنفيذ";
            this.buttonEditApprove_Suppliers.UseVisualStyleBackColor = false;
            this.buttonEditApprove_Suppliers.Click += new System.EventHandler(this.buttonEditApprove_Click);
            // 
            // buttonEdit_Suppliers
            // 
            this.buttonEdit_Suppliers.Image = global::Tohfa.Properties.Resources.if_edit;
            this.buttonEdit_Suppliers.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonEdit_Suppliers.Location = new System.Drawing.Point(6, 19);
            this.buttonEdit_Suppliers.Name = "buttonEdit_Suppliers";
            this.buttonEdit_Suppliers.Size = new System.Drawing.Size(111, 57);
            this.buttonEdit_Suppliers.TabIndex = 6;
            this.buttonEdit_Suppliers.Text = "تعديل";
            this.buttonEdit_Suppliers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonEdit_Suppliers.UseVisualStyleBackColor = true;
            this.buttonEdit_Suppliers.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonLoad_Suppliers
            // 
            this.buttonLoad_Suppliers.Image = global::Tohfa.Properties.Resources.if_view_refreshs;
            this.buttonLoad_Suppliers.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonLoad_Suppliers.Location = new System.Drawing.Point(6, 472);
            this.buttonLoad_Suppliers.Name = "buttonLoad_Suppliers";
            this.buttonLoad_Suppliers.Size = new System.Drawing.Size(123, 57);
            this.buttonLoad_Suppliers.TabIndex = 5;
            this.buttonLoad_Suppliers.Text = "تحديث";
            this.buttonLoad_Suppliers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonLoad_Suppliers.UseVisualStyleBackColor = true;
            // 
            // buttonDelete_Suppliers
            // 
            this.buttonDelete_Suppliers.Image = global::Tohfa.Properties.Resources.if_delete;
            this.buttonDelete_Suppliers.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonDelete_Suppliers.Location = new System.Drawing.Point(6, 176);
            this.buttonDelete_Suppliers.Name = "buttonDelete_Suppliers";
            this.buttonDelete_Suppliers.Size = new System.Drawing.Size(123, 57);
            this.buttonDelete_Suppliers.TabIndex = 3;
            this.buttonDelete_Suppliers.Text = "حذف";
            this.buttonDelete_Suppliers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonDelete_Suppliers.UseVisualStyleBackColor = true;
            this.buttonDelete_Suppliers.Click += new System.EventHandler(this.buttonDelete_Suppliers_Click);
            // 
            // buttonAdd_Suppliers
            // 
            this.buttonAdd_Suppliers.Image = global::Tohfa.Properties.Resources.if_save;
            this.buttonAdd_Suppliers.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonAdd_Suppliers.Location = new System.Drawing.Point(6, 117);
            this.buttonAdd_Suppliers.Name = "buttonAdd_Suppliers";
            this.buttonAdd_Suppliers.Size = new System.Drawing.Size(123, 57);
            this.buttonAdd_Suppliers.TabIndex = 1;
            this.buttonAdd_Suppliers.Text = "إضافة";
            this.buttonAdd_Suppliers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAdd_Suppliers.UseVisualStyleBackColor = true;
            this.buttonAdd_Suppliers.Click += new System.EventHandler(this.buttonAdd_Suppliers_Click);
            // 
            // buttonNew_Suppliers
            // 
            this.buttonNew_Suppliers.Image = global::Tohfa.Properties.Resources.if_plus_add;
            this.buttonNew_Suppliers.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonNew_Suppliers.Location = new System.Drawing.Point(6, 13);
            this.buttonNew_Suppliers.Name = "buttonNew_Suppliers";
            this.buttonNew_Suppliers.Size = new System.Drawing.Size(123, 70);
            this.buttonNew_Suppliers.TabIndex = 0;
            this.buttonNew_Suppliers.Text = "جديد";
            this.buttonNew_Suppliers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonNew_Suppliers.UseVisualStyleBackColor = true;
            this.buttonNew_Suppliers.Click += new System.EventHandler(this.buttonNew_Suppliers_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
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
            this.groupBox2.Size = new System.Drawing.Size(453, 145);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "بيانات المورد";
            this.groupBox2.Visible = false;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(107, 105);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(250, 20);
            this.textBoxAddress.TabIndex = 15;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(107, 79);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(250, 20);
            this.textBoxPhone.TabIndex = 14;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(107, 53);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(250, 20);
            this.textBoxName.TabIndex = 13;
            // 
            // textBoxCode
            // 
            this.textBoxCode.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxCode.Location = new System.Drawing.Point(193, 27);
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(164, 20);
            this.textBoxCode.TabIndex = 12;
            this.textBoxCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(363, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "العنوان:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(363, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "رقم التليفون:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(363, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "الاسم:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(363, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "الكود:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(135, 145);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(453, 390);
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
            this.dataGridView1.Size = new System.Drawing.Size(447, 371);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(2, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 24);
            this.button1.TabIndex = 36;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Suppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 535);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Suppliers";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الموردين";
            this.Load += new System.EventHandler(this.Suppliers_Load);
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
        private System.Windows.Forms.Button buttonEditApprove_Suppliers;
        private System.Windows.Forms.Button buttonEdit_Suppliers;
        private System.Windows.Forms.Button buttonLoad_Suppliers;
        private System.Windows.Forms.Button buttonDelete_Suppliers;
        private System.Windows.Forms.Button buttonAdd_Suppliers;
        private System.Windows.Forms.Button buttonNew_Suppliers;
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
        private System.Windows.Forms.Button button1;
    }
}