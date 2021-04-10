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
    public partial class fPtBac2 : Form
    {
        public fPtBac2()
        {
            InitializeComponent();
        }

        private void btnGiai_Click(object sender, EventArgs e)
        {
            double soA = Convert.ToDouble(this.txbHeSoA.Text);
            double soB = Convert.ToDouble(this.txbHeSoB.Text);
            double soC = Convert.ToDouble(this.txbHeSoC.Text);

            if (soA == 0)
            {
                if (soB == 0)
                {
                    this.txbKQ.Text = "Vô nghiệm";
                }
                else
                {
                    this.txbKQ.Text = "x= " + (-soC / soB);
                }
            }
            else
            {
                double delta = soB * soB - 4 * soA * soC;
                
                if (delta < 0)
                {
                    this.txbKQ.Text = "Vô nghiệm";
                }
                else
                {
                    if (delta == 0)
                    {
                        this.txbKQ.Text = "x1=x2= " + (-soB / (2 * soA));
                    }
                    else
                    {
                        double x1 = (-soB + Math.Sqrt(delta)) / (2 * soA);
                        double x2 = (-soB - Math.Sqrt(delta)) / (2 * soA);

                        this.txbKQ.Text = "x1= " + x1 + "; x2= " + x2;
                    }
                }
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.txbHeSoA.Clear();
            this.txbHeSoB.Clear();
            this.txbHeSoC.Clear();
            this.txbKQ.Clear();
        }

        private void btnStop_Click(object sender, EventArgs e)
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
