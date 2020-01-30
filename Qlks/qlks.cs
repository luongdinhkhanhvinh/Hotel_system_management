using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

using System.Data.SqlClient;

namespace Qlks
{
    public partial class qlks : Form
    {
        public qlks()

        {
            Thread t = new Thread(new ThreadStart(SplashScreen));
            t.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            t.Abort();            
         }
        private void SplashScreen()
        {
            Application.Run(new Khoidong());
        }
        public static string nguoi_dn;
        public string hinh1 = @"Hinh\hinh1.png";
        public string hinh2 = @"Hinh\hinh2.jpg";
        public string hinh3 = @"Hinh\dp.png";
        CauLenh cl = new CauLenh();
        DataTable dt = new DataTable();
        SqlDataReader dr;
        public string tt = null;
        private string tinhtrang(int ma)
        {
            dt.Clear();
            dt = cl.ttphong(ma);
            string tt = dt.Rows[0]["TinhTrang"].ToString();
            string hinh = null;
            if (tt == "Không")
            {
                hinh = hinh2;
            }
            if (tt == "Trống")
            {
                hinh = hinh1;
            }
            if(tt == "Đặt Phòng")
            {
                hinh = hinh3;
            }
            return hinh;
        }

        private bool txp(int ma)
        {
            dr = cl.txphong(ma);
            while (dr.Read())
            {
                string tt = dr.GetString(1);

                if (tt == "Hiện")
                    return true;
            }
            return false;
        }
        public void load_tinhtrangphong()
        {
            bt_101.Image = Image.FromFile(tinhtrang(101));
            bt_102.Image = Image.FromFile(tinhtrang(102));
            bt_103.Image = Image.FromFile(tinhtrang(103));
            bt_104.Image = Image.FromFile(tinhtrang(104));
            bt_105.Image = Image.FromFile(tinhtrang(105));
            bt_106.Image = Image.FromFile(tinhtrang(106));
            bt_107.Image = Image.FromFile(tinhtrang(107));
            bt_108.Image = Image.FromFile(tinhtrang(108));
            bt_109.Image = Image.FromFile(tinhtrang(109));
            bt_110.Image = Image.FromFile(tinhtrang(110));

            bt_201.Image = Image.FromFile(tinhtrang(201));
            bt_202.Image = Image.FromFile(tinhtrang(202));
            bt_203.Image = Image.FromFile(tinhtrang(203));
            bt_204.Image = Image.FromFile(tinhtrang(204));
            bt_205.Image = Image.FromFile(tinhtrang(205));
            bt_206.Image = Image.FromFile(tinhtrang(206));
            bt_207.Image = Image.FromFile(tinhtrang(207));
            bt_208.Image = Image.FromFile(tinhtrang(208));
            bt_209.Image = Image.FromFile(tinhtrang(209));
            bt_210.Image = Image.FromFile(tinhtrang(210));

            bt_301.Image = Image.FromFile(tinhtrang(301));
            bt_302.Image = Image.FromFile(tinhtrang(302));
            bt_303.Image = Image.FromFile(tinhtrang(303));
            bt_304.Image = Image.FromFile(tinhtrang(304));
            bt_305.Image = Image.FromFile(tinhtrang(305));
            bt_306.Image = Image.FromFile(tinhtrang(306));
            bt_307.Image = Image.FromFile(tinhtrang(307));
            bt_308.Image = Image.FromFile(tinhtrang(308));
            bt_309.Image = Image.FromFile(tinhtrang(309));
            bt_310.Image = Image.FromFile(tinhtrang(310));

            bt_401.Image = Image.FromFile(tinhtrang(401));
            bt_402.Image = Image.FromFile(tinhtrang(402));
            bt_403.Image = Image.FromFile(tinhtrang(403));
            bt_404.Image = Image.FromFile(tinhtrang(404));
            bt_405.Image = Image.FromFile(tinhtrang(405));
            bt_406.Image = Image.FromFile(tinhtrang(406));
            bt_407.Image = Image.FromFile(tinhtrang(407));
            bt_408.Image = Image.FromFile(tinhtrang(408));
            bt_409.Image = Image.FromFile(tinhtrang(409));
            bt_410.Image = Image.FromFile(tinhtrang(410));

            bt_501.Image = Image.FromFile(tinhtrang(501));
            bt_502.Image = Image.FromFile(tinhtrang(502));
            bt_503.Image = Image.FromFile(tinhtrang(503));
            bt_504.Image = Image.FromFile(tinhtrang(504));
            bt_505.Image = Image.FromFile(tinhtrang(505));
            bt_506.Image = Image.FromFile(tinhtrang(506));
            bt_507.Image = Image.FromFile(tinhtrang(507));
            bt_508.Image = Image.FromFile(tinhtrang(508));
            bt_509.Image = Image.FromFile(tinhtrang(509));
            bt_510.Image = Image.FromFile(tinhtrang(510));

        }
        public void load_bt()
        {
            bt_101.Visible = txp(101);
            bt_102.Visible = txp(102);
            bt_103.Visible = txp(103);
            bt_104.Visible = txp(104);
            bt_105.Visible = txp(105);
            bt_106.Visible = txp(106);
            bt_107.Visible = txp(107);
            bt_108.Visible = txp(108);
            bt_109.Visible = txp(109);
            bt_110.Visible = txp(110);

            bt_201.Visible = txp(201);
            bt_202.Visible = txp(202);
            bt_203.Visible = txp(203);
            bt_204.Visible = txp(204);
            bt_205.Visible = txp(205);
            bt_206.Visible = txp(206);
            bt_207.Visible = txp(207);
            bt_208.Visible = txp(208);
            bt_209.Visible = txp(209);
            bt_210.Visible = txp(210);

            bt_301.Visible = txp(301);
            bt_302.Visible = txp(302);
            bt_303.Visible = txp(303);
            bt_304.Visible = txp(304);
            bt_305.Visible = txp(305);
            bt_306.Visible = txp(306);
            bt_307.Visible = txp(307);
            bt_308.Visible = txp(308);
            bt_309.Visible = txp(309);
            bt_310.Visible = txp(310);

            bt_401.Visible = txp(401);
            bt_402.Visible = txp(402);
            bt_403.Visible = txp(403);
            bt_404.Visible = txp(404);
            bt_405.Visible = txp(405);
            bt_406.Visible = txp(406);
            bt_407.Visible = txp(407);
            bt_408.Visible = txp(408);
            bt_409.Visible = txp(409);
            bt_410.Visible = txp(410);

            bt_501.Visible = txp(501);
            bt_502.Visible = txp(502);
            bt_503.Visible = txp(503);
            bt_504.Visible = txp(504);
            bt_505.Visible = txp(505);
            bt_506.Visible = txp(506);
            bt_507.Visible = txp(507);
            bt_508.Visible = txp(508); ;
            bt_509.Visible = txp(509);
            bt_510.Visible = txp(510);
        }
        public void load_lb()
        {
            lb_101.Visible = txp(101);
            lb_102.Visible = txp(102);
            lb_103.Visible = txp(103);
            lb_104.Visible = txp(104);
            lb_105.Visible = txp(105);
            lb_106.Visible = txp(106);
            lb_107.Visible = txp(107);
            lb_108.Visible = txp(108);
            lb_109.Visible = txp(109);
            lb_110.Visible = txp(110);

            lb_201.Visible = txp(201);
            lb_202.Visible = txp(202);
            lb_203.Visible = txp(203);
            lb_204.Visible = txp(204);
            lb_205.Visible = txp(205);
            lb_206.Visible = txp(206);
            lb_207.Visible = txp(207);
            lb_208.Visible = txp(208);
            lb_209.Visible = txp(209);
            lb_210.Visible = txp(210);

            lb_301.Visible = txp(301);
            lb_302.Visible = txp(302);
            lb_303.Visible = txp(303);
            lb_304.Visible = txp(304);
            lb_305.Visible = txp(305);
            lb_306.Visible = txp(306);
            lb_307.Visible = txp(307);
            lb_308.Visible = txp(308);
            lb_309.Visible = txp(309);
            lb_310.Visible = txp(310);

            lb_401.Visible = txp(401);
            lb_402.Visible = txp(402);
            lb_403.Visible = txp(403);
            lb_404.Visible = txp(404);
            lb_405.Visible = txp(405);
            lb_406.Visible = txp(406);
            lb_407.Visible = txp(407);
            lb_408.Visible = txp(408);
            lb_409.Visible = txp(409);
            lb_410.Visible = txp(410);

            lb_501.Visible = txp(501);
            lb_502.Visible = txp(502);
            lb_503.Visible = txp(503);
            lb_504.Visible = txp(504);
            lb_505.Visible = txp(505);
            lb_506.Visible = txp(506);
            lb_507.Visible = txp(507);
            lb_508.Visible = txp(508);
            lb_509.Visible = txp(509);
            lb_510.Visible = txp(510);
        }
        
