using FTPBubbleTea.BC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FTPBubbleTea.Forms.Base
{
    public partial class frmEntryBase : Form
    {
        #region Constructor
        /// <summary>
        /// Constructor
        /// </summary>
        public frmEntryBase()
        {
            InitializeComponent();
        }
        #endregion

        #region Fields
        /// <summary>
        /// Mode ของหน้าจอ
        /// </summary>
        protected FTPBubbleTea.Forms.Base.frmBrowseBase.Mode _frmMode = FTPBubbleTea.Forms.Base.frmBrowseBase.Mode.Add;

        /// <summary>
        /// ข้อมูล
        /// </summary>
        protected EntityBase _entityBase = null;


        #endregion

        #region Properties

        /// <summary>
        ///  Mode ของหน้าจอ
        /// </summary>
        public FTPBubbleTea.Forms.Base.frmBrowseBase.Mode FrmMode
        {
            get { return _frmMode; }
            set { _frmMode = value; }
        }

        /// <summary>
        /// ข้อมูล
        /// </summary>
        public EntityBase EntityBase
        {
            get { return _entityBase; }
            set { _entityBase = value; }
        }

        #endregion

        #region Event Control

        /// <summary>
        /// ฟอร์มโหลด
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmEntryBase_Load(object sender, EventArgs e)
        {
            try
            {
                Initialize();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// การกดปุ่มต่างๆ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Control control = (Control)sender;
                switch (control.Name)
                {
                    case "btnSave":
                        ClickSave();
                        break;
                    case "btnClose":
                        ClickClose();
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

        #region Protected Methods

        /// <summary>
        /// เริ่มการทำงาน
        /// </summary>
        protected virtual void Initialize()
        {
            EntityBase = CreateNewEntity();
            Display();
            SetEntityToControl();
          
        }

        /// <summary>
        /// Set หน้าจอ
        /// </summary>
        protected virtual void Display()
        {
            //Set Title
            if (_frmMode == frmBrowseBase.Mode.Add)
            {
                this.Text += " [เพิ่ม]";
            }
            else
            {
                this.Text += " [แก้ไข]";
            }
        }

        /// <summary>
        /// ข้อมูลจาก DataBase To Control
        /// </summary>
        protected virtual void SetEntityToControl()
        {

        }

        /// <summary>
        /// Get Database
        /// </summary>
        /// <returns></returns>
        protected virtual EntityBase CreateNewEntity()
        {
            return new EntityBase();
        }

        /// <summary>
        /// Set Control To Database
        /// </summary>
        protected virtual void SetControlToEntity()
        {

        }

        /// <summary>
        /// ตรวจสอบข้อมูลก่อน Save
        /// </summary>
        protected virtual void VaidateDateEntity()
        {

        }

        /// <summary>
        /// การ Save
        /// </summary>
        protected virtual void Save()
        {

        }

        /// <summary>
        /// กด Click Save
        /// </summary>
        protected virtual void ClickSave()
        {
            SetControlToEntity();
            VaidateDateEntity();
            Save();
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ClickClose();
        }

        /// <summary>
        /// กดปิด
        /// </summary>
        protected virtual void ClickClose()
        {
            this.Close();
        }


        #endregion


    }
}
