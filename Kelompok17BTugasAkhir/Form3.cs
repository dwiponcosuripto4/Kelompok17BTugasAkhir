using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kelompok17BTugasAkhir
{
    public partial class KosKosan : Form
    {
        private string stringConnection = "data source=LAPTOP-9OD41I73\\DWIPONCOS;database=Kos;User ID=sa; Password=xm11tpro";
        private SqlConnection koneksi;
        BindingSource customerBindingSource = new BindingSource();
        private string idkk, namakos, alamat, nohp, kapsk, hs;
        public KosKosan()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
        }

        private void FormPemilikKos_Load()
        {
            koneksi.Open();
            SqlDataAdapter dataAdapter1 = new SqlDataAdapter(new SqlCommand("Select m.id_pemilik, m.nama_pemilik, "
            + "m.alamat, m.no_hp From dbo.pemilik m ", koneksi));
            DataSet ds = new DataSet();
            dataAdapter1.Fill(ds);

            this.customerBindingSource.DataSource = ds.Tables[0];
            this.textidkk.DataBindings.Add(
                new Binding("Text", this.customerBindingSource, "id_koskosan", true));
            this.textNK.DataBindings.Add(
                new Binding("Text", this.customerBindingSource, "nama_kos", true));
            this.textAlamat.DataBindings.Add(
                new Binding("Text", this.customerBindingSource, "alamat", true));
            this.textNoHp.DataBindings.Add(
                new Binding("Text", this.customerBindingSource, "no_hp", true));
            this.textKK.DataBindings.Add(
                new Binding("Text", this.customerBindingSource, "kapasitas_kamar", true));
            this.textHS.DataBindings.Add(
                new Binding("Text", this.customerBindingSource, "harga_sewa", true));
            koneksi.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void clearBinding()
        {
            this.textidkk.DataBindings.Clear();
            this.textNK.DataBindings.Clear();
            this.textAlamat.DataBindings.Clear();
            this.textNoHp.DataBindings.Clear();
            this.textKK.DataBindings.Clear();
            this.textHS.DataBindings.Clear();
        }
    }
}