        public void frm_load()
        {
            if (nguoi_dn == "admin")
            { label2.Text = "Bạn Đang Truy Cập Bằng Quyền: Quản Lý"; }
            else
            {
                label2.Text = "Bạn Đang Truy Cập Bằng Quyền: Nhân Viên";
                nhânViênToolStripMenuItem.Visible = false;
                sửaPhòngToolStripMenuItem.Visible = false;
                sửaDịchVụToolStripMenuItem.Visible = false;
                thêmXóaPhòngToolStripMenuItem.Visible = false;
            }
         
            load_tinhtrangphong();
            load_bt();
            load_lb();
            
        }
        public string layttp(int ma)
        {
            string kq = null;
            dt.Clear();
            dt = cl.ttphong(ma);
            string tt = dt.Rows[0]["TinhTrang"].ToString();
            if (tt == "Đặt Phòng")
                return kq = "dp";
            if (tt == "Không")
                return kq = "kt";
            else
                return kq = "kdp";
        }
        private void qlks_Load(object sender, EventArgs e)
        {
            frm_load();
            
        }
        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            DangNhap dn = new DangNhap();
            dn.Show();
            //DangNhap dn = new DangNhap();
            //dn.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
               
        
        private void danhSáchPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            danhsachphong p = new danhsachphong();  
            p.ShowDialog();
        }

