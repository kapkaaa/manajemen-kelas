using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manajemen_kelas
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

            BuatRoundedButton(button1);
            BuatRoundedButton(button2);
        }

        private void BuatRoundedButton(Button btn)
        {
            int borderRadius = btn.Height / 2;

            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, borderRadius * 2, borderRadius * 2, 180, 90);
            path.AddArc(btn.Width - borderRadius * 2, 0, borderRadius * 2, borderRadius * 2, 270, 90);
            path.AddArc(btn.Width - borderRadius * 2, btn.Height - borderRadius * 2, borderRadius * 2, borderRadius * 2, 0, 90);
            path.AddArc(0, btn.Height - borderRadius * 2, borderRadius * 2, borderRadius * 2, 90, 90);
            path.CloseFigure();

            btn.Region = new Region(path);
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Masukkan Nama Anda")
            {
                textBox1.Text = "";

                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Masukkan Nama Anda";

                textBox1.ForeColor = Color.Silver;
            }
        }
    }
}
