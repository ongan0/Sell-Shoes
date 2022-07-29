using Sell_Shoes.A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sell_Shoes.A_DAL.Repositoties
{
    internal class HoaDonRepos
    {
        QLBG_HTContext qLBG = new QLBG_HTContext();
        public List<HoaDon> GetHoaDon()
        {
            return qLBG.HoaDons.ToList();
        }
    }
}