        private void bt_101_Click(object sender, EventArgs e)
        {
            tt = layttp(101);
            if (tt == "dp")
            {
                
            }
            else
            {
                phong.maphong = 101;
                phong p = new phong();
                p.ShowDialog(); load_tinhtrangphong();
            }
        }

        private void bt_102_Click(object sender, EventArgs e)
        {
            tt = layttp(102);
            if (tt == "dp")
            {
                
            }
            else
            {
                phong.maphong = 102;
                phong p = new phong();
                p.ShowDialog(); load_tinhtrangphong();
            }
        }

        private void bt_103_Click(object sender, EventArgs e)
        {
            tt = layttp(103);
            if (tt == "dp")
            {
                
            }
            else
            {
            phong.maphong = 103;
            phong p = new phong();
            p.ShowDialog(); load_tinhtrangphong();
            }
        }

        private void bt_104_Click(object sender, EventArgs e)
        {
            tt = layttp(104);
            if (tt == "dp")
            {
                
            }
            else
            {
            phong.maphong = 104;
            phong p = new phong();
            p.ShowDialog(); load_tinhtrangphong();}
        }

        private void bt_105_Click(object sender, EventArgs e)
        {
            tt = layttp(105);
            if (tt == "dp")
            {
                
            }
            else
            {
            phong.maphong = 105;
            phong p = new phong();
            p.ShowDialog();
            load_tinhtrangphong();}
        }

        private void bt_106_Click(object sender, EventArgs e)
        {
            tt = layttp(106);
            if (tt == "dp")
            {
                
            }
            else
            {
            phong.maphong = 106;
            phong p = new phong();
            p.ShowDialog(); load_tinhtrangphong();}
        }

        private void bt_107_Click(object sender, EventArgs e)
        {
            tt = layttp(107);
            if (tt == "dp")
            {
                
            }
            else
            {
            phong.maphong = 107;
            phong p = new phong();
            p.ShowDialog(); load_tinhtrangphong();}
        }

        private void bt_108_Click(object sender, EventArgs e)
        {
            tt = layttp(108);
            if (tt == "dp")
            {
                
            }
            else
            {
            phong.maphong = 108;
            phong p = new phong();
            p.ShowDialog(); load_tinhtrangphong();}
        }

        private void bt_109_Click(object sender, EventArgs e)
        {
            tt = layttp(109);
            if (tt == "dp")
            {
                
            }
            else
            {
            phong.maphong = 109;
            phong p = new phong();
            p.ShowDialog(); load_tinhtrangphong();}
        }

        private void bt_110_Click(object sender, EventArgs e)
        {
            tt = layttp(110);
            if (tt == "dp")
            {
                
            }
            else
            {
            phong.maphong = 110;
            phong p = new phong();
            p.ShowDialog(); load_tinhtrangphong();}
        }

        private void bt_210_Click(object sender, EventArgs e)
        {
            tt = layttp(120);
            if (tt == "dp")
            {
                
            }
            else
            {
            phong.maphong = 210;
            phong p = new phong();
            p.ShowDialog(); load_tinhtrangphong();}
        }

        private void bt_209_Click(object sender, EventArgs e)
        {  tt = layttp(209);
            if (tt == "dp")
            {
                
            }
            else
            {
            phong.maphong = 209;
            phong p = new phong();
            p.ShowDialog(); load_tinhtrangphong();
            }
        }

        private void bt_208_Click(object sender, EventArgs e)
        {  tt = layttp(208);
            if (tt == "dp")
            {
                
            }
            else
            {
            phong.maphong = 208;
            phong p = new phong();
            p.ShowDialog(); load_tinhtrangphong();
            }
        }

        private void bt_207_Click(object sender, EventArgs e)
        {  tt = layttp(207);
            if (tt == "dp")
            {
                
            }
            else
            {
            phong.maphong = 207;
            phong p = new phong();
            p.ShowDialog(); load_tinhtrangphong();
            }
        }

        private void bt_206_Click(object sender, EventArgs e)
        {  tt = layttp(206);
            if (tt == "dp")
            {
                
            }
            else
            {
            phong.maphong = 206;
            phong p = new phong();
            p.ShowDialog(); load_tinhtrangphong();
            }
        }

        private void bt_205_Click(object sender, EventArgs e)
        {  tt = layttp(205);
            if (tt == "dp")
            {
                
            }
            else
            {
            phong.maphong = 205;
            phong p = new phong();
            p.ShowDialog(); load_tinhtrangphong();
            }
        }

        private void bt_204_Click(object sender, EventArgs e)
        {  tt = layttp(204);
            if (tt == "dp")
            {
                
            }
            else
            {
            phong.maphong = 204;
            phong p = new phong();
            p.ShowDialog(); load_tinhtrangphong();
            }
        }

        private void bt_203_Click(object sender, EventArgs e)
        {  tt = layttp(203);
            if (tt == "dp")
            {
                
            }
            else
            {
            phong.maphong = 203;
            phong p = new phong();
            p.ShowDialog(); load_tinhtrangphong();
            }
        }

        private void bt_202_Click(object sender, EventArgs e)
        {  tt = layttp(202);
            if (tt == "dp")
            {
                
            }
            else
            {
            phong.maphong = 202;
            phong p = new phong();
            p.ShowDialog(); load_tinhtrangphong();
            }
        }

