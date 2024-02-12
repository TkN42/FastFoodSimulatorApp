using Library.Employee_;
using Library.Order;
using Library.Server_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Kitchen_
{
    public interface ICook
    {
        public Task PrepareOrderAsync(Chef orderTicket, Server server, int orderinterval);
    }
}
