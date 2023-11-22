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
    public partial class FrmBaiDang : UIForm
    {
        BUS_QuanLyBDS.KhachHang kh = new BUS_QuanLyBDS.KhachHang();
        string checkUrlImage;
        string fileName;
        string filSavePath;
        string fileAddress;
        public FrmBaiDang()
        {
            InitializeComponent();
            Loainha();
        }
        private void Loainha()
        {
            cbLoainha.Items.Add("Nhà cấp 3");
            cbLoainha.Items.Add("Nhà cấp 4");
            cbLoainha.Items.Add("Biệt thự");
            cbLoainha.Items.Add("Vincome");
            cbLoainha.Items.Add("Khác");
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra nếu email đã được xác thực (đã đăng nhập)
                string tieuDe = txtTieude.Text;
                string loaiNha = cbLoainha.Text;

                // Convert string inputs to appropriate numeric types
                if (!double.TryParse(txtDientich.Text, out double dientich))
                {
                    MessageBox.Show("Vui lòng nhập đúng định dạng cho diện tích.");
                    return;
                }

                if (!int.TryParse(txtSophong.Text, out int sophong))
                {
                    MessageBox.Show("Vui lòng nhập đúng định dạng cho số phòng.");
                    return;
                }

                if (!double.TryParse(txtGia.Text, out double gia))
                {
                    MessageBox.Show("Vui lòng nhập đúng định dạng cho giá.");
                    return;
                }

                string diaChi = txtDiachi.Text;
                string hinhAnh = txtHinhanh.Text;

                // Kiểm tra nếu có dữ liệu bị bỏ trống
                if (string.IsNullOrEmpty(tieuDe) || string.IsNullOrEmpty(loaiNha) || string.IsNullOrEmpty(diaChi) || string.IsNullOrEmpty(hinhAnh))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                    return;
                }

                // Gọi phương thức DangTin từ lớp BUS và truyền địa chỉ email
                bool result = kh.DangTin(tieuDe, loaiNha, dientich, sophong, gia, diaChi, hinhAnh);

                if (result)
                {
                    MessageBox.Show("Đăng tin thành công. Vui lòng chờ duyệt từ phía nhân viên.");
                }
                else
                {
                    MessageBox.Show("Đăng tin thất bại. Vui lòng kiểm tra lại thông tin.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng cho các trường số.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlopen = new OpenFileDialog();
            dlopen.Filter = "Bitmap(*.bmp)|*.bmp|JPEG(*.jpg)|*.jpg|PNG(*.png)|*.png|GIF(*.gif)|*.gif|ALL file(*.*)|*.*";
            dlopen.FilterIndex = 2;
            dlopen.Title = "Chọn hình ảnh sản phẩm";
            if (dlopen.ShowDialog() == DialogResult.OK)
            {
                fileAddress = dlopen.FileName;
                picHinhAnh.Image = Image.FromFile(fileAddress);
                fileName = Path.GetFileName(dlopen.FileName);
                string saveDirectory = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                filSavePath = saveDirectory + "\\Images\\" + fileName;
                txtHinhanh.Text = "\\Images\\" + fileName;

            }
        }
    }
}
