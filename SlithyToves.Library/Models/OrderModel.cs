using System;
using SlithyToves.DataAccess;

namespace SlithyToves.Library.Models
{
    public class OrderModel : ILog
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public int StoreId { get; set; }
        private date _orderDate;
        private decimal _subtotal;

        #nullable enable
        public date OrderDate
        {
            if (value > DateTime.UtcNow.Date)
            {
                throw new ArgumentOutOfRangeException("Please enter a valid date.", nameof(value));
            }
            _orderDate = OrderDate;
        }

        #nullable enable
        public decimal Subtotal
        {
            if (value < 0) 
            {
                throw new ArgumentException("Please enter a valid subtotal or leave empty.", nameof(value));
            }
            _subtotal = Subtotal;
        }

        public string Log() => 
            $"OrderID: {OrderId}\tCustomerID: {CustomerId}\tStoreID: {StoreId}\tOrder Date: {OrderDate}\tSubtotal: {Subtotal}";
    }
}