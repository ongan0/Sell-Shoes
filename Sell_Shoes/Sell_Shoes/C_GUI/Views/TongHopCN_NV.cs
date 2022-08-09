using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sell_Shoes.Views
{
    public partial class TongHopCN_NV : Form
    {
        public TongHopCN_NV()
        {
            InitializeComponent();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Order_Click(object sender, EventArgs e)
        {
            Order_NV order_NV = new Order_NV();
            order_NV.ShowDialog();
        }

        private void btn_Hoadon_Click(object sender, EventArgs e)
        {
            HoaDon_NV hoaDon = new HoaDon_NV();
            hoaDon.ShowDialog();
        }
        private void btn_Doanhthu_Click(object sender, EventArgs e)
        {
            DoanhThu doanhThu = new DoanhThu();
            doanhThu.ShowDialog();
        }

        private void btn_Support_Click(object sender, EventArgs e)
        {
            Support support = new Support();
            support.ShowDialog();
        }
    }
}
