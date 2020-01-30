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
    public partial class datphong : Form
    {
        public datphong()
        {
            InitializeComponent();
        }
        public static int mp;
        CauLenh cl = new CauLenh();
        DataTable dt = new DataTable();
        SqlDataReader dr;
        private void load()
        {
            dr = cl.loaddp(mp);
            while(dr.Read())
            {
                if(dr.GetString(0) == "Đặt Phòng")
                {
                    rd_dp.Checked = true;
                    txt_ten.Text = dr.GetString(1).ToString();
                    dt_ngay.Text = dr.GetDateTime(2).ToString();
                    txt_sdt.Text = dr.GetString(3).ToString();
                }
                else
                {
                    rd_huy.Checked = true;
                }
            }
        }
        private void datphong_Load(object sender, EventArgs e)
        {
            lb_mp.Text = mp.ToString();
            load();
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_luu_Click(object sender, EventArgs e)
        {
            if(rd_dp.Checked == true)
            {
                if (!string.IsNullOrEmpty(txt_ten.Text))
                {
                    if (!string.IsNullOrEmpty(txt_sdt.Text))
                    {
                        dt.Clear();
                        dt = cl.datphong(mp, "Đặt Phòng", txt_ten.Text, dt_ngay.Value, txt_sdt.Text);
                        if (MessageBox.Show("Đã Lưu", "Chú Ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                        {
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nhập", "Chú Ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        txt_sdt.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Nhập", "Chú Ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    txt_ten.Focus();
                }
            }
            if(rd_huy.Checked == true)
            {
                if (MessageBox.Show("Hủy?", "Chú Ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    dt.Clear();
                    dt = cl.huydatphong(mp);
                    txt_ten.Clear();
                    txt_sdt.Clear();

                }
            }
        }

        private void lb_mp_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rd_dp_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txt_ten_TextChanged(object sender, EventArgs e)
        {

        }

        private void dt_ngay_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void rd_huy_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txt_sdt_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
