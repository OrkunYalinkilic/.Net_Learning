using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Udemy.TelefonRehber
{
    public partial class Form1 : Form
    {
        BusinessLogicLayer.BLL bll;
        public Form1()
        {
            InitializeComponent();
            bll = new BusinessLogicLayer.BLL();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
           int returnValues = bll.SistemKayitKontrol(txtKullaniciAdi.Text, txtSifre.Text);
            if (returnValues>0)
            {
                AnaForm af = new AnaForm();
                af.Show();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı adı veya şifre!","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
    }
}
