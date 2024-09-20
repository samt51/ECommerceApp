using ECommerce.Shared.Bases.Commond;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderService.Domain.Entities
{
    public class OrderItem : BaseEntity
    {
        public int Id { get; set; }
        public int ProductId { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        public int OrderId { get; set; }

        public Order Order { get; set; }

        public int Count { get; set; }
    }
}
