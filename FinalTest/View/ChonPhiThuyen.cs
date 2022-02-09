using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FinalTest.View
{
    public partial class ChonPhiThuyen : Form
    {
        public ChonPhiThuyen()
        {
            InitializeComponent();
            rad1.Checked = true;
        }
        public static string Ship = "";
        private void btnChoose_Click(object sender, EventArgs e)
        {
            if (rad1.Checked == true)
            {
                Ship = "1";              
            }
            else if (rad2.Checked == true)
            {
                Ship = "2";           
            }
            else if (rad3.Checked == true)
            {
                Ship = "3";             
            }
            else if (rad4.Checked == true)
            {
                Ship = "4";            
            }
            GiaoDienGame f1 = new GiaoDienGame();
            this.Hide();
            f1.ShowDialog();
            this.Close();

        }
    }
}
