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
            txtBilgi.Text = "Bir metin degeri giriniz.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string txtMesajDegeri = txtBilgi.Text;
            Form2 frm2 = new Form2(txtMesajDegeri);
            frm2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtBilgi_Enter(object sender, EventArgs e)
        {
            TextBox t1 = (TextBox)sender;
            t1.Text = string.Empty;
        }
    }
}
