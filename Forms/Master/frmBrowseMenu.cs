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
    public partial class frmBrowseMenu : frmBrowseBase
    {
        #region Constructor
        /// <summary>
        /// Constructor
        /// </summary>
        public frmBrowseMenu()
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
            lblTitle.Text = "ข้อมูลเครื่องดื่ม";
            this.Text = lblTitle.Text;
        }

        /// <summary>
        /// override GetListData
        /// </summary>
        /// <returns></returns>
        /// <remarks>Get ข้อมูลจาก Database Table Menu</remarks>
        protected override object GetListData()
        {
            BLMenu bl = new BLMenu();
            return bl.Find("0=0","");
        }

        /// <summary>
        /// override GetFrmEntry
        /// </summary>
        /// <returns></returns>
        /// <remarks>Get frmEntryMenu</remarks>
        protected override frmEntryBase GetFrmEntry()
        {
            return new frmEntryMenu();
        }

        /// <summary>
        /// override Del
        /// </summary>
        /// <remarks>ลบข้อมูล Table Menu</remarks>
        protected override void Del()
        {
            BLMenu bl = new BLMenu();
            BC.Master.Menu entity = (BC.Master.Menu)dgvMain.CurrentRow.DataBoundItem;
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
            displayList.Add("ราคาเมนูร้อน");
            displayList.Add("ราคาเมนูเย็น");
            displayList.Add("ราคาเมนูปั่น");
            displayList.Add("หมายเหตุ");
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
            indexList.Add("Name");
            indexList.Add("PriceHot");
            indexList.Add("PriceCool");
            indexList.Add("PriceSpin");
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
