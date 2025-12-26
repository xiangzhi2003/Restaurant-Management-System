using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IOOP_Assignment_Group_Adlina
{
    public partial class FoodMenuForm : Form
    {
        public FoodMenuForm()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void grpChinese_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\MainDB.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();

            SqlCommand cmd = new SqlCommand("insert menu set foodItem=@foodItem,price=@price,category=@category where menu=@menuID", con);

            cmd.Parameters.AddWithValue("@MenuID", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@FoodItem", (textBox2.Text));
            cmd.Parameters.AddWithValue("@Price", int.Parse(textBox3.Text));
            cmd.Parameters.AddWithValue("@Category", comboBox1.GetItemText(comboBox1.SelectedItem));

            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Saved Successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);

            BinData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\MainDB.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();

            SqlCommand cmd = new SqlCommand("update menu set foodItem=@foodItem,price=@price,category=@category where menu=@menuID", con);

            cmd.Parameters.AddWithValue("@MenuID", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@FoodItem", (textBox2.Text));
            cmd.Parameters.AddWithValue("@Price", int.Parse(textBox3.Text));
            cmd.Parameters.AddWithValue("@Category", comboBox1.GetItemText(comboBox1.SelectedItem));

            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Update Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

            BinData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\MainDB.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();

            SqlCommand cmd = new SqlCommand("delete menu set foodItem=@foodItem,price=@price,category=@category where menu=@menuID", con);

            cmd.Parameters.AddWithValue("@MenuID", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@FoodItem", (textBox2.Text));
            cmd.Parameters.AddWithValue("@Price", int.Parse(textBox3.Text));
            cmd.Parameters.AddWithValue("@Category", comboBox1.GetItemText(comboBox1.SelectedItem));

            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Deleted Successfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);

            BinData();
        }

        void BinData()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\MainDB.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from menu order by menuID asc", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            s.DataSource = dt;
        }

        private void MenuForm_Load_1(object sender, EventArgs e)
        {
            BinData();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FoodMenu obj1 = new FoodMenu(textBox2.Text, textBox3.Text, comboBox1.GetItemText(comboBox1.SelectedItem));
            MessageBox.Show(obj1.MenuInsert());
            BinData();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            FoodMenu obj1 = new FoodMenu(textBox1.Text, textBox2.Text, textBox3.Text, comboBox1.GetItemText(comboBox1.SelectedItem));
            MessageBox.Show(obj1.MenuUpdate());
            BinData();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            FoodMenu obj1 = new FoodMenu(textBox1.Text, textBox2.Text, textBox3.Text, comboBox1.GetItemText(comboBox1.SelectedItem));
            MessageBox.Show(obj1.MenuDelete());
            BinData();
        }
    }
}
