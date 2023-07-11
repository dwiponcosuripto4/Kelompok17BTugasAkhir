namespace Kelompok17BTugasAkhir
{
    partial class FormKamar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKamar));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIdKamar = new System.Windows.Forms.TextBox();
            this.txtFasilitas = new System.Windows.Forms.TextBox();
            this.txtHargaSewa = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kamarBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.kosDataSet1 = new Kelompok17BTugasAkhir.KosDataSet1();
            this.kamarBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kosDataSet = new Kelompok17BTugasAkhir.KosDataSet();
            this.kamarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.bnKamar = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.cbxKos = new System.Windows.Forms.ComboBox();
            this.kamarTableAdapter = new Kelompok17BTugasAkhir.KosDataSetTableAdapters.KamarTableAdapter();
            this.fKPenyewaidkama2C3393D0BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.penyewaTableAdapter = new Kelompok17BTugasAkhir.KosDataSetTableAdapters.PenyewaTableAdapter();
            this.kamarBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.kosDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kamarBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.kamarTableAdapter1 = new Kelompok17BTugasAkhir.KosDataSet1TableAdapters.KamarTableAdapter();
            this.kos2DataSet = new Kelompok17BTugasAkhir.Kos2DataSet();
            this.kos2DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kamarBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.kamarTableAdapter2 = new Kelompok17BTugasAkhir.Kos2DataSetTableAdapters.KamarTableAdapter();
            this.idkamarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idkosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fasilitasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kamarBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kosDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kamarBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kamarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnKamar)).BeginInit();
            this.bnKamar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKPenyewaidkama2C3393D0BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kamarBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kosDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kamarBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kos2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kos2DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kamarBindingSource5)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(577, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Kamar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(581, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(577, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fasilitas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(577, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Harga Sewa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(577, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Status";
            // 
            // txtIdKamar
            // 
            this.txtIdKamar.Location = new System.Drawing.Point(700, 34);
            this.txtIdKamar.Name = "txtIdKamar";
            this.txtIdKamar.Size = new System.Drawing.Size(121, 20);
            this.txtIdKamar.TabIndex = 5;
            // 
            // txtFasilitas
            // 
            this.txtFasilitas.Location = new System.Drawing.Point(700, 69);
            this.txtFasilitas.Name = "txtFasilitas";
            this.txtFasilitas.Size = new System.Drawing.Size(121, 20);
            this.txtFasilitas.TabIndex = 7;
            // 
            // txtHargaSewa
            // 
            this.txtHargaSewa.Location = new System.Drawing.Point(700, 101);
            this.txtHargaSewa.Name = "txtHargaSewa";
            this.txtHargaSewa.Size = new System.Drawing.Size(121, 20);
            this.txtHargaSewa.TabIndex = 8;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(700, 138);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(121, 20);
            this.txtStatus.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idkamarDataGridViewTextBoxColumn,
            this.idkosDataGridViewTextBoxColumn,
            this.fasilitasDataGridViewTextBoxColumn,
            this.hargaDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kamarBindingSource5;
            this.dataGridView1.Location = new System.Drawing.Point(9, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(545, 148);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // kamarBindingSource4
            // 
            this.kamarBindingSource4.DataMember = "Kamar";
            this.kamarBindingSource4.DataSource = this.kosDataSet1;
            // 
            // kosDataSet1
            // 
            this.kosDataSet1.DataSetName = "KosDataSet1";
            this.kosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kamarBindingSource1
            // 
            this.kamarBindingSource1.DataMember = "Kamar";
            this.kamarBindingSource1.DataSource = this.kosDataSet;
            // 
            // kosDataSet
            // 
            this.kosDataSet.DataSetName = "KosDataSet";
            this.kosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kamarBindingSource
            // 
            this.kamarBindingSource.DataMember = "Kamar";
            this.kamarBindingSource.DataSource = this.kosDataSet;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(9, 229);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(135, 229);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(307, 229);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Hapus";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(479, 229);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 14;
            this.button4.Text = "Exit";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // bnKamar
            // 
            this.bnKamar.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bnKamar.CountItem = this.bindingNavigatorCountItem;
            this.bnKamar.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bnKamar.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.bnKamar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bnKamar.Location = new System.Drawing.Point(0, 0);
            this.bnKamar.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnKamar.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnKamar.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnKamar.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnKamar.Name = "bnKamar";
            this.bnKamar.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.bnKamar.PositionItem = this.bindingNavigatorPositionItem;
            this.bnKamar.Size = new System.Drawing.Size(842, 31);
            this.bnKamar.TabIndex = 15;
            this.bnKamar.Text = "bindingNavigator1";
            this.bnKamar.RefreshItems += new System.EventHandler(this.bnKamar_RefreshItems);
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
            // cbxKos
            // 
            this.cbxKos.FormattingEnabled = true;
            this.cbxKos.Location = new System.Drawing.Point(700, 171);
            this.cbxKos.Name = "cbxKos";
            this.cbxKos.Size = new System.Drawing.Size(121, 21);
            this.cbxKos.TabIndex = 16;
            // 
            // kamarTableAdapter
            // 
            this.kamarTableAdapter.ClearBeforeFill = true;
            // 
            // fKPenyewaidkama2C3393D0BindingSource
            // 
            this.fKPenyewaidkama2C3393D0BindingSource.DataMember = "FK__Penyewa__id_kama__2C3393D0";
            this.fKPenyewaidkama2C3393D0BindingSource.DataSource = this.kamarBindingSource;
            // 
            // penyewaTableAdapter
            // 
            this.penyewaTableAdapter.ClearBeforeFill = true;
            // 
            // kamarBindingSource2
            // 
            this.kamarBindingSource2.DataMember = "Kamar";
            this.kamarBindingSource2.DataSource = this.kosDataSet;
            // 
            // kosDataSetBindingSource
            // 
            this.kosDataSetBindingSource.DataSource = this.kosDataSet;
            this.kosDataSetBindingSource.Position = 0;
            // 
            // kamarBindingSource3
            // 
            this.kamarBindingSource3.DataMember = "Kamar";
            this.kamarBindingSource3.DataSource = this.kosDataSetBindingSource;
            // 
            // kamarTableAdapter1
            // 
            this.kamarTableAdapter1.ClearBeforeFill = true;
            // 
            // kos2DataSet
            // 
            this.kos2DataSet.DataSetName = "Kos2DataSet";
            this.kos2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kos2DataSetBindingSource
            // 
            this.kos2DataSetBindingSource.DataSource = this.kos2DataSet;
            this.kos2DataSetBindingSource.Position = 0;
            // 
            // kamarBindingSource5
            // 
            this.kamarBindingSource5.DataMember = "Kamar";
            this.kamarBindingSource5.DataSource = this.kos2DataSetBindingSource;
            // 
            // kamarTableAdapter2
            // 
            this.kamarTableAdapter2.ClearBeforeFill = true;
            // 
            // idkamarDataGridViewTextBoxColumn
            // 
            this.idkamarDataGridViewTextBoxColumn.DataPropertyName = "id_kamar";
            this.idkamarDataGridViewTextBoxColumn.HeaderText = "id_kamar";
            this.idkamarDataGridViewTextBoxColumn.Name = "idkamarDataGridViewTextBoxColumn";
            // 
            // idkosDataGridViewTextBoxColumn
            // 
            this.idkosDataGridViewTextBoxColumn.DataPropertyName = "id_kos";
            this.idkosDataGridViewTextBoxColumn.HeaderText = "id_kos";
            this.idkosDataGridViewTextBoxColumn.Name = "idkosDataGridViewTextBoxColumn";
            // 
            // fasilitasDataGridViewTextBoxColumn
            // 
            this.fasilitasDataGridViewTextBoxColumn.DataPropertyName = "fasilitas";
            this.fasilitasDataGridViewTextBoxColumn.HeaderText = "fasilitas";
            this.fasilitasDataGridViewTextBoxColumn.Name = "fasilitasDataGridViewTextBoxColumn";
            // 
            // hargaDataGridViewTextBoxColumn
            // 
            this.hargaDataGridViewTextBoxColumn.DataPropertyName = "harga";
            this.hargaDataGridViewTextBoxColumn.HeaderText = "harga";
            this.hargaDataGridViewTextBoxColumn.Name = "hargaDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // FormKamar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 450);
            this.Controls.Add(this.cbxKos);
            this.Controls.Add(this.bnKamar);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtHargaSewa);
            this.Controls.Add(this.txtFasilitas);
            this.Controls.Add(this.txtIdKamar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormKamar";
            this.Text = "Kamar";
            this.Load += new System.EventHandler(this.FormKamar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kamarBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kosDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kamarBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kamarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnKamar)).EndInit();
            this.bnKamar.ResumeLayout(false);
            this.bnKamar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKPenyewaidkama2C3393D0BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kamarBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kosDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kamarBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kos2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kos2DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kamarBindingSource5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIdKamar;
        private System.Windows.Forms.TextBox txtFasilitas;
        private System.Windows.Forms.TextBox txtHargaSewa;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.BindingNavigator bnKamar;
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
        private System.Windows.Forms.ComboBox cbxKos;
        private KosDataSet kosDataSet;
        private System.Windows.Forms.BindingSource kamarBindingSource;
        private KosDataSetTableAdapters.KamarTableAdapter kamarTableAdapter;
        private System.Windows.Forms.BindingSource kamarBindingSource1;
        private System.Windows.Forms.BindingSource fKPenyewaidkama2C3393D0BindingSource;
        private KosDataSetTableAdapters.PenyewaTableAdapter penyewaTableAdapter;
        private System.Windows.Forms.BindingSource kamarBindingSource2;
        private System.Windows.Forms.BindingSource kamarBindingSource3;
        private System.Windows.Forms.BindingSource kosDataSetBindingSource;
        private KosDataSet1 kosDataSet1;
        private System.Windows.Forms.BindingSource kamarBindingSource4;
        private KosDataSet1TableAdapters.KamarTableAdapter kamarTableAdapter1;
        private System.Windows.Forms.BindingSource kos2DataSetBindingSource;
        private Kos2DataSet kos2DataSet;
        private System.Windows.Forms.BindingSource kamarBindingSource5;
        private Kos2DataSetTableAdapters.KamarTableAdapter kamarTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idkamarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idkosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fasilitasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
    }
}