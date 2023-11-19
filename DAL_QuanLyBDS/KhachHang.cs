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
        IMongoCollection<BsonDocument> khachang = client.GetDatabase("QLBatDongSan").GetCollection<BsonDocument>("Khachhang");
        IMongoCollection<BsonDocument> khachhangdangtin = client.GetDatabase("QLBatDongSan").GetCollection<BsonDocument>("KhachHangDangTin");

        public bool dangtin(string tieuDe, string loaiNha, string dienTich, string soPhong, string gia, string diaChi, string hinhAnh)
        {
            try
            {
                DateTime ngayDang = DateTime.Now.Date;

                var dangtinDocument = new BsonDocument
            {
                {"TieuDe", tieuDe},
                {"LoaiNha", loaiNha},
                {"DienTich", dienTich},
                {"SoPhong", soPhong},
                {"Gia", gia},
                {"DiaChi", diaChi},
                {"HinhAnh", hinhAnh},
                {"ThoiGianDang", ngayDang},
                {"Duyet", false}
            };

                khachhangdangtin.InsertOne(dangtinDocument);

                Console.WriteLine("Đăng tin thành công, Vui lòng chờ nhân viên kiểm duyệt nội dung! ");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi đăng tin: {ex.Message}");
                return false;
            }
        }
        //
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



    }
}