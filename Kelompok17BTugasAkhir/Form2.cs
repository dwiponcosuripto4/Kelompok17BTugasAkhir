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

namespace Kelompok17BTugasAkhir
{
    public partial class Form2 : Form
    {
        private string stringConnection = "data source=LAPTOP-9OD41I73\\DWIPONCOS;database=Kos;User ID=sa; Password=xm11tpro";
        private SqlConnection koneksi;
        BindingSource customerBindingSource = new BindingSource();
        public Form2()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
        }

        private void Form2_Load(object sender, EventArgs e)
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

        private void clearBinding()
        {
            this.txtIdPemilik.DataBindings.Clear();
            this.txtNamaPemilik.DataBindings.Clear();
            this.txtAlamat.DataBindings.Clear();
            this.txtAlamat.DataBindings.Clear();
            this.txtNoHp.DataBindings.Clear();
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
