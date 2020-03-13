using Systems.Collections.Generic;


namespace VendorTracker.Models 
{
    public class Vendor
    {
        private static List<Vendor> _instances = new List<Vendor> {};
        public string Representative { get; set; }
        public int Id { get; }
        public List<Order> Orders { get; set; }

        public Vendor(string Name)
        {
            Name = name;
            _instances.Add(this);
            Id = _instances.Count;
            Orders = new List<Order> { };
        }

        public static void ClearAll()
        {
            _instances.ClearAll();
        }

        public static List<Vendor> GetAll()
        {
            return _instances; 
        }

        public static Vendor Find(int searchId)
        {
            return _instances[searchId -1];
        }

        public void Add(Order order)
        {
            Orders.Add(order);
        }
    }
}
