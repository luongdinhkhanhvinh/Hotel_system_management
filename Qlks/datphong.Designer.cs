namespace Qlks
{
    partial class datphong
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
            this.bt_luu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rd_dp = new System.Windows.Forms.RadioButton();
            this.txt_ten = new System.Windows.Forms.TextBox();
            this.dt_ngay = new System.Windows.Forms.DateTimePicker();
            this.lb_mp = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rd_huy = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.bt_thoat = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_luu
            // 
            this.bt_luu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_luu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_luu.Location = new System.Drawing.Point(87, 240);
            this.bt_luu.Name = "bt_luu";
            this.bt_luu.Size = new System.Drawing.Size(75, 30);
            this.bt_luu.TabIndex = 0;
            this.bt_luu.Text = "Lưu";
            this.bt_luu.UseVisualStyleBackColor = false;
            this.bt_luu.Click += new System.EventHandler(this.bt_luu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(109, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Đặt Phòng: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // rd_dp
            // 
            this.rd_dp.AutoSize = true;
            this.rd_dp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_dp.ForeColor = System.Drawing.Color.Black;
            this.rd_dp.Location = new System.Drawing.Point(102, 63);
            this.rd_dp.Name = "rd_dp";
            this.rd_dp.Size = new System.Drawing.Size(102, 21);
            this.rd_dp.TabIndex = 2;
            this.rd_dp.TabStop = true;
            this.rd_dp.Text = "Đặt Phòng";
            this.rd_dp.UseVisualStyleBackColor = true;
            this.rd_dp.CheckedChanged += new System.EventHandler(this.rd_dp_CheckedChanged);
            // 
            // txt_ten
            // 
            this.txt_ten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ten.Location = new System.Drawing.Point(163, 102);
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.Size = new System.Drawing.Size(200, 23);
            this.txt_ten.TabIndex = 3;
            this.txt_ten.TextChanged += new System.EventHandler(this.txt_ten_TextChanged);
            // 
            // dt_ngay
            // 
            this.dt_ngay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_ngay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_ngay.Location = new System.Drawing.Point(163, 188);
            this.dt_ngay.Name = "dt_ngay";
            this.dt_ngay.Size = new System.Drawing.Size(200, 23);
            this.dt_ngay.TabIndex = 4;
            this.dt_ngay.ValueChanged += new System.EventHandler(this.dt_ngay_ValueChanged);
            // 
            // lb_mp
            // 
            this.lb_mp.AutoSize = true;
            this.lb_mp.BackColor = System.Drawing.Color.White;
            this.lb_mp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_mp.Location = new System.Drawing.Point(241, 12);
            this.lb_mp.Name = "lb_mp";
            this.lb_mp.Size = new System.Drawing.Size(61, 25);
            this.lb_mp.TabIndex = 5;
            this.lb_mp.Text = "trống";
            this.lb_mp.Click += new System.EventHandler(this.lb_mp_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(24, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tên Khách Hàng";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(24, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ngày Đặt";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // rd_huy
            // 
            this.rd_huy.AutoSize = true;
            this.rd_huy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_huy.ForeColor = System.Drawing.Color.Black;
            this.rd_huy.Location = new System.Drawing.Point(228, 63);
            this.rd_huy.Name = "rd_huy";
            this.rd_huy.Size = new System.Drawing.Size(135, 21);
            this.rd_huy.TabIndex = 9;
            this.rd_huy.TabStop = true;
            this.rd_huy.Text = "Hủy Đặt Phòng";
            this.rd_huy.UseVisualStyleBackColor = true;
            this.rd_huy.CheckedChanged += new System.EventHandler(this.rd_huy_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(24, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Số Điện Thoại";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txt_sdt
            // 
            this.txt_sdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sdt.Location = new System.Drawing.Point(163, 144);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(200, 23);
            this.txt_sdt.TabIndex = 10;
            this.txt_sdt.TextChanged += new System.EventHandler(this.txt_sdt_TextChanged);
            // 
            // bt_thoat
            // 
            this.bt_thoat.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_thoat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_thoat.Location = new System.Drawing.Point(241, 240);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(75, 30);
            this.bt_thoat.TabIndex = 12;
            this.bt_thoat.Text = "Thoát";
            this.bt_thoat.UseVisualStyleBackColor = false;
            this.bt_thoat.Click += new System.EventHandler(this.bt_thoat_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.MintCream;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lb_mp);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(414, 58);
            this.panel1.TabIndex = 13;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // datphong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(412, 292);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bt_thoat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_sdt);
            this.Controls.Add(this.rd_huy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dt_ngay);
            this.Controls.Add(this.txt_ten);
            this.Controls.Add(this.rd_dp);
            this.Controls.Add(this.bt_luu);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "datphong";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "datphong";
            this.Load += new System.EventHandler(this.datphong_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_luu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rd_dp;
        private System.Windows.Forms.TextBox txt_ten;
        private System.Windows.Forms.DateTimePicker dt_ngay;
        private System.Windows.Forms.Label lb_mp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rd_huy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.Button bt_thoat;
        private System.Windows.Forms.Panel panel1;
    }
}