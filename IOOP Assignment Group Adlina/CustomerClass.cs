using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_Assignment_Group_Adlina
{
    internal class Customer
    {
        //objects
        public int CustomerId { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        private string Password { get; set; }
        public List<Order> Orders { get; private set; }
        public List<Reservation> Reservations { get; private set; }
        public List<Feedback> Feedbacks { get; private set; }

        //Constructor
        public Customer(int customerId, string name, string email, string password)
        {
            CustomerId = customerId;
            Name = name;
            Email = email;
            Password = password;
            Orders = new List<Order>();
            Reservations = new List<Reservation>();
            Feedbacks = new List<Feedback>();
        }

        //Methods
        public List<MenuItem> SearchFoodMenu(List<MenuItem> menu, Dictionary<string, string> filters)
        {
            var results = menu.AsEnumerable();
            foreach (var filter in filters)
            {
                results = results.Where(item => item.GetType().GetProperty(filter.Key)?.GetValue(item, null)?.ToString() == filter.Value);
            }
            return results.ToList();
        }

        public void OrderFood(List<MenuItem> menu, List<int> itemIds)
        {
            foreach (var itemId in itemIds)
            {
                var item = menu.FirstOrDefault(m => m.Id == itemId);
                if (item != null)
                {
                    Orders.Add(new Order
                    {
                        Id = Orders.Count + 1,
                        ItemId = itemId,
                        Status = "Pending",
                        Details = item
                    });
                }
            }
        }

        public void EditOrder(int orderId, int newItemId, List<MenuItem> menu)
        {
            var order = Orders.FirstOrDefault(o => o.Id == orderId);
            if (order != null)
            {
                var newItem = menu.FirstOrDefault(m => m.Id == newItemId);
                if (newItem != null)
                {
                    order.ItemId = newItemId;
                    order.Details = newItem;
                }
            }
        }

        public void DeleteOrder(int orderId)
        {
            var order = Orders.FirstOrDefault(o => o.Id == orderId);
            if (order != null)
            {
                Orders.Remove(order);
            }
        }

        public void SendFeedback(string message)
        {
            Feedbacks.Add(new Feedback
            {
                Id = Feedbacks.Count + 1,
                CustomerId = CustomerId,
                Message = message,
                Date = DateTime.Now
            });
        }

        public void UpdateProfile(string name, string email, string password)
        {
            Name = name;
            Email = email;
            Password = password;
        }
    }

    internal class MenuItem
    {
        //Objects
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
    }

    internal class Order
    {
        //Objects
        public int Id { get; set; }
        public int ItemId { get; set; }
        public string Status { get; set; }
        public MenuItem Details { get; set; }
    }

    internal class Reserve
    {
        //Objects
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string Type { get; set; }
        public DateTime Date { get; set; }
        public int NumberOfPeople { get; set; }
    }

    internal class Feedback
    {
        //Objects
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string Message { get; set; }
        public DateTime Date { get; set; }
    }


}

    

