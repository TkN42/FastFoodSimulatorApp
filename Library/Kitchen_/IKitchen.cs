using Library.Customer_;
using Library.Employee_;
using Library.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Kitchen_
{
    public interface IKitchen
    {
        public Task<OrderTicket> PlaceOrderAsync(Customer customer);
        public Task<Chef> GetNextOrderAsync(Chef chef);
    }
}
