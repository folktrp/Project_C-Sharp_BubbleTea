namespace FTPBubbleTea.Forms.Transaction
{
    partial class frmEntryOrder
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
            this.lblNote1 = new System.Windows.Forms.Label();
            this.cboListMenu = new System.Windows.Forms.ComboBox();
            this.lblListMenu = new System.Windows.Forms.Label();
            this.updPriceSpin = new System.Windows.Forms.NumericUpDown();
            this.updPriceCool = new System.Windows.Forms.NumericUpDown();
            this.updPriceHot = new System.Windows.Forms.NumericUpDown();
            this.lblPriceSpin = new System.Windows.Forms.Label();
            this.lblPriceCool = new System.Windows.Forms.Label();
            this.lblPriceHot = new System.Windows.Forms.Label();
            this.rdoHot = new System.Windows.Forms.RadioButton();
            this.rdoCool = new System.Windows.Forms.RadioButton();
            this.rdoSpin = new System.Windows.Forms.RadioButton();
            this.grpToping = new System.Windows.Forms.GroupBox();
            this.chkIsJellyCaramel = new System.Windows.Forms.CheckBox();
            this.chkFruitSalad = new System.Windows.Forms.CheckBox();
            this.chkIsJellyStrawberry = new System.Windows.Forms.CheckBox();
            this.chkIsJellyHoney = new System.Windows.Forms.CheckBox();
            this.chkKaiMookPop = new System.Windows.Forms.CheckBox();
            this.chkKaiMook = new System.Windows.Forms.CheckBox();
            this.grbDiscount = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtMember = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.updTotalPrice = new System.Windows.Forms.NumericUpDown();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblMember = new System.Windows.Forms.Label();
            this.updDiscount = new System.Windows.Forms.NumericUpDown();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.updPrice = new System.Windows.Forms.NumericUpDown();
            this.lblPrice = new System.Windows.Forms.Label();
            this.rdoIsNotMember = new System.Windows.Forms.RadioButton();
            this.rdoIsMemer = new System.Windows.Forms.RadioButton();
            this.cboSweet = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.updPriceSpin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updPriceCool)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updPriceHot)).BeginInit();
            this.grpToping.SuspendLayout();
            this.grbDiscount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updTotalPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNote1
            // 
            this.lblNote1.AutoSize = true;
            this.lblNote1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblNote1.Location = new System.Drawing.Point(6, 169);
            this.lblNote1.Name = "lblNote1";
            this.lblNote1.Size = new System.Drawing.Size(83, 13);
            this.lblNote1.TabIndex = 13;
            this.lblNote1.Text = "ระดับความหวาน";
            // 
            // cboListMenu
            // 
            this.cboListMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboListMenu.FormattingEnabled = true;
            this.cboListMenu.Location = new System.Drawing.Point(94, 64);
            this.cboListMenu.Name = "cboListMenu";
            this.cboListMenu.Size = new System.Drawing.Size(121, 21);
            this.cboListMenu.TabIndex = 3;
            this.cboListMenu.SelectedIndexChanged += new System.EventHandler(this.cboListMenu_SelectedIndexChanged);
            this.cboListMenu.TextChanged += new System.EventHandler(this.cboListMenu_TextChanged);
            // 
            // lblListMenu
            // 
            this.lblListMenu.AutoSize = true;
            this.lblListMenu.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblListMenu.Location = new System.Drawing.Point(38, 67);
            this.lblListMenu.Name = "lblListMenu";
            this.lblListMenu.Size = new System.Drawing.Size(51, 13);
            this.lblListMenu.TabIndex = 2;
            this.lblListMenu.Text = "เลือกเมนู";
            // 
            // updPriceSpin
            // 
            this.updPriceSpin.Enabled = false;
            this.updPriceSpin.Location = new System.Drawing.Point(94, 143);
            this.updPriceSpin.Name = "updPriceSpin";
            this.updPriceSpin.Size = new System.Drawing.Size(100, 20);
            this.updPriceSpin.TabIndex = 11;
            this.updPriceSpin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.updPriceSpin.ThousandsSeparator = true;
            // 
            // updPriceCool
            // 
            this.updPriceCool.Enabled = false;
            this.updPriceCool.Location = new System.Drawing.Point(94, 117);
            this.updPriceCool.Name = "updPriceCool";
            this.updPriceCool.Size = new System.Drawing.Size(100, 20);
            this.updPriceCool.TabIndex = 8;
            this.updPriceCool.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.updPriceCool.ThousandsSeparator = true;
            // 
            // updPriceHot
            // 
            this.updPriceHot.Enabled = false;
            this.updPriceHot.Location = new System.Drawing.Point(94, 91);
            this.updPriceHot.Name = "updPriceHot";
            this.updPriceHot.Size = new System.Drawing.Size(100, 20);
            this.updPriceHot.TabIndex = 5;
            this.updPriceHot.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.updPriceHot.ThousandsSeparator = true;
            // 
            // lblPriceSpin
            // 
            this.lblPriceSpin.AutoSize = true;
            this.lblPriceSpin.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblPriceSpin.Location = new System.Drawing.Point(44, 147);
            this.lblPriceSpin.Name = "lblPriceSpin";
            this.lblPriceSpin.Size = new System.Drawing.Size(45, 13);
            this.lblPriceSpin.TabIndex = 10;
            this.lblPriceSpin.Text = "ราคาปั่น";
            // 
            // lblPriceCool
            // 
            this.lblPriceCool.AutoSize = true;
            this.lblPriceCool.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblPriceCool.Location = new System.Drawing.Point(39, 123);
            this.lblPriceCool.Name = "lblPriceCool";
            this.lblPriceCool.Size = new System.Drawing.Size(50, 13);
            this.lblPriceCool.TabIndex = 7;
            this.lblPriceCool.Text = "ราคาเย็น";
            // 
            // lblPriceHot
            // 
            this.lblPriceHot.AutoSize = true;
            this.lblPriceHot.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblPriceHot.Location = new System.Drawing.Point(39, 95);
            this.lblPriceHot.Name = "lblPriceHot";
            this.lblPriceHot.Size = new System.Drawing.Size(50, 13);
            this.lblPriceHot.TabIndex = 4;
            this.lblPriceHot.Text = "ราคาร้อน";
            // 
            // rdoHot
            // 
            this.rdoHot.AutoSize = true;
            this.rdoHot.BackColor = System.Drawing.Color.LightSkyBlue;
            this.rdoHot.Location = new System.Drawing.Point(201, 95);
            this.rdoHot.Name = "rdoHot";
            this.rdoHot.Size = new System.Drawing.Size(14, 13);
            this.rdoHot.TabIndex = 6;
            this.rdoHot.UseVisualStyleBackColor = false;
            this.rdoHot.CheckedChanged += new System.EventHandler(this.chkKaiMook_CheckedChanged);
            // 
            // rdoCool
            // 
            this.rdoCool.AutoSize = true;
            this.rdoCool.BackColor = System.Drawing.Color.LightSkyBlue;
            this.rdoCool.Checked = true;
            this.rdoCool.Location = new System.Drawing.Point(201, 121);
            this.rdoCool.Name = "rdoCool";
            this.rdoCool.Size = new System.Drawing.Size(14, 13);
            this.rdoCool.TabIndex = 9;
            this.rdoCool.TabStop = true;
            this.rdoCool.UseVisualStyleBackColor = false;
            this.rdoCool.CheckedChanged += new System.EventHandler(this.chkKaiMook_CheckedChanged);
            // 
            // rdoSpin
            // 
            this.rdoSpin.AutoSize = true;
            this.rdoSpin.BackColor = System.Drawing.Color.LightSkyBlue;
            this.rdoSpin.Location = new System.Drawing.Point(201, 147);
            this.rdoSpin.Name = "rdoSpin";
            this.rdoSpin.Size = new System.Drawing.Size(14, 13);
            this.rdoSpin.TabIndex = 12;
            this.rdoSpin.UseVisualStyleBackColor = false;
            this.rdoSpin.CheckedChanged += new System.EventHandler(this.chkKaiMook_CheckedChanged);
            // 
            // grpToping
            // 
            this.grpToping.BackColor = System.Drawing.Color.LightSkyBlue;
            this.grpToping.Controls.Add(this.chkIsJellyCaramel);
            this.grpToping.Controls.Add(this.chkFruitSalad);
            this.grpToping.Controls.Add(this.chkIsJellyStrawberry);
            this.grpToping.Controls.Add(this.chkIsJellyHoney);
            this.grpToping.Controls.Add(this.chkKaiMookPop);
            this.grpToping.Controls.Add(this.chkKaiMook);
            this.grpToping.Location = new System.Drawing.Point(259, 64);
            this.grpToping.Name = "grpToping";
            this.grpToping.Size = new System.Drawing.Size(240, 99);
            this.grpToping.TabIndex = 15;
            this.grpToping.TabStop = false;
            this.grpToping.Text = "ท็อปปิ้ง";
            // 
            // chkIsJellyCaramel
            // 
            this.chkIsJellyCaramel.AutoSize = true;
            this.chkIsJellyCaramel.Location = new System.Drawing.Point(138, 75);
            this.chkIsJellyCaramel.Name = "chkIsJellyCaramel";
            this.chkIsJellyCaramel.Size = new System.Drawing.Size(96, 17);
            this.chkIsJellyCaramel.TabIndex = 5;
            this.chkIsJellyCaramel.Text = "วุ้นคาราเมล (5)";
            this.chkIsJellyCaramel.UseVisualStyleBackColor = true;
            this.chkIsJellyCaramel.CheckedChanged += new System.EventHandler(this.chkKaiMook_CheckedChanged);
            // 
            // chkFruitSalad
            // 
            this.chkFruitSalad.AutoSize = true;
            this.chkFruitSalad.Location = new System.Drawing.Point(17, 75);
            this.chkFruitSalad.Name = "chkFruitSalad";
            this.chkFruitSalad.Size = new System.Drawing.Size(81, 17);
            this.chkFruitSalad.TabIndex = 4;
            this.chkFruitSalad.Text = "ฟลุ๊ตสลัด (5)";
            this.chkFruitSalad.UseVisualStyleBackColor = true;
            this.chkFruitSalad.CheckedChanged += new System.EventHandler(this.chkKaiMook_CheckedChanged);
            // 
            // chkIsJellyStrawberry
            // 
            this.chkIsJellyStrawberry.AutoSize = true;
            this.chkIsJellyStrawberry.Location = new System.Drawing.Point(138, 52);
            this.chkIsJellyStrawberry.Name = "chkIsJellyStrawberry";
            this.chkIsJellyStrawberry.Size = new System.Drawing.Size(98, 17);
            this.chkIsJellyStrawberry.TabIndex = 3;
            this.chkIsJellyStrawberry.Text = "วุ้นสตอเบอรี่ (5)";
            this.chkIsJellyStrawberry.UseVisualStyleBackColor = true;
            this.chkIsJellyStrawberry.CheckedChanged += new System.EventHandler(this.chkKaiMook_CheckedChanged);
            // 
            // chkIsJellyHoney
            // 
            this.chkIsJellyHoney.AutoSize = true;
            this.chkIsJellyHoney.Location = new System.Drawing.Point(138, 29);
            this.chkIsJellyHoney.Name = "chkIsJellyHoney";
            this.chkIsJellyHoney.Size = new System.Drawing.Size(65, 17);
            this.chkIsJellyHoney.TabIndex = 1;
            this.chkIsJellyHoney.Text = "วุ้นน้ำผึ้ง";
            this.chkIsJellyHoney.UseVisualStyleBackColor = true;
            this.chkIsJellyHoney.CheckedChanged += new System.EventHandler(this.chkKaiMook_CheckedChanged);
            // 
            // chkKaiMookPop
            // 
            this.chkKaiMookPop.AutoSize = true;
            this.chkKaiMookPop.Location = new System.Drawing.Point(17, 52);
            this.chkKaiMookPop.Name = "chkKaiMookPop";
            this.chkKaiMookPop.Size = new System.Drawing.Size(93, 17);
            this.chkKaiMookPop.TabIndex = 2;
            this.chkKaiMookPop.Text = "ไข่มุกป๊อบ (10)";
            this.chkKaiMookPop.UseVisualStyleBackColor = true;
            this.chkKaiMookPop.CheckedChanged += new System.EventHandler(this.chkKaiMook_CheckedChanged);
            // 
            // chkKaiMook
            // 
            this.chkKaiMook.AutoSize = true;
            this.chkKaiMook.Location = new System.Drawing.Point(17, 29);
            this.chkKaiMook.Name = "chkKaiMook";
            this.chkKaiMook.Size = new System.Drawing.Size(67, 17);
            this.chkKaiMook.TabIndex = 0;
            this.chkKaiMook.Text = "ไข่มุก (5)";
            this.chkKaiMook.UseVisualStyleBackColor = true;
            this.chkKaiMook.CheckedChanged += new System.EventHandler(this.chkKaiMook_CheckedChanged);
            // 
            // grbDiscount
            // 
            this.grbDiscount.BackColor = System.Drawing.Color.LightSkyBlue;
            this.grbDiscount.Controls.Add(this.btnSearch);
            this.grbDiscount.Controls.Add(this.txtMember);
            this.grbDiscount.Controls.Add(this.txtTel);
            this.grbDiscount.Controls.Add(this.updTotalPrice);
            this.grbDiscount.Controls.Add(this.lblTotalPrice);
            this.grbDiscount.Controls.Add(this.lblMember);
            this.grbDiscount.Controls.Add(this.updDiscount);
            this.grbDiscount.Controls.Add(this.lblTel);
            this.grbDiscount.Controls.Add(this.lblDiscount);
            this.grbDiscount.Controls.Add(this.updPrice);
            this.grbDiscount.Controls.Add(this.lblPrice);
            this.grbDiscount.Controls.Add(this.rdoIsNotMember);
            this.grbDiscount.Controls.Add(this.rdoIsMemer);
            this.grbDiscount.Location = new System.Drawing.Point(259, 169);
            this.grbDiscount.Name = "grbDiscount";
            this.grbDiscount.Size = new System.Drawing.Size(240, 172);
            this.grbDiscount.TabIndex = 0;
            this.grbDiscount.TabStop = false;
            this.grbDiscount.Text = "ส่วนลด";
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::FTPBubbleTea.Properties.Resources.search;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Location = new System.Drawing.Point(180, 71);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(23, 23);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtMember
            // 
            this.txtMember.Enabled = false;
            this.txtMember.Location = new System.Drawing.Point(74, 94);
            this.txtMember.Name = "txtMember";
            this.txtMember.Size = new System.Drawing.Size(100, 20);
            this.txtMember.TabIndex = 8;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(74, 72);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(100, 20);
            this.txtTel.TabIndex = 8;
            this.txtTel.TextChanged += new System.EventHandler(this.txtTel_TextChanged);
            // 
            // updTotalPrice
            // 
            this.updTotalPrice.Enabled = false;
            this.updTotalPrice.Location = new System.Drawing.Point(74, 146);
            this.updTotalPrice.Name = "updTotalPrice";
            this.updTotalPrice.Size = new System.Drawing.Size(100, 20);
            this.updTotalPrice.TabIndex = 7;
            this.updTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.updTotalPrice.ThousandsSeparator = true;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(23, 150);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(45, 13);
            this.lblTotalPrice.TabIndex = 6;
            this.lblTotalPrice.Text = "รวมสุทธิ";
            // 
            // lblMember
            // 
            this.lblMember.AutoSize = true;
            this.lblMember.Location = new System.Drawing.Point(19, 97);
            this.lblMember.Name = "lblMember";
            this.lblMember.Size = new System.Drawing.Size(52, 13);
            this.lblMember.TabIndex = 4;
            this.lblMember.Text = "ชื่อสมาชิก";
            // 
            // updDiscount
            // 
            this.updDiscount.Enabled = false;
            this.updDiscount.Location = new System.Drawing.Point(74, 120);
            this.updDiscount.Name = "updDiscount";
            this.updDiscount.Size = new System.Drawing.Size(100, 20);
            this.updDiscount.TabIndex = 5;
            this.updDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.updDiscount.ThousandsSeparator = true;
            this.updDiscount.ValueChanged += new System.EventHandler(this.updDiscount_ValueChanged);
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(19, 75);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(49, 13);
            this.lblTel.TabIndex = 4;
            this.lblTel.Text = "เบอร์โทร";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(28, 124);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(40, 13);
            this.lblDiscount.TabIndex = 4;
            this.lblDiscount.Text = "ส่วนลด";
            // 
            // updPrice
            // 
            this.updPrice.Enabled = false;
            this.updPrice.Location = new System.Drawing.Point(74, 19);
            this.updPrice.Name = "updPrice";
            this.updPrice.Size = new System.Drawing.Size(100, 20);
            this.updPrice.TabIndex = 1;
            this.updPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.updPrice.ThousandsSeparator = true;
            this.updPrice.ValueChanged += new System.EventHandler(this.updPrice_ValueChanged);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(19, 23);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(49, 13);
            this.lblPrice.TabIndex = 0;
            this.lblPrice.Text = "ราคารวม";
            // 
            // rdoIsNotMember
            // 
            this.rdoIsNotMember.AutoSize = true;
            this.rdoIsNotMember.Checked = true;
            this.rdoIsNotMember.Enabled = false;
            this.rdoIsNotMember.Location = new System.Drawing.Point(121, 48);
            this.rdoIsNotMember.Name = "rdoIsNotMember";
            this.rdoIsNotMember.Size = new System.Drawing.Size(76, 17);
            this.rdoIsNotMember.TabIndex = 3;
            this.rdoIsNotMember.TabStop = true;
            this.rdoIsNotMember.Text = "ลูกค้าทั่วไป";
            this.rdoIsNotMember.UseVisualStyleBackColor = true;
            this.rdoIsNotMember.CheckedChanged += new System.EventHandler(this.chkKaiMook_CheckedChanged);
            // 
            // rdoIsMemer
            // 
            this.rdoIsMemer.AutoSize = true;
            this.rdoIsMemer.Enabled = false;
            this.rdoIsMemer.Location = new System.Drawing.Point(12, 48);
            this.rdoIsMemer.Name = "rdoIsMemer";
            this.rdoIsMemer.Size = new System.Drawing.Size(106, 17);
            this.rdoIsMemer.TabIndex = 2;
            this.rdoIsMemer.Text = "เป็นสมาชิก (10%)";
            this.rdoIsMemer.UseVisualStyleBackColor = true;
            this.rdoIsMemer.CheckedChanged += new System.EventHandler(this.chkKaiMook_CheckedChanged);
            // 
            // cboSweet
            // 
            this.cboSweet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSweet.FormattingEnabled = true;
            this.cboSweet.Location = new System.Drawing.Point(94, 165);
            this.cboSweet.Name = "cboSweet";
            this.cboSweet.Size = new System.Drawing.Size(121, 21);
            this.cboSweet.TabIndex = 16;
            this.cboSweet.SelectedIndexChanged += new System.EventHandler(this.cboSweet_SelectedIndexChanged);
            // 
            // frmEntryOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 353);
            this.Controls.Add(this.cboSweet);
            this.Controls.Add(this.grbDiscount);
            this.Controls.Add(this.grpToping);
            this.Controls.Add(this.rdoSpin);
            this.Controls.Add(this.rdoCool);
            this.Controls.Add(this.rdoHot);
            this.Controls.Add(this.updPriceSpin);
            this.Controls.Add(this.updPriceCool);
            this.Controls.Add(this.updPriceHot);
            this.Controls.Add(this.lblPriceSpin);
            this.Controls.Add(this.lblPriceCool);
            this.Controls.Add(this.lblPriceHot);
            this.Controls.Add(this.cboListMenu);
            this.Controls.Add(this.lblNote1);
            this.Controls.Add(this.lblListMenu);
            entityBase1.EntityState = FTPBubbleTea.BC.EntityBase.EntityStates.Added;
            this.EntityBase = entityBase1;
            this.Name = "frmEntryOrder";
            this.Text = "frmEntryMenu";
            this.Controls.SetChildIndex(this.lblListMenu, 0);
            this.Controls.SetChildIndex(this.lblNote1, 0);
            this.Controls.SetChildIndex(this.cboListMenu, 0);
            this.Controls.SetChildIndex(this.lblPriceHot, 0);
            this.Controls.SetChildIndex(this.lblPriceCool, 0);
            this.Controls.SetChildIndex(this.lblPriceSpin, 0);
            this.Controls.SetChildIndex(this.updPriceHot, 0);
            this.Controls.SetChildIndex(this.updPriceCool, 0);
            this.Controls.SetChildIndex(this.updPriceSpin, 0);
            this.Controls.SetChildIndex(this.rdoHot, 0);
            this.Controls.SetChildIndex(this.rdoCool, 0);
            this.Controls.SetChildIndex(this.rdoSpin, 0);
            this.Controls.SetChildIndex(this.grpToping, 0);
            this.Controls.SetChildIndex(this.grbDiscount, 0);
            this.Controls.SetChildIndex(this.cboSweet, 0);
            ((System.ComponentModel.ISupportInitialize)(this.updPriceSpin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updPriceCool)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updPriceHot)).EndInit();
            this.grpToping.ResumeLayout(false);
            this.grpToping.PerformLayout();
            this.grbDiscount.ResumeLayout(false);
            this.grbDiscount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updTotalPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNote1;
        private System.Windows.Forms.ComboBox cboListMenu;
        private System.Windows.Forms.Label lblListMenu;
        private System.Windows.Forms.NumericUpDown updPriceSpin;
        private System.Windows.Forms.NumericUpDown updPriceCool;
        private System.Windows.Forms.NumericUpDown updPriceHot;
        private System.Windows.Forms.Label lblPriceSpin;
        private System.Windows.Forms.Label lblPriceCool;
        private System.Windows.Forms.Label lblPriceHot;
        private System.Windows.Forms.RadioButton rdoHot;
        private System.Windows.Forms.RadioButton rdoCool;
        private System.Windows.Forms.RadioButton rdoSpin;
        private System.Windows.Forms.GroupBox grpToping;
        private System.Windows.Forms.CheckBox chkIsJellyCaramel;
        private System.Windows.Forms.CheckBox chkFruitSalad;
        private System.Windows.Forms.CheckBox chkIsJellyStrawberry;
        private System.Windows.Forms.CheckBox chkIsJellyHoney;
        private System.Windows.Forms.CheckBox chkKaiMookPop;
        private System.Windows.Forms.CheckBox chkKaiMook;
        private System.Windows.Forms.GroupBox grbDiscount;
        private System.Windows.Forms.NumericUpDown updPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.NumericUpDown updTotalPrice;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.NumericUpDown updDiscount;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.RadioButton rdoIsNotMember;
        private System.Windows.Forms.RadioButton rdoIsMemer;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.TextBox txtMember;
        private System.Windows.Forms.Label lblMember;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cboSweet;
    }
}