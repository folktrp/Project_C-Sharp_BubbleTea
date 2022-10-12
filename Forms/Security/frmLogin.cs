using FTPBubbleTea.BC.Security;
using FTPBubbleTea.BL.Security;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FTPBubbleTea.Forms.Security
{
    public partial class frmLogin : Form
    {
        #region Constructor
        public frmLogin()
        {
            InitializeComponent();
        }
        #endregion

        #region Event Control

        /// <summary>
        /// ปิดจอหน้าจอ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        /// <summary>
        /// กดเข้าสู่ระบบ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                // เช็ค User ว่าง
                if (string.IsNullOrEmpty(txtUserId.Text))
                {
                    throw new Exception(string.Format("กรุณากรอกข้อมูล {0}",lblUserId.Text));
                }
                // เช็ค Password ว่าง
                if (string.IsNullOrEmpty(txtPassword.Text))
                {
                    throw new Exception(string.Format("กรุณากรอกข้อมูล {0}", lblPassword.Text));
                }

                // Get ข้อมูล User จาก Database
                BLUser bl = new BLUser();
                string whereClause = string.Format("{0}='{1}' AND {2}='{3}'", "USER_ID", txtUserId.Text, "PASSWORD", txtPassword.Text);
                //ถ้า User และ Password นี้มีข้อมูลจะ Login สำเร็จ
                  if (bl.GetCount(whereClause) > 0)
                {
                    User entity = bl.GetRecord(whereClause);// Get ข้อมูลจาก ฐานข้อมูล ด้วย User, Password
                    if (entity != null)
                    {
                        // Update วันที่เข้าใช้งานล่าสุด
                        entity.LastLoginDate = DateTime.Now;
                        bl.Save(entity);// Save ข้อมูล
                    }
                    // Set User ที่เข้าระบบ
                    GlobalVariables.USER = txtUserId.Text;
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    Properties.Settings.Default["userLogin"] = txtUserId.Text;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    throw new Exception("ข้อมูลไม่ถูกต้อง");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// เปิดฟอร์ม
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                //Set Title App Name + Version
                this.Text = string.Format("{0} {1}", GlobalVariables.APP_NAME, GlobalVariables.VERSION);
                // Set User ที่เข้าระบบล่าสุด
                txtUserId.Text = Properties.Settings.Default["userLogin"].ToString();
                if (!string.IsNullOrEmpty(txtUserId.Text ))
                {
                    txtPassword.Select();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        private void txtUserId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
