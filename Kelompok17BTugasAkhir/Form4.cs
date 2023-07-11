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
        private string idkmr, idkk, fasilitas, hrga, sts;
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
            hrga = txtHargaSewa.Text;
            sts = txtStatus.Text;
            idkk = cbxKos.Text;
            int hs = 0;
            koneksi.Open();
            string strs = "select id_kos from dbo.Kos where nama_kos = @dd";
            SqlCommand cm = new SqlCommand(strs, koneksi);
            cm.CommandType = CommandType.Text;
            cm.Parameters.Add(new SqlParameter("@dd", idkk));
            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                hs = int.Parse(dr["id_kos"].ToString());
            }
            dr.Close();
            string str = "insert into dbo.Kamar (id_kamar, fasilitas, harga, status, id_kos)" + "values(@idkmr, @Fa, @Hrg, @Status, @Idkk)";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SqlParameter("idkmr", idkmr));
            cmd.Parameters.Add(new SqlParameter("Fa", fasilitas));
            cmd.Parameters.Add(new SqlParameter("Hrg", hrga));
            cmd.Parameters.Add(new SqlParameter("Status", sts));
            cmd.Parameters.Add(new SqlParameter("Idkk", hs));
            cmd.ExecuteNonQuery();

            koneksi.Close();

            MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
