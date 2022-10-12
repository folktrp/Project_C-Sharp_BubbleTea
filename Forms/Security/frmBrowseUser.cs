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
    public partial class frmBrowseUser : frmBrowseBase
    {
        public frmBrowseUser()
        {
            InitializeComponent();
        }


        #region Protected Method

        protected override void Display()
        {
            lblTitle.Text = "ข้อมูลผู้ใช้ระบบ";
            this.Text = lblTitle.Text;
        }

        protected override object GetListData()
        {
            BLUser bl = new BLUser();
            return bl.Find("0=0","");
        }

        protected override frmEntryBase GetFrmEntry()
        {
            return new frmEntryUser();
        }

        protected override void Del()
        {
            BLUser bl = new BLUser();
            User entity = (User)dgvMain.CurrentRow.DataBoundItem;
            bl.Delete(entity);
            MessageBox.Show("ลบสำเร็จ");
        }

        protected override List<string> GetListDisplay()
        {
            List<string> displayList = new List<string>();
            displayList.Add("ชื่อผู้ใช้ระบบ");
            displayList.Add("ชื่อผู้ใช้");
            displayList.Add("วันที่เข้าระบบล่าสุด");
            displayList.Add("หมายเหตุ");

            displayList.Add("วันที่สร้าง");
            displayList.Add("ผู้สร้างข้อมูล");
            displayList.Add("วันที่แก้ไขข้อมูลล่าสุด");
            displayList.Add("ผู้แก้ไขข้อมูลล่าสุด");
            return displayList;
        }

        protected override List<string> GetListIndex()
        {
            List<string> indexList = new List<string>();
            indexList.Add("UserId");
            indexList.Add("UserName");
            indexList.Add("LastLoginDate");
            indexList.Add("Note1");


            indexList.Add("CreateDate");
            indexList.Add("CreateUser");
            indexList.Add("UpdateDate");
            indexList.Add("UpdateUser");
            return indexList;
        }

        #endregion

    }
}
