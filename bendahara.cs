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
    public partial class bendahara : Form
    {
        public bendahara()
        {
            InitializeComponent();
        }

        public void panelform(Form form)
        {
            panel1.Controls.Clear();

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            panel1.Controls.Add(form);
            form.Show();

            if (form is input_kas)
            {
                label2.Text = "PEMBAYARAN KAS";
            }
            else if (form is laporkas)
            {
                label2.Text = "LAPORAN KAS";
            }
            else if (form is profil)
            {
                label2.Text = "PROFIL SISWA";
            }
            else if (form is pengeluaran_kas)
            {
                label2.Text = "PENGELUARAN KAS";
            }
            else
            {
                label2.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelform(new input_kas(this));
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

        private void bendahara_Load(object sender, EventArgs e)
        {
            BuatRoundedButton(button3);
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Form1 main = new Form1();
            main.Show();
            this.Close();
            Session.Clear();
            
        }   

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 main = new Form1();
            main.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelform(new pengeluaran_kas(this));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panelform(new laporkas(this));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panelform(new profil(this));
        }
    }
}
