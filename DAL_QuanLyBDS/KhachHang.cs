using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QuanLyBDS
{
    public partial class KhachHang : Context
    {
        IMongoCollection<BsonDocument> Khachhang = client.GetDatabase("QLBatDongSan").GetCollection<BsonDocument>("Khachhang");
        IMongoCollection<BsonDocument> khachhangdangtin = client.GetDatabase("QLBatDongSan").GetCollection<BsonDocument>("KhachHangDangTin");

        public bool DangTin(string tieuDe, string loaiNha, double dienTich, int soPhong, double gia, string diaChi, string hinhAnh)
        {
            try
            {

                string nextMaNV = getNextMaNV();
                var dangtinDocument = new BsonDocument
                {
                    {"_id", nextMaNV},
                    {"Tieude", tieuDe},
                    {"Loainha", loaiNha},
                    {"Dientich", dienTich},
                    {"Sophong", soPhong},
                    {"Gia", gia},
                    {"Diachi", diaChi},
                    {"Hinhanh", hinhAnh},
                    {"Thoigiandang", DateTime.Now.ToString("dd-MM-yyyy")},
                    {"Trangthai", false}
                };

                khachhangdangtin.InsertOne(dangtinDocument);

                Console.WriteLine("Đăng tin thành công, vui lòng chờ nhân viên kiểm duyệt nội dung!");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi đăng tin: {ex.Message}");
                return false;
            }
        }
        string getNextMaNV()
        {
            var filter = Builders<BsonDocument>.Sort.Descending("_id");
            var lastDocument = khachhangdangtin.Find(new BsonDocument()).Sort(filter).Limit(1).ToList();
            var lastMaNV = lastDocument.Count > 0 ? lastDocument[0]["_id"].ToString() : null;

            if (lastMaNV != null)
            {
                var lastNumber = int.Parse(lastMaNV.Replace("DB", ""));
                return $"DB{lastNumber + 1:00}";
            }
            else
            {
                return "DB01";
            }
        }
        public List<BsonDocument> getBaiDang()
        {
            var filter = Builders<BsonDocument>.Filter.Empty;
            var DangtinData = khachhangdangtin.Find(filter).ToList();
            return DangtinData;
        }
        public bool UpdateBaidang(string id, string tieuDe, string loaiNha, double dienTich, int soPhong, double gia, string diaChi, string hinhAnh)
        {
            try
            {

                // Tạo bộ lọc sử dụng id của bản ghi cần cập nhật
                var filterBuilder = Builders<BsonDocument>.Filter;
                var filter = filterBuilder.Eq("_id", id);

                // Tạo bộ cập nhật để thiết lập các giá trị mới cho các trường trong bản ghi
                var updateBuilder = Builders<BsonDocument>.Update;
                var update = updateBuilder
                    .Set("Tieude", tieuDe)
                    .Set("Loainha", loaiNha)
                    .Set("Dientich", dienTich)
                    .Set("Sophong", soPhong)
                    .Set("Gia", gia)
                    .Set("Diachi", diaChi)
                    .Set("Hinhanh", hinhAnh);

                // Thực hiện hoạt động cập nhật với bộ lọc và cập nhật đã xác định
                var result = khachhangdangtin.UpdateOne(filter, update);

                // Kiểm tra xem có ít nhất một bản ghi đã được chỉnh sửa không
                return result.ModifiedCount > 0;
            }
            catch (Exception ex)
            {
                // Xử lý bất kỳ ngoại lệ nào xảy ra trong quá trình cập nhật
                Console.WriteLine($"Lỗi khi cập nhật bài đăng: {ex.Message}");
                return false;
            }
        }
        public List<BsonDocument> Getkhachhang()
        {
            var filter = Builders<BsonDocument>.Filter.Empty;
            var KhachhangData = Khachhang.Find(filter).ToList();
            return KhachhangData;
        }
        public bool UpdataKhachhang(string email, string hoten, string sdt, string sodu)
        {
            try
            {
                var filterBuilder = Builders<BsonDocument>.Filter;
                var filter = filterBuilder.Empty;
                var updateBuilder = Builders<BsonDocument>.Update;
                var update = updateBuilder
                    .Set("Email", email)
                    .Set("Hoten", hoten)
                    .Set("Sodienthoai", sdt)
                    .Set("Sodu", sodu);
                var result = Khachhang.UpdateOne(filter, update);
                return result.ModifiedCount > 0;
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Lỗi khi cập nhật bài đăng: {ex.Message}");
                return false;
            }
        }
        public bool DeleteKhachhang(string email)
        {
            try
            {
                var filterBuilder = Builders<BsonDocument>.Filter;
                var filter = filterBuilder.Eq("Email", email);
                var result = Khachhang.DeleteOne(filter);
                return result.DeletedCount > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi xóa bài đăng: {ex.Message}");
                return false;
            }

        }
    }
}
