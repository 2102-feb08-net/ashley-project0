using System;
using System.Collections.Generic;

#nullable disable

namespace SlithyToves.DataAccess
{
    public partial class Inventory
    {
        public int StoreId { get; private set; }
        public int ProductId { get; private set; }
        public int OnHand { get; set; }

        public virtual Product Product { get; set; }
        public virtual Store Store { get; set; }
    }
}
