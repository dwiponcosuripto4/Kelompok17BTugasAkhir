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
        private string stringConnection = "data source=LAPTOP-9OD41I73\\DWIPONCOS;database=Kos;User ID=sa; Password=xm11tpro";
        private SqlConnection koneksi;
        private string idkmr, idkk, fasilitas, hrga, status;
        BindingSource customerBindingSource = new BindingSource();

        private void FormKamar_Load(object sender, EventArgs e)
        {

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
            txtIdKos.Text = "";
            txtFasilitas.Text = "";
            txtHargaSewa.Text = "";
            txtStatus.Text = "";
            txtIdKamar.Enabled = true;
            txtIdKos.Enabled = true;
            txtFasilitas.Enabled = true;
            txtHargaSewa.Enabled = true;
            btnSave.Enabled = true;
            btnClear.Enabled = true;
            btnAdd.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            idkmr = txtIdKamar.Text;
            idkk = txtIdKos.Text;
            fasilitas = txtFasilitas.Text;
            hrga = txtHargaSewa.Text;
            koneksi.Open();
            string str = "insert into dbo.Pemilik (id_pemilik, nama_pemilik, alamat, no_hp)" + "values(@idpm, @nmpm, @Al, @nohp)";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SqlParameter("idpm", idkmr));
            cmd.Parameters.Add(new SqlParameter("nmpm", idkk));
            cmd.Parameters.Add(new SqlParameter("AL", fasilitas));
            cmd.Parameters.Add(new SqlParameter("nohp", hrga));
            cmd.Parameters.Add(new SqlParameter("nohp", status));
            cmd.ExecuteNonQuery();

            koneksi.Close();

            MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

            refreshform();
        }

        private void FormKamar_Load()
        {
            koneksi.Open();
            SqlDataAdapter dataAdapter1 = new SqlDataAdapter(new SqlCommand("Select m.id_pemilik, m.nama_pemilik, "
            + "m.alamat, m.no_hp From dbo.pemilik m ", koneksi));
            DataSet ds = new DataSet();
            dataAdapter1.Fill(ds);

            this.customerBindingSource.DataSource = ds.Tables[0];
            this.txtIdKamar.DataBindings.Add(
                new Binding("Text", this.customerBindingSource, "id_pemilik", true));
            this.txtIdKos.DataBindings.Add(
                new Binding("Text", this.customerBindingSource, "nama_pemilik", true));
            this.txtFasilitas.DataBindings.Add(
                new Binding("Text", this.customerBindingSource, "alamat", true));
            this.txtHargaSewa.DataBindings.Add(
                new Binding("Text", this.customerBindingSource, "no_hp", true));
            this.txtStatus.DataBindings.Add(
                new Binding("Text", this.customerBindingSource, "no_hp", true));
            koneksi.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearBinding()
        {
            this.txtIdKamar.DataBindings.Clear();
            this.txtIdKos.DataBindings.Clear();
            this.txtFasilitas.DataBindings.Clear();
            this.txtHargaSewa.DataBindings.Clear();
            this.txtStatus.DataBindings.Clear();
        }

        private void refreshform()
        {
            txtIdKamar.Enabled = false;
            txtIdKos.Enabled = false;
            txtFasilitas.Enabled = false;
            txtHargaSewa.Enabled = false;
            btnAdd.Enabled = true;
            btnSave.Enabled = false;
            btnClear.Enabled = false;
            clearBinding();
            FormKamar_Load();
        }
    }
}
