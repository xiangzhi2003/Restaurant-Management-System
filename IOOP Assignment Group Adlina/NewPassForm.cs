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
    public partial class NewPassForm : Form
    {
        private ProfileUpdate updateUser;
        public NewPassForm(string olusername)
        {
            InitializeComponent();
            updateUser = new ProfileUpdate(olusername);
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            string stat = null;
            stat = updateUser.updatePass(TbNewPass.Text);
            if (stat != null)
            {
                MessageBox.Show(stat);
            }
        }

        private void BtnBack6_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateProfileForm upf = new UpdateProfileForm(TbNewPass.Text);
            upf.ShowDialog();
        }
    }
}
