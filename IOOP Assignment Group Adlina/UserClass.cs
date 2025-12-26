using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.CompilerServices;
using System.Data;
using System.Text.RegularExpressions;
namespace IOOP_Assignment_Group_Adlina
{
    public class UserClass
    {
        // object , field
        public int id;
        public string username, email, password, role;
        private static string Connectionstring = ConfigurationManager.ConnectionStrings["IOOP_Assignment_Group_Adlina.Properties.Settings.MainDBConnectionString"].ConnectionString;
        static SqlConnection con; //SqlConnection is assigned to con
        static SqlCommand cmd; //SqlCommand is assigned to cmd
        static SqlDataReader dr; //SqlDataReader assigned to dr
        static SqlDataAdapter da; //SQlDataAdapter assigned to da

        // constructor
        public UserClass(string username, string email, string password, string role)
        {
            this.username = username;
            this.email = email; 
            this.password = password;   
            this.role = role;
        }

        public UserClass()
        {

        }
        public UserClass(int id)
        {
            this.id = id;
        }


        // methods
        public static bool ValidateEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$"; // ^ start of the string, [^@\s]+ at least 1 character before @, [^@\s]+ at least 1 character after @, \. is the dot, $ asserts position at the end of string
            return Regex.IsMatch(email, pattern);
        }

        public static string Registernew(string username, string email, string password, string role)
        {
            string status = null;
            using (con = new SqlConnection(Connectionstring))
            {
                con.Open();
                ValidateEmail(email);
                if (username != string.Empty || email != string.Empty || password != string.Empty || role != string.Empty) //checking if the user exist or not
                {
                    cmd = new SqlCommand("SELECT * FROM userData WHERE username = @a and email = @b", con);
                    cmd.Parameters.AddWithValue("@a", username);
                    cmd.Parameters.AddWithValue ("@b", email);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                        MessageBox.Show("User exist. Try another username/email.");
                    }
                    else //if not exist, continue adding data into db
                    {
                        dr.Close();
                        cmd = new SqlCommand("INSERT INTO userData VALUES (@username, @email, @password, @role)", con);
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@password", password);
                        cmd.Parameters.AddWithValue("@role", role);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("User added. Please login.");
                    }
                }
                else
                    status = "Please fill in all the fields.";
                con.Close();
                return status;
            }

        }

        public static string AdminAddNew (string username, string email, string role)
        {
            string status = null;
            using (con = new SqlConnection(Connectionstring))
            {
                con.Open();
                ValidateEmail(email);
                if (username != string.Empty || email != string.Empty || role != string.Empty)
                {
                    cmd = new SqlCommand("SELECT * FROM userData WHERE username = @a", con);
                    cmd.Parameters.AddWithValue("@a", username);
                    cmd.Parameters.AddWithValue("@b", email);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                        MessageBox.Show("User exist. Try another username/email.");
                    }
                    else
                    {
                        dr.Close();
                        cmd = new SqlCommand("INSERT INTO userData (Username, Email, Role) VALUES (@username, @email, @role)", con);
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@role", role);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("User added successfully");

                    }
                }
                else
                    status = "Please fill in all the fields.";
                con.Close();
                return status;
            }
        }


        public static string Login(string username,string password)
        {
            string status = null;
            using (con = new SqlConnection(Connectionstring))
            {
                con.Open();
                cmd = new SqlCommand("SELECT COUNT(*) FROM userData WHERE (username = @a or email = @a) and password = @b", con);
                cmd.Parameters.AddWithValue("@a", username);
                cmd.Parameters.AddWithValue("@b", password);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count > 0)
                {
                    cmd = new SqlCommand("SELECT Role FROM userData WHERE (username = @a or email = @a) and password = @b", con);
                    cmd.Parameters.AddWithValue("@a", username);
                    cmd.Parameters.AddWithValue("@b", password);

                    string userRole = cmd.ExecuteScalar().ToString();

                    if (userRole == "Admin")
                    {
                        FormLogin login = new FormLogin();
                        AdminMenuForm admin =new AdminMenuForm(username);
                        login.Hide();
                        admin.ShowDialog();
                    }
                    else if (userRole == "Manager")
                    {
                        FormLogin login = new FormLogin();
                        ManagerForm man = new ManagerForm(username);
                        login.Hide();
                        man.ShowDialog();
                    }
                    else if (userRole == "Chef")
                    {
                        FormLogin login = new FormLogin();
                        ChefForm cf = new ChefForm();
                        cf.Hide();
                        cf.ShowDialog();
                    }
                    else if (userRole == "Customer")
                    {
                        FormLogin login = new FormLogin();
                        CustomerMainMenu customer = new CustomerMainMenu();
                        login.Hide();
                        customer.ShowDialog();
                    }

                }

                else if (username == string.Empty || password == string.Empty)
                {
                    status = "Please fill in all fields.";
                }

                else
                {
                    status = "Incorrect username/email or password.";
                    FormLogin login = new FormLogin();
                    login.Show();
                }

                con.Close();
                return status;
            } 

        }

        public static string DeleteUser(string id)
        {
            string status = null;
            using (con = new SqlConnection(Connectionstring))
            {
                con.Open();

                if (int.TryParse(id, out int value))
                {
                    cmd = new SqlCommand("DELETE FROM userData WHERE userID = @a", con);
                    cmd.Parameters.AddWithValue("a", id);
                    int RowsDeleted = cmd.ExecuteNonQuery();
                    if (RowsDeleted > 0)
                    {
                        MessageBox.Show(" Successfully deleted.");
                    }
                    else
                    {
                        MessageBox.Show("Error : user not exist.");
                    }
                    
                }
                else
                    status = "The number of userID only accepted.";
            }
            con.Close() ;
            return status;


        }


        public static string UpdateRole(string role, string id)
        {
            string status;
            using (con = new SqlConnection(Connectionstring))
            {
                con.Open();

                cmd = new SqlCommand("UPDATE userData SET Role = @ro WHERE userID = @id", con);
                cmd.Parameters.AddWithValue("@ro", role);
                cmd.Parameters.AddWithValue("id", id);
                
                int i = cmd.ExecuteNonQuery();
                if (i>0)
                {
                    status = "Changed role for userID :" + id + "successfully";
                }
                else
                {
                    status = "Invalid userID or role not exist.";
                }

                con.Close();
                return status;


            }
        }


    }

}
