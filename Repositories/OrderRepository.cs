using ArtWebshop.Data;
using ArtWebshop.Models;
using ArtWebshop.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ArtWebshop.Repository
{
    public class OrderRepository : Repository<Order>
    {
        public OrderRepository(ProductDbContext context) : base(context)
        {
        }

        public override Order Update(Order entity)
        {
            var order = _productContext.Orders.Single(o => o.OrderId == entity.OrderId);

            order.UserId = entity.UserId;
            order.OrderDate = entity.OrderDate;
            order.CouponId = entity.CouponId;

            order.OrderRows = entity.OrderRows;

            order.BillingStreetName = entity.BillingStreetName;
            order.BillingCity = entity.BillingCity;
            order.BillingPostalCode = entity.BillingPostalCode;
            order.BillingCountry = entity.BillingCountry;

            order.DeliveryStreetName = entity.DeliveryStreetName;
            order.DeliveryCity = entity.DeliveryCity;
            order.DeliveryPostalCode = entity.DeliveryPostalCode;
            order.DeliveryCountry = entity.DeliveryCountry;
            
            return base.Update(order);
        }
    }
}
