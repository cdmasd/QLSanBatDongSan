using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBDS.KhachHang
{
    public partial class FrmDoiMatKhau : UIForm
    {
        DAL_QuanLyBDS.DangNhap dn = new DAL_QuanLyBDS.DangNhap();
        public FrmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void btnDoimatkhau_Click(object sender, EventArgs e)
        {
            string Email = txtEmail.Text;
            string OldPass = txtMatkhauhientai.Text;
            string NewPass = txtMatkhaumoi.Text;
            try
            {
                if (dn.checkAccount(Email, OldPass))
                {
                    dn.changePass(Email, NewPass);
                    MessageBox.Show("Đổi mật khẩu thành công.");


                }
                else
                {
                    MessageBox.Show("Mật khẩu cũ không đúng hoặc email không tồn tại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
            }
        }
    }
}