        private void bt_201_Click(object sender, EventArgs e)
        {  tt = layttp(201);
            if (tt == "dp")
            {
                
            }
            else
            {
            phong.maphong = 201;
            phong p = new phong();
            p.ShowDialog(); load_tinhtrangphong();
            }
        }

        private void bt_301_Click(object sender, EventArgs e)
        {  
            tt = layttp(301);
            if (tt == "dp")
            {
                
            }
            else
            {
            phong.maphong = 301;
            phong p = new phong();
            p.ShowDialog(); load_tinhtrangphong();
            }
        }

        private void bt_302_Click(object sender, EventArgs e)
        {  
            tt = layttp(302);
            if (tt == "dp")
            {
                
            }
            else
            {
            phong.maphong = 302;
            phong p = new phong();
            p.ShowDialog(); load_tinhtrangphong();
            }
        }

        private void bt_303_Click(object sender, EventArgs e)
        {  
            tt = layttp(303);
            if (tt == "dp")
            {
                
            }
            else
            {
            phong.maphong = 303;
            phong p = new phong();
            p.ShowDialog(); load_tinhtrangphong();
            }
        }

        private void bt_304_Click(object sender, EventArgs e)
        {  
            tt = layttp(304);
            if (tt == "dp")
            {
                
            }
            else
            {
            phong.maphong = 304;
            phong p = new phong();
            p.ShowDialog(); load_tinhtrangphong();
            }
        }

        private void bt_305_Click(object sender, EventArgs e)
        {  
            tt = layttp(305);
            if (tt == "dp")
            {
                
            }
            else
            {
            phong.maphong = 305;
            phong p = new phong();
            p.ShowDialog(); load_tinhtrangphong();
            }
        }

        private void bt_306_Click(object sender, EventArgs e)
        {  
            tt = layttp(306);
            if (tt == "dp")
            {
                
            }
            else
            {
            phong.maphong = 306;
            phong p = new phong();
            p.ShowDialog(); load_tinhtrangphong();
            }
        }

        private void bt_307_Click(object sender, EventArgs e)
        {  
            tt = layttp(307);
            if (tt == "dp")
            {
                
            }
            else
            {
            phong.maphong = 307;
            phong p = new phong();
            p.ShowDialog(); load_tinhtrangphong();
            }
        }

        private void bt_308_Click(object sender, EventArgs e)
        {  
            tt = layttp(308);
            if (tt == "dp")
            {
                
            }
            else
            {
            phong.maphong = 308;
            phong p = new phong();
            p.ShowDialog(); load_tinhtrangphong();
            }
        }

        private void bt_309_Click(object sender, EventArgs e)
        {  
            tt = layttp(309);
            if (tt == "dp")
            {
                
            }
            else
            {
            phong.maphong = 309;
            phong p = new phong();
            p.ShowDialog(); load_tinhtrangphong();
            }
        }

        private void bt_310_Click(object sender, EventArgs e)
        {  
            tt = layttp(310);
            if (tt == "dp")
            {
                
            }
            else
            {
            phong.maphong = 310;
            phong p = new phong();
            p.ShowDialog(); load_tinhtrangphong();
            }
        }

        private void bt_401_Click(object sender, EventArgs e)
        {  
            tt = layttp(401);
            if (tt == "dp")
            {
                
            }
            else
            {
            phong.maphong = 401;
            phong p = new phong();
            p.ShowDialog(); load_tinhtrangphong();
            }
        }

        private void bt_402_Click(object sender, EventArgs e)
        {  
            tt = layttp(402);
            if (tt == "dp")
            {
                
            }
            else
            {
            phong.maphong = 402;
            phong p = new phong();
            p.ShowDialog(); load_tinhtrangphong();
            }
        }

        private void bt_403_Click(object sender, EventArgs e)
        {  
            tt = layttp(403);
            if (tt == "dp")
            {
                
            }
            else
            {
            phong.maphong = 403;
            phong p = new phong();
            p.ShowDialog(); load_tinhtrangphong();
            }
        }

        private void bt_404_Click(object sender, EventArgs e)
        {  
            tt = layttp(404);
            if (tt == "dp")
            {
                
            }
            else
            {
            phong.maphong = 404;
            phong p = new phong();
            p.ShowDialog(); load_tinhtrangphong();
            }
        }

        private void bt_405_Click(object sender, EventArgs e)
        {  
            tt = layttp(405);
            if (tt == "dp")
            {
                
            }
            else
            {
            phong.maphong = 405;
            phong p = new phong();
            p.ShowDialog(); load_tinhtrangphong();
            }
        }

        private void bt_406_Click(object sender, EventArgs e)
        {  
            tt = layttp(406);
            if (tt == "dp")
            {
                
            }
            else
            {
            phong.maphong = 406;
            phong p = new phong();
            p.ShowDialog(); load_tinhtrangphong();
            }
        }

        private void bt_407_Click(object sender, EventArgs e)
        {  
            tt = layttp(407);
            if (tt == "dp")
            {
                
            }
            else
            {
            phong.maphong = 407;
            phong p = new phong();
            p.ShowDialog(); load_tinhtrangphong();
            }
        }

