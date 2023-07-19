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
    public partial class FormPemilikKos : Form
    {
        private string stringConnection = "data source=LAPTOP-9OD41I73\\DWIPONCOS;database=Kos2;User ID=sa; Password=xm11tpro";
        private SqlConnection koneksi;
        private string idpm, namapm, alamat, nohp;
        BindingSource customerBindingSource = new BindingSource();
        public FormPemilikKos()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            this.bnPemilik.BindingSource = this.customerBindingSource;
            refreshform();
        }
        private void FormPemilikKos_Load()
        {
            koneksi.Open();
            SqlDataAdapter dataAdapter1 = new SqlDataAdapter(new SqlCommand("Select m.id_pemilik, m.nama_pemilik, "
            + "m.alamat, m.no_hp From dbo.pemilik m ", koneksi));
            DataSet ds = new DataSet();
            dataAdapter1.Fill(ds);

            this.customerBindingSource.DataSource = ds.Tables[0];
            this.txtIdPemilik.DataBindings.Add(
                new Binding("Text", this.customerBindingSource, "id_pemilik", true));
            this.txtNamaPemilik.DataBindings.Add(
                new Binding("Text", this.customerBindingSource, "nama_pemilik", true));
            this.txtAlamat.DataBindings.Add(
                new Binding("Text", this.customerBindingSource, "alamat", true));
            this.txtNoHp.DataBindings.Add(
                new Binding("Text", this.customerBindingSource, "no_hp", true));
            koneksi.Close();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kos2DataSet.Pemilik' table. You can move, or remove it, as needed.
            this.pemilikTableAdapter1.Fill(this.kos2DataSet.Pemilik);
            // TODO: This line of code loads data into the 'kosDataSet.Pemilik' table. You can move, or remove it, as needed.
            this.pemilikTableAdapter.Fill(this.kosDataSet.Pemilik);

        }

        private void clearBinding()
        {
            this.txtIdPemilik.DataBindings.Clear();
            this.txtNamaPemilik.DataBindings.Clear();
            this.txtAlamat.DataBindings.Clear();
            this.txtNoHp.DataBindings.Clear();
        }

        private void refreshform()
        {
            txtIdPemilik.Enabled = false;
            txtNamaPemilik.Enabled = false;
            txtAlamat.Enabled = false;
            txtNoHp.Enabled = false;
            btnAdd.Enabled = true;
            btnSave.Enabled = false;
            btnClear.Enabled = false;
            clearBinding();
            FormPemilikKos_Load();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Aktifkan mode editing
            txtNamaPemilik.Enabled = true;
            txtAlamat.Enabled = true;
            txtNoHp.Enabled = true;

            // Nonaktifkan tombol-tombol lainnya selain Save
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnSave.Enabled = true;
            btnClear.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Get the selected id_admin from the textida TextBox
                string selectedId = txtIdPemilik.Text;

                // Perform the delete
                koneksi.Open();
                string str = "DELETE FROM dbo.Pemilik WHERE id_pemilik = @SelectedId";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.Parameters.Add(new SqlParameter("@SelectedId", selectedId));
                cmd.ExecuteNonQuery();
                koneksi.Close();

                MessageBox.Show("Data Berhasil Dihapus", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                refreshform();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            refreshform();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtIdPemilik.Text = "";
            txtNamaPemilik.Text = "";
            txtAlamat.Text = "";
            txtNoHp.Text = "";
            txtIdPemilik.Enabled = true;
            txtNamaPemilik.Enabled = true;
            txtAlamat.Enabled = true;
            txtNoHp.Enabled = true;
            btnSave.Enabled = true;
            btnClear.Enabled = true;
            btnAdd.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            idpm = txtIdPemilik.Text;
            namapm = txtNamaPemilik.Text;
            alamat = txtAlamat.Text;
            nohp = txtNoHp.Text;

            koneksi.Open();

            // Check if the ID (idpm) already exists in the database
            string checkIdQuery = "SELECT COUNT(*) FROM dbo.Pemilik WHERE id_pemilik = @Idpm";
            SqlCommand checkIdCmd = new SqlCommand(checkIdQuery, koneksi);
            checkIdCmd.Parameters.AddWithValue("@Idpm", idpm);
            int count = (int)checkIdCmd.ExecuteScalar();

            if (count > 0)
            {
                // If the ID exists, update the existing record
                string updateQuery = "UPDATE dbo.Pemilik SET nama_pemilik = @nmpm, alamat = @Al, no_hp = @nohp WHERE id_pemilik = @Idpm";
                SqlCommand updateCmd = new SqlCommand(updateQuery, koneksi);
                updateCmd.Parameters.AddWithValue("@Idpm", idpm);
                updateCmd.Parameters.AddWithValue("@nmpm", namapm);
                updateCmd.Parameters.AddWithValue("@Al", alamat);
                updateCmd.Parameters.AddWithValue("@nohp", nohp);
                updateCmd.ExecuteNonQuery();

                MessageBox.Show("Data Berhasil Diupdate", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // If the ID does not exist, insert a new record
                string insertQuery = "INSERT INTO dbo.Pemilik (id_pemilik, nama_pemilik, alamat, no_hp) VALUES (@Idpm, @nmpm, @Al, @nohp)";
                SqlCommand insertCmd = new SqlCommand(insertQuery, koneksi);
                insertCmd.Parameters.AddWithValue("@Idpm", idpm);
                insertCmd.Parameters.AddWithValue("@nmpm", namapm);
                insertCmd.Parameters.AddWithValue("@Al", alamat);
                insertCmd.Parameters.AddWithValue("@nohp", nohp);
                insertCmd.ExecuteNonQuery();

                MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            koneksi.Close();
            refreshform();
        }
    }
}


