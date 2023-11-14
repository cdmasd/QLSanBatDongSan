using Sunny.UI;

namespace QuanLyBDS
{
    public partial class FrmDangNhap : UIForm
    {
        public FrmDangNhap()
        {
            InitializeComponent();
            LoginView();
        }
        void ResetValues()
        {
            txtEmailre.Text = null;
            txtHoTenre.Text = null;
            txtSoDTre.Text = null;
            txtPasswordre.Text = null;
        }
        void LoginView()
        {
            uiLabel1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            txtEmail.Enabled = true;
            txtEmail.Visible = true;
            txtPassword.Enabled = true;
            txtPassword.Visible = true;
            chkRemember.Enabled = true;
            chkRemember.Visible = true;
            btnForgotPassword.Enabled = true;
            btnForgotPassword.Visible = true;
            btnLogin.Enabled = true;
            btnLogin.Visible = true;
            uiLabel2.Visible = true;
            btnTaoTaiKhoan.Enabled = true;
            btnTaoTaiKhoan.Visible = true;
            btnKhach.Enabled = true;
            btnKhach.Visible = true;
            // register
            lb1re.Visible = false;
            lb2re.Visible = false;
            lb3re.Visible = false;
            lb4re.Visible = false;
            lb5re.Visible = false;
            lb6re.Visible = false;
            txtEmailre.Enabled = false;
            txtEmailre.Visible = false;
            txtPasswordre.Enabled = false;
            txtPasswordre.Visible = false;
            txtHoTenre.Enabled = false;
            txtHoTenre.Visible = false;
            txtSoDTre.Enabled = false;
            txtSoDTre.Visible = false;
            btnRegister.Enabled = false;
            btnRegister.Visible = false;
            btnDangNhapre.Enabled = false;
            btnDangNhapre.Visible = false;
            txtXacthuc.Enabled = false;
            txtXacthuc.Visible = false;
            btnLayma.Enabled = false;
            btnLayma.Visible = false;
            label3.Visible = false;
        }
        void RegisterView()
        {
            lb1re.Visible = true;
            lb2re.Visible = true;
            lb3re.Visible = true;
            lb4re.Visible = true;
            lb5re.Visible = true;
            lb6re.Visible = true;
            txtEmailre.Enabled = true;
            txtEmailre.Visible = true;
            txtPasswordre.Enabled = true;
            txtPasswordre.Visible = true;
            txtHoTenre.Enabled = true;
            txtHoTenre.Visible = true;
            txtSoDTre.Enabled = true;
            txtSoDTre.Visible = true;
            btnRegister.Enabled = true;
            btnRegister.Visible = true;
            btnDangNhapre.Enabled = true;
            btnDangNhapre.Visible = true;
            txtXacthuc.Enabled = true;
            txtXacthuc.Visible = true;
            btnLayma.Enabled = true;
            btnLayma.Visible = true;
            label3.Visible = true;
            // Login
            uiLabel1.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            txtEmail.Enabled = false;
            txtEmail.Visible = false;
            txtPassword.Enabled = false;
            txtPassword.Visible = false;
            chkRemember.Enabled = false;
            chkRemember.Visible = false;
            btnForgotPassword.Enabled = false;
            btnForgotPassword.Visible = false;
            btnLogin.Enabled = false;
            btnLogin.Visible = false;
            uiLabel2.Visible = false;
            btnTaoTaiKhoan.Enabled = false;
            btnTaoTaiKhoan.Visible = false;
            btnKhach.Enabled = false;
            btnKhach.Visible = false;
        }
        // Mở giao diện của register
        private void btnTaoTaiKhoan_Click(object sender, EventArgs e)
        {
            RegisterView();
        }
        // Mở giao diện của đăng nhập
        private void btnDangNhapre_Click(object sender, EventArgs e)
        {
            LoginView();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            ResetValues();
        }
    }
}
