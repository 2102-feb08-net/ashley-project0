using System;

namespace SlithyToves.Library.Models
{
    public class OrderModel : ILog
    {
        public int OrderId { get; private set; }
        public int CustomerId { get; private set; }
        public int StoreId { get; private set; }
        private DateTime _orderDate;
        private decimal _subtotal;

        #nullable enable
        public DateTime OrderDate
        {
            get => _orderDate;
            set
            {
                if (value > DateTime.UtcNow.Date)
                {
                    throw new ArgumentOutOfRangeException("Please enter a valid date.", nameof(value));
                }
                _orderDate = OrderDate;
            }
        }

        #nullable enable
        public decimal Subtotal
        {
            get => _subtotal;
            set 
            {
                if (value < 0) 
                {
                    throw new ArgumentException("Please enter a valid subtotal or leave empty.", nameof(value));
                }
                _subtotal = Subtotal;
            }
        }

        public string Log() => 
            $"OrderID: {OrderId}\tCustomerID: {CustomerId}\tStoreID: {StoreId}\tOrder Date: {OrderDate}\tSubtotal: {Subtotal}";


        public OrderModel(int orderId = 0, int customerId = 0, int storeId = 0)
        {
            OrderId = orderId;
            CustomerId = customerId;
            StoreId = storeId;
        }

        public OrderModel(DateTime orderDate, decimal subtotal, int orderId = 0, int customerId = 0, int storeId = 0)
        {
            OrderId = orderId;
            CustomerId = customerId;
            StoreId = storeId;
            OrderDate = orderDate;
            Subtotal = subtotal;
        }
    }
}