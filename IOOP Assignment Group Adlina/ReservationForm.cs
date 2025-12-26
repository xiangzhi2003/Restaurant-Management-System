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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace IOOP_Assignment_Group_Adlina
{
    public partial class ReservationForm : Form
    {
        public ReservationForm()
        {
            InitializeComponent();
        }

        void BinData()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\xiang\source\repos\IOOP-Assignment-Group-Adlina4\IOOP Assignment Group Adlina\MainDB.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from reservation order by eventDate asc", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void ReservationForm_Load(object sender, EventArgs e)
        {
            BinData();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //dateTimePicker1.CustomFormat = "yyyy/mm/dd";
        }

        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                //dateTimePicker1.CustomFormat = "";
            }
        }




        private void button1_Click_1(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\xiang\source\repos\IOOP-Assignment-Group-Adlina1\IOOP Assignment Group Adlina\MainDB.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=False");
            //con.Open();

            //SqlCommand cmd = new SqlCommand("insert into reservation(customerID,amountPeople,eventDate,eventHall,rsvStatus) values(@customerID,@amountPeople,@eventDate,@eventHall,@rsvStatus)", con);

            //cmd.Parameters.AddWithValue("@CustomerID", int.Parse(textBox1.Text));
            //cmd.Parameters.AddWithValue("@AmountPeople", int.Parse(textBox2.Text));
            //cmd.Parameters.AddWithValue("@EventDate", dateTimePicker1.Value);
            //cmd.Parameters.AddWithValue("@EventHall", comboBox1.GetItemText(comboBox1.SelectedItem));
            //cmd.Parameters.AddWithValue("@RsvStatus", comboBox2.GetItemText(comboBox2.SelectedItem));

            //cmd.ExecuteNonQuery();

            //con.Close();

            //MessageBox.Show("Saved Successfully", "Save" , MessageBoxButtons.OK, MessageBoxIcon.Information);

            //BinData();
            Reservation obj1 = new Reservation(textBox1.Text, textBox2.Text, dateTimePicker1.Value.ToString(), comboBox1.GetItemText(comboBox1.SelectedItem), comboBox2.GetItemText(comboBox2.SelectedItem), textBox3.Text);
            MessageBox.Show(obj1.CustomerReservation());
            BinData();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\xiang\source\repos\IOOP-Assignment-Group-Adlina1\IOOP Assignment Group Adlina\MainDB.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=False");
            //con.Open();

            //SqlCommand cmd = new SqlCommand("update reservation set amountPeople=@amountPeople,eventDate=@eventDate,eventHall=@eventHall,rsvStatus=@rsvStatus where customerID=@customerID", con);

            //cmd.Parameters.AddWithValue("@CustomerID", int.Parse(textBox1.Text));
            //cmd.Parameters.AddWithValue("@AmountPeople", int.Parse(textBox2.Text));
            //cmd.Parameters.AddWithValue("@EventDate", dateTimePicker1.Value);
            //cmd.Parameters.AddWithValue("@EventHall", comboBox1.GetItemText(comboBox1.SelectedItem));
            //cmd.Parameters.AddWithValue("@RsvStatus", comboBox2.GetItemText(comboBox2.SelectedItem));

            //cmd.ExecuteNonQuery();

            //con.Close();

            //MessageBox.Show("Update Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //BinData();
            Reservation obj1 = new Reservation(textBox1.Text, textBox2.Text, dateTimePicker1.Value.ToString(), comboBox1.GetItemText(comboBox1.SelectedItem), comboBox2.GetItemText(comboBox2.SelectedItem) , textBox3.Text);
            MessageBox.Show(obj1.UpdateReservation());
            BinData();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\xiang\source\repos\IOOP-Assignment-Group-Adlina1\IOOP Assignment Group Adlina\MainDB.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=False");
            //con.Open();

            //SqlCommand cmd = new SqlCommand("delete reservation set amountPeople=@amountPeople,eventDate=@eventDate,eventHall=@eventHall,rsvStatus=@rsvStatus where customerID=@customerID", con);

            //cmd.Parameters.AddWithValue("@CustomerID", int.Parse(textBox1.Text));
            //cmd.Parameters.AddWithValue("@AmountPeople", int.Parse(textBox2.Text));
            //cmd.Parameters.AddWithValue("@EventDate", dateTimePicker1.Value);
            //cmd.Parameters.AddWithValue("@EventHall", comboBox1.GetItemText(comboBox1.SelectedItem));
            //cmd.Parameters.AddWithValue("@RsvStatus", comboBox2.GetItemText(comboBox2.SelectedItem));

            //cmd.ExecuteNonQuery();

            //con.Close();

            //MessageBox.Show("Deleted Successfully", "delete", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //BinData();
            Reservation obj1 = new Reservation(textBox1.Text, textBox2.Text, dateTimePicker1.Value.ToString(), comboBox1.GetItemText(comboBox1.SelectedItem), comboBox2.GetItemText(comboBox2.SelectedItem) , textBox3.Text);
            MessageBox.Show(obj1.DeleteReservation());
            BinData();
        }
    }
}