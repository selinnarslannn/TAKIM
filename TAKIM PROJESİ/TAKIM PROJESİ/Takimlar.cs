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
    public partial class Takimlar : Form
    {
        public Takimlar()
        {
            InitializeComponent();
        }

        TakimContainer baglanti = new TakimContainer();

        public void Listele()
        {
            dataGridView1.DataSource = baglanti.TakimSet.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int takimno = Convert.ToInt32(textBox1.Tag);
            var yenile = baglanti.TakimSet.Where(x => x.TakimNo == takimno).FirstOrDefault();
            yenile.TakimAdi = textBox1.Text;
            yenile.UlkeNo = Convert.ToInt32(textBox2.Text);
            baglanti.SaveChanges();
            Listele();

        }

        private void button3_Click(object sender, EventArgs e)
        {

            Takim save = new Takim ();
            save.TakimAdi = textBox1.Text;
            save.UlkeNo = Convert.ToInt32(textBox2.Text);
            baglanti.TakimSet.Add(save);
            baglanti.SaveChanges();
            Listele();

          


        }

        private void button4_Click(object sender, EventArgs e)
        {
            int takimno = Convert.ToInt32(textBox1.Tag);
            var sil = baglanti.TakimSet.Where(x => x.TakimNo == takimno).FirstOrDefault();
            baglanti.TakimSet.Remove(sil);
            baglanti.SaveChanges();
            Listele();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = baglanti.TakimSet.Where(s => s.TakimAdi.Contains(textBox1.Text)).ToList();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            textBox1.Tag = satir.Cells["TakimNo"].Value.ToString();
            textBox1.Text = satir.Cells["TakimAdi"].Value.ToString();
            textBox2.Text = satir.Cells["UlkeNo"].Value.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Sekmelerr go = new Sekmelerr();
            go.Show();
            this.Hide();

        }
    }
}
