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
        private string stringConnection = "data source=LAPTOP-9OD41I73\\DWIPONCOS;database=Kos;User ID=sa; Password=xm11tpro";
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
            string str = "insert into dbo.Admin (id_admin, nama_admin, no_hp, username, password)" + "values(@Ida, @Nma, @nohp, @Usr, @Pw)";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SqlParameter("Ida", ida));
            cmd.Parameters.Add(new SqlParameter("Nma", nma));
            cmd.Parameters.Add(new SqlParameter("nohp", nohp));
            cmd.Parameters.Add(new SqlParameter("Usr", usern));
            cmd.Parameters.Add(new SqlParameter("Pw", pssw));
            cmd.ExecuteNonQuery();

            koneksi.Close();

            MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            refreshform();
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
