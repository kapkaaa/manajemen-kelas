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
            textBox1.Text = "Masukkan nama anda";
            textBox1.ForeColor = Color.Gray;

            textBox1.Enter += RemoveText;
            textBox1.Leave += AddText;

            int borderRadius = 20; // Semakin besar, semakin melengkung
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
            path.AddArc(button1.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
            path.AddArc(button1.Width - borderRadius, button1.Height - borderRadius, borderRadius, borderRadius, 0, 90);
            path.AddArc(0, button1.Height - borderRadius, borderRadius, borderRadius, 90, 90);
            path.CloseAllFigures();

            button1.Region = new Region(path);
        }

        private void RemoveText(object sender, EventArgs e)
        {
            if (textBox1.Text == "Masukkan nama anda")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void AddText(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = "Masukkan nama anda";
                textBox1.ForeColor = Color.Gray;
            }
        }
    }
}
