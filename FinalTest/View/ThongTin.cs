using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace FinalTest.View
{
    public partial class ThongTin : Form
    {
        public ThongTin()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources.Button);
            player.Play();
            GiaoDienChinh F1 = new GiaoDienChinh();
            this.Hide();
            F1.ShowDialog();
            this.Close();
        }

        private void ThongTin_FormClosing(object sender, FormClosingEventArgs e)
        {
            GiaoDienChinh F1 = new GiaoDienChinh();
            this.Hide();
            F1.ShowDialog();
            this.Close();
        }
    }
}
