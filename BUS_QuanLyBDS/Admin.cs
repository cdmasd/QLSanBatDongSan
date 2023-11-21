using DTO_QuanLyBDS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using XSystem.Security.Cryptography;

namespace BUS_QuanLyBDS
{
    public class Admin
    {
        private readonly DAL_QuanLyBDS.Admin dal_Admin;

        public Admin()
        {
            dal_Admin = new DAL_QuanLyBDS.Admin();
        }

        public List<NhanVienDTO> DanhSachNhanVien()
        {
            return dal_Admin.DanhSachNhanVien();
        }

        public string MaNhanVien()
        {
            int soLuongNV = dal_Admin.DanhSachNhanVien().Count();
            List<int> listId = dal_Admin.DanhSachSoId();
            if (dal_Admin.DanhSachNhanVien().Count > 0)
            {
                int maxId = listId.Max() + 1;
                if (soLuongNV > 0)
                {
                    if (maxId < 10)
                    {
                        return "NV000" + maxId;
                    }
                    else if (maxId < 100)
                    {
                        return "NV" + "00" + maxId;
                    }
                    else if (maxId < 1000)
                    {
                        return "NV" + "0" + maxId;
                    }
                    else
                    {
                        return "NV" + maxId;
                    }
                }
            }
            return "NV0001";
        }

        public string ThemNhanVien(NhanVienDTO nhanVien, TaiKhoanDTO taiKhoan)
        {
            return dal_Admin.ThemNhanVien(nhanVien, taiKhoan);
        }

        public string CapNhatNhanVien(NhanVienDTO nhanVien)
        {
            return dal_Admin.CapNhatNhanVien(nhanVien);
        }

        public string Encrytion(string password)
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

        public bool KiemTraEmail(string inputEmail)
        {
            inputEmail = inputEmail ?? string.Empty;
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(inputEmail))
                return (true);
            else
                return (false);
        }

        public string XoaNhanVien(string Email)
        {
            return dal_Admin.XoaNhanVien(Email);
        }

        public List<NhanVienDTO> TimKiemNhanVienTheoId(string Id)
        {
            return dal_Admin.TimKiemNhanVienTheoId(Id);
        }
    }
}
