namespace Qlks
{
    partial class Txphong
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
            this.rd_xoa = new System.Windows.Forms.RadioButton();
            this.cb_mp = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.rd_them = new System.Windows.Forms.RadioButton();
            this.bt_them = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_mpa = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rd_xoa
            // 
            this.rd_xoa.AutoSize = true;
            this.rd_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_xoa.ForeColor = System.Drawing.Color.Black;
            this.rd_xoa.Location = new System.Drawing.Point(13, 58);
            this.rd_xoa.Margin = new System.Windows.Forms.Padding(4);
            this.rd_xoa.Name = "rd_xoa";
            this.rd_xoa.Size = new System.Drawing.Size(105, 21);
            this.rd_xoa.TabIndex = 0;
            this.rd_xoa.Text = "Xóa Phòng";
            this.rd_xoa.UseVisualStyleBackColor = true;
            this.rd_xoa.CheckedChanged += new System.EventHandler(this.rd_xoa_CheckedChanged);
            // 
            // cb_mp
            // 
            this.cb_mp.FormattingEnabled = true;
            this.cb_mp.Location = new System.Drawing.Point(298, 55);
            this.cb_mp.Margin = new System.Windows.Forms.Padding(4);
            this.cb_mp.Name = "cb_mp";
            this.cb_mp.Size = new System.Drawing.Size(180, 24);
            this.cb_mp.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(144, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Danh sách phòng";
            // 
            // bt_xoa
            // 
            this.bt_xoa.BackColor = System.Drawing.Color.MintCream;
            this.bt_xoa.ForeColor = System.Drawing.Color.Black;
            this.bt_xoa.Location = new System.Drawing.Point(512, 53);
            this.bt_xoa.Margin = new System.Windows.Forms.Padding(4);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(112, 30);
            this.bt_xoa.TabIndex = 3;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = false;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // rd_them
            // 
            this.rd_them.AutoSize = true;
            this.rd_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_them.ForeColor = System.Drawing.Color.Black;
            this.rd_them.Location = new System.Drawing.Point(13, 99);
            this.rd_them.Margin = new System.Windows.Forms.Padding(4);
            this.rd_them.Name = "rd_them";
            this.rd_them.Size = new System.Drawing.Size(117, 21);
            this.rd_them.TabIndex = 4;
            this.rd_them.Text = "Thêm Phòng";
            this.rd_them.UseVisualStyleBackColor = true;
            this.rd_them.CheckedChanged += new System.EventHandler(this.rd_them_CheckedChanged);
            // 
            // bt_them
            // 
            this.bt_them.BackColor = System.Drawing.Color.MintCream;
            this.bt_them.ForeColor = System.Drawing.Color.Black;
            this.bt_them.Location = new System.Drawing.Point(512, 94);
            this.bt_them.Margin = new System.Windows.Forms.Padding(4);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(112, 30);
            this.bt_them.TabIndex = 7;
            this.bt_them.Text = "Thêm";
            this.bt_them.UseVisualStyleBackColor = false;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(144, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Danh sách phòng";
            // 
            // cb_mpa
            // 
            this.cb_mpa.FormattingEnabled = true;
            this.cb_mpa.Location = new System.Drawing.Point(298, 96);
            this.cb_mpa.Margin = new System.Windows.Forms.Padding(4);
            this.cb_mpa.Name = "cb_mpa";
            this.cb_mpa.Size = new System.Drawing.Size(180, 24);
            this.cb_mpa.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(267, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Sửa Phòng";
            // 
            // Txphong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 146);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bt_them);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_mpa);
            this.Controls.Add(this.rd_them);
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_mp);
            this.Controls.Add(this.rd_xoa);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkCyan;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(660, 185);
            this.MinimumSize = new System.Drawing.Size(660, 185);
            this.Name = "Txphong";
            this.Text = "Thêm Xóa Phòng";
            this.Load += new System.EventHandler(this.Txphong_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rd_xoa;
        private System.Windows.Forms.ComboBox cb_mp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.RadioButton rd_them;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_mpa;
        private System.Windows.Forms.Label label3;
    }
}