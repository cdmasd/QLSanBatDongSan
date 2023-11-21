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
        public bool UpdateBaidang(string tieuDe, string loaiNha, double dienTich, int soPhong, double gia, string diaChi, string hinhAnh)
        {
            return kh.UpdateBaidang(tieuDe, loaiNha, dienTich, soPhong, gia, diaChi, hinhAnh);
        }
        public bool DeleteBaidang(string tieude)
        {
            return kh.DeleteBaidang(tieude);
        }
        //Phần khách hàng
        public List<BsonDocument> Getkhachhang()
        {
            return kh.Getkhachhang();
        }
        public bool UpdateKhachhang(string email, string hoten, string sdt, string sodu)
        {
            return kh.UpdataKhachhang(email, hoten, sdt, sodu);
        }
        public bool DeleteKhachhang(string email)
        {
            return kh.DeleteKhachhang(email);
        }
    }
}
