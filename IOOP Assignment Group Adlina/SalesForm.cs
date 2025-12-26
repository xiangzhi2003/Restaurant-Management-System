using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_Assignment_Group_Adlina
{
    public partial class SalesForm : Form
    {
        private static string Connectionstring = ConfigurationManager.ConnectionStrings["IOOP_Assignment_Group_Adlina.Properties.Settings.MainDBConnectionString"].ConnectionString;
        static SqlConnection con; //SqlConnection is assigned to con
        static SqlCommand cmd; //SqlCommand is assigned to cmd
        static SqlDataReader dr; //SqlDataReader assigned to dr

        public SalesForm()
        {
            InitializeComponent();
        }

        private void SalesForm_Load(object sender, EventArgs e)
        {

        }

        private void FetchnBindData(string filter)
        {
            using(con = new SqlConnection(Connectionstring))
            {
                con.Open();
                string query = "";

                // based on filter, construct sql query depends on it

                switch (filter)
                {
                    case "Daily":
                        query = @"SELECT CONVERT (date, date) AS PaymentDate, SUM (totalPrice) AS RMTotalSales FROM customer
                                GROUP BY CONVERT (date, date) ORDER BY PaymentDate";
                        break;

                    case "Monthly":
                        query = @"SELECT YEAR(date) AS Year, MONTH(date) AS Month, SUM (totalPrice) AS RMTotalSales FROM customer
                                GROUP BY YEAR(date), MONTH(date) ORDER BY Year, Month";
                        break;

                    case "Yearly":
                        query = @"SELECT YEAR(date) AS Year, SUM (totalPrice) AS RMTotalSales FROM customer
                                GROUP BY YEAR(date) ORDER BY Year";
                        break;
                }

                cmd = new SqlCommand(query, con);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;  
            }

        }

        private void CbSales_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SelectedFilter = CbSales.SelectedItem.ToString();
            FetchnBindData(SelectedFilter);
        }

        private void BtnBack5_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMenuForm amf = new AdminMenuForm();
            amf.ShowDialog();
        }
    }
}
