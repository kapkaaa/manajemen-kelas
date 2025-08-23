using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net.Mail;
using System.Net;
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

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string emailTujuan = "";
            string userId = "";
            koneksi k = new koneksi();
            k.sql();
            MySqlConnection conn = k.get();

            // Cari email berdasarkan username
            using (MySqlCommand cmd = new MySqlCommand("SELECT gmail, id, role_id FROM users WHERE nama = @username", conn))
            {
                cmd.Parameters.AddWithValue("@username", username);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        emailTujuan = reader["gmail"].ToString();
                        userId = reader["id"].ToString();
                        Session.CurrentUserID = Convert.ToInt32(reader["id"]);
                        Session.CurrentUserName = username;
                        Session.CurrentRole = Convert.ToInt32(reader["role_id"]);
                        Session.IsLoggedIn = true;
                    }
                    else
                    {
                        MessageBox.Show("Username tidak ditemukan.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        k.close();
                        return;
                    }
                }
            }

            // Generate token
            Random rand = new Random();
            string tokenn = rand.Next(100000, 999999).ToString(); // Token 6 digit
                                                                 // Waktu token
            DateTime createdAt = DateTime.Now;
            DateTime expiredAt = createdAt.AddMinutes(5); // Token berlaku 5 menit


            // Simpan token ke database
            using (MySqlCommand cmd = new MySqlCommand("insert into auth_tokens (user_id, token, created_at, expired_at) values (@id, @token, @created_at, @expired_at)", conn))
            {
                cmd.Parameters.AddWithValue("@token", tokenn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@id", userId);
                cmd.Parameters.AddWithValue("@created_at", createdAt.ToString("yyyy-MM-dd HH:mm:ss"));
                cmd.Parameters.AddWithValue("@expired_at", expiredAt.ToString("yyyy-MM-dd HH:mm:ss"));
                cmd.ExecuteNonQuery();
            }

            // Kirim token ke email yang sudah ditemukan
            //email mail = new email();
            //mail.SendEmail(emailTujuan, tokenn, username);
            //MessageBox.Show("berhasil");
            token tkn = new token();
            tkn.Show();
            panel1.Visible = false;

            k.close();
        }

    }
}
