using FTPBubbleTea.BC.Security;
using FTPBubbleTea.BL.Master;
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

namespace FTPBubbleTea.Forms.Master
{
    public partial class frmBrowseMember : frmBrowseBase
    {
        #region Constructor
        /// <summary>
        /// Constructor
        /// </summary>
        public frmBrowseMember()
        {
            InitializeComponent();
        }
        #endregion

        #region Protected Method
        /// <summary>
        /// override Display
        /// </summary>
        protected override void Display()
        {
            lblTitle.Text = "ข้อมูลสมาชิก";
            this.Text = lblTitle.Text;
        }

        /// <summary>
        /// override GetListData
        /// </summary>
        /// <returns></returns>
        /// <remarks>Get ข้อมูลจาก Database Table Member</remarks>
        protected override object GetListData()
        {
            BLMember bl = new BLMember();
            return bl.Find("0=0","");
        }

        /// <summary>
        /// override GetFrmEntry
        /// </summary>
        /// <returns></returns>
        /// <remarks>Get frmEntryMember</remarks>
        protected override frmEntryBase GetFrmEntry()
        {
            return new frmEntryMember();
        }

        /// <summary>
        /// override Del
        /// </summary>
        /// <remarks>ลบข้อมูล Table Member</remarks>
        protected override void Del()
        {
            BLMember bl = new BLMember();
            BC.Master.Member entity = (BC.Master.Member)dgvMain.CurrentRow.DataBoundItem;
            bl.Delete(entity);
            MessageBox.Show("ลบสำเร็จ");
        }

        /// <summary>
        /// Set ชื่อคอลัม
        /// </summary>
        /// <returns></returns>
        protected override List<string> GetListDisplay()
        {
            List<string> displayList = new List<string>();
            displayList.Add("รหัส");
            displayList.Add("ชื่อ");
            displayList.Add("นามสกุล");
            displayList.Add("ชื่อเล่น");
            displayList.Add("เบอร์โทร");
            displayList.Add("วันที่สร้าง");
            displayList.Add("ผู้สร้างข้อมูล");
            displayList.Add("วันที่แก้ไขข้อมูลล่าสุด");
            displayList.Add("ผู้แก้ไขข้อมูลล่าสุด");
            return displayList;
        }

        /// <summary>
        /// Set ลำดับคอลัม
        /// </summary>
        /// <returns></returns>
        protected override List<string> GetListIndex()
        {
            List<string> indexList = new List<string>();
            indexList.Add("Id");
            indexList.Add("NAME");
            indexList.Add("SURNAME");
            indexList.Add("NICKNAME");
            indexList.Add("TEL");
            indexList.Add("CreateDate");
            indexList.Add("CreateUser");
            indexList.Add("UpdateDate");
            indexList.Add("UpdateUser");
            return indexList;
        }

        #endregion

    }
}
