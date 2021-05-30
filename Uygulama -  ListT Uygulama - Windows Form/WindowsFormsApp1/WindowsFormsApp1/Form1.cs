using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class form : Form
    {
        public form()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ButonAcKapa(bool kontrol)
        {
            foreach (Control item in grpBoxIslemListe.Controls)
            {
                if (item is Button)
                {
                    ((Button)item).Enabled = kontrol;
                }
            }
        }

        private void form_Load(object sender, EventArgs e)
        {
            tm_zamanla.Interval = 15000;
            tm_zamanla.Tick += tm_zamanla_tick;
            tm_zamanla.Start();

            ButonAcKapa(false);

            sistemGiris kullaniciKontrol = new sistemGiris();
            kullaniciKontrol.MdiParent = this;
            kullaniciKontrol.StartPosition = FormStartPosition.CenterScreen; 
            kullaniciKontrol.Show();

        }

        private void tm_zamanla_tick(object sender, EventArgs e)
        {
            lblZaman.Text = DateTime.Now.ToString("dd.MM.yyyy hh:mm");

        }
    }
}
