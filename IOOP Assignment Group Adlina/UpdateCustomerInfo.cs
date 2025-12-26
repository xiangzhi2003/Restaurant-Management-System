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
    public partial class UpdateCustomerInfo : Form
    {
        public UpdateCustomerInfo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewUserForm newUserform = new NewUserForm(string.Empty);
            newUserform.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewEmForm newEm = new NewEmForm(string.Empty);
            newEm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewPassForm newPass = new NewPassForm(string.Empty);
            newPass.ShowDialog();
        }
    }
}
