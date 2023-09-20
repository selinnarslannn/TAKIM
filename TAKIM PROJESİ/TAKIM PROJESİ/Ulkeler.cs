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
    public partial class Ulkeler : Form
    {
        public Ulkeler()
        {
            InitializeComponent();
        }

        TakimContainer baglanti = new TakimContainer();
        public void Listele()
        {
            dataGridView1.DataSource = baglanti.UlkeSet.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Listele();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int ulkeno = Convert.ToInt32(textBox1.Tag);
            var yenile = baglanti.UlkeSet.Where(x => x.UlkeNo  == ulkeno).FirstOrDefault();
            yenile.UlkeAdi = textBox1.Text;
            baglanti.SaveChanges();
            Listele();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Ulke save = new Ulke();
            save.UlkeAdi = textBox1.Text;
            baglanti.UlkeSet.Add(save);
            baglanti.SaveChanges();

            Listele();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int ulkeno = Convert.ToInt32(textBox1.Tag);
            var sil = baglanti.UlkeSet.Where(x => x.UlkeNo == ulkeno).FirstOrDefault();
            baglanti.UlkeSet.Remove(sil);
            baglanti.SaveChanges();
            Listele();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = baglanti.UlkeSet.Where(s => s.UlkeAdi.Contains(textBox1.Text)).ToList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            textBox1.Tag = satir.Cells["UlkeNo"].Value.ToString();
            textBox1.Text = satir.Cells["UlkeAdi"].Value.ToString();
        }
    }
   
}
