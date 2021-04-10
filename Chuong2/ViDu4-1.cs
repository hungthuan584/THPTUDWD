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
    public partial class ViDu4_1 : Form
    {
        public ViDu4_1()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.txbKQ.Text = "Bạn đã chọn website ";
            this.txbKQ.Text += this.lstWeb.SelectedItem.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.txbKQ.ResetText();
        }

        private void ViDu4_1_Load(object sender, EventArgs e)
        {
            this.lstWeb.Items.Add("Tuổi trẻ");
            this.lstWeb.Items.Add("Thanh niên");
            this.lstWeb.Items.Add("VNExpress");
            this.lstWeb.Items.Add("Dân trí");
            this.lstWeb.Items.Add("Công an");
            this.lstWeb.SelectedItem = "Tuổi trẻ";
        }
    }
}
