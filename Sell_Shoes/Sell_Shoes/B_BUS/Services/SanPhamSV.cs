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
      public string CreateNewGiay(int MaSanpham, string Ten, decimal Dongianhap, int Soluongcon, string Tenhang)
      {
            SanPham sp = new SanPham();
            sp.MaSanpham = MaSanpham;
            sp.Ten = Ten;
            sp.Dongianhap = Dongianhap;
            sp.Soluongcon = Soluongcon;
            sp.Tenhang = Tenhang;
            
            return spRepos.AddSanPham(sp) ? "thêm thành công" : "thêm thất bại";
        }

        public string UpdateSanPham(int MaSanpham, string Ten, decimal Dongianhap, int Soluongcon, string Tenhang)
        {
            return spRepos.EditSanPham(MaSanpham, Ten, Dongianhap , Soluongcon , Tenhang) ? "them thanh cong" : "them that bai";
        }
        
        public string DeleteAGiay(int masanpham)
        {
            return spRepos.DeleteSanPham(masanpham) ? "thêm thành công" : "thêm thất bại";

        }
        //public string DeleteGiayByName(string ten)
        //{
        //    if (spRepos.DeleteGiayByName(ten))
        //    {
        //        return $"đã xóa tất cả xe có tên là : {ten}";
        //    }
        //    else
        //    {
        //        return "xóa thất bại";
        //    }
        //}
    }
}
