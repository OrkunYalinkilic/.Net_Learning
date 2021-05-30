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
    public partial class frmMusteri : Form
    {
        public frmMusteri()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            databese db = new databese();

            List<musteri> musteriListesi = db.musteriListesi();

             dtgMusteriListesi.DataSource = musteriListesi;
            // dtgMusteriListesi.Columns["id"].Visible = false;

            /*
             var isimsizListedgw = from I in musteriListesi
             select new
             {
                 isim = I.isim,
                 soyisim = I.soyisim,
                 tamAdi = I.tamAdi,
             };

            dtgMusteriListesi.DataSource = isimsizListedgw.ToList();
            */

            dtgMusteriListesi.Columns[0].HeaderText = "Müşteri ID";
            dtgMusteriListesi.Columns["isim"].HeaderText = "Müşteri İsim";
            dtgMusteriListesi.Columns["soyisim"].HeaderText = "Müşteri Soyisim";
            dtgMusteriListesi.Columns[4].Width = 220;

            

        }

        private void dtgMusteriListesi_DoubleClick(object sender, EventArgs e)
        {
            int secilenMusteriID = (int)dtgMusteriListesi[0, dtgMusteriListesi.CurrentCell.RowIndex].Value;

            databese db = new databese();

            musteri secilenMusteri = (musteri)db.musteriListesi().FindAll(i => i.id == secilenMusteriID).FirstOrDefault();

            popUpMesaj popUp = new popUpMesaj(secilenMusteri);
            popUp.ShowDialog();

        }
    }
}
