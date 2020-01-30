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
    public partial class doimatkhau : Form
    {
        public doimatkhau()
        {
            InitializeComponent();
        }
        CauLenh cl = new CauLenh();
        DataTable dt;
        public static string taikhoan;
        public void frm_load()
        {
            lb_tk.Text = taikhoan;
            txt_mkm.Clear();
            txt_mkc.Clear();
            txt_nl.Clear();
        }
        private void doimatkhau_Load(object sender, EventArgs e)
        {
            frm_load();

        }

        private void bt_luu_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txt_mkc.Text))
            {
                if (!string.IsNullOrEmpty(txt_mkm.Text))
                {
                    if (!string.IsNullOrEmpty(txt_nl.Text))
                    {
                        if (txt_mkm.Text == txt_nl.Text)
                        {
                            dt = cl.doimatkhau(lb_tk.Text, txt_mkc.Text, txt_mkm.Text);
                            if (dt.Rows[0]["errcode"].ToString() == "0")
                            {
                                MessageBox.Show("Đã Lưu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                this.Close();
                               
                            }
                            else if (dt.Rows[0]["errcode"].ToString() == "1")
                            {
                                MessageBox.Show("Lỗi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                frm_load();
                                dt.Clear();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Mật khẩu nhập lại không chính xác", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Xác nhận mật khẩu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txt_nl.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Nhập mật khẩu mới", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_mkm.Focus();
                }
            }
            else
            {
                MessageBox.Show("Nhập mật khẩu cũ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_mkc.Focus();
            }
        }

        private void bt_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
