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
    public partial class FeedbackForm : Form
    {
        public FeedbackForm()
        {
            InitializeComponent();
        }

        private void FeedbackForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks for your feedback, Hoping to see you soon again!!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FoodMenuForm mf = new FoodMenuForm();
            mf.ShowDialog();
        }
    }
}
