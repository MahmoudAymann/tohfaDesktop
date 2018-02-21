namespace Tohfa
{
    partial class Products
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Products));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.buttonEditApprove = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonLoad_Product = new System.Windows.Forms.Button();
            this.buttonDelete_Product = new System.Windows.Forms.Button();
            this.buttonAdd_Product = new System.Windows.Forms.Button();
            this.buttonNew_Product = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxWorkKind = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxMachinePrice = new System.Windows.Forms.TextBox();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxMaterialPrice = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBoxMaterial = new System.Windows.Forms.ComboBox();
            this.buttonAddImg = new System.Windows.Forms.Button();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.textBoxLength = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxColor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxDepartment = new System.Windows.Forms.ComboBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.buttonLoad_Product);
            this.groupBox1.Controls.Add(this.buttonDelete_Product);
            this.groupBox1.Controls.Add(this.buttonAdd_Product);
            this.groupBox1.Controls.Add(this.buttonNew_Product);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(135, 644);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.buttonEditApprove);
            this.groupBox5.Controls.Add(this.buttonEdit);
            this.groupBox5.Location = new System.Drawing.Point(6, 239);
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
            // buttonLoad_Product
            // 
            this.buttonLoad_Product.Image = global::Tohfa.Properties.Resources.if_view_refreshs;
            this.buttonLoad_Product.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonLoad_Product.Location = new System.Drawing.Point(6, 575);
            this.buttonLoad_Product.Name = "buttonLoad_Product";
            this.buttonLoad_Product.Size = new System.Drawing.Size(123, 57);
            this.buttonLoad_Product.TabIndex = 5;
            this.buttonLoad_Product.Text = "تحديث";
            this.buttonLoad_Product.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonLoad_Product.UseVisualStyleBackColor = true;
            this.buttonLoad_Product.Click += new System.EventHandler(this.buttonLoad_Product_Click);
            // 
            // buttonDelete_Product
            // 
            this.buttonDelete_Product.Image = global::Tohfa.Properties.Resources.if_delete;
            this.buttonDelete_Product.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonDelete_Product.Location = new System.Drawing.Point(6, 176);
            this.buttonDelete_Product.Name = "buttonDelete_Product";
            this.buttonDelete_Product.Size = new System.Drawing.Size(123, 57);
            this.buttonDelete_Product.TabIndex = 3;
            this.buttonDelete_Product.Text = "حذف";
            this.buttonDelete_Product.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonDelete_Product.UseVisualStyleBackColor = true;
            this.buttonDelete_Product.Click += new System.EventHandler(this.buttonDelete_Product_Click);
            // 
            // buttonAdd_Product
            // 
            this.buttonAdd_Product.Image = global::Tohfa.Properties.Resources.if_save;
            this.buttonAdd_Product.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonAdd_Product.Location = new System.Drawing.Point(6, 117);
            this.buttonAdd_Product.Name = "buttonAdd_Product";
            this.buttonAdd_Product.Size = new System.Drawing.Size(123, 57);
            this.buttonAdd_Product.TabIndex = 1;
            this.buttonAdd_Product.Text = "إضافة";
            this.buttonAdd_Product.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAdd_Product.UseVisualStyleBackColor = true;
            this.buttonAdd_Product.Click += new System.EventHandler(this.buttonAdd_Product_Click);
            // 
            // buttonNew_Product
            // 
            this.buttonNew_Product.Image = global::Tohfa.Properties.Resources.if_plus_add;
            this.buttonNew_Product.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonNew_Product.Location = new System.Drawing.Point(6, 13);
            this.buttonNew_Product.Name = "buttonNew_Product";
            this.buttonNew_Product.Size = new System.Drawing.Size(123, 70);
            this.buttonNew_Product.TabIndex = 0;
            this.buttonNew_Product.Text = "جديد";
            this.buttonNew_Product.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonNew_Product.UseVisualStyleBackColor = true;
            this.buttonNew_Product.Click += new System.EventHandler(this.buttonNew_Product_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxWorkKind);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.textBoxTime);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.comboBoxMaterial);
            this.groupBox2.Controls.Add(this.buttonAddImg);
            this.groupBox2.Controls.Add(this.textBoxHeight);
            this.groupBox2.Controls.Add(this.textBoxWidth);
            this.groupBox2.Controls.Add(this.textBoxLength);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBoxColor);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.comboBoxDepartment);
            this.groupBox2.Controls.Add(this.textBoxName);
            this.groupBox2.Controls.Add(this.textBoxCode);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(135, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(676, 405);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "بيانات المنتج";
            this.groupBox2.Visible = false;
            // 
            // comboBoxWorkKind
            // 
            this.comboBoxWorkKind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxWorkKind.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxWorkKind.FormattingEnabled = true;
            this.comboBoxWorkKind.Items.AddRange(new object[] {
            "قطع",
            "حفر",
            "قطع وحفر"});
            this.comboBoxWorkKind.Location = new System.Drawing.Point(274, 178);
            this.comboBoxWorkKind.Name = "comboBoxWorkKind";
            this.comboBoxWorkKind.Size = new System.Drawing.Size(302, 24);
            this.comboBoxWorkKind.TabIndex = 39;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(582, 183);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 16);
            this.label15.TabIndex = 38;
            this.label15.Text = "نوع العمل:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.textBoxMachinePrice);
            this.groupBox4.Controls.Add(this.textBoxTotal);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.textBoxMaterialPrice);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox4.Location = new System.Drawing.Point(3, 288);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(670, 114);
            this.groupBox4.TabIndex = 37;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "الاسعار";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(483, 52);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 16);
            this.label14.TabIndex = 37;
            this.label14.Text = "سعر الماكينة:";
            // 
            // textBoxMachinePrice
            // 
            this.textBoxMachinePrice.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMachinePrice.Location = new System.Drawing.Point(227, 48);
            this.textBoxMachinePrice.Name = "textBoxMachinePrice";
            this.textBoxMachinePrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxMachinePrice.Size = new System.Drawing.Size(250, 23);
            this.textBoxMachinePrice.TabIndex = 38;
            this.textBoxMachinePrice.Text = "0";
            this.textBoxMachinePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxMachinePrice.TextChanged += new System.EventHandler(this.textBoxMachinePrice_TextChanged);
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotal.ForeColor = System.Drawing.Color.Red;
            this.textBoxTotal.Location = new System.Drawing.Point(227, 80);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.ReadOnly = true;
            this.textBoxTotal.Size = new System.Drawing.Size(250, 23);
            this.textBoxTotal.TabIndex = 36;
            this.textBoxTotal.Text = "0";
            this.textBoxTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(483, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "سعر الخامة:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(483, 84);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 16);
            this.label13.TabIndex = 35;
            this.label13.Text = "السعر:";
            // 
            // textBoxMaterialPrice
            // 
            this.textBoxMaterialPrice.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMaterialPrice.Location = new System.Drawing.Point(227, 19);
            this.textBoxMaterialPrice.Name = "textBoxMaterialPrice";
            this.textBoxMaterialPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxMaterialPrice.Size = new System.Drawing.Size(250, 23);
            this.textBoxMaterialPrice.TabIndex = 22;
            this.textBoxMaterialPrice.Text = "0";
            this.textBoxMaterialPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxMaterialPrice.TextChanged += new System.EventHandler(this.textBoxMaterialPrice_TextChanged);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(646, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 24);
            this.button1.TabIndex = 34;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(390, 239);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 16);
            this.label12.TabIndex = 33;
            this.label12.Text = "دقيقه";
            // 
            // textBoxTime
            // 
            this.textBoxTime.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTime.Location = new System.Drawing.Point(436, 236);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.Size = new System.Drawing.Size(140, 23);
            this.textBoxTime.TabIndex = 32;
            this.textBoxTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(582, 238);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 16);
            this.label11.TabIndex = 31;
            this.label11.Text = "وقت الماكينة:";
            // 
            // comboBoxMaterial
            // 
            this.comboBoxMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMaterial.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMaterial.FormattingEnabled = true;
            this.comboBoxMaterial.Location = new System.Drawing.Point(274, 150);
            this.comboBoxMaterial.Name = "comboBoxMaterial";
            this.comboBoxMaterial.Size = new System.Drawing.Size(302, 24);
            this.comboBoxMaterial.TabIndex = 30;
            // 
            // buttonAddImg
            // 
            this.buttonAddImg.Image = global::Tohfa.Properties.Resources.ic_upload_26;
            this.buttonAddImg.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonAddImg.Location = new System.Drawing.Point(278, 236);
            this.buttonAddImg.Name = "buttonAddImg";
            this.buttonAddImg.Size = new System.Drawing.Size(42, 46);
            this.buttonAddImg.TabIndex = 18;
            this.buttonAddImg.Text = "صورة";
            this.buttonAddImg.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAddImg.UseVisualStyleBackColor = true;
            this.buttonAddImg.Click += new System.EventHandler(this.buttonAddImg_Click);
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHeight.Location = new System.Drawing.Point(274, 117);
            this.textBoxHeight.Multiline = true;
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(46, 20);
            this.textBoxHeight.TabIndex = 29;
            this.textBoxHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxHeight_KeyPress);
            this.textBoxHeight.Leave += new System.EventHandler(this.textBoxHeight_Leave);
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxWidth.Location = new System.Drawing.Point(384, 117);
            this.textBoxWidth.Multiline = true;
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(46, 20);
            this.textBoxWidth.TabIndex = 28;
            this.textBoxWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxWidth_KeyPress);
            this.textBoxWidth.Leave += new System.EventHandler(this.textBoxWidth_Leave);
            // 
            // textBoxLength
            // 
            this.textBoxLength.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLength.Location = new System.Drawing.Point(488, 117);
            this.textBoxLength.Multiline = true;
            this.textBoxLength.Name = "textBoxLength";
            this.textBoxLength.Size = new System.Drawing.Size(46, 20);
            this.textBoxLength.TabIndex = 27;
            this.textBoxLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxLength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLength_KeyPress);
            this.textBoxLength.Leave += new System.EventHandler(this.textBoxLength_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(536, 120);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 16);
            this.label10.TabIndex = 26;
            this.label10.Text = "الطول:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(326, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 16);
            this.label9.TabIndex = 25;
            this.label9.Text = "الإرتفاع:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(436, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 16);
            this.label8.TabIndex = 24;
            this.label8.Text = "العرض:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(582, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "المقاس:";
            // 
            // textBoxColor
            // 
            this.textBoxColor.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxColor.Location = new System.Drawing.Point(274, 208);
            this.textBoxColor.Name = "textBoxColor";
            this.textBoxColor.Size = new System.Drawing.Size(302, 23);
            this.textBoxColor.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(582, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "اللون:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::Tohfa.Properties.Resources.default_img;
            this.pictureBox1.Location = new System.Drawing.Point(3, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 263);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(583, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "القسم:";
            // 
            // comboBoxDepartment
            // 
            this.comboBoxDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDepartment.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDepartment.FormattingEnabled = true;
            this.comboBoxDepartment.Location = new System.Drawing.Point(274, 57);
            this.comboBoxDepartment.Name = "comboBoxDepartment";
            this.comboBoxDepartment.Size = new System.Drawing.Size(302, 24);
            this.comboBoxDepartment.TabIndex = 8;
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(274, 84);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(302, 23);
            this.textBoxName.TabIndex = 5;
            // 
            // textBoxCode
            // 
            this.textBoxCode.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxCode.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCode.Location = new System.Drawing.Point(330, 31);
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(246, 23);
            this.textBoxCode.TabIndex = 4;
            this.textBoxCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(582, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "الخامة:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(583, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "الاسم:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(583, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "الكود:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(135, 405);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(676, 239);
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
            this.dataGridView1.Size = new System.Drawing.Size(670, 220);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 644);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Products";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "المنتجات";
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button buttonEditApprove;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonLoad_Product;
        private System.Windows.Forms.Button buttonDelete_Product;
        private System.Windows.Forms.Button buttonAdd_Product;
        private System.Windows.Forms.Button buttonNew_Product;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonAddImg;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxDepartment;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMaterialPrice;
        private System.Windows.Forms.TextBox textBoxColor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBoxMaterial;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.TextBox textBoxWidth;
        private System.Windows.Forms.TextBox textBoxLength;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxWorkKind;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxMachinePrice;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}