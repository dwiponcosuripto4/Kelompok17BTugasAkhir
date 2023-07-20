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
        private string idt, idpm, idp, ad;
        private decimal harga;
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
            cbxAdmin.Enabled = false;
            btnAdd.Enabled = true;
            btnSave.Enabled = false;
            btnClear.Enabled = false;
            clearBinding();
            FormTransaksi_Load();
        }

        private void FormTransaksi_Load()
        {
            koneksi.Open();
            SqlDataAdapter dataAdapter1 = new SqlDataAdapter(new SqlCommand("SELECT m.id_transaksi, p1.nama_pemilik, " +
            "p2.nama_penyewa, m.harga, m.tanggal_masuk, m.tanggal_keluar, p3.nama_admin FROM dbo.Transaksi m " +
            "JOIN dbo.Pemilik p1 ON m.id_pemilik = p1.id_pemilik " +
            "JOIN dbo.Penyewa p2 ON m.id_penyewa = p2.id_penyewa " +
            "JOIN dbo.Admin p3 ON m.id_admin = p3.id_admin", koneksi));
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
            this.cbxAdmin.DataBindings.Add(
                new Binding("Text", this.customerBindingSource, "nama_admin", true));
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
            cbxAdmin.Text = "";
            textidt.Enabled = true;
            cbxIdPemilik.Enabled = true;
            cbxIdPenyewa.Enabled = true;
            txtHarga.Enabled = true;
            dtMasuk.Enabled = true;
            dtKeluar.Enabled = true;
            cbxAdmin.Enabled = true;
            Pemilikcbx();
            Penyewacbx();
            Admincbx();
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
        private void Admincbx()
        {
            koneksi.Open();
            string str = "select nama_admin from dbo.Admin";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteReader();
            koneksi.Close();
            cbxAdmin.DisplayMember = "nama_admin";
            cbxAdmin.ValueMember = "id_admin";
            cbxAdmin.DataSource = ds.Tables[0];
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Retrieve the updated values from input fields
            idt = textidt.Text;
            idpm = cbxIdPemilik.Text;
            idp = cbxIdPenyewa.Text;
            harga = decimal.Parse(txtHarga.Text);
            tm = dtMasuk.Value;
            tk = dtKeluar.Value;
            ad = cbxAdmin.Text;
            string im = string.Empty, ip = string.Empty, am = string.Empty;

            // Get the corresponding IDs for pemilik and penyewa
            koneksi.Open();
            string strs = "SELECT id_pemilik FROM dbo.Pemilik WHERE nama_pemilik = @dd";
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

            string strs3 = "SELECT id_admin FROM dbo.Admin WHERE nama_admin = @dd";
            SqlCommand cm3 = new SqlCommand(strs3, koneksi);
            cm3.CommandType = CommandType.Text;
            cm3.Parameters.Add(new SqlParameter("@dd", ad));
            SqlDataReader dr3 = cm3.ExecuteReader();
            while (dr3.Read())
            {
                am = dr3["id_admin"].ToString();
            }
            dr3.Close();

            // Check if the ID (idt) already exists in the database
            string checkIdQuery = "SELECT COUNT(*) FROM dbo.Transaksi WHERE id_transaksi = @Idt";
            SqlCommand checkIdCmd = new SqlCommand(checkIdQuery, koneksi);
            checkIdCmd.Parameters.AddWithValue("@Idt", idt);
            int count = (int)checkIdCmd.ExecuteScalar();

            if (count > 0)
            {
                // If the ID exists, update the existing record
                string updateQuery = "UPDATE dbo.Transaksi SET id_pemilik = @Idpm, id_penyewa = @Idp, harga = @Hrg, tanggal_masuk = @Tm, tanggal_keluar = @Tk, id_admin = @Am WHERE id_transaksi = @Idt";
                SqlCommand updateCmd = new SqlCommand(updateQuery, koneksi);
                updateCmd.Parameters.AddWithValue("@Idt", idt);
                updateCmd.Parameters.AddWithValue("@Idpm", im);
                updateCmd.Parameters.AddWithValue("@Idp", ip);
                updateCmd.Parameters.AddWithValue("@Hrg", harga);
                updateCmd.Parameters.AddWithValue("@Tm", tm);
                updateCmd.Parameters.AddWithValue("@Tk", tk);
                updateCmd.Parameters.AddWithValue("@Am", am);
                updateCmd.ExecuteNonQuery();

                MessageBox.Show("Data Berhasil Diupdate", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // If the ID does not exist, insert a new record
                string insertQuery = "INSERT INTO dbo.Transaksi (id_transaksi, id_pemilik, id_penyewa, harga, tanggal_masuk, tanggal_keluar, id_admin) VALUES (@Idt, @Idpm, @Idp, @Hrg, @Tm, @Tk, @Am)";
                SqlCommand insertCmd = new SqlCommand(insertQuery, koneksi);
                insertCmd.Parameters.AddWithValue("@Idt", idt);
                insertCmd.Parameters.AddWithValue("@Idpm", im);
                insertCmd.Parameters.AddWithValue("@Idp", ip);
                insertCmd.Parameters.AddWithValue("@Hrg", harga);
                insertCmd.Parameters.AddWithValue("@Tm", tm);
                insertCmd.Parameters.AddWithValue("@Tk", tk);
                insertCmd.Parameters.AddWithValue("@Am", am);
                insertCmd.ExecuteNonQuery();

                MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            koneksi.Close();
            refreshform();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Enable input fields for editing
            cbxIdPemilik.Enabled = true;
            cbxIdPenyewa.Enabled = true;
            txtHarga.Enabled = true;
            dtMasuk.Enabled = true;
            dtKeluar.Enabled = true;
            cbxAdmin.Enabled = true;

            // Disable unnecessary buttons
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnSave.Enabled = true;
            btnClear.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Get the selected id_transaksi from the textidt TextBox
                string selectedId = textidt.Text;

                // Perform the delete
                koneksi.Open();
                string str = "DELETE FROM dbo.Transaksi WHERE id_transaksi = @SelectedId";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.Parameters.Add(new SqlParameter("@SelectedId", selectedId));
                cmd.ExecuteNonQuery();
                koneksi.Close();

                MessageBox.Show("Data Berhasil Dihapus", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                refreshform();
            }
        }

        private void clearBinding()
        {
            this.textidt.DataBindings.Clear();
            this.cbxIdPemilik.DataBindings.Clear();
            this.cbxIdPenyewa.DataBindings.Clear();
            this.txtHarga.DataBindings.Clear();
            this.dtMasuk.DataBindings.Clear();
            this.dtKeluar.DataBindings.Clear();
            this.cbxAdmin.DataBindings.Clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kos22.Transaksi' table. You can move, or remove it, as needed.
            this.transaksiTableAdapter7.Fill(this.kos22.Transaksi);
            // TODO: This line of code loads data into the 'kos2fix.Transaksi' table. You can move, or remove it, as needed.
            this.transaksiTableAdapter6.Fill(this.kos2fix.Transaksi);

        }
    }
}
