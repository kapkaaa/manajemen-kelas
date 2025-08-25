using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manajemen_kelas
{
    public partial class input_kas : Form
    {
        private bendahara bendahara;
        public input_kas(bendahara parent)
        {
            InitializeComponent();
            bendahara = parent;
        }

        private void input_kas_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Masukkan Nama Siswa")
            {
                textBox1.Text = "";

                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Masukkan Nama Siswa";

                textBox1.ForeColor = Color.Silver;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            search(textBox1.Text);
        }

        private void search(string keyword)
        {
           koneksi k = new koneksi();
           k.sql();

            try
            {
                MySqlConnection conn = k.get();

                using (MySqlCommand cmd = new MySqlCommand("select * from users where nama LIKE @keyword"))
                {
                    cmd.Parameters.AddWithValue("keyword", "%" + keyword + "%");
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = dt;
                }

            }catch (Exception ex)
            {
                MessageBox.Show("error" + ex.Message);
            }
            finally
            {
                k.close();
            }
        }
    }
}
