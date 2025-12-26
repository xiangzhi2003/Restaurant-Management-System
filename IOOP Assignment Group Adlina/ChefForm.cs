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
    public partial class ChefForm : Form
    {
        public ChefForm()
        {
            InitializeComponent();
        }

        private void ChefForm_Load(object sender, EventArgs e)
        {

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            ViewUpdateOrder od = new ViewUpdateOrder();
            od.ShowDialog();
        }

        private void btnManageInventory_Click(object sender, EventArgs e)
        {
            ManageInventory mi = new ManageInventory();
            mi.ShowDialog();
        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            ChefUpdateProfile up = new ChefUpdateProfile();
            up.ShowDialog();
        }
    }
}
