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
    public partial class ForgotPassword : Form
    {
        private UserClass user;
        private PasswordGen genpass;

        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void ForgotPassword_Load(object sender, EventArgs e)
        {

        }

        private void EmptyAll()
        {
            TbUsername.Text = string.Empty;
        }

        private void BtnGen_Click(object sender, EventArgs e)
        {
            string user = TbUsername.Text;
            string password = null;

            if(PasswordGen.AunthenticateUser(user))
            {
                password = PasswordGen.GenRanPassForgot(user, 5);
                LblGenPass.Text = password;
                MessageBox.Show("Reset successful. Please login with the generated password and change it in your manage profile.");

            }
            else
            {
                MessageBox.Show("Invalid username.");
            }
            EmptyAll();
        }

        private void BtnBack3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin login = new FormLogin();
            login.ShowDialog();
        }
    }
}
