namespace QuanLyBDS.NhanVien
{
    partial class FrmDaduyet
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            btnXem = new Sunny.UI.UIButton();
            dtView = new Sunny.UI.UIDataGridView();
            txtDiachi = new Sunny.UI.UITextBox();
            label7 = new Label();
            btnXoa = new Sunny.UI.UIButton();
            txtHinhanh = new Sunny.UI.UITextBox();
            txtGia = new Sunny.UI.UITextBox();
            txtSophong = new Sunny.UI.UITextBox();
            txtDientich = new Sunny.UI.UITextBox();
            cbLoainha = new Sunny.UI.UIComboBox();
            txtTieude = new Sunny.UI.UITextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label8 = new Label();
            txtId = new Label();
            ((System.ComponentModel.ISupportInitialize)dtView).BeginInit();
            SuspendLayout();
            // 
            // btnXem
            // 
            btnXem.BackColor = SystemColors.ActiveCaption;
            btnXem.FillColor = SystemColors.Highlight;
            btnXem.FillHoverColor = Color.MidnightBlue;
            btnXem.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnXem.Location = new Point(517, 140);
            btnXem.MinimumSize = new Size(1, 1);
            btnXem.Name = "btnXem";
            btnXem.Size = new Size(100, 35);
            btnXem.Style = Sunny.UI.UIStyle.Custom;
            btnXem.TabIndex = 54;
            btnXem.Text = "Xem ảnh";
            btnXem.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            // 
            // dtView
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(243, 249, 255);
            dtView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dtView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtView.BackgroundColor = Color.FromArgb(243, 249, 255);
            dtView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dtView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dtView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(220, 236, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dtView.DefaultCellStyle = dataGridViewCellStyle3;
            dtView.EnableHeadersVisualStyles = false;
            dtView.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtView.GridColor = Color.FromArgb(104, 173, 255);
            dtView.Location = new Point(12, 197);
            dtView.MultiSelect = false;
            dtView.Name = "dtView";
            dtView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(243, 249, 255);
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dtView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(220, 236, 255);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(48, 48, 48);
            dtView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dtView.RowTemplate.Height = 25;
            dtView.ScrollBarRectColor = Color.FromArgb(80, 160, 255);
            dtView.SelectedIndex = -1;
            dtView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtView.Size = new Size(765, 356);
            dtView.Style = Sunny.UI.UIStyle.Custom;
            dtView.TabIndex = 53;
            dtView.Click += dtView_Click;
            // 
            // txtDiachi
            // 
            txtDiachi.Enabled = false;
            txtDiachi.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDiachi.Location = new Point(525, 39);
            txtDiachi.Margin = new Padding(4, 5, 4, 5);
            txtDiachi.MinimumSize = new Size(1, 16);
            txtDiachi.Name = "txtDiachi";
            txtDiachi.Padding = new Padding(5);
            txtDiachi.ShowText = false;
            txtDiachi.Size = new Size(203, 24);
            txtDiachi.Style = Sunny.UI.UIStyle.Custom;
            txtDiachi.TabIndex = 49;
            txtDiachi.TextAlignment = ContentAlignment.MiddleLeft;
            txtDiachi.Watermark = "";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(521, 13);
            label7.Name = "label7";
            label7.Size = new Size(149, 19);
            label7.TabIndex = 48;
            label7.Text = "Địa chỉ bất động sản :";
            // 
            // btnXoa
            // 
            btnXoa.BackColor = SystemColors.ActiveCaption;
            btnXoa.FillColor = SystemColors.Highlight;
            btnXoa.FillHoverColor = Color.MidnightBlue;
            btnXoa.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnXoa.Location = new Point(634, 141);
            btnXoa.MinimumSize = new Size(1, 1);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(100, 35);
            btnXoa.Style = Sunny.UI.UIStyle.Custom;
            btnXoa.TabIndex = 52;
            btnXoa.Text = "Xoá bài";
            btnXoa.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnXoa.Click += btnXoa_Click;
            // 
            // txtHinhanh
            // 
            txtHinhanh.Enabled = false;
            txtHinhanh.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtHinhanh.Location = new Point(525, 99);
            txtHinhanh.Margin = new Padding(4, 5, 4, 5);
            txtHinhanh.MinimumSize = new Size(1, 16);
            txtHinhanh.Name = "txtHinhanh";
            txtHinhanh.Padding = new Padding(5);
            txtHinhanh.ShowText = false;
            txtHinhanh.Size = new Size(203, 24);
            txtHinhanh.Style = Sunny.UI.UIStyle.Custom;
            txtHinhanh.TabIndex = 50;
            txtHinhanh.TextAlignment = ContentAlignment.MiddleLeft;
            txtHinhanh.Watermark = "";
            // 
            // txtGia
            // 
            txtGia.Enabled = false;
            txtGia.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtGia.Location = new Point(135, 152);
            txtGia.Margin = new Padding(4, 5, 4, 5);
            txtGia.MinimumSize = new Size(1, 16);
            txtGia.Name = "txtGia";
            txtGia.Padding = new Padding(5);
            txtGia.ShowText = false;
            txtGia.Size = new Size(203, 24);
            txtGia.Style = Sunny.UI.UIStyle.Custom;
            txtGia.TabIndex = 47;
            txtGia.TextAlignment = ContentAlignment.MiddleLeft;
            txtGia.Watermark = "";
            // 
            // txtSophong
            // 
            txtSophong.Enabled = false;
            txtSophong.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSophong.Location = new Point(135, 117);
            txtSophong.Margin = new Padding(4, 5, 4, 5);
            txtSophong.MinimumSize = new Size(1, 16);
            txtSophong.Name = "txtSophong";
            txtSophong.Padding = new Padding(5);
            txtSophong.ShowText = false;
            txtSophong.Size = new Size(203, 24);
            txtSophong.Style = Sunny.UI.UIStyle.Custom;
            txtSophong.TabIndex = 46;
            txtSophong.TextAlignment = ContentAlignment.MiddleLeft;
            txtSophong.Watermark = "";
            // 
            // txtDientich
            // 
            txtDientich.Enabled = false;
            txtDientich.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDientich.Location = new Point(135, 82);
            txtDientich.Margin = new Padding(4, 5, 4, 5);
            txtDientich.MinimumSize = new Size(1, 16);
            txtDientich.Name = "txtDientich";
            txtDientich.Padding = new Padding(5);
            txtDientich.ShowText = false;
            txtDientich.Size = new Size(203, 24);
            txtDientich.Style = Sunny.UI.UIStyle.Custom;
            txtDientich.TabIndex = 45;
            txtDientich.TextAlignment = ContentAlignment.MiddleLeft;
            txtDientich.Watermark = "";
            // 
            // cbLoainha
            // 
            cbLoainha.DataSource = null;
            cbLoainha.Enabled = false;
            cbLoainha.FillColor = Color.White;
            cbLoainha.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbLoainha.Location = new Point(135, 47);
            cbLoainha.Margin = new Padding(4, 5, 4, 5);
            cbLoainha.MinimumSize = new Size(63, 0);
            cbLoainha.Name = "cbLoainha";
            cbLoainha.Padding = new Padding(0, 0, 30, 2);
            cbLoainha.Size = new Size(203, 24);
            cbLoainha.Style = Sunny.UI.UIStyle.Custom;
            cbLoainha.TabIndex = 44;
            cbLoainha.TextAlignment = ContentAlignment.MiddleLeft;
            cbLoainha.Watermark = "";
            // 
            // txtTieude
            // 
            txtTieude.Enabled = false;
            txtTieude.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTieude.Location = new Point(135, 12);
            txtTieude.Margin = new Padding(4, 5, 4, 5);
            txtTieude.MinimumSize = new Size(1, 16);
            txtTieude.Name = "txtTieude";
            txtTieude.Padding = new Padding(5);
            txtTieude.ShowText = false;
            txtTieude.Size = new Size(203, 24);
            txtTieude.Style = Sunny.UI.UIStyle.Custom;
            txtTieude.TabIndex = 43;
            txtTieude.TextAlignment = ContentAlignment.MiddleLeft;
            txtTieude.Watermark = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(521, 73);
            label6.Name = "label6";
            label6.Size = new Size(75, 19);
            label6.TabIndex = 42;
            label6.Text = "Hình ảnh :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(88, 155);
            label5.Name = "label5";
            label5.Size = new Size(38, 19);
            label5.TabIndex = 41;
            label5.Text = "Giá :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(49, 120);
            label4.Name = "label4";
            label4.Size = new Size(77, 19);
            label4.TabIndex = 40;
            label4.Text = "Số phòng :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(52, 85);
            label3.Name = "label3";
            label3.Size = new Size(74, 19);
            label3.TabIndex = 39;
            label3.Text = "Diện tích :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(53, 50);
            label2.Name = "label2";
            label2.Size = new Size(73, 19);
            label2.TabIndex = 38;
            label2.Text = "Loại nhà :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(61, 15);
            label1.Name = "label1";
            label1.Size = new Size(65, 19);
            label1.TabIndex = 37;
            label1.Text = "Tiêu đề :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.Control;
            label8.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(335, 366);
            label8.Name = "label8";
            label8.Size = new Size(118, 19);
            label8.TabIndex = 56;
            label8.Text = "Không có dữ liệu";
            label8.Visible = false;
            // 
            // txtId
            // 
            txtId.AutoSize = true;
            txtId.Location = new Point(407, 39);
            txtId.Name = "txtId";
            txtId.Size = new Size(55, 16);
            txtId.TabIndex = 57;
            txtId.Text = "label8";
            txtId.Visible = false;
            // 
            // FrmDaduyet
            // 
            AllowShowTitle = false;
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(789, 565);
            Controls.Add(txtId);
            Controls.Add(label8);
            Controls.Add(btnXem);
            Controls.Add(dtView);
            Controls.Add(txtDiachi);
            Controls.Add(label7);
            Controls.Add(btnXoa);
            Controls.Add(txtHinhanh);
            Controls.Add(txtGia);
            Controls.Add(txtSophong);
            Controls.Add(txtDientich);
            Controls.Add(cbLoainha);
            Controls.Add(txtTieude);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmDaduyet";
            Padding = new Padding(0);
            ShowTitle = false;
            Style = Sunny.UI.UIStyle.Custom;
            Text = "FrmDaduyet";
            ZoomScaleRect = new Rectangle(15, 15, 800, 450);
            Load += FrmDaduyet_Load;
            ((System.ComponentModel.ISupportInitialize)dtView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Sunny.UI.UIButton btnXem;
        private Sunny.UI.UIDataGridView dtView;
        private Sunny.UI.UITextBox txtDiachi;
        private Label label7;
        private Sunny.UI.UIButton btnXoa;
        private Sunny.UI.UITextBox txtHinhanh;
        private Sunny.UI.UITextBox txtGia;
        private Sunny.UI.UITextBox txtSophong;
        private Sunny.UI.UITextBox txtDientich;
        private Sunny.UI.UIComboBox cbLoainha;
        private Sunny.UI.UITextBox txtTieude;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label8;
        private Label txtId;
    }
}