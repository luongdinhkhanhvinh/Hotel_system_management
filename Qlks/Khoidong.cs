using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.ComponentModel;

namespace Qlks
{
    public partial class Khoidong : Form
    {
        public Khoidong()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(2);
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
            }
        }

        private void Khoidong_Load(object sender, EventArgs e)
        {
            this.timer1.Start();
        }
    }
}
