using FinalTest.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace FinalTest
{
    public partial class GiaoDienChinh : Form
    {
        bool Pausemusic = false;
        public GiaoDienChinh()
        {
            InitializeComponent();
            SoundPlayer player = new SoundPlayer(Properties.Resources.ĐỘ_TỘC_2___FROM_MIXI_WITH_LOVE___MASEW_x_PHÚC_DU_x_PHÁO_x_ĐỘ_MIXI__OFFICIAL_MV_LYRIC___mp3cut_net_);
            player.PlayLooping();
        }

        // Tắt/Mở nhạc nền
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (Pausemusic == false)
            {
                Sound.Image = Properties.Resources.Mute;
                SoundPlayer player = new SoundPlayer(Properties.Resources.ĐỘ_TỘC_2___FROM_MIXI_WITH_LOVE___MASEW_x_PHÚC_DU_x_PHÁO_x_ĐỘ_MIXI__OFFICIAL_MV_LYRIC___mp3cut_net_);
                player.Stop();
            }
            else
            {
                Sound.Image = Properties.Resources.Sound;
                SoundPlayer player = new SoundPlayer(Properties.Resources.ĐỘ_TỘC_2___FROM_MIXI_WITH_LOVE___MASEW_x_PHÚC_DU_x_PHÁO_x_ĐỘ_MIXI__OFFICIAL_MV_LYRIC___mp3cut_net_);
                player.PlayLooping();
            }
            if (Pausemusic == false)
            {
                Pausemusic = true;
            }
            else
            {
                Pausemusic = false;
            }
        }
        //Button vào game
        private void btnStart_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources.Button);
            player.Play();
            GiaoDienGame F1 = new GiaoDienGame();
            this.Hide();
            F1.ShowDialog();
            this.Close();
        }
        //Button Thông Tin
        private void btnAbout_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources.Button);
            player.Play();
            ThongTin inf = new ThongTin();
            this.Hide();
            inf.ShowDialog();
            this.Close();
        }
        //Button Thoát
        private void btnExit_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources.Button);
            player.Play();
            this.Close();
        }
        //Event Form Closing
        private void GiaoDienChinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn muốn có thoát Game?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.No) e.Cancel = true;
            else if (dlr == DialogResult.Yes) e.Cancel = false;
        }

        private void btnSpaceShip_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources.Button);
            player.Play();
            ChonPhiThuyen f1 = new ChonPhiThuyen();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }
    }
}
