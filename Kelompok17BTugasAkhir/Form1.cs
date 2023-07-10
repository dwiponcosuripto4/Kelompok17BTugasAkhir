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
            Kelompok17BTugasAkhir.Form4 formPanggil = new Kelompok17BTugasAkhir.Form4();
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
            Kelompok17BTugasAkhir.Form5 formPanggil = new Kelompok17BTugasAkhir.Form5();
            formPanggil.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Kelompok17BTugasAkhir.Form6 formPanggil = new Kelompok17BTugasAkhir.Form6();
            formPanggil.Show();
        }
    }
}
