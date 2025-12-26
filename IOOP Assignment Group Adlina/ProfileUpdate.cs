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
    internal class ProfileUpdate
    {
        string username, email, password;
        //Assign the Connectionstring (variable) to its connection string. Simplified by using connection string name in App.config but have to use ConfigurationManager.
        private static string Connectionstring = ConfigurationManager.ConnectionStrings["IOOP_Assignment_Group_Adlina.Properties.Settings.MainDBConnectionString"].ConnectionString;
        static SqlConnection con; //SqlConnection is assigned/defined to con
        static SqlCommand cmd; //SqlCommand is assigned/defined to cmd
        static SqlDataReader dr; //SqlDataReader assigned/defined to dr

        //Constructor with three parameters  
        public ProfileUpdate(string username, string email, string password)
        {
            this.username = username;
            this.email = email;
            this.password = password;
        }

        //Constructor with one parameter
        public ProfileUpdate(string username)
        {
            this.username = username;
        }

        public string updateUser(string un)
        {
            
            string status;
            using (con = new SqlConnection(Connectionstring))// using the connection string by using (call SqlConnection by variable assigned) = new SqlConnection( variable that define the connection string above)
            {
                //have to have curly bracket after closing the brackets on Using
                con.Open(); //open connection
              
                // cmd already defined as SqlCommand above, so just use cmd = new SqlCommand ( put your query , con)
                cmd = new SqlCommand("UPDATE userData SET Username = @nm WHERE Username LIKE @ou;", con);// con refers to already defined SqlConnection
                cmd.Parameters.AddWithValue("@nm", un);
                cmd.Parameters.AddWithValue("@ou", username);

                int i = cmd.ExecuteNonQuery();
                if (i != 0)
                {
                    status = "Update Successfully.";
                }
                else
                {
                    status = "Unable to update.";
                }
            }
            con.Close();
            return status;
        }

        public string updateEm(string em)
        {
            string status;
            using (con = new SqlConnection(Connectionstring))
            {
                con.Open();

                cmd = new SqlCommand("UPDATE userData SET Email = @em WHERE Username LIKE @ou;", con);
                cmd.Parameters.AddWithValue("@em", em);
                cmd.Parameters.AddWithValue("@ou", username);

                int i = cmd.ExecuteNonQuery();
                if (i != 0)
                {
                    status = "Update Successfully.";
                }
                else
                {
                    status = "Unable to update.";
                }
            }

            con.Close();
            return status;
        }

        public string updatePass(string pa)
        {
            string status;
            using (con = new SqlConnection(Connectionstring))
            {
                con.Open();

                cmd = new SqlCommand("UPDATE userData SET Password = @pa WHERE Username LIKE @ou;", con);
                cmd.Parameters.AddWithValue("@pa", pa);
                cmd.Parameters.AddWithValue("@ou", username);

                int i = cmd.ExecuteNonQuery();
                if (i != 0)
                {
                    status = "Update Successfully.";
                }
                else
                {
                    status = "Unable to update.";
                }
            }

            con.Close();
            return status;
        }
    }
}
