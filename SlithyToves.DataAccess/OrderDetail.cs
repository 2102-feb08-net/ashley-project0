using System;
using System.Collections.Generic;

#nullable disable

namespace SlithyToves.DataAccess
{
    public partial class OrderDetail
    {
        public int OrderId { get; private set; }
        public int ProductId { get; private set; }
        public int Quantity { get; set; }

        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
