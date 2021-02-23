using System;

namespace SlithyToves.DataAccess
{
    public class Repository
    {
        private readonly SlithyTovesContext _dbContext;

        public Repository(SlithyTovesContext context) 
        {
            _dbContext = context ?? throw new ArgumentException(nameof(context));
        }

    }
}