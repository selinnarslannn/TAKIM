using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TAKIM_PROJESİ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        TakimContainer baglanti = new TakimContainer();

        public bool  GirisYap( string ad , string sifre)
        {
            var query = from p in baglanti.KullaniciSet  where p.KullaniciAdi == ad && p.Sifre == sifre select p;

            if (query.Any())
            {
                return true;
            }
            else
            {
                return false;
            }

        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            if (GirisYap(textBox1.Text, textBox2.Text))
            {
                MessageBox.Show("Giriş Başarılı...");
            }
            else
            {
                MessageBox.Show("Giriş Başarısız...");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Visible = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            Sekmelerr go = new Sekmelerr();
            go.Show();
            this.Hide();
        }
    }
}
