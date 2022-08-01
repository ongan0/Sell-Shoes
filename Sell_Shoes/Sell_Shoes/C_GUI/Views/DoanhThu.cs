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
        

        private void btn_DoanhThu_Click(object sender, EventArgs e)
        {
            dtg_ShowDT.DataSource = DoanhThuSV.ShowAllDoanhThu();
        }
      
    }
}
