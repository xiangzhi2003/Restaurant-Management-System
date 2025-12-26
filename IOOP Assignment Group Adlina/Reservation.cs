using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace IOOP_Assignment_Group_Adlina
{
    internal class Reservation
    {
        private string customerID;
        private string amountPeople;
        private string eventDate;
        private string eventHall;
        private string rsvStatus;
        private string CustName;
        static SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\xiang\source\repos\IOOP-Assignment-Group-Adlina4\IOOP Assignment Group Adlina\MainDB.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=False");

        public string CustomerID { get => customerID; set => customerID = value; }

        public string AmountPeople { get => amountPeople; set => amountPeople = value; }

        public string EventDate { get => eventDate; set => eventDate = value; }

        public string EventHall { get => eventHall; set => eventHall = value; }

        public string RsvStatus { get => rsvStatus; set => rsvStatus = value; }

        public string custName { get => CustName; set => CustName = value; }


        //Constructor with three parameters  
        public Reservation(string customerID, string amountPeople, string eventDate, string eventHall, string rsvStatus , string CustName)
        {
            this.customerID = customerID;
            this.amountPeople = amountPeople;
            this.eventDate = eventDate;
            this.eventHall = eventHall;
            this.rsvStatus = rsvStatus;
            this.CustName = CustName;
        }

        //Constructor with one parameter
        public Reservation(string customerID)
        {
            this.customerID = customerID;
        }


        public string CustomerReservation()
        {
            string status;
            con.Open();

            SqlCommand cmd = new SqlCommand("insert into reservation(customerID,amountPeople,eventDate,eventHall,rsvStatus,CustName) values(@id ,@ppl,@dt , @hl , @st , @CN);", con);
            cmd.Parameters.AddWithValue("@id", customerID);
            cmd.Parameters.AddWithValue("@ppl", amountPeople);
            cmd.Parameters.AddWithValue("@dt", DateTime.Parse(eventDate));
            cmd.Parameters.AddWithValue("@hl", eventHall);
            cmd.Parameters.AddWithValue("@st", rsvStatus);
            cmd.Parameters.AddWithValue("@CN", CustName);

            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                status = "Save Successfully.";
            }
            else
            {
                status = "Unable to save.";
            }
            con.Close();
            return status;
        }

        public string UpdateReservation()
        {
            string status;
            con.Open();

            SqlCommand cmd = new SqlCommand("update reservation set amountPeople=@ppl,eventDate=@dt,eventHall=@hl,rsvStatus=@st,CustName=@CN where customerID=@id", con);
            cmd.Parameters.AddWithValue("@id", customerID);
            cmd.Parameters.AddWithValue("@ppl", amountPeople);
            cmd.Parameters.AddWithValue("@dt", DateTime.Parse(eventDate));
            cmd.Parameters.AddWithValue("@hl", eventHall);
            cmd.Parameters.AddWithValue("@st", rsvStatus);
            cmd.Parameters.AddWithValue("@CN", CustName);

            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                status = "Update Successfully.";
            }
            else
            {
                status = "Unable to update.";
            }
            con.Close();
            return status;
        }

        public string DeleteReservation()
        {
            string status;
            con.Open();

            SqlCommand cmd = new SqlCommand("delete from reservation where customerID=@id", con);
            cmd.Parameters.AddWithValue("@id", customerID);
            cmd.Parameters.AddWithValue("@ppl", amountPeople);
            cmd.Parameters.AddWithValue("@dt", DateTime.Parse(eventDate));
            cmd.Parameters.AddWithValue("@hl", eventHall);
            cmd.Parameters.AddWithValue("@st", rsvStatus);
            cmd.Parameters.AddWithValue("@CN", CustName);

            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                status = "Delete Successfully.";
            }
            else
            {
                status = "Unable to delete.";
            }
            con.Close();
            return status;
        }
    }
}
