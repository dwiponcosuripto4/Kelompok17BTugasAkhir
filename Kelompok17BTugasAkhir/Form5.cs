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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kelompok17BTugasAkhir
{
    public partial class FormPenyewa : Form
    {
        private string stringConnection = "data source=LAPTOP-9OD41I73\\DWIPONCOS;database=Kos2;User ID=sa; Password=xm11tpro";
        private SqlConnection koneksi;
        private string idp, np, idk, alamat, NoHp ;
        BindingSource customerBindingSource = new BindingSource();

        public FormPenyewa()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            this.bnpenyewa.BindingSource = this.customerBindingSource;
            refreshform();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            textidp.Text = "";
            textnp.Text = "";
            textalamat.Text = "";
            textNoHp.Text = "";
            cbxKamar.Text = "";
            textidp.Enabled = true;
            textnp.Enabled = true;
            textalamat.Enabled = true;
            textNoHp.Enabled = true;
            Kamarcbx();
            btnSave.Enabled = true;
            btnClear.Enabled = true;
            cbxKamar.Enabled = true;
            btnAdd.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            idp = textidp.Text;
            np = textnp.Text;
            alamat = textalamat.Text;
            NoHp = textNoHp.Text;
            idk = cbxKamar.Text;

            int hs = 0;
            koneksi.Open();
            string strs = "select id_kamar from dbo.Kamar where fasilitas = @dd";
            SqlCommand cm = new SqlCommand(strs, koneksi);
            cm.CommandType = CommandType.Text;
            cm.Parameters.Add(new SqlParameter("@dd", idk));
            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                hs = int.Parse(dr["id_kamar"].ToString());
            }
            dr.Close();

            string str = "insert into dbo.Penyewa (id_penyewa, nama_penyewa, alamat, no_hp, id_kamar)" + "values(@idp, @np, @Al, @nohp, @kmr)";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SqlParameter("idp", idp));
            cmd.Parameters.Add(new SqlParameter("np", np));
            cmd.Parameters.Add(new SqlParameter("Al", alamat));
            cmd.Parameters.Add(new SqlParameter("nohp", NoHp));
            cmd.Parameters.Add(new SqlParameter("kmr", hs));
            cmd.ExecuteNonQuery();

            koneksi.Close();

            MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

            refreshform();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            refreshform();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kos2DataSet.Penyewa' table. You can move, or remove it, as needed.
            this.penyewaTableAdapter1.Fill(this.kos2DataSet.Penyewa);
            // TODO: This line of code loads data into the 'kosDataSet.Penyewa' table. You can move, or remove it, as needed.
            this.penyewaTableAdapter.Fill(this.kosDataSet.Penyewa);

        }

        private void FormPenyewa_Load()
        {
            koneksi.Open();
            SqlDataAdapter dataAdapter1 = new SqlDataAdapter(new SqlCommand("Select m.id_penyewa, m.nama_penyewa, "
            + "m.alamat, m.no_hp, p.fasilitas From dbo.penyewa m " +
            "join dbo.Kamar p on m.id_kamar = p.id_kamar", koneksi));
            DataSet ds = new DataSet();
            dataAdapter1.Fill(ds);

            this.customerBindingSource.DataSource = ds.Tables[0];
            this.textidp.DataBindings.Add(
                new Binding("Text", this.customerBindingSource, "id_penyewa", true));
            this.textnp.DataBindings.Add(
                new Binding("Text", this.customerBindingSource, "nama_penyewa", true));
            this.textalamat.DataBindings.Add(
                new Binding("Text", this.customerBindingSource, "alamat", true));
            this.textNoHp.DataBindings.Add(
                new Binding("Text", this.customerBindingSource, "no_hp", true));
            this.cbxKamar.DataBindings.Add(
                new Binding("Text", this.customerBindingSource, "fasilitas", true));
            koneksi.Close();
        }

        private void clearBinding()
        {
            this.textidp.DataBindings.Clear();
            this.textnp.DataBindings.Clear();
            this.textalamat.DataBindings.Clear();
            this.textNoHp.DataBindings.Clear();
            this.cbxKamar.DataBindings.Clear();
        }

        private void refreshform()
        {
            textidp.Enabled = false;
            textnp.Enabled = false;
            textalamat.Enabled = false;
            textNoHp.Enabled = false;
            cbxKamar.Enabled = false;
            btnAdd.Enabled = true;
            btnSave.Enabled = false;
            btnClear.Enabled = false;
            clearBinding();
            FormPenyewa_Load();
        }

        private void Kamarcbx()
        {
            koneksi.Open();
            string str = "select fasilitas from dbo.Kamar";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteReader();
            koneksi.Close();
            cbxKamar.DisplayMember = "fasilitas";
            cbxKamar.ValueMember = "id_kamar";
            cbxKamar.DataSource = ds.Tables[0];

        }
    }
}
