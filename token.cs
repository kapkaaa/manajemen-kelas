using MySql.Data.MySqlClient;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Manajemen_kelas
{
    public partial class token : Form
    {

        private Form1 utama;

        public token(Form1 parent)
        {
            InitializeComponent();
            utama = parent;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            label3.Enabled = false;

            // Kirim ulang token ke email
            //email mail = new email();
            //mail.SendEmail(emailTujuan, token, username);

            // Tampilkan notifikasi
            MessageBox.Show("Token berhasil dikirim ulang. Silakan cek email Anda.", "Kirim Ulang Token", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Mulai timer cooldown
            timer1.Interval = 30000; // 30 detik cooldown
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Enabled = true;
            timer1.Stop();
        }

        private void token_Load(object sender, EventArgs e)
        {
            int RoleId = Session.CurrentRole;

            BuatRoundedButton(button1);
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
            if (textBox1.Text == "Masukkan Token")
            {
                textBox1.Text = "";

                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Masukkan Token";

                textBox1.ForeColor = Color.Silver;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            koneksi k = new koneksi();
            k.sql();
            MySqlConnection conn = k.get();


            using (MySqlCommand cmd = new MySqlCommand("SELECT * from auth_tokens where token = @token", conn))
            {
                cmd.Parameters.AddWithValue("@token", textBox1.Text);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        DateTime expiredAt = Convert.ToDateTime(reader["expired_at"]);

                        if (DateTime.Now > expiredAt)
                        {
                            MessageBox.Show("Token sudah expired.");
                        }
                        else
                        {
                            dashboard home = new dashboard();
                            home.Show();
                            this.Close();
                            utama.Hide();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Token tidak valid.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        k.close();
                        return;
                    }
                }
            }
        }
    }
}
