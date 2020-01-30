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
    public partial class dichvu : Form
    {
        public dichvu()
        {
            InitializeComponent();
        }
        CauLenh cl = new CauLenh();
        DataTable dt = new DataTable();
        public int ma = 0;
        private void load()
        {
            dt.Clear();
            txt_ma.Enabled = false;
            bt_them.Enabled = true;
            bt_luu.Enabled = false;
            bt_sua.Enabled = false;
            bt_xoa.Enabled = false;
            txt_gia.Text = null;
            txt_ten.Text = null;
            txt_ma.Text = null;
            dt = cl.laydichvu(0);
            dataGridView1.DataSource = dt;
        }
        private void dichvu_Load(object sender, EventArgs e)
        {
            load();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bt_them.Enabled = true;
            bt_sua.Enabled = true;
            bt_xoa.Enabled = true;
            bt_luu.Enabled = false;
            txt_ten.Text = dataGridView1.CurrentRow.Cells["Ten"].Value.ToString();
            txt_gia.Text = dataGridView1.CurrentRow.Cells["Gia"].Value.ToString();
            ma = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Madv"].Value);
            txt_ma.Text = ma.ToString();
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            bt_sua.Enabled = false;
            bt_xoa.Enabled = false;
            txt_ma.Text = "0";
            bt_luu.Enabled = true;
            txt_ten.Clear();
            txt_gia.Clear();
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            
            if (!string.IsNullOrEmpty(txt_ten.Text))
            {
                if (!string.IsNullOrEmpty(txt_gia.Text))
                {
                    dt.Clear();
                    dt = cl.suadv(ma, txt_ten.Text, Convert.ToInt32(txt_gia.Text));
                    load();
                }
                else
                {
                    MessageBox.Show("Nhập Giá", "Chú Ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Nhập Tên", "Chú Ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            SqlDataReader dr;
            if (MessageBox.Show("Bạn Muốn Xóa", "Chú Ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                dr = cl.xoadv(ma);
                load();
            }
        }

        private void bt_luu_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_ten.Text))
            {
                if (!string.IsNullOrEmpty(txt_gia.Text))
                {
                    dt.Clear();
                    dt = cl.suadv(0, txt_ten.Text, Convert.ToInt32(txt_gia.Text));
                    load();
                }
                else
                {
                    MessageBox.Show("Nhập Giá", "Chú Ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Nhập Tên", "Chú Ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }
    }
}
