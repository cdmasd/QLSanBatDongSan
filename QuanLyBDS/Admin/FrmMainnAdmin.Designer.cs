namespace QuanLyBDS.Admin
{
    partial class FrmMainnAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainnAdmin));
            panelAdmin = new Panel();
            panel1 = new Panel();
            btnDangxuat = new Button();
            btnDoimatkhau = new Button();
            btnThongke = new Button();
            btnHotro = new Button();
            btnDaduyet = new Button();
            btnDuyetbai = new Button();
            btnKhachhang = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            btnNhanvien = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelAdmin
            // 
            panelAdmin.BackColor = SystemColors.ActiveCaption;
            panelAdmin.Dock = DockStyle.Right;
            panelAdmin.Location = new Point(196, 0);
            panelAdmin.Name = "panelAdmin";
            panelAdmin.Size = new Size(704, 565);
            panelAdmin.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(btnDangxuat);
            panel1.Controls.Add(btnDoimatkhau);
            panel1.Controls.Add(btnThongke);
            panel1.Controls.Add(btnHotro);
            panel1.Controls.Add(btnDaduyet);
            panel1.Controls.Add(btnDuyetbai);
            panel1.Controls.Add(btnKhachhang);
            panel1.Controls.Add(btnNhanvien);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(196, 565);
            panel1.TabIndex = 5;
            // 
            // btnDangxuat
            // 
            btnDangxuat.Dock = DockStyle.Top;
            btnDangxuat.FlatAppearance.BorderSize = 0;
            btnDangxuat.FlatStyle = FlatStyle.Flat;
            btnDangxuat.Font = new Font("Roboto Condensed", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnDangxuat.ForeColor = SystemColors.Control;
            btnDangxuat.Image = (Image)resources.GetObject("btnDangxuat.Image");
            btnDangxuat.Location = new Point(0, 419);
            btnDangxuat.Name = "btnDangxuat";
            btnDangxuat.Size = new Size(196, 42);
            btnDangxuat.TabIndex = 8;
            btnDangxuat.Text = "Đăng xuất";
            btnDangxuat.TextAlign = ContentAlignment.MiddleRight;
            btnDangxuat.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnDangxuat.UseVisualStyleBackColor = true;
            btnDangxuat.Click += btnDangxuat_Click;
            // 
            // btnDoimatkhau
            // 
            btnDoimatkhau.Dock = DockStyle.Top;
            btnDoimatkhau.FlatAppearance.BorderSize = 0;
            btnDoimatkhau.FlatStyle = FlatStyle.Flat;
            btnDoimatkhau.Font = new Font("Roboto Condensed", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnDoimatkhau.ForeColor = SystemColors.Control;
            btnDoimatkhau.Image = (Image)resources.GetObject("btnDoimatkhau.Image");
            btnDoimatkhau.Location = new Point(0, 377);
            btnDoimatkhau.Name = "btnDoimatkhau";
            btnDoimatkhau.Size = new Size(196, 42);
            btnDoimatkhau.TabIndex = 7;
            btnDoimatkhau.Text = "Đổi mật khẩu";
            btnDoimatkhau.TextAlign = ContentAlignment.MiddleRight;
            btnDoimatkhau.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnDoimatkhau.UseVisualStyleBackColor = true;
            btnDoimatkhau.Click += btnDoimatkhau_Click;
            // 
            // btnThongke
            // 
            btnThongke.Dock = DockStyle.Top;
            btnThongke.FlatAppearance.BorderSize = 0;
            btnThongke.FlatStyle = FlatStyle.Flat;
            btnThongke.Font = new Font("Roboto Condensed", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnThongke.ForeColor = SystemColors.Control;
            btnThongke.Image = (Image)resources.GetObject("btnThongke.Image");
            btnThongke.Location = new Point(0, 335);
            btnThongke.Name = "btnThongke";
            btnThongke.Size = new Size(196, 42);
            btnThongke.TabIndex = 6;
            btnThongke.Text = "Thống kê";
            btnThongke.TextAlign = ContentAlignment.MiddleRight;
            btnThongke.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnThongke.UseVisualStyleBackColor = true;
            btnThongke.Click += btnThongke_Click;
            // 
            // btnHotro
            // 
            btnHotro.Dock = DockStyle.Top;
            btnHotro.FlatAppearance.BorderSize = 0;
            btnHotro.FlatStyle = FlatStyle.Flat;
            btnHotro.Font = new Font("Roboto Condensed", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnHotro.ForeColor = SystemColors.Control;
            btnHotro.Image = (Image)resources.GetObject("btnHotro.Image");
            btnHotro.Location = new Point(0, 293);
            btnHotro.Name = "btnHotro";
            btnHotro.Size = new Size(196, 42);
            btnHotro.TabIndex = 5;
            btnHotro.Text = "Hỗ trợ";
            btnHotro.TextAlign = ContentAlignment.MiddleRight;
            btnHotro.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnHotro.UseVisualStyleBackColor = true;
            btnHotro.Click += btnHotro_Click;
            // 
            // btnDaduyet
            // 
            btnDaduyet.Dock = DockStyle.Top;
            btnDaduyet.FlatAppearance.BorderSize = 0;
            btnDaduyet.FlatStyle = FlatStyle.Flat;
            btnDaduyet.Font = new Font("Roboto Condensed", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnDaduyet.ForeColor = SystemColors.Control;
            btnDaduyet.Image = (Image)resources.GetObject("btnDaduyet.Image");
            btnDaduyet.Location = new Point(0, 251);
            btnDaduyet.Name = "btnDaduyet";
            btnDaduyet.Size = new Size(196, 42);
            btnDaduyet.TabIndex = 4;
            btnDaduyet.Text = "Đã duyệt";
            btnDaduyet.TextAlign = ContentAlignment.MiddleRight;
            btnDaduyet.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnDaduyet.UseVisualStyleBackColor = true;
            btnDaduyet.Click += btnDaduyet_Click;
            // 
            // btnDuyetbai
            // 
            btnDuyetbai.Dock = DockStyle.Top;
            btnDuyetbai.FlatAppearance.BorderSize = 0;
            btnDuyetbai.FlatStyle = FlatStyle.Flat;
            btnDuyetbai.Font = new Font("Roboto Condensed", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnDuyetbai.ForeColor = SystemColors.Control;
            btnDuyetbai.Image = (Image)resources.GetObject("btnDuyetbai.Image");
            btnDuyetbai.Location = new Point(0, 209);
            btnDuyetbai.Name = "btnDuyetbai";
            btnDuyetbai.Size = new Size(196, 42);
            btnDuyetbai.TabIndex = 3;
            btnDuyetbai.Text = "Duyệt bài";
            btnDuyetbai.TextAlign = ContentAlignment.MiddleRight;
            btnDuyetbai.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnDuyetbai.UseVisualStyleBackColor = true;
            btnDuyetbai.Click += btnDuyetbai_Click;
            // 
            // btnKhachhang
            // 
            btnKhachhang.Dock = DockStyle.Top;
            btnKhachhang.FlatAppearance.BorderSize = 0;
            btnKhachhang.FlatStyle = FlatStyle.Flat;
            btnKhachhang.Font = new Font("Roboto Condensed", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnKhachhang.ForeColor = SystemColors.Control;
            btnKhachhang.Image = (Image)resources.GetObject("btnKhachhang.Image");
            btnKhachhang.Location = new Point(0, 167);
            btnKhachhang.Name = "btnKhachhang";
            btnKhachhang.Size = new Size(196, 42);
            btnKhachhang.TabIndex = 2;
            btnKhachhang.Text = "Khách hàng";
            btnKhachhang.TextAlign = ContentAlignment.MiddleRight;
            btnKhachhang.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnKhachhang.UseVisualStyleBackColor = true;
            btnKhachhang.Click += btnKhachhang_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(196, 125);
            panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.avatardefault_92824;
            pictureBox1.Location = new Point(33, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(131, 103);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnNhanvien
            // 
            btnNhanvien.Dock = DockStyle.Top;
            btnNhanvien.FlatAppearance.BorderSize = 0;
            btnNhanvien.FlatStyle = FlatStyle.Flat;
            btnNhanvien.Font = new Font("Roboto Condensed", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnNhanvien.ForeColor = SystemColors.Control;
            btnNhanvien.Image = Properties.Resources.employee_white;
            btnNhanvien.Location = new Point(0, 125);
            btnNhanvien.Name = "btnNhanvien";
            btnNhanvien.Size = new Size(196, 42);
            btnNhanvien.TabIndex = 1;
            btnNhanvien.Text = "Nhân viên";
            btnNhanvien.TextAlign = ContentAlignment.MiddleRight;
            btnNhanvien.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnNhanvien.UseVisualStyleBackColor = true;
            btnNhanvien.Click += btnNhanvien_Click;
            // 
            // FrmMainnAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(900, 565);
            Controls.Add(panel1);
            Controls.Add(panelAdmin);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmMainnAdmin";
            Text = "FrmMainnAdmin";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelAdmin;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button btnThongke;
        private Button btnHotro;
        private Button btnDaduyet;
        private Button btnDuyetbai;
        private Button btnKhachhang;
        private Button btnDoimatkhau;
        private Button btnDangxuat;
        private Button btnNhanvien;
    }
}