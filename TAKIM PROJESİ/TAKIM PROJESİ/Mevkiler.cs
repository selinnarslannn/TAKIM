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
    public partial class Mevkiler : Form
    {
        public Mevkiler()
        {
            InitializeComponent();
        }

        TakimContainer baglanti = new TakimContainer();

        public void Listele()
        {
            dataGridView1.DataSource = baglanti.MevkiSet.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int mevkino = Convert.ToInt32(textBox1.Tag);
            var yenile = baglanti.MevkiSet.Where(x => x.MevkiNo  == mevkino).FirstOrDefault();
            yenile.MevkiAdi = Convert.ToString(textBox1.Text);
            baglanti.SaveChanges();
            Listele();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Mevki save = new Mevki();
            save.MevkiAdi = textBox1.Text;
            baglanti.MevkiSet.Add(save);
            baglanti.SaveChanges();

            Listele();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int mevkino = Convert.ToInt32(textBox1.Tag);
            var sil = baglanti.MevkiSet.Where(x => x.MevkiNo == mevkino).FirstOrDefault();
            baglanti.MevkiSet.Remove(sil);
            baglanti.SaveChanges();
            Listele();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = baglanti.MevkiSet.Where(s => s.MevkiAdi.Contains(textBox1.Text)).ToList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            DataGridViewRow satir = dataGridView1.CurrentRow;
            textBox1.Tag = satir.Cells["MevkiNo"].Value.ToString();
            textBox1.Text = satir.Cells["MevkiAdi"].Value.ToString();
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Sekmelerr go = new Sekmelerr();
            go.Show();
            this.Hide();
        }
    }
}
