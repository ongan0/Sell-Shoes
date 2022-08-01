using Sell_Shoes.A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sell_Shoes.A_DAL.Repositoties
{
    internal class DoanhThuRepos
    {
        DoanhThu DoanhThu = new DoanhThu();
        QLBG_HTContext qLBG = new QLBG_HTContext();
        public List<DoanhThu> GetAllDoanhThu() 
        {
            return qLBG.DoanhThus.ToList();
        }

    }
}
