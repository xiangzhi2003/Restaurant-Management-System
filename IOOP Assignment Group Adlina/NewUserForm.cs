using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_Assignment_Group_Adlina
{
    public partial class NewUserForm : Form
    {
        private ProfileUpdate updateUser;
        private static string Connectionstring = ConfigurationManager.ConnectionStrings["IOOP_Assignment_Group_Adlina.Properties.Settings.MainDBConnectionString"].ToString();

        public NewUserForm(string olusername)
        {
            InitializeComponent();
            updateUser = new ProfileUpdate(olusername);
        }

        public void EmptyAll()
        {
            TbNewUser.Text = string.Empty;
        }
    
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            string stat = null;
            stat = updateUser.updateUser(TbNewUser.Text);
            if (stat != null)
            {
                MessageBox.Show(stat);
            }
            EmptyAll();

        }

        private void BtnBack6_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateProfileForm upf = new UpdateProfileForm(TbNewUser.Text);
            upf.ShowDialog();
        }

        private void NewUserForm_Load(object sender, EventArgs e)
        {

        }
    }
}
