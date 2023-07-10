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
        private string stringConnection = "data source=LAPTOP-9OD41I73\\DWIPONCOS;database=Kos;User ID=sa; Password=xm11tpro";
        private SqlConnection koneksi;
        BindingSource customerBindingSource = new BindingSource();
        public FormPemilikKos()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
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

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
