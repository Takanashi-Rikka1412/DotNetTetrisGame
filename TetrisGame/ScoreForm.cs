using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TetrisGame
{
    // 分数破本地记录的弹窗
    public partial class ScoreForm : Form
    {
        ScoreRank scoreRank;

        private System.Drawing.Point mousePoint;
        public ScoreForm(ScoreRank scoreRank)
        {
            InitializeComponent();
            this.scoreRank = scoreRank;
        }

        private void pnlTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new System.Drawing.Point(e.X, e.Y);
        }

        private void pnlTitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                this.Location = new System.Drawing.Point(this.Location.X + e.X - mousePoint.X, this.Location.Y + e.Y - mousePoint.Y);
        }

        private void btnMinForm_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        // 输入昵称并确认
        private void btnYes_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
                return;
            this.scoreRank.Name = txtName.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
