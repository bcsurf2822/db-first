using System;
using System.Collections.Generic;

namespace db_first.Models;

public partial class OrderSubtotal
{
    public int? OrderId { get; set; }

    public double? Subtotal { get; set; }
}
