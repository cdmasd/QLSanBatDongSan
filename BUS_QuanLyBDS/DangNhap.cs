using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using MongoDB.Bson;
using System.Net.Mail;
using System.Net;
using PasswordGenerator;

namespace BUS_QuanLyBDS
{
    public partial class DangNhap
    {
        DAL_QuanLyBDS.DangNhap dn = new DAL_QuanLyBDS.DangNhap();
        public bool checkAccount(string email, string password)
        {
            return dn.checkAccount(email, encrytion(password));
        }
        public string getRole(string email)
        {
            return dn.getRole(email);
        }
        public bool insertKhachhang(string email, string name, string phone, string password)
        {
            return dn.insertKhachhang(email, name, phone, encrytion(password));
        }
        public bool changePass(string email, string password)
        {
            return dn.changePass(email, encrytion(password));
        }
        #region Xác thực
        // Mã hoá
        public string encrytion(string password)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] encrypt;
            UTF8Encoding encode = new UTF8Encoding();
            encrypt = md5.ComputeHash(encode.GetBytes(password));
            StringBuilder builder = new StringBuilder();
            foreach (var item in encrypt)
            {
                builder.Append(item.ToString());
            }
            return builder.ToString();
        }
        // Tạo chuỗi ngẫu nhiên
        public string RandomString()
        {
            var pass = new Password(8); // khởi tạo mật khẩu gồm 8 kí tự
            var passGenerate = pass.Next();
            return passGenerate;
        }
        #endregion
    }
}
