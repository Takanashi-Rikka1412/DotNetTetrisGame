namespace TetrisGame
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tab = new System.Windows.Forms.TabControl();
            this.tabMenu = new System.Windows.Forms.TabPage();
            this.tabGame = new System.Windows.Forms.TabPage();
            this.lblScoreNum = new System.Windows.Forms.Label();
            this.lblLevelNum = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.pnlNext = new System.Windows.Forms.Panel();
            this.pnlGame = new System.Windows.Forms.Panel();
            this.tabScoreBoard = new System.Windows.Forms.TabPage();
            this.btnMenu2 = new System.Windows.Forms.Button();
            this.dgvScoreBoard = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.btnMinForm = new System.Windows.Forms.Button();
            this.picTitle = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.picTetris = new System.Windows.Forms.PictureBox();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnScoreBoard = new System.Windows.Forms.Button();
            this.picGameOver = new System.Windows.Forms.PictureBox();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.tab.SuspendLayout();
            this.tabMenu.SuspendLayout();
            this.tabGame.SuspendLayout();
            this.pnlGame.SuspendLayout();
            this.tabScoreBoard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScoreBoard)).BeginInit();
            this.pnlTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTetris)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGameOver)).BeginInit();
            this.SuspendLayout();
            // 
            // tab
            // 
            this.tab.Controls.Add(this.tabMenu);
            this.tab.Controls.Add(this.tabGame);
            this.tab.Controls.Add(this.tabScoreBoard);
            this.tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab.ItemSize = new System.Drawing.Size(0, 1);
            this.tab.Location = new System.Drawing.Point(0, 0);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(700, 900);
            this.tab.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tab.TabIndex = 0;
            // 
            // tabMenu
            // 
            this.tabMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tabMenu.Controls.Add(this.btnStart);
            this.tabMenu.Controls.Add(this.picTetris);
            this.tabMenu.Controls.Add(this.btnQuit);
            this.tabMenu.Controls.Add(this.btnScoreBoard);
            this.tabMenu.Location = new System.Drawing.Point(4, 5);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.Size = new System.Drawing.Size(692, 891);
            this.tabMenu.TabIndex = 0;
            // 
            // tabGame
            // 
            this.tabGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.tabGame.Controls.Add(this.lblScoreNum);
            this.tabGame.Controls.Add(this.lblLevelNum);
            this.tabGame.Controls.Add(this.lblScore);
            this.tabGame.Controls.Add(this.lblLevel);
            this.tabGame.Controls.Add(this.pnlNext);
            this.tabGame.Controls.Add(this.pnlGame);
            this.tabGame.Controls.Add(this.btnMenu);
            this.tabGame.Controls.Add(this.btnRestart);
            this.tabGame.Location = new System.Drawing.Point(4, 5);
            this.tabGame.Name = "tabGame";
            this.tabGame.Size = new System.Drawing.Size(692, 891);
            this.tabGame.TabIndex = 1;
            // 
            // lblScoreNum
            // 
            this.lblScoreNum.AutoSize = true;
            this.lblScoreNum.Font = new System.Drawing.Font("宋体", 15F);
            this.lblScoreNum.ForeColor = System.Drawing.Color.White;
            this.lblScoreNum.Location = new System.Drawing.Point(548, 374);
            this.lblScoreNum.Name = "lblScoreNum";
            this.lblScoreNum.Size = new System.Drawing.Size(0, 30);
            this.lblScoreNum.TabIndex = 7;
            // 
            // lblLevelNum
            // 
            this.lblLevelNum.AutoSize = true;
            this.lblLevelNum.Font = new System.Drawing.Font("宋体", 15F);
            this.lblLevelNum.ForeColor = System.Drawing.Color.White;
            this.lblLevelNum.Location = new System.Drawing.Point(548, 312);
            this.lblLevelNum.Name = "lblLevelNum";
            this.lblLevelNum.Size = new System.Drawing.Size(0, 30);
            this.lblLevelNum.TabIndex = 6;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("宋体", 15F);
            this.lblScore.ForeColor = System.Drawing.Color.White;
            this.lblScore.Location = new System.Drawing.Point(446, 374);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(73, 30);
            this.lblScore.TabIndex = 5;
            this.lblScore.Text = "分数";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Font = new System.Drawing.Font("宋体", 15F);
            this.lblLevel.ForeColor = System.Drawing.Color.White;
            this.lblLevel.Location = new System.Drawing.Point(446, 312);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(73, 30);
            this.lblLevel.TabIndex = 4;
            this.lblLevel.Text = "等级";
            // 
            // pnlNext
            // 
            this.pnlNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnlNext.Location = new System.Drawing.Point(454, 83);
            this.pnlNext.Name = "pnlNext";
            this.pnlNext.Size = new System.Drawing.Size(160, 160);
            this.pnlNext.TabIndex = 1;
            // 
            // pnlGame
            // 
            this.pnlGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnlGame.Controls.Add(this.picGameOver);
            this.pnlGame.Location = new System.Drawing.Point(18, 70);
            this.pnlGame.Name = "pnlGame";
            this.pnlGame.Size = new System.Drawing.Size(400, 800);
            this.pnlGame.TabIndex = 0;
            // 
            // tabScoreBoard
            // 
            this.tabScoreBoard.Controls.Add(this.btnMenu2);
            this.tabScoreBoard.Controls.Add(this.dgvScoreBoard);
            this.tabScoreBoard.Location = new System.Drawing.Point(4, 5);
            this.tabScoreBoard.Name = "tabScoreBoard";
            this.tabScoreBoard.Size = new System.Drawing.Size(692, 891);
            this.tabScoreBoard.TabIndex = 2;
            this.tabScoreBoard.UseVisualStyleBackColor = true;
            // 
            // btnMenu2
            // 
            this.btnMenu2.Location = new System.Drawing.Point(34, 24);
            this.btnMenu2.Name = "btnMenu2";
            this.btnMenu2.Size = new System.Drawing.Size(144, 51);
            this.btnMenu2.TabIndex = 3;
            this.btnMenu2.Text = "回到主菜单";
            this.btnMenu2.UseVisualStyleBackColor = true;
            this.btnMenu2.Click += new System.EventHandler(this.btnMenu2_Click);
            // 
            // dgvScoreBoard
            // 
            this.dgvScoreBoard.AllowUserToAddRows = false;
            this.dgvScoreBoard.AllowUserToDeleteRows = false;
            this.dgvScoreBoard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvScoreBoard.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvScoreBoard.Location = new System.Drawing.Point(110, 104);
            this.dgvScoreBoard.Name = "dgvScoreBoard";
            this.dgvScoreBoard.ReadOnly = true;
            this.dgvScoreBoard.RowTemplate.Height = 30;
            this.dgvScoreBoard.Size = new System.Drawing.Size(356, 287);
            this.dgvScoreBoard.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "玩家";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "得分";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnlTitleBar.Controls.Add(this.btnCloseForm);
            this.pnlTitleBar.Controls.Add(this.btnMinForm);
            this.pnlTitleBar.Controls.Add(this.picTitle);
            this.pnlTitleBar.Location = new System.Drawing.Point(4, 3);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(692, 53);
            this.pnlTitleBar.TabIndex = 4;
            this.pnlTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseDown);
            this.pnlTitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseMove);
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.Image = global::TetrisGame.Properties.Resources.ButtonCloseForm;
            this.btnCloseForm.Location = new System.Drawing.Point(649, 4);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(40, 40);
            this.btnCloseForm.TabIndex = 3;
            this.btnCloseForm.TabStop = false;
            this.btnCloseForm.UseVisualStyleBackColor = false;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // btnMinForm
            // 
            this.btnMinForm.Image = global::TetrisGame.Properties.Resources.ButtonMinForm;
            this.btnMinForm.Location = new System.Drawing.Point(603, 4);
            this.btnMinForm.Name = "btnMinForm";
            this.btnMinForm.Size = new System.Drawing.Size(40, 40);
            this.btnMinForm.TabIndex = 2;
            this.btnMinForm.TabStop = false;
            this.btnMinForm.UseVisualStyleBackColor = false;
            this.btnMinForm.Click += new System.EventHandler(this.btnMinForm_Click);
            // 
            // picTitle
            // 
            this.picTitle.Image = global::TetrisGame.Properties.Resources.Tetris;
            this.picTitle.Location = new System.Drawing.Point(9, 4);
            this.picTitle.Name = "picTitle";
            this.picTitle.Size = new System.Drawing.Size(89, 43);
            this.picTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTitle.TabIndex = 0;
            this.picTitle.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Image = global::TetrisGame.Properties.Resources.ButtonStart;
            this.btnStart.Location = new System.Drawing.Point(256, 330);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(180, 65);
            this.btnStart.TabIndex = 1;
            this.btnStart.TabStop = false;
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // picTetris
            // 
            this.picTetris.Image = global::TetrisGame.Properties.Resources.Tetris;
            this.picTetris.Location = new System.Drawing.Point(93, 97);
            this.picTetris.Name = "picTetris";
            this.picTetris.Size = new System.Drawing.Size(500, 150);
            this.picTetris.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picTetris.TabIndex = 3;
            this.picTetris.TabStop = false;
            // 
            // btnQuit
            // 
            this.btnQuit.Image = global::TetrisGame.Properties.Resources.ButtonQuit;
            this.btnQuit.Location = new System.Drawing.Point(256, 530);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(180, 65);
            this.btnQuit.TabIndex = 3;
            this.btnQuit.TabStop = false;
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnScoreBoard
            // 
            this.btnScoreBoard.Image = global::TetrisGame.Properties.Resources.ButtonScore;
            this.btnScoreBoard.Location = new System.Drawing.Point(256, 430);
            this.btnScoreBoard.Name = "btnScoreBoard";
            this.btnScoreBoard.Size = new System.Drawing.Size(180, 65);
            this.btnScoreBoard.TabIndex = 2;
            this.btnScoreBoard.TabStop = false;
            this.btnScoreBoard.UseVisualStyleBackColor = false;
            this.btnScoreBoard.Click += new System.EventHandler(this.btnScoreBoard_Click);
            // 
            // picGameOver
            // 
            this.picGameOver.BackColor = System.Drawing.Color.Transparent;
            this.picGameOver.Image = global::TetrisGame.Properties.Resources.picGameOver;
            this.picGameOver.Location = new System.Drawing.Point(3, 311);
            this.picGameOver.Name = "picGameOver";
            this.picGameOver.Size = new System.Drawing.Size(394, 72);
            this.picGameOver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picGameOver.TabIndex = 0;
            this.picGameOver.TabStop = false;
            // 
            // btnMenu
            // 
            this.btnMenu.Image = global::TetrisGame.Properties.Resources.ButtonMenu;
            this.btnMenu.Location = new System.Drawing.Point(444, 553);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(180, 65);
            this.btnMenu.TabIndex = 3;
            this.btnMenu.TabStop = false;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Image = global::TetrisGame.Properties.Resources.ButtonRestart;
            this.btnRestart.Location = new System.Drawing.Point(444, 457);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(180, 65);
            this.btnRestart.TabIndex = 2;
            this.btnRestart.TabStop = false;
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 900);
            this.Controls.Add(this.pnlTitleBar);
            this.Controls.Add(this.tab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(700, 900);
            this.MinimumSize = new System.Drawing.Size(700, 900);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.tab.ResumeLayout(false);
            this.tabMenu.ResumeLayout(false);
            this.tabMenu.PerformLayout();
            this.tabGame.ResumeLayout(false);
            this.tabGame.PerformLayout();
            this.pnlGame.ResumeLayout(false);
            this.tabScoreBoard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvScoreBoard)).EndInit();
            this.pnlTitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTetris)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGameOver)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage tabMenu;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnScoreBoard;
        private System.Windows.Forms.TabPage tabGame;
        private System.Windows.Forms.TabPage tabScoreBoard;
        private System.Windows.Forms.DataGridView dgvScoreBoard;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Panel pnlGame;
        private System.Windows.Forms.Panel pnlNext;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnMenu2;
        private System.Windows.Forms.Label lblScoreNum;
        private System.Windows.Forms.Label lblLevelNum;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.PictureBox picTetris;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox picGameOver;
        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.PictureBox picTitle;
        private System.Windows.Forms.Button btnCloseForm;
        private System.Windows.Forms.Button btnMinForm;
    }
}