        private void bt_408_Click(object sender, EventArgs e)
        {  
            tt = layttp(408);
            if (tt == "dp")
            {
                
            }
            else
            {
            phong.maphong = 408;
            phong p = new phong();
            p.ShowDialog(); load_tinhtrangphong();
            }
        }

        private void bt_409_Click(object sender, EventArgs e)
        {  
            tt = layttp(409);
            if (tt == "dp")
            {
                
            }
            else
            {
            phong.maphong = 409;
            phong p = new phong();
            p.ShowDialog(); load_tinhtrangphong();
            }
        }

        private void bt_410_Click(object sender, EventArgs e)
        {  
            tt = layttp(410);
            if (tt == "dp")
            {
                
            }
            else
            {
            phong.maphong = 410;
            phong p = new phong();
            p.ShowDialog(); load_tinhtrangphong();
            }
        }

        private void bt_501_Click(object sender, EventArgs e)
        {  
            tt = layttp(501);
            if (tt == "dp")
            {
                
            }
            else
            {
            phong.maphong = 501;
            phong p = new phong();
            p.ShowDialog(); load_tinhtrangphong();
            }
        }

        private void bt_502_Click(object sender, EventArgs e)
        {  
            tt = layttp(502);
            if (tt == "dp")
            {
                
            }
            else
            {
            phong.maphong = 502;
            phong p = new phong();
            p.ShowDialog(); load_tinhtrangphong();
            }
        }

        private void bt_503_Click(object sender, EventArgs e)
        {  
            tt = layttp(503);
            if (tt == "dp")
            {
                
            }
            else
            {
            phong.maphong = 503;
            phong p = new phong();
            p.ShowDialog(); load_tinhtrangphong();
            }
        }

        private void bt_504_Click(object sender, EventArgs e)
        {  
            tt = layttp(504);
            if (tt == "dp")
            {
                
            }
            else
            {
            phong.maphong = 504;
            phong p = new phong();
            p.ShowDialog(); load_tinhtrangphong();
            }
        }

        private void bt_505_Click(object sender, EventArgs e)
        {  
            tt = layttp(505);
            if (tt == "dp")
            {
                
            }
            else
            {
            phong.maphong = 505;
            phong p = new phong();
            p.ShowDialog(); load_tinhtrangphong();
            }
        }

        private void bt_506_Click(object sender, EventArgs e)
        {  
            tt = layttp(506);
            if (tt == "dp")
            {
                
            }
            else
            {
            phong.maphong = 506;
            phong p = new phong();
            p.ShowDialog(); load_tinhtrangphong();
            }
        }

        private void bt_507_Click(object sender, EventArgs e)
        {  
            tt = layttp(507);
            if (tt == "dp")
            {
                
            }
            else
            {
            phong.maphong = 507;
            phong p = new phong();
            p.ShowDialog(); load_tinhtrangphong();
            }
        }

        private void bt_508_Click(object sender, EventArgs e)
        {  
            tt = layttp(508);
            if (tt == "dp")
            {
                
            }
            else
            {
            phong.maphong = 508;
            phong p = new phong();
            p.ShowDialog(); load_tinhtrangphong();
            }
        }

        private void bt_509_Click(object sender, EventArgs e)
        {  
            tt = layttp(509);
            if (tt == "dp")
            {
                
            }
            else
            {
            phong.maphong = 509;
            phong p = new phong();
            p.ShowDialog(); load_tinhtrangphong();
            }
        }

        private void bt_510_Click(object sender, EventArgs e)
        {  
            tt = layttp(510);
            if (tt == "dp")
            {

            }
            else
            {
                phong.maphong = 510;
                phong p = new phong();
                p.ShowDialog(); load_tinhtrangphong();
            }
        }

