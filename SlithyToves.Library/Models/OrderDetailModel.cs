using System;
using SlithyToves.DataAccess;

namespace SlithyToves.Library.Models
{
    public class OrderDetailModel : ILog
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
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
    }
}