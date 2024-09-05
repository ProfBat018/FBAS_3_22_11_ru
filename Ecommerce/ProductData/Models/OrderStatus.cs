using System;
using System.Collections.Generic;

namespace ProductData.Models;

public  class OrderStatus: INotTrackable
{
    public int StatusId { get; set; }

    public string StatusName { get; set; } = null!;
}
