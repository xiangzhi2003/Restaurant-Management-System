using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //importing the system data sql client. 
using System.Configuration;
using System.Runtime.Remoting.Contexts;

namespace IOOP_Assignment_Group_Adlina
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }




        public string Login(string un)
        {
            string status = null;
            SqlConnection con = new SqlConnection(@"Data Source=USER;Initial Catalog=admin;Integrated Security=True;"); //Database connection
            con.Open();

            SqlCommand cmd = new SqlCommand(SELECT count(*) from userData where Username=LblLoginUserEmail or Email=LblLoginUserEmail and Password=LblLoginPass)
        }

        private void BtnLogin_Click(object sender, EventArgs e) //When clicking login
        {
           

        }
    }
}
