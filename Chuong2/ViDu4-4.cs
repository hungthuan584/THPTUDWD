using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chuong2
{
    public partial class ViDu4_4 : Form
    {
        public ViDu4_4()
        {
            InitializeComponent();
        }

        int i = 0;
        int j = 0;
        
        private void btnStart_Click(object sender, EventArgs e)
        {
            this.lbTimeOut.Hide();
            this.timer1.Enabled = true;
            this.timer2.Enabled = true;
            this.btnStart.Text = "Bắt đầu";
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK) Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            if (i <= 9)
            {
                this.lbMM.Text = "0" + i.ToString();
            }
            else
            {
                this.lbMM.Text = i.ToString();
            }
            if (i > 58)
            {
                i = -1;
            }
            if (i == 2)
            {
                this.lbTimeOut.Show();
                this.timer1.Enabled = false;
                this.timer2.Enabled = false;
                this.lbMM.Text = "00";
                this.lbSS.Text = "00";
                i = 0;
                j = 0;
                this.timer1.Enabled = false;
                this.timer2.Enabled = false;
                this.btnStart.Text = "Bắt đầu";
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            j++;
            if (j <= 9)
            {
                this.lbSS.Text = "0"+j.ToString();
            }
            else
            {
                this.lbSS.Text = j.ToString();
            }
            if (j == 59)
            {
                j = -1;
            }
            
        }

        private void ViDu4_4_Load(object sender, EventArgs e)
        {
            this.lbTimeOut.Hide();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled = false;
            this.timer2.Enabled = false;
            this.btnStart.Text = "Tiếp tục";
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.lbMM.Text = "00";
            this.lbSS.Text = "00";
            i = 0;
            j = 0;
            this.timer1.Enabled = false;
            this.timer2.Enabled = false;
            this.btnStart.Text = "Bắt đầu";
        }
    }
}
