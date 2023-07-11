namespace Kelompok17BTugasAkhir
{
    partial class admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin));
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textida = new System.Windows.Forms.TextBox();
            this.textnma = new System.Windows.Forms.TextBox();
            this.textnohp = new System.Windows.Forms.TextBox();
            this.textuser = new System.Windows.Forms.TextBox();
            this.textpsw = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.adminBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kosDataSet = new Kelompok17BTugasAkhir.KosDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bnadmin = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.adminTableAdapter = new Kelompok17BTugasAkhir.KosDataSetTableAdapters.AdminTableAdapter();
            this.kos2DataSet = new Kelompok17BTugasAkhir.Kos2DataSet();
            this.kos2DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adminBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.adminTableAdapter1 = new Kelompok17BTugasAkhir.Kos2DataSetTableAdapters.AdminTableAdapter();
            this.idadminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaadminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nohpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnadmin)).BeginInit();
            this.bnadmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kos2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kos2DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(9, 184);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(161, 184);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(323, 184);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Hapus";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(479, 184);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Exit";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textida
            // 
            this.textida.Location = new System.Drawing.Point(693, 29);
            this.textida.Name = "textida";
            this.textida.Size = new System.Drawing.Size(100, 20);
            this.textida.TabIndex = 5;
            // 
            // textnma
            // 
            this.textnma.Location = new System.Drawing.Point(693, 52);
            this.textnma.Name = "textnma";
            this.textnma.Size = new System.Drawing.Size(100, 20);
            this.textnma.TabIndex = 6;
            // 
            // textnohp
            // 
            this.textnohp.Location = new System.Drawing.Point(693, 75);
            this.textnohp.Name = "textnohp";
            this.textnohp.Size = new System.Drawing.Size(100, 20);
            this.textnohp.TabIndex = 7;
            // 
            // textuser
            // 
            this.textuser.Location = new System.Drawing.Point(693, 99);
            this.textuser.Name = "textuser";
            this.textuser.Size = new System.Drawing.Size(100, 20);
            this.textuser.TabIndex = 8;
            // 
            // textpsw
            // 
            this.textpsw.Location = new System.Drawing.Point(693, 122);
            this.textpsw.Name = "textpsw";
            this.textpsw.Size = new System.Drawing.Size(100, 20);
            this.textpsw.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idadminDataGridViewTextBoxColumn,
            this.namaadminDataGridViewTextBoxColumn,
            this.nohpDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.adminBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(9, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(545, 105);
            this.dataGridView1.TabIndex = 10;
            // 
            // adminBindingSource
            // 
            this.adminBindingSource.DataMember = "Admin";
            this.adminBindingSource.DataSource = this.kosDataSet;
            // 
            // kosDataSet
            // 
            this.kosDataSet.DataSetName = "KosDataSet";
            this.kosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(587, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Id_Admin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(587, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nama Admin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(587, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "No Hp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(587, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Username";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(587, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Passwword";
            // 
            // bnadmin
            // 
            this.bnadmin.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bnadmin.CountItem = this.bindingNavigatorCountItem;
            this.bnadmin.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bnadmin.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.bnadmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bnadmin.Location = new System.Drawing.Point(0, 0);
            this.bnadmin.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnadmin.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnadmin.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnadmin.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnadmin.Name = "bnadmin";
            this.bnadmin.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.bnadmin.PositionItem = this.bindingNavigatorPositionItem;
            this.bnadmin.Size = new System.Drawing.Size(800, 31);
            this.bnadmin.TabIndex = 16;
            this.bnadmin.Text = "bindingNavigator1";
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
            // adminTableAdapter
            // 
            this.adminTableAdapter.ClearBeforeFill = true;
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
            // adminBindingSource1
            // 
            this.adminBindingSource1.DataMember = "Admin";
            this.adminBindingSource1.DataSource = this.kos2DataSetBindingSource;
            // 
            // adminTableAdapter1
            // 
            this.adminTableAdapter1.ClearBeforeFill = true;
            // 
            // idadminDataGridViewTextBoxColumn
            // 
            this.idadminDataGridViewTextBoxColumn.DataPropertyName = "id_admin";
            this.idadminDataGridViewTextBoxColumn.HeaderText = "id_admin";
            this.idadminDataGridViewTextBoxColumn.Name = "idadminDataGridViewTextBoxColumn";
            // 
            // namaadminDataGridViewTextBoxColumn
            // 
            this.namaadminDataGridViewTextBoxColumn.DataPropertyName = "nama_admin";
            this.namaadminDataGridViewTextBoxColumn.HeaderText = "nama_admin";
            this.namaadminDataGridViewTextBoxColumn.Name = "namaadminDataGridViewTextBoxColumn";
            // 
            // nohpDataGridViewTextBoxColumn
            // 
            this.nohpDataGridViewTextBoxColumn.DataPropertyName = "no_hp";
            this.nohpDataGridViewTextBoxColumn.HeaderText = "no_hp";
            this.nohpDataGridViewTextBoxColumn.Name = "nohpDataGridViewTextBoxColumn";
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // adminBindingSource2
            // 
            this.adminBindingSource2.DataMember = "Admin";
            this.adminBindingSource2.DataSource = this.kos2DataSetBindingSource;
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 245);
            this.Controls.Add(this.bnadmin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textpsw);
            this.Controls.Add(this.textuser);
            this.Controls.Add(this.textnohp);
            this.Controls.Add(this.textnma);
            this.Controls.Add(this.textida);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Name = "admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnadmin)).EndInit();
            this.bnadmin.ResumeLayout(false);
            this.bnadmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kos2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kos2DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textida;
        private System.Windows.Forms.TextBox textnma;
        private System.Windows.Forms.TextBox textnohp;
        private System.Windows.Forms.TextBox textuser;
        private System.Windows.Forms.TextBox textpsw;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingNavigator bnadmin;
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
        private System.Windows.Forms.BindingSource adminBindingSource;
        private KosDataSetTableAdapters.AdminTableAdapter adminTableAdapter;
        private System.Windows.Forms.BindingSource kos2DataSetBindingSource;
        private Kos2DataSet kos2DataSet;
        private System.Windows.Forms.BindingSource adminBindingSource1;
        private Kos2DataSetTableAdapters.AdminTableAdapter adminTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idadminDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaadminDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nohpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource adminBindingSource2;
    }
}