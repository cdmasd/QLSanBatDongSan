using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QuanLyBDS
{
    public partial class KhachHang
    {
        DAL_QuanLyBDS.KhachHang kh = new DAL_QuanLyBDS.KhachHang();
        // phần khách hàng đăng bài 
        public bool DangTin(string tieuDe, string loaiNha, double dienTich, int soPhong, double gia, string diaChi, string hinhAnh)
        {
            return kh.DangTin(tieuDe, loaiNha, dienTich, soPhong, gia, diaChi, hinhAnh);
        }
        public List<BsonDocument> getBaiDang()
        {
            return kh.getBaiDang();
        }
        public bool UpdateBaidang(string id, string tieuDe, string loaiNha, double dienTich, int soPhong, double gia, string diaChi, string hinhAnh)
        {
            return kh.UpdateBaidang(id, tieuDe, loaiNha, dienTich, soPhong, gia, diaChi, hinhAnh);
        }
       
    }
}
