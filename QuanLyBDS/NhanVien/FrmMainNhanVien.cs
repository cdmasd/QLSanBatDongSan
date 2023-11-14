using QuanLyBDS.KhachHang;
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
    public partial class FrmMainNhanVien : UIForm
    {
        public FrmMainNhanVien()
        {
            InitializeComponent();
        }
        void ResetColor()
        {
            btnKhachhang.BackColor = SystemColors.MenuHighlight;
            btnDuyetbai.BackColor = SystemColors.MenuHighlight;
            btnDaduyet.BackColor = SystemColors.MenuHighlight;
            btnHotro.BackColor = SystemColors.MenuHighlight;
            btnDoimatkhau.BackColor = SystemColors.MenuHighlight;
        }
        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            ResetColor();
            btnKhachhang.BackColor = Color.SteelBlue;
            if (!CheckExistForm("FrmQLKhachHang"))
            {
                FrmQLKhachHang kh = new FrmQLKhachHang();
                kh.TopLevel = false;
                panelNhanVien.Controls.Add(kh);
                kh.Show();
                kh.BringToFront();
            }
            else
            {
                ActiveChildForm("FrmQLKhachHang");
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

        private void btnDuyetbai_Click(object sender, EventArgs e)
        {
            ResetColor();
            btnDuyetbai.BackColor = Color.SteelBlue;
            if (!CheckExistForm("FrmDuyetbai"))
            {
                FrmDuyetbai duyetbai = new FrmDuyetbai();
                duyetbai.TopLevel = false;
                panelNhanVien.Controls.Add(duyetbai);
                duyetbai.Show();
                duyetbai.BringToFront();
            }
            else
            {
                ActiveChildForm("FrmDuyetbai");
            }
        }

        private void btnDaduyet_Click(object sender, EventArgs e)
        {
            ResetColor();
            btnDaduyet.BackColor = Color.SteelBlue;
            if (!CheckExistForm("FrmDaduyet"))
            {
                FrmDaduyet daduyet = new FrmDaduyet();
                daduyet.TopLevel = false;
                panelNhanVien.Controls.Add(daduyet);
                daduyet.Show();
                daduyet.BringToFront();
            }
            else
            {
                ActiveChildForm("FrmDaduyet");
            }
        }

        private void btnHotro_Click(object sender, EventArgs e)
        {
            ResetColor();
            btnHotro.BackColor = Color.SteelBlue;
            if (!CheckExistForm("FrmHotro"))
            {
                FrmHotro ht = new FrmHotro();
                ht.TopLevel = false;
                panelNhanVien.Controls.Add(ht);
                ht.Show();
                ht.BringToFront();
            }
            else
            {
                ActiveChildForm("FrmDaduyet");
            }
        }

        private void btnDoimatkhau_Click(object sender, EventArgs e)
        {
            ResetColor();
            btnDoimatkhau.BackColor = Color.SteelBlue;
            if (!CheckExistForm("FrmDoimatkhau"))
            {
                FrmDoimatkhau dmk = new FrmDoimatkhau();
                dmk.TopLevel = false;
                panelNhanVien.Controls.Add(dmk);
                dmk.Show();
                dmk.BringToFront();
            }
            else
            {
                ActiveChildForm("FrmDoimatkhau");
            }
        }
    }
}
