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
using static System.Net.Mime.MediaTypeNames;

namespace Kelompok17BTugasAkhir
{
    public partial class admin : Form
    {
        private string stringConnection = "data source=LAPTOP-9OD41I73\\DWIPONCOS;database=Kos2;User ID=sa; Password=xm11tpro";
        private SqlConnection koneksi;
        private string ida, nma, nohp, usern, pssw;
        BindingSource customerBindingSource = new BindingSource();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            textida.Text = "";
            textnma.Text = "";
            textnohp.Text = "";
            textuser.Text = "";
            textpsw.Text = "";
            textida.Enabled = true;
            textnma.Enabled = true;
            textnohp.Enabled = true;
            textuser.Enabled = true;
            textpsw.Enabled = true;
            btnSave.Enabled = true;
            btnClear.Enabled = true;
            btnAdd.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ida = textida.Text;
            nma = textnma.Text;
            nohp = textnohp.Text;
            usern = textuser.Text;
            pssw = textpsw.Text;

            koneksi.Open();

            // Check if the ID (ida) already exists in the database
            string checkIdQuery = "SELECT COUNT(*) FROM dbo.Admin WHERE id_admin = @Ida";
            SqlCommand checkIdCmd = new SqlCommand(checkIdQuery, koneksi);
            checkIdCmd.Parameters.AddWithValue("@Ida", ida);
            int count = (int)checkIdCmd.ExecuteScalar();

            if (count > 0)
            {
                // If the ID exists, update the existing record
                string updateQuery = "UPDATE dbo.Admin SET nama_admin = @Nma, no_hp = @nohp, username = @Usr, password = @Pw WHERE id_admin = @Ida";
                SqlCommand updateCmd = new SqlCommand(updateQuery, koneksi);
                updateCmd.Parameters.AddWithValue("@Ida", ida);
                updateCmd.Parameters.AddWithValue("@Nma", nma);
                updateCmd.Parameters.AddWithValue("@nohp", nohp);
                updateCmd.Parameters.AddWithValue("@Usr", usern);
                updateCmd.Parameters.AddWithValue("@Pw", pssw);
                updateCmd.ExecuteNonQuery();

                MessageBox.Show("Data Berhasil Diupdate", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // If the ID does not exist, insert a new record
                string insertQuery = "INSERT INTO dbo.Admin (id_admin, nama_admin, no_hp, username, password) VALUES (@Ida, @Nma, @nohp, @Usr, @Pw)";
                SqlCommand insertCmd = new SqlCommand(insertQuery, koneksi);
                insertCmd.Parameters.AddWithValue("@Ida", ida);
                insertCmd.Parameters.AddWithValue("@Nma", nma);
                insertCmd.Parameters.AddWithValue("@nohp", nohp);
                insertCmd.Parameters.AddWithValue("@Usr", usern);
                insertCmd.Parameters.AddWithValue("@Pw", pssw);
                insertCmd.ExecuteNonQuery();

                MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            koneksi.Close();
            refreshform();
        }

        public admin()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            this.bnadmin.BindingSource = this.customerBindingSource;
            refreshform();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kos2DataSet.Admin' table. You can move, or remove it, as needed.
            this.adminTableAdapter1.Fill(this.kos2DataSet.Admin);
            // TODO: This line of code loads data into the 'kosDataSet.Admin' table. You can move, or remove it, as needed.
            this.adminTableAdapter.Fill(this.kosDataSet.Admin);

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            refreshform();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Aktifkan mode editing
            textnma.Enabled = true;
            textnohp.Enabled = true;
            textuser.Enabled = true;
            textpsw.Enabled = true;

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
                string selectedId = textida.Text;

                // Perform the delete
                koneksi.Open();
                string str = "DELETE FROM dbo.Admin WHERE id_admin = @SelectedId";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.Parameters.Add(new SqlParameter("@SelectedId", selectedId));
                cmd.ExecuteNonQuery();
                koneksi.Close();

                MessageBox.Show("Data Berhasil Dihapus", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                refreshform();
            }
        }

        private void admin_Load()
        {
            koneksi.Open();
            SqlDataAdapter dataAdapter1 = new SqlDataAdapter(new SqlCommand("Select m.id_admin, m.nama_admin, "
            + "m.no_hp, username, password From dbo.Admin m ", koneksi));
            DataSet ds = new DataSet();
            dataAdapter1.Fill(ds);

            this.customerBindingSource.DataSource = ds.Tables[0];
            this.textida.DataBindings.Add(
                new Binding("Text", this.customerBindingSource, "id_admin", true));
            this.textnma.DataBindings.Add(
                new Binding("Text", this.customerBindingSource, "nama_admin", true));
            this.textnohp.DataBindings.Add(
                new Binding("Text", this.customerBindingSource, "no_hp", true));
            this.textuser.DataBindings.Add(
                new Binding("Text", this.customerBindingSource, "username", true));
            this.textpsw.DataBindings.Add(
                new Binding("Text", this.customerBindingSource, "password", true));
            koneksi.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearBinding()
        {
            this.textida.DataBindings.Clear();
            this.textnma.DataBindings.Clear();
            this.textnohp.DataBindings.Clear();
            this.textuser.DataBindings.Clear();
            this.textpsw.DataBindings.Clear();
        }

        private void refreshform()
        {
            textida.Enabled = false;
            textnma.Enabled = false;
            textnohp.Enabled = false;
            textuser.Enabled = false;
            textpsw.Enabled = false;
            btnAdd.Enabled = true;
            btnSave.Enabled = false;
            btnClear.Enabled = false;
            clearBinding();
            admin_Load();
        }
    }
}
