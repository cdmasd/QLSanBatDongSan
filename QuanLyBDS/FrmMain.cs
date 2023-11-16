using QuanLyBDS.Admin;
using QuanLyBDS.Guest;
using QuanLyBDS.KhachHang;
using QuanLyBDS.NhanVien;
using Sunny.UI;

namespace QuanLyBDS
{
    public partial class FrmMain : UIForm
    {
        public static int session = 0; // kiểm tra đăng nhập chưa
        public static string mail;
        FrmDangNhap dn = new FrmDangNhap();
        FrmMainAdmin ad = new FrmMainAdmin();
        FrmMainKhachHang kh = new FrmMainKhachHang();
        FrmMainNhanVien nv = new FrmMainNhanVien();
        FrmMainGuest guest = new FrmMainGuest();
        public FrmMain()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            DangNhap();
        }
        void DangNhap()
        {
            if (!CheckExistForm("FrmDangNhap"))
            {
                dn.TopLevel = false;
                PanelMain.Controls.Add(dn);
                dn.Show();
                dn.FormClosed += new FormClosedEventHandler(FrmDangNhap_FormClosed);
            }
            else
            {
                ActiveChildForm("FrmDangNhap");
            }
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            OpenVaitro();
        }
        public void OpenVaitro()
        {
            if (session == 1)
            {
                this.Text = mail;
                if (dn.vaitro == "admin")
                {
                    ad.TopLevel = false;
                    PanelMain.Controls.Add(ad);
                    ad.Show();
                }
                else if (dn.vaitro == "khachhang")
                {
                    kh.TopLevel = false;
                    PanelMain.Controls.Add(kh);
                    kh.Show();
                }
                else if (dn.vaitro == "nhanvien")
                {
                    nv.TopLevel = false;
                    PanelMain.Controls.Add(nv);
                    nv.Show();
                }
                else
                {
                    guest.TopLevel = false;
                    PanelMain.Controls.Add(guest);
                    guest.Show();
                }
            }
        }
        void FrmDangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Refresh();
            FrmMain_Load(sender, e);
        }
        private bool CheckExistForm(string name)
        {
            FormCollection fc = Application.OpenForms;
            var check = false;
            foreach (Form frm in fc)
            {
                if (frm.Name == name)
                {
                    frm.BringToFront();
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
    }
}
