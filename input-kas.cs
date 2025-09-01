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
using static System.Net.WebRequestMethods;

namespace Manajemen_kelas
{
    public partial class input_kas : Form
    {
        private bendahara bendahara;
        private int selectedUserId = -1; 
        private int selectedSemesterId = 1;

        public input_kas(bendahara parent)
        {
            InitializeComponent();
            bendahara = parent;
        }

        private void input_kas_Load(object sender, EventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("id-ID");
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("id-ID");

            // Format Tanggal Indonesia
            dtp.Format = DateTimePickerFormat.Custom;
            // atau jika ingin ada hari & bulan dalam bahasa Indonesia
            dtp.CustomFormat = "dddd, dd MMMM yyyy";

            data();
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
            string keyword = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                data();
            }
            else
            {
                search(keyword);
            }
        }

        private void search(string keyword)
        {
           koneksi k = new koneksi();
           k.sql();

            try
            {
                MySqlConnection conn = k.get();

                using (MySqlCommand cmd = new MySqlCommand("select * from kas_siswa p join users u ON p.user_id = u.id where u.nama LIKE @keyword"))
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

        private void data()
        {
            koneksi k = new koneksi();
            k.sql();
            try
            {
                MySqlConnection conn = k.get();

                using (MySqlCommand cmd = new MySqlCommand("select u.nama, ks.*, s.semester from kas_siswa ks join users u on ks.user_id = u.id join semester s on ks.semester_id = s.id", conn))
                {
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource= dt;
                    dataGridView1.Columns["id"].Visible = false;
                    dataGridView1.Columns["user_id"].Visible = false;

                    dataGridView1.Columns["kode"].HeaderText = "Kode";
                    dataGridView1.Columns["nama"].HeaderText = "Nama Siswa";
                    dataGridView1.Columns["jumlah"].HeaderText = "Kas";
                    dataGridView1.Columns["tanggal"].HeaderText = "Tanggal bayar";
                    dataGridView1.Columns["semester"].HeaderText = "Semester";
                    dataGridView1.Columns["keterangan"].HeaderText = "Keterangan";
                }
                
            } catch (Exception ex)
            {
                MessageBox.Show("error" + ex.Message);
            }
            finally
            { 
                k.close(); 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void clear()
        {
            tbjl.Clear();
            tbkd.Clear();
            tbktr.Clear();
            tbnm.Clear();
            cmbsmt.SelectedIndex = -1;
            dtp.Value = DateTime.Now;
            data();
            textBox1.Clear();
        }
    }
}
