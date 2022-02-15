using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtWebshop.Data
{
    public class ContextSelector<T>
    {
        private readonly AppDbContext _appDbContext;
        private readonly ProductDbContext _productDbContext;

        public ContextSelector(AppDbContext appDbContext, ProductDbContext productDbContext)
        {
            _appDbContext = appDbContext;
            _productDbContext = productDbContext;
        }
        public T Get(T context)
        {

            return context;
        }
    }
}
