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
        List<Sell_Shoes.A_DAL.Models.DoanhThu> doanhThus = new List<A_DAL.Models.DoanhThu>();
        int count = 0;
        DoanhThuSV doanhThuSV = new DoanhThuSV();
        public DoanhThu()
        {
            InitializeComponent();
        }
        public void LoadDTShow(List<Sell_Shoes.A_DAL.Models.DoanhThu> doanhThus)
        {
            dtg_ShowDT.Rows.Clear();
            dtg_ShowDT.DataSource = null;
            dtg_ShowDT.ColumnCount = 3;
            dtg_ShowDT.Columns[0].Name = "mã doanh thu";
            dtg_ShowDT.Columns[1].Name = "ngày xuất";
            dtg_ShowDT.Columns[2].Name = "doanh thu ";

            foreach (var item in doanhThus)
            {
                dtg_ShowDT.Rows.Add(item.MaDoanhthu, item.Ngayxuat, item.Doanhthu);
            }
        }
        private void btn_DoanhThu_Click(object sender, EventArgs e)
        {
            LoadDTShow(doanhThuSV.ShowAllDoanhThu());
        }

        private void dtp_DateStop_ValueChanged(object sender, EventArgs e)
        {
            var start = Convert.ToDateTime(dtp_DateStart.Value);
            var stop = Convert.ToDateTime(dtp_DateStop.Value);

            LoadDTShow(doanhThuSV.SearchDT(start, stop));
        }

        private void dtp_DateStart_ValueChanged(object sender, EventArgs e)
        {
            var start = Convert.ToDateTime(dtp_DateStart.Value);
            var stop = Convert.ToDateTime(dtp_DateStop.Value);

            LoadDTShow(doanhThuSV.SearchDT(start, stop));
        }
    }
}
