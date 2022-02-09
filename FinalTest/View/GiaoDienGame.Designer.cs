namespace FinalTest
{
    partial class GiaoDienGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GiaoDienGame));
            this.txtScore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.gOver = new System.Windows.Forms.Label();
            this.txtScoreOver = new System.Windows.Forms.Label();
            this.txtThongbao = new System.Windows.Forms.Label();
            this.txtHscore = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.Label();
            this.txtWin = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lif3 = new System.Windows.Forms.PictureBox();
            this.lif2 = new System.Windows.Forms.PictureBox();
            this.lif1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelPause = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnExit = new Space_Shooter.ButtonCustomize();
            ((System.ComponentModel.ISupportInitialize)(this.lif3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lif2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lif1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelPause.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.BackColor = System.Drawing.Color.Black;
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtScore.ForeColor = System.Drawing.Color.Red;
            this.txtScore.Location = new System.Drawing.Point(12, 918);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(107, 31);
            this.txtScore.TabIndex = 1;
            this.txtScore.Text = "Score: ";
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.maingameTimer);
            // 
            // gOver
            // 
            this.gOver.AutoSize = true;
            this.gOver.Font = new System.Drawing.Font("Ravie", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gOver.ForeColor = System.Drawing.Color.SteelBlue;
            this.gOver.Location = new System.Drawing.Point(512, 437);
            this.gOver.Name = "gOver";
            this.gOver.Size = new System.Drawing.Size(416, 63);
            this.gOver.TabIndex = 5;
            this.gOver.Text = "GAME OVER";
            // 
            // txtScoreOver
            // 
            this.txtScoreOver.AutoSize = true;
            this.txtScoreOver.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtScoreOver.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtScoreOver.Location = new System.Drawing.Point(661, 500);
            this.txtScoreOver.Name = "txtScoreOver";
            this.txtScoreOver.Size = new System.Drawing.Size(113, 40);
            this.txtScoreOver.TabIndex = 6;
            this.txtScoreOver.Text = "Score : ";
            // 
            // txtThongbao
            // 
            this.txtThongbao.AutoSize = true;
            this.txtThongbao.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThongbao.ForeColor = System.Drawing.Color.Gray;
            this.txtThongbao.Location = new System.Drawing.Point(481, 394);
            this.txtThongbao.Name = "txtThongbao";
            this.txtThongbao.Size = new System.Drawing.Size(461, 43);
            this.txtThongbao.TabIndex = 7;
            this.txtThongbao.Text = "Press Enter To Continue ";
            // 
            // txtHscore
            // 
            this.txtHscore.AutoSize = true;
            this.txtHscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtHscore.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtHscore.Location = new System.Drawing.Point(-2, 3);
            this.txtHscore.Name = "txtHscore";
            this.txtHscore.Size = new System.Drawing.Size(142, 25);
            this.txtHscore.TabIndex = 8;
            this.txtHscore.Text = "High Score: ";
            // 
            // txtValue
            // 
            this.txtValue.AutoSize = true;
            this.txtValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtValue.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtValue.Location = new System.Drawing.Point(127, 3);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(25, 25);
            this.txtValue.TabIndex = 9;
            this.txtValue.Text = "0";
            // 
            // txtWin
            // 
            this.txtWin.AutoSize = true;
            this.txtWin.Font = new System.Drawing.Font("Ravie", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWin.ForeColor = System.Drawing.Color.IndianRed;
            this.txtWin.Location = new System.Drawing.Point(427, 371);
            this.txtWin.Name = "txtWin";
            this.txtWin.Size = new System.Drawing.Size(577, 129);
            this.txtWin.TabIndex = 10;
            this.txtWin.Text = "WINNER";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lif3
            // 
            this.lif3.Image = global::FinalTest.Properties.Resources.life;
            this.lif3.Location = new System.Drawing.Point(1440, 3);
            this.lif3.Name = "lif3";
            this.lif3.Size = new System.Drawing.Size(32, 32);
            this.lif3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.lif3.TabIndex = 4;
            this.lif3.TabStop = false;
            // 
            // lif2
            // 
            this.lif2.Image = global::FinalTest.Properties.Resources.life;
            this.lif2.Location = new System.Drawing.Point(1402, 3);
            this.lif2.Name = "lif2";
            this.lif2.Size = new System.Drawing.Size(32, 32);
            this.lif2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.lif2.TabIndex = 3;
            this.lif2.TabStop = false;
            // 
            // lif1
            // 
            this.lif1.Image = global::FinalTest.Properties.Resources.life;
            this.lif1.Location = new System.Drawing.Point(1364, 3);
            this.lif1.Name = "lif1";
            this.lif1.Size = new System.Drawing.Size(32, 32);
            this.lif1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.lif1.TabIndex = 2;
            this.lif1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::FinalTest.Properties.Resources.SpaceShip4;
            this.pictureBox1.Location = new System.Drawing.Point(701, 899);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelPause
            // 
            this.panelPause.Controls.Add(this.label3);
            this.panelPause.Controls.Add(this.label2);
            this.panelPause.Location = new System.Drawing.Point(489, 371);
            this.panelPause.Name = "panelPause";
            this.panelPause.Size = new System.Drawing.Size(461, 169);
            this.panelPause.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(32, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(407, 73);
            this.label3.TabIndex = 1;
            this.label3.Text = "Game Pause";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.IndianRed;
            this.label2.Location = new System.Drawing.Point(73, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(328, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Press P or Esc To Coninue";
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnExit.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.BtnExit.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnExit.BorderRadius = 20;
            this.BtnExit.BorderSize = 0;
            this.BtnExit.FlatAppearance.BorderSize = 0;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.ForeColor = System.Drawing.Color.White;
            this.BtnExit.Location = new System.Drawing.Point(1322, 918);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(150, 40);
            this.BtnExit.TabIndex = 12;
            this.BtnExit.Text = "Go To Menu";
            this.BtnExit.TextColor = System.Drawing.Color.White;
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // GiaoDienGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1484, 961);
            this.Controls.Add(this.panelPause);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.txtWin);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.txtHscore);
            this.Controls.Add(this.txtThongbao);
            this.Controls.Add(this.txtScoreOver);
            this.Controls.Add(this.gOver);
            this.Controls.Add(this.lif3);
            this.Controls.Add(this.lif2);
            this.Controls.Add(this.lif1);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GiaoDienGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Space Shooting";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GiaoDienGame_FormClosing);
            this.Load += new System.EventHandler(this.GiaoDienGame_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.lif3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lif2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lif1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelPause.ResumeLayout(false);
            this.panelPause.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox lif1;
        private System.Windows.Forms.PictureBox lif2;
        private System.Windows.Forms.PictureBox lif3;
        private System.Windows.Forms.Label gOver;
        private System.Windows.Forms.Label txtScoreOver;
        private System.Windows.Forms.Label txtThongbao;
        private System.Windows.Forms.Label txtHscore;
        private System.Windows.Forms.Label txtValue;
        private System.Windows.Forms.Label txtWin;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private Space_Shooter.ButtonCustomize BtnExit;
        private System.Windows.Forms.Panel panelPause;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}