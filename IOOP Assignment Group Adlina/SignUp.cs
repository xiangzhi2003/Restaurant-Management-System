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
    public partial class SignUp : Form
    {
        private UserClass user;
        private static string Connectionstring = ConfigurationManager.ConnectionStrings["IOOP_Assignment_Group_Adlina.Properties.Settings.MainDBConnectionString"].ToString();
        public SignUp()
        {
            InitializeComponent();
        }

        public void EmptyAll()
        {
            TbSignUser.Text = string.Empty;
            TbSignEm.Text = string.Empty;
            TbSignPass.Text = string.Empty;
            CBSignrole.SelectedIndex = -1;
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            
        }

        public void BtnSignUp_Click(object sender, EventArgs e)
        {
            string stat = null;
            stat = UserClass.Registernew(TbSignUser.Text, TbSignEm.Text, TbSignPass.Text, CBSignrole.Text);
            if (stat != null)
            {
                MessageBox.Show(stat);
            }
            UserClass.ValidateEmail(TbSignEm.Text);
            EmptyAll();
            
        }

        private void BtnBack3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin backlog = new FormLogin();
            backlog.ShowDialog();
        }

        private void CBSignrole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
