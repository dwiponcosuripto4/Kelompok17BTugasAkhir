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
        private string idkk, namakos, alamat, nohp, kapsk, hs;
        BindingSource customerBindingSource = new BindingSource();
        public KosKosan()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            this.bnKos.BindingSource = this.customerBindingSource;
            refreshform();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            textidkk.Text = "";
            textNK.Text = "";
            textAlamat.Text = "";
            textNoHp.Text = "";
            textKK.Text = "";
            textHS.Text = "";
            textidkk.Enabled = true;
            textNK.Enabled = true;
            textAlamat.Enabled = true;
            textNoHp.Enabled = true;
            textKK.Enabled = true;
            textHS.Enabled = true;
            btnSave.Enabled = true;
            btnClear.Enabled = true;
            btnAdd.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            idkk = textidkk.Text;
            namakos = textNK.Text;
            alamat = textAlamat.Text;
            nohp = textNoHp.Text;
            kapsk = textKK.Text;
            hs = textHS.Text;
            koneksi.Open();
            string str = "insert into dbo.Kos (id_kos, nama_kos, alamat, no_hp, kapasitas, harga)" + "values(@idk, @nk, @Al, @nohp, @kaps, @hrs)";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SqlParameter("idk", idkk));
            cmd.Parameters.Add(new SqlParameter("nk", namakos));
            cmd.Parameters.Add(new SqlParameter("Al", alamat));
            cmd.Parameters.Add(new SqlParameter("nohp", nohp));
            cmd.Parameters.Add(new SqlParameter("kaps", kapsk));
            cmd.Parameters.Add(new SqlParameter("hrs", hs));
            cmd.ExecuteNonQuery();

            koneksi.Close();

            MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

            refreshform();
        }

        private void bnKos_RefreshItems(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            refreshform();
        }

        private void KosKosan_Load()
        {
            koneksi.Open();
            SqlDataAdapter dataAdapter1 = new SqlDataAdapter(new SqlCommand("Select m.id_kos, m.nama_kos, "
            + "m.alamat, m.no_hp, m.kapasitas, m.harga from dbo.kos m ", koneksi));
            DataSet ds = new DataSet();
            dataAdapter1.Fill(ds);

            this.customerBindingSource.DataSource = ds.Tables[0];
            this.textidkk.DataBindings.Add(
                new Binding("Text", this.customerBindingSource, "id_kos", true));
            this.textNK.DataBindings.Add(
                new Binding("Text", this.customerBindingSource, "nama_kos", true));
            this.textAlamat.DataBindings.Add(
                new Binding("Text", this.customerBindingSource, "alamat", true));
            this.textNoHp.DataBindings.Add(
                new Binding("Text", this.customerBindingSource, "no_hp", true));
            this.textKK.DataBindings.Add(
                new Binding("Text", this.customerBindingSource, "kapasitas", true));
            this.textHS.DataBindings.Add(
                new Binding("Text", this.customerBindingSource, "harga", true));
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
        private void refreshform()
        {
            textidkk.Enabled = false;
            textNK.Enabled = false;
            textAlamat.Enabled = false;
            textNoHp.Enabled = false;
            textKK.Enabled = false;
            textHS.Enabled = false;
            btnAdd.Enabled = true;
            btnSave.Enabled = false;
            btnClear.Enabled = false;
            clearBinding();
            KosKosan_Load();
        }
    }
}
