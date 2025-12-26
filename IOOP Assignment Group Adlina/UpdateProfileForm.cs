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
    public partial class UpdateProfileForm : Form
    {
        string olusername;

        public UpdateProfileForm(string OlUsername)
        {
            InitializeComponent();
            olusername = OlUsername;
        }

        private void UpdateProfileForm_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LblProfileSett_Click(object sender, EventArgs e)
        {

        }

        private void BtnNewUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewUserForm changeuser = new NewUserForm(olusername);
            changeuser.ShowDialog();
        }

        private void BtnNewEm_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewEmForm changeem = new NewEmForm(olusername);
            changeem.ShowDialog();
        }

        private void BtnNewPass_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewPassForm changepass = new NewPassForm(olusername);
            changepass.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
