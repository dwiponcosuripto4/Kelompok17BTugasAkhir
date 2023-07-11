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
        private string stringConnection = "data source=LAPTOP-9OD41I73\\DWIPONCOS;database=Kos2;User ID=sa; Password=xm11tpro";
        private SqlConnection koneksi;
        private string idkk, namakos, alamat, nohp, kapsk, hs, pemilik;
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
            cbxPemilik.Enabled = true;
            textNK.Enabled = true;
            textAlamat.Enabled = true;
            textNoHp.Enabled = true;
            textKK.Enabled = true;
            textHS.Enabled = true;
            Pemilikcbx();
            btnSave.Enabled = true;
            btnClear.Enabled = true;
            btnAdd.Enabled = false;
        }

        private void Pemilikcbx()
        {
            koneksi.Open();
            string str = "select nama_pemilik from dbo.Pemilik";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteReader();
            koneksi.Close();
            cbxPemilik.DisplayMember = "nama_pemilik";
            cbxPemilik.ValueMember = "id_pemilik";
            cbxPemilik.DataSource = ds.Tables[0];

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            idkk = textidkk.Text;
            pemilik = cbxPemilik.Text;
            namakos = textNK.Text;
            alamat = textAlamat.Text;
            nohp = textNoHp.Text;
            kapsk = textKK.Text;
            hs = textHS.Text;
            int pm = 0;
            koneksi.Open();
            string strs = "select id_pemilik from dbo.Pemilik where nama_pemilik = @dd";
            SqlCommand cm = new SqlCommand(strs, koneksi);
            cm.CommandType = CommandType.Text;
            cm.Parameters.Add(new SqlParameter("@dd", pemilik));
            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read()) 
            {
                pm = int.Parse(dr["id_pemilik"].ToString());
            }
            dr.Close();
            string str = "insert into dbo.Kos (id_kos, id_pemilik, nama_kos, alamat, no_hp, kapasitas, harga)" + "values(@idk, @Pm, @nk, @Al, @nohp, @kaps, @hrs)";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SqlParameter("idk", idkk));
            cmd.Parameters.Add(new SqlParameter("Pm", pm));
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void KosKosan_Load()
        {
            koneksi.Open();
            SqlDataAdapter dataAdapter1 = new SqlDataAdapter(new SqlCommand("Select m.id_kos, p.nama_pemilik, "
            + "m.nama_kos, m.alamat, m.no_hp, m.kapasitas, m.harga from dbo.kos m " +
                "join dbo.Pemilik p on m.id_pemilik = p.id_pemilik", koneksi));
            DataSet ds = new DataSet();
            dataAdapter1.Fill(ds);

            this.customerBindingSource.DataSource = ds.Tables[0];
            this.textidkk.DataBindings.Add(
                new Binding("Text", this.customerBindingSource, "id_kos", true));
            this.cbxPemilik.DataBindings.Add(
                new Binding("Text", this.customerBindingSource, "nama_pemilik", true));
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
            // TODO: This line of code loads data into the 'kos2DataSet.Kos' table. You can move, or remove it, as needed.
            this.kosTableAdapter1.Fill(this.kos2DataSet.Kos);
            // TODO: This line of code loads data into the 'kosDataSet.Kos' table. You can move, or remove it, as needed.
            this.kosTableAdapter.Fill(this.kosDataSet.Kos);

        }

        private void clearBinding()
        {
            this.textidkk.DataBindings.Clear();
            this.cbxPemilik.DataBindings.Clear();
            this.textNK.DataBindings.Clear();
            this.textAlamat.DataBindings.Clear();
            this.textNoHp.DataBindings.Clear();
            this.textKK.DataBindings.Clear();
            this.textHS.DataBindings.Clear();
        }
        private void refreshform()
        {
            textidkk.Enabled = false;
            cbxPemilik.Enabled = false;
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
