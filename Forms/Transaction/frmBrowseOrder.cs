using FTPBubbleTea.BC.Transaction;
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
    public partial class frmBrowseOrder : frmBrowseBase
    {
        public frmBrowseOrder()
        {
            InitializeComponent();
        }

         #region Protected Method

        protected override void Display()
        {
            lblTitle.Text = "การซื้อขาย";
            this.Text = lblTitle.Text;
        }

        protected override object GetListData()
        {
            BLOrder bl = new BLOrder();
            List<Order> entityCollection = bl.Find("0=0", "ID DESC");
            int sumPrice = 0;
            foreach (Order entity in entityCollection)
            {
                sumPrice += entity.TotalPrice;
            }

            lblTotalSum.Text = string.Format("ยอดขายปัจจุบัน {0:#,##0} บาท", sumPrice);
            return entityCollection;
        }

        protected override frmEntryBase GetFrmEntry()
        {
            return new frmEntryOrder();
        }

        protected override void Del()
        {
            BLOrder bl = new BLOrder();
            Order entity = (Order)dgvMain.CurrentRow.DataBoundItem;
            bl.Delete(entity);
            MessageBox.Show("ลบสำเร็จ");
        }

        protected override List<string> GetListDisplay()
        {
            List<string> displayList = new List<string>();
            displayList.Add("เลขคำสั่งซื้อ");
            displayList.Add("ราคาก่อนส่วนลด(บาท)");
            displayList.Add("ส่วนลด");
            displayList.Add("ราคาสุทธิ(บาท)");
            displayList.Add("ชื่อเมนู");
            displayList.Add("วิธีการ");
            displayList.Add("หมายเหตุ");
            displayList.Add("ไข่มุก");
            displayList.Add("ไข่มุกป๊อบ");
            displayList.Add("ฟุตสลัด");
            displayList.Add("วุ้นน้ำผึง");
            displayList.Add("วุ้นสตอเบอรี่");
            displayList.Add("วุ้นคาราเมล");
            displayList.Add("วันที่สร้าง");
            displayList.Add("ผู้สร้างข้อมูล");
            displayList.Add("วันที่แก้ไขข้อมูลล่าสุด");
            displayList.Add("ผู้แก้ไขข้อมูลล่าสุด");
            return displayList;
        }

        protected override List<string> GetListIndex()
        {
            List<string> indexList = new List<string>();
            indexList.Add("ID");
            indexList.Add("PRICE");
            indexList.Add("Discount");
            indexList.Add("TOTALPRICE");
            indexList.Add("MenuName");
            indexList.Add("MenuType");
            indexList.Add("Note1");
            indexList.Add("IsKaiMook");
            indexList.Add("IsMookPop");
            indexList.Add("IsFruitSalad");
            indexList.Add("IsJellyHoney");
            indexList.Add("IsJellyStrawberry");
            indexList.Add("IsJellyCaramel");
            indexList.Add("CreateDate");
            indexList.Add("CreateUser");
            indexList.Add("UpdateDate");
            indexList.Add("UpdateUser");
            return indexList;
        }

        #endregion
    }
}
