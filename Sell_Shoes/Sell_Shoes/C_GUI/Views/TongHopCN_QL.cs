using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sell_Shoes;

namespace Sell_Shoes.Views
{
    public partial class TongHopCN_QL : Form
    {
        public TongHopCN_QL()
        {
            InitializeComponent();
        }

        private void btn_Hoadon_Click(object sender, EventArgs e)
        {
            HoaDon_QL hoaDon_QL = new HoaDon_QL();

            hoaDon_QL.ShowDialog();
        }

        private void btn_Sanpham_Click(object sender, EventArgs e)
        {
            SanPham_QL sanPham_QL = new SanPham_QL();
            sanPham_QL.ShowDialog();
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
        private void btn_Logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
