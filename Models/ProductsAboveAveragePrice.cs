using System;
using System.Collections.Generic;

namespace db_first.Models;

public partial class ProductsAboveAveragePrice
{
    public string? ProductName { get; set; }

    public double? UnitPrice { get; set; }
}
