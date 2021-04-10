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
    public partial class fKQHT : Form
    {
        public fKQHT()
        {
            InitializeComponent();
        }

        double diemThapNhat(double van, double toan, double ngoaingu)
        {
            double min = Math.Min(van,Math.Min(toan,ngoaingu));
            return min;
        }

        double diemKetQua(double van, double toan, double ngoaingu)
        {
            double diemKQ = 0;
            double diemThem = 0;
            if (this.chkNu.Checked == true)
            {
                diemThem = 0.5;
            }
            diemKQ = van * 2 + toan * 2 + ngoaingu + diemThem;
            return diemKQ;
        }

        string xepLoai(double van, double toan, double ngoaingu)
        {
            string xeploai = "Yếu";
            double kq = diemKetQua(van, toan, ngoaingu);
            double dtn = diemThapNhat(van, toan, ngoaingu);

            if(kq>=40 && dtn >= 7)
            {
                xeploai = "Giỏi";
            }
            else
            {
                if(kq>=35 && dtn >= 6)
                {
                    xeploai = "Khá";
                }
                else
                {
                    if(kq>=25 && dtn >= 5)
                    {
                        xeploai = "Trung bình";
                    }
                }
            }
            return xeploai;
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            double v = Convert.ToDouble(this.txbVan.Text);
            double t = Convert.ToDouble(this.txbToan.Text);
            double n = Convert.ToDouble(this.txbNN.Text);
            this.txbDTN.Text = Convert.ToString(diemThapNhat(v, t, n));
            this.txbDKQ.Text = Convert.ToString(diemKetQua(v, t, n));
            this.txbXL.Text = xepLoai(v, t, n);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.txbHoten.Clear();
            this.chkNu.Checked = false;
            this.txbToan.Clear();
            this.txbVan.Clear();
            this.txbNN.Clear();
            this.txbDTN.Clear();
            this.txbDKQ.Clear();
            this.txbXL.Clear();
        }

        private void btnDung_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK) Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            fMain f = new fMain();
            this.Close();
        }

        private void fKQHT_Load(object sender, EventArgs e)
        {

        }
    }
}
