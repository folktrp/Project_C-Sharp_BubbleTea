using FTPBubbleTea.BC;
using FTPBubbleTea.BC.Security;
using FTPBubbleTea.BL.Security;
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

namespace FTPBubbleTea.Forms.Security
{
    public partial class frmEntryUser : frmEntryBase
    {
        public frmEntryUser()
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
            User entity = (User)this.EntityBase;
            txtNote1.Text = entity.Note1;
            txtUser.Text = entity.UserId;
            txtUserName.Text = entity.UserName;
            txtPassword.Text = entity.Password;
            if (FrmMode == frmBrowseBase.Mode.Add)
            {
                txtUser.Enabled = true;
            }
            else
            {
                txtUser.Enabled = false;
            }
        }

        protected override EntityBase CreateNewEntity()
        {
            if (FrmMode == frmBrowseBase.Mode.Add)
            {
                return new User();
            }
            else
            {
                return _entityBase;
            }
        }

        protected override void SetControlToEntity()
        {
            User entity = (User)this.EntityBase;
            DateTime currentDate = DateTime.Now;
            entity.UserId = txtUser.Text;
            entity.UserName = txtUserName.Text;
            entity.Note1 = txtNote1.Text;
            entity.RoleId = 1;
            entity.UserRank = 1;
            entity.UserStatus = 1;
            entity.Password = txtPassword.Text;
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
            BLUser bl = new BLUser();
            User entity = (User)this.EntityBase;
            bl.Save(entity);
            MessageBox.Show("บันทึกข้อมูลสำเร็จ");
        }

        protected override void VaidateDateEntity()
        {
            User entity = (User)this.EntityBase;

            if (string.IsNullOrEmpty(entity.UserId))
            {
                throw new Exception(string.Format("ข้อมูล {0} ไม่สามารถว่างได้", lblUser.Text));
            }

            if (string.IsNullOrEmpty(entity.Password))
            {
                throw new Exception(string.Format("ข้อมูล {0} ไม่สามารถว่างได้", lblPassword.Text));
            }

            if (string.IsNullOrEmpty(entity.UserName))
            {
                throw new Exception(string.Format("ข้อมูล {0} ไม่สามารถว่างได้", lblUserName.Text));
            }

        }

        #endregion
    }
}
