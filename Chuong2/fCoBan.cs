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
    public partial class fCoBan : Form
    {
        public fCoBan()
        {
            InitializeComponent();
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            double so1 = Convert.ToDouble(this.txbSo1.Text);
            double so2 = Convert.ToDouble(this.txbSo2.Text);
            this.txbKQ.Text = Convert.ToString(so1 + so2);
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            double so1 = Convert.ToDouble(this.txbSo1.Text);
            double so2 = Convert.ToDouble(this.txbSo2.Text);
            this.txbKQ.Text = Convert.ToString(so1 - so2);
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            double so1 = Convert.ToDouble(this.txbSo1.Text);
            double so2 = Convert.ToDouble(this.txbSo2.Text);
            this.txbKQ.Text = Convert.ToString(so1 * so2);
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            double so1 = Convert.ToDouble(this.txbSo1.Text);
            double so2 = Convert.ToDouble(this.txbSo2.Text);
            if (so2 == 0)
            {
                MessageBox.Show("Số thứ 2 phải khác 0\n\rVui lòng nhập số khác","Thông báo");
                this.txbSo2.ResetText();
                this.txbSo2.Focus();
            }
            else { this.txbKQ.Text = Convert.ToString(so1 / so2); }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.txbSo1.Clear();
            this.txbSo2.Clear();
            this.txbKQ.Clear();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có muốn dừng chương trình?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK) Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            fMain f = new fMain();
            this.Close();
        }
    }
}
