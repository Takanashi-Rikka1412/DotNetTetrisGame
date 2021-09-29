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
            this.tlpTop10 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.lblName1 = new System.Windows.Forms.Label();
            this.lblName2 = new System.Windows.Forms.Label();
            this.lblName3 = new System.Windows.Forms.Label();
            this.lblName4 = new System.Windows.Forms.Label();
            this.lblScore1 = new System.Windows.Forms.Label();
            this.lblScore2 = new System.Windows.Forms.Label();
            this.lblScore3 = new System.Windows.Forms.Label();
            this.lblScore4 = new System.Windows.Forms.Label();
            this.lblName5 = new System.Windows.Forms.Label();
            this.lblName6 = new System.Windows.Forms.Label();
            this.lblName7 = new System.Windows.Forms.Label();
            this.lblName8 = new System.Windows.Forms.Label();
            this.lblName9 = new System.Windows.Forms.Label();
            this.lblName10 = new System.Windows.Forms.Label();
            this.lblScore5 = new System.Windows.Forms.Label();
            this.lblScore6 = new System.Windows.Forms.Label();
            this.lblScore7 = new System.Windows.Forms.Label();
            this.lblScore8 = new System.Windows.Forms.Label();
            this.lblScore9 = new System.Windows.Forms.Label();
            this.lblScore10 = new System.Windows.Forms.Label();
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.btnMinForm = new System.Windows.Forms.Button();
            this.picTitle = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.picTetris = new System.Windows.Forms.PictureBox();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnScoreBoard = new System.Windows.Forms.Button();
            this.btnPauseOrContinue = new System.Windows.Forms.Button();
            this.picPause = new System.Windows.Forms.PictureBox();
            this.picGameOver = new System.Windows.Forms.PictureBox();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.pic3 = new System.Windows.Forms.PictureBox();
            this.pic4 = new System.Windows.Forms.PictureBox();
            this.pic5 = new System.Windows.Forms.PictureBox();
            this.pic6 = new System.Windows.Forms.PictureBox();
            this.pic7 = new System.Windows.Forms.PictureBox();
            this.pic8 = new System.Windows.Forms.PictureBox();
            this.pic9 = new System.Windows.Forms.PictureBox();
            this.pic10 = new System.Windows.Forms.PictureBox();
            this.picTop10 = new System.Windows.Forms.PictureBox();
            this.btnMenu2 = new System.Windows.Forms.Button();
            this.tab.SuspendLayout();
            this.tabMenu.SuspendLayout();
            this.tabGame.SuspendLayout();
            this.pnlGame.SuspendLayout();
            this.tabScoreBoard.SuspendLayout();
            this.tlpTop10.SuspendLayout();
            this.pnlTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTetris)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGameOver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTop10)).BeginInit();
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
            this.tabGame.Controls.Add(this.btnPauseOrContinue);
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
            this.lblScoreNum.Font = new System.Drawing.Font("思源黑体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblScoreNum.ForeColor = System.Drawing.Color.White;
            this.lblScoreNum.Location = new System.Drawing.Point(548, 374);
            this.lblScoreNum.Name = "lblScoreNum";
            this.lblScoreNum.Size = new System.Drawing.Size(0, 44);
            this.lblScoreNum.TabIndex = 7;
            // 
            // lblLevelNum
            // 
            this.lblLevelNum.AutoSize = true;
            this.lblLevelNum.Font = new System.Drawing.Font("思源黑体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLevelNum.ForeColor = System.Drawing.Color.White;
            this.lblLevelNum.Location = new System.Drawing.Point(548, 312);
            this.lblLevelNum.Name = "lblLevelNum";
            this.lblLevelNum.Size = new System.Drawing.Size(0, 44);
            this.lblLevelNum.TabIndex = 6;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("思源黑体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblScore.ForeColor = System.Drawing.Color.White;
            this.lblScore.Location = new System.Drawing.Point(446, 374);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(80, 44);
            this.lblScore.TabIndex = 5;
            this.lblScore.Text = "分数";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Font = new System.Drawing.Font("思源黑体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLevel.ForeColor = System.Drawing.Color.White;
            this.lblLevel.Location = new System.Drawing.Point(446, 312);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(80, 44);
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
            this.pnlGame.Controls.Add(this.picPause);
            this.pnlGame.Controls.Add(this.picGameOver);
            this.pnlGame.Location = new System.Drawing.Point(18, 70);
            this.pnlGame.Name = "pnlGame";
            this.pnlGame.Size = new System.Drawing.Size(400, 800);
            this.pnlGame.TabIndex = 0;
            // 
            // tabScoreBoard
            // 
            this.tabScoreBoard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tabScoreBoard.Controls.Add(this.tlpTop10);
            this.tabScoreBoard.Controls.Add(this.picTop10);
            this.tabScoreBoard.Controls.Add(this.btnMenu2);
            this.tabScoreBoard.Location = new System.Drawing.Point(4, 5);
            this.tabScoreBoard.Name = "tabScoreBoard";
            this.tabScoreBoard.Size = new System.Drawing.Size(692, 891);
            this.tabScoreBoard.TabIndex = 2;
            // 
            // tlpTop10
            // 
            this.tlpTop10.ColumnCount = 3;
            this.tlpTop10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.250399F));
            this.tlpTop10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.60606F));
            this.tlpTop10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpTop10.Controls.Add(this.pic2, 0, 1);
            this.tlpTop10.Controls.Add(this.pic1, 0, 0);
            this.tlpTop10.Controls.Add(this.pic3, 0, 2);
            this.tlpTop10.Controls.Add(this.pic4, 0, 3);
            this.tlpTop10.Controls.Add(this.pic5, 0, 4);
            this.tlpTop10.Controls.Add(this.pic6, 0, 5);
            this.tlpTop10.Controls.Add(this.pic7, 0, 6);
            this.tlpTop10.Controls.Add(this.pic8, 0, 7);
            this.tlpTop10.Controls.Add(this.pic9, 0, 8);
            this.tlpTop10.Controls.Add(this.pic10, 0, 9);
            this.tlpTop10.Controls.Add(this.lblName1, 1, 0);
            this.tlpTop10.Controls.Add(this.lblName2, 1, 1);
            this.tlpTop10.Controls.Add(this.lblName3, 1, 2);
            this.tlpTop10.Controls.Add(this.lblName4, 1, 3);
            this.tlpTop10.Controls.Add(this.lblScore1, 2, 0);
            this.tlpTop10.Controls.Add(this.lblScore2, 2, 1);
            this.tlpTop10.Controls.Add(this.lblScore3, 2, 2);
            this.tlpTop10.Controls.Add(this.lblScore4, 2, 3);
            this.tlpTop10.Controls.Add(this.lblName5, 1, 4);
            this.tlpTop10.Controls.Add(this.lblName6, 1, 5);
            this.tlpTop10.Controls.Add(this.lblName7, 1, 6);
            this.tlpTop10.Controls.Add(this.lblName8, 1, 7);
            this.tlpTop10.Controls.Add(this.lblName9, 1, 8);
            this.tlpTop10.Controls.Add(this.lblName10, 1, 9);
            this.tlpTop10.Controls.Add(this.lblScore5, 2, 4);
            this.tlpTop10.Controls.Add(this.lblScore6, 2, 5);
            this.tlpTop10.Controls.Add(this.lblScore7, 2, 6);
            this.tlpTop10.Controls.Add(this.lblScore8, 2, 7);
            this.tlpTop10.Controls.Add(this.lblScore9, 2, 8);
            this.tlpTop10.Controls.Add(this.lblScore10, 2, 9);
            this.tlpTop10.Location = new System.Drawing.Point(29, 274);
            this.tlpTop10.Name = "tlpTop10";
            this.tlpTop10.RowCount = 10;
            this.tlpTop10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpTop10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpTop10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpTop10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpTop10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpTop10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpTop10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpTop10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpTop10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpTop10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpTop10.Size = new System.Drawing.Size(627, 583);
            this.tlpTop10.TabIndex = 6;
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
            // lblName1
            // 
            this.lblName1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName1.AutoSize = true;
            this.lblName1.Font = new System.Drawing.Font("思源黑体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblName1.ForeColor = System.Drawing.Color.Red;
            this.lblName1.Location = new System.Drawing.Point(61, 0);
            this.lblName1.Name = "lblName1";
            this.lblName1.Size = new System.Drawing.Size(374, 58);
            this.lblName1.TabIndex = 6;
            this.lblName1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName2
            // 
            this.lblName2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName2.AutoSize = true;
            this.lblName2.Font = new System.Drawing.Font("思源黑体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblName2.ForeColor = System.Drawing.Color.Orange;
            this.lblName2.Location = new System.Drawing.Point(61, 58);
            this.lblName2.Name = "lblName2";
            this.lblName2.Size = new System.Drawing.Size(374, 58);
            this.lblName2.TabIndex = 6;
            this.lblName2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName3
            // 
            this.lblName3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName3.AutoSize = true;
            this.lblName3.Font = new System.Drawing.Font("思源黑体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblName3.ForeColor = System.Drawing.Color.Yellow;
            this.lblName3.Location = new System.Drawing.Point(61, 116);
            this.lblName3.Name = "lblName3";
            this.lblName3.Size = new System.Drawing.Size(374, 58);
            this.lblName3.TabIndex = 6;
            this.lblName3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName4
            // 
            this.lblName4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName4.AutoSize = true;
            this.lblName4.Font = new System.Drawing.Font("思源黑体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblName4.ForeColor = System.Drawing.Color.White;
            this.lblName4.Location = new System.Drawing.Point(61, 174);
            this.lblName4.Name = "lblName4";
            this.lblName4.Size = new System.Drawing.Size(374, 58);
            this.lblName4.TabIndex = 6;
            this.lblName4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScore1
            // 
            this.lblScore1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblScore1.AutoSize = true;
            this.lblScore1.Font = new System.Drawing.Font("思源黑体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblScore1.ForeColor = System.Drawing.Color.Red;
            this.lblScore1.Location = new System.Drawing.Point(441, 0);
            this.lblScore1.Name = "lblScore1";
            this.lblScore1.Size = new System.Drawing.Size(183, 58);
            this.lblScore1.TabIndex = 6;
            this.lblScore1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScore2
            // 
            this.lblScore2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblScore2.AutoSize = true;
            this.lblScore2.Font = new System.Drawing.Font("思源黑体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblScore2.ForeColor = System.Drawing.Color.Orange;
            this.lblScore2.Location = new System.Drawing.Point(441, 58);
            this.lblScore2.Name = "lblScore2";
            this.lblScore2.Size = new System.Drawing.Size(183, 58);
            this.lblScore2.TabIndex = 6;
            this.lblScore2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScore3
            // 
            this.lblScore3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblScore3.AutoSize = true;
            this.lblScore3.Font = new System.Drawing.Font("思源黑体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblScore3.ForeColor = System.Drawing.Color.Yellow;
            this.lblScore3.Location = new System.Drawing.Point(441, 116);
            this.lblScore3.Name = "lblScore3";
            this.lblScore3.Size = new System.Drawing.Size(183, 58);
            this.lblScore3.TabIndex = 6;
            this.lblScore3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScore4
            // 
            this.lblScore4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblScore4.AutoSize = true;
            this.lblScore4.Font = new System.Drawing.Font("思源黑体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblScore4.ForeColor = System.Drawing.Color.White;
            this.lblScore4.Location = new System.Drawing.Point(441, 174);
            this.lblScore4.Name = "lblScore4";
            this.lblScore4.Size = new System.Drawing.Size(183, 58);
            this.lblScore4.TabIndex = 6;
            this.lblScore4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName5
            // 
            this.lblName5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName5.AutoSize = true;
            this.lblName5.Font = new System.Drawing.Font("思源黑体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblName5.ForeColor = System.Drawing.Color.White;
            this.lblName5.Location = new System.Drawing.Point(61, 232);
            this.lblName5.Name = "lblName5";
            this.lblName5.Size = new System.Drawing.Size(374, 58);
            this.lblName5.TabIndex = 6;
            this.lblName5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName6
            // 
            this.lblName6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName6.AutoSize = true;
            this.lblName6.Font = new System.Drawing.Font("思源黑体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblName6.ForeColor = System.Drawing.Color.White;
            this.lblName6.Location = new System.Drawing.Point(61, 290);
            this.lblName6.Name = "lblName6";
            this.lblName6.Size = new System.Drawing.Size(374, 58);
            this.lblName6.TabIndex = 6;
            this.lblName6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName7
            // 
            this.lblName7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName7.AutoSize = true;
            this.lblName7.Font = new System.Drawing.Font("思源黑体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblName7.ForeColor = System.Drawing.Color.White;
            this.lblName7.Location = new System.Drawing.Point(61, 348);
            this.lblName7.Name = "lblName7";
            this.lblName7.Size = new System.Drawing.Size(374, 58);
            this.lblName7.TabIndex = 6;
            this.lblName7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName8
            // 
            this.lblName8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName8.AutoSize = true;
            this.lblName8.Font = new System.Drawing.Font("思源黑体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblName8.ForeColor = System.Drawing.Color.White;
            this.lblName8.Location = new System.Drawing.Point(61, 406);
            this.lblName8.Name = "lblName8";
            this.lblName8.Size = new System.Drawing.Size(374, 58);
            this.lblName8.TabIndex = 6;
            this.lblName8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName9
            // 
            this.lblName9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName9.AutoSize = true;
            this.lblName9.Font = new System.Drawing.Font("思源黑体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblName9.ForeColor = System.Drawing.Color.White;
            this.lblName9.Location = new System.Drawing.Point(61, 464);
            this.lblName9.Name = "lblName9";
            this.lblName9.Size = new System.Drawing.Size(374, 58);
            this.lblName9.TabIndex = 6;
            this.lblName9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName10
            // 
            this.lblName10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName10.AutoSize = true;
            this.lblName10.Font = new System.Drawing.Font("思源黑体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblName10.ForeColor = System.Drawing.Color.White;
            this.lblName10.Location = new System.Drawing.Point(61, 522);
            this.lblName10.Name = "lblName10";
            this.lblName10.Size = new System.Drawing.Size(374, 61);
            this.lblName10.TabIndex = 6;
            this.lblName10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScore5
            // 
            this.lblScore5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblScore5.AutoSize = true;
            this.lblScore5.Font = new System.Drawing.Font("思源黑体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblScore5.ForeColor = System.Drawing.Color.White;
            this.lblScore5.Location = new System.Drawing.Point(441, 232);
            this.lblScore5.Name = "lblScore5";
            this.lblScore5.Size = new System.Drawing.Size(183, 58);
            this.lblScore5.TabIndex = 6;
            this.lblScore5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScore6
            // 
            this.lblScore6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblScore6.AutoSize = true;
            this.lblScore6.Font = new System.Drawing.Font("思源黑体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblScore6.ForeColor = System.Drawing.Color.White;
            this.lblScore6.Location = new System.Drawing.Point(441, 290);
            this.lblScore6.Name = "lblScore6";
            this.lblScore6.Size = new System.Drawing.Size(183, 58);
            this.lblScore6.TabIndex = 6;
            this.lblScore6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScore7
            // 
            this.lblScore7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblScore7.AutoSize = true;
            this.lblScore7.Font = new System.Drawing.Font("思源黑体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblScore7.ForeColor = System.Drawing.Color.White;
            this.lblScore7.Location = new System.Drawing.Point(441, 348);
            this.lblScore7.Name = "lblScore7";
            this.lblScore7.Size = new System.Drawing.Size(183, 58);
            this.lblScore7.TabIndex = 6;
            this.lblScore7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScore8
            // 
            this.lblScore8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblScore8.AutoSize = true;
            this.lblScore8.Font = new System.Drawing.Font("思源黑体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblScore8.ForeColor = System.Drawing.Color.White;
            this.lblScore8.Location = new System.Drawing.Point(441, 406);
            this.lblScore8.Name = "lblScore8";
            this.lblScore8.Size = new System.Drawing.Size(183, 58);
            this.lblScore8.TabIndex = 6;
            this.lblScore8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScore9
            // 
            this.lblScore9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblScore9.AutoSize = true;
            this.lblScore9.Font = new System.Drawing.Font("思源黑体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblScore9.ForeColor = System.Drawing.Color.White;
            this.lblScore9.Location = new System.Drawing.Point(441, 464);
            this.lblScore9.Name = "lblScore9";
            this.lblScore9.Size = new System.Drawing.Size(183, 58);
            this.lblScore9.TabIndex = 6;
            this.lblScore9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScore10
            // 
            this.lblScore10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblScore10.AutoSize = true;
            this.lblScore10.Font = new System.Drawing.Font("思源黑体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblScore10.ForeColor = System.Drawing.Color.White;
            this.lblScore10.Location = new System.Drawing.Point(441, 522);
            this.lblScore10.Name = "lblScore10";
            this.lblScore10.Size = new System.Drawing.Size(183, 61);
            this.lblScore10.TabIndex = 6;
            this.lblScore10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // btnPauseOrContinue
            // 
            this.btnPauseOrContinue.Image = global::TetrisGame.Properties.Resources.ButtonPause;
            this.btnPauseOrContinue.Location = new System.Drawing.Point(451, 444);
            this.btnPauseOrContinue.Name = "btnPauseOrContinue";
            this.btnPauseOrContinue.Size = new System.Drawing.Size(180, 65);
            this.btnPauseOrContinue.TabIndex = 8;
            this.btnPauseOrContinue.TabStop = false;
            this.btnPauseOrContinue.UseVisualStyleBackColor = false;
            this.btnPauseOrContinue.Click += new System.EventHandler(this.btnPauseOrContinue_Click);
            // 
            // picPause
            // 
            this.picPause.BackColor = System.Drawing.Color.Transparent;
            this.picPause.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picPause.Image = global::TetrisGame.Properties.Resources.picPause;
            this.picPause.Location = new System.Drawing.Point(3, 311);
            this.picPause.Name = "picPause";
            this.picPause.Size = new System.Drawing.Size(394, 72);
            this.picPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picPause.TabIndex = 1;
            this.picPause.TabStop = false;
            // 
            // picGameOver
            // 
            this.picGameOver.BackColor = System.Drawing.Color.Transparent;
            this.picGameOver.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
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
            this.btnMenu.Location = new System.Drawing.Point(451, 636);
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
            this.btnRestart.Location = new System.Drawing.Point(451, 540);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(180, 65);
            this.btnRestart.TabIndex = 2;
            this.btnRestart.TabStop = false;
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // pic2
            // 
            this.pic2.Image = global::TetrisGame.Properties.Resources.Top2;
            this.pic2.Location = new System.Drawing.Point(3, 61);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(52, 52);
            this.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic2.TabIndex = 5;
            this.pic2.TabStop = false;
            // 
            // pic1
            // 
            this.pic1.Image = global::TetrisGame.Properties.Resources.Top1;
            this.pic1.Location = new System.Drawing.Point(3, 3);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(52, 52);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic1.TabIndex = 5;
            this.pic1.TabStop = false;
            // 
            // pic3
            // 
            this.pic3.Image = global::TetrisGame.Properties.Resources.Top3;
            this.pic3.Location = new System.Drawing.Point(3, 119);
            this.pic3.Name = "pic3";
            this.pic3.Size = new System.Drawing.Size(52, 52);
            this.pic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic3.TabIndex = 5;
            this.pic3.TabStop = false;
            // 
            // pic4
            // 
            this.pic4.Image = global::TetrisGame.Properties.Resources.Top4;
            this.pic4.Location = new System.Drawing.Point(3, 177);
            this.pic4.Name = "pic4";
            this.pic4.Size = new System.Drawing.Size(52, 52);
            this.pic4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic4.TabIndex = 5;
            this.pic4.TabStop = false;
            // 
            // pic5
            // 
            this.pic5.Image = global::TetrisGame.Properties.Resources.Top5;
            this.pic5.Location = new System.Drawing.Point(3, 235);
            this.pic5.Name = "pic5";
            this.pic5.Size = new System.Drawing.Size(52, 52);
            this.pic5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic5.TabIndex = 5;
            this.pic5.TabStop = false;
            // 
            // pic6
            // 
            this.pic6.Image = global::TetrisGame.Properties.Resources.Top6;
            this.pic6.Location = new System.Drawing.Point(3, 293);
            this.pic6.Name = "pic6";
            this.pic6.Size = new System.Drawing.Size(52, 52);
            this.pic6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic6.TabIndex = 5;
            this.pic6.TabStop = false;
            // 
            // pic7
            // 
            this.pic7.Image = global::TetrisGame.Properties.Resources.Top7;
            this.pic7.Location = new System.Drawing.Point(3, 351);
            this.pic7.Name = "pic7";
            this.pic7.Size = new System.Drawing.Size(52, 52);
            this.pic7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic7.TabIndex = 5;
            this.pic7.TabStop = false;
            // 
            // pic8
            // 
            this.pic8.Image = global::TetrisGame.Properties.Resources.Top8;
            this.pic8.Location = new System.Drawing.Point(3, 409);
            this.pic8.Name = "pic8";
            this.pic8.Size = new System.Drawing.Size(52, 52);
            this.pic8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic8.TabIndex = 5;
            this.pic8.TabStop = false;
            // 
            // pic9
            // 
            this.pic9.Image = global::TetrisGame.Properties.Resources.Top9;
            this.pic9.Location = new System.Drawing.Point(3, 467);
            this.pic9.Name = "pic9";
            this.pic9.Size = new System.Drawing.Size(52, 52);
            this.pic9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic9.TabIndex = 5;
            this.pic9.TabStop = false;
            // 
            // pic10
            // 
            this.pic10.Image = global::TetrisGame.Properties.Resources.Top10;
            this.pic10.Location = new System.Drawing.Point(3, 525);
            this.pic10.Name = "pic10";
            this.pic10.Size = new System.Drawing.Size(52, 52);
            this.pic10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic10.TabIndex = 5;
            this.pic10.TabStop = false;
            // 
            // picTop10
            // 
            this.picTop10.Image = global::TetrisGame.Properties.Resources.Top10Title;
            this.picTop10.Location = new System.Drawing.Point(136, 139);
            this.picTop10.Name = "picTop10";
            this.picTop10.Size = new System.Drawing.Size(420, 120);
            this.picTop10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picTop10.TabIndex = 5;
            this.picTop10.TabStop = false;
            // 
            // btnMenu2
            // 
            this.btnMenu2.Image = global::TetrisGame.Properties.Resources.ButtonMenu;
            this.btnMenu2.Location = new System.Drawing.Point(29, 68);
            this.btnMenu2.Name = "btnMenu2";
            this.btnMenu2.Size = new System.Drawing.Size(180, 65);
            this.btnMenu2.TabIndex = 4;
            this.btnMenu2.TabStop = false;
            this.btnMenu2.UseVisualStyleBackColor = false;
            this.btnMenu2.Click += new System.EventHandler(this.btnMenu2_Click);
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
            this.tlpTop10.ResumeLayout(false);
            this.tlpTop10.PerformLayout();
            this.pnlTitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTetris)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGameOver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTop10)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage tabMenu;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnScoreBoard;
        private System.Windows.Forms.TabPage tabGame;
        private System.Windows.Forms.TabPage tabScoreBoard;
        private System.Windows.Forms.Panel pnlGame;
        private System.Windows.Forms.Panel pnlNext;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnRestart;
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
        private System.Windows.Forms.PictureBox picPause;
        private System.Windows.Forms.Button btnPauseOrContinue;
        private System.Windows.Forms.Button btnMenu2;
        private System.Windows.Forms.TableLayoutPanel tlpTop10;
        private System.Windows.Forms.PictureBox picTop10;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.PictureBox pic3;
        private System.Windows.Forms.PictureBox pic4;
        private System.Windows.Forms.PictureBox pic5;
        private System.Windows.Forms.PictureBox pic6;
        private System.Windows.Forms.PictureBox pic7;
        private System.Windows.Forms.PictureBox pic8;
        private System.Windows.Forms.PictureBox pic9;
        private System.Windows.Forms.PictureBox pic10;
        private System.Windows.Forms.Label lblName1;
        private System.Windows.Forms.Label lblName2;
        private System.Windows.Forms.Label lblName3;
        private System.Windows.Forms.Label lblName4;
        private System.Windows.Forms.Label lblScore1;
        private System.Windows.Forms.Label lblScore2;
        private System.Windows.Forms.Label lblScore3;
        private System.Windows.Forms.Label lblScore4;
        private System.Windows.Forms.Label lblName5;
        private System.Windows.Forms.Label lblName6;
        private System.Windows.Forms.Label lblName7;
        private System.Windows.Forms.Label lblName8;
        private System.Windows.Forms.Label lblName9;
        private System.Windows.Forms.Label lblName10;
        private System.Windows.Forms.Label lblScore5;
        private System.Windows.Forms.Label lblScore6;
        private System.Windows.Forms.Label lblScore7;
        private System.Windows.Forms.Label lblScore8;
        private System.Windows.Forms.Label lblScore9;
        private System.Windows.Forms.Label lblScore10;
    }
}

