using ECommerce.Shared.Bases.Commond;
using ECommerce.Shared.Bases.Enums;

namespace OrderService.Domain.Entities
{
    public class Order : BaseEntity
    {
        public DateTime CreatedDate { get; set; }
        public string BuyerId { get; set; }

        public Address Address { get; set; }
        public ICollection<OrderItem> Items { get; set; } = new List<OrderItem>();

        public OrderStatusEnum Status { get; set; }

        public string FailMessage { get; set; }
    }
}
