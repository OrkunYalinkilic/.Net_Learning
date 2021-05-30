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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            List<Urun> urunlerim = new List<Urun>();

            urunlerim.Add(new Urun()
            {
                id = 1,
                resimYol = @"C:\Users\Orkun YALINKILIÇ\Desktop\C# DERSLERİ\78-) Windows Form - GridView içinde Image nesnesi\WindowsFormsApp1\WindowsFormsApp1\image\iphonexx.jpg",
                urunTanim = "I PHONE X",


            });

            urunlerim.Add(new Urun()
            {
                id = 2,
                resimYol = @"C:\Users\Orkun YALINKILIÇ\Desktop\C# DERSLERİ\78-) Windows Form - GridView içinde Image nesnesi\WindowsFormsApp1\WindowsFormsApp1\image\samsungg.jpg",
                urunTanim = "SAMSUNG NOTE 10",
            });

            urunlerim.Add(new Urun()
            {
                id = 3,
                resimYol = @"C:\Users\Orkun YALINKILIÇ\Desktop\C# DERSLERİ\78-) Windows Form - GridView içinde Image nesnesi\WindowsFormsApp1\WindowsFormsApp1\image\huawei.jpg",
                urunTanim = " HUAWEİ MATE 1O",
            });

            urunlerim.Add(new Urun()
            {
                id = 4,
                resimYol = @"",
                urunTanim = " BELIRSIZ",
            });

            dgwUrunler.DataSource = urunlerim;

        }

        private void dgwUrunler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
