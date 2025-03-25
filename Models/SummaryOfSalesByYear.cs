using System;
using System.Collections.Generic;

namespace db_first.Models;

public partial class SummaryOfSalesByYear
{
    public DateTime? ShippedDate { get; set; }

    public int? OrderId { get; set; }

    public double? Subtotal { get; set; }
}
