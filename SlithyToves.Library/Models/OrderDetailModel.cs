using System;

namespace SlithyToves.Library.Models
{
    public class OrderDetailModel
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
    }
}