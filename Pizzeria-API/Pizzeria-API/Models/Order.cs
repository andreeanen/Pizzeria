﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzeria_API.Models
{
    public enum Status {Submitted, Delivered, Cancelled};
    public class Order
    {
        public Guid Id { get; set; }
        public double TotalSum { get; set; }
        public Status Status { get; set; }
        public List<IProduct> Products { get; set; }
    }
}
