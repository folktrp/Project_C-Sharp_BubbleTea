namespace FTPBubbleTea.Forms.Master
{
    partial class frmEntryMenu
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
            FTPBubbleTea.BC.EntityBase entityBase1 = new FTPBubbleTea.BC.EntityBase();
            this.txtNote1 = new System.Windows.Forms.TextBox();
            this.lblNote1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.updPriceHot = new System.Windows.Forms.NumericUpDown();
            this.lblPriceHot = new System.Windows.Forms.Label();
            this.lblPriceCool = new System.Windows.Forms.Label();
            this.updPriceCool = new System.Windows.Forms.NumericUpDown();
            this.lblPriceSpin = new System.Windows.Forms.Label();
            this.updPriceSpin = new System.Windows.Forms.NumericUpDown();
            this.txtImage = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.updPriceHot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updPriceCool)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updPriceSpin)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNote1
            // 
            this.txtNote1.Location = new System.Drawing.Point(84, 166);
            this.txtNote1.Multiline = true;
            this.txtNote1.Name = "txtNote1";
            this.txtNote1.Size = new System.Drawing.Size(290, 72);
            this.txtNote1.TabIndex = 11;
            // 
            // lblNote1
            // 
            this.lblNote1.AutoSize = true;
            this.lblNote1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblNote1.Location = new System.Drawing.Point(26, 166);
            this.lblNote1.Name = "lblNote1";
            this.lblNote1.Size = new System.Drawing.Size(52, 13);
            this.lblNote1.TabIndex = 10;
            this.lblNote1.Text = "หมายเหตุ";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(84, 61);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblName.Location = new System.Drawing.Point(58, 64);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(20, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "ชื่อ";
            // 
            // updPriceHot
            // 
            this.updPriceHot.Location = new System.Drawing.Point(84, 88);
            this.updPriceHot.Name = "updPriceHot";
            this.updPriceHot.Size = new System.Drawing.Size(120, 20);
            this.updPriceHot.TabIndex = 5;
            this.updPriceHot.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.updPriceHot.ThousandsSeparator = true;
            // 
            // lblPriceHot
            // 
            this.lblPriceHot.AutoSize = true;
            this.lblPriceHot.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblPriceHot.Location = new System.Drawing.Point(28, 92);
            this.lblPriceHot.Name = "lblPriceHot";
            this.lblPriceHot.Size = new System.Drawing.Size(50, 13);
            this.lblPriceHot.TabIndex = 4;
            this.lblPriceHot.Text = "ราคาร้อน";
            // 
            // lblPriceCool
            // 
            this.lblPriceCool.AutoSize = true;
            this.lblPriceCool.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblPriceCool.Location = new System.Drawing.Point(28, 118);
            this.lblPriceCool.Name = "lblPriceCool";
            this.lblPriceCool.Size = new System.Drawing.Size(50, 13);
            this.lblPriceCool.TabIndex = 6;
            this.lblPriceCool.Text = "ราคาเย็น";
            // 
            // updPriceCool
            // 
            this.updPriceCool.Location = new System.Drawing.Point(84, 114);
            this.updPriceCool.Name = "updPriceCool";
            this.updPriceCool.Size = new System.Drawing.Size(120, 20);
            this.updPriceCool.TabIndex = 7;
            this.updPriceCool.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.updPriceCool.ThousandsSeparator = true;
            // 
            // lblPriceSpin
            // 
            this.lblPriceSpin.AutoSize = true;
            this.lblPriceSpin.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblPriceSpin.Location = new System.Drawing.Point(33, 144);
            this.lblPriceSpin.Name = "lblPriceSpin";
            this.lblPriceSpin.Size = new System.Drawing.Size(45, 13);
            this.lblPriceSpin.TabIndex = 8;
            this.lblPriceSpin.Text = "ราคาปั่น";
            // 
            // updPriceSpin
            // 
            this.updPriceSpin.Location = new System.Drawing.Point(84, 140);
            this.updPriceSpin.Name = "updPriceSpin";
            this.updPriceSpin.Size = new System.Drawing.Size(120, 20);
            this.updPriceSpin.TabIndex = 9;
            this.updPriceSpin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.updPriceSpin.ThousandsSeparator = true;
            // 
            // txtImage
            // 
            this.txtImage.Location = new System.Drawing.Point(84, 244);
            this.txtImage.Name = "txtImage";
            this.txtImage.Size = new System.Drawing.Size(290, 20);
            this.txtImage.TabIndex = 0;
            this.txtImage.Visible = false;
            // 
            // frmEntryMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 307);
            this.Controls.Add(this.updPriceSpin);
            this.Controls.Add(this.updPriceCool);
            this.Controls.Add(this.updPriceHot);
            this.Controls.Add(this.txtNote1);
            this.Controls.Add(this.lblPriceSpin);
            this.Controls.Add(this.lblNote1);
            this.Controls.Add(this.lblPriceCool);
            this.Controls.Add(this.txtImage);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblPriceHot);
            this.Controls.Add(this.lblName);
            entityBase1.EntityState = FTPBubbleTea.BC.EntityBase.EntityStates.Added;
            this.EntityBase = entityBase1;
            this.Name = "frmEntryMenu";
            this.Text = "frmEntryMenu";
            this.Controls.SetChildIndex(this.lblName, 0);
            this.Controls.SetChildIndex(this.lblPriceHot, 0);
            this.Controls.SetChildIndex(this.txtName, 0);
            this.Controls.SetChildIndex(this.txtImage, 0);
            this.Controls.SetChildIndex(this.lblPriceCool, 0);
            this.Controls.SetChildIndex(this.lblNote1, 0);
            this.Controls.SetChildIndex(this.lblPriceSpin, 0);
            this.Controls.SetChildIndex(this.txtNote1, 0);
            this.Controls.SetChildIndex(this.updPriceHot, 0);
            this.Controls.SetChildIndex(this.updPriceCool, 0);
            this.Controls.SetChildIndex(this.updPriceSpin, 0);
            ((System.ComponentModel.ISupportInitialize)(this.updPriceHot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updPriceCool)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updPriceSpin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNote1;
        private System.Windows.Forms.Label lblNote1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.NumericUpDown updPriceHot;
        private System.Windows.Forms.Label lblPriceHot;
        private System.Windows.Forms.Label lblPriceCool;
        private System.Windows.Forms.NumericUpDown updPriceCool;
        private System.Windows.Forms.Label lblPriceSpin;
        private System.Windows.Forms.NumericUpDown updPriceSpin;
        private System.Windows.Forms.TextBox txtImage;
    }
}