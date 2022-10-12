namespace FTPBubbleTea.Forms
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.lblDevBy = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnMember = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnListMenu = new System.Windows.Forms.Button();
            this.lblAppName = new System.Windows.Forms.Label();
            this.pnlBottom.SuspendLayout();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlBottom.Controls.Add(this.lblDevBy);
            this.pnlBottom.Controls.Add(this.lblUser);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 595);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1111, 29);
            this.pnlBottom.TabIndex = 0;
            // 
            // lblDevBy
            // 
            this.lblDevBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDevBy.AutoSize = true;
            this.lblDevBy.Location = new System.Drawing.Point(1028, 7);
            this.lblDevBy.Name = "lblDevBy";
            this.lblDevBy.Size = new System.Drawing.Size(29, 13);
            this.lblDevBy.TabIndex = 0;
            this.lblDevBy.Text = "User";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(12, 7);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(29, 13);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "User";
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Blue;
            this.pnlTop.Controls.Add(this.picLogo);
            this.pnlTop.Controls.Add(this.btnMember);
            this.pnlTop.Controls.Add(this.btnUser);
            this.pnlTop.Controls.Add(this.btnOrder);
            this.pnlTop.Controls.Add(this.btnListMenu);
            this.pnlTop.Controls.Add(this.lblAppName);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1111, 104);
            this.pnlTop.TabIndex = 1;
            // 
            // picLogo
            // 
            this.picLogo.BackgroundImage = global::FTPBubbleTea.Properties.Resources._9D577E4F_F9B2_467F_A620_4C30849746691;
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picLogo.InitialImage = null;
            this.picLogo.Location = new System.Drawing.Point(13, 13);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(69, 74);
            this.picLogo.TabIndex = 2;
            this.picLogo.TabStop = false;
            this.picLogo.Click += new System.EventHandler(this.picLogo_Click);
            // 
            // btnMember
            // 
            this.btnMember.BackgroundImage = global::FTPBubbleTea.Properties.Resources._2851398;
            this.btnMember.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMember.Location = new System.Drawing.Point(331, 12);
            this.btnMember.Name = "btnMember";
            this.btnMember.Size = new System.Drawing.Size(75, 75);
            this.btnMember.TabIndex = 1;
            this.btnMember.UseVisualStyleBackColor = true;
            this.btnMember.Click += new System.EventHandler(this.btnListMenu_Click);
            // 
            // btnUser
            // 
            this.btnUser.BackgroundImage = global::FTPBubbleTea.Properties.Resources._219986;
            this.btnUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUser.Location = new System.Drawing.Point(250, 12);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(75, 75);
            this.btnUser.TabIndex = 1;
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnListMenu_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.BackgroundImage = global::FTPBubbleTea.Properties.Resources._3500833;
            this.btnOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOrder.Location = new System.Drawing.Point(169, 12);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(75, 75);
            this.btnOrder.TabIndex = 1;
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnListMenu_Click);
            // 
            // btnListMenu
            // 
            this.btnListMenu.BackgroundImage = global::FTPBubbleTea.Properties.Resources.drink_icon;
            this.btnListMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnListMenu.Location = new System.Drawing.Point(88, 12);
            this.btnListMenu.Name = "btnListMenu";
            this.btnListMenu.Size = new System.Drawing.Size(75, 75);
            this.btnListMenu.TabIndex = 1;
            this.btnListMenu.UseVisualStyleBackColor = true;
            this.btnListMenu.Click += new System.EventHandler(this.btnListMenu_Click);
            // 
            // lblAppName
            // 
            this.lblAppName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAppName.AutoSize = true;
            this.lblAppName.Font = new System.Drawing.Font("Cordia New", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppName.ForeColor = System.Drawing.Color.White;
            this.lblAppName.Location = new System.Drawing.Point(865, 37);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(150, 56);
            this.lblAppName.TabIndex = 0;
            this.lblAppName.Text = "App Name";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 624);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlBottom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnListMenu;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblDevBy;
        private System.Windows.Forms.Button btnMember;

    }
}

