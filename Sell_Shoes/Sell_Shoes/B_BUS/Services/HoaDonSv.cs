using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sell_Shoes.A_DAL.Models;
using Sell_Shoes.A_DAL.Repositoties;

namespace Sell_Shoes.B_BUS.Services
{
    internal class HoaDonSv
    {
        HoaDonRepos hdRepos = new HoaDonRepos();
        public HoaDonSv()
        {

        }
        public List<HoaDon> ShowHoaDon()
        {
            return hdRepos.GetHoaDon();
        }
        public List<CthoaDon> ShowCTHoaDon()
        {
            return hdRepos.GetCthoaDons();
        }
        public string DeleteHD(int id)
        {
            return hdRepos.DeleteHD(id)? "Xóa thành công" : "Xóa thất bại";
        }
    }
}
