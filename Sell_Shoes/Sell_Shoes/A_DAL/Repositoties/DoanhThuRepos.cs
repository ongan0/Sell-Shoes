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
        public List<DoanhThu> SearchDT(DateTime start, DateTime stop)
        {
            var date1 = new DateTime(stop.Year, stop.Month, stop.Day);
            try
            {
                date1 = new DateTime(stop.Year, stop.Month, stop.Day + 1);
            }
            catch (Exception)
            {
                try
                {
                    date1 = new DateTime(stop.Year, stop.Month + 1, 1);
                }
                catch (Exception)
                {

                    date1 = new DateTime(stop.Year + 1, 1, 1);
                }
            }
            return qLBG.DoanhThus.Where(p => p.Ngayxuat >= start && p.Ngayxuat <= date1).ToList();
        }
    }
}
