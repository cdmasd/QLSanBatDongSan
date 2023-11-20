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
    public partial class FrmMainKhachHang : UIForm
    {
        public FrmMainKhachHang()
        {
            InitializeComponent();
        }
        void ResetColor()
        {
            btnThongtin.BackColor = SystemColors.MenuHighlight;
            btnDangbds.BackColor = SystemColors.MenuHighlight;
            btnDanhsachbaidang.BackColor = SystemColors.MenuHighlight;
            btnHotro.BackColor = SystemColors.MenuHighlight;
            btnDoimk.BackColor = SystemColors.MenuHighlight;
        }
        private void btnThongtin_Click(object sender, EventArgs e)
        {
            ResetColor();
            btnThongtin.BackColor = Color.SteelBlue;
            if (!CheckExistForm("FrmThongTin"))
            {
                FrmThongTin tt = new FrmThongTin();
                tt.TopLevel = false;
                panelKhachHang.Controls.Add(tt);
                tt.Show();
                tt.BringToFront();
            }
            else
            {
                ActiveChildForm("FrmThongTin");
            }
        }

        private void btnDangbds_Click(object sender, EventArgs e)
        {
            ResetColor();
            btnDangbds.BackColor = Color.SteelBlue;
            if (!CheckExistForm("FrmBaiDang"))
            {
                FrmBaiDang bd = new FrmBaiDang();
                bd.TopLevel = false;
                panelKhachHang.Controls.Add(bd);
                bd.Show();
                bd.BringToFront();

            }
            else
            {
                ActiveChildForm("FrmBaiDang");
            }
        }

        private void btnThongkebds_Click(object sender, EventArgs e)
        {
            ResetColor();
            btnDanhsachbaidang.BackColor = Color.SteelBlue;
            if (!CheckExistForm("FrmDanhSachBaiDang"))
            {
                FrmDanhSachBaiDang listbd = new FrmDanhSachBaiDang();
                listbd.TopLevel = false;
                panelKhachHang.Controls.Add(listbd);
                listbd.Show();
                listbd.BringToFront();

            }
            else
            {
                ActiveChildForm("FrmDanhSachBaiDang");
            }
        }

        private void btnHotro_Click(object sender, EventArgs e)
        {
            ResetColor();
            btnHotro.BackColor = Color.SteelBlue;
            if (!CheckExistForm("FrmHoTro"))
            {
                FrmHoTro hotro = new FrmHoTro();
                hotro.TopLevel = false;
                panelKhachHang.Controls.Add(hotro);
                hotro.Show();
                hotro.BringToFront();

            }
            else
            {
                ActiveChildForm("FrmHoTro");
            }
        }

        private void btnDoimk_Click(object sender, EventArgs e)
        {
            ResetColor();
            btnDoimk.BackColor = Color.SteelBlue;
            if (!CheckExistForm("FrmDoiMatKhau"))
            {
                FrmDoiMatKhau dmk = new FrmDoiMatKhau();
                dmk.TopLevel = false;
                panelKhachHang.Controls.Add(dmk);
                dmk.Show();
                dmk.BringToFront();

            }
            else
            {
                ActiveChildForm("FrmDoiMatKhau");
            }
        }
        // Kiểm tra form đã tồn tại trước khi mở
        private bool CheckExistForm(string name)
        {
            FormCollection fc = Application.OpenForms;
            var check = false;
            foreach (Form frm in fc)
            {
                if (frm.Name == name)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }

        // Show form lên trên cùng của form cha
        private void ActiveChildForm(string name)
        {
            FormCollection fc = Application.OpenForms;
            foreach (Form frm in fc)
            {
                if (frm.Name == name)
                {
                    frm.BringToFront();
                    break;
                }
            }
        }

        private void btnNaptien_Click(object sender, EventArgs e)
        {
            ResetColor();
            btnDoimk.BackColor = Color.SteelBlue;
        }

        private void btnDangxuat_Click(object sender, EventArgs e)
        {
            FrmMain.mail = "Quản lý bất động sản";
            FrmMain.session = 0;
            this.Close();
        }
    }
}
