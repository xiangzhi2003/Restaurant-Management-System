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
    public partial class ManageUserForm : Form
    {
        public ManageUserForm()
        {
            InitializeComponent();
        }

        private void RbtnViewUsers_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BtnViewReg_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewUsersForm vu = new ViewUsersForm();
            vu.ShowDialog();
        }

        private void BtnAddNewus_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddUserForm addnew = new AddUserForm();
            addnew.ShowDialog();
        }

        private void BtnChangeRole_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormChangeroleus cr = new FormChangeroleus();
            cr.ShowDialog();
        }

        private void BtnDelReguser_Click(object sender, EventArgs e)
        {
            this.Hide();
            DelUserForm del = new DelUserForm();
            del.ShowDialog();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMenuForm admin = new AdminMenuForm();
            admin.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