        private void thôngTinNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void thêmNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Txphong t = new Txphong();
            t.ShowDialog();
        }

        private void sửaPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            suaphong sp = new suaphong();
            sp.ShowDialog();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doimatkhau.taikhoan = nguoi_dn;
            doimatkhau dmk = new doimatkhau();
            dmk.ShowDialog();
        }

        private void tìmKiếmKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timkh tk = new timkh();
            tk.Show();
        }

        private void noneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pt_hinh.Image = null;
        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thongtin tt = new Thongtin();
            tt.ShowDialog();
        }
              

        private void thêmXóaPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Txphong tx = new Txphong();
            tx.ShowDialog();
            load_bt();
            load_lb();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            thongtinnv ttnv = new thongtinnv();
            ttnv.ShowDialog();
        }

        private void bt_101_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void bt_101_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                tt = layttp(101);
                if (tt == "kt")
                {
                    
                }
                else
                {
                    Point ClickPoint = new Point(e.X, e.Y);
                    datphong.mp = 101;
                    datphong dp = new datphong();
                    dp.ShowDialog();load_tinhtrangphong();
                }
            }
        }

        private void bt_104_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                tt = layttp(104);
                if (tt == "kt")
                {
                    
                }
                else
                {
                Point ClickPoint = new Point(e.X, e.Y);
                datphong.mp = 104;
                datphong dp = new datphong();
                dp.ShowDialog();load_tinhtrangphong();
                }
            }
        }

        private void bt_102_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                tt = layttp(102);
                if (tt == "kt")
                {

                }
                else
                {
                    Point ClickPoint = new Point(e.X, e.Y);
                    datphong.mp = 102;
                    datphong dp = new datphong();
                    dp.ShowDialog();load_tinhtrangphong();
                }
            }
        }

        private void bt_103_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                tt = layttp(103);
                if (tt == "kt")
                {
                    
                }
                else
                {
                Point ClickPoint = new Point(e.X, e.Y);
                datphong.mp = 103;
                datphong dp = new datphong();
                dp.ShowDialog();load_tinhtrangphong();
                }
            }
        }

        private void bt_105_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                tt = layttp(105);
                if (tt == "kt")
                {
                    
                }
                else
                {
                Point ClickPoint = new Point(e.X, e.Y);
                datphong.mp = 105;
                datphong dp = new datphong();
                dp.ShowDialog();load_tinhtrangphong();
                }
            }
        }

        private void bt_106_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                tt = layttp(106);
                if (tt == "kt")
                {
                    
                }
                else
                {
                Point ClickPoint = new Point(e.X, e.Y);
                datphong.mp = 106;
                datphong dp = new datphong();
                dp.ShowDialog();load_tinhtrangphong();
                }
            }
        }

        private void bt_107_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                tt = layttp(107);
                if (tt == "kt")
                {
                    
                }
                else
                {
                Point ClickPoint = new Point(e.X, e.Y);
                datphong.mp = 107;
                datphong dp = new datphong();
                dp.ShowDialog();load_tinhtrangphong();
                }
            }
        }

        private void bt_108_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                tt = layttp(108);
                if (tt == "kt")
                {
                    
                }
                else
                {
                Point ClickPoint = new Point(e.X, e.Y);
                datphong.mp = 108;
                datphong dp = new datphong();
                dp.ShowDialog();load_tinhtrangphong();
                }
            }
        }

        private void bt_109_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                tt = layttp(109);
                if (tt == "kt")
                {
                    
                }
                else
                {
                Point ClickPoint = new Point(e.X, e.Y);
                datphong.mp = 108;
                datphong dp = new datphong();
                dp.ShowDialog();load_tinhtrangphong();
                }
            }
        }

        private void bt_110_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                tt = layttp(110);
                if (tt == "kt")
                {
                    
                }
                else
                {
                Point ClickPoint = new Point(e.X, e.Y);
                datphong.mp = 110;
                datphong dp = new datphong();
                dp.ShowDialog();load_tinhtrangphong();
                }
            }
        }

        private void bt_201_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                tt = layttp(201);
                if (tt == "kt")
                {
                    
                }
                else
                {
                Point ClickPoint = new Point(e.X, e.Y);
                datphong.mp = 201;
                datphong dp = new datphong();
                dp.ShowDialog();load_tinhtrangphong();
                }
            }
        }

        private void bt_202_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                tt = layttp(202);
                if (tt == "kt")
                {
                    
                }
                else
                {
                Point ClickPoint = new Point(e.X, e.Y);
                datphong.mp = 202;
                datphong dp = new datphong();
                dp.ShowDialog();load_tinhtrangphong();
                }
            }
        }

        private void bt_203_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                tt = layttp(203);
                if (tt == "kt")
                {
                    
                }
                else
                {
                Point ClickPoint = new Point(e.X, e.Y);
                datphong.mp = 203;
                datphong dp = new datphong();
                dp.ShowDialog();load_tinhtrangphong();
                }
            }
        }

        private void bt_204_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                tt = layttp(204);
                if (tt == "kt")
                {
                    
                }
                else
                {
                Point ClickPoint = new Point(e.X, e.Y);
                datphong.mp = 204;
                datphong dp = new datphong();
                dp.ShowDialog();load_tinhtrangphong();
                }
            }
        }

        private void bt_205_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                tt = layttp(205);
                if (tt == "kt")
                {
                    
                }
                else
                {
                Point ClickPoint = new Point(e.X, e.Y);
                datphong.mp = 205;
                datphong dp = new datphong();
                dp.ShowDialog();load_tinhtrangphong();
                }
            }
        }

        private void bt_206_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                tt = layttp(206);
                if (tt == "kt")
                {
                    
                }
                else
                {
                Point ClickPoint = new Point(e.X, e.Y);
                datphong.mp = 206;
                datphong dp = new datphong();
                dp.ShowDialog();load_tinhtrangphong();
                }
            }
        }

        private void bt_207_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                tt = layttp(207);
                if (tt == "kt")
                {
                    
                }
                else
                {
                Point ClickPoint = new Point(e.X, e.Y);
                datphong.mp = 207;
                datphong dp = new datphong();
                dp.ShowDialog();load_tinhtrangphong();
                }
            }
        }

        private void bt_208_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                tt = layttp(208);
                if (tt == "kt")
                {
                    
                }
                else
                {
                Point ClickPoint = new Point(e.X, e.Y);
                datphong.mp = 208;
                datphong dp = new datphong();
                dp.ShowDialog();load_tinhtrangphong();
                }
            }
        }

        private void bt_209_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                tt = layttp(209);
                if (tt == "kt")
                {
                    
                }
                else
                {
                Point ClickPoint = new Point(e.X, e.Y);
                datphong.mp = 209;
                datphong dp = new datphong();
                dp.ShowDialog();load_tinhtrangphong();
                }
            }
        }

        private void bt_210_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                tt = layttp(210);
                if (tt == "kt")
                {
                    
                }
                else
                {
                Point ClickPoint = new Point(e.X, e.Y);
                datphong.mp = 210;
                datphong dp = new datphong();
                dp.ShowDialog();load_tinhtrangphong();
                }
            }
        }

        private void bt_301_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                tt = layttp(301);
                if (tt == "kt")
                {
                    
                }
                else
                {
                Point ClickPoint = new Point(e.X, e.Y);
                datphong.mp = 301;
                datphong dp = new datphong();
                dp.ShowDialog();load_tinhtrangphong();
                }
            }
        }

        private void bt_302_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                tt = layttp(302);
                if (tt == "kt")
                {
                    
                }
                else
                {
                Point ClickPoint = new Point(e.X, e.Y);
                datphong.mp = 302;
                datphong dp = new datphong();
                dp.ShowDialog();load_tinhtrangphong();
                }
            }
        }

        private void bt_303_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                tt = layttp(303);
                if (tt == "kt")
                {
                    
                }
                else
                {
                Point ClickPoint = new Point(e.X, e.Y);
                datphong.mp = 303;
                datphong dp = new datphong();
                dp.ShowDialog();load_tinhtrangphong();
                }
            }
        }

        private void bt_304_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                tt = layttp(304);
                if (tt == "kt")
                {
                    
                }
                else
                {
                Point ClickPoint = new Point(e.X, e.Y);
                datphong.mp = 304;
                datphong dp = new datphong();
                dp.ShowDialog();load_tinhtrangphong();
                }
            }
        }

        private void bt_305_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                tt = layttp(305);
                if (tt == "kt")
                {
                    
                }
                else
                {
                Point ClickPoint = new Point(e.X, e.Y);
                datphong.mp = 305;
                datphong dp = new datphong();
                dp.ShowDialog();load_tinhtrangphong();
                }
            }
        }

        private void bt_306_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                tt = layttp(306);
                if (tt == "kt")
                {
                    
                }
                else
                {
                Point ClickPoint = new Point(e.X, e.Y);
                datphong.mp = 306;
                datphong dp = new datphong();
                dp.ShowDialog();load_tinhtrangphong();
                }
            }
        }

        private void bt_307_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                tt = layttp(307);
                if (tt == "kt")
                {
                    
                }
                else
                {
                Point ClickPoint = new Point(e.X, e.Y);
                datphong.mp = 307;
                datphong dp = new datphong();
                dp.ShowDialog();load_tinhtrangphong();
                }
            }
        }

        private void bt_308_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                tt = layttp(308);
                if (tt == "kt")
                {
                    
                }
                else
                {
                Point ClickPoint = new Point(e.X, e.Y);
                datphong.mp = 308;
                datphong dp = new datphong();
                dp.ShowDialog();load_tinhtrangphong();
                }
            }
        }

        private void bt_309_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                tt = layttp(309);
                if (tt == "kt")
                {
                    
                }
                else
                {
                Point ClickPoint = new Point(e.X, e.Y);
                datphong.mp = 309;
                datphong dp = new datphong();
                dp.ShowDialog();load_tinhtrangphong();
                }
            }
        }

        private void bt_310_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                tt = layttp(310);
                if (tt == "kt")
                {
                    
                }
                else
                {
                Point ClickPoint = new Point(e.X, e.Y);
                datphong.mp = 310;
                datphong dp = new datphong();
                dp.ShowDialog();load_tinhtrangphong();
                }
            }
        }

        private void bt_401_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                tt = layttp(401);
                if (tt == "kt")
                {
                    
                }
                else
                {
                Point ClickPoint = new Point(e.X, e.Y);
                datphong.mp = 401;
                datphong dp = new datphong();
                dp.ShowDialog();load_tinhtrangphong();
                }
            }
        }

        private void bt_402_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                tt = layttp(402);
                if (tt == "kt")
                {
                    
                }
                else
                {
                Point ClickPoint = new Point(e.X, e.Y);
                datphong.mp = 402;
                datphong dp = new datphong();
                dp.ShowDialog();load_tinhtrangphong();
                }
            }
        }

        private void bt_403_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                tt = layttp(403);
                if (tt == "kt")
                {
                    
                }
                else
                {
                Point ClickPoint = new Point(e.X, e.Y);
                datphong.mp = 403;
                datphong dp = new datphong();
                dp.ShowDialog();load_tinhtrangphong();
                }
            }
        }

        private void bt_404_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                tt = layttp(404);
                if (tt == "kt")
                {
                    
                }
                else
                {
                Point ClickPoint = new Point(e.X, e.Y);
                datphong.mp = 404;
                datphong dp = new datphong();
                dp.ShowDialog();load_tinhtrangphong();
                }
            }
        }

        private void bt_405_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                tt = layttp(405);
                if (tt == "kt")
                {
                    
                }
                else
                {
                Point ClickPoint = new Point(e.X, e.Y);
                datphong.mp = 405;
                datphong dp = new datphong();
                dp.ShowDialog();load_tinhtrangphong();
                }
            }
        }

        private void bt_406_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                tt = layttp(406);
                if (tt == "kt")
                {
                    
                }
                else
                {
                Point ClickPoint = new Point(e.X, e.Y);
                datphong.mp = 406;
                datphong dp = new datphong();
                dp.ShowDialog();load_tinhtrangphong();
                }
            }
        }

        private void bt_407_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                tt = layttp(407);
                if (tt == "kt")
                {
                    
                }
                else
                {
                Point ClickPoint = new Point(e.X, e.Y);
                datphong.mp = 407;
                datphong dp = new datphong();
                dp.ShowDialog();load_tinhtrangphong();
                }
            }
        }

        private void bt_408_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                tt = layttp(408);
                if (tt == "kt")
                {
                    
                }
                else
                {
                Point ClickPoint = new Point(e.X, e.Y);
                datphong.mp = 408;
                datphong dp = new datphong();
                dp.ShowDialog();load_tinhtrangphong();
                }
            }
        }

        private void bt_409_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                tt = layttp(409);
                if (tt == "kt")
                {
                    
                }
                else
                {
                Point ClickPoint = new Point(e.X, e.Y);
                datphong.mp = 409;
                datphong dp = new datphong();
                dp.ShowDialog();load_tinhtrangphong();
                }
            }
        }

        private void bt_410_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                tt = layttp(410);
                if (tt == "kt")
                {
                    
                }
                else
                {
                Point ClickPoint = new Point(e.X, e.Y);
                datphong.mp = 410;
                datphong dp = new datphong();
                dp.ShowDialog();load_tinhtrangphong();
                }
            }
        }

        private void bt_501_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                tt = layttp(501);
                if (tt == "kt")
                {
                    
                }
                else
                {
                Point ClickPoint = new Point(e.X, e.Y);
                datphong.mp = 501;
                datphong dp = new datphong();
                dp.ShowDialog();load_tinhtrangphong();
                }
            }
        }

        private void bt_502_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                tt = layttp(502);
                if (tt == "kt")
                {
                    
                }
                else
                {
                Point ClickPoint = new Point(e.X, e.Y);
                datphong.mp = 502;
                datphong dp = new datphong();
                dp.ShowDialog();load_tinhtrangphong();
                }
            }
        }

        private void bt_503_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                tt = layttp(503);
                if (tt == "kt")
                {
                    
                }
                else
                {
                Point ClickPoint = new Point(e.X, e.Y);
                datphong.mp = 503;
                datphong dp = new datphong();
                dp.ShowDialog();load_tinhtrangphong();
                }
            }
        }

        private void bt_504_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                tt = layttp(504);
                if (tt == "kt")
                {
                    
                }
                else
                {
                Point ClickPoint = new Point(e.X, e.Y);
                datphong.mp = 504;
                datphong dp = new datphong();
                dp.ShowDialog();load_tinhtrangphong();
                }
            }
        }

        private void bt_505_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                tt = layttp(505);
                if (tt == "kt")
                {
                    
                }
                else
                {
                Point ClickPoint = new Point(e.X, e.Y);
                datphong.mp = 505;
                datphong dp = new datphong();
                dp.ShowDialog();load_tinhtrangphong();
                }
            }
        }

        private void bt_506_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                tt = layttp(506);
                if (tt == "kt")
                {
                    
                }
                else
                {
                Point ClickPoint = new Point(e.X, e.Y);
                datphong.mp = 506;
                datphong dp = new datphong();
                dp.ShowDialog();load_tinhtrangphong();
                }
            }
        }

        private void bt_507_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                tt = layttp(507);
                if (tt == "kt")
                {
                    
                }
                else
                {
                Point ClickPoint = new Point(e.X, e.Y);
                datphong.mp = 507;
                datphong dp = new datphong();
                dp.ShowDialog();load_tinhtrangphong();
                }
            }
        }

        private void bt_508_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                tt = layttp(508);
                if (tt == "kt")
                {
                    
                }
                else
                {
                Point ClickPoint = new Point(e.X, e.Y);
                datphong.mp = 508;
                datphong dp = new datphong();
                dp.ShowDialog();load_tinhtrangphong();
                }
            }
        }

        private void bt_509_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                tt = layttp(509);
                if (tt == "kt")
                {
                    
                }
                else
                {
                Point ClickPoint = new Point(e.X, e.Y);
                datphong.mp = 509;
                datphong dp = new datphong();
                dp.ShowDialog();load_tinhtrangphong();
                }
            }
        }

        private void bt_510_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                tt = layttp(510);
                if (tt == "kt")
                {
                    
                }
                else
                {
                Point ClickPoint = new Point(e.X, e.Y);
                datphong.mp = 510;
                datphong dp = new datphong();
                dp.ShowDialog();load_tinhtrangphong();
                }
            }
        }

        private void sửaDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dichvu dv = new dichvu();
            dv.ShowDialog();
        }

        private void trợGiúpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pt_hinh_Click(object sender, EventArgs e)
        {

        }
    }
}
