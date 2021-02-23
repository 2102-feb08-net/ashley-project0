using System;
using SlithyToves.DataAccess;

namespace SlithyToves.Library.Models
{
    public class OrderDetailModel : ILog
    {
        public int OrderId { get; private set; }
        public int ProductId { get; private set; }
        private int _quantity;

        public int Quantity
        {
            get => _quantity;
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                _quantity = Quantity;
            }
        }

        public string Log() => 
            $"OrderID: {OrderId}\tProductID: {ProductId}\tQuantity: {Quantity}";


        public OrderDetailModel(int quantity, int orderId = 0, int productId = 0)
        {
            OrderId = orderId;
            ProductId = productId; 
            Quantity = quantity; 
        }
    }
}