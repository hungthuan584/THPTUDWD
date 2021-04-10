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
    public partial class ViDu4_2 : Form
    {
        public ViDu4_2()
        {
            InitializeComponent();
        }

        private void ViDu4_2_Load(object sender, EventArgs e)
        {
            this.cbWeb.Items.Add("Tuổi trẻ");
            this.cbWeb.Items.Add("Thanh niên");
            this.cbWeb.Items.Add("VNExpress");
            this.cbWeb.Items.Add("Dân trí");
            this.cbWeb.Items.Add("Công an");
            this.cbWeb.SelectedItem = "Tuổi trẻ";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.txbKQ.Text = "Bạn đã chọn website ";
            this.txbKQ.Text += this.cbWeb.SelectedItem.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.txbKQ.ResetText();
        }
    }
}
