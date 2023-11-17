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
        public FrmMain()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            dn.TopLevel = false;
            PanelMain.Controls.Add(dn);
            dn.Show();
            dn.FormClosed += new FormClosedEventHandler(FrmDangNhap_FormClosed);
        }
        void DangNhap()
        {
            FrmDangNhap newdangnhap = new FrmDangNhap();
            newdangnhap.TopLevel = false;
            PanelMain.Controls.Add(newdangnhap);
            newdangnhap.Show();
            newdangnhap.FormClosed += new FormClosedEventHandler(FrmDangNhap_FormClosed);
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            OpenVaitro();
            if(session == 0)
            {
                DangNhap();
            }
        }
        public void OpenVaitro()
        {
            if (session == 1)
            {
                this.Text = mail;
                if (dn.vaitro == "admin")
                {
                    FrmMainAdmin ad = new FrmMainAdmin();
                    ad.TopLevel = false;
                    PanelMain.Controls.Add(ad);
                    ad.Show();
                    ad.FormClosed += new FormClosedEventHandler(FrmMainAdmin_FormClosed);
                }
                else if (dn.vaitro == "khachhang")
                {
                    FrmMainKhachHang kh = new FrmMainKhachHang();
                    kh.TopLevel = false;
                    PanelMain.Controls.Add(kh);
                    kh.Show();
                    kh.FormClosed += new FormClosedEventHandler(FrmMainKhachHang_FormClosed);
                }
                else if (dn.vaitro == "nhanvien")
                {
                    FrmMainNhanVien nv = new FrmMainNhanVien();
                    nv.TopLevel = false;
                    PanelMain.Controls.Add(nv);
                    nv.Show();
                    nv.FormClosed += new FormClosedEventHandler(FrmMainNhanVien_FormClosed);
                }
                else
                {
                    FrmMainGuest guest = new FrmMainGuest();
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
        void FrmMainAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Refresh();
            FrmMain_Load(sender, e);
        }
        void FrmMainKhachHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Refresh();
            FrmMain_Load(sender, e);
        }
        void FrmMainNhanVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Refresh();
            FrmMain_Load(sender, e);
        }
        void FrmMainGuest_FormClosed(object sender, FormClosedEventArgs e)
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
