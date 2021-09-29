namespace TetrisGame
{
    partial class ScoreForm
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
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCongratulation = new System.Windows.Forms.Label();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.btnMinForm = new System.Windows.Forms.Button();
            this.picTitle = new System.Windows.Forms.PictureBox();
            this.pnlTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnlTitleBar.Controls.Add(this.btnCloseForm);
            this.pnlTitleBar.Controls.Add(this.btnMinForm);
            this.pnlTitleBar.Controls.Add(this.picTitle);
            this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(400, 53);
            this.pnlTitleBar.TabIndex = 5;
            this.pnlTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseDown);
            this.pnlTitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseMove);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtName.Font = new System.Drawing.Font("思源黑体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(120, 177);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(249, 51);
            this.txtName.TabIndex = 6;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("思源黑体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(34, 180);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(80, 44);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "昵称";
            // 
            // lblCongratulation
            // 
            this.lblCongratulation.AutoSize = true;
            this.lblCongratulation.Font = new System.Drawing.Font("思源黑体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCongratulation.ForeColor = System.Drawing.Color.White;
            this.lblCongratulation.Location = new System.Drawing.Point(48, 79);
            this.lblCongratulation.Name = "lblCongratulation";
            this.lblCongratulation.Size = new System.Drawing.Size(321, 44);
            this.lblCongratulation.TabIndex = 8;
            this.lblCongratulation.Text = "恭喜你！进入Top10！";
            // 
            // btnYes
            // 
            this.btnYes.Image = global::TetrisGame.Properties.Resources.ButtonYes;
            this.btnYes.Location = new System.Drawing.Point(150, 283);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(100, 65);
            this.btnYes.TabIndex = 9;
            this.btnYes.TabStop = false;
            this.btnYes.UseVisualStyleBackColor = false;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.Image = global::TetrisGame.Properties.Resources.ButtonCloseForm;
            this.btnCloseForm.Location = new System.Drawing.Point(357, 4);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(40, 40);
            this.btnCloseForm.TabIndex = 5;
            this.btnCloseForm.TabStop = false;
            this.btnCloseForm.UseVisualStyleBackColor = false;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // btnMinForm
            // 
            this.btnMinForm.Image = global::TetrisGame.Properties.Resources.ButtonMinForm;
            this.btnMinForm.Location = new System.Drawing.Point(311, 4);
            this.btnMinForm.Name = "btnMinForm";
            this.btnMinForm.Size = new System.Drawing.Size(40, 40);
            this.btnMinForm.TabIndex = 4;
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
            // ScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.lblCongratulation);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.pnlTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(400, 400);
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "ScoreForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScoreForm";
            this.pnlTitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.PictureBox picTitle;
        private System.Windows.Forms.Button btnCloseForm;
        private System.Windows.Forms.Button btnMinForm;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCongratulation;
        private System.Windows.Forms.Button btnYes;
    }
}