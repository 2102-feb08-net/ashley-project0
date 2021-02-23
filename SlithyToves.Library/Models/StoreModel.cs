using System;
using SlithyToves.DataAccess;

namespace SlithyToves.Library.Models
{
    public class StoreModel : ILog
    {
        public int StoreId { get; set; }
        private string _storeName;

        public string StoreName 
        {
            get => _storeName;
            set
            {
                if (value.Length == 0) 
                {
                    throw new ArgumentException("Store name must not be empty.", nameof(value));
                }
                _storeName = value;
            }
        }

        public string Log() => 
            $"StoreID: {StoreId}\tStore Name: {StoreName}";
    }
}