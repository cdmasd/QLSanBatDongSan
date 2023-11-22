using MongoDB.Bson;
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

namespace QuanLyBDS.NhanVien
{
    public partial class FrmQLKhachHang : UIForm
    {
        BUS_QuanLyBDS.NhanVien nv = new BUS_QuanLyBDS.NhanVien();
        public FrmQLKhachHang()
        {
            InitializeComponent();
            LoadDataQLyKhachhang();
            dtView.CellClick += dtView_CellClick;
        }

        private void btnNap_Click(object sender, EventArgs e)
        {
            double naptien = double.Parse(txtNap.Text);
            double sodu = double.Parse(txtSodu.Text) + naptien;
            string email = txtEmail.Text;
            string hoten = txtHoten.Text;
            string sdt = txtSdt.Text;
            string id = txtId.Text;
            bool result = nv.UpdateKhachhang(id, email, hoten, sdt, sodu);
            if (result)
            {
                MessageBox.Show("Nạp tiền thành công");
                LoadDataQLyKhachhang();
                dtView.Refresh();
            }
            else
            {
                MessageBox.Show("Nạp tiền thất bại");
            }
        }
        private void LoadDataQLyKhachhang()
        {
            List<BsonDocument> dataKhachhang = nv.Getkhachhang();
            dtView.ClearAll();
            if (dataKhachhang.Count > 0)
            {
                dtView.Columns.Add("_id", "ID");
                dtView.Columns.Add("Email", "Email");
                dtView.Columns.Add("Hoten", "Họ tên");
                dtView.Columns.Add("Sodienthoai", "Số điện thoại");
                dtView.Columns.Add("SoDu", "Số dư");
                txtId.Visible = false;
                dtView.Rows.Clear();

                foreach (var doc in dataKhachhang)
                {
                    List<object> values = new List<object>();
                    foreach (var key in doc.Names)
                    {
                        values.Add(doc[key]);
                    }
                    dtView.Rows.Add(values.ToArray());
                }
            }
            else
            {
                txtId.Visible = true;
            }

        }
        private void dtView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dtView.Rows[e.RowIndex];

                // Lấy dữ liệu từ các ô của dòng được chọn
                string id = selectedRow.Cells["_id"].Value.ToString();
                string email = selectedRow.Cells["Email"].Value.ToString();
                string hoten = selectedRow.Cells["Hoten"].Value.ToString();
                string sdt = selectedRow.Cells["Sodienthoai"].Value.ToString();
                string sodu = selectedRow.Cells["SoDu"].Value.ToString();

                // Hiển thị dữ liệu lên các controls
                txtId.Text = id;
                txtEmail.Text = email;
                txtHoten.Text = hoten;
                txtSdt.Text = sdt;
                txtSodu.Text = sodu;

            }
        }
    }
}
