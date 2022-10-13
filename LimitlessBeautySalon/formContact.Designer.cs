
namespace LimitlessBeautySalon
{
    partial class formContact
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formContact));
            this.pnlGridView = new System.Windows.Forms.Panel();
            this.btnServer = new System.Windows.Forms.Button();
            this.dgvContactList = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pachetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observatiiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tableApplicationBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.dbAppDataSet = new LimitlessBeautySalon.dbAppDataSet();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.tableApplicationTableAdapter = new LimitlessBeautySalon.dbAppDataSetTableAdapters.tableApplicationTableAdapter();
            this.lblHeader = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pictureBoxUp = new System.Windows.Forms.PictureBox();
            this.tableApplicationBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tableApplicationBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tableApplicationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.limitlessClassBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.formAddEditContactBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableApplicationBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbAppDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableApplicationBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableApplicationBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableApplicationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.limitlessClassBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formAddEditContactBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlGridView
            // 
            this.pnlGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGridView.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlGridView.Controls.Add(this.btnServer);
            this.pnlGridView.Controls.Add(this.dgvContactList);
            this.pnlGridView.Controls.Add(this.pictureBox1);
            this.pnlGridView.Controls.Add(this.txtSearch);
            this.pnlGridView.Controls.Add(this.btnRefresh);
            this.pnlGridView.Controls.Add(this.btnNew);
            this.pnlGridView.Location = new System.Drawing.Point(28, 113);
            this.pnlGridView.Name = "pnlGridView";
            this.pnlGridView.Size = new System.Drawing.Size(1076, 406);
            this.pnlGridView.TabIndex = 1;
            this.pnlGridView.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlGridView_Paint);
            // 
            // btnServer
            // 
            this.btnServer.BackColor = System.Drawing.Color.Tomato;
            this.btnServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServer.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServer.ForeColor = System.Drawing.Color.White;
            this.btnServer.Location = new System.Drawing.Point(242, 13);
            this.btnServer.Name = "btnServer";
            this.btnServer.Size = new System.Drawing.Size(103, 32);
            this.btnServer.TabIndex = 7;
            this.btnServer.Text = "{text}";
            this.btnServer.UseVisualStyleBackColor = false;
            this.btnServer.Click += new System.EventHandler(this.btnServer_Click);
            // 
            // dgvContactList
            // 
            this.dgvContactList.AllowUserToAddRows = false;
            this.dgvContactList.AllowUserToDeleteRows = false;
            this.dgvContactList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvContactList.AutoGenerateColumns = false;
            this.dgvContactList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvContactList.BackgroundColor = System.Drawing.Color.White;
            this.dgvContactList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvContactList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContactList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.numeDataGridViewTextBoxColumn,
            this.pachetDataGridViewTextBoxColumn,
            this.oraDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.observatiiDataGridViewTextBoxColumn,
            this.edit,
            this.delete});
            this.dgvContactList.DataSource = this.tableApplicationBindingSource3;
            this.dgvContactList.GridColor = System.Drawing.Color.LightGray;
            this.dgvContactList.Location = new System.Drawing.Point(24, 54);
            this.dgvContactList.Margin = new System.Windows.Forms.Padding(2);
            this.dgvContactList.Name = "dgvContactList";
            this.dgvContactList.ReadOnly = true;
            this.dgvContactList.RowHeadersVisible = false;
            this.dgvContactList.RowTemplate.Height = 24;
            this.dgvContactList.Size = new System.Drawing.Size(1030, 336);
            this.dgvContactList.TabIndex = 6;
            this.dgvContactList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContactList_CellClick);
            this.dgvContactList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContactList_CellContentClick);
            this.dgvContactList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvContactList_CellFormatting);
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn8.FillWeight = 30F;
            this.dataGridViewTextBoxColumn8.HeaderText = "ID";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn8.Width = 37;
            // 
            // numeDataGridViewTextBoxColumn
            // 
            this.numeDataGridViewTextBoxColumn.DataPropertyName = "Nume";
            this.numeDataGridViewTextBoxColumn.HeaderText = "Nume";
            this.numeDataGridViewTextBoxColumn.Name = "numeDataGridViewTextBoxColumn";
            this.numeDataGridViewTextBoxColumn.ReadOnly = true;
            this.numeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // pachetDataGridViewTextBoxColumn
            // 
            this.pachetDataGridViewTextBoxColumn.DataPropertyName = "Pachet";
            this.pachetDataGridViewTextBoxColumn.HeaderText = "Pachet";
            this.pachetDataGridViewTextBoxColumn.Name = "pachetDataGridViewTextBoxColumn";
            this.pachetDataGridViewTextBoxColumn.ReadOnly = true;
            this.pachetDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // oraDataGridViewTextBoxColumn
            // 
            this.oraDataGridViewTextBoxColumn.DataPropertyName = "Ora";
            this.oraDataGridViewTextBoxColumn.FillWeight = 50F;
            this.oraDataGridViewTextBoxColumn.HeaderText = "Ora";
            this.oraDataGridViewTextBoxColumn.Name = "oraDataGridViewTextBoxColumn";
            this.oraDataGridViewTextBoxColumn.ReadOnly = true;
            this.oraDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "Telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            this.telefonDataGridViewTextBoxColumn.ReadOnly = true;
            this.telefonDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // observatiiDataGridViewTextBoxColumn
            // 
            this.observatiiDataGridViewTextBoxColumn.DataPropertyName = "Observatii";
            this.observatiiDataGridViewTextBoxColumn.FillWeight = 150F;
            this.observatiiDataGridViewTextBoxColumn.HeaderText = "Observatii";
            this.observatiiDataGridViewTextBoxColumn.Name = "observatiiDataGridViewTextBoxColumn";
            this.observatiiDataGridViewTextBoxColumn.ReadOnly = true;
            this.observatiiDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // edit
            // 
            this.edit.DataPropertyName = "EDIT";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Gold;
            this.edit.DefaultCellStyle = dataGridViewCellStyle1;
            this.edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit.HeaderText = "";
            this.edit.Name = "edit";
            this.edit.ReadOnly = true;
            this.edit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.edit.Text = "Edit";
            this.edit.ToolTipText = "Edit";
            this.edit.UseColumnTextForButtonValue = true;
            // 
            // delete
            // 
            this.delete.DataPropertyName = "DELETE";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.delete.DefaultCellStyle = dataGridViewCellStyle2;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.HeaderText = "";
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.delete.Text = "Delete";
            this.delete.ToolTipText = "Delete";
            this.delete.UseColumnTextForButtonValue = true;
            // 
            // tableApplicationBindingSource3
            // 
            this.tableApplicationBindingSource3.DataMember = "tableApplication";
            this.tableApplicationBindingSource3.DataSource = this.dbAppDataSet;
            // 
            // dbAppDataSet
            // 
            this.dbAppDataSet.DataSetName = "dbAppDataSet";
            this.dbAppDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::LimitlessBeautySalon.Properties.Resources.iconfinder_Rounded_10_2024633;
            this.pictureBox1.Location = new System.Drawing.Point(826, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(847, 21);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(208, 20);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Black;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Gold;
            this.btnRefresh.Location = new System.Drawing.Point(133, 13);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(103, 32);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.Black;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.Gold;
            this.btnNew.Location = new System.Drawing.Point(24, 13);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(103, 32);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // tableApplicationTableAdapter
            // 
            this.tableApplicationTableAdapter.ClearBeforeFill = true;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.Gold;
            this.lblHeader.Location = new System.Drawing.Point(23, 30);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(224, 30);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Limitless Beauty Salon";
            this.lblHeader.Click += new System.EventHandler(this.lblHeader_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Black;
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Controls.Add(this.pictureBoxUp);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1134, 82);
            this.pnlHeader.TabIndex = 0;
            // 
            // pictureBoxUp
            // 
            this.pictureBoxUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxUp.Image = global::LimitlessBeautySalon.Properties.Resources.pngtree_black_atmospheric_financial_technology_conference_background_image_145942;
            this.pictureBoxUp.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxUp.Name = "pictureBoxUp";
            this.pictureBoxUp.Size = new System.Drawing.Size(1134, 82);
            this.pictureBoxUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUp.TabIndex = 1;
            this.pictureBoxUp.TabStop = false;
            // 
            // tableApplicationBindingSource2
            // 
            this.tableApplicationBindingSource2.DataMember = "tableApplication";
            // 
            // tableApplicationBindingSource1
            // 
            this.tableApplicationBindingSource1.DataMember = "tableApplication";
            // 
            // tableApplicationBindingSource
            // 
            this.tableApplicationBindingSource.DataMember = "tableApplication";
            // 
            // formContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1134, 545);
            this.Controls.Add(this.pnlGridView);
            this.Controls.Add(this.pnlHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formContact";
            this.Text = "Limitless Beauty Salon";
            this.Load += new System.EventHandler(this.formContact_Load);
            this.pnlGridView.ResumeLayout(false);
            this.pnlGridView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableApplicationBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbAppDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableApplicationBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableApplicationBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableApplicationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.limitlessClassBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formAddEditContactBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlGridView;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnRefresh;

        private System.Windows.Forms.BindingSource tableApplicationBindingSource;
        private System.Windows.Forms.BindingSource formAddEditContactBindingSource;
        private System.Windows.Forms.BindingSource limitlessClassBindingSource;

        private System.Windows.Forms.BindingSource tableApplicationBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn packageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observationsDataGridViewTextBoxColumn;

        private System.Windows.Forms.BindingSource tableApplicationBindingSource2;

        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private dbAppDataSet dbAppDataSet;
        private System.Windows.Forms.BindingSource tableApplicationBindingSource3;
        private dbAppDataSetTableAdapters.tableApplicationTableAdapter tableApplicationTableAdapter;
        private System.Windows.Forms.Button btnServer;
        public System.Windows.Forms.DataGridView dgvContactList;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.PictureBox pictureBoxUp;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pachetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observatiiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn edit;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
    }
}

