using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manajemen_kelas
{
    internal class koneksi
    {
        private string connectionString = "Server=localhost;Port=3306;Database=kelas;Uid=root;Pwd=;";
        private MySqlConnection conn;

        public koneksi()
        {
            conn = new MySqlConnection(connectionString);
        }

        // Method untuk buka koneksi
        public void sql()
        {
            try
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal membuka koneksi: " + ex.Message);
            }
        }

        // Method untuk tutup koneksi
        public void close()
        {
            try
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menutup koneksi: " + ex.Message);
            }
        }

        // Method untuk ambil objek koneksi
        public MySqlConnection get()
        {
            return conn;
        }
    }
}

