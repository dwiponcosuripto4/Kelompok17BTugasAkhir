namespace Kelompok17BTugasAkhir
{
    partial class FormPenyewa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPenyewa));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textidp = new System.Windows.Forms.TextBox();
            this.textnp = new System.Windows.Forms.TextBox();
            this.textalamat = new System.Windows.Forms.TextBox();
            this.textNoHp = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idpenyewaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namapenyewaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nohpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idkamarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.penyewaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kosDataSet = new Kelompok17BTugasAkhir.KosDataSet();
            this.bnpenyewa = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.penyewaTableAdapter = new Kelompok17BTugasAkhir.KosDataSetTableAdapters.PenyewaTableAdapter();
            this.cbxKamar = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.penyewaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnpenyewa)).BeginInit();
            this.bnpenyewa.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id_Penyewa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama Penyewa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(220, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Alamat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(220, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "No Hp";
            // 
            // textidp
            // 
            this.textidp.Location = new System.Drawing.Point(387, 51);
            this.textidp.Name = "textidp";
            this.textidp.Size = new System.Drawing.Size(288, 26);
            this.textidp.TabIndex = 4;
            // 
            // textnp
            // 
            this.textnp.Location = new System.Drawing.Point(388, 83);
            this.textnp.Name = "textnp";
            this.textnp.Size = new System.Drawing.Size(288, 26);
            this.textnp.TabIndex = 5;
            // 
            // textalamat
            // 
            this.textalamat.Location = new System.Drawing.Point(388, 115);
            this.textalamat.Name = "textalamat";
            this.textalamat.Size = new System.Drawing.Size(288, 26);
            this.textalamat.TabIndex = 6;
            // 
            // textNoHp
            // 
            this.textNoHp.Location = new System.Drawing.Point(387, 147);
            this.textNoHp.Name = "textNoHp";
            this.textNoHp.Size = new System.Drawing.Size(288, 26);
            this.textNoHp.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(224, 265);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 31);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(352, 265);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 31);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(476, 265);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 31);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Hapus";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(600, 265);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 31);
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
            this.idpenyewaDataGridViewTextBoxColumn,
            this.namapenyewaDataGridViewTextBoxColumn,
            this.alamatDataGridViewTextBoxColumn,
            this.nohpDataGridViewTextBoxColumn,
            this.idkamarDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.penyewaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(54, 320);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(866, 232);
            this.dataGridView1.TabIndex = 12;
            // 
            // idpenyewaDataGridViewTextBoxColumn
            // 
            this.idpenyewaDataGridViewTextBoxColumn.DataPropertyName = "id_penyewa";
            this.idpenyewaDataGridViewTextBoxColumn.HeaderText = "id_penyewa";
            this.idpenyewaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idpenyewaDataGridViewTextBoxColumn.Name = "idpenyewaDataGridViewTextBoxColumn";
            this.idpenyewaDataGridViewTextBoxColumn.Width = 150;
            // 
            // namapenyewaDataGridViewTextBoxColumn
            // 
            this.namapenyewaDataGridViewTextBoxColumn.DataPropertyName = "nama_penyewa";
            this.namapenyewaDataGridViewTextBoxColumn.HeaderText = "nama_penyewa";
            this.namapenyewaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.namapenyewaDataGridViewTextBoxColumn.Name = "namapenyewaDataGridViewTextBoxColumn";
            this.namapenyewaDataGridViewTextBoxColumn.Width = 150;
            // 
            // alamatDataGridViewTextBoxColumn
            // 
            this.alamatDataGridViewTextBoxColumn.DataPropertyName = "alamat";
            this.alamatDataGridViewTextBoxColumn.HeaderText = "alamat";
            this.alamatDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.alamatDataGridViewTextBoxColumn.Name = "alamatDataGridViewTextBoxColumn";
            this.alamatDataGridViewTextBoxColumn.Width = 150;
            // 
            // nohpDataGridViewTextBoxColumn
            // 
            this.nohpDataGridViewTextBoxColumn.DataPropertyName = "no_hp";
            this.nohpDataGridViewTextBoxColumn.HeaderText = "no_hp";
            this.nohpDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nohpDataGridViewTextBoxColumn.Name = "nohpDataGridViewTextBoxColumn";
            this.nohpDataGridViewTextBoxColumn.Width = 150;
            // 
            // idkamarDataGridViewTextBoxColumn
            // 
            this.idkamarDataGridViewTextBoxColumn.DataPropertyName = "id_kamar";
            this.idkamarDataGridViewTextBoxColumn.HeaderText = "id_kamar";
            this.idkamarDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idkamarDataGridViewTextBoxColumn.Name = "idkamarDataGridViewTextBoxColumn";
            this.idkamarDataGridViewTextBoxColumn.Width = 150;
            // 
            // penyewaBindingSource
            // 
            this.penyewaBindingSource.DataMember = "Penyewa";
            this.penyewaBindingSource.DataSource = this.kosDataSet;
            // 
            // kosDataSet
            // 
            this.kosDataSet.DataSetName = "KosDataSet";
            this.kosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bnpenyewa
            // 
            this.bnpenyewa.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bnpenyewa.CountItem = this.bindingNavigatorCountItem;
            this.bnpenyewa.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bnpenyewa.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.bnpenyewa.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bnpenyewa.Location = new System.Drawing.Point(0, 0);
            this.bnpenyewa.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnpenyewa.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnpenyewa.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnpenyewa.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnpenyewa.Name = "bnpenyewa";
            this.bnpenyewa.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.bnpenyewa.PositionItem = this.bindingNavigatorPositionItem;
            this.bnpenyewa.Size = new System.Drawing.Size(1010, 38);
            this.bnpenyewa.TabIndex = 13;
            this.bnpenyewa.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 33);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 38);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // penyewaTableAdapter
            // 
            this.penyewaTableAdapter.ClearBeforeFill = true;
            // 
            // cbxKamar
            // 
            this.cbxKamar.FormattingEnabled = true;
            this.cbxKamar.Location = new System.Drawing.Point(387, 179);
            this.cbxKamar.Name = "cbxKamar";
            this.cbxKamar.Size = new System.Drawing.Size(288, 28);
            this.cbxKamar.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(220, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Kamar";
            // 
            // FormPenyewa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 603);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxKamar);
            this.Controls.Add(this.bnpenyewa);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.textNoHp);
            this.Controls.Add(this.textalamat);
            this.Controls.Add(this.textnp);
            this.Controls.Add(this.textidp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormPenyewa";
            this.Text = "Penyewa";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.penyewaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnpenyewa)).EndInit();
            this.bnpenyewa.ResumeLayout(false);
            this.bnpenyewa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textidp;
        private System.Windows.Forms.TextBox textnp;
        private System.Windows.Forms.TextBox textalamat;
        private System.Windows.Forms.TextBox textNoHp;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingNavigator bnpenyewa;
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
        private System.Windows.Forms.BindingSource penyewaBindingSource;
        private KosDataSetTableAdapters.PenyewaTableAdapter penyewaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpenyewaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namapenyewaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nohpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idkamarDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cbxKamar;
        private System.Windows.Forms.Label label5;
    }
}