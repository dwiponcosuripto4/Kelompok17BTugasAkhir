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
using static System.Net.Mime.MediaTypeNames;

namespace Kelompok17BTugasAkhir
{
    public partial class admin : Form
    {
        private string stringConnection = "data source=LAPTOP-9OD41I73\\DWIPONCOS;database=Kos;User ID=sa; Password=xm11tpro";
        private SqlConnection koneksi;
        private string idka, idko, nohp, usern, pssw;
        BindingSource customerBindingSource = new BindingSource();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            textidka.Text = "";
            textidko.Text = "";
            textnohp.Text = "";
            textuser.Text = "";
            textpsw.Text = "";
            textidka.Enabled = true;
            textidko.Enabled = true;
            textnohp.Enabled = true;
            textuser.Enabled = true;
            textpsw.Enabled = true;
            btnSave.Enabled = true;
            btnClear.Enabled = true;
            btnAdd.Enabled = false;
        }

        public admin()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            this.bnadmin.BindingSource = this.customerBindingSource;
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void admin_Load()
        {
            koneksi.Open();
            SqlDataAdapter dataAdapter1 = new SqlDataAdapter(new SqlCommand("Select m.id_kos, m.nama_kos, "
            + "m.alamat, m.no_hp, kapasitas, harga From dbo.Kos m ", koneksi));
            DataSet ds = new DataSet();
            dataAdapter1.Fill(ds);

            this.customerBindingSource.DataSource = ds.Tables[0];
            this.textidka.DataBindings.Add(
                new Binding("Text", this.customerBindingSource, "id_koskosan", true));
            this.textidko.DataBindings.Add(
                new Binding("Text", this.customerBindingSource, "nama_kos", true));
            this.textnohp.DataBindings.Add(
                new Binding("Text", this.customerBindingSource, "alamat", true));
            this.textuser.DataBindings.Add(
                new Binding("Text", this.customerBindingSource, "no_hp", true));
            this.textpsw.DataBindings.Add(
                new Binding("Text", this.customerBindingSource, "kapasitas_kamar", true));
            koneksi.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
