using System;
using System.Collections.Generic;

#nullable disable

namespace SlithyToves.DataAccess
{
    public partial class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int OrderId { get; private set; }
        public int CustomerId { get; private set; }
        public int StoreId { get; private set; }
        public DateTime? OrderDate { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Store Store { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
