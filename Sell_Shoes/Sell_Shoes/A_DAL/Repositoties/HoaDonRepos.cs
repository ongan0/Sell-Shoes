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
        HoaDon hoaDon = new HoaDon();
        QLBG_HTContext qLBG = new QLBG_HTContext();
        public List<HoaDon> GetHoaDon()
        {
            return qLBG.HoaDons.ToList();
        }
        public List<CthoaDon> GetCthoaDons()
        {

            return qLBG.CthoaDons.ToList(); 
        }
        public bool DeleteHD(int id)
        {
            try
            {
                var hoadon = qLBG.HoaDons.FirstOrDefault(p => p.MaHoadon == id);
                qLBG.HoaDons.Remove(hoadon);
                qLBG.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
        public List<HoaDon> SearchHD(DateTime start, DateTime stop)
        {
            return qLBG.HoaDons.Where(p => p.Ngaylap >= start && p.Ngaylap <= stop).ToList();
        }
    }
}
