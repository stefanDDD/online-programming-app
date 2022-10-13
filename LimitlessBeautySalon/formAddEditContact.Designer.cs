
namespace LimitlessBeautySalon
{
    partial class formAddEditContact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAddEditContact));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureBoxUp = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblObservations = new System.Windows.Forms.Label();
            this.txtObservations = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.lblPackage = new System.Windows.Forms.Label();
            this.txtPackage = new System.Windows.Forms.TextBox();
            this.lblHour = new System.Windows.Forms.Label();
            this.txtHour = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.pnlError = new System.Windows.Forms.Panel();
            this.tmrError = new System.Windows.Forms.Timer(this.components);
            this.lblError = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUp)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlError.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Black;
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.pictureBoxUp);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(423, 82);
            this.pnlHeader.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Gold;
            this.lblTitle.Location = new System.Drawing.Point(23, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(65, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "{text}";
            // 
            // pictureBoxUp
            // 
            this.pictureBoxUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxUp.Image = global::LimitlessBeautySalon.Properties.Resources.abstract_golden_glowing_wave_banner;
            this.pictureBoxUp.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxUp.Name = "pictureBoxUp";
            this.pictureBoxUp.Size = new System.Drawing.Size(423, 82);
            this.pictureBoxUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUp.TabIndex = 1;
            this.pictureBoxUp.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.lblObservations);
            this.panel1.Controls.Add(this.txtObservations);
            this.panel1.Controls.Add(this.lblPhone);
            this.panel1.Controls.Add(this.txtPhone);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.txtDate);
            this.panel1.Controls.Add(this.lblPackage);
            this.panel1.Controls.Add(this.txtPackage);
            this.panel1.Controls.Add(this.lblHour);
            this.panel1.Controls.Add(this.txtHour);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Location = new System.Drawing.Point(23, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(378, 507);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Black;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Gold;
            this.btnUpdate.Location = new System.Drawing.Point(24, 455);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(103, 32);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Black;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Gold;
            this.btnSave.Location = new System.Drawing.Point(24, 455);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(103, 32);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblObservations
            // 
            this.lblObservations.AutoSize = true;
            this.lblObservations.Location = new System.Drawing.Point(21, 403);
            this.lblObservations.Name = "lblObservations";
            this.lblObservations.Size = new System.Drawing.Size(54, 13);
            this.lblObservations.TabIndex = 15;
            this.lblObservations.Text = "Observatii";
            // 
            // txtObservations
            // 
            this.txtObservations.Location = new System.Drawing.Point(23, 419);
            this.txtObservations.Name = "txtObservations";
            this.txtObservations.Size = new System.Drawing.Size(321, 20);
            this.txtObservations.TabIndex = 14;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(21, 331);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(43, 13);
            this.lblPhone.TabIndex = 13;
            this.lblPhone.Text = "Telefon";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(23, 347);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(321, 20);
            this.txtPhone.TabIndex = 12;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(21, 254);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 9;
            this.lblDate.Text = "Data";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(23, 270);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(321, 20);
            this.txtDate.TabIndex = 8;
            // 
            // lblPackage
            // 
            this.lblPackage.AutoSize = true;
            this.lblPackage.Location = new System.Drawing.Point(21, 103);
            this.lblPackage.Name = "lblPackage";
            this.lblPackage.Size = new System.Drawing.Size(41, 13);
            this.lblPackage.TabIndex = 7;
            this.lblPackage.Text = "Pachet";
            // 
            // txtPackage
            // 
            this.txtPackage.Location = new System.Drawing.Point(23, 119);
            this.txtPackage.Name = "txtPackage";
            this.txtPackage.Size = new System.Drawing.Size(321, 20);
            this.txtPackage.TabIndex = 6;
            // 
            // lblHour
            // 
            this.lblHour.AutoSize = true;
            this.lblHour.Location = new System.Drawing.Point(21, 181);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(24, 13);
            this.lblHour.TabIndex = 3;
            this.lblHour.Text = "Ora";
            // 
            // txtHour
            // 
            this.txtHour.Location = new System.Drawing.Point(23, 197);
            this.txtHour.Name = "txtHour";
            this.txtHour.Size = new System.Drawing.Size(321, 20);
            this.txtHour.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(21, 34);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Nume";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(23, 50);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(321, 20);
            this.txtName.TabIndex = 0;
            // 
            // pnlError
            // 
            this.pnlError.Controls.Add(this.lblError);
            this.pnlError.Location = new System.Drawing.Point(23, 108);
            this.pnlError.Name = "pnlError";
            this.pnlError.Size = new System.Drawing.Size(378, 20);
            this.pnlError.TabIndex = 20;
            this.pnlError.Visible = false;
            // 
            // tmrError
            // 
            this.tmrError.Interval = 2000;
            this.tmrError.Tick += new System.EventHandler(this.tmrError_Tick);
            // 
            // lblError
            // 
            this.lblError.BackColor = System.Drawing.Color.Tomato;
            this.lblError.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblError.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.White;
            this.lblError.Location = new System.Drawing.Point(0, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(378, 20);
            this.lblError.TabIndex = 19;
            this.lblError.Text = "label1";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblError.Visible = false;
            this.lblError.Click += new System.EventHandler(this.lblError_Click);
            // 
            // formAddEditContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(423, 636);
            this.Controls.Add(this.pnlError);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formAddEditContact";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Limitless Beauty Salon";
            this.Load += new System.EventHandler(this.formAddEditContact_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUp)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlError.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPackage;
        private System.Windows.Forms.Label lblHour;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblObservations;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Panel pnlError;
        private System.Windows.Forms.Timer tmrError;
        public System.Windows.Forms.TextBox txtPackage;
        public System.Windows.Forms.TextBox txtHour;
        public System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.TextBox txtObservations;
        public System.Windows.Forms.TextBox txtPhone;
        public System.Windows.Forms.TextBox txtDate;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBoxUp;
        private System.Windows.Forms.Label lblError;
    }
}