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
    public partial class tinhtien : Form
    {
        double tienphong, tongtien;
        public tinhtien()
        {
            InitializeComponent();
        }
        public static int maphong;
        public static string nv;
        SqlDataReader dr;
        DataTable dt = new DataTable();
        CauLenh cl = new CauLenh();
       
        private void tinhtien_Load(object sender, EventArgs e)
        {
            int /*ngay1, thang1, ngay2, thang2, nam1, nam2,*/ giaphong;
            dr = cl.loaiphong(maphong);
            while (dr.Read())
            {
                giaphong = dr.GetInt32(0);

                dr = cl.timphong(maphong);
                while (dr.Read())
                {
                    //lb_tt.Text = dr.GetString(1);
                    if (dr.GetString(1) == "Trống")
                    {


                    }
                    else
                    {


                        lb_ten.Text = dr.GetString(2);
                        lb_namsinh.Text = dr.GetInt32(3).ToString();
                        lb_socm.Text = dr.GetInt32(4).ToString();
                        lb_ngaydp.Text = dr.GetDateTime(6).ToString();
                        lb_ngaytp.Text = dr.GetDateTime(7).ToString();


                        //string chuoi1 = lb_ngaydp.Text;
                        //string chuoi2 = lb_ngaytp.Text;

                        //string[] ketqua1 = chuoi1.Split('/');
                        //thang1 = Convert.ToInt32(ketqua1[0]);
                        //ngay1 = Convert.ToInt32(ketqua1[1]);
                        //string nam = ketqua1[2];
                        //nam1 = Convert.ToInt32(nam.Substring(0, 4));
                        

                        //string[] ketqua2 = chuoi2.Split('/');
                        //thang2 = Convert.ToInt32(ketqua2[0]);
                        //ngay2 = Convert.ToInt32(ketqua2[1]);
                        //string namm = ketqua2[2];
                        //nam2 = Convert.ToInt32(namm.Substring(0, 4));
                        //string mot = ngay1 + "/" + thang1 + "/" + nam1;
                        //string hai = ngay2 + "/" + thang2 + "/" + nam2;


                        DateTime ngaythue = Convert.ToDateTime(lb_ngaydp.Text);
                        DateTime ngaytra = Convert.ToDateTime(lb_ngaytp.Text);
                        TimeSpan ngaythuephong = ngaytra - ngaythue;
                        int songay = ngaythuephong.Days;
                        tienphong = songay * giaphong;

                        //tienphong = ((ngay2 - ngay1) + ((thang2 - thang1) * 30) + ((nam2 - nam1) * 365))  * giaphong;
                        lb_tienphong.Text = Convert.ToString(tienphong);
                    }


                }
            }
            dr = cl.hientongtien(maphong);
            while (dr.Read())
            {
                lb_chiphi.Text = dr.GetInt32(0).ToString();

            }
            dr = cl.laytiencoc(maphong);
            while(dr.Read())
            {
                lb_tc.Text = dr.GetInt32(0).ToString();
            }
            label1.Text = "Thông Tin Phòng: " + maphong.ToString();
            lb_tenp.Text = "Phòng Số: " + maphong.ToString();
            if (lb_tienphong.Text != "Trống")
            {
                tongtien = Convert.ToDouble(lb_tienphong.Text) + Convert.ToDouble(lb_chiphi.Text) - Convert.ToInt32(lb_tc.Text);
                lb_tongtien.Text = Convert.ToString(tongtien);
            }

        }

        private void bt_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_tinhtien_Click(object sender, EventArgs e)
        {
            
           if (lb_tongtien.Text == "0")
            {
                MessageBox.Show("Lỗi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                dt = cl.luuthongtinphong(maphong, lb_ten.Text, Convert.ToInt32(lb_namsinh.Text), Convert.ToInt32(lb_socm.Text), lb_ngaydp.Text, lb_ngaytp.Text, Convert.ToInt32(lb_tienphong.Text), Convert.ToInt32(lb_chiphi.Text), Convert.ToInt32(lb_tongtien.Text),nv);
                MessageBox.Show("Đã Lưu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //this.Close();
                phong f = new phong();


                f.XoaTrong(sender,e);                         
               lb_tongtien.Text = "0";
                lb_tienphong.Text = "0";
                lb_chiphi.Text = "0";
            
            }
        }

        private void bt_in_Click(object sender, EventArgs e)
        {

        }

        private void lb_tenp_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lb_ngaydp_Click(object sender, EventArgs e)
        {

        }

        private void lb_ngaytp_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lb_ten_Click(object sender, EventArgs e)
        {

        }

        private void lb_tienphong_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void lb_namsinh_Click(object sender, EventArgs e)
        {

        }

        private void lb_socm_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lb_chiphi_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void lb_tongtien_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void lb_tc_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
