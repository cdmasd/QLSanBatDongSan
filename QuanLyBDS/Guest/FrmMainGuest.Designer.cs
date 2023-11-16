namespace QuanLyBDS.Guest
{
    partial class FrmMainGuest
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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            dtView = new Sunny.UI.UIDataGridView();
            cbLoainha = new Sunny.UI.UIComboBox();
            cbDientich = new Sunny.UI.UIComboBox();
            cbSophong = new Sunny.UI.UIComboBox();
            cbGia = new Sunny.UI.UIComboBox();
            cbDiachi = new Sunny.UI.UIComboBox();
            label1 = new Label();
            label2 = new Label();
            txtHoten = new Label();
            label3 = new Label();
            txtEmail = new Label();
            label5 = new Label();
            txtSodt = new Label();
            panelGuest = new Panel();
            btnTimkiem = new Sunny.UI.UIButton();
            btnXemanh = new Sunny.UI.UIButton();
            ((System.ComponentModel.ISupportInitialize)dtView).BeginInit();
            panelGuest.SuspendLayout();
            SuspendLayout();
            // 
            // dtView
            // 
            dtView.AllowUserToAddRows = false;
            dtView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(243, 249, 255);
            dtView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dtView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtView.BackgroundColor = Color.FromArgb(243, 249, 255);
            dtView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dtView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dtView.ColumnHeadersHeight = 32;
            dtView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(220, 236, 255);
            dataGridViewCellStyle8.SelectionForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dtView.DefaultCellStyle = dataGridViewCellStyle8;
            dtView.EnableHeadersVisualStyles = false;
            dtView.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtView.GridColor = Color.FromArgb(104, 173, 255);
            dtView.Location = new Point(12, 153);
            dtView.MultiSelect = false;
            dtView.Name = "dtView";
            dtView.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(243, 249, 255);
            dataGridViewCellStyle9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle9.SelectionForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dtView.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.BackColor = Color.White;
            dataGridViewCellStyle10.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(220, 236, 255);
            dataGridViewCellStyle10.SelectionForeColor = Color.FromArgb(48, 48, 48);
            dtView.RowsDefaultCellStyle = dataGridViewCellStyle10;
            dtView.RowTemplate.Height = 25;
            dtView.ScrollBarRectColor = Color.FromArgb(80, 160, 255);
            dtView.SelectedIndex = -1;
            dtView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtView.Size = new Size(667, 400);
            dtView.TabIndex = 45;
            // 
            // cbLoainha
            // 
            cbLoainha.DataSource = null;
            cbLoainha.FillColor = Color.White;
            cbLoainha.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbLoainha.Location = new Point(26, 44);
            cbLoainha.Margin = new Padding(4, 5, 4, 5);
            cbLoainha.MinimumSize = new Size(63, 0);
            cbLoainha.Name = "cbLoainha";
            cbLoainha.Padding = new Padding(0, 0, 30, 2);
            cbLoainha.Size = new Size(150, 29);
            cbLoainha.TabIndex = 46;
            cbLoainha.Text = "Loại Nhà";
            cbLoainha.TextAlignment = ContentAlignment.MiddleLeft;
            cbLoainha.Watermark = "";
            // 
            // cbDientich
            // 
            cbDientich.DataSource = null;
            cbDientich.FillColor = Color.White;
            cbDientich.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbDientich.Location = new Point(277, 44);
            cbDientich.Margin = new Padding(4, 5, 4, 5);
            cbDientich.MinimumSize = new Size(63, 0);
            cbDientich.Name = "cbDientich";
            cbDientich.Padding = new Padding(0, 0, 30, 2);
            cbDientich.Size = new Size(150, 29);
            cbDientich.TabIndex = 47;
            cbDientich.Text = "Diện tích";
            cbDientich.TextAlignment = ContentAlignment.MiddleLeft;
            cbDientich.Watermark = "";
            // 
            // cbSophong
            // 
            cbSophong.DataSource = null;
            cbSophong.FillColor = Color.White;
            cbSophong.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbSophong.Location = new Point(528, 44);
            cbSophong.Margin = new Padding(4, 5, 4, 5);
            cbSophong.MinimumSize = new Size(63, 0);
            cbSophong.Name = "cbSophong";
            cbSophong.Padding = new Padding(0, 0, 30, 2);
            cbSophong.Size = new Size(150, 29);
            cbSophong.TabIndex = 48;
            cbSophong.Text = "Số phòng";
            cbSophong.TextAlignment = ContentAlignment.MiddleLeft;
            cbSophong.Watermark = "";
            // 
            // cbGia
            // 
            cbGia.DataSource = null;
            cbGia.FillColor = Color.White;
            cbGia.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbGia.Location = new Point(277, 98);
            cbGia.Margin = new Padding(4, 5, 4, 5);
            cbGia.MinimumSize = new Size(63, 0);
            cbGia.Name = "cbGia";
            cbGia.Padding = new Padding(0, 0, 30, 2);
            cbGia.Size = new Size(150, 29);
            cbGia.TabIndex = 49;
            cbGia.Text = "Khoảng giá";
            cbGia.TextAlignment = ContentAlignment.MiddleLeft;
            cbGia.Watermark = "";
            // 
            // cbDiachi
            // 
            cbDiachi.DataSource = null;
            cbDiachi.FillColor = Color.White;
            cbDiachi.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbDiachi.Location = new Point(26, 98);
            cbDiachi.Margin = new Padding(4, 5, 4, 5);
            cbDiachi.MinimumSize = new Size(63, 0);
            cbDiachi.Name = "cbDiachi";
            cbDiachi.Padding = new Padding(0, 0, 30, 2);
            cbDiachi.Size = new Size(150, 29);
            cbDiachi.TabIndex = 50;
            cbDiachi.Text = "Địa chỉ";
            cbDiachi.TextAlignment = ContentAlignment.MiddleLeft;
            cbDiachi.Watermark = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto Condensed", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(724, 153);
            label1.Name = "label1";
            label1.Size = new Size(132, 23);
            label1.TabIndex = 51;
            label1.Text = "Thông tin liên hệ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(11, 39);
            label2.Name = "label2";
            label2.Size = new Size(79, 19);
            label2.TabIndex = 0;
            label2.Text = "Họ và tên :";
            // 
            // txtHoten
            // 
            txtHoten.AutoSize = true;
            txtHoten.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtHoten.Location = new Point(11, 64);
            txtHoten.Name = "txtHoten";
            txtHoten.Size = new Size(127, 19);
            txtHoten.TabIndex = 1;
            txtHoten.Text = "Bấm vào dataview";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(11, 111);
            label3.Name = "label3";
            label3.Size = new Size(53, 19);
            label3.TabIndex = 2;
            label3.Text = "Email :";
            // 
            // txtEmail
            // 
            txtEmail.AutoSize = true;
            txtEmail.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(11, 136);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(127, 19);
            txtEmail.TabIndex = 3;
            txtEmail.Text = "Bấm vào dataview";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(11, 183);
            label5.Name = "label5";
            label5.Size = new Size(102, 19);
            label5.TabIndex = 4;
            label5.Text = "Số điện thoại :";
            // 
            // txtSodt
            // 
            txtSodt.AutoSize = true;
            txtSodt.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSodt.Location = new Point(11, 208);
            txtSodt.Name = "txtSodt";
            txtSodt.Size = new Size(127, 19);
            txtSodt.TabIndex = 5;
            txtSodt.Text = "Bấm vào dataview";
            // 
            // panelGuest
            // 
            panelGuest.BorderStyle = BorderStyle.FixedSingle;
            panelGuest.Controls.Add(txtSodt);
            panelGuest.Controls.Add(label5);
            panelGuest.Controls.Add(txtEmail);
            panelGuest.Controls.Add(label3);
            panelGuest.Controls.Add(txtHoten);
            panelGuest.Controls.Add(label2);
            panelGuest.Location = new Point(689, 188);
            panelGuest.Name = "panelGuest";
            panelGuest.Size = new Size(203, 268);
            panelGuest.TabIndex = 52;
            panelGuest.Visible = false;
            // 
            // btnTimkiem
            // 
            btnTimkiem.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnTimkiem.Location = new Point(550, 92);
            btnTimkiem.MinimumSize = new Size(1, 1);
            btnTimkiem.Name = "btnTimkiem";
            btnTimkiem.Size = new Size(100, 35);
            btnTimkiem.TabIndex = 53;
            btnTimkiem.Text = "Tìm kiếm";
            btnTimkiem.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnTimkiem.Click += btnTimkiem_Click;
            // 
            // btnXemanh
            // 
            btnXemanh.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnXemanh.Location = new Point(743, 479);
            btnXemanh.MinimumSize = new Size(1, 1);
            btnXemanh.Name = "btnXemanh";
            btnXemanh.Size = new Size(100, 35);
            btnXemanh.TabIndex = 54;
            btnXemanh.Text = "Xem ảnh";
            btnXemanh.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnXemanh.Click += btnXemanh_Click;
            // 
            // FrmMainGuest
            // 
            AllowShowTitle = false;
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(900, 565);
            Controls.Add(btnXemanh);
            Controls.Add(btnTimkiem);
            Controls.Add(panelGuest);
            Controls.Add(label1);
            Controls.Add(cbDiachi);
            Controls.Add(cbGia);
            Controls.Add(cbSophong);
            Controls.Add(cbDientich);
            Controls.Add(cbLoainha);
            Controls.Add(dtView);
            Name = "FrmMainGuest";
            Padding = new Padding(0);
            ShowTitle = false;
            Text = "";
            ZoomScaleRect = new Rectangle(15, 15, 800, 450);
            ((System.ComponentModel.ISupportInitialize)dtView).EndInit();
            panelGuest.ResumeLayout(false);
            panelGuest.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Sunny.UI.UIDataGridView dtView;
        private Sunny.UI.UIComboBox cbLoainha;
        private Sunny.UI.UIComboBox cbDientich;
        private Sunny.UI.UIComboBox cbSophong;
        private Sunny.UI.UIComboBox cbGia;
        private Sunny.UI.UIComboBox cbDiachi;
        private Label label1;
        private Label label2;
        private Label txtHoten;
        private Label label3;
        private Label txtEmail;
        private Label label5;
        private Label txtSodt;
        private Panel panelGuest;
        private Sunny.UI.UIButton btnTimkiem;
        private Sunny.UI.UIButton btnXemanh;
    }
}