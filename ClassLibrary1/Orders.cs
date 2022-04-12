using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Domian
{
    public class Orders
    {
        public Orders(Customer customer)
        {
            Customer = customer;
            Date = DateTime.Now;
            Number = CreatNumber();
            OrderItems = new List<OrderItem>();
        }

        public Customer Customer { get; set; }
        public string Number { get; set; }
        public DateTime Date { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
        
        private string CreatNumber()
        {
            string str = string.Empty;
            str=new Random().Next(10000).ToString().PadLeft(5,'0');
            return str;
        }


        public double Total() 
        {

            var total = 0.0;
            foreach (var item in OrderItems)
            { 
                total+=item. SubTotal();

            }
            return total;   
        }
    }
}
