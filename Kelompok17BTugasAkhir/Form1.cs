using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kelompok17BTugasAkhir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Kelompok17BTugasAkhir.FormKamar formPanggil = new Kelompok17BTugasAkhir.FormKamar();
            formPanggil.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kelompok17BTugasAkhir.FormPemilikKos formPanggil = new Kelompok17BTugasAkhir.FormPemilikKos();
            formPanggil.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kelompok17BTugasAkhir.KosKosan formPanggil = new Kelompok17BTugasAkhir.KosKosan();
            formPanggil.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Kelompok17BTugasAkhir.FormPenyewa formPanggil = new Kelompok17BTugasAkhir.FormPenyewa();
            formPanggil.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Kelompok17BTugasAkhir.admin formPanggil = new Kelompok17BTugasAkhir.admin();
            formPanggil.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Kelompok17BTugasAkhir.FormTransaksi formPanggil = new Kelompok17BTugasAkhir.FormTransaksi();
            formPanggil.Show();
        }
    }
}
