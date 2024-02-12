﻿using Library.Kitchen_;
using Library.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Customer_;

public class Customer : ICustomer
{
    public int CustomerNumber { get; private set; }

    public Customer(int customerNumber)
    {
        CustomerNumber = customerNumber;
    }

    public async Task<OrderTicket> PlaceOrderAsync(Kitchen kitchen)
    {
        var orderTicket = await kitchen.PlaceOrderAsync(this);
        return orderTicket;
    }
}
