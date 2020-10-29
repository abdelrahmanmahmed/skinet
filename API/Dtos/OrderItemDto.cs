using System;
namespace API.Dtos
{
    public class OrderItemDto
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public string PictureUrl { get; set; }

        public decimal Prcice { get; set; }

        public int Quantity { get; set; }
    }
}
