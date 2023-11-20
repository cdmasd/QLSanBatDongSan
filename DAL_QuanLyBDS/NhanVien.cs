using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QuanLyBDS
{
    public class NhanVien : Context
    {
        IMongoCollection<BsonDocument> dangtin = client.GetDatabase("QLBatDongSan").GetCollection<BsonDocument>("KhachHangDangTin");
        IMongoCollection<BsonDocument> nhanvien = client.GetDatabase("QLBatDongSan").GetCollection<BsonDocument>("NhanVien");
        public List<BsonDocument> Chuaduyet()
        {
            return dangtin.Find(new BsonDocument
            {
                { "Duyet", false }
            }).ToList();
        }
        public bool DeleteBaiDang(string id)
        {
            try
            {
                dangtin.DeleteOne(new BsonDocument
                {
                    { "_id", id }
                });
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
                var update = Builders<BsonDocument>.Update.Set("Duyet", true).Set("NguoiDuyet", getNameNv(email));
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
    }
}
