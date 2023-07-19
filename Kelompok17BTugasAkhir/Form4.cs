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
    public partial class FormKamar : Form
    {
        private string stringConnection = "data source=LAPTOP-9OD41I73\\DWIPONCOS;database=Kos2;User ID=sa; Password=xm11tpro";
        private SqlConnection koneksi;
        private string idkmr, idkk, fasilitas, sts;
        private decimal hrga;
        BindingSource customerBindingSource = new BindingSource();

        private void FormKamar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kos2fix.Kamar' table. You can move, or remove it, as needed.
            this.kamarTableAdapter3.Fill(this.kos2fix.Kamar);
            // TODO: This line of code loads data into the 'kos2DataSet.Kamar' table. You can move, or remove it, as needed.
            this.kamarTableAdapter2.Fill(this.kos2DataSet.Kamar);
            // TODO: This line of code loads data into the 'kosDataSet1.Kamar' table. You can move, or remove it, as needed.
            this.kamarTableAdapter1.Fill(this.kosDataSet1.Kamar);
            // TODO: This line of code loads data into the 'kosDataSet.Penyewa' table. You can move, or remove it, as needed.
            this.penyewaTableAdapter.Fill(this.kosDataSet.Penyewa);

        }

        public FormKamar()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            this.bnKamar.BindingSource = this.customerBindingSource;
            refreshform();
        }

        private void bnKamar_RefreshItems(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            refreshform();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtIdKamar.Text = "";
            cbxKos.Text = "";
            txtFasilitas.Text = "";
            txtHargaSewa.Text = "";
            txtStatus.Text = "";
            txtIdKamar.Enabled = true;
            cbxKos.Enabled = true;
            txtFasilitas.Enabled = true;
            txtHargaSewa.Enabled = true;
            txtStatus.Enabled = true;
            Koscbx();
            btnSave.Enabled = true;
            btnClear.Enabled = true;
            btnAdd.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            idkmr = txtIdKamar.Text;
            fasilitas = txtFasilitas.Text;
            hrga = decimal.Parse(txtHargaSewa.Text);
            sts = txtStatus.Text;
            idkk = cbxKos.Text;

            string hs = string.Empty;
            koneksi.Open();
            string strs = "select id_kos from dbo.Kos where nama_kos = @dd";
            SqlCommand cm = new SqlCommand(strs, koneksi);
            cm.CommandType = CommandType.Text;
            cm.Parameters.Add(new SqlParameter("@dd", idkk));
            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                hs = dr["id_kos"].ToString();
            }
            dr.Close();

            // Check if the ID (idkmr) already exists in the database
            string checkIdQuery = "SELECT COUNT(*) FROM dbo.Kamar WHERE id_kamar = @Idkmr";
            SqlCommand checkIdCmd = new SqlCommand(checkIdQuery, koneksi);
            checkIdCmd.Parameters.AddWithValue("@Idkmr", idkmr);
            int count = (int)checkIdCmd.ExecuteScalar();

            if (count > 0)
            {
                // If the ID exists, update the existing record
                string updateQuery = "UPDATE dbo.Kamar SET fasilitas = @Fa, harga = @Hrg, status = @Status, id_kos = @Idkk WHERE id_kamar = @Idkmr";
                SqlCommand updateCmd = new SqlCommand(updateQuery, koneksi);
                updateCmd.Parameters.AddWithValue("@Idkmr", idkmr);
                updateCmd.Parameters.AddWithValue("@Fa", fasilitas);
                updateCmd.Parameters.AddWithValue("@Hrg", hrga);
                updateCmd.Parameters.AddWithValue("@Status", sts);
                updateCmd.Parameters.AddWithValue("@Idkk", hs);
                updateCmd.ExecuteNonQuery();

                MessageBox.Show("Data Berhasil Diupdate", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // If the ID does not exist, insert the new record
                string insertQuery = "INSERT INTO dbo.Kamar (id_kamar, fasilitas, harga, status, id_kos) VALUES (@Idkmr, @Fa, @Hrg, @Status, @Idkk)";
                SqlCommand insertCmd = new SqlCommand(insertQuery, koneksi);
                insertCmd.Parameters.AddWithValue("@Idkmr", idkmr);
                insertCmd.Parameters.AddWithValue("@Fa", fasilitas);
                insertCmd.Parameters.AddWithValue("@Hrg", hrga);
                insertCmd.Parameters.AddWithValue("@Status", sts);
                insertCmd.Parameters.AddWithValue("@Idkk", hs);
                insertCmd.ExecuteNonQuery();

                MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            koneksi.Close();
            refreshform();
        }

        private void FormKamar_Load()
        {
            koneksi.Open();
            SqlDataAdapter dataAdapter1 = new SqlDataAdapter(new SqlCommand("Select m.id_kamar, m.fasilitas, "
            + "m.harga, m.status, p.nama_kos From dbo.Kamar m " +
            "join dbo.Kos p on m.id_kos = p.id_kos", koneksi));
            DataSet ds = new DataSet();
            dataAdapter1.Fill(ds);

            this.customerBindingSource.DataSource = ds.Tables[0];
            this.txtIdKamar.DataBindings.Add(
                new Binding("Text", this.customerBindingSource, "id_kamar", true));
            this.txtFasilitas.DataBindings.Add(
                new Binding("Text", this.customerBindingSource, "fasilitas", true));
            this.txtHargaSewa.DataBindings.Add(
                new Binding("Text", this.customerBindingSource, "harga", true));
            this.txtStatus.DataBindings.Add(
                new Binding("Text", this.customerBindingSource, "status", true));
            this.cbxKos.DataBindings.Add(
                new Binding("Text", this.customerBindingSource, "nama_kos", true));
            koneksi.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Aktifkan mode editing
            txtFasilitas.Enabled = true;
            txtHargaSewa.Enabled = true;
            txtStatus.Enabled = true;
            cbxKos.Enabled = true;

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
                // Get the selected id_transaksi from the textidt TextBox
                string selectedId = txtIdKamar.Text;

                // Perform the delete
                koneksi.Open();
                string str = "DELETE FROM dbo.Kamar WHERE id_kamar = @SelectedId";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.Parameters.Add(new SqlParameter("@SelectedId", selectedId));
                cmd.ExecuteNonQuery();
                koneksi.Close();

                MessageBox.Show("Data Berhasil Dihapus", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                refreshform();
            }
        }

        private void Koscbx()
        {
            koneksi.Open();
            string str = "select nama_kos from dbo.Kos";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteReader();
            koneksi.Close();
            cbxKos.DisplayMember = "nama_kos";
            cbxKos.ValueMember = "id_kos";
            cbxKos.DataSource = ds.Tables[0];

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearBinding()
        {
            this.txtIdKamar.DataBindings.Clear();
            this.cbxKos.DataBindings.Clear();
            this.txtFasilitas.DataBindings.Clear();
            this.txtHargaSewa.DataBindings.Clear();
            this.txtStatus.DataBindings.Clear();
        }

        private void refreshform()
        {
            txtIdKamar.Enabled = false;
            cbxKos.Enabled = false;
            txtFasilitas.Enabled = false;
            txtHargaSewa.Enabled = false;
            txtStatus.Enabled = false;
            btnAdd.Enabled = true;
            btnSave.Enabled = false;
            btnClear.Enabled = false;
            clearBinding();
            FormKamar_Load();
        }
    }
}
