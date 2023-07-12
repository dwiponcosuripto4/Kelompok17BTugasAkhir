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
    public partial class FormTransaksi : Form
    {
        private string stringConnection = "data source=LAPTOP-9OD41I73\\DWIPONCOS;database=Kos2;User ID=sa; Password=xm11tpro";
        private SqlConnection koneksi;
        private string idt, harga, idpm, idp;
        private DateTime tm, tk;
        BindingSource customerBindingSource = new BindingSource();

        private void bntransaksi_RefreshItems(object sender, EventArgs e)
        {

        }

        public FormTransaksi()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            this.bntransaksi.BindingSource = this.customerBindingSource;
            refreshform();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            refreshform();
        }


        private void refreshform()
        {
            textidt.Enabled = false;
            cbxIdPemilik.Enabled = false;
            cbxIdPenyewa.Enabled = false;
            txtHarga.Enabled = false;
            dtMasuk.Enabled = false;
            dtKeluar.Enabled = false;
            btnAdd.Enabled = true;
            btnSave.Enabled = false;
            btnClear.Enabled = false;
            clearBinding();
            FormTransaksi_Load();
        }

        private void FormTransaksi_Load()
        {
            koneksi.Open();
            SqlDataAdapter dataAdapter1 = new SqlDataAdapter(new SqlCommand("SELECT m.id_transaksi, p1.nama_pemilik, "
                + "p2.nama_penyewa, m.harga, m.tanggal_masuk, m.tanggal_keluar FROM dbo.Transaksi m " +
                "JOIN dbo.Pemilik p1 ON m.id_pemilik = p1.id_pemilik " +
                "JOIN dbo.Penyewa p2 ON m.id_penyewa = p2.id_penyewa", koneksi));
            DataSet ds = new DataSet();
            dataAdapter1.Fill(ds);

            this.customerBindingSource.DataSource = ds.Tables[0];
            this.textidt.DataBindings.Add(
                new Binding("Text", this.customerBindingSource, "id_transaksi", true));
            this.cbxIdPemilik.DataBindings.Add(
                new Binding("Text", this.customerBindingSource, "nama_pemilik", true));
            this.cbxIdPenyewa.DataBindings.Add(
                new Binding("Text", this.customerBindingSource, "nama_penyewa", true));
            this.txtHarga.DataBindings.Add(
                new Binding("Text", this.customerBindingSource, "harga", true));
            this.dtMasuk.DataBindings.Add(
                new Binding("Text", this.customerBindingSource, "tanggal_masuk", true));
            this.dtKeluar.DataBindings.Add(
                new Binding("Text", this.customerBindingSource, "tanggal_keluar", true));
            koneksi.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            textidt.Text = "";
            cbxIdPemilik.Text = "";
            cbxIdPenyewa.Text = "";
            txtHarga.Text = "";
            dtMasuk.Text = "";
            dtKeluar.Text = "";
            textidt.Enabled = true;
            cbxIdPemilik.Enabled = true;
            cbxIdPenyewa.Enabled = true;
            txtHarga.Enabled = true;
            dtMasuk.Enabled = true;
            dtKeluar.Enabled = true;
            Pemilikcbx();
            Penyewacbx();
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
            cbxIdPemilik.DisplayMember = "nama_pemilik";
            cbxIdPemilik.ValueMember = "id_pemilik";
            cbxIdPemilik.DataSource = ds.Tables[0];

        }

        private void Penyewacbx()
        {
            koneksi.Open();
            string str = "select nama_penyewa from dbo.Penyewa";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteReader();
            koneksi.Close();
            cbxIdPenyewa.DisplayMember = "nama_penyewa";
            cbxIdPenyewa.ValueMember = "id_penyewa";
            cbxIdPenyewa.DataSource = ds.Tables[0];

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            idt = textidt.Text;
            idpm = cbxIdPemilik.Text;
            idp = cbxIdPenyewa.Text;
            harga = txtHarga.Text;
            tm = dtMasuk.Value;
            tk = dtKeluar.Value;
            string im = string.Empty, ip = string.Empty;
            koneksi.Open();
            string strs = "select id_pemilik from dbo.Pemilik where nama_pemilik = @dd";
            SqlCommand cm = new SqlCommand(strs, koneksi);
            cm.CommandType = CommandType.Text;
            cm.Parameters.Add(new SqlParameter("@dd", idpm));
            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                im = dr["id_pemilik"].ToString();
            }
            dr.Close();
            string strs2 = "SELECT id_penyewa FROM dbo.Penyewa WHERE nama_penyewa = @dd";
            SqlCommand cm2 = new SqlCommand(strs2, koneksi);
            cm2.CommandType = CommandType.Text;
            cm2.Parameters.Add(new SqlParameter("@dd", idp));
            SqlDataReader dr2 = cm2.ExecuteReader();
            while (dr2.Read())
            {
                ip = dr2["id_penyewa"].ToString();
            }
            dr2.Close();
            string str = "insert into dbo.Transaksi (id_transaksi, id_pemilik, id_penyewa, harga, tanggal_masuk, tanggal_keluar)" + "values(@Idt, @Idpm, @Idp, @Hrg, @Tm, @Tk)";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SqlParameter("Idt", idt));
            cmd.Parameters.Add(new SqlParameter("Idpm", im));
            cmd.Parameters.Add(new SqlParameter("Idp", ip));
            cmd.Parameters.Add(new SqlParameter("Hrg", harga));
            cmd.Parameters.Add(new SqlParameter("Tm", tm));
            cmd.Parameters.Add(new SqlParameter("Tk", tk));
            cmd.ExecuteNonQuery();

            koneksi.Close();

            MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

            refreshform();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearBinding()
        {
            this.textidt.DataBindings.Clear();
            this.cbxIdPemilik.DataBindings.Clear();
            this.cbxIdPenyewa.DataBindings.Clear();
            this.txtHarga.DataBindings.Clear();
            this.dtMasuk.DataBindings.Clear();
            this.dtKeluar.DataBindings.Clear();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kos2DataSet2.Transaksi' table. You can move, or remove it, as needed.
            this.transaksiTableAdapter5.Fill(this.kos2DataSet2.Transaksi);
            // TODO: This line of code loads data into the 'kosDataSet3.Transaksi' table. You can move, or remove it, as needed.
            this.transaksiTableAdapter2.Fill(this.kosDataSet3.Transaksi);
            // TODO: This line of code loads data into the 'kosDataSet2.Transaksi' table. You can move, or remove it, as needed.
            this.transaksiTableAdapter1.Fill(this.kosDataSet2.Transaksi);

        }
    }
}
