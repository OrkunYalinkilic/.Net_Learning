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
    public partial class KullaniciUrunSecimleri : Form
    {
        Urun[] secilenUrunler;
        public KullaniciUrunSecimleri(Urun[] secilenUrunlerParametre)
        {
            InitializeComponent();
            secilenUrunler = secilenUrunlerParametre;
        }

        private void KullaniciUrunSecimleri_Load(object sender, EventArgs e)
        {
            foreach (Urun item in secilenUrunler)
            {
                Button btn = new Button();
                btn.Name = "btn" + item.id.ToString();
                btn.Text = item.urunAdi;
                btn.Size = new System.Drawing.Size(184, 60);
                btn.Tag = item;
                btn.Click += Btn_Click;

                //this.button1.Location = new System.Drawing.Point(14, 254);
                //this.button1.Name = "button1";
                //this.button1.Size = new System.Drawing.Size(114, 57);
                //this.button1.TabIndex = 2;
                //this.button1.Text = "button1";
                //this.button1.UseVisualStyleBackColor = true;

                flowLayoutPanel1.Controls.Add(btn);

            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {   //anlık

            Button bt = sender as Button;
            Urun u1 = bt.Tag as Urun;

            Form F1 = Application.OpenForms["Form1"];
            GroupBox F1GBOX = (GroupBox)F1.Controls["groupBox1"];

            ((PictureBox)F1GBOX.Controls["pctUrunResim"]).Image = Image.FromFile(u1.urunResim);
            ((TextBox)F1GBOX.Controls["txtUrunAdi"]).Text = u1.urunAdi;
            ((TextBox)F1GBOX.Controls["txtKategori"]).Text = u1.urunKategori;
            ((TextBox)F1GBOX.Controls["txtYazar"]).Text = u1.yazar;
            ((TextBox)F1GBOX.Controls["txtStokAdet"]).Text = u1.stokAdet.ToString();
            ((RichTextBox)F1GBOX.Controls["txtUrunAciklama"]).Text = u1.aciklama;

            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
