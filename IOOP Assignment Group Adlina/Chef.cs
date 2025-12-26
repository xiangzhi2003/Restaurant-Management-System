using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOOP_Assignment_Group_Adlina
{
    internal class Chef
    {
        private string name;
        private string password;
        private string email;
        private string status;
        private int orderID;
        private int inAmount;
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MainDB"].ToString());

        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public string Status { get => status; set => status = value; }
        public int InAmount { get => inAmount; set => inAmount = value; }

        public Chef(string nm) 
        { 
            name = nm;
        }
        public Chef(int o)
        {
            orderID = o;
        }
        public Chef(string em,string p,string s)
        {
            email = em;
            password = p;
            status = s;
        }

        public static void viewprofile(Chef o1)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from userData where username=@a", con);
            cmd.Parameters.AddWithValue("@a", o1.name);

            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                o1.email = rd.GetString(2);
                o1.password = rd.GetString(3);
            }
            con.Close();
        }

        public string updateprofile(string em, string p)
        {
            string status;
            con.Open();

            SqlCommand cmd = new SqlCommand("update userData set email =@e, password=@p where username = @nm", con);
            cmd.Parameters.AddWithValue("@e", em);
            cmd.Parameters.AddWithValue("@p", p);
            cmd.Parameters.AddWithValue("@nm", name);

            int i = cmd .ExecuteNonQuery();
            if (i != 0)
                status = "Update Successfully.";
            else
                status = "Unable to update.";
            con.Close();
            return status;
        }

        public static ArrayList vieworder()
        {
            ArrayList o = new ArrayList();
            con.Open();
            SqlCommand cmd = new SqlCommand("select orderID, foodItem from order", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                o.Add(rd.GetString(0));
            }
            con.Close();
            return o;
        }

        public string updateorder_status(string s)
        {
            string status;

            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE chef SET orderStatus = @s WHERE orderID = @o", con);
            cmd.Parameters.AddWithValue("@s", s);
            cmd.Parameters.AddWithValue("@o", orderID);

            int i = cmd.ExecuteNonQuery();
            if (i != 0)
                status = "Update Successfully.";
            else
                status = "Unable to update.";

            con.Close();
            return status;
        }

        public static void vieworderstatus(Chef o1)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from chef where orderID=@o", con);
            cmd.Parameters.AddWithValue("@o", o1.orderID);

            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                o1.status = rd.GetString(4);
            }
            con.Close();
        }

        public static ArrayList viewinventory()
        {
            ArrayList i = new ArrayList();
            con.Open();
            SqlCommand cmd = new SqlCommand("select ingredient from inventory", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                i.Add(rd.GetString(0));
            }
            con.Close();
            return i;
        }

        public string editAmount(int inAmount)
        {
            string status;
            con.Open();
            SqlCommand cmd = new SqlCommand("update inventory set amount =@a where ingredient =@i", con);
            cmd.Parameters.AddWithValue("@a", inAmount);
            cmd.Parameters.AddWithValue("@i", name);

            int i = cmd.ExecuteNonQuery();
            if (i != 0)
                status = "Edit Successfully.";
            else
                status = "Unable to edit.";

            con.Close();
            return status;
        }

        public string addInventory()
        {
            string status;
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into inventory(ingredient,amount) values(@i,'0')", con);
            cmd.Parameters.AddWithValue("@i", name);
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
                status = "Added Successfully.";
            else
                status = "Unable to add.";

            con.Close();
            return status;
        }

        public string deleteInventory() 
        {
            string status;
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from inventory where ingredient =@i", con);
            cmd.Parameters.AddWithValue("@i", name);
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
                status = "Deleted Successfully.";
            else
                status = "Unable to delete.";

            con.Close();
            return status;
        }
        public static void searchIngredient(Chef o1)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from inventory where ingredient=@i", con);
            cmd.Parameters.AddWithValue("@i", o1.name);

            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                o1.status = rd.GetString(1);
            }
            con.Close();
        }
    }
}
