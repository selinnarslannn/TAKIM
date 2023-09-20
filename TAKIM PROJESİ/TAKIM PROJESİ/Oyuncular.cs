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
    public partial class Oyuncular : Form
    {
        public Oyuncular()
        {
            InitializeComponent();
        }

        TakimContainer baglanti = new TakimContainer();

        public void Listele()
        {

            dataGridView1.DataSource = baglanti.OyuncuSet.ToList();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Oyuncu save = new  Oyuncu();
            save.Adi = textBox1.Text;
            save.Soyadi = textBox2.Text;
            save.Yas = Convert.ToInt32(textBox3.Text);
            save.Mevki = textBox4.Text;
            save.Maas = Convert.ToInt32(textBox5.Text);
            save.Ulke = textBox6.Text;
            save.TakimNo = Convert.ToInt32(textBox7.Text);
            save.MevkiNo = Convert.ToInt32(textBox8.Text);

            baglanti.OyuncuSet.Add(save);
            baglanti.SaveChanges();

            Listele();

            
    

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int oyuncuno = Convert.ToInt32(textBox1.Tag);
            var yenile = baglanti.OyuncuSet.Where(x => x.OyuncuNo == oyuncuno).FirstOrDefault();
            yenile.Adi = textBox1.Text;
            yenile.Soyadi = textBox2.Text;
            yenile.Yas = Convert.ToInt32(textBox3.Text);
            yenile.Mevki = textBox4.Text;
            yenile.Maas = Convert.ToInt32(textBox5.Text);
            yenile.Ulke = textBox6.Text;

            baglanti.SaveChanges();
            Listele();


            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int oyuncuno = Convert.ToInt32(textBox1.Text);
            var sil = baglanti.OyuncuSet.Where(x => x.OyuncuNo == oyuncuno).FirstOrDefault();
            baglanti.OyuncuSet.Remove(sil);
            baglanti.SaveChanges();
            Listele();

          
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = baglanti.OyuncuSet.Where(s => s.Adi.Contains(textBox1.Text)).ToList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow satir = dataGridView1.CurrentRow;
            textBox1.Tag = satir.Cells["OyuncuNo"].Value.ToString();
            textBox1.Text = satir.Cells["Adi"].Value.ToString();
            textBox2.Text = satir.Cells["Soyadi"].Value.ToString();
            textBox3.Text = satir.Cells["Yas"].Value.ToString();
            textBox4.Text = satir.Cells["Mevki"].Value.ToString();
            textBox5.Text = satir.Cells["Maas"].Value.ToString();
            textBox6.Text = satir.Cells["Ulke"].Value.ToString();
            textBox7.Text = satir.Cells["TakimNo"].Value.ToString();
            textBox8.Text = satir.Cells["MevkiNo"].Value.ToString();
        }

        private void Oyuncular_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Sekmelerr go = new Sekmelerr();
            go.Show();
            this.Hide();
        }
    }
}
