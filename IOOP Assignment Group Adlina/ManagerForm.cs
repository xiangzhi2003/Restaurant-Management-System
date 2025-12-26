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
    public partial class ManagerForm : Form
    {
        string olUsername;

        public string OlUsername { get { return olUsername; } }

        public ManagerForm()
        {
            InitializeComponent();
        }

        public ManagerForm(string olUsername)
        {
            InitializeComponent();
            this.olUsername = olUsername;
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            UpdateProfileForm ad= new UpdateProfileForm(olUsername);
            ad.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            ReservationForm ad = new ReservationForm();
            ad.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            FoodMenuForm ad = new FoodMenuForm();
            ad.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Welcome", olUsername);
        }
    }
}
