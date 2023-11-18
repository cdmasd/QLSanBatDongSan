using MongoDB.Bson;
using System;
using System.Collections.Generic;

namespace BUS_QuanLyBDS
{
    public class KhachHang
    {
        private readonly DAL_QuanLyBDS.KhachHang kh = new DAL_QuanLyBDS.KhachHang();

        public bool DangTin(string tieuDe, string loaiNha, string  dienTich, string soPhong, string gia, string diaChi, string hinhAnh)
        {
            try
            {
                // Call the method from DAL to post a new advertisement
                return kh.dangtin(tieuDe, loaiNha, dienTich, soPhong, gia, diaChi, hinhAnh);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi đăng tin: {ex.Message}");
                return false;
            }
        }
        public List<BsonDocument>GetDataKhachHang()
        {
            return kh.getBaiDang(); 
        }
        public bool UpdateBaiDang(string tieuDe, string loaiNha, string dienTich, string soPhong, string gia, string diaChi, string hinhAnh)
        {
            try
            {
                // Call the method from DAL to update an advertisement
                return kh.UpdateBaidang(tieuDe, loaiNha, dienTich, soPhong, gia, diaChi, hinhAnh);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi cập nhật bài đăng: {ex.Message}");
                return false;
            }
        }
    }
}
