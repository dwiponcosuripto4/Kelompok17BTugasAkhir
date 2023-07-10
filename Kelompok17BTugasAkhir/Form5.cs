﻿using System;
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
        private string stringConnection = "data source=LAPTOP-9OD41I73\\DWIPONCOS;database=Kos;User ID=sa; Password=xm11tpro";
        private SqlConnection koneksi;
        private string idp, np, alamat, NoHp ;
        BindingSource customerBindingSource = new BindingSource();

        public FormPenyewa()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            this.bnpenyewa.BindingSource = this.customerBindingSource;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            textidp.Text = "";
            textnp.Text = "";
            textalamat.Text = "";
            textNoHp.Text = "";
            textidp.Enabled = true;
            textnp.Enabled = true;
            textalamat.Enabled = true;
            textNoHp.Enabled = true;
            btnSave.Enabled = true;
            btnClear.Enabled = true;
            btnAdd.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            idp = textidp.Text;
            np = textnp.Text;
            alamat = textalamat.Text;
            NoHp = textNoHp.Text;
            koneksi.Open();
            string str = "insert into dbo.Pemilik (id_pemilik, nama_pemilik, alamat, no_hp)" + "values(@idpm, @nmpm, @Al, @nohp)";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SqlParameter("idp", idp));
            cmd.Parameters.Add(new SqlParameter("np", np));
            cmd.Parameters.Add(new SqlParameter("Al", alamat));
            cmd.Parameters.Add(new SqlParameter("nohp", NoHp));
            cmd.ExecuteNonQuery();

            koneksi.Close();

            MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void FormPenyewa_Load()
        {
            koneksi.Open();
            SqlDataAdapter dataAdapter1 = new SqlDataAdapter(new SqlCommand("Select m.id_pemilik, m.nama_pemilik, "
            + "m.alamat, m.no_hp From dbo.pemilik m ", koneksi));
            DataSet ds = new DataSet();
            dataAdapter1.Fill(ds);

            this.customerBindingSource.DataSource = ds.Tables[0];
            this.textidp.DataBindings.Add(
                new Binding("Text", this.customerBindingSource, "id_Penyewa", true));
            this.textnp.DataBindings.Add(
                new Binding("Text", this.customerBindingSource, "nama_Penyewa", true));
            this.textalamat.DataBindings.Add(
                new Binding("Text", this.customerBindingSource, "alamat", true));
            this.textNoHp.DataBindings.Add(
                new Binding("Text", this.customerBindingSource, "no_hp", true));
            koneksi.Close();
        }
    }
}
