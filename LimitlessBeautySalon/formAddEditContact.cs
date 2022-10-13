using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using LimitlessBeautySalon.FolderClass;

namespace LimitlessBeautySalon
{
    public partial class formAddEditContact : Form


    {
        
        
        formContact f1;
        public formAddEditContact(formContact frm1)
        {
            
            InitializeComponent();
          
            this.f1=frm1;
            


        }
        public formAddEditContact()
        {
            
            InitializeComponent();
            
            lblTitle.Text = "Adauga Contact";
            

        }

        LimitlessClass c = new LimitlessClass();
        public void ShowError(string Text)
        { 
            
            lblError.Text = Text;
            pnlError.Visible = true;
            tmrError.Start();
            
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void lblError_Click(object sender, EventArgs e)
        {

        }

        private void tmrError_Tick(object sender, EventArgs e)
        {
            tmrError.Stop();
            pnlError.Visible = false;
            
        }

        private void formAddEditContact_Load(object sender, EventArgs e)
        {
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Parent = pictureBoxUp; 

        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            lblError.Visible = true;
            pnlError.Visible = true;
            
            if (string.IsNullOrEmpty(txtName.Text))
            {

                ShowError("Eroare! Campul [Nume] este necesar");
            }
            else if (string.IsNullOrEmpty(txtPackage.Text))
            {
                ShowError("Eroare! Campul [Pachet] este necesar");
            }
            else if (string.IsNullOrEmpty(txtHour.Text))
            {
                ShowError("Eroare! Campul [Ora] este necesar");
            }
            else if (string.IsNullOrEmpty(txtDate.Text))
            {
                ShowError("Eroare! Campul [Data] este necesar");
            }
            else if (string.IsNullOrEmpty(txtPhone.Text))
            {
                ShowError("Eroare! Campul [Telefon] este necesar");
            }
            else if (string.IsNullOrEmpty(txtObservations.Text))
            {
                ShowError("Eroare! Campul [Observatii] este necesar");
            }
            else
            {
                ShowError("Completare reusita");
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-VUPD668;Initial Catalog=dbApp;Integrated Security=True");
                conn.Open();
                
                SqlCommand cmd = new SqlCommand("INSERT INTO tableApplication (Nume, Pachet, Ora, Data, Telefon, Observatii) VALUES ('" + txtName.Text + "','" + txtPackage.Text + "','" + txtHour.Text + "','" + txtDate.Text + "','" + txtPhone.Text + "','" + txtObservations.Text + "')", conn);


                int i = cmd.ExecuteNonQuery();

                if (i != 0)

                {

                    MessageBox.Show("Datele au fost salvate");


                }
                else
                {
                    MessageBox.Show("Eroare la salvarea datelor");


                }
                conn.Close();
                this.Close();
            }
        }


        public void btnUpdate_Click(object sender, EventArgs e)
        {
            lblError.Visible = true;
            pnlError.Visible = true;
            if (string.IsNullOrEmpty(txtName.Text))
            {
                ShowError("Eroare! Campul [Nume] este necesar");
            }
            else if (string.IsNullOrEmpty(txtPackage.Text))
            {
                ShowError("Eroare! Campul [Pachet] este necesar");
            }
            else if (string.IsNullOrEmpty(txtHour.Text))
            {
                ShowError("Eroare! Campul [Ora] este necesar");
            }
            else if (string.IsNullOrEmpty(txtDate.Text))
            {
                ShowError("Eroare! Campul [Data] este necesar");
            }
            else if (string.IsNullOrEmpty(txtPhone.Text))
            {
                ShowError("Eroare! Campul [Telefon] este necesar");
            }
            else if (string.IsNullOrEmpty(txtObservations.Text))
            {
                ShowError("Eroare! Campul [Observatii] este necesar");
            }
            else 
            {
                ShowError("Completare reusita");
                DialogResult dialogResultEdit = MessageBox.Show("Doriti sa editati contactul?", "Warning", MessageBoxButtons.YesNo);

                if (dialogResultEdit == DialogResult.Yes)
                {

                    this.Close();

                }
                else if (dialogResultEdit == DialogResult.No)
                {

                }
            }
        }


    }
}
