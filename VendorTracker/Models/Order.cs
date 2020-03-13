using Systems.Collections.Generic;


namespace VendorTracker.Models 
{
    public class Order
    {
        public string Info { get; set; }
        public int Id { get; set; }
        private static List<Order> _instances = new List<Order> { };


        public Order(string info)
        {
            Info = info;
            _instances.Add(this);
            Id = _instances.Count;
        }

        public static List<Order> GetAll()
        {
            return _instances; 
        }

        public static void ClearAll()
        {
            return _instances.Clear();
        }

        public static Order Find(int searchId)
        {
            return _instances[searchId - 1];
            
        }
    }




}
