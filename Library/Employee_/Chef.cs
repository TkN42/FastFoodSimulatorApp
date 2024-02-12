using Library.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Employee_;

public class Chef:Person
{
    public OrderTicket ticket { get; set; }

    public Chef(string Name) : base(Name)
    {
        this.Name = Name;
        IsWork = false;
    }
}
