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
    public partial class DelUserForm : Form
    {
        private UserClass user;
        private static string Connectionstring = ConfigurationManager.ConnectionStrings["IOOP_Assignment_Group_Adlina.Properties.Settings.MainDBConnectionString"].ConnectionString;
        static SqlConnection con; //SqlConnection is assigned to con
        static SqlCommand cmd; //SqlCommand is assigned to cmd
        static SqlDataReader dr; //SqlDataReader assigned to dr
        static SqlDataAdapter da; //SQlDataAdapter assigned to da
        public DelUserForm()
        {
            InitializeComponent();
        }

        public void EmptyAll()
        {
            TbUserID.Text = string.Empty;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string stat = null;
            stat = UserClass.DeleteUser(TbUserID.Text);
            if (stat != null)
            {
                MessageBox.Show(stat);
            }
            EmptyAll();


        }

        private void DelUserForm_Load(object sender, EventArgs e)
        {

        }

        private void BtnBack3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageUserForm muf = new ManageUserForm();
            muf.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
