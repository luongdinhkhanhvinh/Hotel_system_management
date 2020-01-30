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
    public partial class thongtinnv : Form
    {
        
        public thongtinnv()
        {
            InitializeComponent();
        }
        CauLenh cl = new CauLenh();
        SqlDataReader dr;
        DataTable dt;
        private void loaddulieu()
        {
           
            dt = cl.hiennv(0);
            dg.DataSource = dt.DefaultView;
            
        }
        private void thongtinnv_Load(object sender, EventArgs e)
        {
            loaddulieu();
        }


        private void bt_them_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_ten.Text))
            {
                if (!string.IsNullOrEmpty(txt_taikhoan.Text))
                {

                    if (rd_nam.Checked)
                    {
                        dt.Clear();
                        dt = cl.themnv(txt_ten.Text, rd_nam.Text, txt_diachi.Text, txt_ngaysinh.Text, Convert.ToInt32(txt_sdt.Text), txt_taikhoan.Text, txt_matkhau.Text);
                        if (dt.Rows[0]["errcode"].ToString() == "1")
                        {
                            MessageBox.Show("Tài Đã Khoản Tồn Tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txt_taikhoan.Focus();
                        }
                        else
                        {
                            MessageBox.Show("Thêm Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            dt.Clear();
                            loaddulieu();
                        }
                    }
                    else
                    {
                        dt.Clear();
                        dt = cl.themnv(txt_ten.Text, rd_nu.Text, txt_diachi.Text, txt_ngaysinh.Text, Convert.ToInt32(txt_sdt.Text), txt_taikhoan.Text, txt_matkhau.Text);
                        if (dt.Rows[0]["errcode"].ToString() == "1")
                        {
                            MessageBox.Show("Tài Đã Khoản Tồn Tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txt_taikhoan.Focus();
                        }
                        else
                        {
                            MessageBox.Show("Thêm thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            dt.Clear();
                            loaddulieu();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Nhập Tài Khoản", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_taikhoan.Focus();
                }
            }

            else
            {
                MessageBox.Show("Nhập Tên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_ten.Focus();
            }
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_ten.Text))
            {
                if (!string.IsNullOrEmpty(txt_taikhoan.Text))
                {
                    if (rd_nam.Checked)
                    {
                        dt.Clear();
                        dt = cl.suanv(txt_ten.Text, rd_nam.Text, txt_diachi.Text, txt_ngaysinh.Text, Convert.ToInt32(txt_sdt.Text), txt_taikhoan.Text, txt_matkhau.Text);
                        if (dt.Rows[0]["errcode"].ToString() == "1")
                        {
                            MessageBox.Show("Sai Tài Khoản", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txt_taikhoan.Focus();
                        }
                        else
                        {
                            MessageBox.Show("Sửa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            dt.Clear();
                            loaddulieu();
                            
                        }
                    }
                    else
                    {
                        dt.Clear();
                        dt = cl.suanv(txt_ten.Text, rd_nu.Text, txt_diachi.Text, txt_ngaysinh.Text, Convert.ToInt32(txt_sdt.Text), txt_taikhoan.Text, txt_matkhau.Text);
                        if (dt.Rows[0]["errcode"].ToString() == "0")
                        {
                            MessageBox.Show("Sửa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            dt.Clear();
                            loaddulieu();
                        }
                        else
                        {
                            MessageBox.Show("Sai Tài Khoản", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txt_taikhoan.Focus();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Nhập Tài Khoản", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_taikhoan.Focus();
                }
            }
               
            else
            {
                MessageBox.Show("Nhập Tên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_ten.Focus();
            }
        }

        private void dg_Click(object sender, EventArgs e)
        {
            string gt = null;
            int manv = Convert.ToInt32(dg.CurrentRow.Cells["Manv"].Value.ToString());
            dr = cl.hiennhanvien(manv);
            while (dr.Read())
            {
                txt_ten.Text = dr.GetString(1);
                gt = dr.GetString(2).ToString();
                if (gt == "Nam")
                    rd_nam.Checked = true;
                else
                    rd_nu.Checked = true;
                txt_diachi.Text = dr.GetString(3);
                
                txt_ngaysinh.Text = dr.GetString(4);
                txt_sdt.Text = dr.GetInt32(5).ToString();
                txt_taikhoan.Text = dr.GetString(6);
                txt_matkhau.Text = dr.GetString(7);
            }

        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa nhân viên này?", "Chú Ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                dt = cl.xoanhanvien(Convert.ToInt32(dg.CurrentRow.Cells["Manv"].Value.ToString()));

                dt.Clear();
                loaddulieu();
            }
        }

        private void txt_sdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

       
    }
}
