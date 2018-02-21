namespace Tohfa
{
    partial class OrderSelection
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
            this.buttonAddFromEmp = new System.Windows.Forms.Button();
            this.buttonAddService = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAddFromEmp
            // 
            this.buttonAddFromEmp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddFromEmp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddFromEmp.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddFromEmp.Image = global::Tohfa.Properties.Resources.ic_order_fromEmp_100;
            this.buttonAddFromEmp.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonAddFromEmp.Location = new System.Drawing.Point(12, 12);
            this.buttonAddFromEmp.Name = "buttonAddFromEmp";
            this.buttonAddFromEmp.Size = new System.Drawing.Size(184, 132);
            this.buttonAddFromEmp.TabIndex = 1;
            this.buttonAddFromEmp.Text = "منتج";
            this.buttonAddFromEmp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAddFromEmp.UseVisualStyleBackColor = true;
            this.buttonAddFromEmp.Click += new System.EventHandler(this.buttonAddFromEmp_Click);
            // 
            // buttonAddService
            // 
            this.buttonAddService.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddService.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddService.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddService.Image = global::Tohfa.Properties.Resources.ic_service_100;
            this.buttonAddService.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonAddService.Location = new System.Drawing.Point(213, 12);
            this.buttonAddService.Name = "buttonAddService";
            this.buttonAddService.Size = new System.Drawing.Size(192, 132);
            this.buttonAddService.TabIndex = 0;
            this.buttonAddService.Text = "خدمة";
            this.buttonAddService.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAddService.UseVisualStyleBackColor = true;
            this.buttonAddService.Click += new System.EventHandler(this.buttonAddService_Click);
            // 
            // OrderSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 156);
            this.Controls.Add(this.buttonAddFromEmp);
            this.Controls.Add(this.buttonAddService);
            this.Name = "OrderSelection";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderSelection";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAddService;
        private System.Windows.Forms.Button buttonAddFromEmp;
    }
}