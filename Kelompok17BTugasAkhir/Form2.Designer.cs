﻿namespace Kelompok17BTugasAkhir
{
    partial class FormPemilikKos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPemilikKos));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdPemilik = new System.Windows.Forms.TextBox();
            this.txtNamaPemilik = new System.Windows.Forms.TextBox();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.txtNoHp = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idpemilikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namapemilikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nohpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pemilikBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kos2DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kos2DataSet = new Kelompok17BTugasAkhir.Kos2DataSet();
            this.pemilikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kosDataSet = new Kelompok17BTugasAkhir.KosDataSet();
            this.bnPemilik = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.pemilikTableAdapter = new Kelompok17BTugasAkhir.KosDataSetTableAdapters.PemilikTableAdapter();
            this.pemilikTableAdapter1 = new Kelompok17BTugasAkhir.Kos2DataSetTableAdapters.PemilikTableAdapter();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pemilikBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kos2DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kos2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pemilikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnPemilik)).BeginInit();
            this.bnPemilik.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(527, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id_Pemilik";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(527, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama Pemilik";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(527, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Alamat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(529, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "No Hp";
            // 
            // txtIdPemilik
            // 
            this.txtIdPemilik.Location = new System.Drawing.Point(637, 35);
            this.txtIdPemilik.Name = "txtIdPemilik";
            this.txtIdPemilik.Size = new System.Drawing.Size(100, 20);
            this.txtIdPemilik.TabIndex = 4;
            // 
            // txtNamaPemilik
            // 
            this.txtNamaPemilik.Location = new System.Drawing.Point(637, 67);
            this.txtNamaPemilik.Name = "txtNamaPemilik";
            this.txtNamaPemilik.Size = new System.Drawing.Size(100, 20);
            this.txtNamaPemilik.TabIndex = 5;
            // 
            // txtAlamat
            // 
            this.txtAlamat.Location = new System.Drawing.Point(637, 101);
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(100, 20);
            this.txtAlamat.TabIndex = 6;
            // 
            // txtNoHp
            // 
            this.txtNoHp.Location = new System.Drawing.Point(637, 138);
            this.txtNoHp.Name = "txtNoHp";
            this.txtNoHp.Size = new System.Drawing.Size(100, 20);
            this.txtNoHp.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(9, 227);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(128, 227);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(248, 227);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(377, 227);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "Exit";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpemilikDataGridViewTextBoxColumn,
            this.namapemilikDataGridViewTextBoxColumn,
            this.alamatDataGridViewTextBoxColumn,
            this.nohpDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pemilikBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(443, 130);
            this.dataGridView1.TabIndex = 12;
            // 
            // idpemilikDataGridViewTextBoxColumn
            // 
            this.idpemilikDataGridViewTextBoxColumn.DataPropertyName = "id_pemilik";
            this.idpemilikDataGridViewTextBoxColumn.HeaderText = "id_pemilik";
            this.idpemilikDataGridViewTextBoxColumn.Name = "idpemilikDataGridViewTextBoxColumn";
            // 
            // namapemilikDataGridViewTextBoxColumn
            // 
            this.namapemilikDataGridViewTextBoxColumn.DataPropertyName = "nama_pemilik";
            this.namapemilikDataGridViewTextBoxColumn.HeaderText = "nama_pemilik";
            this.namapemilikDataGridViewTextBoxColumn.Name = "namapemilikDataGridViewTextBoxColumn";
            // 
            // alamatDataGridViewTextBoxColumn
            // 
            this.alamatDataGridViewTextBoxColumn.DataPropertyName = "alamat";
            this.alamatDataGridViewTextBoxColumn.HeaderText = "alamat";
            this.alamatDataGridViewTextBoxColumn.Name = "alamatDataGridViewTextBoxColumn";
            // 
            // nohpDataGridViewTextBoxColumn
            // 
            this.nohpDataGridViewTextBoxColumn.DataPropertyName = "no_hp";
            this.nohpDataGridViewTextBoxColumn.HeaderText = "no_hp";
            this.nohpDataGridViewTextBoxColumn.Name = "nohpDataGridViewTextBoxColumn";
            // 
            // pemilikBindingSource1
            // 
            this.pemilikBindingSource1.DataMember = "Pemilik";
            this.pemilikBindingSource1.DataSource = this.kos2DataSetBindingSource;
            // 
            // kos2DataSetBindingSource
            // 
            this.kos2DataSetBindingSource.DataSource = this.kos2DataSet;
            this.kos2DataSetBindingSource.Position = 0;
            // 
            // kos2DataSet
            // 
            this.kos2DataSet.DataSetName = "Kos2DataSet";
            this.kos2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pemilikBindingSource
            // 
            this.pemilikBindingSource.DataMember = "Pemilik";
            this.pemilikBindingSource.DataSource = this.kosDataSet;
            // 
            // kosDataSet
            // 
            this.kosDataSet.DataSetName = "KosDataSet";
            this.kosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bnPemilik
            // 
            this.bnPemilik.AddNewItem = null;
            this.bnPemilik.CountItem = this.bindingNavigatorCountItem;
            this.bnPemilik.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bnPemilik.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.bnPemilik.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bnPemilik.Location = new System.Drawing.Point(0, 0);
            this.bnPemilik.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnPemilik.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnPemilik.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnPemilik.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnPemilik.Name = "bnPemilik";
            this.bnPemilik.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.bnPemilik.PositionItem = this.bindingNavigatorPositionItem;
            this.bnPemilik.Size = new System.Drawing.Size(800, 31);
            this.bnPemilik.TabIndex = 13;
            this.bnPemilik.Text = "bindingNavigator1";
            this.bnPemilik.RefreshItems += new System.EventHandler(this.bindingNavigator1_RefreshItems);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // pemilikTableAdapter
            // 
            this.pemilikTableAdapter.ClearBeforeFill = true;
            // 
            // pemilikTableAdapter1
            // 
            this.pemilikTableAdapter1.ClearBeforeFill = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(530, 194);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 14;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(532, 242);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FormPemilikKos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 298);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.bnPemilik);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtNoHp);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.txtNamaPemilik);
            this.Controls.Add(this.txtIdPemilik);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormPemilikKos";
            this.Text = "PemilikKos";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pemilikBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kos2DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kos2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pemilikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnPemilik)).EndInit();
            this.bnPemilik.ResumeLayout(false);
            this.bnPemilik.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdPemilik;
        private System.Windows.Forms.TextBox txtNamaPemilik;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.TextBox txtNoHp;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingNavigator bnPemilik;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private KosDataSet kosDataSet;
        private System.Windows.Forms.BindingSource pemilikBindingSource;
        private KosDataSetTableAdapters.PemilikTableAdapter pemilikTableAdapter;
        private System.Windows.Forms.BindingSource kos2DataSetBindingSource;
        private Kos2DataSet kos2DataSet;
        private System.Windows.Forms.BindingSource pemilikBindingSource1;
        private Kos2DataSetTableAdapters.PemilikTableAdapter pemilikTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpemilikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namapemilikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nohpDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
    }
}