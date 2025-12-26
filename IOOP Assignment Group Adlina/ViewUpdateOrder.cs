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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace IOOP_Assignment_Group_Adlina
{
    public partial class ViewUpdateOrder : Form
    {
        private string orders;
        public ViewUpdateOrder()
        {
            InitializeComponent();
        }

        private void Order_Load(object sender, EventArgs e)
        {

            ArrayList order = new ArrayList();

            order = Chef.vieworder();
            foreach (var item in order) 
            {
                listViewOrders.Items.Add(item);
            }
        }

        private void listViewOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewOrders.SelectedItem != null)
            {
                orders = listViewOrders.SelectedItem.ToString();
            }
            Chef obj1 = new Chef(orders);
            Chef.vieworderstatus(obj1);

            cmbstatus.Text = obj1.Status;
        }

        private void btnupdatestatus_Click(object sender, EventArgs e)
        {
            Chef obj1 = new Chef(orders);
            MessageBox.Show(obj1.updateorder_status(cmbstatus.SelectedItem.ToString()));
        }

        private void listViewOrders_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
