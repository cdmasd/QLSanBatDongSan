using MongoDB.Bson;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace QuanLyBDS.NhanVien
{
    public partial class FrmQLKhachHang : UIForm
    {
        BUS_QuanLyBDS.KhachHang kh = new BUS_QuanLyBDS.KhachHang();

        public FrmQLKhachHang()
        {
            InitializeComponent();
            LoadKhachHang();
            dtView.CellClick += dtView_CellClick;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string Email = txtEmail.Text;
            if (!string.IsNullOrEmpty(Email))
            {
                bool XoaThanhCong = kh.deleteKhachhang(Email);
                if (XoaThanhCong)
                {
                    MessageBox.Show("Xóa khách hàng thành công");
                    LoadKhachHang();
                }
                else
                {
                    MessageBox.Show("Xóa khách hàng không thành công");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một khách hàng để xóa");
            }
        }

        private void LoadKhachHang()
        {
            List<BsonDocument> dataBaiDang = kh.GetKhachHang();
            dtView.ClearAll();
            // Load header name
            foreach (var header in dataBaiDang[0].Names)
            {
                if (header != "ThoiGianDang")
                {
                    if (header != "Duyet")
                    {
                        dtView.Columns.Add(header, header);
                    }
                }
                else
                {
                    continue;
                }
            }

            // Đổ dữ liệu vào từng dòng của DataGridView
            foreach (var doc in dataBaiDang)
            {
                List<object> values = new List<object>();
                foreach (var key in doc.Names)
                {
                    values.Add(doc[key]);
                }
                dtView.Rows.Add(values.ToArray());
            }
            dtView.Columns[0].HeaderText = "ID";
            dtView.Columns[1].HeaderText = "Họ tên";
            dtView.Columns[2].HeaderText = "Email";
            dtView.Columns[3].HeaderText = "Số điện thoại";
            dtView.Columns[4].HeaderText = "Số dư";

        }
        private void dtView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dtView.Rows[e.RowIndex];

                // Lấy dữ liệu từ các ô của dòng được chọn
                string email = selectedRow.Cells["Email"].Value.ToString();
                string hoten = selectedRow.Cells["Hoten"].Value.ToString();
                string sdt = selectedRow.Cells["Sodienthoai"].Value.ToString();
                string sodu = selectedRow.Cells["SoDu"].Value.ToString();

                // Hiển thị dữ liệu lên các controls
                txtEmail.Text = email;
                txtHoten.Text = hoten;
                txtSdt.Text = sdt;
                txtSodu.Text = sodu;


            }
        }
        private void dtView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmQLKhachHang_Load(object sender, EventArgs e)
        {

        }
    }
}
