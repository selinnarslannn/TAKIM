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
    public partial class Sekmelerr : Form
    {
        public Sekmelerr()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Takimlar go = new Takimlar();
            go.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Oyuncular go = new Oyuncular();
            go.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Mevkiler  go = new Mevkiler();
            go.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Ulkeler  go = new Ulkeler();
            go.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Raporlar go = new Raporlar();
            go.Show();
            this.Hide();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            İletişim go = new İletişim();
            go.Show();
            this.Hide();
        }
    }
}
