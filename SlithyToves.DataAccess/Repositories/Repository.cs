using System;
using System.Linq;
using SlithyToves.DataAccess;
using SlithyToves.Library;

namespace SlithyToves.DataAccess
{
    public class Repository
    {
        private readonly SlithyTovesContext _dbContext;

        public Repository(SlithyTovesContext context) 
        {
            _dbContext = context ?? throw new ArgumentException(nameof(context));
        }

        public List<Library.Models.CustomerModel> GetAllCustomers()
        {
            var customers = new List<SlithyToves.Library.Models.CustomerModel>();
            return 
        }

    }
}