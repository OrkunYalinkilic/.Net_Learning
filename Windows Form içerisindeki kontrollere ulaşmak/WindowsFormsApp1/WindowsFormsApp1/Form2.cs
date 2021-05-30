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
    public partial class frmKayitOnIzlemeEkrani : Form
    {
        public frmKayitOnIzlemeEkrani()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

            foreach (Form item in Application.OpenForms)
            {
                if (item.Name == "Form1")
                {
                    foreach (Control item2 in item.Controls)
                    {
                        if (item2 is TextBox)
                        {
                            ((TextBox)item2).Text = string.Empty;
                        }
                    }
                }
            }

            //VEYA
            /*
            Form yakalanan = Application.OpenForms["Form1"];
            ((TextBox)yakalanan.Controls["txtIsım"]).Text = string.Empty;
            ((TextBox)yakalanan.Controls["txtSoyisim"]).Text = string.Empty;
            ((TextBox)yakalanan.Controls["txtEmailAdres"]).Text = string.Empty;
            ((TextBox)yakalanan.Controls["txtTelefonNo"]).Text = string.Empty;
            */

            this.Close();
        }
    }
}
