using Sell_Shoes.A_DAL.Models;
using Sell_Shoes.B_BUS.Services;
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
    public partial class DoanhThu : Form
    {
        int count = 0;
        DoanhThuSV DoanhThuSV  = new DoanhThuSV();
        public DoanhThu()
        {
            InitializeComponent();
        }
        public void LoadDataToGridView(List<DoanhThu> doanhThus)
        {
            //dtg_ShowDT.ColumnCount = 5;
            //dtg_ShowDT.Columns[0].Name = "mã sản phẩm";
            //dtg_ShowDT.Columns[1].Name = "Ngày Xuất";
            //dtg_ShowDT.Columns[2].Name = "Doanh Thu 1";
            //foreach(var item in doanhThus)
            //{
            //    dtg_ShowDT.Rows.Add(item.madoa)
            //}
        }

        private void btn_DoanhThu_Click(object sender, EventArgs e)
        {
            dtg_ShowDT.DataSource = DoanhThuSV.ShowAllDoanhThu();
        }
      
    }
}
