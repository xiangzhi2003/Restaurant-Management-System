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
    public partial class CustomerMainMenu : Form
    {
        public CustomerMainMenu()
        {
            InitializeComponent();
        }

        private void CustomerMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FoodMenuForm mf = new FoodMenuForm();
            mf.ShowDialog();
        }

        private void orderfoodbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FoodMenuForm mf = new FoodMenuForm();
            mf.ShowDialog();
        }

        private void statusbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            RsvReportForm rsvReportForm = new RsvReportForm();
            rsvReportForm.ShowDialog();
        }

        private void feedbackbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FeedbackForm feedbackForm = new FeedbackForm();
            feedbackForm.ShowDialog();
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateCustomerInfo updateCustomerInfo = new UpdateCustomerInfo();
            updateCustomerInfo.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thankyou so much for ordering!!");
        }
    }
}
