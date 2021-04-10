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
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK) Application.Exit();
        }

        private void btnBT1_Click(object sender, EventArgs e)
        {
            fCoBan f = new fCoBan();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnBT2_Click(object sender, EventArgs e)
        {
            fPtBac1 f = new fPtBac1();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnBT3_Click(object sender, EventArgs e)
        {
            fPtBac2 f = new fPtBac2();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnBT4_Click(object sender, EventArgs e)
        {
            fKQHT f = new fKQHT();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
