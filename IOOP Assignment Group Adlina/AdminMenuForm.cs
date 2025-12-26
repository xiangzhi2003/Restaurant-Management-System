using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_Assignment_Group_Adlina
{
    public partial class AdminMenuForm : Form
    {
        string OlUsername;

        public AdminMenuForm()
        {
            InitializeComponent();
        }

        public AdminMenuForm(string olusername)
        {
            InitializeComponent();
            this.OlUsername = olusername;
            DisplayWelcome(olusername);
        }

        private void DisplayWelcome(string olusername)
        {
            LblAddNew.Text = "Welcome " + olusername + " !";
        }

        private void ManAllUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageUserForm mu = new ManageUserForm();
            mu.ShowDialog();
        }

        private void BtnViewFeed_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewFBForm fb = new ViewFBForm();
            fb.ShowDialog();
        }

        private void BtnViewSales_Click(object sender, EventArgs e)
        {
            this.Hide();
            SalesForm ss = new SalesForm();
            ss.ShowDialog();
        }

        private void BtnManProfile1_Click(object sender, EventArgs e)
        {
            UpdateProfileForm up = new UpdateProfileForm(OlUsername);
            up.ShowDialog();
        }
        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin login = new FormLogin();
            login.ShowDialog();
        }
        
        private void RbtnManageAdmin_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AdminMenuForm_Load(object sender, EventArgs e)
        {

        }

        private void LblAddNew_Click(object sender, EventArgs e)
        {

        }


    }
}
