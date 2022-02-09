using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using FinalTest.View;

namespace FinalTest
{
    public partial class GiaoDienGame : Form
    {
        int life;
        int playerSpeed = 12;
        int enemySpeed = 2;
        int score = 0;
        int speedbullet = 10;
        int enemybulletTimer = 300;
        bool goLeft, goRight;
        bool shooter = false;
        bool isGameOver;
        bool isWin;
        bool isPause = true;
        bool Pause = false;
        SoundPlayer Sound = new SoundPlayer( Properties.Resources.Shooter);
        PictureBox[] AlientArray1;
        PictureBox[] AlientArray2;
        PictureBox[] AlientArray3;
        PictureBox[] AlientArray4;
        PictureBox[] AlientArray5;
        public GiaoDienGame()
        {
            InitializeComponent();
            gameSetup();
            HighScore();
        }
        //Chọn Phi Thuyền       
        private void GiaoDienGame_Load(object sender, EventArgs e)
        {
            if (ChonPhiThuyen.Ship == "1")
            {
                Sound = new SoundPlayer(Properties.Resources.Shooter2);
                pictureBox1.Image = Properties.Resources.SapceShip1;
            }
            else if (ChonPhiThuyen.Ship == "2")
            {
                Sound = new SoundPlayer(Properties.Resources.Shooter3);
                pictureBox1.Image = Properties.Resources.SapceShip2;
            }
            else if (ChonPhiThuyen.Ship == "3")
            {
                Sound = new SoundPlayer(Properties.Resources.Shooter4);
                pictureBox1.Image = Properties.Resources.SapceShip3;
            }
            else if (ChonPhiThuyen.Ship == "4")
            {
                Sound = new SoundPlayer(Properties.Resources.Shooter);
                pictureBox1.Image = Properties.Resources.SpaceShip4;
            }
        }

