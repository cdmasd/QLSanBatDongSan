using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QuanLyBDS
{
    public class DangNhap : Context
    {
        dynamic db = client.GetDatabase("QLBatDongSan");
        IMongoCollection<BsonDocument> taikhoan = client.GetDatabase("QLBatDongSan").GetCollection<BsonDocument>("TaiKhoan");
        IMongoCollection<BsonDocument> khachhang = client.GetDatabase("QLBatDongSan").GetCollection<BsonDocument>("Khachhang");
        public bool checkAccount(string email, string password)
        {
            var result = taikhoan.Find(new BsonDocument
            {
                { "Email", email },
                { "Matkhau", password }
            }).ToList();
            if(result.Count() > 0)
            {
                return true;
            }
            return false;
        }
        public string getRole(string email)
        {
            var result = taikhoan.Find(new BsonDocument
            {
                { "Email", email }
            }).ToList();
            return result[0]["Vaitro"].ToString();
        }
        public void registerAccount(string email, string password)
        {
                taikhoan.InsertOne(new BsonDocument
                {
                    {"Email",email},
                    {"Matkhau", password},
                    {"Vaitro","khachhang"}
                });
        }
        public bool insertKhachhang(string email, string name, string phone, string password)
        {
            try
            {
                khachhang.InsertOne(new BsonDocument
                {
                    {"Email",email},
                    {"Hoten",name },
                    {"Sodienthoai",phone }
                });
                registerAccount(email, password);
                return true;
            } catch (Exception ex)
            {
                return false;
            }
        }
        public bool changePass(string email, string password)
        {
            try
            {
                var filter = Builders<BsonDocument>.Filter.Eq("Email", email);
                var update = Builders<BsonDocument>.Update.Set("Matkhau", password);
                taikhoan.UpdateOne(filter, update);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
