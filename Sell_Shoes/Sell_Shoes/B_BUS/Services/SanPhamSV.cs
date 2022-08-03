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
      public string CreateNewSanPham(string Ten, decimal Dongianhap, decimal Dongiaban , int Soluongcon, string Tenhang)
      {
            SanPham sp = new SanPham();
            sp.Ten = Ten;
            sp.Dongianhap = Dongianhap;
            sp.Dongiaban = Dongiaban;
            sp.Soluongcon = Soluongcon;
            sp.Tenhang = Tenhang;
            
            return spRepos.AddSanPham(sp) ? "thêm thành công" : "thêm thất bại";
      }

        public string Updatesanpham(int masanpham,string ten, decimal dongianhap, decimal dongiaban, int soluongcon, string tenhang)
        {
            return spRepos.EditSanPham(masanpham ,ten, dongianhap, dongiaban, soluongcon, tenhang)? "sửa thành công" : "sửa thất bại";
        }
        
        public string DeleteSanPham(int masanpham )
        {
            return spRepos.DeleteSanPham(masanpham) ? "xóa thành công" : "xóa thất bại";
        }
        
    }
}
