namespace Tohfa
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSlide = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.تهيئةالاسعارToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemCurrency = new System.Windows.Forms.ToolStripMenuItem();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.sPanel = new System.Windows.Forms.Panel();
            this.buttonReports = new System.Windows.Forms.Button();
            this.buttonOrder = new System.Windows.Forms.Button();
            this.buttonDepartment = new System.Windows.Forms.Button();
            this.buttonRaw = new System.Windows.Forms.Button();
            this.buttonAgents = new System.Windows.Forms.Button();
            this.buttonProducts = new System.Windows.Forms.Button();
            this.buttonEmployees = new System.Windows.Forms.Button();
            this.buttonSuppliers = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonStore = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.sPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.buttonSlide);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(35, 629);
            this.panel1.TabIndex = 0;
            // 
            // buttonSlide
            // 
            this.buttonSlide.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSlide.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSlide.Location = new System.Drawing.Point(0, 0);
            this.buttonSlide.Name = "buttonSlide";
            this.buttonSlide.Size = new System.Drawing.Size(33, 102);
            this.buttonSlide.TabIndex = 0;
            this.buttonSlide.Text = "S\r\nH\r\nO\r\nW";
            this.buttonSlide.UseVisualStyleBackColor = true;
            this.buttonSlide.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 80;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.تهيئةالاسعارToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // تهيئةالاسعارToolStripMenuItem
            // 
            this.تهيئةالاسعارToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemCurrency});
            this.تهيئةالاسعارToolStripMenuItem.Name = "تهيئةالاسعارToolStripMenuItem";
            this.تهيئةالاسعارToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.تهيئةالاسعارToolStripMenuItem.Text = "التهيئة";
            // 
            // ToolStripMenuItemCurrency
            // 
            this.ToolStripMenuItemCurrency.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ToolStripMenuItemCurrency.Image = global::Tohfa.Properties.Resources.dollar_coin_stack;
            this.ToolStripMenuItemCurrency.Name = "ToolStripMenuItemCurrency";
            this.ToolStripMenuItemCurrency.Size = new System.Drawing.Size(136, 22);
            this.ToolStripMenuItemCurrency.Text = "تهيئة الأسعار";
            this.ToolStripMenuItemCurrency.Click += new System.EventHandler(this.ToolStripMenuItemCurrency_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.Location = new System.Drawing.Point(800, 625);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.linkLabel1.Size = new System.Drawing.Size(72, 19);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Tohfa.net";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Tohfa.Properties.Resources.ic_combo_chart_64;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(659, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 100);
            this.button1.TabIndex = 4;
            this.button1.Text = "الإيرادات";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // sPanel
            // 
            this.sPanel.BackColor = System.Drawing.Color.White;
            this.sPanel.BackgroundImage = global::Tohfa.Properties.Resources.slider_back;
            this.sPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sPanel.Controls.Add(this.buttonReports);
            this.sPanel.Controls.Add(this.buttonOrder);
            this.sPanel.Controls.Add(this.buttonDepartment);
            this.sPanel.Controls.Add(this.buttonRaw);
            this.sPanel.Controls.Add(this.buttonAgents);
            this.sPanel.Controls.Add(this.buttonProducts);
            this.sPanel.Controls.Add(this.buttonEmployees);
            this.sPanel.Controls.Add(this.buttonSuppliers);
            this.sPanel.Controls.Add(this.pictureBox1);
            this.sPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sPanel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sPanel.Location = new System.Drawing.Point(35, 24);
            this.sPanel.Name = "sPanel";
            this.sPanel.Size = new System.Drawing.Size(200, 629);
            this.sPanel.TabIndex = 1;
            // 
            // buttonReports
            // 
            this.buttonReports.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReports.Image = ((System.Drawing.Image)(resources.GetObject("buttonReports.Image")));
            this.buttonReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReports.Location = new System.Drawing.Point(4, 561);
            this.buttonReports.Name = "buttonReports";
            this.buttonReports.Size = new System.Drawing.Size(191, 59);
            this.buttonReports.TabIndex = 8;
            this.buttonReports.Text = "التقاير";
            this.buttonReports.UseVisualStyleBackColor = true;
            this.buttonReports.Click += new System.EventHandler(this.buttonReports_Click);
            // 
            // buttonOrder
            // 
            this.buttonOrder.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOrder.Image = ((System.Drawing.Image)(resources.GetObject("buttonOrder.Image")));
            this.buttonOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOrder.Location = new System.Drawing.Point(3, 496);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(191, 59);
            this.buttonOrder.TabIndex = 7;
            this.buttonOrder.Text = "أمر شغل";
            this.buttonOrder.UseVisualStyleBackColor = true;
            this.buttonOrder.Click += new System.EventHandler(this.buttonOrder_Click);
            // 
            // buttonDepartment
            // 
            this.buttonDepartment.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDepartment.Image = ((System.Drawing.Image)(resources.GetObject("buttonDepartment.Image")));
            this.buttonDepartment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDepartment.Location = new System.Drawing.Point(4, 301);
            this.buttonDepartment.Name = "buttonDepartment";
            this.buttonDepartment.Size = new System.Drawing.Size(191, 59);
            this.buttonDepartment.TabIndex = 0;
            this.buttonDepartment.Text = "الأقسام";
            this.buttonDepartment.UseVisualStyleBackColor = true;
            this.buttonDepartment.Click += new System.EventHandler(this.buttonDepartment_Click);
            // 
            // buttonRaw
            // 
            this.buttonRaw.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRaw.Image = ((System.Drawing.Image)(resources.GetObject("buttonRaw.Image")));
            this.buttonRaw.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRaw.Location = new System.Drawing.Point(4, 366);
            this.buttonRaw.Name = "buttonRaw";
            this.buttonRaw.Size = new System.Drawing.Size(191, 59);
            this.buttonRaw.TabIndex = 6;
            this.buttonRaw.Text = "الخامات";
            this.buttonRaw.UseVisualStyleBackColor = true;
            this.buttonRaw.Click += new System.EventHandler(this.buttonRaw_Click);
            // 
            // buttonAgents
            // 
            this.buttonAgents.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgents.Image = ((System.Drawing.Image)(resources.GetObject("buttonAgents.Image")));
            this.buttonAgents.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAgents.Location = new System.Drawing.Point(4, 171);
            this.buttonAgents.Name = "buttonAgents";
            this.buttonAgents.Size = new System.Drawing.Size(191, 59);
            this.buttonAgents.TabIndex = 2;
            this.buttonAgents.Text = "العملاء";
            this.buttonAgents.UseVisualStyleBackColor = true;
            this.buttonAgents.Click += new System.EventHandler(this.buttonAgents_Click);
            // 
            // buttonProducts
            // 
            this.buttonProducts.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProducts.Image = ((System.Drawing.Image)(resources.GetObject("buttonProducts.Image")));
            this.buttonProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProducts.Location = new System.Drawing.Point(4, 431);
            this.buttonProducts.Name = "buttonProducts";
            this.buttonProducts.Size = new System.Drawing.Size(191, 59);
            this.buttonProducts.TabIndex = 5;
            this.buttonProducts.Text = "المنتجات";
            this.buttonProducts.UseVisualStyleBackColor = true;
            this.buttonProducts.Click += new System.EventHandler(this.buttonProducts_Click);
            // 
            // buttonEmployees
            // 
            this.buttonEmployees.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEmployees.Image = ((System.Drawing.Image)(resources.GetObject("buttonEmployees.Image")));
            this.buttonEmployees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEmployees.Location = new System.Drawing.Point(4, 236);
            this.buttonEmployees.Name = "buttonEmployees";
            this.buttonEmployees.Size = new System.Drawing.Size(191, 59);
            this.buttonEmployees.TabIndex = 4;
            this.buttonEmployees.Text = "الموظفين";
            this.buttonEmployees.UseVisualStyleBackColor = true;
            this.buttonEmployees.Click += new System.EventHandler(this.buttonEmployees_Click);
            // 
            // buttonSuppliers
            // 
            this.buttonSuppliers.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSuppliers.Image = ((System.Drawing.Image)(resources.GetObject("buttonSuppliers.Image")));
            this.buttonSuppliers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSuppliers.Location = new System.Drawing.Point(3, 106);
            this.buttonSuppliers.Name = "buttonSuppliers";
            this.buttonSuppliers.Size = new System.Drawing.Size(191, 59);
            this.buttonSuppliers.TabIndex = 3;
            this.buttonSuppliers.Text = "الموردين";
            this.buttonSuppliers.UseVisualStyleBackColor = true;
            this.buttonSuppliers.Click += new System.EventHandler(this.buttonSuppliers_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::Tohfa.Properties.Resources.mainpage;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // buttonStore
            // 
            this.buttonStore.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStore.Image = global::Tohfa.Properties.Resources.ic_combo_chart_64;
            this.buttonStore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStore.Location = new System.Drawing.Point(659, 143);
            this.buttonStore.Name = "buttonStore";
            this.buttonStore.Size = new System.Drawing.Size(213, 100);
            this.buttonStore.TabIndex = 5;
            this.buttonStore.Text = "الخزينة";
            this.buttonStore.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonStore.UseVisualStyleBackColor = true;
            this.buttonStore.Click += new System.EventHandler(this.buttonStore_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(884, 653);
            this.Controls.Add(this.buttonStore);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.sPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "القائمة الرئيسية";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.sPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSlide;
        private System.Windows.Forms.Panel sPanel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonDepartment;
        private System.Windows.Forms.Button buttonOrder;
        private System.Windows.Forms.Button buttonRaw;
        private System.Windows.Forms.Button buttonProducts;
        private System.Windows.Forms.Button buttonEmployees;
        private System.Windows.Forms.Button buttonSuppliers;
        private System.Windows.Forms.Button buttonAgents;
        private System.Windows.Forms.Button buttonReports;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem تهيئةالاسعارToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemCurrency;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonStore;
    }
}

