using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sell_Shoes.A_DAL.Models;
using Sell_Shoes.A_DAL.Repositoties;

namespace Sell_Shoes.B_BUS.Services
{
    internal class SanPhamSV
    {
        SanPhamRepos spRepos = new SanPhamRepos();

        public SanPhamSV()
        {

        }
        public List<SanPham> ShowAllSanPham()
        {
            return spRepos.GetAllSanPham();
        }
      public string CreateNewSanPham(string Ten, decimal Dongianhap, int Soluongcon, string Tenhang)
      {
            SanPham sp = new SanPham();
            sp.Ten = Ten;
            sp.Dongianhap = Dongianhap;
            sp.Soluongcon = Soluongcon;
            sp.Tenhang = Tenhang;
            
            return spRepos.AddSanPham(sp) ? "thêm thành công" : "thêm thất bại";
        }

        public string UpdateSanPham(int MaSanpham, string Ten, decimal Dongianhap, int Soluongcon, string Tenhang)
        {
            return spRepos.EditSanPham(MaSanpham, Ten, Dongianhap , Soluongcon , Tenhang) ? "thêm thành công" : "thêm thất bại";
        }
        
        public string DeleteAGiay(int masanpham)
        {
            return spRepos.DeleteSanPham(masanpham) ? "thêm thành công" : "thêm thất bại";

        }
        
    }
}
