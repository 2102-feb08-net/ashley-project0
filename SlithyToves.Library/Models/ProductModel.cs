using System;

namespace SlithyToves.Library.Models
{
    public class ProductModel : ILog
    {
        public int ProductId { get; private set; }
        private string _productName;
        private decimal _unitPrice;

        public string ProductName 
        {
            get => _productName;
            set
            {
                if (value.Length == 0) 
                {
                    throw new ArgumentException("Product name must not be empty.", nameof(value));
                }
                _productName = value;
            }
        }

        public decimal UnitPrice
        {
            get => _unitPrice;
            set
            {
                if (value <= 0) 
                {
                    throw new ArgumentException("Please enter a valid price.", nameof(value));
                }
                _unitPrice = UnitPrice;
            }
        }

        public string Log() => 
            $"ProductID: {ProductId}\tProduct Name: {ProductName}tUnit Price: {UnitPrice}";


        public ProductModel(string productName, int productId = 0)
        {
            ProductId = productId;
            ProductName = productName;
        }

        public ProductModel(string productName, decimal unitPrice, int productId = 0)
        {
            ProductId = productId;
            ProductName = productName;
            UnitPrice = unitPrice;
        }
    }
}