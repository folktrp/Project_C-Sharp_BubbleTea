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
    public partial class frmBrowseBase : Form
    {

        #region Fields
        /// <summary>
        /// 
        /// </summary>
        protected List<string> _indexColumn = new List<string>();
        /// <summary>
        /// 
        /// </summary>
        protected List<string> _displayColumn = new List<string>();

        #endregion

        #region Enum
        /// <summary>
        /// โหมดหน้าจอ Entry 
        /// </summary>
        public enum Mode
        {
            Edit, // แก้ไข
            Add // เพิ่ม
        }

        #endregion

        #region Constructor
        /// <summary>
        /// Constructor
        /// </summary>
        public frmBrowseBase()
        {
            InitializeComponent();
        }

        #endregion

        #region Event Control

        /// <summary>
        /// ฟอร์มโหลด
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmBrowseBase_Load(object sender, EventArgs e)
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
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Control control = (Control)sender;
                switch (control.Name)
                {
                    case "btnAdd":
                        ClickAdd();
                        break;
                    case "btnDel":
                        ClickDel();
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

        private void dgvMain_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                EditData(e.RowIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        #endregion

        #region Protected Methods
        /// <summary>
        /// โหลดครั้งแรก
        /// </summary>
        protected virtual void Initialize()
        {
            Display();
            GetDataToGrid();
        }

        /// <summary>
        /// แสดงข้อมูลไปที่หน้าจอ
        /// </summary>
        protected virtual void Display()
        {

        }

        /// <summary>
        /// Get ข้อมูลไป DataGridView
        /// </summary>
        protected virtual void GetDataToGrid()
        {
            dgvMain.DataSource = GetListData();
            _indexColumn = GetListIndex();
            _displayColumn = GetListDisplay();
            SetIndexColumn();
        }

        /// <summary>
        /// Get ข้อมูล
        /// </summary>
        /// <returns></returns>
        protected virtual object GetListData()
        {
            return null;
        }

       /// <summary>
       /// การกดปุ่มเพิ่มข้อมูล
       /// </summary>
        protected virtual void ClickAdd()
        {
            frmEntryBase frm = GetFrmEntry();
            frm.FrmMode = Mode.Add;
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                GetDataToGrid();
            }
        }

        /// <summary>
        /// การกดปุ่มลบข้อมูล
        /// </summary>
        protected virtual void ClickDel()
        {
            object del = (EntityBase)dgvMain.CurrentRow.DataBoundItem;
            if (del != null && MessageBox.Show("คุณต้องการลบข้อมูลใช่หรือไม่ ?", "ยืนยันการลบข้อมูล", MessageBoxButtons.YesNo,
        MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
            {
                Del();
                GetDataToGrid();
            }
        }

        /// <summary>
        /// การลบข้อมูล
        /// </summary>
        protected virtual void Del()
        {

        }

        /// <summary>
        /// การกดแก้ไข
        /// </summary>
        /// <param name="rowsIndex"></param>
        protected virtual void EditData(int rowsIndex)
        {
            frmEntryBase frm = GetFrmEntry();
            frm.FrmMode = Mode.Edit;
            frm.EntityBase = (EntityBase)dgvMain.CurrentRow.DataBoundItem;
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                GetDataToGrid();
            }
        }

        /// <summary>
        /// การ Get หน้าจอ Entry
        /// </summary>
        /// <returns></returns>
        protected virtual frmEntryBase GetFrmEntry()
        {
            return new frmEntryBase();
        }

        /// <summary>
        /// Get ชื่อคอลัม
        /// </summary>
        /// <returns></returns>
        protected virtual List<string> GetListDisplay()
        {
            return new List<string>();
        }

        /// <summary>
        /// Get ลำดับคอลัม
        /// </summary>
        /// <returns></returns>
        protected virtual List<string> GetListIndex()
        {
            return new List<string>();
        }
  
        /// <summary>
        /// Set ลำดับและชื่อคอลัม
        /// </summary>
        protected virtual void SetIndexColumn()
        {
            if (_indexColumn.Count > 0)
            {
                for (int i = 0; i < dgvMain.Columns.Count; i++)
                {
                    dgvMain.Columns[i].Visible = false;
                }
                for (int i = 0; i < dgvMain.ColumnCount; i++)
                {
                    for (int j = 0; j < _indexColumn.Count; j++)
                    {
                        if (dgvMain.Columns[i].Name.ToLower() == _indexColumn[j].ToLower())
                        {
                            dgvMain.Columns[i].DisplayIndex = j;
                            dgvMain.Columns[i].Visible = true;
                            dgvMain.Columns[i].HeaderText = _displayColumn[j];
                        }
                    }
                }
            }
        }
        #endregion

    }
}
