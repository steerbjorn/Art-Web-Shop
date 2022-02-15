using ArtWebshop.Data;
using ArtWebshop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtWebshop.Repositories
{
    public class ProductRepository : Repository<Product>
    {
        public ProductRepository(ProductDbContext context) :base(context)
        {
        }

        public override Product Update(Product entity)
        {
            var product = _productContext.Products.Single(p => p.ProductId == entity.ProductId);

            product.ArtistId = entity.ArtistId;
            product.Title = entity.Title;
            product.Width = entity.Width;
            product.Height = entity.Height;

            return base.Update(product);
        }
    }
}
