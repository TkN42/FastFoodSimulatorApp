using Library.Employee_;
using Library.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Server_
{
    public interface IServer
    {
        public Task ServeOrder(Chef orderTicket, int orderinterval);
    }
}
