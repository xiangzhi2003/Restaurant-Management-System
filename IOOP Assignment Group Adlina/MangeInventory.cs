using System;
using System.Collections;
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
    public partial class ManageInventory : Form
    {
        private string search;

        private string ingredient;
        public ManageInventory()
        {
            InitializeComponent();
        }

        private void ManageInventory_Load(object sender, EventArgs e)
        {
            ArrayList ingredient = new ArrayList();

            ingredient = Chef.viewinventory();
            foreach (var item in ingredient)
            {
                listInventory.Items.Add(item);
            }
        }

        private void listInventory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listInventory.SelectedItem != null) 
            { 
                ingredient = listInventory.SelectedItem.ToString();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int amount = (int)numEdit.Value;
            Chef obj1 = new Chef(ingredient);
            MessageBox.Show(obj1.editAmount(amount));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Chef obj1 = new Chef(txtIngredient.Text);
            MessageBox.Show(obj1.addInventory());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Chef obj = new Chef(txtIngredient.Text);
            MessageBox.Show(obj.deleteInventory());
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtSearch != null) 
            {
                search = txtSearch.Text;
                listInventory.Items.Clear();
                Chef obj1 = new Chef(search);
                Chef.searchIngredient(obj1);
                listInventory.Items.Add(obj1);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ManageInventory newform = new ManageInventory();
            newform.ShowDialog();
            this.Close();
        }
    }
}
