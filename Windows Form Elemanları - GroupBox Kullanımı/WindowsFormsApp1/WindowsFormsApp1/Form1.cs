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

        int labelSayac = 0;
        int textboxSayac = 0;
        int groupBoxSayac = 0;
        Control c;

        private void Form1_Load(object sender, EventArgs e)
        {
            //breakpoint ile incele..

            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                    textboxSayac++;
                else if (item is Label)
                    labelSayac++;
                else if (item is GroupBox)
                    groupBoxSayac++;
            }

            GroupBox GPBox = this.Controls["groupBox1"] as GroupBox;

            foreach (Control item in GPBox.Controls)
            {
                c = item;
            }



        }
    }
}
