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
    public partial class ChefUpdateProfile : Form
    {
        public static string username;
        public ChefUpdateProfile()
        {
            InitializeComponent();
        }

        public ChefUpdateProfile(string un)
        {
            InitializeComponent();
            username = un; 
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Chef obj1 =new Chef(username);
            MessageBox.Show(obj1.updateprofile(txtEmail.Text, txtPassword.Text));
        }

        private void ChefUpdateProfile_Load(object sender, EventArgs e)
        {
            Chef obj1 = new Chef(username);

            Chef.viewprofile(obj1);

            txtEmail.Text = obj1.Email;
            txtPassword.Text = obj1.Password;
        }
    }
}
