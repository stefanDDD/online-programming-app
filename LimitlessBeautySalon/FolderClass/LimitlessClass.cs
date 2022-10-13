using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace LimitlessBeautySalon.FolderClass
{
    class LimitlessClass
    {
        //getter setter properties
        //Acts as data carrier in our application

        public int ID { get; set; }

        public string Name { get; set; }

        public string Package { get; set; }

        public string Hour { get; set; }

        public string Date { get; set; }

        public string Phone { get; set; }
        
        public string Observations { get; set; }

        static string myconnString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;

        //select data from database
        public DataTable Select()
        {
            //database connection
            SqlConnection conn = new SqlConnection(myconnString);
            DataTable dt = new DataTable();
            try
            {
                //writing sql query
                string sql = "SELECT * FROM tableApplication";
                //creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //creating sql DataAdapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch(Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return dt;

        }

        //inserting data into database
        public bool Insert(LimitlessClass c)
        {
            //creating a default return type and setting his value to false
            bool isSucces = false;
            //connect database
            SqlConnection conn = new SqlConnection(myconnString);
            try
            {
                //create sql query to insert data
                string sql = "INSERT INTO tableApplication (Nume, Pachet, Ora, Data, Telefon, Observatii) VALUES (@Nume, @Pachet, @Ora, @Data, @Telefon, @Observatii)";
                //create sql command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //create parameters to add data
                cmd.Parameters.AddWithValue("@Nume", c.Name);
                cmd.Parameters.AddWithValue("@Pachet", c.Package);
                cmd.Parameters.AddWithValue("@Ora", c.Hour);
                cmd.Parameters.AddWithValue("@Data", c.Date);
                cmd.Parameters.AddWithValue("@Telefon", c.Phone);
                cmd.Parameters.AddWithValue("@Observatii", c.Observations);

                //Connection Open here
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSucces = true;

                }
                else
                {
                    isSucces = false;
                }

            }
            catch(Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSucces;


        }



        //Method to update data in database from our application
        public bool Update(LimitlessClass c)
        {
            //Create default return type and set his default value to false
            bool isSucces = false;
            SqlConnection conn = new SqlConnection(myconnString);
            try
            {
                //Sql to update data in our database
                string sql = "UPDATE tableApplication SET Nume=@Nume, Pachet=@Pachet, Ora=@Ora, Data=@Data, Telefon=@Telefon, Observatii=@Observatii WHERE ID=@ID";

                //creating sql command
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Create parameters to add value
                cmd.Parameters.AddWithValue("@Nume", c.Name);
                cmd.Parameters.AddWithValue("@Pachet", c.Package);
                cmd.Parameters.AddWithValue("@Ora", c.Hour);
                cmd.Parameters.AddWithValue("@Data", c.Date);
                cmd.Parameters.AddWithValue("@Telefon", c.Phone);
                cmd.Parameters.AddWithValue("@Observatii", c.Observations);

                //Open database connection
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                //if the query runs succesfully the the value of rows will be greater than 0 else its value will be 0
                if (rows > 0)
                {
                    isSucces = true;
                }
                else
                {
                    isSucces = false;
                }
            }
            catch(Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSucces;
        }
        //method to delete data from database
        public bool Delete(LimitlessClass c)
        {
            //Create a default return value and set its value to false
            bool isSucces = false;
            //create sql connection
            SqlConnection conn = new SqlConnection(myconnString);
            try
            {
                //sql to delete data
                string sql = "DELETE FROM tableApplication WHERE ID=@ID";

                //create sql command
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ID", c.ID);
                //open connection
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                //if the query run succesfully the the value of rows will be greater else its value will be 0
                if (rows > 0)
                {
                    isSucces = true;
                }
                else
                {
                    isSucces = false;
                }

            }
            catch(Exception ex)
            {

            }
            finally
            {
                //connection close here
                conn.Close();
            }
            return isSucces;
        }

}
}
