using Sell_Shoes.A_DAL.Models;
using Sell_Shoes.A_DAL.Repositoties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sell_Shoes.B_BUS.Services
{
    internal class DoanhThuSV
    {
        DoanhThuRepos dtRepos = new DoanhThuRepos();
        public DoanhThuSV()
        {

        }
        public List<DoanhThu> ShowAllDoanhThu()
        {
            return dtRepos.GetAllDoanhThu();
        }
        public List<DoanhThu> SearchDT(DateTime start, DateTime stop)
        {
            return dtRepos.SearchDT(start, stop);
        }

    }
    
}
