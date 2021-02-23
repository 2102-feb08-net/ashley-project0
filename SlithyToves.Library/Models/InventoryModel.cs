using System;
using SlithyToves.DataAccess;

namespace SlithyToves.Library.Models
{
    public class InventoryModel : ILog
    {
        public int StoreId { get; private set; }
        public int ProductId { get; private set; }
        private int _onHand;

        public int OnHand 
        {
            get => _onHand;
            set
            {
                if (value <= 0)
                {
                    value = 0;
                }
                _onHand = OnHand;
            }
        }

        public string Log() => 
            $"StoreID: {StoreId}\tProductID: {ProductId}\tOn Hand: {OnHand}";

        
        public InventoryModel(int onHand, int storeId = 0, int productId = 0)
        {
            StoreId = storeId;
            ProductId = productId;
            OnHand = onHand;
        }
    }
}