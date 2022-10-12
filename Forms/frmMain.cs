using FTPBubbleTea.Forms.Master;
using FTPBubbleTea.Forms.Security;
using FTPBubbleTea.Forms.Transaction;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FTPBubbleTea.Forms
{
    public partial class frmMain : Form
    {
        #region Constructor
        public frmMain()
        {
            InitializeComponent();
        }
        #endregion

        #region Event Control

        /// <summary>
        /// เปิดฟอร์ม
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                // Set Title
                this.Text = string.Format("{0} {1}", GlobalVariables.APP_NAME, GlobalVariables.VERSION);
                lblAppName.Text = GlobalVariables.APP_NAME;
                lblUser.Text = GlobalVariables.USER;
                lblDevBy.Text = string.Format("Dev By {0}", GlobalVariables.DEV_BY);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// เลือกเปิดหน้าจอ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnListMenu_Click(object sender, EventArgs e)
        {
            try
            {
                Control control = (Control)sender;

                switch (control.Name)
                {
                    case "btnListMenu": // Function ข้อมูลเครื่องดื่ม
                        frmBrowseMenu frmBrowseListMenu = new frmBrowseMenu();
                        frmBrowseListMenu.MdiParent = this;
                        frmBrowseListMenu.Show();
                        break;

                    case "btnOrder": // Function สั่งซื้อเครื่องื่ม
                        frmBrowseOrder frmBrowseOrder = new frmBrowseOrder();
                        frmBrowseOrder.MdiParent = this;
                        frmBrowseOrder.Show();
                        break;

                    case "btnMember": // Function ข้อมูลสมาชิก
                        frmBrowseMember frmBrowseMember = new frmBrowseMember();
                        frmBrowseMember.MdiParent = this;
                        frmBrowseMember.Show();
                        break;
                    case "btnUser": // Function ข้อมูลผู้ใช้ระบบ
                        frmBrowseUser frmBrowseUser = new frmBrowseUser();
                        frmBrowseUser.MdiParent = this;
                        frmBrowseUser.Show();
                        break;
                        
                    default:
                        break;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        private void picLogo_Click(object sender, EventArgs e)
        {

        }
    }
}
