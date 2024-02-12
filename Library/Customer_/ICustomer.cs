using Library.Kitchen_;
using Library.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Customer_
{
    public interface ICustomer
    {
        public Task<OrderTicket> PlaceOrderAsync(Kitchen kitchen);
    }
}
