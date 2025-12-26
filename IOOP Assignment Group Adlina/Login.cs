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
using System.Configuration;//importing the system configuration
using System.Runtime.Remoting.Messaging; 

namespace IOOP_Assignment_Group_Adlina
{

    public partial class FormLogin : Form
    {
        private UserClass user;
        private static string Connectionstring = ConfigurationManager.ConnectionStrings["IOOP_Assignment_Group_Adlina.Properties.Settings.MainDBConnectionString"].ToString();

        private void EmptyAll()
        {
            TbLoginUserEmail.Text = string.Empty;
            TbLoginPass.Text = string.Empty;
        }

        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }


        private void BtnLogin_Click(object sender, EventArgs e) //When clicking login
        {
            this.Hide();
            string stat = null;
            stat = UserClass.Login(TbLoginUserEmail.Text, TbLoginPass.Text);
            if (stat != null)
            {
                MessageBox.Show(stat);
            }
            EmptyAll();

        }

        private void BtnSignup_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp newsu = new SignUp();
            newsu.ShowDialog();

        }

        private void LlForgotPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ForgotPassword newfp = new ForgotPassword();
            newfp.ShowDialog();

        }
    }
}
