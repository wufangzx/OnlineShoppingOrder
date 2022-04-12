using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Domian
{
    public class OrderItem
    {



     private Orders _order;

     public OrderItem(Orders ords,Product pd)
    {
            _Order = ords;
            Product = pd;
    
    }
        public Orders _Order
    {
            get
            {
                return _order;
            }
             set
            {
            _order = value;
            _order.OrderItems.Add(this);
            }
    }  
       
        public Product Product
        { 
            get; 
            set;
        }
   
        public double count
        {
            set;
            get;
 
        }
        public double SubTotal()
        {
            return Product.Price *count;
        }    
            
    }
}
