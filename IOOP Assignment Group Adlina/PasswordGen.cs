using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace IOOP_Assignment_Group_Adlina
{
    public class PasswordGen
    {
        //field, object
        private static string Connectionstring = ConfigurationManager.ConnectionStrings["IOOP_Assignment_Group_Adlina.Properties.Settings.MainDBConnectionString"].ConnectionString;
        static SqlConnection con; //SqlConnection is assigned to con
        static SqlCommand cmd; //SqlCommand is assigned to cmd
        static SqlDataReader dr; //SqlDataReader assigned to dr


        // method
        public static bool AunthenticateUser(string user)
        {
            bool userExist = false;
            using (con = new SqlConnection(Connectionstring))
            {
                con.Open();
                cmd = new SqlCommand("SELECT COUNT(*) FROM userData WHERE Username = @a", con);// checks if username is in database
                cmd.Parameters.AddWithValue("@a", user);

                int count =  (int)cmd.ExecuteScalar();
                userExist = (count >0);
            }
            return userExist;
        }

        public static string GenRandomPassword(string username, string email, string role, int length)
        {
            // list of all characters that would be in password (all alphabets and all digits)
            char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            Random rnd = new Random();  // initialize a random number generator
            string password = "";  // Result will be stored here

            // loop number of letters specified by the length parameter
            for (int i = 0; i < length; i++)
            {
                password += alphabet[rnd.Next(0, alphabet.Length)]; // generate a random index, get the corresponding character, and add to password
            }
            using (con = new SqlConnection(Connectionstring))
            {
                con.Open();
                cmd = new SqlCommand("INSERT INTO userData VALUES (@username, @email, @password, @role)", con);// insert into userData table
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@role", role);
                cmd.ExecuteNonQuery();
            }
            return password;
        }

        public static string GenRanPassForgot(string username, int length)
        {
            char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            Random rnd = new Random();
            string password = "";

            for (int i = 0; i < length; i++)
            {
                password += alphabet[rnd.Next(0, alphabet.Length)];
            }

            using (con = new SqlConnection(Connectionstring))
            {
                con.Open();
                cmd = new SqlCommand("UPDATE userData SET Password = @pa WHERE Username LIKE @un", con);
                cmd.Parameters.AddWithValue("@pa", password);
                cmd.Parameters.AddWithValue("@un", username);
                cmd.ExecuteNonQuery();
            }
            return password;
        }
    }
}
