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
    public partial class phong : Form
    {

        

       

        
        public phong()
        {
            InitializeComponent();
        }
        public static int maphong;
        CauLenh cl = new CauLenh();
        DataTable dt = new DataTable() ;
        SqlDataReader dr;
        private object e;
        public void load()
        {
            bt_capnhat.Enabled = false;
            bt_tinhtien.Enabled = false;
            if(rd_kt.Checked == true)
            {
                bt_capnhat.Enabled = true;
                bt_tinhtien.Enabled = true;
            }
            else
            {
                bt_capnhat.Enabled = false;
                bt_tinhtien.Enabled = false;
            }
            label1.Text = "Thông Tin Phòng " + maphong.ToString();
            lb_tenp.Text = "Phòng Số: " + maphong.ToString();
            dr = cl.timphong(maphong);
            while (dr.Read())
            {
                //lb_tt.Text = dr.GetString(1);
                if (dr.GetString(1) == "Trống")
                {
                    rd_t.Checked = true;
                    rd_kt.Checked = false;
                    txt_ten.Text = "";
                    txt_namsinh.Text = "";
                    txt_socm.Text = "";
                    txt_songuoidp.Text = "";

                }
                else
                {
                    rd_kt.Checked = true;
                    rd_t.Checked = false;
                    txt_ten.Text = dr.GetString(2);
                    txt_namsinh.Text = dr.GetInt32(3).ToString();
                    txt_socm.Text = dr.GetInt32(4).ToString();
                    txt_songuoidp.Text = dr.GetInt32(5).ToString();
                    lb_ngaydp.Text = dr.GetDateTime(6).ToString();
                    lb_ngaytp.Text = dr.GetDateTime(7).ToString();
                }
            }
            dr = cl.loaiphong(maphong);
            while(dr.Read())
            {
                lb_lp.Text = dr.GetString(1);
                lp_gp.Text = dr.GetInt32(0).ToString();
            }
        }
        private void phong_Load(object sender, EventArgs e)
        {
            load();            
        }

       
        private void bt_huy_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        public void bt_sua_Click(object sender, EventArgs e)
        {
         
            if(rd_t.Checked)
            {
                txt_ten.Clear();
                txt_namsinh.Clear();
                txt_socm.Clear();
                txt_songuoidp.Clear();
                lb_ngaydp.Text = "";
                lb_ngaytp.Text = "";
                dt = cl.xoaphong(maphong);
                if (dt.Rows[0]["errcode"].ToString() == "1")
                {
                    dt = cl.xoacpp(maphong);
                    dt = cl.xoatongtien(maphong);
                    MessageBox.Show("Sửa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    
                    load();   
                }
            }
            else
            {
                if(!string.IsNullOrEmpty(txt_ten.Text))
                {
                    if (!string.IsNullOrEmpty(txt_namsinh.Text))
                    {
                        if (!string.IsNullOrEmpty(txt_socm.Text))
                        {
                            if (!string.IsNullOrEmpty(txt_songuoidp.Text))
                            {
                                dt = cl.suaphong(maphong, rd_kt.Text, txt_ten.Text, Convert.ToInt32(txt_namsinh.Text), Convert.ToInt32(txt_socm.Text), Convert.ToInt32(txt_songuoidp.Text), dt_ngaydp.Value, dt_ngaytp.Value);
                                rd_kt.Checked = true;
                                if (dt.Rows[0]["errcode"].ToString() == "1")
                                {
                                    MessageBox.Show("Sửa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    
                                    load();   
                                }
                                else
                                {
                                    MessageBox.Show("Lỗi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                }
                            }
                            else
                            {
                                MessageBox.Show("Nhập Số Người Đặt Phòng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                txt_songuoidp.Focus();
                            }
                        }
                        else
	                    {
                            MessageBox.Show("Nhập Số Chứng Minh", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txt_socm.Focus();
                        }
                    }
                    else
	                {
                        MessageBox.Show("Nhập Năm Sinh", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txt_namsinh.Focus();
	                }
                }
                else
                {
                    MessageBox.Show("Nhập Tên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_ten.Focus();
                }

            }


        }

        public void setnull()
        {
            rd_t.Checked = true;
           


        }
        private void bt_tinhtien_Click(object sender, EventArgs e)
        {
            tinhtien.maphong = maphong;
            tinhtien tt = new tinhtien();
            tt.ShowDialog();
            
        }

        private void bt_capnhat_Click(object sender, EventArgs e)
        {
            capnhat.maphong = maphong;
            capnhat cn = new capnhat();
            cn.ShowDialog();
        }

        private void txt_socm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_songuoidp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public void rd_kt_CheckedChanged(object sender, EventArgs e)
        {
            bt_capnhat.Enabled = true;
            bt_tinhtien.Enabled = true;
        }

        private void rd_t_CheckedChanged(object sender, EventArgs e)
        {
            bt_capnhat.Enabled = false;
            bt_tinhtien.Enabled = false;
        }
        public void XoaTrong(object sender, EventArgs e)
        {
            rd_t.Checked = true;
            bt_sua_Click(sender,e);
            this.Close();
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void lb_tenp_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void lb_lp_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void lp_gp_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lb_ngaydp_Click(object sender, EventArgs e)
        {

        }

        private void lb_ngaytp_Click(object sender, EventArgs e)
        {

        }

     
    }
}