        //Tạo mạng sống cho player
        #region
        private void life_index()
        {
            if (life == 1)
            {
                SoundPlayer player = new SoundPlayer(Properties.Resources.Hit);
                player.Play();
                lif1.Image = Properties.Resources.life_white;
            }
            if (life == 2)
            {
                SoundPlayer player = new SoundPlayer(Properties.Resources.Hit);
                player.Play();
                lif2.Image = Properties.Resources.life_white;
            }
            if (life == 3)
            {
                SoundPlayer player = new SoundPlayer(Properties.Resources.Hit);
                player.Play();
                lif3.Image = Properties.Resources.life_white;
                gOver.Show();
                HighScore();
                txtThongbao.Show();
                txtScoreOver.Show();
                removeAll();
                txtThongbao.Text = "Nhấn Enter Đế Tiếp Tục";
                gameOver("Game Over");
            }

        }
        #endregion
        //GameTimer
        #region 
        private void maingameTimer(object sender, EventArgs e)
        {
            txtScore.Text = "Score: " + score;
            if (goLeft)
            {
                pictureBox1.Left -= playerSpeed;
            }
            if (goRight)
            {
                pictureBox1.Left += playerSpeed;
            }
            enemybulletTimer -= speedbullet;
            if (enemybulletTimer < 1 && isGameOver == false)
            {
                enemybulletTimer = 300;
                makeBullet("alienBullet");
                SoundPlayer player = new SoundPlayer(Properties.Resources.AlienShoot);
                player.Play();
            }
            //Vòng lập vị trí xuất hiện của Alien
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "AlienInvaders")
                {
                    x.Left += enemySpeed;
                    if (x.Left > 1450)
                    {
                        x.Top += 50;
                        x.Left = -90;
                    }
                    //Event khi player chạm vào alien
                    if (x.Bounds.IntersectsWith(pictureBox1.Bounds))
                    {
                        SoundPlayer player = new SoundPlayer(@"D:\Visual Studio Project\FinalTest\SoundEffect\Hit.wav");
                        player.Play();
                        life += 1;
                        life_index();
                    }
                    //Event + Score khi tiêu diệt ALien
                    foreach (Control y in this.Controls)
                    {
                        if (y is PictureBox && (string)y.Tag == "bullet")
                        {
                            if (y.Bounds.IntersectsWith(x.Bounds))
                            {
                                SoundPlayer sound = new SoundPlayer(Properties.Resources.AlienHit);
                                sound.Play();
                                this.Controls.Remove(x);
                                this.Controls.Remove(y);
                                score += 50;
                            }
                        }

                    }
                }
                //Event tạo vị trí xuất hiện đạn của Player
                if (x is PictureBox && (string)x.Tag == "bullet")
                {
                    x.Top -= 20;
                    if (x.Top < 15)
                    {
                        this.Controls.Remove(x);

                    }
                }
                //Event Khi Player Trúng Đạn Của Alien
                if (x is PictureBox && (string)x.Tag == "alienBullet")
                {
                    x.Top += 20;
                    if (x.Top > 1000)
                    {
                        this.Controls.Remove(x);
                    }
                    if (x.Bounds.IntersectsWith(pictureBox1.Bounds))
                    {
                        this.Controls.Remove(x);
                        life += 1;
                        life_index();
                    }
                }
            }
            //Tăng độ khó khi hạ được nhiều Alien và Tăng thêm đạn cho player
            #region
            if (score >= 1250)
            {
                enemySpeed = 5;
                speedbullet = 15;
            }
            if (score >= 1850)
            {
                shooter = true;
                enemySpeed = 10;
                speedbullet = 25;
            }
            else if (score >= 2750)
            {
                speedbullet = 35;
                enemySpeed = 30;
            }
            if (score == 3750)
            {
                txtWin.Show();
                gameOver(txtWin.Text = "Winner");
                txtScoreOver.Show();
                removeAll();
            }
            #endregion
        }
        #endregion
        //Sự kiện nhấn phím , tạo di chuyển 
        #region keyup&down event 
        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
            if (e.KeyCode == Keys.P || e.KeyCode == Keys.Escape)
            {
                if (Pause == false)
                {
                    isPause = false;
                    gameTimer.Stop();
                    panelPause.Show();
                }
                else
                {
                    isPause = true;
                    gameTimer.Start();
                    panelPause.Hide();
                }
                if (Pause == true)
                {
                    Pause = false;
                }
                else
                {
                    Pause = true;
                }
            }
        }
        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.Space && isWin == false && isPause == true)
            {             
                Sound.Play();
                makeBullet("bullet");

                if (shooter == true)
                {
                    makeBullet2("bullet");
                }
            }
            if (e.KeyCode == Keys.Enter && isGameOver == true)
            {
                removeAll();
                gameSetup();
            }
        }
        #endregion       
        //Tạo Alien
        #region       

        private void makeAlien1()
        {
            AlientArray1 = new PictureBox[15];
            int left = 0;
            for (int i = 0; i < AlientArray1.Length; i++)
            {
                AlientArray1[i] = new PictureBox();
                AlientArray1[i].Size = new Size(30, 30);
                AlientArray1[i].Image = Properties.Resources.Alient2;
                AlientArray1[i].Top = 50;
                AlientArray1[i].Tag = "AlienInvaders";
                AlientArray1[i].Left = left;
                AlientArray1[i].SizeMode = PictureBoxSizeMode.StretchImage;
                this.Controls.Add(AlientArray1[i]);
                left = left - 100;

            }
        }
        private void makeAlien2()
        {
            AlientArray2 = new PictureBox[15];
            int left = 0;
            for (int i = 0; i < AlientArray2.Length; i++)
            {
                AlientArray2[i] = new PictureBox();
                AlientArray2[i].Size = new Size(30, 30);
                AlientArray2[i].Image = Properties.Resources.Alient1;
                AlientArray2[i].Top = 200;
                AlientArray2[i].Tag = "AlienInvaders";
                AlientArray2[i].Left = left;
                AlientArray2[i].SizeMode = PictureBoxSizeMode.StretchImage;
                this.Controls.Add(AlientArray2[i]);
                left = left - 100;
            }
        }
        private void makeAlien3()
        {
            AlientArray3 = new PictureBox[15];
            int left = 0;
            for (int i = 0; i < AlientArray3.Length; i++)
            {
                AlientArray3[i] = new PictureBox();
                AlientArray3[i].Size = new Size(30, 30);
                AlientArray3[i].Image = Properties.Resources.pngegg;
                AlientArray3[i].Top = 350;
                AlientArray3[i].Tag = "AlienInvaders";
                AlientArray3[i].Left = left;
                AlientArray3[i].SizeMode = PictureBoxSizeMode.StretchImage;
                this.Controls.Add(AlientArray3[i]);
                left = left - 100;
            }
        }
        private void makeAlien4()
        {
            AlientArray4 = new PictureBox[15];
            int left = 0;
            for (int i = 0; i < AlientArray4.Length; i++)
            {
                AlientArray4[i] = new PictureBox();
                AlientArray4[i].Size = new Size(30, 30);
                AlientArray4[i].Image = Properties.Resources.Alien4;
                AlientArray4[i].Top = 500;
                AlientArray4[i].Tag = "AlienInvaders";
                AlientArray4[i].Left = left;
                AlientArray4[i].SizeMode = PictureBoxSizeMode.StretchImage;
                this.Controls.Add(AlientArray4[i]);
                left = left - 100;
            }
        }
        private void makeAlien5()
        {
            AlientArray5 = new PictureBox[15];
            int left = 0;
            for (int i = 0; i < AlientArray5.Length; i++)
            {
                AlientArray5[i] = new PictureBox();
                AlientArray5[i].Size = new Size(30, 30);
                AlientArray5[i].Image = Properties.Resources.Alien5;
                AlientArray5[i].Top = 650;
                AlientArray5[i].Tag = "AlienInvaders";
                AlientArray5[i].Left = left;
                AlientArray5[i].SizeMode = PictureBoxSizeMode.StretchImage;
                this.Controls.Add(AlientArray5[i]);
                left = left - 100;
            }
        }
        #endregion
        //Tạo súng cho player
        #region MakeBullet
        private void makeBullet(string bulletTag)
        {
            PictureBox bullet = new PictureBox();
            bullet.Size = new Size(2, 15);
            bullet.Tag = bulletTag;
            bullet.Left = pictureBox1.Left + pictureBox1.Width / 2;
            if ((string)bullet.Tag == "bullet")
            {
                bullet.Image = Properties.Resources.bullet3;
                bullet.Top = pictureBox1.Top - 20;

            }
            else if ((string)bullet.Tag == "alienBullet")
            {
                bullet.Image = Properties.Resources.bullet3;
                bullet.Top = -100;
                bullet.BringToFront();
            }
            this.Controls.Add(bullet);
            bullet.BringToFront();
        }
        private void makeBullet2(string bulletTag)
        {
            PictureBox bullet = new PictureBox();
            bullet.Image = Properties.Resources.bullet3;
            bullet.Size = new Size(2, 15);
            bullet.Tag = bulletTag;
            bullet.Left = pictureBox1.Left + pictureBox1.Width / 3;
            if ((string)bullet.Tag == "bullet")
            {
                bullet.Top = pictureBox1.Top - 20;
            }
            this.Controls.Add(bullet);
            bullet.BringToFront();
        }
        #endregion
        //Khởi tạo game mặc định
        #region
        private void gameSetup()
        {
            score = 0;
            isWin = false;
            isGameOver = false;
            enemybulletTimer = 300;
            enemySpeed = 5;
            panelPause.Hide();
            AllAlien();
            BtnExit.Hide();
            gOver.Hide();
            txtWin.Hide();
            txtScoreOver.Hide();
            txtThongbao.Hide();
            gameTimer.Start();
        }

        #endregion
        //Lưu High Score
        #region HighScore
        private void HighScore()
        {
            txtValue.Text = Properties.Settings.Default.hscore;
            int a = Int32.Parse(txtValue.Text);
            if (score > a)
            {
                txtValue.Text = score.ToString();
                Properties.Settings.Default.hscore = txtValue.Text;
                Properties.Settings.Default.Save();
            }
        }
        #endregion
        //Hàm gọi Alien
        #region
        private void AllAlien()
        {
            makeAlien1();
            makeAlien2();
            makeAlien3();
            makeAlien4();
            makeAlien5();
        }
        #endregion
        //Thông Báo Game Over/Win
        #region
        private void gameOver(string message)
        {
            if (message == "Game Over")
            {
                SoundPlayer player = new SoundPlayer(Properties.Resources.GameOver2);
                player.Play();
            }
            else
            {
                SoundPlayer player2 = new SoundPlayer(Properties.Resources.Win);
                player2.Play();
            }

            isGameOver = true;
            isWin = true;
            txtScore.Hide();
            gameTimer.Stop();
            BtnExit.Show();
            txtScoreOver.Text = "Score: " + score;
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    if ((string)x.Tag == "bullet" || (string)x.Tag == "alienBullet")
                    {
                        this.Controls.Remove(x);
                    }
                }
            }
        }
        #endregion
        //Khởi tạo lại game
        #region
        private void removeAll()
        {
            foreach (PictureBox i in AlientArray1)
            {
                this.Controls.Remove(i);
            }
            foreach (PictureBox i in AlientArray2)
            {
                this.Controls.Remove(i);
            }
            foreach (PictureBox i in AlientArray3)
            {
                this.Controls.Remove(i);
            }
            foreach (PictureBox i in AlientArray4)
            {
                this.Controls.Remove(i);
            }
            foreach (PictureBox i in AlientArray5)
            {
                this.Controls.Remove(i);
            }
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    if ((string)x.Tag == "bullet" || (string)x.Tag == "alienBullet")
                    {
                        this.Controls.Remove(x);
                    }
                }
            }
            lif1.Image = Properties.Resources.life;
            lif2.Image = Properties.Resources.life;
            lif3.Image = Properties.Resources.life;
            life = 0;
            shooter = false;
            enemySpeed = 2;
            speedbullet = 10;
            txtScore.Show();

        }
        //Button trở lại menu
        private void Exit_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources.Button);
            player.Play();
            GiaoDienChinh f1 = new GiaoDienChinh();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }
        #endregion
        //FormClosing Event
        #region
        private void GiaoDienGame_FormClosing(object sender, FormClosingEventArgs e)
        {


            DialogResult dlr = MessageBox.Show("Bạn muốn có thoát Game?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.No) e.Cancel = true;
            else
            {
                gameTimer.Stop();
                GiaoDienChinh F1 = new GiaoDienChinh();
                this.Hide();
                F1.ShowDialog();
                this.Close();
            }
        }
        #endregion
    }
}
