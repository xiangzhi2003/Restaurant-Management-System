using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_Assignment_Group_Adlina
{
    internal class ManagerProfileUpdate
    {
        private string username;
        private string email;
        private string password;
        static SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\xiang\source\repos\IOOP-Assignment-Group-Adlina3\IOOP Assignment Group Adlina\MainDB.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=False");

        public string Username { get => username; set => username = value; }

        public string Email { get => email; set => email = value; }

        public string Password { get => password; set => password = value; }

        public ManagerProfileUpdate(string username, string email, string password)
        {
            this.username = username;
            this.email = email;
            this.password = password;
        }

        //Constructor with one parameter
        public ManagerProfileUpdate(string username)
        {
            this.username = username;
        }

        public string updateProfile(string un, string em, string pas)
        {
            string status;
            con.Open();

            SqlCommand cmd = new SqlCommand("update userData set Username =@nm ,Email =@e,Password=@p where Username like @ou", con);
            cmd.Parameters.AddWithValue("@nm", un);
            cmd.Parameters.AddWithValue("@e", em);
            cmd.Parameters.AddWithValue("@p", pas);
            cmd.Parameters.AddWithValue("@ou", username);

            //try
            //{
            //    cmd.ExecuteNonQuery();
            //    MessageBox.Show("Update Successful");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //return username;

            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                status = "Update Successfully.";
            }
            else
            {
                status = "Unable to update.";
            }
            con.Close();
            return status;
        }
    }
}

