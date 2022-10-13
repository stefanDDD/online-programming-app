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
using System.Configuration;
using LimitlessBeautySalon.FolderClass;
using LimitlessBeautySalon.dbAppDataSetTableAdapters;
using LimitlessBeautySalon.Properties;


namespace LimitlessBeautySalon
{
    public partial class formContact : Form

    {

        public int ID { get; set; }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-VUPD668;Initial Catalog=dbApp;Integrated Security=True");

        SqlDataAdapter adapter;
        DataTable dt;


        bool ON = true;
        bool toggleLight = true;
        Timer t = new Timer();
        public formContact()
        {
            
            InitializeComponent();
            ShowData();



        }
        LimitlessClass c = new LimitlessClass();
        private void pnlGridView_Paint(object sender, PaintEventArgs e)
        {
            dgvContactList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvContactList.AllowUserToResizeRows = false;
        }

        private void formContact_Load(object sender, EventArgs e)
        {
            lblHeader.BackColor = Color.Transparent;
            lblHeader.Parent = pictureBoxUp;
            lblHeader.BackColor = System.Drawing.Color.Transparent;
            btnServer.Text = "OFF";
            t.Interval = 1000;
            t.Tick += new EventHandler(t_Tick);
            // TODO: This line of code loads data into the 'dbAppDataSet.tableApplication' table. You can move, or remove it, as needed.
            this.tableApplicationTableAdapter.Fill(this.dbAppDataSet.tableApplication);


        }

        private void t_Tick(object sender, EventArgs e)
        {
            if (toggleLight)
            {
                btnServer.BackColor = Color.Black;
                btnServer.ForeColor = Color.Gold;
                toggleLight = false;

            }
            else
            {
                btnServer.BackColor = Color.LimeGreen;
                btnServer.ForeColor = Color.White;
                toggleLight = true;
            }
        }
        private void btnServer_Click(object sender, EventArgs e)
        {
            if (ON)
            {
                btnServer.Text = "ON";
                t.Start();
                ON = false;
            }
            else
            {
                btnServer.Text = "OFF";
                btnServer.BackColor = Color.Tomato;
                btnServer.ForeColor = Color.White;
                t.Stop();
                ON = true;
            }
        }

        public void ShowData()
        {

            adapter = new SqlDataAdapter("SELECT * FROM tableApplication", conn);
            dt = new DataTable();
            adapter.Fill(dt);
            dgvContactList.DataSource = dt;
        }


        private void btnNew_Click(object sender, EventArgs e)
        {
            
            formAddEditContact f2 = new formAddEditContact();
            new formAddEditContact().ShowDialog();
            
            ShowData();

        }

        public void dgvContactList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            if (e.ColumnIndex == 7)
            {
                int rowIndex = e.RowIndex;
                formAddEditContact f2 = new formAddEditContact();
                formContact f1 = new formContact();
                f2.txtName.Text = f1.dgvContactList.Rows[rowIndex].Cells[1].Value.ToString();
                f2.txtPackage.Text = f1.dgvContactList.Rows[rowIndex].Cells[2].Value.ToString();
                f2.txtHour.Text = f1.dgvContactList.Rows[rowIndex].Cells[3].Value.ToString();
                f2.txtDate.Text = f1.dgvContactList.Rows[rowIndex].Cells[4].Value.ToString();
                f2.txtPhone.Text = f1.dgvContactList.Rows[rowIndex].Cells[5].Value.ToString();
                f2.txtObservations.Text = f1.dgvContactList.Rows[rowIndex].Cells[6].Value.ToString();
                f2.lblTitle.Text = "Editeaza Contact";
                f2.btnSave.Visible = false;
                f2.btnUpdate.Visible = true;
                f2.ShowDialog();
                

                    f2.btnUpdate.Click += f2.btnUpdate_Click;
                    
                        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-VUPD668;Initial Catalog=dbApp;Integrated Security=True");
                        SqlCommand cmd;
                        cmd = new SqlCommand("UPDATE tableApplication SET Nume='" + f2.txtName.Text + "',Pachet='" + f2.txtPackage.Text + "',Ora='" + f2.txtHour.Text + "',Data='" + f2.txtDate.Text + "',Telefon='" + f2.txtPhone.Text + "',Observatii='" + f2.txtObservations.Text + "' WHERE ID=" + f1.dgvContactList.Rows[rowIndex].Cells[0].Value.ToString(), conn);
                        conn.Open();

                        cmd.ExecuteNonQuery();

                        conn.Close();
                    


                


            }
            else if (e.ColumnIndex == 8)
                {

                DialogResult dialogResult = MessageBox.Show("Doriti sa stergeti contactul?", "Warning", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                { 
                    //create sql connection
                    conn = new SqlConnection(@"Data Source=DESKTOP-VUPD668;Initial Catalog=dbApp;Integrated Security=True");

                    int rowIndex = e.RowIndex;
                    //sql to delete data
                    string sql = "DELETE FROM tableApplication WHERE ID=" + dgvContactList.Rows[rowIndex].Cells[0].Value;
                    //create sql command
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    //open connection
                    conn.Open();
                    cmd.ExecuteNonQuery();

                    conn.Close();
                    dgvContactList.Rows.RemoveAt(rowIndex);
                    
                }
                else if (dialogResult == DialogResult.No)
                {

                }



            } 
          

        }

        internal void dgvContactList_CellContentClick(DataGridView dgvContactList, DataGridViewCellCancelEventArgs dataGridViewCellCancelEventArgs)
        {
            throw new NotImplementedException();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SearchData(txtSearch.Text);
        }
        public void SearchData(string search)
        {
            
            conn.Open();
            string query = "SELECT * FROM tableApplication WHERE Nume LIKE '%" + search + "%' OR  Pachet LIKE '%" + search + "%' OR Ora LIKE '%" + search + "%' OR Data LIKE '%" + search + "%' OR Telefon LIKE '%" + search + "%' OR Observatii LIKE '%" + search + "%' ";

            adapter = new SqlDataAdapter(query, conn);
            dt = new DataTable();
            adapter.Fill(dt);

            dgvContactList.DataSource = dt;
                conn.Close();
        }
       

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ShowData();
            this.dgvContactList.Refresh();
            this.dgvContactList.Update();
        }

        private void dgvContactList_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvContactList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {


        }

        private void lblHeader_Click(object sender, EventArgs e)
        {

        }
    }
}
