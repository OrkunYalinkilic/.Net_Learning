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
            lblSkor.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnUret_Click(object sender, EventArgs e)
        {

            int mayin1 = 0;
            int mayin2 = 0;
            int mayin3 = 0;

            Random rnd = new Random();
            mayin1 = rnd.Next(1, 20);
            mayin2 = rnd.Next(21, 40);
            mayin3 = rnd.Next(41, 50);

            for (int i = 1; i <= 100; i++)
            {

                Button btnTemp = new Button();

                btnTemp.Name = "btn" + i.ToString();
                btnTemp.Size = new System.Drawing.Size(35, 35);
                btnTemp.Text = i.ToString();
                btnTemp.UseVisualStyleBackColor = true;

                if (i == mayin1 || i == mayin2 || i == mayin3)
                {
                    btnTemp.Tag = true;
                }
                else
                {
                    btnTemp.Tag = false;
                }

                btnTemp.Click += btnTemp_Click;

                flowLayoutPanel1.Controls.Add(btnTemp);

            }

            //this.btnTemp.Location = new System.Drawing.Point(3, 3);
            //this.btnTemp.Name = "btnTemp";
            //this.btnTemp.Size = new System.Drawing.Size(35, 35);
            //this.btnTemp.TabIndex = 2;
            //this.btnTemp.Text = "1";
            //this.btnTemp.UseVisualStyleBackColor = true;
        }

        private void btnTemp_Click(object sender, EventArgs e)
        {
            Button basilanbtnTemp = (Button)sender;
            bool mayinBulundumu = (bool)basilanbtnTemp.Tag;
            if (mayinBulundumu)
            {
                int mayinSayisi = int.Parse(lblMayin.Text);
                mayinSayisi++;
                lblMayin.Text = mayinSayisi.ToString();

                if (mayinSayisi == 3)
                {
                    foreach (Control item in this.Controls)
                    {
                        item.Enabled = false;
                    }
                }

                MessageBox.Show("Mayini Buldunuz..", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);
                basilanbtnTemp.BackColor = Color.Red;
            }

            else
            {
                basilanbtnTemp.BackColor = Color.Plum;

                int skor = int.Parse(lblSkor.Text);
                skor++;
                lblSkor.Text = skor.ToString();
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
