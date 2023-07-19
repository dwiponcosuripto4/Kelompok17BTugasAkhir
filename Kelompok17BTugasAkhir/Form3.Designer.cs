namespace Kelompok17BTugasAkhir
{
    partial class KosKosan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KosKosan));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textidkk = new System.Windows.Forms.TextBox();
            this.textNK = new System.Windows.Forms.TextBox();
            this.textAlamat = new System.Windows.Forms.TextBox();
            this.textNoHp = new System.Windows.Forms.TextBox();
            this.textKK = new System.Windows.Forms.TextBox();
            this.textHS = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idkosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpemilikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namakosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nohpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kapasitasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kos2DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kos2DataSet = new Kelompok17BTugasAkhir.Kos2DataSet();
            this.kosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kosDataSet = new Kelompok17BTugasAkhir.KosDataSet();
            this.bnKos = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
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
            this.kosTableAdapter = new Kelompok17BTugasAkhir.KosDataSetTableAdapters.KosTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxPemilik = new System.Windows.Forms.ComboBox();
            this.kosTableAdapter1 = new Kelompok17BTugasAkhir.Kos2DataSetTableAdapters.KosTableAdapter();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kos2DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kos2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnKos)).BeginInit();
            this.bnKos.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(851, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id_kos-kosan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(851, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama Kos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(851, 149);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Alamat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(851, 173);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "No Hp";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(851, 196);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Kapasitas Kamar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(851, 218);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Harga Sewa";
            // 
            // textidkk
            // 
            this.textidkk.Location = new System.Drawing.Point(966, 72);
            this.textidkk.Margin = new System.Windows.Forms.Padding(2);
            this.textidkk.Name = "textidkk";
            this.textidkk.Size = new System.Drawing.Size(121, 20);
            this.textidkk.TabIndex = 6;
            // 
            // textNK
            // 
            this.textNK.Location = new System.Drawing.Point(966, 123);
            this.textNK.Margin = new System.Windows.Forms.Padding(2);
            this.textNK.Name = "textNK";
            this.textNK.Size = new System.Drawing.Size(121, 20);
            this.textNK.TabIndex = 7;
            // 
            // textAlamat
            // 
            this.textAlamat.Location = new System.Drawing.Point(966, 146);
            this.textAlamat.Margin = new System.Windows.Forms.Padding(2);
            this.textAlamat.Name = "textAlamat";
            this.textAlamat.Size = new System.Drawing.Size(121, 20);
            this.textAlamat.TabIndex = 8;
            // 
            // textNoHp
            // 
            this.textNoHp.Location = new System.Drawing.Point(966, 170);
            this.textNoHp.Margin = new System.Windows.Forms.Padding(2);
            this.textNoHp.Name = "textNoHp";
            this.textNoHp.Size = new System.Drawing.Size(121, 20);
            this.textNoHp.TabIndex = 9;
            // 
            // textKK
            // 
            this.textKK.Location = new System.Drawing.Point(966, 193);
            this.textKK.Margin = new System.Windows.Forms.Padding(2);
            this.textKK.Name = "textKK";
            this.textKK.Size = new System.Drawing.Size(121, 20);
            this.textKK.TabIndex = 10;
            // 
            // textHS
            // 
            this.textHS.Location = new System.Drawing.Point(966, 215);
            this.textHS.Margin = new System.Windows.Forms.Padding(2);
            this.textHS.Name = "textHS";
            this.textHS.Size = new System.Drawing.Size(121, 20);
            this.textHS.TabIndex = 11;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(76, 340);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(50, 21);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(231, 340);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(50, 21);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(387, 340);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(50, 21);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Hapus";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(568, 340);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(50, 21);
            this.button4.TabIndex = 15;
            this.button4.Text = "Exit";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idkosDataGridViewTextBoxColumn,
            this.idpemilikDataGridViewTextBoxColumn,
            this.namakosDataGridViewTextBoxColumn,
            this.alamatDataGridViewTextBoxColumn,
            this.nohpDataGridViewTextBoxColumn,
            this.kapasitasDataGridViewTextBoxColumn,
            this.hargaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kosBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(8, 42);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(765, 209);
            this.dataGridView1.TabIndex = 16;
            // 
            // idkosDataGridViewTextBoxColumn
            // 
            this.idkosDataGridViewTextBoxColumn.DataPropertyName = "id_kos";
            this.idkosDataGridViewTextBoxColumn.HeaderText = "id_kos";
            this.idkosDataGridViewTextBoxColumn.Name = "idkosDataGridViewTextBoxColumn";
            // 
            // idpemilikDataGridViewTextBoxColumn
            // 
            this.idpemilikDataGridViewTextBoxColumn.DataPropertyName = "id_pemilik";
            this.idpemilikDataGridViewTextBoxColumn.HeaderText = "id_pemilik";
            this.idpemilikDataGridViewTextBoxColumn.Name = "idpemilikDataGridViewTextBoxColumn";
            // 
            // namakosDataGridViewTextBoxColumn
            // 
            this.namakosDataGridViewTextBoxColumn.DataPropertyName = "nama_kos";
            this.namakosDataGridViewTextBoxColumn.HeaderText = "nama_kos";
            this.namakosDataGridViewTextBoxColumn.Name = "namakosDataGridViewTextBoxColumn";
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
            // kapasitasDataGridViewTextBoxColumn
            // 
            this.kapasitasDataGridViewTextBoxColumn.DataPropertyName = "kapasitas";
            this.kapasitasDataGridViewTextBoxColumn.HeaderText = "kapasitas";
            this.kapasitasDataGridViewTextBoxColumn.Name = "kapasitasDataGridViewTextBoxColumn";
            // 
            // hargaDataGridViewTextBoxColumn
            // 
            this.hargaDataGridViewTextBoxColumn.DataPropertyName = "harga";
            this.hargaDataGridViewTextBoxColumn.HeaderText = "harga";
            this.hargaDataGridViewTextBoxColumn.Name = "hargaDataGridViewTextBoxColumn";
            // 
            // kosBindingSource1
            // 
            this.kosBindingSource1.DataMember = "Kos";
            this.kosBindingSource1.DataSource = this.kos2DataSetBindingSource;
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
            // kosBindingSource
            // 
            this.kosBindingSource.DataMember = "Kos";
            this.kosBindingSource.DataSource = this.kosDataSet;
            // 
            // kosDataSet
            // 
            this.kosDataSet.DataSetName = "KosDataSet";
            this.kosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bnKos
            // 
            this.bnKos.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bnKos.CountItem = this.bindingNavigatorCountItem;
            this.bnKos.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bnKos.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.bnKos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bnKos.Location = new System.Drawing.Point(0, 0);
            this.bnKos.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnKos.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnKos.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnKos.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnKos.Name = "bnKos";
            this.bnKos.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.bnKos.PositionItem = this.bindingNavigatorPositionItem;
            this.bnKos.Size = new System.Drawing.Size(1145, 31);
            this.bnKos.TabIndex = 17;
            this.bnKos.Text = "bindingNavigator1";
            this.bnKos.RefreshItems += new System.EventHandler(this.bnKos_RefreshItems);
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(35, 23);
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
            // kosTableAdapter
            // 
            this.kosTableAdapter.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(851, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Pemilik";
            // 
            // cbxPemilik
            // 
            this.cbxPemilik.FormattingEnabled = true;
            this.cbxPemilik.Location = new System.Drawing.Point(966, 97);
            this.cbxPemilik.Name = "cbxPemilik";
            this.cbxPemilik.Size = new System.Drawing.Size(121, 21);
            this.cbxPemilik.TabIndex = 19;
            // 
            // kosTableAdapter1
            // 
            this.kosTableAdapter1.ClearBeforeFill = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(312, 377);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 20;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(500, 377);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // KosKosan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 490);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.cbxPemilik);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bnKos);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.textHS);
            this.Controls.Add(this.textKK);
            this.Controls.Add(this.textNoHp);
            this.Controls.Add(this.textAlamat);
            this.Controls.Add(this.textNK);
            this.Controls.Add(this.textidkk);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "KosKosan";
            this.Text = "Kos-Kosan";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kos2DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kos2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnKos)).EndInit();
            this.bnKos.ResumeLayout(false);
            this.bnKos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textidkk;
        private System.Windows.Forms.TextBox textNK;
        private System.Windows.Forms.TextBox textAlamat;
        private System.Windows.Forms.TextBox textNoHp;
        private System.Windows.Forms.TextBox textKK;
        private System.Windows.Forms.TextBox textHS;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingNavigator bnKos;
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
        private System.Windows.Forms.BindingSource kosBindingSource;
        private KosDataSetTableAdapters.KosTableAdapter kosTableAdapter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxPemilik;
        private System.Windows.Forms.BindingSource kos2DataSetBindingSource;
        private Kos2DataSet kos2DataSet;
        private System.Windows.Forms.BindingSource kosBindingSource1;
        private Kos2DataSetTableAdapters.KosTableAdapter kosTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idkosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpemilikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namakosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nohpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kapasitasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
    }
}