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
    public partial class frmEntryMember : frmEntryBase
    {
        public frmEntryMember()
        {
            InitializeComponent();
        }

        #region Protected Methods

        protected override void Display()
        {
            this.Text = "ข้อมูลสมาชิก";
            base.Display();
        }

        protected override void SetEntityToControl()
        {
            BC.Master.Member entity = (BC.Master.Member)this.EntityBase;
            txtName.Text = entity.Name;
            txtSurname.Text = entity.Surname;
            txtNickName.Text = entity.NickName;
            txtTel.Text = entity.Tel;
        }

        protected override EntityBase CreateNewEntity()
        {
            if (FrmMode == frmBrowseBase.Mode.Add)
            {
                return new BC.Master.Member();
            }
            else
            {
                return _entityBase;
            }
        }

        protected override void SetControlToEntity()
        {
            BC.Master.Member entity = (BC.Master.Member)this.EntityBase;
            DateTime currentDate = DateTime.Now;
            entity.Name = txtName.Text;
            entity.Surname = txtSurname.Text;
            entity.NickName = txtNickName.Text;
            entity.Tel = txtTel.Text;


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
            BLMember bl = new BLMember();
            BC.Master.Member entity = (BC.Master.Member)this.EntityBase;
            bl.Save(entity);
            MessageBox.Show("บันทึกข้อมูลสำเร็จ");
        }

        protected override void VaidateDateEntity()
        {
            BC.Master.Member entity = (BC.Master.Member)this.EntityBase;

            if (string.IsNullOrEmpty(entity.Name))
            {
                throw new Exception(string.Format("ข้อมูล {0} ไม่สามารถว่างได้", lblName.Text));
            }

        }

        #endregion

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
