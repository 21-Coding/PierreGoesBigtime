using System.Collections.Generic;
using System;



namespace VendorTracker.Models
{
    public class Order
    {
        public string Info { get; set; }
        public int Id { get; set; }
        public string Payment { get; set; }
        public string Date { get; set; }
        public string Location { get; set; }

        private static List<Order> _instances = new List<Order> { };


        public Order(string info, string payment, string date, string location)
        {
            Info = info;
            _instances.Add(this);
            Id = _instances.Count;
            Payment = payment;
            Date = date;
            Location = location;
        }

        public static List<Order> GetAll()
        {
            return _instances;
        }

        public static void ClearAll()
        {
           _instances.Clear();
        }

        public static Order Find(int searchId)
        {
            return _instances[searchId - 1];

        }
    }




}
