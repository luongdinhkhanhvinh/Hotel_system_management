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
    public partial class Txphong : Form
    {
        public Txphong()
        {
            InitializeComponent();
        }
        CauLenh cl = new CauLenh();
        DataTable dt = new DataTable();
        SqlDataReader dr;
        private string tt = null;
        private void load()
        {
            
            bt_xoa.Enabled = false;
            cb_mp.Enabled = false;
            bt_them.Enabled = false;            
            cb_mpa.Enabled = false;
            if(rd_them.Checked == true)
            {
                dt.Clear();
                cb_mpa.Enabled = true;
                cb_mp.Enabled = false;
                bt_them.Enabled = true;
                bt_xoa.Enabled = false;
                dt = cl.laytrangthaianhien(0, "Ẩn");
                cb_mpa.DataSource = dt;
                cb_mpa.DisplayMember = "Maphong";
            }
            else if(rd_xoa.Checked == true)
            {
                dt.Clear();
                cb_mp.Enabled = true;
                cb_mpa.Enabled = false;
                bt_xoa.Enabled = true;
                bt_them.Enabled = false;
                dt = cl.laytrangthaianhien(0, "Hiện");
                cb_mp.DataSource = dt;
                cb_mp.DisplayMember = "Maphong";
            }
            
        }
        private void Txphong_Load(object sender, EventArgs e)
        {
            load();
        }
        private void rd_xoa_CheckedChanged(object sender, EventArgs e)
        {
            dt.Clear();
            cb_mp.Enabled = true;
            cb_mpa.Enabled = false;
            bt_xoa.Enabled = true;
            bt_them.Enabled = false;
            dt = cl.laytrangthaianhien(0, "Hiện");
            cb_mp.DataSource = dt;
            cb_mp.DisplayMember = "Maphong";
            
        }
        private void bt_xoa_Click(object sender, EventArgs e)
        {
            dr = cl.ttphong1(Convert.ToInt32(cb_mp.Text));
            
            while(dr.Read())
            {
                tt = dr.GetString(1);
            }
            if (tt == "Trống")
            {
                if (MessageBox.Show("Bạn muốn xóa?", "Chú Ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    dt = cl.suatrangthaianhien(Convert.ToInt32(cb_mp.Text), "Ẩn");
                    load();
                }
            }
            else
            {
                MessageBox.Show("Không Thể Xóa Phòng Có Khách", "Chú Ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                load();
            }
        }

        private void rd_them_CheckedChanged(object sender, EventArgs e)
        {
            dt.Clear();
            cb_mpa.Enabled = true;
            cb_mp.Enabled = false;
            bt_them.Enabled = true;
            bt_xoa.Enabled = false;
            dt = cl.laytrangthaianhien(0, "Ẩn");
            cb_mpa.DataSource = dt;
            cb_mpa.DisplayMember = "Maphong";
            
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thêm?", "Chú Ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                dt = cl.suatrangthaianhien(Convert.ToInt32(cb_mpa.Text), "Hiện");
                load();
            }
        }

        
    }
}
