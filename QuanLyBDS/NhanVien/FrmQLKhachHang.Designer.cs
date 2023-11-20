namespace QuanLyBDS.NhanVien
{
    partial class FrmQLKhachHang
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
            btnNap = new Sunny.UI.UIButton();
            txtSodu = new Sunny.UI.UITextBox();
            txtSdt = new Sunny.UI.UITextBox();
            txtEmail = new Sunny.UI.UITextBox();
            txtHoten = new Sunny.UI.UITextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtNap = new Sunny.UI.UITextBox();
            btnXoa = new Sunny.UI.UIButton();
            dtView = new Sunny.UI.UIDataGridView();
            ((System.ComponentModel.ISupportInitialize)dtView).BeginInit();
            SuspendLayout();
            // 
            // btnNap
            // 
            btnNap.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnNap.Location = new Point(562, 70);
            btnNap.MinimumSize = new Size(1, 1);
            btnNap.Name = "btnNap";
            btnNap.Size = new Size(85, 24);
            btnNap.TabIndex = 26;
            btnNap.Text = "Nạp";
            btnNap.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            // 
            // txtSodu
            // 
            txtSodu.Enabled = false;
            txtSodu.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSodu.Location = new Point(276, 104);
            txtSodu.Margin = new Padding(4, 5, 4, 5);
            txtSodu.MinimumSize = new Size(1, 16);
            txtSodu.Name = "txtSodu";
            txtSodu.Padding = new Padding(5);
            txtSodu.ShowText = false;
            txtSodu.Size = new Size(203, 27);
            txtSodu.TabIndex = 23;
            txtSodu.TextAlignment = ContentAlignment.MiddleLeft;
            txtSodu.Watermark = "";
            // 
            // txtSdt
            // 
            txtSdt.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSdt.Location = new Point(276, 47);
            txtSdt.Margin = new Padding(4, 5, 4, 5);
            txtSdt.MinimumSize = new Size(1, 16);
            txtSdt.Name = "txtSdt";
            txtSdt.Padding = new Padding(5);
            txtSdt.ShowText = false;
            txtSdt.Size = new Size(203, 27);
            txtSdt.TabIndex = 24;
            txtSdt.TextAlignment = ContentAlignment.MiddleLeft;
            txtSdt.Watermark = "";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(32, 104);
            txtEmail.Margin = new Padding(4, 5, 4, 5);
            txtEmail.MinimumSize = new Size(1, 16);
            txtEmail.Name = "txtEmail";
            txtEmail.Padding = new Padding(5);
            txtEmail.ShowText = false;
            txtEmail.Size = new Size(203, 27);
            txtEmail.TabIndex = 25;
            txtEmail.TextAlignment = ContentAlignment.MiddleLeft;
            txtEmail.Watermark = "";
            // 
            // txtHoten
            // 
            txtHoten.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtHoten.Location = new Point(32, 47);
            txtHoten.Margin = new Padding(4, 5, 4, 5);
            txtHoten.MinimumSize = new Size(1, 16);
            txtHoten.Name = "txtHoten";
            txtHoten.Padding = new Padding(5);
            txtHoten.ShowText = false;
            txtHoten.Size = new Size(203, 27);
            txtHoten.TabIndex = 22;
            txtHoten.TextAlignment = ContentAlignment.MiddleLeft;
            txtHoten.Watermark = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(276, 80);
            label4.Name = "label4";
            label4.Size = new Size(75, 25);
            label4.TabIndex = 21;
            label4.Text = "Số dư :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(276, 23);
            label3.Name = "label3";
            label3.Size = new Size(137, 25);
            label3.TabIndex = 20;
            label3.Text = "Số điện thoại :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(32, 80);
            label2.Name = "label2";
            label2.Size = new Size(71, 25);
            label2.TabIndex = 19;
            label2.Text = "Email :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(32, 23);
            label1.Name = "label1";
            label1.Size = new Size(80, 25);
            label1.TabIndex = 18;
            label1.Text = "Họ tên :";
            // 
            // txtNap
            // 
            txtNap.Enabled = false;
            txtNap.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNap.Location = new Point(536, 38);
            txtNap.Margin = new Padding(4, 5, 4, 5);
            txtNap.MinimumSize = new Size(1, 16);
            txtNap.Name = "txtNap";
            txtNap.Padding = new Padding(5);
            txtNap.ShowText = false;
            txtNap.Size = new Size(135, 27);
            txtNap.TabIndex = 24;
            txtNap.TextAlignment = ContentAlignment.MiddleLeft;
            txtNap.Watermark = "Nhập số tiền nạp";
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnXoa.Location = new Point(544, 100);
            btnXoa.MinimumSize = new Size(1, 1);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(124, 28);
            btnXoa.TabIndex = 27;
            btnXoa.Text = "Xoá khách hàng";
            btnXoa.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnXoa.Click += btnXoa_Click;
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
            dtView.Location = new Point(12, 155);
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
            dtView.RowHeadersWidth = 51;
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
            dtView.Size = new Size(698, 398);
            dtView.TabIndex = 28;
            dtView.CellContentClick += dtView_CellContentClick;
            // 
            // FrmQLKhachHang
            // 
            AllowShowTitle = false;
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(722, 565);
            Controls.Add(dtView);
            Controls.Add(btnXoa);
            Controls.Add(txtNap);
            Controls.Add(btnNap);
            Controls.Add(txtSodu);
            Controls.Add(txtSdt);
            Controls.Add(txtEmail);
            Controls.Add(txtHoten);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmQLKhachHang";
            Padding = new Padding(0);
            ShowTitle = false;
            Text = "FrmQLKhachHang";
            ZoomScaleRect = new Rectangle(15, 15, 800, 450);
            Load += FrmQLKhachHang_Load;
            ((System.ComponentModel.ISupportInitialize)dtView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Sunny.UI.UIButton btnNap;
        private Sunny.UI.UITextBox txtSodu;
        private Sunny.UI.UITextBox txtSdt;
        private Sunny.UI.UITextBox txtEmail;
        private Sunny.UI.UITextBox txtHoten;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Sunny.UI.UITextBox txtNap;
        private Sunny.UI.UIButton btnXoa;
        private Sunny.UI.UIDataGridView dtView;
    }
}