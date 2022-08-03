using Sell_Shoes.A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sell_Shoes.A_DAL.Repositoties
{
    internal class SanPhamRepos
    {
        SanPham sanPham = new SanPham();
        QLBG_HTContext qLBG = new QLBG_HTContext();

        public List<SanPham> GetAllSanPham() // tra ve all giay
        {
            return qLBG.SanPhams.ToList();
        }


        public bool AddSanPham(SanPham sp) // them moi giay
        {
            try
            {
                qLBG.SanPhams.Add(sp); qLBG.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message); return false;
            }
        }

        public bool EditSanPham(int masanpham ,string Ten, decimal Dongianhap, decimal Dongiaban, int Soluongcon, string Tenhang)
        {
            try
            {
                var sanpham = qLBG.SanPhams.FirstOrDefault(p => p.MaSanpham == masanpham);
                sanpham.Ten = Ten;
                sanpham.Dongianhap = Dongianhap;
                sanpham.Dongiaban = Dongiaban;
                sanpham.Soluongcon = Soluongcon;
                sanpham.Tenhang = Tenhang;
                qLBG.SaveChanges(); return false;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message); return false;
            }
        }



        public bool DeleteSanPham(string ten) // xoa 1 xe dc lua chon
        {
            try
            {
                var sanpham = qLBG.SanPhams.FirstOrDefault(p => p.Ten == ten);
                qLBG.SanPhams.RemoveRange(sanpham);
                qLBG.SaveChanges();
                return true;

            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message); return false;
            }
        }
        
    }
}
