using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QuanLyBDS
{
    public partial class NhanVien : Context
    {
        IMongoCollection<BsonDocument> dangtin = client.GetDatabase("QLBatDongSan").GetCollection<BsonDocument>("KhachHangDangTin");
        IMongoCollection<BsonDocument> nhanvien = client.GetDatabase("QLBatDongSan").GetCollection<BsonDocument>("NhanVien");
        IMongoCollection<BsonDocument> ticket = client.GetDatabase("QLBatDongSan").GetCollection<BsonDocument>("Ticket");
        public List<BsonDocument> Chuaduyet()
        {
            return dangtin.Find(new BsonDocument
            {
                { "TrangThai", false }
            }).ToList();
        }
        public List<BsonDocument> Daduyet()
        {
            return dangtin.Find(new BsonDocument
            {
                { "TrangThai", true }
            }).ToList();
        }
        public bool DeleteBaiDang(string id,string cause)
        {
            try
            {
                if(cause == "tuchoi")
                {
                    dangtin.DeleteOne(new BsonDocument
                    {
                        { "_id", id }
                    });
                } else
                {
                    dangtin.DeleteOne(new BsonDocument
                    {
                        { "_id", id }
                    });
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public string getNameNv(string email)
        {
            var result = nhanvien.Find(new BsonDocument
            {
                { "Email", email }
            }).ToList();
            return result[0]["Hoten"].ToString();
        }
        public bool Duyetbai(string id,string email)
        {
            try
            {
                var filter = Builders<BsonDocument>.Filter.Eq("_id", id);
                var update = Builders<BsonDocument>.Update.Set("TrangThai", true).Set("NguoiDuyet", getNameNv(email));
                var result = dangtin.UpdateOne(filter, update);
                if (result.ModifiedCount > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
        public List<BsonDocument> Chuahotro()
        {
            return ticket.Find(new BsonDocument
            {
                { "TrangThai", false }
            }).ToList();
        }
        public bool Hotro(string id, string email)
        {
            try
            {
                var filter = Builders<BsonDocument>.Filter.Eq("_id", id);
                var update = Builders<BsonDocument>.Update.Set("TrangThai", true).Set("NguoiHoTro", getNameNv(email));
                var result = ticket.UpdateOne(filter, update);
                if (result.ModifiedCount > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
