using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manajemen_kelas
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToString("HH:mm:ss");
            day.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy", new CultureInfo("id-ID"));
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            int role = Session.CurrentRole;

            rolesForm();
                //if (role == 1)
                //{
                //    LoadFormToPanel(new walas());
                //}
                //elseif (role  == 3) {
                //    LoadFormToPanel (new sekretaris());
                //}
                //elseif (role == 4) {
                //    LoadFormToPanel(new bendahara());
                //}
                //elseif (role == 5) {
                //    LoadFormToPanel(new siswa());
                //}


            timer1.Interval = 1000;
            timer1.Start();
        }

        private void rolesForm()
        {
            string form = "";

            koneksi k = new koneksi();
            k.sql();
            MySqlConnection conn = k.get();

            try
            {

                using (MySqlCommand cmd = new MySqlCommand("select * from roles where role_id = @role", conn))
                {
                    cmd.Parameters.AddWithValue("@role", Session.CurrentRole);
                    using (MySqlDataReader  reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            form = reader["form_name"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Role Tidak ditemukan");
                            return;
                        }
                    }
                }

                Type formtype = Type.GetType("Manajemen_kelas." + form);
                if (formtype != null)
                {
                    Form formins =  (Form)Activator.CreateInstance(formtype);
                    LoadFormToPanel(formins);
                }
                else
                {
                    MessageBox.Show("Form Tidak ditemukan");
                }
            } 
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
            finally
            {
                k.close();
            }
        }

        private void LoadFormToPanel(Form childForm)
        {
            panel3.Controls.Clear();
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panel3.Controls.Add(childForm);
            childForm.Show();

            label1.Text = "Dashboard " + childForm.Name;
        }

    }
}
