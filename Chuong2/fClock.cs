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
    public partial class fClock : Form
    {
        public fClock()
        {
            InitializeComponent();
        }

        double sec = 60;
        double minute = 0;
        string ConvertToString(double a)
        {
            string stra = "";
            if (a <= 9)
            {
                stra = "0" + a.ToString();
            }
            else
            {
                stra = a.ToString();
            }
            return stra;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            minute = Convert.ToDouble(cbTime.Text)-1;
            this.lbTimeOut.Hide();
            this.timer1.Start();
            this.btnStart.Text = "Start";
            this.cbTime.Enabled = false;
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            this.timer1.Stop();
            this.btnStart.Text = "Continue";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.lbMM.Text = "00";
            this.lbSS.Text = "00";
            sec = 60;
            this.timer1.Stop();
            this.btnStart.Text = "Start";
            lbTimeOut.Hide();
            this.cbTime.Enabled = true;
            this.cbTime.Focus();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK) Application.Exit();
        }

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (sec==0)
            {
                minute--;
                sec = 60;         
            }
            sec--;
            this.lbMM.Text = ConvertToString(minute);
            this.lbSS.Text = ConvertToString(sec);
            if (minute == 0 && sec == 0)
            {
                timer1.Stop();
                lbTimeOut.Show();
            }
        }

        private void fClock_Load(object sender, EventArgs e)
        {
            this.lbTimeOut.Hide();
        }
    }
}
