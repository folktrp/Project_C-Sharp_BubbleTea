using FTPBubbleTea.BC;
using FTPBubbleTea.BC.Master;
using FTPBubbleTea.BC.Security;
using FTPBubbleTea.BC.Transaction;
using FTPBubbleTea.BL.Master;
using FTPBubbleTea.BL.Security;
using FTPBubbleTea.BL.Transaction;
using FTPBubbleTea.Forms.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FTPBubbleTea.Forms.Transaction
{
    public partial class frmEntryOrder : frmEntryBase
    {
        public frmEntryOrder()
        {
            InitializeComponent();
        }

        #region Evenet Control

        private void cboListMenu_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboListMenu != null)
                {
                    BLMenu bl = new BLMenu();
                    BC.Master.Menu entity = bl.GetRecord(string.Format("NAME='{0}'", cboListMenu.Text));
                    if (entity != null)
                    {
                        updPriceCool.Value = entity.PriceCool;
                        updPriceHot.Value = entity.PriceHot;
                        updPriceSpin.Value = entity.PriceSpin;

                        if (updPriceCool.Value == 0)
                        {
                            rdoHot.Enabled = false;
                            rdoHot.Checked = false;
                        }
                        else
                        {
                            rdoHot.Enabled = true;
                        }
                        if (updPriceHot.Value == 0)
                        {
                            rdoHot.Checked = false;
                            rdoHot.Enabled = false;
                        }
                        else
                        {
                            rdoCool.Enabled = true;
                        }

                        if (updPriceSpin.Value == 0)
                        {
                            rdoHot.Checked = false;
                            rdoHot.Enabled = false;
                        }
                        else
                        {
                            rdoSpin.Enabled = true;
                        }
                        GetPrice();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                BLMember bl = new BLMember();
                string whereClause = string.Format("{0}='{1}'", "TEL", txtTel.Text);
                Member entity = bl.GetRecord(whereClause);
                if (entity != null)
                {
                    txtMember.Text = string.Format("{0} {1}", entity.Name, entity.Surname);
                    MessageBox.Show(string.Format("เป็นสมาชิก \r\nคุณ{0} {1} \r\nชื่อเล่น {2}  ", entity.Name, entity.Surname, entity.NickName));
                    rdoIsMemer.Checked = true;
                }
                else
                {
                    MessageBox.Show("ไม่พบข้อมูลสมาชิก");
                    rdoIsNotMember.Checked = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void chkKaiMook_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                GetPrice();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Protected Methods

        protected override void Display()
        {
            AddComboListMenu();
            AddComboSweet();
            this.Text = "ข้อมูลผู้ใช้ระบบ";
            base.Display();
            GetPrice();
        }

        protected override void SetEntityToControl()
        {
            Order entity = (Order)this.EntityBase;
            cboSweet.Text = entity.Note1;
            cboListMenu.Text = entity.MenuName;
            updDiscount.Value = entity.Discount;
            updPrice.Value = entity.Price;
            updTotalPrice.Value = entity.TotalPrice;
            chkFruitSalad.Checked = entity.IsFruitSalad;
            chkKaiMook.Checked = entity.IsKaiMook;
            chkIsJellyCaramel.Checked = entity.IsJellyCaramel;
            chkIsJellyHoney.Checked = entity.IsJellyHoney;
            chkIsJellyStrawberry.Checked = entity.IsJellyStrawberry;
            chkKaiMookPop.Checked = entity.IsMookPop;
            rdoIsMemer.Checked = entity.IsMember;
            txtMember.Text = entity.IdMember;
            if (FrmMode == frmBrowseBase.Mode.Edit)
            {
                if (entity.MenuType == "HOT")
                {
                    rdoHot.Checked = true;
                }
                else if (entity.MenuType == "COOL")
                {
                    rdoCool.Checked = true;
                }
                else if (entity.MenuType == "SPIN")
                {
                    rdoSpin.Checked = true;
                }
            }

        }

        protected override EntityBase CreateNewEntity()
        {
            if (FrmMode == frmBrowseBase.Mode.Add)
            {
                return new Order();
            }
            else
            {
                return _entityBase;
            }
        }

        protected override void SetControlToEntity()
        {
            Order entity = (Order)this.EntityBase;
            DateTime currentDate = DateTime.Now;
            entity.MenuName = cboListMenu.Text;
            entity.Note1 = cboSweet.Text;
            entity.MenuName = cboListMenu.Text;
            entity.Discount = (int)updDiscount.Value;
            entity.Price = (int)updPrice.Value;
            entity.TotalPrice = (int)updTotalPrice.Value;
            entity.IsFruitSalad = chkFruitSalad.Checked;
            entity.IsKaiMook = chkKaiMook.Checked;
            entity.IsJellyCaramel = chkIsJellyCaramel.Checked;
            entity.IsJellyHoney = chkIsJellyHoney.Checked;
            entity.IsJellyStrawberry = chkIsJellyStrawberry.Checked;
            entity.IsMookPop = chkKaiMookPop.Checked;
            entity.IsMember = rdoIsMemer.Checked;
            entity.IdMember = txtMember.Text;

            BLMenu bl = new BLMenu();
            BC.Master.Menu entityMenu = bl.GetRecord(string.Format("NAME='{0}'", cboListMenu.Text));
            if (entityMenu != null)
            {
                entity.MenuId = entityMenu.Id;
            }

            if (rdoHot.Checked)
            {
                entity.MenuType = "HOT";
            }
            else if (rdoCool.Checked)
            {
                entity.MenuType = "COOL";
            }
            else if (rdoSpin.Checked)
            {
                entity.MenuType = "SPIN";
            }

            if (FrmMode == frmBrowseBase.Mode.Add)
            {
                entity.CreateDate = currentDate;
                entity.CreateUser = GlobalVariables.USER;
                entity.UpdateDate = currentDate;
                entity.UpdateUser = GlobalVariables.USER;
                entity.EntityState = BC.EntityBase.EntityStates.Added;
            }
            else
            {
                entity.UpdateDate = currentDate;
                entity.UpdateUser = GlobalVariables.USER;
                entity.EntityState = BC.EntityBase.EntityStates.Change;
            }
        }

        protected override void Save()
        {
            BLOrder bl = new BLOrder();
            Order entity = (Order)this.EntityBase;
            bl.Save(entity);
            MessageBox.Show("บันทึกข้อมูลสำเร็จ");
        }

        protected override void VaidateDateEntity()
        {
            Order entity = (Order)this.EntityBase;

        }

        #endregion

        #region Private Methods

        private void AddComboListMenu()
        {
            BLMenu bl = new BLMenu();
            List<BC.Master.Menu> entityCollection = bl.Find("0=0", "");
            cboListMenu.DisplayMember = "Text";
            cboListMenu.ValueMember = "Value";
            foreach (BC.Master.Menu entity in entityCollection)
            {
                cboListMenu.Items.Add(new { Text = entity.Name, Value = entity.Id });
            }
        }
        private void AddComboSweet()
        {
            string[] arr = { "หวานมาก", "หวานปกติ", "หวานน้อย", "ไม่หวาน" };
            cboSweet.DisplayMember = "Text";
            cboSweet.ValueMember = "Value";
            foreach (var item in arr)
            {
                cboSweet.Items.Add(new { Text = item, Value = item });
            }
        }

        private void GetPrice()
        {
            int price = 0;
            if (rdoHot.Checked)
            {
                price = (int)updPriceHot.Value;
            }
            else if (rdoCool.Checked)
            {
                price = (int)updPriceCool.Value;
            }
            else if (rdoSpin.Checked)
            {
                price = (int)updPriceSpin.Value;
            }

            if (chkFruitSalad.Checked)
            {
                price += 5;
            }
            if (chkKaiMook.Checked)
            {
                price += 5;
            }
            if (chkKaiMookPop.Checked)
            {
                price += 10;
            }
            if (chkIsJellyCaramel.Checked)
            {
                price += 5;
            }
            if (chkIsJellyHoney.Checked)
            {
                price += 5;
            }
            if (chkIsJellyStrawberry.Checked)
            {
                price += 5;
            }


            updPrice.Value = price;
            updTotalPrice.Value = price;

            if (rdoIsMemer.Checked)
            {
                updDiscount.Value = (int)(price * 0.10);
                updTotalPrice.Value = updPrice.Value - updDiscount.Value;
            }
            else
            {
                updDiscount.Value = 0;
            }
        }

        #endregion

        private void txtTel_TextChanged(object sender, EventArgs e)
        {

        }

        private void updPrice_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cboListMenu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboSweet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void updDiscount_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
