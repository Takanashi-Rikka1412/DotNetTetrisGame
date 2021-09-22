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
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnScoreBoard = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.tabGame = new System.Windows.Forms.TabPage();
            this.pnlNext = new System.Windows.Forms.Panel();
            this.pnlGame = new System.Windows.Forms.Panel();
            this.tabScoreBoard = new System.Windows.Forms.TabPage();
            this.dgvScoreBoard = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnMenu2 = new System.Windows.Forms.Button();
            this.tab.SuspendLayout();
            this.tabMenu.SuspendLayout();
            this.tabGame.SuspendLayout();
            this.tabScoreBoard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScoreBoard)).BeginInit();
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
            this.tab.Size = new System.Drawing.Size(678, 844);
            this.tab.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tab.TabIndex = 0;
            // 
            // tabMenu
            // 
            this.tabMenu.Controls.Add(this.btnQuit);
            this.tabMenu.Controls.Add(this.btnScoreBoard);
            this.tabMenu.Controls.Add(this.btnStart);
            this.tabMenu.Location = new System.Drawing.Point(4, 5);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.Padding = new System.Windows.Forms.Padding(3);
            this.tabMenu.Size = new System.Drawing.Size(670, 835);
            this.tabMenu.TabIndex = 0;
            this.tabMenu.UseVisualStyleBackColor = true;
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(226, 334);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(159, 46);
            this.btnQuit.TabIndex = 2;
            this.btnQuit.Text = "退出游戏";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnScoreBoard
            // 
            this.btnScoreBoard.Location = new System.Drawing.Point(226, 271);
            this.btnScoreBoard.Name = "btnScoreBoard";
            this.btnScoreBoard.Size = new System.Drawing.Size(159, 46);
            this.btnScoreBoard.TabIndex = 1;
            this.btnScoreBoard.Text = "得分排行";
            this.btnScoreBoard.UseVisualStyleBackColor = true;
            this.btnScoreBoard.Click += new System.EventHandler(this.btnScoreBoard_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(226, 210);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(159, 46);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "开始游戏";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tabGame
            // 
            this.tabGame.BackColor = System.Drawing.Color.Gainsboro;
            this.tabGame.Controls.Add(this.btnMenu);
            this.tabGame.Controls.Add(this.btnRestart);
            this.tabGame.Controls.Add(this.pnlNext);
            this.tabGame.Controls.Add(this.pnlGame);
            this.tabGame.Location = new System.Drawing.Point(4, 5);
            this.tabGame.Name = "tabGame";
            this.tabGame.Padding = new System.Windows.Forms.Padding(3);
            this.tabGame.Size = new System.Drawing.Size(670, 835);
            this.tabGame.TabIndex = 1;
            // 
            // pnlNext
            // 
            this.pnlNext.BackColor = System.Drawing.Color.White;
            this.pnlNext.Location = new System.Drawing.Point(442, 23);
            this.pnlNext.Name = "pnlNext";
            this.pnlNext.Size = new System.Drawing.Size(200, 200);
            this.pnlNext.TabIndex = 1;
            // 
            // pnlGame
            // 
            this.pnlGame.BackColor = System.Drawing.Color.White;
            this.pnlGame.Location = new System.Drawing.Point(8, 6);
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
            this.tabScoreBoard.Padding = new System.Windows.Forms.Padding(3);
            this.tabScoreBoard.Size = new System.Drawing.Size(670, 835);
            this.tabScoreBoard.TabIndex = 2;
            this.tabScoreBoard.UseVisualStyleBackColor = true;
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
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(470, 472);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(144, 51);
            this.btnRestart.TabIndex = 2;
            this.btnRestart.Text = "重新开始";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(470, 552);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(144, 51);
            this.btnMenu.TabIndex = 3;
            this.btnMenu.Text = "回到主菜单";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 844);
            this.Controls.Add(this.tab);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tab.ResumeLayout(false);
            this.tabMenu.ResumeLayout(false);
            this.tabGame.ResumeLayout(false);
            this.tabScoreBoard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvScoreBoard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage tabMenu;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnScoreBoard;
        private System.Windows.Forms.Button btnStart;
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
    }
}

