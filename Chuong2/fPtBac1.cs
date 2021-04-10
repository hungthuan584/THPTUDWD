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
    public partial class fPtBac1 : Form
    {
        public fPtBac1()
        {
            InitializeComponent();
        }

        private void btnGiai_Click(object sender, EventArgs e)
        {
            double sob = Convert.ToDouble(this.txbHeSoB.Text);
            double soc = Convert.ToDouble(this.txbHeSoC.Text);

            if (sob == 0)
            {
                this.txbKQ.Text = "Vô nghiệm";
            }
            else
            {
                this.txbKQ.Text = "x= " + (-soc / sob);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.txbHeSoB.Clear();
            this.txbHeSoC.Clear();
            this.txbKQ.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có muốn thoát?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK) Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            fMain f = new fMain();
            this.Close();
        }
    }
}
