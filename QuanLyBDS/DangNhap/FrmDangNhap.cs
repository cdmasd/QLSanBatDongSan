using Sunny.UI;
using System.Net.Mail;
using System.Net;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace QuanLyBDS
{
    public partial class FrmDangNhap : UIForm
    {
        BUS_QuanLyBDS.DangNhap dn = new BUS_QuanLyBDS.DangNhap();
        public string vaitro { get; set; }
        string num;
        string newpass;
        public FrmDangNhap()
        {
            InitializeComponent();
            LoginView();
            settingsUI();
        }
        private void FrmDangNhap_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.isSave)
            {
                txtEmail.Text = Properties.Settings.Default.email;
                txtPassword.Text = Properties.Settings.Default.matkhau;
                chkRemember.Checked = true;
            }
        }

        #region Giao diện
        public void settingsUI()
        {
            UIStyles.DPIScale = true;
            UIStyles.GlobalFont = true;
            UIStyles.GlobalFontName = "Tahoma";
            UIStyles.SetDPIScale();
            UILocalize.OK = "Ok";
            UILocalize.Cancel = "Cancel";
            UILocalize.SuccessTitle = "Success";
            UILocalize.ErrorTitle = "Error";
        }

        void ResetValues()
        {
            txtEmailre.Text = null;
            txtHoTenre.Text = null;
            txtSoDTre.Text = null;
            txtPasswordre.Text = null;
            txtXacthuc.Text = null;
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
        #endregion
        #region chức năng
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmailre.Text) || string.IsNullOrEmpty(txtHoTenre.Text)
                || string.IsNullOrWhiteSpace(txtSoDTre.Text) || string.IsNullOrEmpty(txtPasswordre.Text))
            {
                ShowErrorNotifier("Các trường không được để rỗng");
                txtEmailre.Focus();
                return;
            }
            if (!isEmail(txtEmailre.Text.Trim()))
            {
                ShowErrorNotifier("Sai định dạng email");
                txtEmailre.Focus();
                return;
            }
            if (!isPhone(txtSoDTre.Text.Trim()))
            {
                ShowErrorNotifier("Sai định dạng số điện thoại");
                txtSoDTre.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtXacthuc.Text))
            {
                ShowErrorNotifier("Vui lòng lấy mã xác thực và kiểm tra email");
                txtXacthuc.Focus();
                return;
            }
            if (txtXacthuc.Text != num)
            {
                ShowErrorNotifier("Mã xác thực không chính xác");
                txtXacthuc.Focus();
                return;
            }
            if (dn.insertKhachhang(txtEmailre.Text, txtHoTenre.Text, txtSoDTre.Text, txtPasswordre.Text))
            {
                ShowSuccessTip("Đăng kí thành công");
                // Lưu thông tin tài khoản
                btnDangNhapre_Click(sender, e);
            }
            else
            {
                UIMessageDialog.ShowErrorDialog(this, "Dăng kí không thành công,email hoặc số điện thoại đã tồn tại");
            }
            ResetValues();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                ShowErrorNotifier("Các trường không được rỗng");
                return;
            }
            if (dn.checkAccount(txtEmail.Text, txtPassword.Text))
            {
                UIMessageDialog.ShowSuccessDialog(this, "Đăng nhập thành công");
                // Gửi kết quả đăng nhập cho frmMain
                FrmMain.mail = txtEmail.Text;
                FrmMain.session = 1;
                vaitro = dn.getRole(txtEmail.Text);
                // Lưu thông tin tài khoản
                Properties.Settings.Default.isSave = chkRemember.Checked;
                if (chkRemember.Checked)
                {
                    Properties.Settings.Default.email = txtEmail.Text;
                    Properties.Settings.Default.matkhau = txtPassword.Text;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    Properties.Settings.Default.email = "";
                    Properties.Settings.Default.matkhau = "";
                    Properties.Settings.Default.Save();
                }

                this.Close();
            }
            else
            {
                UIMessageDialog.ShowSuccessDialog(this, "Đăng nhập không thành công, kiểm tra lại email hoặc mật khẩu");
                txtEmail.Text = "";
                txtPassword.Text = "";
                txtEmail.Focus();
            }
        }

        private void btnKhach_Click(object sender, EventArgs e)
        {
            FrmMain.mail = "Sàn bất động sản";
            FrmMain.session = 1;
            vaitro = "guest";
            this.Close();
        }
        private void btnLayma_Click(object sender, EventArgs e)
        {
            num = generateNum();
            try
            {
                // Khởi tạo đối tượng MailMessage để tạo email.
                MailMessage Msg = new MailMessage();

                // Đặt người gửi email.
                Msg.From = new MailAddress("tienphanps28044@gmail.com");

                // Đặt người nhận email, thường là địa chỉ email của người dùng muốn khôi phục mật khẩu.
                Msg.To.Add(txtEmailre.Text.Trim());

                // Đặt tiêu đề của email.
                Msg.Subject = "Mã xác thực phần mềm quản lý bất động sản";

                // Đặt nội dung (body) của email và chèn mật khẩu mới vào nội dung email.
                Msg.Body = $"Mã xác thực của bạn là : {num}";

                using (SmtpClient client = new SmtpClient())
                {
                    client.EnableSsl = true;
                    client.UseDefaultCredentials = false;
                    client.Credentials = new NetworkCredential("tienphanps28044@gmail.com", "oxap pttt nkmb yvuu");
                    client.Host = "smtp.gmail.com";
                    client.Port = 587;
                    client.DeliveryMethod = SmtpDeliveryMethod.Network;

                    client.Send(Msg);
                }
                UIMessageDialog.ShowSuccessDialog(this, $"Đã gửi mã xác thực vào địa chỉ email : {txtEmailre.Text}");
            }
            catch (Exception ex)
            {
                // Nếu lỗi là do lỗi khác, hãy hiển thị thông báo lỗi.
                UIMessageDialog.ShowErrorDialog(this, ex.Message);
            }
        }
        private void btnForgotPassword_Click(object sender, EventArgs e)
        {
            newpass = dn.RandomString();
            if (txtEmail.Text == "")
            {
                ShowErrorNotifier("Vui lòng nhập email lấy lại mật khẩu");
                return;
            }
            if (dn.changePass(txtEmail.Text, newpass))
            {
                try
                {
                    // Khởi tạo đối tượng MailMessage để tạo email.
                    MailMessage Msg = new MailMessage();

                    // Đặt người gửi email.
                    Msg.From = new MailAddress("tienphanps28044@gmail.com");

                    // Đặt người nhận email, thường là địa chỉ email của người dùng muốn khôi phục mật khẩu.
                    Msg.To.Add(txtEmail.Text.Trim());

                    // Đặt tiêu đề của email.
                    Msg.Subject = "Lấy lại mật khẩu";

                    // Đặt nội dung (body) của email và chèn mật khẩu mới vào nội dung email.
                    Msg.Body = $"Mật khẩu mới của bạn là : {newpass}";

                    using (SmtpClient client = new SmtpClient())
                    {
                        client.EnableSsl = true;
                        client.UseDefaultCredentials = false;
                        client.Credentials = new NetworkCredential("tienphanps28044@gmail.com", "oxap pttt nkmb yvuu");
                        client.Host = "smtp.gmail.com";
                        client.Port = 587;
                        client.DeliveryMethod = SmtpDeliveryMethod.Network;

                        client.Send(Msg);
                    }
                    UIMessageDialog.ShowSuccessDialog(this, $"Đã gửi mật khẩu mới vào địa chỉ email : {txtEmail.Text}");
                }
                catch (Exception ex)
                {
                    // Nếu lỗi là do lỗi khác, hãy hiển thị thông báo lỗi.
                    UIMessageDialog.ShowErrorDialog(this, ex.Message);
                }
            }
        }

        #endregion
        #region Xác thực
        public static bool isEmail(string inputEmail)
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
        public static bool isPhone(string phone)
        {
            string strRegex = @"^0\d{9}$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(phone))
                return (true);
            else
                return (false);
        }
        public string generateNum()
        {
            Random rd = new Random();
            return rd.Next(100000, 999999).ToString();
        }
        private void txtSoDTre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        #endregion
    }
}
