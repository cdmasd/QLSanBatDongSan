using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QuanLyBDS
{
    public class KhachHang : Context
    {
        //Khách hàng đăng tin
        dynamic db = client.GetDatabase("QLBatDongSan");
        IMongoCollection<BsonDocument> Khachhang = client.GetDatabase("QLBatDongSan").GetCollection<BsonDocument>("Khachhang");
        IMongoCollection<BsonDocument> khachhangdangtin = client.GetDatabase("QLBatDongSan").GetCollection<BsonDocument>("KhachHangDangTin");

        public bool dangtin(string tieuDe, string loaiNha, string dienTich, string soPhong, string gia, string diaChi, string hinhAnh)
        {
            try
            {
                DateTime ngayDang = DateTime.Now.Date;
                string nextMaNV = getNextMaNV();

                khachhangdangtin.InsertOne(new BsonDocument

                {
                    {"_id", nextMaNV},
                    {"TieuDe", tieuDe},
                    {"LoaiNha", loaiNha},
                    {"DienTich", dienTich},
                    {"SoPhong", soPhong},
                    {"Gia", gia},
                    {"DiaChi", diaChi},
                    {"HinhAnh", hinhAnh},
                    {"ThoiGianDang", ngayDang},
                    {"Duyet", false}
                });

                Console.WriteLine("Đăng tin thành công, Vui lòng chờ nhân viên kiểm duyệt nội dung! ");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi đăng tin: {ex.Message}");
                return false;
            }
        }
        // Lấy bài đăng
        public List<BsonDocument> getBaiDang()
        {
                var filter = Builders<BsonDocument>.Filter.Empty;
                var DangtinData = khachhangdangtin.Find(filter).ToList();
                return DangtinData;
        }
        //Cập nhật bài đăng 
        public bool UpdateBaidang(string tieuDe, string loaiNha, string dienTich, string soPhong, string gia, string diaChi, string hinhAnh)
        {
            try
            {
                var filterBuilder = Builders<BsonDocument>.Filter;
                var filter = filterBuilder.Empty;

                var updateBuilder = Builders<BsonDocument>.Update;
                var update = updateBuilder
                    .Set("TieuDe", tieuDe)
                    .Set("LoaiNha", loaiNha)
                    .Set("DienTich", dienTich)
                    .Set("SoPhong", soPhong)
                    .Set("Gia", gia)
                    .Set("DiaChi", diaChi)
                    .Set("HinhAnh", hinhAnh);

                var result = khachhangdangtin.UpdateOne(filter, update);

                return result.ModifiedCount > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi cập nhật bài đăng: {ex.Message}");
                return false;
            }
        }
        // xoá bài
        public bool DeletebaiDang (string tieude)
        {
            try
            {
                var filterBuilder = Builders<BsonDocument>.Filter;
                var filter = filterBuilder.Eq("TieuDe", tieude);
                var reusult = khachhangdangtin.DeleteOne(filter);
                return reusult.DeletedCount > 0; 

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi xóa bài đăng: {ex.Message}");
                return false;
            }
        }
        public List <BsonDocument>Getkhachhang()
        {
            var filter = Builders<BsonDocument>.Filter.Empty;
            var datakhachhang = Khachhang.Find(filter).ToList();
            return datakhachhang; 
        }
        public bool UpdataKhachhang (string email, string hoten, string sdt, string sodu)
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
            catch(Exception ex)
            {

                Console.WriteLine($"Lỗi khi cập nhật bài đăng: {ex.Message}");
                return false;
            }
        }
        public bool deleteKhachhang(string email)
        {
            try
            {
                var filterBuilder = Builders<BsonDocument>.Filter;
                var filter = filterBuilder.Eq("email", email);
                var result = Khachhang.DeleteOne(filter);
                return result.DeletedCount > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi xóa bài đăng: {ex.Message}");
                return false;
            }

        }
        string getNextMaNV()
        {
            // Giảm dần theo mã nhân viên
            var filter = Builders<BsonDocument>.Sort.Descending("_id");
            // Lấy ra đối tượng có mã nhân viên cao nhất
            var lastDocument = khachhangdangtin.Find(new BsonDocument()).Sort(filter).Limit(1).ToList();
            // Nếu trong đối tượng lastDocument không tìm được đối tượng nào thì trả về null
            // Ngược lại gán mã nhân viên cho lastMaNV
            var lastMaNV = lastDocument.Count > 0 ? lastDocument[0]["_id"].ToString() : null;

            if (lastMaNV != null)
            {
                // Lấy số từ chuỗi và tăng giá trị lên 1
                var lastNumber = int.Parse(lastMaNV.Replace("DB", ""));
                return $"DB{lastNumber + 1:00}";
            }
            else
            {
                return "DB01";
            }
        }
    }
}