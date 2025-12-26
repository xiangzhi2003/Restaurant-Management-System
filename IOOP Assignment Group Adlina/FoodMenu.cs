using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOOP_Assignment_Group_Adlina
{
    internal class FoodMenu
    {
        private string menuID;
        private string foodItem;
        private string price;
        private string category;
        
        static SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\MainDB.mdf;Integrated Security=True;Connect Timeout=30");

        public string MenuID { get => menuID; set => menuID = value; }

        public string FoodItem { get => foodItem; set => foodItem = value; }

        public string Price { get => price; set => price = value; }


        //Constructor with three parameters  
        public FoodMenu(string menuID, string foodItem, string price, string category)
        {
            this.menuID = menuID;
            this.foodItem = foodItem;
            this.price = price;
            this.category = category;
        }
        public FoodMenu(string foodItem, string price, string category)
        {
            this.foodItem = foodItem;
            this.price = price;
            this.category = category;
        }


        //Constructor with one parameter
        public FoodMenu(string menuID)
        {
            this.menuID = menuID;
        }


        public string MenuInsert()
        {
            string status;
            con.Open();

            SqlCommand cmd = new SqlCommand("insert into menu(foodItem,price,category) values(@fi,@pr , @ct);", con);
            cmd.Parameters.AddWithValue("@fi", foodItem);
            cmd.Parameters.AddWithValue("@pr", price);
            cmd.Parameters.AddWithValue("@ct", category);

            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                status = "Save Successfully.";
            }
            else
            {
                status = "Unable to save.";
            }
            con.Close();
            return status;
        }

        public string MenuUpdate()
        {
            string status;
            con.Open();

            SqlCommand cmd = new SqlCommand("update menu set foodItem=@fi,price=@pr,category=@ct where menuID=@mn", con);
            cmd.Parameters.AddWithValue("@mn", menuID);
            cmd.Parameters.AddWithValue("@fi", foodItem);
            cmd.Parameters.AddWithValue("@pr", price);
            cmd.Parameters.AddWithValue("@ct", category);

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

        public string MenuDelete()
        {
            string status;
            con.Open();

            SqlCommand cmd = new SqlCommand("delete from menu where menuID=@mn", con);
            cmd.Parameters.AddWithValue("@mn", menuID);
            cmd.Parameters.AddWithValue("@fi", foodItem);
            cmd.Parameters.AddWithValue("@pr", price);
            cmd.Parameters.AddWithValue("@ct", category);

            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                status = "Delete Successfully.";
            }
            else
            {
                status = "Unable to delete.";
            }
            con.Close();
            return status;
        }
    }
}


