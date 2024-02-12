﻿using Library.Employee_;
using Library.Order;
using Library.Server_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Kitchen_;

public class Cook : ICook
{
    public event EventHandler<Message> StringReturned;
    public async Task PrepareOrderAsync(Chef orderTicket, Server server, int orderinterval)
    {
        await Task.Delay(orderinterval); // Simulate order preparation time
        Console.WriteLine($"Cook finished preparing Order {orderTicket.ticket}.");
        StringReturned?.Invoke(this, new Message("Cook", $"Cook finished preparing Order {orderTicket.ticket.OrderNumber}."));
        server.ServeOrder(orderTicket, orderinterval);
    }
}
