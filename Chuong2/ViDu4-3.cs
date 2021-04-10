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
    public partial class ViDu4_3 : Form
    {
        public ViDu4_3()
        {
            InitializeComponent();
        }

        private void btnKQ_Click(object sender, EventArgs e)
        {
            string hoten = this.txbHoTen.Text.Trim();
            if (this.rad1.Checked == true) this.txbKQ.Text = hoten.ToLower();
            if (this.rad2.Checked == true) this.txbKQ.Text = hoten.ToUpper();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.txbHoTen.Clear();
            this.txbKQ.Clear();
            this.rad1.Checked = true;
            this.txbHoTen.Focus();
        }

        private void btnDung_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK) Application.Exit();
        }
    }
}
