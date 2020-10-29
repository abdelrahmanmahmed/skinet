using System;
namespace Core.Entities.OrderAggregate
{
    public class OrderItem : BaseEntity
    {
        public OrderItem()
        {
        }

        public OrderItem(ProductItemOrdered itemOrdered, decimal prcice, int quantity)
        {
            ItemOrdered = itemOrdered;
            Prcice = prcice;
            Quantity = quantity;
        }

        public ProductItemOrdered ItemOrdered { get; set; }

        public decimal Prcice { get; set; }

        public int Quantity { get; set; }
    }
}
