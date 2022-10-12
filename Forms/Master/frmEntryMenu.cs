using FTPBubbleTea.BC;
using FTPBubbleTea.BL.Master;
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

namespace FTPBubbleTea.Forms.Master
{
    public partial class frmEntryMenu : frmEntryBase
    {
        public frmEntryMenu()
        {
            InitializeComponent();
        }

        #region Protected Methods

        protected override void Display()
        {
            this.Text = "ข้อมูลผู้ใช้ระบบ";
            base.Display();
        }

        protected override void SetEntityToControl()
        {
            BC.Master.Menu entity = (BC.Master.Menu)this.EntityBase;
            txtNote1.Text = entity.Note1;
            txtName.Text = entity.Name;
            updPriceCool.Value = entity.PriceCool;
            updPriceHot.Value = entity.PriceHot;
            updPriceSpin.Value = entity.PriceSpin;
        }

        protected override EntityBase CreateNewEntity()
        {
            if (FrmMode == frmBrowseBase.Mode.Add)
            {
                return new BC.Master.Menu();
            }
            else
            {
                return _entityBase;
            }
        }

        protected override void SetControlToEntity()
        {
            BC.Master.Menu entity = (BC.Master.Menu)this.EntityBase;
            DateTime currentDate = DateTime.Now;
            entity.Name = txtName.Text;
            entity.PriceCool = (int)updPriceCool.Value;
            entity.PriceHot = (int)updPriceHot.Value;
            entity.PriceSpin = (int)updPriceSpin.Value;
            entity.Note1 = txtNote1.Text;

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
            BLMenu bl = new BLMenu();
            BC.Master.Menu entity = (BC.Master.Menu)this.EntityBase;
            bl.Save(entity);
            MessageBox.Show("บันทึกข้อมูลสำเร็จ");
        }

        protected override void VaidateDateEntity()
        {
            BC.Master.Menu entity = (BC.Master.Menu)this.EntityBase;

            if (string.IsNullOrEmpty(entity.Name))
            {
                throw new Exception(string.Format("ข้อมูล {0} ไม่สามารถว่างได้", lblName.Text));
            }

        }

        #endregion
    }
}
