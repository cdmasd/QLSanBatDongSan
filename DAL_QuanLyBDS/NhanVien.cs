using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QuanLyBDS
{
    public class NhanVien : Context
    {
        dynamic db = client.GetDatabase("QLBatDongSan");
        IMongoCollection<BsonDocument> nhanvien = client.GetDatabase("QLBatDongSan").GetCollection<BsonDocument>("NhanVien");
        IMongoCollection<BsonDocument> khachhangdangtin = client.GetDatabase("QLBatDongSan").GetCollection<BsonDocument>("KhachHangDangTin");
        public List <BsonDocument>getBaidangKhachhang()
        {
            var filter = Builders<BsonDocument>.Filter.Empty;
            var DataDangtin = khachhangdangtin.Find(filter).ToList(); 
            return DataDangtin;
        }
    }
}
