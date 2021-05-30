using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReflectionFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtObje.Text))
            {
                txtObje.BackColor = Color.White;
                Type T = Type.GetType(txtObje.Text);
                if (T != null)
                {
                    ctors(T);
                    properties(T);
                    methods(T);
                }
                else
                {
                    MessageBox.Show($"{txtObje.Text} Aramis oldugunuz sinif bulunamadi.", "Bilgilendirme",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Lutfen bilgi almak istediginiz sinifin tam adini giriniz", "Bilgilendirme",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtObje.BackColor = Color.Yellow;
            }
        }

        private void ctors(Type t)
        {
            lts_ctors.Items.Clear();
            ConstructorInfo[] RV = t.GetConstructors();
            foreach (var item in RV)
            {
                lts_ctors.Items.Add(item.ToString());
            }
        }
        private void properties(Type t)
        {
            lst_props.Items.Clear();
            PropertyInfo[] PI = t.GetProperties();
            foreach (var item in PI)
            {
                lst_props.Items.Add(item.Name);
            }
        }
        private void methods(Type t)
        {
            lst_mtds.Items.Clear();
            MethodInfo[] MI =  t.GetMethods();
            foreach (var item in MI)
            {
                lst_mtds.Items.Add(item.ReturnType.Name + " " + item.Name);
            }
        }
    }
}
