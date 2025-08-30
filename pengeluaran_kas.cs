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
    public partial class pengeluaran_kas : Form
    {
        private bendahara bendahara;

        public pengeluaran_kas(bendahara parent)
        {
            InitializeComponent();
            bendahara = parent;
        }

        private void pengeluaran_kas_Load(object sender, EventArgs e)
        {

        }
    }
}
