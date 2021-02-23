using System;
using SlithyToves.DataAccess;

namespace SlithyToves.Library.Models
{
    public class InventoryModel : ILog
    {
        public int StoreId { get; set; }
        public int ProductId { get; set; }
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
    }
}