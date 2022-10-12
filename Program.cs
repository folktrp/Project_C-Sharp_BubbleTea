using FTPBubbleTea.Forms;
using FTPBubbleTea.Forms.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FTPBubbleTea
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            //ถ้า Login สำเร็จจะเปิดหน้า frmMain
            frmLogin frm = new frmLogin();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new frmMain());  
            }
            else
            {
                return;
            }
        }
    }
}
