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
    public partial class ViewUsersForm : Form
    {
        private UserClass user;
        private static string Connectionstring = ConfigurationManager.ConnectionStrings["IOOP_Assignment_Group_Adlina.Properties.Settings.MainDBConnectionString"].ToString();
        static SqlConnection con; //SqlConnection is assigned to con
        static SqlCommand cmd; //SqlCommand is assigned to cmd
        static SqlDataReader dr; //SqlDataReader assigned to dr
        static SqlDataAdapter da; //SQlDataAdapter assigned to da
        public ViewUsersForm()
        {
            InitializeComponent();
        }
        private void ViewUsersForm_Load(object sender, EventArgs e)
        {
            using (con = new SqlConnection(Connectionstring))
            {
                con.Open();
                da = new SqlDataAdapter("SELECT userID, Username, Email, Role FROM userData", con);
                DataSet ds = new DataSet();
                da.Fill(ds, "userData");
                dataGridView1.DataSource = ds.Tables["userData"].DefaultView;
            }
        }



        private void BtnBack2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageUserForm muf = new ManageUserForm();
            muf.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
