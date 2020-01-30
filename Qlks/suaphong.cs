using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Qlks
{
    public partial class suaphong : Form
    {
        public suaphong()
        {
            InitializeComponent();
        }
        CauLenh cl = new CauLenh();
        DataTable dt = new DataTable();
        public void suaphong_load()
        {
             dt = cl.loaiphong1(0);
            cb_lp.DataSource = dt;
            cb_lp.DisplayMember = "LoaiPhong";
        }
        private void suaphong_Load(object sender, EventArgs e)
        {

           suaphong_load();
        }

        private void bt_luu_Click(object sender, EventArgs e)
        {
           
            if (!string.IsNullOrEmpty(txt_mp.Text))
            {
                if (!string.IsNullOrEmpty(txt_giaphong.Text))
                {
                    string lp = cb_lp.Text;
                    dt.Clear();
                    dt = cl.suaphong(Convert.ToInt32(txt_mp.Text), Convert.ToInt32(txt_giaphong.Text), lp);
                    if (dt.Rows[0]["errcode"].ToString() == "0")
                    {
                        MessageBox.Show("Đã Lưu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        suaphong_load();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txt_mp.Focus();
                        suaphong_load();
                    }
                }
                else
                {
                    MessageBox.Show("Nhập Giá Phòng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_giaphong.Focus();
                }
            }
            else
            {
                MessageBox.Show("Nhập Mã Phòng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_mp.Focus();
            }
        }

        private void bt_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
