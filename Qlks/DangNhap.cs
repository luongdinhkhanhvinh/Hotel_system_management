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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }


        CauLenh cl = new CauLenh();
        DataTable dt = new DataTable();
        private void DangNhap_Load(object sender, EventArgs e)
        {

        }
        private void bt_dn_Click(object sender, EventArgs e)
        {
            dt.Clear();
            dt = cl.dangnhap(txt_tk.Text, txt_mk.Text);
            if (!string.IsNullOrEmpty(txt_tk.Text))
            {
                if (!string.IsNullOrEmpty(txt_mk.Text))
                {
                    if (dt.Rows[0]["errcode"].ToString() == "0")
                    {
                        qlks.nguoi_dn = txt_tk.Text;
                        tinhtien.nv = txt_tk.Text;
                        txt_mk.Text = "";
                        txt_tk.Text = "";
                        txt_tk.Focus();
                        this.Hide();
                        qlks ql = new qlks();
                        ql.ShowDialog();
                    }

                    else
                    {
                        lblhienthi.Text = "Sai Tên Đăng Nhập Hoặc Mật Khẩu !!!";
                        txt_tk.Text = "";
                        txt_mk.Text = "";
                        txt_tk.Focus();
                    }
                }
                else
                {
                    lblhienthi.Text = "Chưa Nhập Mật Khẩu !!!";
                    txt_mk.Focus();
                }
            }
            else
            {
                lblhienthi.Text = "Chưa Nhập Tên Đăng Nhập !!!";
                txt_tk.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void enter(object sender, KeyPressEventArgs e)
        {
            this.bt_dn_Click(sender,e);
        }
    }
}
